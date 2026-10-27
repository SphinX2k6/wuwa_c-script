using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B6 RID: 21430
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleScoreProgressActivityPanel : UiPanelBase
	{
		// Token: 0x06036C1F RID: 224287 RVA: 0x00CF5C2C File Offset: 0x00CF3E2C
		public UniTask Init(UUIItem item)
		{
			MoraleScoreProgressActivityPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleScoreProgressActivityPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036C20 RID: 224288 RVA: 0x00CF5C78 File Offset: 0x00CF3E78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06036C21 RID: 224289 RVA: 0x00CF5D14 File Offset: 0x00CF3F14
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressActivityPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressActivityPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C22 RID: 224290 RVA: 0x00CF5D58 File Offset: 0x00CF3F58
		public void UpdateData()
		{
			MoraleModel instance = MoraleModel.Instance;
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout = this.PercentLayout;
			if (percentLayout != null)
			{
				percentLayout.RefreshByData(instance.ProgressRewardList, new Action(this.UpdatePercentHandle), false);
			}
			List<MoraleAreaProgressData> list = new List<MoraleAreaProgressData>(instance.ProgressRewardList.Count);
			foreach (MoraleProgressRewardData moraleProgressRewardData in instance.ProgressRewardList)
			{
				MoraleAreaProgressData item = new MoraleAreaProgressData
				{
					TargetScore = moraleProgressRewardData.TargetScore,
					LastTargetScore = moraleProgressRewardData.LastTargetScore,
					StartScore = moraleProgressRewardData.StartScore
				};
				list.Add(item);
			}
			GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> pointLayout = this.PointLayout;
			if (pointLayout != null)
			{
				pointLayout.RefreshByData(list, null, false);
			}
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout2 = this.PercentLayout;
			if (percentLayout2 != null)
			{
				percentLayout2.BindLateUpdate(delegate(float _)
				{
					TimerSystem.Instance.Next(new TTimerAction(this.TimerUpdatePercentHandle), null, null);
					GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout3 = this.PercentLayout;
					if (percentLayout3 == null)
					{
						return;
					}
					percentLayout3.UnBindLateUpdate();
				});
			}
			int currentProgressScore = instance.GetCurrentProgressScore();
			int progressTotalScore = instance.GetProgressTotalScore();
			UUIText text = base.GetText(0);
			string textStringId = "Morale_title_17";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				currentProgressScore,
				progressTotalScore
			}));
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Morale_title_1");
		}

		// Token: 0x06036C23 RID: 224291 RVA: 0x00CF5EA8 File Offset: 0x00CF40A8
		protected void TimerUpdatePercentHandle(float _)
		{
			this.UpdatePercentHandle();
		}

		// Token: 0x06036C24 RID: 224292 RVA: 0x00CF5EB0 File Offset: 0x00CF40B0
		protected void UpdatePercentHandle()
		{
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout = this.PercentLayout;
			List<MoraleScoreProgressPercentItem> list = (percentLayout != null) ? percentLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].UpdatePercentHandle();
			}
		}

		// Token: 0x06036C25 RID: 224293 RVA: 0x00CF5EF1 File Offset: 0x00CF40F1
		private MoraleScoreProgressPercentItem CreatePercentItem()
		{
			return new MoraleScoreProgressPercentItem();
		}

		// Token: 0x06036C26 RID: 224294 RVA: 0x00CF5EF8 File Offset: 0x00CF40F8
		private MoraleAreaProgressPointItem CreatePointItem()
		{
			return new MoraleAreaProgressPointItem();
		}

		// Token: 0x0401CE72 RID: 118386
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> PercentLayout;

		// Token: 0x0401CE73 RID: 118387
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> PointLayout;

		// Token: 0x0200B652 RID: 46674
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040373C2 RID: 226242
			public const int TxtSumScoreProgress = 0;

			// Token: 0x040373C3 RID: 226243
			public const int TxtSumProgressTitle = 1;

			// Token: 0x040373C4 RID: 226244
			public const int LayoutPercent = 2;

			// Token: 0x040373C5 RID: 226245
			public const int ItemPercent = 3;

			// Token: 0x040373C6 RID: 226246
			public const int LayoutProgressPoint = 4;

			// Token: 0x040373C7 RID: 226247
			public const int ItemProgressPointTemplate = 5;
		}
	}
}
