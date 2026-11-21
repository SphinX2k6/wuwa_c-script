using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004ABA RID: 19130
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAbyssRootView : UiViewBase
	{
		// Token: 0x0602FDCD RID: 196045 RVA: 0x00D5BAF4 File Offset: 0x00D59CF4
		public DangoAbyssRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FDCE RID: 196046 RVA: 0x00D5BB08 File Offset: 0x00D59D08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FDCF RID: 196047 RVA: 0x00D5BBF0 File Offset: 0x00D59DF0
		public override bool GetBgmSwitch()
		{
			return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
		}

		// Token: 0x0602FDD0 RID: 196048 RVA: 0x00D5BBFF File Offset: 0x00D59DFF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		}

		// Token: 0x0602FDD1 RID: 196049 RVA: 0x00D5BC1D File Offset: 0x00D59E1D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		}

		// Token: 0x0602FDD2 RID: 196050 RVA: 0x00D5BC3B File Offset: 0x00D59E3B
		protected override void OnHandleLoadScene()
		{
			DangoAbyssController.Instance.InitAbyssDangoObserver(0);
		}

		// Token: 0x0602FDD3 RID: 196051 RVA: 0x00D5BC48 File Offset: 0x00D59E48
		protected override void OnHandleReleaseScene()
		{
			DangoAbyssController.Instance.DestroyAbyssDangoObserver(0);
		}

		// Token: 0x0602FDD4 RID: 196052 RVA: 0x00D5BC55 File Offset: 0x00D59E55
		private void OnAbyssRoleInfoUpdate()
		{
			this.InfoPanel.OnDangoInfoUpdate();
		}

		// Token: 0x0602FDD5 RID: 196053 RVA: 0x00D5BC62 File Offset: 0x00D59E62
		private DangoItem InitItem()
		{
			return new DangoItem
			{
				ViewModel = this.ViewModel
			};
		}

		// Token: 0x0602FDD6 RID: 196054 RVA: 0x00D5BC78 File Offset: 0x00D59E78
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssRootView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRootView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDD7 RID: 196055 RVA: 0x00D5BCBC File Offset: 0x00D59EBC
		protected override void OnStart()
		{
			this.DLSSPastValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.DLSS.Enable");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
			DangoRootViewData dangoRootViewData = this.OpenParam as DangoRootViewData;
			this.ActivityId = dangoRootViewData.ActivityId;
			int num = dangoRootViewData.DangoId;
			if (num == 0)
			{
				AbyssDangoRoleData[] allDangoList = this.GetActivityData().GetAllDangoList();
				if (allDangoList.Length != 0)
				{
					num = allDangoList[0].GetId();
				}
			}
			this.ViewModel.SetDangoId(num, false);
			this.Layout = new GenericLayout<DangoItem, DangoAbyssDefine.DangoListRoleData>(base.GetVerticalLayout(1), new Func<DangoItem>(this.InitItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0602FDD8 RID: 196056 RVA: 0x00D5BD62 File Offset: 0x00D59F62
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602FDD9 RID: 196057 RVA: 0x00D5BD6B File Offset: 0x00D59F6B
		private DangoAbyssActivityData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as DangoAbyssActivityData;
		}

		// Token: 0x0602FDDA RID: 196058 RVA: 0x00D5BD84 File Offset: 0x00D59F84
		protected override void OnBeforeShow()
		{
			this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
			if (this.GetActivityData().GetAllDangoList().Length == 0)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.YZY, "没有团子数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int dangoId = this.ViewModel.GetDangoId();
			AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
			this.OnSelectDango(dangoAbyssRoleData);
			this.RefreshLayout();
		}

		// Token: 0x0602FDDB RID: 196059 RVA: 0x00D5BDFB File Offset: 0x00D59FFB
		private void OnDataUpdate(EPluginEquipViewData key)
		{
			switch (key)
			{
			case EPluginEquipViewData.DangoId:
				this.OnDangoIdUpdate();
				return;
			case EPluginEquipViewData.SlotIndex:
				this.OnSlotIndexUpdate();
				break;
			case EPluginEquipViewData.PluginItem:
				break;
			default:
				return;
			}
		}

		// Token: 0x0602FDDC RID: 196060 RVA: 0x00D5BE1D File Offset: 0x00D5A01D
		protected override void OnAfterDestroy()
		{
			this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		}

		// Token: 0x0602FDDD RID: 196061 RVA: 0x00D5BE38 File Offset: 0x00D5A038
		private void RefreshLayout()
		{
			List<DangoAbyssDefine.DangoListRoleData> list = new List<DangoAbyssDefine.DangoListRoleData>();
			foreach (AbyssDangoRoleData abyssDangoRoleData in this.GetActivityData().GetAllDangoList())
			{
				list.Add(new DangoAbyssDefine.DangoListRoleData
				{
					Data = abyssDangoRoleData,
					Id = abyssDangoRoleData.GetId(),
					OnClickCallBack = new Action<DangoAbyssDefine.DangoListRoleData>(this.OnItemClick)
				});
			}
			this.Layout.RefreshByData(list, null, false);
		}

		// Token: 0x0602FDDE RID: 196062 RVA: 0x00D5BEAE File Offset: 0x00D5A0AE
		private void OnItemClick(DangoAbyssDefine.DangoListRoleData data)
		{
			this.OnSelectDango(data.Data);
		}

		// Token: 0x0602FDDF RID: 196063 RVA: 0x00D5BEBC File Offset: 0x00D5A0BC
		[NullableContext(2)]
		private void OnSelectDango(AbyssDangoRoleData dangoData)
		{
			if (dangoData == null)
			{
				return;
			}
			int id = dangoData.GetId();
			this.ViewModel.SetDangoId(id, false);
			DangoAbyssController.Instance.RefreshAbyssDangoModel(0, id, "MonsterCase", null);
			EventSystem.Instance.Emit<int>(EEventName.OnAbyssPluginDangoSelect, id);
		}

		// Token: 0x0602FDE0 RID: 196064 RVA: 0x00D5BF04 File Offset: 0x00D5A104
		private void OnDangoIdUpdate()
		{
			int dangoId = this.ViewModel.GetDangoId();
			DangoAbyssModel.Instance.SetDangoHasCheck(dangoId);
			EventSystem.Instance.Emit(EEventName.RefreshAbyssDevelopRedDot);
			this.Layout.RefreshWithoutDataSync();
		}

		// Token: 0x0602FDE1 RID: 196065 RVA: 0x00D5BF43 File Offset: 0x00D5A143
		private void OnSlotIndexUpdate()
		{
			this.ViewModel.GetSlotIndex();
		}

		// Token: 0x0602FDE2 RID: 196066 RVA: 0x00D5BF54 File Offset: 0x00D5A154
		protected override void OnBeforeDestroy()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DLSSPastValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x04019692 RID: 104082
		private int ActivityId;

		// Token: 0x04019693 RID: 104083
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoItem, DangoAbyssDefine.DangoListRoleData> Layout;

		// Token: 0x04019694 RID: 104084
		[Nullable(2)]
		private DangoAbyssRoleInfoItem InfoPanel;

		// Token: 0x04019695 RID: 104085
		private readonly PluginEquipViewModel ViewModel = new PluginEquipViewModel();

		// Token: 0x04019696 RID: 104086
		private int DLSSPastValue;

		// Token: 0x04019697 RID: 104087
		private const int MODELINDEX = 0;

		// Token: 0x0200A73D RID: 42813
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04033ACD RID: 211661
			public const int BtnClose = 0;

			// Token: 0x04033ACE RID: 211662
			public const int DangoScrollView = 1;

			// Token: 0x04033ACF RID: 211663
			public const int DangoItem = 2;

			// Token: 0x04033AD0 RID: 211664
			public const int AttributePanel = 3;
		}
	}
}
