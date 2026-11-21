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
	// Token: 0x02004DDF RID: 19935
	public class SpecialEnergyBarQingXiao : SpecialEnergyBarBase
	{
		// Token: 0x06032215 RID: 205333 RVA: 0x00E0BF30 File Offset: 0x00E0A130
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

		// Token: 0x06032216 RID: 205334 RVA: 0x00E0C16F File Offset: 0x00E0A36F
		protected override void OnInitData()
		{
			this.MorphPercentMachine.Init(this.GetMorphTargetAttributePercent());
		}

		// Token: 0x06032217 RID: 205335 RVA: 0x00E0C184 File Offset: 0x00E0A384
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

		// Token: 0x06032218 RID: 205336 RVA: 0x00E0C1BE File Offset: 0x00E0A3BE
		protected float GetQinTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.QIN_ATTR_ID, SpecialEnergyBarQingXiao.MAX_QIN_ATTR_ID);
		}

		// Token: 0x06032219 RID: 205337 RVA: 0x00E0C1D0 File Offset: 0x00E0A3D0
		protected float GetJianTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.JIAN_ATTR_ID, SpecialEnergyBarQingXiao.MAX_JIAN_ATTR_ID);
		}

		// Token: 0x0603221A RID: 205338 RVA: 0x00E0C1E2 File Offset: 0x00E0A3E2
		protected float GetMorphTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiao.MORPH_ATTR_ID, SpecialEnergyBarQingXiao.MAX_MORPH_ATTR_ID);
		}

		// Token: 0x0603221B RID: 205339 RVA: 0x00E0C1F4 File Offset: 0x00E0A3F4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinOrMorphPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.MAX_QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinOrMorphPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiao.MAX_JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQingXiao.MorphTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		}

		// Token: 0x0603221C RID: 205340 RVA: 0x00E0C27A File Offset: 0x00E0A47A
		private void OnQinOrMorphPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (this.CurState == SpecialEnergyBarQingXiao.EState.Normal)
			{
				this.OnQinPercentChange(attributeId, newValue, oldValue);
				return;
			}
			this.OnMorphPercentChange(attributeId, newValue, oldValue);
		}

		// Token: 0x0603221D RID: 205341 RVA: 0x00E0C298 File Offset: 0x00E0A498
		private void OnQinPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			float qinTargetAttributePercent = this.GetQinTargetAttributePercent();
			this.IsQinEnergyFull = (qinTargetAttributePercent >= 1f);
			this.RefreshNormalBarStyle(false);
		}

		// Token: 0x0603221E RID: 205342 RVA: 0x00E0C2C4 File Offset: 0x00E0A4C4
		private void OnJianPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			float jianTargetAttributePercent = this.GetJianTargetAttributePercent();
			this.IsJianEnergyFull = (jianTargetAttributePercent >= 1f);
			this.RefreshNormalBarStyle(false);
		}

		// Token: 0x0603221F RID: 205343 RVA: 0x00E0C2F0 File Offset: 0x00E0A4F0
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

		// Token: 0x06032220 RID: 205344 RVA: 0x00E0C360 File Offset: 0x00E0A560
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

		// Token: 0x06032221 RID: 205345 RVA: 0x00E0C3BC File Offset: 0x00E0A5BC
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

		// Token: 0x06032222 RID: 205346 RVA: 0x00E0C407 File Offset: 0x00E0A607
		private void OnMorphTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQingXiao.EState.Morph : SpecialEnergyBarQingXiao.EState.Normal);
		}

		// Token: 0x06032223 RID: 205347 RVA: 0x00E0C418 File Offset: 0x00E0A618
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

		// Token: 0x06032224 RID: 205348 RVA: 0x00E0C4C8 File Offset: 0x00E0A6C8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQingXiao.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032225 RID: 205349 RVA: 0x00E0C50C File Offset: 0x00E0A70C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQingXiao.<InitBarItem>d__34 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<InitBarItem>d__34>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032226 RID: 205350 RVA: 0x00E0C550 File Offset: 0x00E0A750
		protected UniTask InitMorphKeyItem()
		{
			SpecialEnergyBarQingXiao.<InitMorphKeyItem>d__35 <InitMorphKeyItem>d__;
			<InitMorphKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMorphKeyItem>d__.<>4__this = this;
			<InitMorphKeyItem>d__.<>1__state = -1;
			<InitMorphKeyItem>d__.<>t__builder.Start<SpecialEnergyBarQingXiao.<InitMorphKeyItem>d__35>(ref <InitMorphKeyItem>d__);
			return <InitMorphKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032227 RID: 205351 RVA: 0x00E0C594 File Offset: 0x00E0A794
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

		// Token: 0x06032228 RID: 205352 RVA: 0x00E0C60B File Offset: 0x00E0A80B
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

		// Token: 0x06032229 RID: 205353 RVA: 0x00E0C638 File Offset: 0x00E0A838
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

		// Token: 0x0603222A RID: 205354 RVA: 0x00E0C70C File Offset: 0x00E0A90C
		private void UpdateMorphBarPercent()
		{
			float curPercent = this.MorphPercentMachine.GetCurPercent();
			base.GetSlider(5).SetValue(curPercent, true);
			base.GetUiNiagara(13).SetNiagaraVarFloat("Dissolve", 1f - curPercent);
			base.GetUiNiagara(14).SetNiagaraVarFloat("Dissolve", curPercent);
		}

		// Token: 0x0603222B RID: 205355 RVA: 0x00E0C75F File Offset: 0x00E0A95F
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

		// Token: 0x0401A8F1 RID: 108785
		[StaticVariableRuleIgnore]
		private static readonly int MorphTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.状态标识.剑仙状态"];

		// Token: 0x0401A8F2 RID: 108786
		private static readonly EAttributeType QIN_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401A8F3 RID: 108787
		private static readonly EAttributeType MAX_QIN_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401A8F4 RID: 108788
		private static readonly EAttributeType JIAN_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A8F5 RID: 108789
		private static readonly EAttributeType MAX_JIAN_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A8F6 RID: 108790
		private static readonly EAttributeType MORPH_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401A8F7 RID: 108791
		private static readonly EAttributeType MAX_MORPH_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401A8F8 RID: 108792
		[Nullable(1)]
		private readonly SpecialEnergyBarPercentMachine MorphPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A8F9 RID: 108793
		[Nullable(2)]
		private SpecialEnergyBarQingXiaoSlot NormalBarSlotItem;

		// Token: 0x0401A8FA RID: 108794
		[Nullable(2)]
		private SpecialEnergyBarKeyItem MorphKeyItem;

		// Token: 0x0401A8FB RID: 108795
		private bool IsQinEnergyFull;

		// Token: 0x0401A8FC RID: 108796
		private bool IsJianEnergyFull;

		// Token: 0x0401A8FD RID: 108797
		private bool IsLastNormalEnergyFull;

		// Token: 0x0401A8FE RID: 108798
		private SpecialEnergyBarQingXiao.EState CurState = SpecialEnergyBarQingXiao.EState.Max;

		// Token: 0x0401A8FF RID: 108799
		private bool? MorphScaleVisible;

		// Token: 0x0401A900 RID: 108800
		private bool? MorphMaxNiaVisible;

		// Token: 0x0200AB50 RID: 43856
		private enum EChildType
		{
			// Token: 0x04034FDF RID: 217055
			PnlStateA,
			// Token: 0x04034FE0 RID: 217056
			SlotBarItem,
			// Token: 0x04034FE1 RID: 217057
			PnlNml,
			// Token: 0x04034FE2 RID: 217058
			PnlAct,
			// Token: 0x04034FE3 RID: 217059
			PnlStateB,
			// Token: 0x04034FE4 RID: 217060
			SldBar,
			// Token: 0x04034FE5 RID: 217061
			PnlHotKey,
			// Token: 0x04034FE6 RID: 217062
			AnimAMax,
			// Token: 0x04034FE7 RID: 217063
			AnimA2B,
			// Token: 0x04034FE8 RID: 217064
			AnimB2A,
			// Token: 0x04034FE9 RID: 217065
			AnimDGlowIn,
			// Token: 0x04034FEA RID: 217066
			AnimDGlowOut,
			// Token: 0x04034FEB RID: 217067
			AnimBMax,
			// Token: 0x04034FEC RID: 217068
			NiaGre,
			// Token: 0x04034FED RID: 217069
			NiaBlu,
			// Token: 0x04034FEE RID: 217070
			AnimBMax2B
		}

		// Token: 0x0200AB51 RID: 43857
		private enum EState
		{
			// Token: 0x04034FF0 RID: 217072
			Normal,
			// Token: 0x04034FF1 RID: 217073
			Morph,
			// Token: 0x04034FF2 RID: 217074
			Max
		}
	}
}
