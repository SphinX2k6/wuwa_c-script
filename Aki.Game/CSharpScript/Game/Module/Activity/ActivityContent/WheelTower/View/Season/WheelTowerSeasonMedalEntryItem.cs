using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F5F RID: 24415
	[NullableContext(2)]
	[Nullable(0)]
	public class WheelTowerSeasonMedalEntryItem : UiPanelBase
	{
		// Token: 0x0603E000 RID: 253952 RVA: 0x00EF6E30 File Offset: 0x00EF5030
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnEntryBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603E001 RID: 253953 RVA: 0x00EF6F7C File Offset: 0x00EF517C
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerSeasonMedalEntryItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalEntryItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E002 RID: 253954 RVA: 0x00EF6FC0 File Offset: 0x00EF51C0
		public void Refresh(int seasonId)
		{
			List<IWheelTowerMedalGroupData> seasonMedalGroupList = WheelTowerModel.Instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
			if (seasonMedalGroupList.Count == 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			IWheelTowerMedalGroupData wheelTowerMedalGroupData = seasonMedalGroupList[0];
			IWheelTowerMedalGroupData wheelTowerMedalGroupData2 = (seasonMedalGroupList.Count >= 2) ? seasonMedalGroupList[1] : null;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(wheelTowerMedalGroupData2 != null);
			}
			bool isMaxLevel = wheelTowerMedalGroupData.IsMaxLevel;
			bool flag = wheelTowerMedalGroupData2 == null || wheelTowerMedalGroupData2.IsMaxLevel;
			bool flag2 = false;
			bool flag3 = false;
			if (!isMaxLevel)
			{
				flag2 = true;
			}
			else if (wheelTowerMedalGroupData2 != null && !flag)
			{
				flag3 = true;
			}
			FColor highlightColor = FColor.FromHex("FFFFFF");
			FColor highlightColor2 = FColor.FromHex("FDFDBE");
			WheelTowerSeasonMedalPreviewItem leftPreview = this.LeftPreview;
			if (leftPreview != null)
			{
				leftPreview.Refresh(wheelTowerMedalGroupData, flag2, highlightColor);
			}
			if (wheelTowerMedalGroupData2 != null)
			{
				WheelTowerSeasonMedalPreviewItem rightPreview = this.RightPreview;
				if (rightPreview != null)
				{
					rightPreview.Refresh(wheelTowerMedalGroupData2, flag3, highlightColor2);
				}
			}
			this.ApplyScaleAndLayer(flag2, flag3, wheelTowerMedalGroupData2 != null);
			IWheelTowerMedalGroupData group = flag2 ? wheelTowerMedalGroupData : (flag3 ? wheelTowerMedalGroupData2 : (wheelTowerMedalGroupData2 ?? wheelTowerMedalGroupData));
			this.RefreshDescAndProgress(group);
		}

		// Token: 0x0603E003 RID: 253955 RVA: 0x00EF70D4 File Offset: 0x00EF52D4
		private void ApplyScaleAndLayer(bool leftActive, bool rightActive, bool hasRight)
		{
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(1);
			if (item == null || item2 == null)
			{
				return;
			}
			float num = leftActive ? 1f : 0.85f;
			UUIItem uuiitem = item;
			FVector fvector = new FVector(num, num, 1f);
			uuiitem.SetUIRelativeScale3D(fvector);
			if (hasRight)
			{
				float num2 = rightActive ? 1f : 0.85f;
				UUIItem uuiitem2 = item2;
				fvector = new FVector(num2, num2, 1f);
				uuiitem2.SetUIRelativeScale3D(fvector);
				if (leftActive)
				{
					item.SetHierarchyIndex(1);
					item2.SetHierarchyIndex(0);
					return;
				}
				if (rightActive)
				{
					item2.SetHierarchyIndex(1);
					item.SetHierarchyIndex(0);
				}
			}
		}

		// Token: 0x0603E004 RID: 253956 RVA: 0x00EF716C File Offset: 0x00EF536C
		[NullableContext(1)]
		private void RefreshDescAndProgress(IWheelTowerMedalGroupData group)
		{
			NewTowerMedal? lastMedalConfigByGroupId = WheelTowerUtil.GetLastMedalConfigByGroupId(group.GroupId);
			if (lastMedalConfigByGroupId != null)
			{
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = base.GetText(6);
				string name = lastMedalConfigByGroupId.Value.Name;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("S");
				defaultInterpolatedStringHandler.AppendFormatted<int>(group.SeasonId);
				instance.SetLocalTextNew(text, name, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), lastMedalConfigByGroupId.Value.Desc, Array.Empty<object>());
			}
			int num = Math.Max(group.CurrentTarget, 1);
			float fillAmount = group.IsMaxLevel ? 1f : Math.Min((float)group.Progress / (float)num, 1f);
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(group.Progress);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(group.CurrentTarget);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUITexture texture = base.GetTexture(5);
			if (texture == null)
			{
				return;
			}
			texture.SetFillAmount(fillAmount);
		}

		// Token: 0x0603E005 RID: 253957 RVA: 0x00EF728D File Offset: 0x00EF548D
		private void OnEntryBtnClick()
		{
			UiManager.Instance.CloseView(EUiViewName.WheelTowerSeasonRewardView, null);
			WheelTowerController.Instance.OpenSeasonMedalView(0, false);
		}

		// Token: 0x040205CB RID: 132555
		private const float ACTIVE_SCALE = 1f;

		// Token: 0x040205CC RID: 132556
		private const float DIM_SCALE = 0.85f;

		// Token: 0x040205CD RID: 132557
		private const int MAX_DISPLAY_COUNT = 2;

		// Token: 0x040205CE RID: 132558
		private WheelTowerSeasonMedalPreviewItem LeftPreview;

		// Token: 0x040205CF RID: 132559
		private WheelTowerSeasonMedalPreviewItem RightPreview;
	}
}
