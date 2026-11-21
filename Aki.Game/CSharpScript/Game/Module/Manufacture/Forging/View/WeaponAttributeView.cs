using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004624 RID: 17956
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponAttributeView : UiPanelBase
	{
		// Token: 0x0602D1B4 RID: 184756 RVA: 0x00C9BE88 File Offset: 0x00C9A088
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602D1B5 RID: 184757 RVA: 0x00C9BFA4 File Offset: 0x00C9A1A4
		protected override void OnStart()
		{
			if (this.FirstAttributeComponent == null)
			{
				this.FirstAttributeComponent = new AttributeItemInternal();
				this.FirstAttributeComponent.CreateThenShowByActor(base.GetItem(5).GetOwner());
			}
			if (this.SecondAttributeComponent == null)
			{
				this.SecondAttributeComponent = new AttributeItemInternal();
				this.SecondAttributeComponent.CreateThenShowByActor(base.GetItem(6).GetOwner());
			}
			this.StarView = new GenericLayout<WeaponAttributeView.StarItem, EStartState>(base.GetHorizontalLayout(3), new Func<WeaponAttributeView.StarItem>(this.InitStarItem), null, false, true);
			TArray<UUIItem> attachUIChildren = this.StarView.GetRootUiItem().GetAttachUIChildren();
			for (int i = 0; i < attachUIChildren.Num(); i++)
			{
				attachUIChildren.Get(i).SetUIActive(false);
			}
		}

		// Token: 0x0602D1B6 RID: 184758 RVA: 0x00C9C055 File Offset: 0x00C9A255
		private WeaponAttributeView.StarItem InitStarItem()
		{
			return new WeaponAttributeView.StarItem();
		}

		// Token: 0x0602D1B7 RID: 184759 RVA: 0x00C9C05C File Offset: 0x00C9A25C
		private void RefreshSkillNameText()
		{
			WeaponReson? weaponResonanceConfig = global::WeaponConfig.Instance.GetWeaponResonanceConfig(this.WeaponConfig.Value.ResonId, 1);
			if (weaponResonanceConfig != null)
			{
				base.GetText(1).ShowTextNew(weaponResonanceConfig.Value.Name);
			}
		}

		// Token: 0x0602D1B8 RID: 184760 RVA: 0x00C9C0AC File Offset: 0x00C9A2AC
		private void RefreshStar()
		{
			List<EStartState> data = new List<EStartState>(WeaponModel.Instance.GetWeaponBreachMaxLevel(this.WeaponConfig.Value.BreachId));
			this.StarView.RefreshByData(data, null, false);
		}

		// Token: 0x0602D1B9 RID: 184761 RVA: 0x00C9C0EC File Offset: 0x00C9A2EC
		private void RefreshWeaponLevel()
		{
			int num = 1;
			int levelLimit = this.WeaponBreachConfig.Value.LevelLimit;
			LguiUtil.Instance.SetLocalText(base.GetText(2), "ForgingWeaponLevel", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				levelLimit
			}));
		}

		// Token: 0x0602D1BA RID: 184762 RVA: 0x00C9C144 File Offset: 0x00C9A344
		private void RefreshWeaponAttribute()
		{
			this.FirstAttributeComponent.UpdateParam(this.WeaponConfig.Value.FirstPropId.Value.Id, this.WeaponConfig.Value.FirstPropId.Value.IsRatio);
			float curveValue = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.FirstCurve, this.WeaponConfig.Value.FirstPropId.Value.Value, 1, 0);
			this.FirstAttributeComponent.SetCurrentValue(curveValue);
			this.SecondAttributeComponent.UpdateParam(this.WeaponConfig.Value.SecondPropId.Value.Id, this.WeaponConfig.Value.SecondPropId.Value.IsRatio);
			float curveValue2 = WeaponModel.Instance.GetCurveValue(this.WeaponConfig.Value.SecondCurve, this.WeaponConfig.Value.SecondPropId.Value.Value, 1, 0);
			this.SecondAttributeComponent.SetCurrentValue(curveValue2);
			LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>("1"));
		}

		// Token: 0x0602D1BB RID: 184763 RVA: 0x00C9C2B8 File Offset: 0x00C9A4B8
		public void RefreshTips(IWeaponForgingData data)
		{
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			this.WeaponConfig = global::WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			this.WeaponBreachConfig = global::WeaponConfig.Instance.GetWeaponBreach(this.WeaponConfig.Value.BreachId, 1);
			this.RefreshSkillNameText();
			this.RefreshWeaponLevel();
			this.RefreshStar();
			this.RefreshWeaponAttribute();
		}

		// Token: 0x0401834E RID: 99150
		private WeaponConf? WeaponConfig;

		// Token: 0x0401834F RID: 99151
		private WeaponBreach? WeaponBreachConfig;

		// Token: 0x04018350 RID: 99152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<WeaponAttributeView.StarItem, EStartState> StarView;

		// Token: 0x04018351 RID: 99153
		[Nullable(2)]
		private AttributeItemInternal FirstAttributeComponent;

		// Token: 0x04018352 RID: 99154
		[Nullable(2)]
		private AttributeItemInternal SecondAttributeComponent;

		// Token: 0x04018353 RID: 99155
		private const int CurrentLevel = 1;

		// Token: 0x04018354 RID: 99156
		private const int CurrentBreach = 0;

		// Token: 0x0200A22C RID: 41516
		[Nullable(0)]
		public class StarItem : UiPanelBase, IGridProxy<EStartState>
		{
			// Token: 0x17007955 RID: 31061
			// (get) Token: 0x060458DE RID: 284894 RVA: 0x014E7196 File Offset: 0x014E5396
			// (set) Token: 0x060458DF RID: 284895 RVA: 0x014E719E File Offset: 0x014E539E
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public IScrollViewDelegate<IGridProxy<EStartState>, EStartState> ScrollViewDelegate { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }

			// Token: 0x17007956 RID: 31062
			// (get) Token: 0x060458E0 RID: 284896 RVA: 0x014E71A7 File Offset: 0x014E53A7
			// (set) Token: 0x060458E1 RID: 284897 RVA: 0x014E71AF File Offset: 0x014E53AF
			public int GridIndex { get; set; }

			// Token: 0x17007957 RID: 31063
			// (get) Token: 0x060458E2 RID: 284898 RVA: 0x014E71B8 File Offset: 0x014E53B8
			// (set) Token: 0x060458E3 RID: 284899 RVA: 0x014E71C0 File Offset: 0x014E53C0
			public int DisplayIndex { get; set; }

			// Token: 0x060458E4 RID: 284900 RVA: 0x014E71C9 File Offset: 0x014E53C9
			public void Refresh(EStartState data, bool isSelected, int gridIndex)
			{
				if (data == EStartState.ON)
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(1).SetUIActive(false);
					return;
				}
				base.GetSprite(0).SetUIActive(false);
				base.GetSprite(1).SetUIActive(true);
			}

			// Token: 0x060458E5 RID: 284901 RVA: 0x014E7206 File Offset: 0x014E5406
			public void Clear()
			{
			}

			// Token: 0x060458E6 RID: 284902 RVA: 0x014E7208 File Offset: 0x014E5408
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x060458E7 RID: 284903 RVA: 0x014E720A File Offset: 0x014E540A
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x060458E8 RID: 284904 RVA: 0x014E720C File Offset: 0x014E540C
			public void CreateThenShowByActor(AActor actor)
			{
				base.CreateThenShowByActor(actor, null);
			}

			// Token: 0x060458E9 RID: 284905 RVA: 0x014E7218 File Offset: 0x014E5418
			public UniTask CreateThenShowByActorAsync(AActor actor)
			{
				WeaponAttributeView.StarItem.<CreateThenShowByActorAsync>d__18 <CreateThenShowByActorAsync>d__;
				<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateThenShowByActorAsync>d__.<>4__this = this;
				<CreateThenShowByActorAsync>d__.actor = actor;
				<CreateThenShowByActorAsync>d__.<>1__state = -1;
				<CreateThenShowByActorAsync>d__.<>t__builder.Start<WeaponAttributeView.StarItem.<CreateThenShowByActorAsync>d__18>(ref <CreateThenShowByActorAsync>d__);
				return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060458EA RID: 284906 RVA: 0x014E7264 File Offset: 0x014E5464
			public UniTask CreateByActorAsync(AActor actor)
			{
				WeaponAttributeView.StarItem.<CreateByActorAsync>d__19 <CreateByActorAsync>d__;
				<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<CreateByActorAsync>d__.<>4__this = this;
				<CreateByActorAsync>d__.actor = actor;
				<CreateByActorAsync>d__.<>1__state = -1;
				<CreateByActorAsync>d__.<>t__builder.Start<WeaponAttributeView.StarItem.<CreateByActorAsync>d__19>(ref <CreateByActorAsync>d__);
				return <CreateByActorAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060458EB RID: 284907 RVA: 0x014E72AF File Offset: 0x014E54AF
			public object GetKey(EStartState data, int gridIndex)
			{
				return data;
			}

			// Token: 0x060458EC RID: 284908 RVA: 0x014E72B8 File Offset: 0x014E54B8
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x060458ED RID: 284909 RVA: 0x014E734D File Offset: 0x014E554D
			protected override void OnStart()
			{
				base.GetSprite(2).SetUIActive(false);
			}

			// Token: 0x060458EE RID: 284910 RVA: 0x014E735C File Offset: 0x014E555C
			public void SetState(bool isOn)
			{
			}

			// Token: 0x0200BD41 RID: 48449
			[NullableContext(0)]
			public class EStarItemComponents
			{
				// Token: 0x0403A1BA RID: 238010
				public const int ImgStarOn = 0;

				// Token: 0x0403A1BB RID: 238011
				public const int ImgStarOff = 1;

				// Token: 0x0403A1BC RID: 238012
				public const int ImgStarNext = 2;
			}
		}

		// Token: 0x0200A22D RID: 41517
		[NullableContext(0)]
		private class EWeaponAttributeComponents
		{
			// Token: 0x040324D3 RID: 206035
			public const int TxtSkillGrade = 0;

			// Token: 0x040324D4 RID: 206036
			public const int TxtSkillName = 1;

			// Token: 0x040324D5 RID: 206037
			public const int TxtLevel = 2;

			// Token: 0x040324D6 RID: 206038
			public const int PnlStar = 3;

			// Token: 0x040324D7 RID: 206039
			public const int PnlAttr = 4;

			// Token: 0x040324D8 RID: 206040
			public const int FirstAttributeItem = 5;

			// Token: 0x040324D9 RID: 206041
			public const int SecondAttributeItem = 6;
		}
	}
}
