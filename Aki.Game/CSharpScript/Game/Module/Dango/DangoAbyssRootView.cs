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
	// Token: 0x02005AD9 RID: 23257
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAbyssRootView : UiViewBase
	{
		// Token: 0x0603AE5B RID: 241243 RVA: 0x00E0AE0C File Offset: 0x00E0900C
		public DangoAbyssRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AE5C RID: 241244 RVA: 0x00E0AE20 File Offset: 0x00E09020
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

		// Token: 0x0603AE5D RID: 241245 RVA: 0x00E0AF08 File Offset: 0x00E09108
		public override bool GetLoopAudioEventSwitch()
		{
			return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
		}

		// Token: 0x0603AE5E RID: 241246 RVA: 0x00E0AF17 File Offset: 0x00E09117
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		}

		// Token: 0x0603AE5F RID: 241247 RVA: 0x00E0AF35 File Offset: 0x00E09135
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
		}

		// Token: 0x0603AE60 RID: 241248 RVA: 0x00E0AF53 File Offset: 0x00E09153
		protected override void OnHandleLoadScene()
		{
			DangoAbyssController.Instance.InitAbyssDangoObserver(0);
		}

		// Token: 0x0603AE61 RID: 241249 RVA: 0x00E0AF60 File Offset: 0x00E09160
		protected override void OnHandleReleaseScene()
		{
			DangoAbyssController.Instance.DestroyAbyssDangoObserver(0);
		}

		// Token: 0x0603AE62 RID: 241250 RVA: 0x00E0AF6D File Offset: 0x00E0916D
		private void OnAbyssRoleInfoUpdate()
		{
			this.InfoPanel.OnDangoInfoUpdate();
		}

		// Token: 0x0603AE63 RID: 241251 RVA: 0x00E0AF7A File Offset: 0x00E0917A
		private DangoItem InitItem()
		{
			return new DangoItem
			{
				ViewModel = this.ViewModel
			};
		}

		// Token: 0x0603AE64 RID: 241252 RVA: 0x00E0AF90 File Offset: 0x00E09190
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssRootView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRootView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE65 RID: 241253 RVA: 0x00E0AFD4 File Offset: 0x00E091D4
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

		// Token: 0x0603AE66 RID: 241254 RVA: 0x00E0B07A File Offset: 0x00E0927A
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603AE67 RID: 241255 RVA: 0x00E0B083 File Offset: 0x00E09283
		private DangoAbyssActivityData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as DangoAbyssActivityData;
		}

		// Token: 0x0603AE68 RID: 241256 RVA: 0x00E0B09C File Offset: 0x00E0929C
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

		// Token: 0x0603AE69 RID: 241257 RVA: 0x00E0B113 File Offset: 0x00E09313
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

		// Token: 0x0603AE6A RID: 241258 RVA: 0x00E0B135 File Offset: 0x00E09335
		protected override void OnAfterDestroy()
		{
			this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		}

		// Token: 0x0603AE6B RID: 241259 RVA: 0x00E0B150 File Offset: 0x00E09350
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

		// Token: 0x0603AE6C RID: 241260 RVA: 0x00E0B1C6 File Offset: 0x00E093C6
		private void OnItemClick(DangoAbyssDefine.DangoListRoleData data)
		{
			this.OnSelectDango(data.Data);
		}

		// Token: 0x0603AE6D RID: 241261 RVA: 0x00E0B1D4 File Offset: 0x00E093D4
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

		// Token: 0x0603AE6E RID: 241262 RVA: 0x00E0B21C File Offset: 0x00E0941C
		private void OnDangoIdUpdate()
		{
			int dangoId = this.ViewModel.GetDangoId();
			DangoAbyssModel.Instance.SetDangoHasCheck(dangoId);
			EventSystem.Instance.Emit(EEventName.RefreshAbyssDevelopRedDot);
			this.Layout.RefreshWithoutDataSync();
		}

		// Token: 0x0603AE6F RID: 241263 RVA: 0x00E0B25B File Offset: 0x00E0945B
		private void OnSlotIndexUpdate()
		{
			this.ViewModel.GetSlotIndex();
		}

		// Token: 0x0603AE70 RID: 241264 RVA: 0x00E0B26C File Offset: 0x00E0946C
		protected override void OnBeforeDestroy()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DLSSPastValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0401EBD6 RID: 125910
		private int ActivityId;

		// Token: 0x0401EBD7 RID: 125911
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoItem, DangoAbyssDefine.DangoListRoleData> Layout;

		// Token: 0x0401EBD8 RID: 125912
		[Nullable(2)]
		private DangoAbyssRoleInfoItem InfoPanel;

		// Token: 0x0401EBD9 RID: 125913
		private readonly PluginEquipViewModel ViewModel = new PluginEquipViewModel();

		// Token: 0x0401EBDA RID: 125914
		private int DLSSPastValue;

		// Token: 0x0401EBDB RID: 125915
		private const int MODELINDEX = 0;

		// Token: 0x0200BD35 RID: 48437
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04039103 RID: 233731
			public const int BtnClose = 0;

			// Token: 0x04039104 RID: 233732
			public const int DangoScrollView = 1;

			// Token: 0x04039105 RID: 233733
			public const int DangoItem = 2;

			// Token: 0x04039106 RID: 233734
			public const int AttributePanel = 3;
		}
	}
}
