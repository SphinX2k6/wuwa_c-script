using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C94 RID: 23700
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeHeadStateMonsterInfo
	{
		// Token: 0x0603BDAE RID: 245166 RVA: 0x00E4BB10 File Offset: 0x00E49D10
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

		// Token: 0x0603BDAF RID: 245167 RVA: 0x00E4BC84 File Offset: 0x00E49E84
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

		// Token: 0x0603BDB0 RID: 245168 RVA: 0x00E4BCE7 File Offset: 0x00E49EE7
		private void OnFightTagChanged(int tagId, bool bTagExists)
		{
			if (this.HasFightTag == bTagExists)
			{
				return;
			}
			this.HasFightTag = bTagExists;
			BattleUiModel.Instance.MergeHeadStateData.OnMonsterFightTagChange(this.Id, bTagExists);
		}

		// Token: 0x0603BDB1 RID: 245169 RVA: 0x00E4BD10 File Offset: 0x00E49F10
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

		// Token: 0x0603BDB2 RID: 245170 RVA: 0x00E4BD68 File Offset: 0x00E49F68
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

		// Token: 0x0401F35A RID: 127834
		public int Id;

		// Token: 0x0401F35B RID: 127835
		public int PbDataId;

		// Token: 0x0401F35C RID: 127836
		public EntityHandle EntityHandle;

		// Token: 0x0401F35D RID: 127837
		public bool IsDead;

		// Token: 0x0401F35E RID: 127838
		public float BaseLife;

		// Token: 0x0401F35F RID: 127839
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x0401F360 RID: 127840
		public ITagTask FightTagListenTask;

		// Token: 0x0401F361 RID: 127841
		public bool HasFightTag;

		// Token: 0x0401F362 RID: 127842
		public float Hp;

		// Token: 0x0401F363 RID: 127843
		public float HpMax;
	}
}
