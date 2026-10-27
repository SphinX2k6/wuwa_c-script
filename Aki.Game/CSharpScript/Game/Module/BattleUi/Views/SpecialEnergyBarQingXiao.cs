using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DFA RID: 24058
	public class SpecialEnergyBarQingXiao : SpecialEnergyBarBase
	{
		// Token: 0x0603D286 RID: 250502 RVA: 0x00EBA9E4 File Offset: 0x00EB8BE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D287 RID: 250503 RVA: 0x00EBAC23 File Offset: 0x00EB8E23
		protected override void OnInitData()
		{
			this.MorphPercentMachine.Init(this.GetMorphTargetAttributePercent());
		}

		// Token: 0x0603D288 RID: 250504 RVA: 0x00EBAC38 File Offset: 0x00EB8E38
		protected float GetAttributePercent(EAttributeType attrId, EAttributeType maxAttrId)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(attrId);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(maxAttrId);
			float result = 0f;
			if (currentValue2 > 0f)
			{
				result = currentValue / currentValue2;
			}
			return result;
		}

		// Token: 0x0603D289 RID: 250505 RVA: 0x00EBAC72 File Offset: 0x00EB8E72
		protected float GetQinTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.QIN_ATTR_ID, SpecialEnergyBarQingXiao.MAX_QIN_ATTR_ID);
		}

		// Token: 0x0603D28A RID: 250506 RVA: 0x00EBAC84 File Offset: 0x00EB8E84
		protected float GetJianTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.JIAN_ATTR_ID, SpecialEnergyBarQingXiao.MAX_JIAN_ATTR_ID);
		}

		// Token: 0x0603D28B RID: 250507 RVA: 0x00EBAC96 File Offset: 0x00EB8E96
		protected float GetMorphTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.MORPH_ATTR_ID, SpecialEnergyBarQingXiao.MAX_MORPH_ATTR_ID);
		}

		// Token: 0x0603D28C RID: 250508 RVA: 0x00EBACA8 File Offset: 0x00EB8EA8
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinOrMorphPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.MAX_QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinOrMorphPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.MAX_JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQingXiao.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		}

		// Token: 0x0603D28D RID: 250509 RVA: 0x00EBAD2E File Offset: 0x00EB8F2E
		private void OnQinOrMorphPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.CurState == SpecialEnergyBarQingXiao.EState.Normal)
			{
				this.OnQinPercentChange(attributeId, newValue, oldValue);
				return;
			}
			this.OnMorphPercentChange(attributeId, newValue, oldValue);
		}

		// Token: 0x0603D28E RID: 250510 RVA: 0x00EBAD4C File Offset: 0x00EB8F4C
		private void OnQinPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			float qinTargetAttributePercent = this.GetQinTargetAttributePercent();
			this.IsQinEnergyFull = (qinTargetAttributePercent >= 1f);
			this.RefreshNormalBarStyle(false);
		}

		// Token: 0x0603D28F RID: 250511 RVA: 0x00EBAD78 File Offset: 0x00EB8F78
		private void OnJianPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			float jianTargetAttributePercent = this.GetJianTargetAttributePercent();
			this.IsJianEnergyFull = (jianTargetAttributePercent >= 1f);
			this.RefreshNormalBarStyle(false);
		}

		// Token: 0x0603D290 RID: 250512 RVA: 0x00EBADA4 File Offset: 0x00EB8FA4
		private void OnMorphPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			float morphTargetAttributePercent = this.GetMorphTargetAttributePercent();
			this.SetMorphScaleVisible(morphTargetAttributePercent > 0f && morphTargetAttributePercent < 1f);
			this.SetMorphMaxNiaVisible(morphTargetAttributePercent >= 1f);
			SpecialEnergyBarKeyItem morphKeyItem = this.MorphKeyItem;
			if (morphKeyItem != null)
			{
				morphKeyItem.RefreshKeyEnable(morphTargetAttributePercent >= 1f, false);
			}
			this.MorphPercentMachine.SetTargetPercent(morphTargetAttributePercent);
			this.UpdateMorphBarPercent();
		}

		// Token: 0x0603D291 RID: 250513 RVA: 0x00EBAE14 File Offset: 0x00EB9014
		private void SetMorphScaleVisible(bool visible)
		{
			bool? morphScaleVisible = this.MorphScaleVisible;
			if (morphScaleVisible.GetValueOrDefault() == visible & morphScaleVisible != null)
			{
				return;
			}
			this.MorphScaleVisible = new bool?(visible);
			if (visible)
			{
				base.StopTweenAnim(11);
				base.PlayTweenAnim(10);
				return;
			}
			base.StopTweenAnim(10);
			base.PlayTweenAnim(11);
		}

		// Token: 0x0603D292 RID: 250514 RVA: 0x00EBAE70 File Offset: 0x00EB9070
		private void SetMorphMaxNiaVisible(bool visible)
		{
			bool? morphMaxNiaVisible = this.MorphMaxNiaVisible;
			if (morphMaxNiaVisible.GetValueOrDefault() == visible & morphMaxNiaVisible != null)
			{
				return;
			}
			this.MorphMaxNiaVisible = new bool?(visible);
			if (visible)
			{
				base.PlayTweenAnim(12);
				return;
			}
			base.PlayTweenAnim(15);
		}

		// Token: 0x0603D293 RID: 250515 RVA: 0x00EBAEBB File Offset: 0x00EB90BB
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQingXiao.EState.Morph : SpecialEnergyBarQingXiao.EState.Normal);
		}

		// Token: 0x0603D294 RID: 250516 RVA: 0x00EBAECC File Offset: 0x00EB90CC
		private void RefreshNormalBarStyle(bool isStart = false)
		{
			if (isStart)
			{
				this.IsQinEnergyFull = (this.GetQinTargetAttributePercent() >= 1f);
				this.IsJianEnergyFull = (this.GetJianTargetAttributePercent() >= 1f);
			}
			bool flag = this.IsJianEnergyFull && this.IsQinEnergyFull;
			if (this.IsLastNormalEnergyFull == flag)
			{
				return;
			}
			if (flag)
			{
				base.PlayTweenAnim(7);
			}
			else
			{
				base.StopTweenAnim(7);
				base.GetItem(3).SetUIActive(false);
				base.GetItem(2).SetAlpha(1f);
				base.GetItem(2).SetUIActive(true);
			}
			SpecialEnergyBarQingXiaoSlot normalBarSlotItem = this.NormalBarSlotItem;
			if (normalBarSlotItem != null)
			{
				normalBarSlotItem.SetKeyEnable(flag);
			}
			this.IsLastNormalEnergyFull = flag;
		}

		// Token: 0x0603D295 RID: 250517 RVA: 0x00EBAF7C File Offset: 0x00EB917C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQingXiao.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D296 RID: 250518 RVA: 0x00EBAFC0 File Offset: 0x00EB91C0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQingXiao.<InitBarItem>d__34 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<InitBarItem>d__34>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D297 RID: 250519 RVA: 0x00EBB004 File Offset: 0x00EB9204
		protected UniTask InitMorphKeyItem()
		{
			SpecialEnergyBarQingXiao.<InitMorphKeyItem>d__35 <InitMorphKeyItem>d__;
			<InitMorphKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMorphKeyItem>d__.<>4__this = this;
			<InitMorphKeyItem>d__.<>1__state = -1;
			<InitMorphKeyItem>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<InitMorphKeyItem>d__35>(ref <InitMorphKeyItem>d__);
			return <InitMorphKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D298 RID: 250520 RVA: 0x00EBB048 File Offset: 0x00EB9248
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(15);
			this.RefreshState();
			this.UpdateMorphBarPercent();
			this.RefreshNormalBarStyle(true);
			SpecialEnergyBarKeyItem morphKeyItem = this.MorphKeyItem;
			if (morphKeyItem == null)
			{
				return;
			}
			morphKeyItem.RefreshKeyEnable(this.GetMorphTargetAttributePercent() >= 1f, true);
		}

		// Token: 0x0603D299 RID: 250521 RVA: 0x00EBB0BF File Offset: 0x00EB92BF
		private void RefreshState()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarQingXiao.MorphTagId))
			{
				this.SetState(SpecialEnergyBarQingXiao.EState.Morph);
				return;
			}
			this.SetState(SpecialEnergyBarQingXiao.EState.Normal);
		}

		// Token: 0x0603D29A RID: 250522 RVA: 0x00EBB0EC File Offset: 0x00EB92EC
		private void SetState(SpecialEnergyBarQingXiao.EState state)
		{
			if (this.CurState == state)
			{
				return;
			}
			if (state != SpecialEnergyBarQingXiao.EState.Normal)
			{
				if (state == SpecialEnergyBarQingXiao.EState.Morph)
				{
					if (this.CurState != SpecialEnergyBarQingXiao.EState.Max)
					{
						base.StopTweenAnim(9);
					}
					base.PlayTweenAnim(8);
					base.GetUiNiagara(13).SetUIActive(true);
					base.GetUiNiagara(14).SetUIActive(true);
					this.UpdateMorphBarPercent();
					SpecialEnergyBarKeyItem morphKeyItem = this.MorphKeyItem;
					if (morphKeyItem != null)
					{
						morphKeyItem.RefreshKeyEnable(this.GetMorphTargetAttributePercent() >= 1f, false);
					}
				}
			}
			else
			{
				if (this.CurState != SpecialEnergyBarQingXiao.EState.Max)
				{
					base.StopTweenAnim(8);
				}
				base.PlayTweenAnim(9);
				base.GetUiNiagara(13).SetUIActive(false);
				base.GetUiNiagara(14).SetUIActive(false);
				this.RefreshNormalBarStyle(false);
			}
			base.GetItem(6).SetUIActive(state == SpecialEnergyBarQingXiao.EState.Morph);
			this.CurState = state;
		}

		// Token: 0x0603D29B RID: 250523 RVA: 0x00EBB1C0 File Offset: 0x00EB93C0
		private void UpdateMorphBarPercent()
		{
			float curPercent = this.MorphPercentMachine.GetCurPercent();
			base.GetSlider(5).SetValue(curPercent, true);
			base.GetUiNiagara(13).SetNiagaraVarFloat("Dissolve", 1f - curPercent);
			base.GetUiNiagara(14).SetNiagaraVarFloat("Dissolve", curPercent);
		}

		// Token: 0x0603D29C RID: 250524 RVA: 0x00EBB213 File Offset: 0x00EB9413
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarQingXiaoSlot normalBarSlotItem = this.NormalBarSlotItem;
			if (normalBarSlotItem != null)
			{
				normalBarSlotItem.Tick(delta);
			}
			if (this.MorphPercentMachine.Update(delta))
			{
				this.UpdateMorphBarPercent();
			}
		}

		// Token: 0x0401FE2A RID: 130602
		[StaticVariableRuleIgnore]
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.状态标识.剑仙状态"];

		// Token: 0x0401FE2B RID: 130603
		private static readonly EAttributeType QIN_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401FE2C RID: 130604
		private static readonly EAttributeType MAX_QIN_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401FE2D RID: 130605
		private static readonly EAttributeType JIAN_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FE2E RID: 130606
		private static readonly EAttributeType MAX_JIAN_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FE2F RID: 130607
		private static readonly EAttributeType MORPH_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401FE30 RID: 130608
		private static readonly EAttributeType MAX_MORPH_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401FE31 RID: 130609
		[Nullable(1)]
		private readonly SpecialEnergyBarPercentMachine MorphPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FE32 RID: 130610
		[Nullable(2)]
		private SpecialEnergyBarQingXiaoSlot NormalBarSlotItem;

		// Token: 0x0401FE33 RID: 130611
		[Nullable(2)]
		private SpecialEnergyBarKeyItem MorphKeyItem;

		// Token: 0x0401FE34 RID: 130612
		private bool IsQinEnergyFull;

		// Token: 0x0401FE35 RID: 130613
		private bool IsJianEnergyFull;

		// Token: 0x0401FE36 RID: 130614
		private bool IsLastNormalEnergyFull;

		// Token: 0x0401FE37 RID: 130615
		private SpecialEnergyBarQingXiao.EState CurState = SpecialEnergyBarQingXiao.EState.Max;

		// Token: 0x0401FE38 RID: 130616
		private bool? MorphScaleVisible;

		// Token: 0x0401FE39 RID: 130617
		private bool? MorphMaxNiaVisible;

		// Token: 0x0200C141 RID: 49473
		private enum EChildType
		{
			// Token: 0x0403A5ED RID: 239085
			PnlStateA,
			// Token: 0x0403A5EE RID: 239086
			SlotBarItem,
			// Token: 0x0403A5EF RID: 239087
			PnlNml,
			// Token: 0x0403A5F0 RID: 239088
			PnlAct,
			// Token: 0x0403A5F1 RID: 239089
			PnlStateB,
			// Token: 0x0403A5F2 RID: 239090
			SldBar,
			// Token: 0x0403A5F3 RID: 239091
			PnlHotKey,
			// Token: 0x0403A5F4 RID: 239092
			AnimAMax,
			// Token: 0x0403A5F5 RID: 239093
			AnimA2B,
			// Token: 0x0403A5F6 RID: 239094
			AnimB2A,
			// Token: 0x0403A5F7 RID: 239095
			AnimDGlowIn,
			// Token: 0x0403A5F8 RID: 239096
			AnimDGlowOut,
			// Token: 0x0403A5F9 RID: 239097
			AnimBMax,
			// Token: 0x0403A5FA RID: 239098
			NiaGre,
			// Token: 0x0403A5FB RID: 239099
			NiaBlu,
			// Token: 0x0403A5FC RID: 239100
			AnimBMax2B
		}

		// Token: 0x0200C142 RID: 49474
		private enum EState
		{
			// Token: 0x0403A5FE RID: 239102
			Normal,
			// Token: 0x0403A5FF RID: 239103
			Morph,
			// Token: 0x0403A600 RID: 239104
			Max
		}
	}
}
