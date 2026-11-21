using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FE RID: 22782
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolAffairsView : SolarSchoolHideHudViewBase
	{
		// Token: 0x060382A1 RID: 230049 RVA: 0x00FB2FC1 File Offset: 0x00FB11C1
		public SolarSchoolAffairsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060382A2 RID: 230050 RVA: 0x00FB2FD4 File Offset: 0x00FB11D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060382A3 RID: 230051 RVA: 0x00FB30A0 File Offset: 0x00FB12A0
		protected override void OnStart()
		{
			this.OptionScroll = new GenericScrollViewNew<SolarSchoolAffairsOptionItem, int>(base.GetScrollViewWithScrollbar(3), new Func<SolarSchoolAffairsOptionItem>(this.CreateOptionItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
			this.Handler = (this.OpenParam as ISolarSchoolAffairsViewHandler);
			if (this.Handler == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.YYZ, "[SolarSchool][Affairs] 界面缺少玩法回调口，流程无法推进", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Handler.OnViewReady(this);
		}

		// Token: 0x060382A4 RID: 230052 RVA: 0x00FB3124 File Offset: 0x00FB1324
		public void ShowAffairs(SolarSchoolAffairs affairs, IReadOnlyList<int> optionIds)
		{
			this.ChoiceInteractable = true;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), affairs.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), affairs.Content, Array.Empty<object>());
			base.TrySetTextureByPath(affairs.RoleIcon, base.GetTexture(1), null, null);
			this.OptionScroll.RefreshByData(optionIds, null, true);
		}

		// Token: 0x060382A5 RID: 230053 RVA: 0x00FB319E File Offset: 0x00FB139E
		private SolarSchoolAffairsOptionItem CreateOptionItem()
		{
			return new SolarSchoolAffairsOptionItem
			{
				OnClickChoiceBack = new Action<int, int>(this.OnChoiceItemClicked),
				CanSelectFunc = (() => this.ChoiceInteractable)
			};
		}

		// Token: 0x060382A6 RID: 230054 RVA: 0x00FB31CC File Offset: 0x00FB13CC
		private void OnChoiceItemClicked(int gridIndex, int optionId)
		{
			this.ChoiceInteractable = false;
			GenericScrollViewNew<SolarSchoolAffairsOptionItem, int> optionScroll = this.OptionScroll;
			if (optionScroll != null)
			{
				optionScroll.SelectGridProxy(gridIndex, false);
			}
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(SolarSchoolGamePlayModel.Instance.GetActivityId(), "AffairsChoiceHoldDuration", 0);
			ISolarSchoolAffairsViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnChoiceSelected(optionId);
			}
			this.ClearChoiceTimer();
			this.ChoiceTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ChoiceTimer = null;
				ISolarSchoolAffairsViewHandler handler2 = this.Handler;
				if (handler2 == null)
				{
					return;
				}
				handler2.OnFinished();
			}, (float)paramInt, null, null, true, 1f);
		}

		// Token: 0x060382A7 RID: 230055 RVA: 0x00FB324C File Offset: 0x00FB144C
		private void ClearChoiceTimer()
		{
			if (this.ChoiceTimer == null)
			{
				return;
			}
			this.ChoiceTimer.Remove();
			this.ChoiceTimer = null;
		}

		// Token: 0x060382A8 RID: 230056 RVA: 0x00FB326A File Offset: 0x00FB146A
		protected override void OnBeforeDestroy()
		{
			this.ClearChoiceTimer();
			ISolarSchoolAffairsViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x0401D922 RID: 121122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SolarSchoolAffairsOptionItem, int> OptionScroll;

		// Token: 0x0401D923 RID: 121123
		[Nullable(2)]
		private ISolarSchoolAffairsViewHandler Handler;

		// Token: 0x0401D924 RID: 121124
		private bool ChoiceInteractable = true;

		// Token: 0x0401D925 RID: 121125
		[Nullable(2)]
		private TimerHandle ChoiceTimer;

		// Token: 0x0200B4BC RID: 46268
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E24 RID: 228900
			public const int TxtType = 0;

			// Token: 0x04037E25 RID: 228901
			public const int TexHead = 1;

			// Token: 0x04037E26 RID: 228902
			public const int TxtDetails = 2;

			// Token: 0x04037E27 RID: 228903
			public const int SvOption = 3;

			// Token: 0x04037E28 RID: 228904
			public const int OptionItem = 4;
		}
	}
}
