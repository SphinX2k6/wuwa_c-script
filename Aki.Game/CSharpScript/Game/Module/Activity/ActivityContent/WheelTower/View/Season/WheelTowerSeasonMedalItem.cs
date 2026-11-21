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

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F49 RID: 20297
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WheelTowerSeasonMedalItem : GridProxyAbstract<IWheelTowerMedalItemData>
	{
		// Token: 0x06032FA5 RID: 208805 RVA: 0x00E4913C File Offset: 0x00E4733C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMedalBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032FA6 RID: 208806 RVA: 0x00E492EC File Offset: 0x00E474EC
		protected override void OnStart()
		{
			this.ProgressTween.SetCurrentEase(LTweenEase.OutSine);
			this.ProgressTween.BindUpdateTween(new Action<float>(this.OnProgressTweenUpdate));
			this.ProgressTween.BindCompleteTween(new Action(this.OnProgressTweenComplete));
			this.SeqPlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06032FA7 RID: 208807 RVA: 0x00E49345 File Offset: 0x00E47545
		protected override void OnBeforeDestroy()
		{
			CustomPromise<bool> tweenPromise = this.TweenPromise;
			if (tweenPromise != null)
			{
				tweenPromise.SetResult(true);
			}
			this.TweenPromise = null;
			this.ProgressTween.Destroy();
		}

		// Token: 0x06032FA8 RID: 208808 RVA: 0x00E4936C File Offset: 0x00E4756C
		public void SetPreviewMedalId(int medalId)
		{
			this.PreviewMedalId = medalId;
			IWheelTowerMedalGroupData groupData = this.GetGroupData();
			if (groupData != null)
			{
				this.RefreshAppearance(groupData);
			}
		}

		// Token: 0x06032FA9 RID: 208809 RVA: 0x00E49394 File Offset: 0x00E47594
		public override void Refresh(IWheelTowerMedalItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.ApplyFlags(data);
			IWheelTowerMedalGroupData medalGroupData = WheelTowerModel.Instance.GetMedalGroupData(data.GroupId);
			if (medalGroupData == null)
			{
				return;
			}
			bool flag = medalGroupData.CurrentMedalId == 0;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!data.HideMedalPnl || !flag);
			}
			this.RefreshProgress(medalGroupData);
			this.RefreshAppearance(medalGroupData);
		}

		// Token: 0x06032FAA RID: 208810 RVA: 0x00E4940C File Offset: 0x00E4760C
		public UniTask PlayProgressTweenAsync()
		{
			WheelTowerSeasonMedalItem.<PlayProgressTweenAsync>d__13 <PlayProgressTweenAsync>d__;
			<PlayProgressTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayProgressTweenAsync>d__.<>4__this = this;
			<PlayProgressTweenAsync>d__.<>1__state = -1;
			<PlayProgressTweenAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalItem.<PlayProgressTweenAsync>d__13>(ref <PlayProgressTweenAsync>d__);
			return <PlayProgressTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FAB RID: 208811 RVA: 0x00E49450 File Offset: 0x00E47650
		public UniTask PlayUnlockAsync()
		{
			WheelTowerSeasonMedalItem.<PlayUnlockAsync>d__14 <PlayUnlockAsync>d__;
			<PlayUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAsync>d__.<>4__this = this;
			<PlayUnlockAsync>d__.<>1__state = -1;
			<PlayUnlockAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalItem.<PlayUnlockAsync>d__14>(ref <PlayUnlockAsync>d__);
			return <PlayUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FAC RID: 208812 RVA: 0x00E49493 File Offset: 0x00E47693
		[NullableContext(2)]
		private IWheelTowerMedalGroupData GetGroupData()
		{
			if (this.ItemData == null)
			{
				return null;
			}
			return WheelTowerModel.Instance.GetMedalGroupData(this.ItemData.GroupId);
		}

		// Token: 0x06032FAD RID: 208813 RVA: 0x00E494B4 File Offset: 0x00E476B4
		private void ApplyFlags(IWheelTowerMedalItemData data)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(!data.DisableInteract.GetValueOrDefault());
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!data.HideDetails.GetValueOrDefault());
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!data.IsLast.GetValueOrDefault());
		}

		// Token: 0x06032FAE RID: 208814 RVA: 0x00E4952C File Offset: 0x00E4772C
		private void RefreshProgress(IWheelTowerMedalGroupData groupData)
		{
			int currentTarget = groupData.CurrentTarget;
			int num = (currentTarget > 0) ? Math.Min(groupData.Progress, currentTarget) : groupData.Progress;
			UUIText text = base.GetText(7);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/<color=#b3b3b3>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentTarget);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			float num2 = (currentTarget > 0) ? ((float)num / (float)currentTarget) : 0f;
			this.CurrentProgressRatio = num2;
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(num2);
		}

		// Token: 0x06032FAF RID: 208815 RVA: 0x00E495DC File Offset: 0x00E477DC
		private void RefreshAppearance(IWheelTowerMedalGroupData groupData)
		{
			this.CurrentMedalId = groupData.CurrentMedalId;
			int num = (groupData.CurrentMedalId != 0) ? groupData.CurrentMedalId : groupData.NextMedalId;
			int id = (this.PreviewMedalId != 0) ? this.PreviewMedalId : num;
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(id);
			if (medalConfigById == null)
			{
				return;
			}
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(6);
			string name = medalConfigById.Value.Name;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("S");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupData.SeasonId);
			instance.SetLocalTextNew(text, name, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			base.SetTextureByPath(medalConfigById.Value.Icon, base.GetTexture(4), null, null);
			base.SetTextureByPath(medalConfigById.Value.Background, base.GetTexture(3), null, null);
		}

		// Token: 0x06032FB0 RID: 208816 RVA: 0x00E496D0 File Offset: 0x00E478D0
		private void OnProgressTweenUpdate(float value)
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}

		// Token: 0x06032FB1 RID: 208817 RVA: 0x00E496E4 File Offset: 0x00E478E4
		private void OnProgressTweenComplete()
		{
			CustomPromise<bool> tweenPromise = this.TweenPromise;
			this.TweenPromise = null;
			if (tweenPromise == null)
			{
				return;
			}
			tweenPromise.SetResult(true);
		}

		// Token: 0x06032FB2 RID: 208818 RVA: 0x00E49700 File Offset: 0x00E47900
		private void OnMedalBtnClick()
		{
			if (this.ItemData == null)
			{
				return;
			}
			WheelTowerMedalDetailViewData param = new WheelTowerMedalDetailViewData
			{
				GroupId = this.ItemData.GroupId,
				Index = base.GridIndex + 1
			};
			UiManager.Instance.OpenView(EUiViewName.WheelTowerMedalDetailView, param, null);
		}

		// Token: 0x0401B0AD RID: 110765
		private const float ProgressTweenDuration = 0.7f;

		// Token: 0x0401B0AE RID: 110766
		[Nullable(2)]
		private IWheelTowerMedalItemData ItemData;

		// Token: 0x0401B0AF RID: 110767
		private float CurrentProgressRatio;

		// Token: 0x0401B0B0 RID: 110768
		private int CurrentMedalId;

		// Token: 0x0401B0B1 RID: 110769
		private int PreviewMedalId;

		// Token: 0x0401B0B2 RID: 110770
		private readonly LguiFloatTween ProgressTween = new LguiFloatTween();

		// Token: 0x0401B0B3 RID: 110771
		[Nullable(2)]
		private CustomPromise<bool> TweenPromise;

		// Token: 0x0401B0B4 RID: 110772
		[Nullable(2)]
		private UiSequencePlayer SeqPlayer;
	}
}
