using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EFD RID: 24317
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivityPageSelectContent : GridProxyAbstract<ActivityBaseData>
	{
		// Token: 0x0603DC8F RID: 253071 RVA: 0x00EEFD44 File Offset: 0x00EEDF44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DC90 RID: 253072 RVA: 0x00EEFF5C File Offset: 0x00EEE15C
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
			this.ActivityBubbleComponent = new ActivityBubbleComponent(base.GetItem(10), base.GetSprite(11), base.GetText(12), delegate(string path, UUISprite uiSprite, bool setSize)
			{
				this.SetSpriteByPath(path, uiSprite, setSize, null, null);
			});
		}

		// Token: 0x0603DC91 RID: 253073 RVA: 0x00EEFFB5 File Offset: 0x00EEE1B5
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshActivityTab, new Action<int>(this.OnRefreshActivityTab));
		}

		// Token: 0x0603DC92 RID: 253074 RVA: 0x00EEFFD3 File Offset: 0x00EEE1D3
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshActivityTab, new Action<int>(this.OnRefreshActivityTab));
		}

		// Token: 0x0603DC93 RID: 253075 RVA: 0x00EEFFF1 File Offset: 0x00EEE1F1
		protected override void OnBeforeShow()
		{
			this.AddEventListener();
		}

		// Token: 0x0603DC94 RID: 253076 RVA: 0x00EEFFF9 File Offset: 0x00EEE1F9
		protected override void OnBeforeHide()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0603DC95 RID: 253077 RVA: 0x00EF0001 File Offset: 0x00EEE201
		private void AddTimer()
		{
			ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
			this.IsTimerEnable = true;
		}

		// Token: 0x0603DC96 RID: 253078 RVA: 0x00EF0020 File Offset: 0x00EEE220
		private void RemoveTimer()
		{
			ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
			this.IsTimerEnable = false;
		}

		// Token: 0x0603DC97 RID: 253079 RVA: 0x00EF003F File Offset: 0x00EEE23F
		private bool TryAddTimer()
		{
			if (this.IsTimerEnable)
			{
				return false;
			}
			this.AddTimer();
			return true;
		}

		// Token: 0x0603DC98 RID: 253080 RVA: 0x00EF0052 File Offset: 0x00EEE252
		private bool TryRemoveTimer()
		{
			if (!this.IsTimerEnable)
			{
				return false;
			}
			this.RemoveTimer();
			return true;
		}

		// Token: 0x0603DC99 RID: 253081 RVA: 0x00EF0065 File Offset: 0x00EEE265
		private void OnTimerRefresh(float delta)
		{
			this.ActivityBubbleComponent.RefreshBubble(this.Data);
		}

		// Token: 0x0603DC9A RID: 253082 RVA: 0x00EF0079 File Offset: 0x00EEE279
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			this.RemoveTimer();
		}

		// Token: 0x0603DC9B RID: 253083 RVA: 0x00EF0088 File Offset: 0x00EEE288
		private void OnRefreshActivityTab(int activityId)
		{
			ActivityBaseData data = this.Data;
			bool flag;
			if (data == null)
			{
				flag = false;
			}
			else
			{
				int id = data.Id;
				flag = true;
			}
			if (flag && this.Data.Id == activityId)
			{
				this.RefreshName();
				this.RefreshTime();
				this.RefreshIcon();
				this.RefreshTagIcon();
				this.RefreshRecommendIcon();
				this.RefreshTypeIcon();
				this.RefreshBubbleAndCheckTimer();
			}
		}

		// Token: 0x0603DC9C RID: 253084 RVA: 0x00EF00E4 File Offset: 0x00EEE2E4
		private void RefreshToggleState(bool selectOn, bool bFireEvent = false)
		{
			EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
			if (!bFireEvent && selectOn)
			{
				this.UpdateBubbleClickStateAndRefresh();
			}
		}

		// Token: 0x0603DC9D RID: 253085 RVA: 0x00EF0118 File Offset: 0x00EEE318
		private void OnClickItem(EToggleState toggleState)
		{
			Action<ActivityBaseData, bool> toggleClickInternal = this.ToggleClickInternal;
			if (toggleClickInternal != null)
			{
				toggleClickInternal(this.Data, toggleState == EToggleState.ETT_Checked);
			}
			if (toggleState == EToggleState.ETT_Checked)
			{
				this.UpdateBubbleClickStateAndRefresh();
			}
		}

		// Token: 0x0603DC9E RID: 253086 RVA: 0x00EF013F File Offset: 0x00EEE33F
		public void SetToggleState(bool bSelectOn, bool bFireEvent = true)
		{
			this.RefreshToggleState(bSelectOn, bFireEvent);
		}

		// Token: 0x0603DC9F RID: 253087 RVA: 0x00EF0149 File Offset: 0x00EEE349
		public void BindToggleClick(Action<ActivityBaseData, bool> func)
		{
			this.ToggleClickInternal = func;
		}

		// Token: 0x0603DCA0 RID: 253088 RVA: 0x00EF0152 File Offset: 0x00EEE352
		public void BindCanToggleExecuteChange(Func<int, bool, bool> func)
		{
			this.CanToggleExecuteChangeInternal = func;
		}

		// Token: 0x0603DCA1 RID: 253089 RVA: 0x00EF015C File Offset: 0x00EEE35C
		public unsafe override void Refresh(ActivityBaseData data, bool isSelected, int gridIndex)
		{
			try
			{
				if (this.Data != null)
				{
					this.UnBindRedDot();
				}
				this.Data = data;
				this.BindRedDot(data);
				this.RefreshToggleState(isSelected, false);
				this.RefreshName();
				this.RefreshTime();
				this.RefreshIcon();
				this.RefreshTagIcon();
				this.RefreshRecommendIcon();
				this.RefreshTypeIcon();
				this.RefreshBubbleAndCheckTimer();
			}
			catch (Exception ex)
			{
				ActivityModel instance = ActivityModel.Instance;
				ActivityBaseData data2 = this.Data;
				int activityId = (data2 != null) ? data2.Id : 0;
				ActivityBaseData data3 = this.Data;
				bool flag;
				if (data3 == null)
				{
					flag = false;
				}
				else
				{
					ActivityType type = data3.Type;
					flag = true;
				}
				instance.OpenActivityErrorConfirmBox(activityId, (int)(flag ? this.Data.Type : ActivityType.Parkour));
				if (ex != null)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "[Activity] 活动页签状态异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "id";
					ActivityBaseData data4 = this.Data;
					ptr = new ValueTuple<string, object>(item, (data4 != null) ? data4.Id : 0);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance2.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.Activity;
					ELogAuthor author2 = ELogAuthor.YYZ;
					string message2 = "[Activity] 活动页签状态异常";
					string item2 = "id";
					ActivityBaseData data5 = this.Data;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item2, (data5 != null) ? data5.Id : 0);
					instance3.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x0603DCA2 RID: 253090 RVA: 0x00EF02C8 File Offset: 0x00EEE4C8
		public override void Clear()
		{
			this.TryRemoveTimer();
		}

		// Token: 0x0603DCA3 RID: 253091 RVA: 0x00EF02D1 File Offset: 0x00EEE4D1
		private bool CanToggleExecuteChange()
		{
			Func<int, bool, bool> canToggleExecuteChangeInternal = this.CanToggleExecuteChangeInternal;
			return canToggleExecuteChangeInternal == null || canToggleExecuteChangeInternal(this.Data.Id, base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked);
		}

		// Token: 0x0603DCA4 RID: 253092 RVA: 0x00EF0300 File Offset: 0x00EEE500
		private void RefreshName()
		{
			Regex regex = new Regex("<.*?>");
			string title = this.Data.GetTitle();
			base.GetText(1).SetText(regex.Replace(title, ""), true);
		}

		// Token: 0x0603DCA5 RID: 253093 RVA: 0x00EF0340 File Offset: 0x00EEE540
		private void RefreshTime()
		{
			bool forceHideActivityTimeTextFlag = ActivityModel.Instance.GetForceHideActivityTimeTextFlag();
			bool flag = false;
			if (forceHideActivityTimeTextFlag || !flag)
			{
				base.GetText(3).SetUIActive(false);
				base.GetItem(4).SetUIActive(false);
				return;
			}
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)this.Data.BeginOpenTime);
			DateTime dataFromTimeStamp2 = TimeUtil.Instance.GetDataFromTimeStamp((double)this.Data.EndOpenTime);
			string newText = StringUtils.Format("{0}/{1}-{2}/{3}", new string[]
			{
				dataFromTimeStamp.Month.ToString(),
				dataFromTimeStamp.Day.ToString(),
				dataFromTimeStamp2.Month.ToString(),
				dataFromTimeStamp2.Day.ToString()
			});
			base.GetText(3).SetText(newText, true);
			base.GetText(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0603DCA6 RID: 253094 RVA: 0x00EF042C File Offset: 0x00EEE62C
		private void RefreshIcon()
		{
			string[] array = this.Data.LocalConfig.Value.TabTexture();
			UUITexture texture = base.GetTexture(5);
			texture.SetUIActive(false);
			if (array == null || array.Length == 0)
			{
				return;
			}
			int num = 0;
			if (array.Length >= 2)
			{
				num = ((PlayerInfoModel.Instance.GetPlayerGender() > EPlayerGender.Female) ? 1 : 0);
			}
			base.SetTextureByPath(array[num], texture, null, delegate(bool _)
			{
				texture.SetUIActive(true);
			});
			bool finishShowState = this.Data.FinishShowState;
			base.GetItem(6).SetUIActive(finishShowState);
		}

		// Token: 0x0603DCA7 RID: 253095 RVA: 0x00EF04D0 File Offset: 0x00EEE6D0
		private void RefreshTagIcon()
		{
			string tabTagIcon = this.Data.LocalConfig.Value.TabTagIcon;
			UUISprite tagIcon = base.GetSprite(7);
			bool flag = !string.IsNullOrEmpty(tabTagIcon);
			tagIcon.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(tabTagIcon, tagIcon, true, null, delegate(bool _)
				{
					(tagIcon.GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition).SetAllStateSprite(tagIcon.GetSprite());
				});
			}
		}

		// Token: 0x0603DCA8 RID: 253096 RVA: 0x00EF0548 File Offset: 0x00EEE748
		private void RefreshRecommendIcon()
		{
			bool finishShowState = this.Data.FinishShowState;
			bool flag = this.Data.TimeType == EActivityTimeType.TimeLimit;
			base.GetSprite(9).SetUIActive(this.Data.LocalConfig.Value.IsTabEffectNotice && !finishShowState && flag);
		}

		// Token: 0x0603DCA9 RID: 253097 RVA: 0x00EF05A0 File Offset: 0x00EEE7A0
		private void RefreshTypeIcon()
		{
			int showTabTypeId = this.Data.LocalConfig.Value.ShowTabTypeId;
			ActivityTitleTags? activityTitleTags = ActivityConfig.Instance.GetActivityTitleTags(showTabTypeId);
			if (activityTitleTags == null)
			{
				return;
			}
			string tagIcon = activityTitleTags.Value.TagIcon;
			UUISprite sprite = base.GetSprite(8);
			bool flag = !string.IsNullOrEmpty(tagIcon);
			sprite.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(tagIcon, sprite, true, null, null);
			}
		}

		// Token: 0x0603DCAA RID: 253098 RVA: 0x00EF0621 File Offset: 0x00EEE821
		private void BindRedDot(ActivityBaseData data)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(2), null, data.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			this.IsBindRed = true;
		}

		// Token: 0x0603DCAB RID: 253099 RVA: 0x00EF065A File Offset: 0x00EEE85A
		private void UnBindRedDot()
		{
			if (this.IsBindRed)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(2), this.Data.Id);
				this.IsBindRed = false;
			}
		}

		// Token: 0x0603DCAC RID: 253100 RVA: 0x00EF0689 File Offset: 0x00EEE889
		public void RefreshBubbleAndCheckTimer()
		{
			if (this.ActivityBubbleComponent.RefreshBubble(this.Data))
			{
				this.TryAddTimer();
				return;
			}
			this.TryRemoveTimer();
		}

		// Token: 0x0603DCAD RID: 253101 RVA: 0x00EF06AD File Offset: 0x00EEE8AD
		private void UpdateBubbleClickStateAndRefresh()
		{
			if (this.ActivityBubbleComponent.CheckToUpdateBubbleClickState())
			{
				this.RefreshBubbleAndCheckTimer();
			}
		}

		// Token: 0x0603DCAE RID: 253102 RVA: 0x00EF06C2 File Offset: 0x00EEE8C2
		public override object GetKey(ActivityBaseData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x04020483 RID: 132227
		[Nullable(2)]
		private ActivityBaseData Data;

		// Token: 0x04020484 RID: 132228
		[Nullable(2)]
		private Func<int, bool, bool> CanToggleExecuteChangeInternal;

		// Token: 0x04020485 RID: 132229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ActivityBaseData, bool> ToggleClickInternal;

		// Token: 0x04020486 RID: 132230
		private bool IsBindRed;

		// Token: 0x04020487 RID: 132231
		[Nullable(2)]
		private ActivityBubbleComponent ActivityBubbleComponent;

		// Token: 0x04020488 RID: 132232
		private bool IsTimerEnable;

		// Token: 0x0200C22F RID: 49711
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403AABE RID: 240318
			public const int Toggle = 0;

			// Token: 0x0403AABF RID: 240319
			public const int NameText = 1;

			// Token: 0x0403AAC0 RID: 240320
			public const int RedDot = 2;

			// Token: 0x0403AAC1 RID: 240321
			public const int TimeText = 3;

			// Token: 0x0403AAC2 RID: 240322
			public const int SpriteTime = 4;

			// Token: 0x0403AAC3 RID: 240323
			public const int TextureIcon = 5;

			// Token: 0x0403AAC4 RID: 240324
			public const int PanelFinish = 6;

			// Token: 0x0403AAC5 RID: 240325
			public const int TagIcon = 7;

			// Token: 0x0403AAC6 RID: 240326
			public const int SpriteTypeIcon = 8;

			// Token: 0x0403AAC7 RID: 240327
			public const int SpriteRecommend = 9;

			// Token: 0x0403AAC8 RID: 240328
			public const int ItemBubble = 10;

			// Token: 0x0403AAC9 RID: 240329
			public const int SpriteBubble = 11;

			// Token: 0x0403AACA RID: 240330
			public const int TxtRemainTime = 12;
		}
	}
}
