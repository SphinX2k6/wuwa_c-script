using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200628F RID: 25231
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenTabItem : UiPanelBase
	{
		// Token: 0x0603F7CE RID: 260046 RVA: 0x00F59762 File Offset: 0x00F57962
		public RealmBetweenTabItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F7CF RID: 260047 RVA: 0x00F59774 File Offset: 0x00F57974
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectOn))
			};
		}

		// Token: 0x0603F7D0 RID: 260048 RVA: 0x00F59834 File Offset: 0x00F57A34
		public UniTask Init(UUIItem actor)
		{
			RealmBetweenTabItem.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RealmBetweenTabItem.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603F7D1 RID: 260049 RVA: 0x00F5987F File Offset: 0x00F57A7F
		protected override void OnStart()
		{
		}

		// Token: 0x0603F7D2 RID: 260050 RVA: 0x00F59881 File Offset: 0x00F57A81
		public void BindSelectedCallBack(Action<RealmBetweenAreaData, int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x0603F7D3 RID: 260051 RVA: 0x00F5988A File Offset: 0x00F57A8A
		public void BindIsSelectedOn(Func<RealmBetweenAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOnFunc = isSelectedOn;
		}

		// Token: 0x0603F7D4 RID: 260052 RVA: 0x00F59894 File Offset: 0x00F57A94
		private void OnToggleSelectOn(EToggleState state)
		{
			if (this.Data != null)
			{
				this.ActivityBaseData.SaveFirstCheckRedDotState(ERealmBetweenSaveFlag.AreaNewUnlock, this.Data.AreaId);
				this.RefreshByData(this.Data, this.Index);
				Action<RealmBetweenAreaData, int> selectedCallBack = this.SelectedCallBack;
				if (selectedCallBack != null)
				{
					selectedCallBack(this.Data, this.Index);
				}
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0603F7D5 RID: 260053 RVA: 0x00F59900 File Offset: 0x00F57B00
		public void Update(RealmBetweenAreaData data, int index)
		{
			this.RefreshByData(data, index);
			Func<RealmBetweenAreaData, int, bool> isSelectedOnFunc = this.IsSelectedOnFunc;
			bool bOn = isSelectedOnFunc != null && isSelectedOnFunc(data, index);
			this.SetSelected(bOn, false);
		}

		// Token: 0x0603F7D6 RID: 260054 RVA: 0x00F59934 File Offset: 0x00F57B34
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, bFireEvent, false, false);
		}

		// Token: 0x0603F7D7 RID: 260055 RVA: 0x00F5995C File Offset: 0x00F57B5C
		private void RefreshByData(RealmBetweenAreaData data, int index)
		{
			this.Data = data;
			this.Index = index;
			Area value = AreaConfig.Instance.GetAreaInfo(data.AreaId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
			bool uiactive = data.IsUnlock && this.ActivityBaseData.IsAreaTaskFinish(data.AreaId);
			bool flag = data.IsUnlock && this.ActivityBaseData.GetAreaRewardState(data.AreaId);
			bool areaNewUnlockState = this.ActivityBaseData.GetAreaNewUnlockState(data.AreaId);
			base.GetItem(2).SetUIActive(uiactive);
			base.GetItem(3).SetUIActive(!data.IsUnlock);
			base.GetItem(4).SetUIActive(flag && !areaNewUnlockState);
			base.GetItem(5).SetUIActive(areaNewUnlockState);
		}

		// Token: 0x0603F7D8 RID: 260056 RVA: 0x00F59A3F File Offset: 0x00F57C3F
		public void MarkNewUnlockSeen()
		{
			if (this.Data != null)
			{
				this.ActivityBaseData.SaveFirstCheckRedDotState(ERealmBetweenSaveFlag.AreaNewUnlock, this.Data.AreaId);
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x04021301 RID: 135937
		[Nullable(2)]
		protected RealmBetweenAreaData Data;

		// Token: 0x04021302 RID: 135938
		protected int Index;

		// Token: 0x04021303 RID: 135939
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RealmBetweenAreaData, int> SelectedCallBack;

		// Token: 0x04021304 RID: 135940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<RealmBetweenAreaData, int, bool> IsSelectedOnFunc;

		// Token: 0x04021305 RID: 135941
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
