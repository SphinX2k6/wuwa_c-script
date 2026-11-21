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
	// Token: 0x02004EE4 RID: 20196
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivityPageSelectContent : GridProxyAbstract<ActivityBaseData>
	{
		// Token: 0x06032C2A RID: 207914 RVA: 0x00E41A08 File Offset: 0x00E3FC08
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

		// Token: 0x06032C2B RID: 207915 RVA: 0x00E41C20 File Offset: 0x00E3FE20
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
			this.ActivityBubbleComponent = new ActivityBubbleComponent(base.GetItem(10), base.GetSprite(11), base.GetText(12), delegate(string path, UUISprite uiSprite, bool setSize)
			{
				this.SetSpriteByPath(path, uiSprite, setSize, null, null);
			});
		}

		// Token: 0x06032C2C RID: 207916 RVA: 0x00E41C79 File Offset: 0x00E3FE79
		protected void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshActivityTab, new Action<int>(this.OnRefreshActivityTab));
		}

		// Token: 0x06032C2D RID: 207917 RVA: 0x00E41C97 File Offset: 0x00E3FE97
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshActivityTab, new Action<int>(this.OnRefreshActivityTab));
		}

		// Token: 0x06032C2E RID: 207918 RVA: 0x00E41CB5 File Offset: 0x00E3FEB5
		protected override void OnBeforeShow()
		{
			this.AddEventListener();
		}

		// Token: 0x06032C2F RID: 207919 RVA: 0x00E41CBD File Offset: 0x00E3FEBD
		protected override void OnBeforeHide()
		{
			this.RemoveEventListener();
		}

		// Token: 0x06032C30 RID: 207920 RVA: 0x00E41CC5 File Offset: 0x00E3FEC5
		private void AddTimer()
		{
			ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
			this.IsTimerEnable = true;
		}

		// Token: 0x06032C31 RID: 207921 RVA: 0x00E41CE4 File Offset: 0x00E3FEE4
		private void RemoveTimer()
		{
			ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
			this.IsTimerEnable = false;
		}

		// Token: 0x06032C32 RID: 207922 RVA: 0x00E41D03 File Offset: 0x00E3FF03
		private bool TryAddTimer()
		{
			if (this.IsTimerEnable)
			{
				return false;
			}
			this.AddTimer();
			return true;
		}

		// Token: 0x06032C33 RID: 207923 RVA: 0x00E41D16 File Offset: 0x00E3FF16
		private bool TryRemoveTimer()
		{
			if (!this.IsTimerEnable)
			{
				return false;
			}
			this.RemoveTimer();
			return true;
		}

		// Token: 0x06032C34 RID: 207924 RVA: 0x00E41D29 File Offset: 0x00E3FF29
		private void OnTimerRefresh(float delta)
		{
			this.ActivityBubbleComponent.RefreshBubble(this.Data);
		}

		// Token: 0x06032C35 RID: 207925 RVA: 0x00E41D3D File Offset: 0x00E3FF3D
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			this.RemoveTimer();
		}

		// Token: 0x06032C36 RID: 207926 RVA: 0x00E41D4C File Offset: 0x00E3FF4C
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

		// Token: 0x06032C37 RID: 207927 RVA: 0x00E41DA8 File Offset: 0x00E3FFA8
		private void RefreshToggleState(bool selectOn, bool bFireEvent = false)
		{
			EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
			if (!bFireEvent && selectOn)
			{
				this.UpdateBubbleClickStateAndRefresh();
			}
		}

		// Token: 0x06032C38 RID: 207928 RVA: 0x00E41DDC File Offset: 0x00E3FFDC
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

		// Token: 0x06032C39 RID: 207929 RVA: 0x00E41E03 File Offset: 0x00E40003
		public void SetToggleState(bool bSelectOn, bool bFireEvent = true)
		{
			this.RefreshToggleState(bSelectOn, bFireEvent);
		}

		// Token: 0x06032C3A RID: 207930 RVA: 0x00E41E0D File Offset: 0x00E4000D
		public void BindToggleClick(Action<ActivityBaseData, bool> func)
		{
			this.ToggleClickInternal = func;
		}

		// Token: 0x06032C3B RID: 207931 RVA: 0x00E41E16 File Offset: 0x00E40016
		public void BindCanToggleExecuteChange(Func<int, bool, bool> func)
		{
			this.CanToggleExecuteChangeInternal = func;
		}

		// Token: 0x06032C3C RID: 207932 RVA: 0x00E41E20 File Offset: 0x00E40020
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

		// Token: 0x06032C3D RID: 207933 RVA: 0x00E41F8C File Offset: 0x00E4018C
		public override void Clear()
		{
			this.TryRemoveTimer();
		}

		// Token: 0x06032C3E RID: 207934 RVA: 0x00E41F95 File Offset: 0x00E40195
		private bool CanToggleExecuteChange()
		{
			Func<int, bool, bool> canToggleExecuteChangeInternal = this.CanToggleExecuteChangeInternal;
			return canToggleExecuteChangeInternal == null || canToggleExecuteChangeInternal(this.Data.Id, base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked);
		}

		// Token: 0x06032C3F RID: 207935 RVA: 0x00E41FC4 File Offset: 0x00E401C4
		private void RefreshName()
		{
			Regex regex = new Regex("<.*?>");
			string title = this.Data.GetTitle();
			base.GetText(1).SetText(regex.Replace(title, ""), true);
		}

		// Token: 0x06032C40 RID: 207936 RVA: 0x00E42004 File Offset: 0x00E40204
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

		// Token: 0x06032C41 RID: 207937 RVA: 0x00E420F0 File Offset: 0x00E402F0
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

		// Token: 0x06032C42 RID: 207938 RVA: 0x00E42194 File Offset: 0x00E40394
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

		// Token: 0x06032C43 RID: 207939 RVA: 0x00E4220C File Offset: 0x00E4040C
		private void RefreshRecommendIcon()
		{
			bool finishShowState = this.Data.FinishShowState;
			bool flag = this.Data.TimeType == EActivityTimeType.TimeLimit;
			base.GetSprite(9).SetUIActive(this.Data.LocalConfig.Value.IsTabEffectNotice && !finishShowState && flag);
		}

		// Token: 0x06032C44 RID: 207940 RVA: 0x00E42264 File Offset: 0x00E40464
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

		// Token: 0x06032C45 RID: 207941 RVA: 0x00E422E5 File Offset: 0x00E404E5
		private void BindRedDot(ActivityBaseData data)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(2), null, data.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
			this.IsBindRed = true;
		}

		// Token: 0x06032C46 RID: 207942 RVA: 0x00E4231E File Offset: 0x00E4051E
		private void UnBindRedDot()
		{
			if (this.IsBindRed)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(2), this.Data.Id);
				this.IsBindRed = false;
			}
		}

		// Token: 0x06032C47 RID: 207943 RVA: 0x00E4234D File Offset: 0x00E4054D
		public void RefreshBubbleAndCheckTimer()
		{
			if (this.ActivityBubbleComponent.RefreshBubble(this.Data))
			{
				this.TryAddTimer();
				return;
			}
			this.TryRemoveTimer();
		}

		// Token: 0x06032C48 RID: 207944 RVA: 0x00E42371 File Offset: 0x00E40571
		private void UpdateBubbleClickStateAndRefresh()
		{
			if (this.ActivityBubbleComponent.CheckToUpdateBubbleClickState())
			{
				this.RefreshBubbleAndCheckTimer();
			}
		}

		// Token: 0x06032C49 RID: 207945 RVA: 0x00E42386 File Offset: 0x00E40586
		public override object GetKey(ActivityBaseData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401AF55 RID: 110421
		[Nullable(2)]
		private ActivityBaseData Data;

		// Token: 0x0401AF56 RID: 110422
		[Nullable(2)]
		private Func<int, bool, bool> CanToggleExecuteChangeInternal;

		// Token: 0x0401AF57 RID: 110423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ActivityBaseData, bool> ToggleClickInternal;

		// Token: 0x0401AF58 RID: 110424
		private bool IsBindRed;

		// Token: 0x0401AF59 RID: 110425
		[Nullable(2)]
		private ActivityBubbleComponent ActivityBubbleComponent;

		// Token: 0x0401AF5A RID: 110426
		private bool IsTimerEnable;

		// Token: 0x0200AC3D RID: 44093
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040354B2 RID: 218290
			public const int Toggle = 0;

			// Token: 0x040354B3 RID: 218291
			public const int NameText = 1;

			// Token: 0x040354B4 RID: 218292
			public const int RedDot = 2;

			// Token: 0x040354B5 RID: 218293
			public const int TimeText = 3;

			// Token: 0x040354B6 RID: 218294
			public const int SpriteTime = 4;

			// Token: 0x040354B7 RID: 218295
			public const int TextureIcon = 5;

			// Token: 0x040354B8 RID: 218296
			public const int PanelFinish = 6;

			// Token: 0x040354B9 RID: 218297
			public const int TagIcon = 7;

			// Token: 0x040354BA RID: 218298
			public const int SpriteTypeIcon = 8;

			// Token: 0x040354BB RID: 218299
			public const int SpriteRecommend = 9;

			// Token: 0x040354BC RID: 218300
			public const int ItemBubble = 10;

			// Token: 0x040354BD RID: 218301
			public const int SpriteBubble = 11;

			// Token: 0x040354BE RID: 218302
			public const int TxtRemainTime = 12;
		}
	}
}
