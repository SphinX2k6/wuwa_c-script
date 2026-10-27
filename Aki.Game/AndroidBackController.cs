using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016E4 RID: 5860
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AndroidBackController : UiControllerBase
{
	// Token: 0x0600A7EE RID: 42990 RVA: 0x0025B397 File Offset: 0x00259597
	protected override bool OnInit()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			this.IsLogOpen = true;
		}
		return true;
	}

	// Token: 0x0600A7EF RID: 42991 RVA: 0x0025B3AD File Offset: 0x002595AD
	protected override void OnAddEvents()
	{
		InputDistributeController.Instance.BindKey("Android_Back", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAndroidBackEvent));
	}

	// Token: 0x0600A7F0 RID: 42992 RVA: 0x0025B3CA File Offset: 0x002595CA
	protected override void OnRemoveEvents()
	{
		InputDistributeController.Instance.UnBindKey("Android_Back", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAndroidBackEvent));
	}

	// Token: 0x0600A7F1 RID: 42993 RVA: 0x0025B3E8 File Offset: 0x002595E8
	private void OnAndroidBackEvent(string keyName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			return;
		}
		if (this.IsLogOpen)
		{
			Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "安卓返回键触发", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (UUIAndroidBackComponent.GetActiveAndroidBackComponentSize() <= 0)
		{
			this.HandleAndroidBackEmpty();
			return;
		}
		UUIAndroidBackComponent topActiveAndroidBack = UUIAndroidBackComponent.GetTopActiveAndroidBack();
		if (this.IsLogOpen)
		{
			string empty = string.Empty;
			ULGUIBPLibrary.GetFullPathOfActor(GlobalData.World, topActiveAndroidBack.GetOwner(), ref empty);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AndroidBack;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "触发了关闭按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("按钮的节点路径", empty);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.ClickButtonInternal(topActiveAndroidBack);
	}

	// Token: 0x0600A7F2 RID: 42994 RVA: 0x0025B488 File Offset: 0x00259688
	private void HandleAndroidBackEmpty()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.LoginView))
		{
			if (this.IsLogOpen)
			{
				Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "在登录界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			ConfirmBoxController.Instance.ShowExitGameConfirmBox();
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.BattleView))
		{
			if (this.IsLogOpen)
			{
				Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "不在主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return;
		}
		if (LoadingModel.Instance.IsLoading)
		{
			if (this.IsLogOpen)
			{
				Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "loading界面打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return;
		}
		if (this.IsLogOpen)
		{
			Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "当前处于主界面并且不在loading界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		ConfirmBoxController.Instance.ShowReturnLoginConfirmBox();
	}

	// Token: 0x0600A7F3 RID: 42995 RVA: 0x0025B578 File Offset: 0x00259778
	private void ClickButtonInternal(UUIAndroidBackComponent component)
	{
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor != null)
		{
			lguiEventSystemActor.SimulateClickButton(1, component.RootUIComp, new FVector2D?(component.ClickPivot));
		}
	}

	// Token: 0x0600A7F4 RID: 42996 RVA: 0x0025B5B1 File Offset: 0x002597B1
	protected override bool OnClear()
	{
		UUIAndroidBackComponent.ClearAndroidBackComponent();
		return true;
	}

	// Token: 0x0600A7F5 RID: 42997 RVA: 0x0025B5BC File Offset: 0x002597BC
	public void GmTestAndroidBack()
	{
		if (this.TestAndroidBack != null)
		{
			this.CloseTestAndroidBack();
			return;
		}
		UPrefabAsset prefabAsset = ResourceSystem.Instance.Load<UPrefabAsset>("/Game/Aki/UI/UIResources/Common/Prefabs/UiItem_BackBtn1.UiItem_BackBtn1", "Debug");
		this.TestAndroidBack = ULGUIBPLibrary.LoadPrefabWithAsset(GlobalData.World, prefabAsset, UiLayer.Instance.GetLayerRootUiItem(ELayerType.Debug));
		UUIItem uuiitem = this.TestAndroidBack.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		uuiitem.SetDisplayName("GmTestAndroidBack");
		uuiitem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		uuiitem.SetAnchorOffset(new FVector2D(0f, 0f));
		UUIButtonComponent uuibuttonComponent = this.TestAndroidBack.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
		UUIAndroidBackComponent uuiandroidBackComponent = this.TestAndroidBack.GetComponentByClass(UUIAndroidBackComponent.StaticClass()) as UUIAndroidBackComponent;
		if (uuiandroidBackComponent != null)
		{
			this.TestAndroidBack.K2_DestroyComponent(uuiandroidBackComponent);
		}
		uuibuttonComponent.OnClickCallBack.Bind(delegate()
		{
			Log.Instance.Info(ELogModule.AndroidBack, ELogAuthor.XXJ, "安卓返回点击", default(ReadOnlySpan<ValueTuple<string, object>>));
			InputDistributeController.Instance.InputKey("Android_Back", true);
			InputDistributeController.Instance.InputKey("Android_Back", false);
		});
		LguiUtil.Instance.SetActorIsPermanent(this.TestAndroidBack, true, true);
	}

	// Token: 0x0600A7F6 RID: 42998 RVA: 0x0025B6CD File Offset: 0x002598CD
	private void CloseTestAndroidBack()
	{
		(this.TestAndroidBack.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent).OnClickCallBack.Unbind();
		this.TestAndroidBack.K2_DestroyActor();
		this.TestAndroidBack = null;
	}

	// Token: 0x17000DEC RID: 3564
	// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x0025B705 File Offset: 0x00259905
	public static AndroidBackController Instance
	{
		get
		{
			return AndroidBackController._Instance;
		}
	}

	// Token: 0x0600A7F8 RID: 43000 RVA: 0x0025B70C File Offset: 0x0025990C
	public static AndroidBackController GetOrCreateInstance()
	{
		if (AndroidBackController._Instance == null)
		{
			AndroidBackController.CreateInstance();
		}
		return AndroidBackController._Instance;
	}

	// Token: 0x0600A7F9 RID: 43001 RVA: 0x0025B720 File Offset: 0x00259920
	public static bool CreateInstance()
	{
		if (AndroidBackController._Instance != null)
		{
			return true;
		}
		AndroidBackController._Instance = new AndroidBackController();
		return true;
	}

	// Token: 0x0600A7FA RID: 43002 RVA: 0x0025B736 File Offset: 0x00259936
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A7FB RID: 43003 RVA: 0x0025B738 File Offset: 0x00259938
	public static void ResetStaticDefaultValue()
	{
		AndroidBackController._Instance = null;
	}

	// Token: 0x0600A7FC RID: 43004 RVA: 0x0025B740 File Offset: 0x00259940
	static AndroidBackController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AndroidBackController.CreateStaticDefaultValue), new Action(AndroidBackController.ResetStaticDefaultValue));
	}

	// Token: 0x04004BAC RID: 19372
	private const int ANDROID_BACK_POINT_ID = 1;

	// Token: 0x04004BAD RID: 19373
	public bool IsLogOpen;

	// Token: 0x04004BAE RID: 19374
	[Nullable(2)]
	private AActor TestAndroidBack;

	// Token: 0x04004BAF RID: 19375
	[Nullable(2)]
	private static AndroidBackController _Instance;
}
