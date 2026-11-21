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
	// Token: 0x0200520D RID: 21005
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenTabItem : UiPanelBase
	{
		// Token: 0x0603448F RID: 214159 RVA: 0x00EA06BE File Offset: 0x00E9E8BE
		public RealmBetweenTabItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x06034490 RID: 214160 RVA: 0x00EA06D0 File Offset: 0x00E9E8D0
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

		// Token: 0x06034491 RID: 214161 RVA: 0x00EA0790 File Offset: 0x00E9E990
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

		// Token: 0x06034492 RID: 214162 RVA: 0x00EA07DB File Offset: 0x00E9E9DB
		protected override void OnStart()
		{
		}

		// Token: 0x06034493 RID: 214163 RVA: 0x00EA07DD File Offset: 0x00E9E9DD
		public void BindSelectedCallBack(Action<RealmBetweenAreaData, int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x06034494 RID: 214164 RVA: 0x00EA07E6 File Offset: 0x00E9E9E6
		public void BindIsSelectedOn(Func<RealmBetweenAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOnFunc = isSelectedOn;
		}

		// Token: 0x06034495 RID: 214165 RVA: 0x00EA07F0 File Offset: 0x00E9E9F0
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

		// Token: 0x06034496 RID: 214166 RVA: 0x00EA085C File Offset: 0x00E9EA5C
		public void Update(RealmBetweenAreaData data, int index)
		{
			this.RefreshByData(data, index);
			Func<RealmBetweenAreaData, int, bool> isSelectedOnFunc = this.IsSelectedOnFunc;
			bool bOn = isSelectedOnFunc != null && isSelectedOnFunc(data, index);
			this.SetSelected(bOn, false);
		}

		// Token: 0x06034497 RID: 214167 RVA: 0x00EA0890 File Offset: 0x00E9EA90
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, bFireEvent, false, false);
		}

		// Token: 0x06034498 RID: 214168 RVA: 0x00EA08B8 File Offset: 0x00E9EAB8
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

		// Token: 0x06034499 RID: 214169 RVA: 0x00EA099B File Offset: 0x00E9EB9B
		public void MarkNewUnlockSeen()
		{
			if (this.Data != null)
			{
				this.ActivityBaseData.SaveFirstCheckRedDotState(ERealmBetweenSaveFlag.AreaNewUnlock, this.Data.AreaId);
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0401BC30 RID: 113712
		[Nullable(2)]
		protected RealmBetweenAreaData Data;

		// Token: 0x0401BC31 RID: 113713
		protected int Index;

		// Token: 0x0401BC32 RID: 113714
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RealmBetweenAreaData, int> SelectedCallBack;

		// Token: 0x0401BC33 RID: 113715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<RealmBetweenAreaData, int, bool> IsSelectedOnFunc;

		// Token: 0x0401BC34 RID: 113716
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
