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
	// Token: 0x02005F62 RID: 24418
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WheelTowerSeasonMedalItem : GridProxyAbstract<IWheelTowerMedalItemData>
	{
		// Token: 0x0603E00A RID: 253962 RVA: 0x00EF7410 File Offset: 0x00EF5610
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

		// Token: 0x0603E00B RID: 253963 RVA: 0x00EF75C0 File Offset: 0x00EF57C0
		protected override void OnStart()
		{
			this.ProgressTween.SetCurrentEase(LTweenEase.OutSine);
			this.ProgressTween.BindUpdateTween(new Action<float>(this.OnProgressTweenUpdate));
			this.ProgressTween.BindCompleteTween(new Action(this.OnProgressTweenComplete));
			this.SeqPlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E00C RID: 253964 RVA: 0x00EF7619 File Offset: 0x00EF5819
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

		// Token: 0x0603E00D RID: 253965 RVA: 0x00EF7640 File Offset: 0x00EF5840
		public void SetPreviewMedalId(int medalId)
		{
			this.PreviewMedalId = medalId;
			IWheelTowerMedalGroupData groupData = this.GetGroupData();
			if (groupData != null)
			{
				this.RefreshAppearance(groupData);
			}
		}

		// Token: 0x0603E00E RID: 253966 RVA: 0x00EF7668 File Offset: 0x00EF5868
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

		// Token: 0x0603E00F RID: 253967 RVA: 0x00EF76E0 File Offset: 0x00EF58E0
		public UniTask PlayProgressTweenAsync()
		{
			WheelTowerSeasonMedalItem.<PlayProgressTweenAsync>d__13 <PlayProgressTweenAsync>d__;
			<PlayProgressTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayProgressTweenAsync>d__.<>4__this = this;
			<PlayProgressTweenAsync>d__.<>1__state = -1;
			<PlayProgressTweenAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalItem.<PlayProgressTweenAsync>d__13>(ref <PlayProgressTweenAsync>d__);
			return <PlayProgressTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E010 RID: 253968 RVA: 0x00EF7724 File Offset: 0x00EF5924
		public UniTask PlayUnlockAsync()
		{
			WheelTowerSeasonMedalItem.<PlayUnlockAsync>d__14 <PlayUnlockAsync>d__;
			<PlayUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAsync>d__.<>4__this = this;
			<PlayUnlockAsync>d__.<>1__state = -1;
			<PlayUnlockAsync>d__.<>t__builder.Start<WheelTowerSeasonMedalItem.<PlayUnlockAsync>d__14>(ref <PlayUnlockAsync>d__);
			return <PlayUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E011 RID: 253969 RVA: 0x00EF7767 File Offset: 0x00EF5967
		[NullableContext(2)]
		private IWheelTowerMedalGroupData GetGroupData()
		{
			if (this.ItemData == null)
			{
				return null;
			}
			return WheelTowerModel.Instance.GetMedalGroupData(this.ItemData.GroupId);
		}

		// Token: 0x0603E012 RID: 253970 RVA: 0x00EF7788 File Offset: 0x00EF5988
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

		// Token: 0x0603E013 RID: 253971 RVA: 0x00EF7800 File Offset: 0x00EF5A00
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

		// Token: 0x0603E014 RID: 253972 RVA: 0x00EF78B0 File Offset: 0x00EF5AB0
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

		// Token: 0x0603E015 RID: 253973 RVA: 0x00EF79A4 File Offset: 0x00EF5BA4
		private void OnProgressTweenUpdate(float value)
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}

		// Token: 0x0603E016 RID: 253974 RVA: 0x00EF79B8 File Offset: 0x00EF5BB8
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

		// Token: 0x0603E017 RID: 253975 RVA: 0x00EF79D4 File Offset: 0x00EF5BD4
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

		// Token: 0x040205DB RID: 132571
		private const float ProgressTweenDuration = 0.7f;

		// Token: 0x040205DC RID: 132572
		[Nullable(2)]
		private IWheelTowerMedalItemData ItemData;

		// Token: 0x040205DD RID: 132573
		private float CurrentProgressRatio;

		// Token: 0x040205DE RID: 132574
		private int CurrentMedalId;

		// Token: 0x040205DF RID: 132575
		private int PreviewMedalId;

		// Token: 0x040205E0 RID: 132576
		private readonly LguiFloatTween ProgressTween = new LguiFloatTween();

		// Token: 0x040205E1 RID: 132577
		[Nullable(2)]
		private CustomPromise<bool> TweenPromise;

		// Token: 0x040205E2 RID: 132578
		[Nullable(2)]
		private UiSequencePlayer SeqPlayer;
	}
}
