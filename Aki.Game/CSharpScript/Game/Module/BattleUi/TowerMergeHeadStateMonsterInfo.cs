using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA5 RID: 23717
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerMergeHeadStateMonsterInfo
	{
		// Token: 0x0603BEB7 RID: 245431 RVA: 0x00E51634 File Offset: 0x00E4F834
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

		// Token: 0x0603BEB8 RID: 245432 RVA: 0x00E51710 File Offset: 0x00E4F910
		public void RemoveListener()
		{
			if (this.AttributeComponent != null)
			{
				this.AttributeComponent.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
				this.AttributeComponent.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthMaxChanged));
				this.AttributeComponent = null;
			}
		}

		// Token: 0x0603BEB9 RID: 245433 RVA: 0x00E5175E File Offset: 0x00E4F95E
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.Hp == newValue)
			{
				return;
			}
			this.Hp = newValue;
			BattleUiModel.Instance.TowerMergeHeadStateData.OnMonsterHpChanged(this.MonsterInfoId);
		}

		// Token: 0x0603BEBA RID: 245434 RVA: 0x00E51786 File Offset: 0x00E4F986
		private void OnHealthMaxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.HpMax == newValue)
			{
				return;
			}
			this.HpMax = newValue;
			BattleUiModel.Instance.TowerMergeHeadStateData.OnMonsterHpChanged(this.MonsterInfoId);
		}

		// Token: 0x0401F44A RID: 128074
		public int MonsterInfoId;

		// Token: 0x0401F44B RID: 128075
		public long CreatureDataId;

		// Token: 0x0401F44C RID: 128076
		public EntityHandle EntityHandle;

		// Token: 0x0401F44D RID: 128077
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x0401F44E RID: 128078
		public float Hp;

		// Token: 0x0401F44F RID: 128079
		public float HpMax;
	}
}
