using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C87 RID: 19591
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerMergeHeadStateMonsterInfo
	{
		// Token: 0x06030E0A RID: 200202 RVA: 0x00DA1CDC File Offset: 0x00D9FEDC
		public bool AddListener()
		{
			if (this.AttributeComponent != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "[Tower合并怪物血条]重复添加监听";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.EntityHandle.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.RemoveListener();
			}
			this.AttributeComponent = this.EntityHandle.Entity.GetComponent<BaseAttributeComponent>();
			if (this.AttributeComponent == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "[Tower合并怪物血条]监听的实体不存在AttributeComponent";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", this.EntityHandle.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.AttributeComponent.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
			this.AttributeComponent.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthMaxChanged), null);
			return true;
		}

		// Token: 0x06030E0B RID: 200203 RVA: 0x00DA1DB8 File Offset: 0x00D9FFB8
		public void RemoveListener()
		{
			if (this.AttributeComponent != null)
			{
				this.AttributeComponent.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
				this.AttributeComponent.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthMaxChanged));
				this.AttributeComponent = null;
			}
		}

		// Token: 0x06030E0C RID: 200204 RVA: 0x00DA1E06 File Offset: 0x00DA0006
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.Hp == newValue)
			{
				return;
			}
			this.Hp = newValue;
			BattleUiModel.Instance.TowerMergeHeadStateData.OnMonsterHpChanged(this.MonsterInfoId);
		}

		// Token: 0x06030E0D RID: 200205 RVA: 0x00DA1E2E File Offset: 0x00DA002E
		private void OnHealthMaxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.HpMax == newValue)
			{
				return;
			}
			this.HpMax = newValue;
			BattleUiModel.Instance.TowerMergeHeadStateData.OnMonsterHpChanged(this.MonsterInfoId);
		}

		// Token: 0x04019F03 RID: 106243
		public int MonsterInfoId;

		// Token: 0x04019F04 RID: 106244
		public long CreatureDataId;

		// Token: 0x04019F05 RID: 106245
		public EntityHandle EntityHandle;

		// Token: 0x04019F06 RID: 106246
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x04019F07 RID: 106247
		public float Hp;

		// Token: 0x04019F08 RID: 106248
		public float HpMax;
	}
}
