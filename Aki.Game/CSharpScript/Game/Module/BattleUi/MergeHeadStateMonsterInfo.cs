using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C76 RID: 19574
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeHeadStateMonsterInfo
	{
		// Token: 0x06030D01 RID: 199937 RVA: 0x00D9C104 File Offset: 0x00D9A304
		public bool AddListener()
		{
			if (this.FightTagListenTask != null || this.AttributeComponent != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "合并怪物血条重复添加进战监听";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.EntityHandle.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.RemoveListener();
			}
			BaseTagComponent component = this.EntityHandle.Entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "合并怪物血条监听的实体不存在tagComponent";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", this.EntityHandle.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.AttributeComponent = this.EntityHandle.Entity.GetComponent<BaseAttributeComponent>();
			if (this.AttributeComponent == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.CFT;
				string message3 = "合并怪物血条监听的实体不存在AttributeComponent";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("entityId", this.EntityHandle.Id);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			this.FightTagListenTask = component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new BaseTagComponent.TTagSwitchedCallback(this.OnFightTagChanged), null);
			this.HasFightTag = component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			attributeComponent.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
			attributeComponent.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthMaxChanged), null);
			return true;
		}

		// Token: 0x06030D02 RID: 199938 RVA: 0x00D9C278 File Offset: 0x00D9A478
		public void RemoveListener()
		{
			if (this.FightTagListenTask != null)
			{
				this.FightTagListenTask.EndTask();
				this.FightTagListenTask = null;
			}
			if (this.AttributeComponent != null)
			{
				BaseAttributeComponent attributeComponent = this.AttributeComponent;
				attributeComponent.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
				attributeComponent.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthMaxChanged));
				this.AttributeComponent = null;
			}
		}

		// Token: 0x06030D03 RID: 199939 RVA: 0x00D9C2DB File Offset: 0x00D9A4DB
		private void OnFightTagChanged(int tagId, bool bTagExists)
		{
			if (this.HasFightTag == bTagExists)
			{
				return;
			}
			this.HasFightTag = bTagExists;
			BattleUiModel.Instance.MergeHeadStateData.OnMonsterFightTagChange(this.Id, bTagExists);
		}

		// Token: 0x06030D04 RID: 199940 RVA: 0x00D9C304 File Offset: 0x00D9A504
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			float hp = this.Hp;
			this.Hp = newValue;
			if (this.HpMax <= 0f)
			{
				return;
			}
			float hpChange = (this.Hp - hp) / this.HpMax * this.BaseLife;
			BattleUiModel.Instance.MergeHeadStateData.OnMonsterHealthChange(this.Id, hpChange);
		}

		// Token: 0x06030D05 RID: 199941 RVA: 0x00D9C35C File Offset: 0x00D9A55C
		private void OnHealthMaxChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			float hpMax = this.HpMax;
			this.HpMax = newValue;
			float num = 0f;
			if (hpMax > 0f)
			{
				num = this.Hp / hpMax;
			}
			float num2 = 0f;
			if (this.HpMax > 0f)
			{
				num2 = this.Hp / this.HpMax;
			}
			float hpChange = (num2 - num) * this.BaseLife;
			BattleUiModel.Instance.MergeHeadStateData.OnMonsterHealthChange(this.Id, hpChange);
		}

		// Token: 0x04019E13 RID: 106003
		public int Id;

		// Token: 0x04019E14 RID: 106004
		public int PbDataId;

		// Token: 0x04019E15 RID: 106005
		public EntityHandle EntityHandle;

		// Token: 0x04019E16 RID: 106006
		public bool IsDead;

		// Token: 0x04019E17 RID: 106007
		public float BaseLife;

		// Token: 0x04019E18 RID: 106008
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x04019E19 RID: 106009
		public ITagTask FightTagListenTask;

		// Token: 0x04019E1A RID: 106010
		public bool HasFightTag;

		// Token: 0x04019E1B RID: 106011
		public float Hp;

		// Token: 0x04019E1C RID: 106012
		public float HpMax;
	}
}
