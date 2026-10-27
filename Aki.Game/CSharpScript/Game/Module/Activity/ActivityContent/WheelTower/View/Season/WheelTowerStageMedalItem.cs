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
	// Token: 0x02005F71 RID: 24433
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WheelTowerStageMedalItem : GridProxyAbstract<IWheelTowerMedalItemData>
	{
		// Token: 0x0603E065 RID: 254053 RVA: 0x00EF9584 File Offset: 0x00EF7784
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMedalBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603E066 RID: 254054 RVA: 0x00EF96F0 File Offset: 0x00EF78F0
		protected override void OnStart()
		{
			this.ScoreTween.SetCurrentEase(LTweenEase.OutSine);
			this.ScoreTween.BindUpdateTween(new Action<int>(this.OnScoreTweenUpdate));
			this.ScoreTween.BindCompleteTween(new Action(this.OnScoreTweenComplete));
			this.SeqPlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E067 RID: 254055 RVA: 0x00EF9749 File Offset: 0x00EF7949
		protected override void OnBeforeDestroy()
		{
			CustomPromise<bool> tweenPromise = this.TweenPromise;
			if (tweenPromise != null)
			{
				tweenPromise.SetResult(true);
			}
			this.TweenPromise = null;
			this.ScoreTween.Destroy();
		}

		// Token: 0x0603E068 RID: 254056 RVA: 0x00EF9770 File Offset: 0x00EF7970
		public void SetPreviewMedalId(int oldMedalId)
		{
			this.IsPreviewing = true;
			this.PreviewMedalId = oldMedalId;
			IWheelTowerMedalGroupData groupData = this.GetGroupData();
			if (groupData != null)
			{
				this.RefreshDisplay(groupData);
			}
		}

		// Token: 0x0603E069 RID: 254057 RVA: 0x00EF979C File Offset: 0x00EF799C
		public override void Refresh(IWheelTowerMedalItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.ApplyFlags(data);
			IWheelTowerMedalGroupData medalGroupData = WheelTowerModel.Instance.GetMedalGroupData(data.GroupId);
			if (medalGroupData == null)
			{
				return;
			}
			this.RefreshScore(medalGroupData, gridIndex);
			this.RefreshDisplay(medalGroupData);
		}

		// Token: 0x0603E06A RID: 254058 RVA: 0x00EF97DC File Offset: 0x00EF79DC
		public UniTask PlayScoreTweenAsync()
		{
			WheelTowerStageMedalItem.<PlayScoreTweenAsync>d__14 <PlayScoreTweenAsync>d__;
			<PlayScoreTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayScoreTweenAsync>d__.<>4__this = this;
			<PlayScoreTweenAsync>d__.<>1__state = -1;
			<PlayScoreTweenAsync>d__.<>t__builder.Start<WheelTowerStageMedalItem.<PlayScoreTweenAsync>d__14>(ref <PlayScoreTweenAsync>d__);
			return <PlayScoreTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E06B RID: 254059 RVA: 0x00EF9820 File Offset: 0x00EF7A20
		public UniTask PlayUnlockAsync()
		{
			WheelTowerStageMedalItem.<PlayUnlockAsync>d__15 <PlayUnlockAsync>d__;
			<PlayUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAsync>d__.<>4__this = this;
			<PlayUnlockAsync>d__.<>1__state = -1;
			<PlayUnlockAsync>d__.<>t__builder.Start<WheelTowerStageMedalItem.<PlayUnlockAsync>d__15>(ref <PlayUnlockAsync>d__);
			return <PlayUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E06C RID: 254060 RVA: 0x00EF9863 File Offset: 0x00EF7A63
		[NullableContext(2)]
		private IWheelTowerMedalGroupData GetGroupData()
		{
			if (this.ItemData == null)
			{
				return null;
			}
			return WheelTowerModel.Instance.GetMedalGroupData(this.ItemData.GroupId);
		}

		// Token: 0x0603E06D RID: 254061 RVA: 0x00EF9884 File Offset: 0x00EF7A84
		private void ApplyFlags(IWheelTowerMedalItemData data)
		{
			bool valueOrDefault = data.HideDetails.GetValueOrDefault();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(!data.DisableInteract.GetValueOrDefault());
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!valueOrDefault);
		}

		// Token: 0x0603E06E RID: 254062 RVA: 0x00EF98D8 File Offset: 0x00EF7AD8
		private void RefreshScore(IWheelTowerMedalGroupData groupData, int gridIndex)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText((gridIndex + 1).ToString("D2"), true);
			}
			this.CurrentScore = groupData.Progress;
			UUIText text2 = base.GetText(6);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(groupData.Progress.ToString(), true);
		}

		// Token: 0x0603E06F RID: 254063 RVA: 0x00EF9934 File Offset: 0x00EF7B34
		private void RefreshDisplay(IWheelTowerMedalGroupData groupData)
		{
			this.CurrentMedalId = groupData.CurrentMedalId;
			bool flag = groupData.CurrentMedalId == 0;
			int num = this.IsPreviewing ? this.PreviewMedalId : groupData.CurrentMedalId;
			bool flag2 = num == 0;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUITexture texture = base.GetTexture(5);
			if (texture != null)
			{
				texture.SetUIActive(!flag2);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 != null)
			{
				texture2.SetUIActive(!flag2);
			}
			if (flag2)
			{
				return;
			}
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(num);
			if (medalConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(medalConfigById.Value.Icon, base.GetTexture(5), null, null);
			base.SetTextureByPath(medalConfigById.Value.Background, base.GetTexture(3), null, null);
		}

		// Token: 0x0603E070 RID: 254064 RVA: 0x00EF9A48 File Offset: 0x00EF7C48
		private void OnScoreTweenUpdate(int value)
		{
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			text.SetText(value.ToString(), true);
		}

		// Token: 0x0603E071 RID: 254065 RVA: 0x00EF9A63 File Offset: 0x00EF7C63
		private void OnScoreTweenComplete()
		{
			CustomPromise<bool> tweenPromise = this.TweenPromise;
			this.TweenPromise = null;
			if (tweenPromise == null)
			{
				return;
			}
			tweenPromise.SetResult(true);
		}

		// Token: 0x0603E072 RID: 254066 RVA: 0x00EF9A80 File Offset: 0x00EF7C80
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

		// Token: 0x04020638 RID: 132664
		private const float ScoreTweenDuration = 0.7f;

		// Token: 0x04020639 RID: 132665
		[Nullable(2)]
		private IWheelTowerMedalItemData ItemData;

		// Token: 0x0402063A RID: 132666
		private int CurrentScore;

		// Token: 0x0402063B RID: 132667
		private int CurrentMedalId;

		// Token: 0x0402063C RID: 132668
		private bool IsPreviewing;

		// Token: 0x0402063D RID: 132669
		private int PreviewMedalId;

		// Token: 0x0402063E RID: 132670
		private readonly LguiIntTween ScoreTween = new LguiIntTween();

		// Token: 0x0402063F RID: 132671
		[Nullable(2)]
		private CustomPromise<bool> TweenPromise;

		// Token: 0x04020640 RID: 132672
		[Nullable(2)]
		private UiSequencePlayer SeqPlayer;
	}
}
