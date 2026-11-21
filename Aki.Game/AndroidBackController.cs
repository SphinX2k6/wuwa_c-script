using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B9C RID: 2972
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AndroidBackController : UiControllerBase
{
	// Token: 0x06007BCE RID: 31694 RVA: 0x0026579F File Offset: 0x0026399F
	protected override bool OnInit()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			this.IsLogOpen = true;
		}
		return true;
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x002657B5 File Offset: 0x002639B5
	protected override void OnAddEvents()
	{
		InputDistributeController.Instance.BindKey("Android_Back", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAndroidBackEvent));
	}

	// Token: 0x06007BD0 RID: 31696 RVA: 0x002657D2 File Offset: 0x002639D2
	protected override void OnRemoveEvents()
	{
		InputDistributeController.Instance.UnBindKey("Android_Back", new TInputHandle<InputDistributeDefine.EActionType>(this.OnAndroidBackEvent));
	}

	// Token: 0x06007BD1 RID: 31697 RVA: 0x002657F0 File Offset: 0x002639F0
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

	// Token: 0x06007BD2 RID: 31698 RVA: 0x00265890 File Offset: 0x00263A90
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

	// Token: 0x06007BD3 RID: 31699 RVA: 0x00265980 File Offset: 0x00263B80
	private void ClickButtonInternal(UUIAndroidBackComponent component)
	{
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor != null)
		{
			lguiEventSystemActor.SimulateClickButton(1, component.RootUIComp, new FVector2D?(component.ClickPivot));
		}
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x002659B9 File Offset: 0x00263BB9
	protected override bool OnClear()
	{
		UUIAndroidBackComponent.ClearAndroidBackComponent();
		return true;
	}

	// Token: 0x06007BD5 RID: 31701 RVA: 0x002659C4 File Offset: 0x00263BC4
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

	// Token: 0x06007BD6 RID: 31702 RVA: 0x00265AD5 File Offset: 0x00263CD5
	private void CloseTestAndroidBack()
	{
		(this.TestAndroidBack.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent).OnClickCallBack.Unbind();
		this.TestAndroidBack.K2_DestroyActor();
		this.TestAndroidBack = null;
	}

	// Token: 0x17000E0D RID: 3597
	// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x00265B0D File Offset: 0x00263D0D
	public static AndroidBackController Instance
	{
		get
		{
			return AndroidBackController._Instance;
		}
	}

	// Token: 0x06007BD8 RID: 31704 RVA: 0x00265B14 File Offset: 0x00263D14
	public static AndroidBackController GetOrCreateInstance()
	{
		if (AndroidBackController._Instance == null)
		{
			AndroidBackController.CreateInstance();
		}
		return AndroidBackController._Instance;
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x00265B28 File Offset: 0x00263D28
	public static bool CreateInstance()
	{
		if (AndroidBackController._Instance != null)
		{
			return true;
		}
		AndroidBackController._Instance = new AndroidBackController();
		return true;
	}

	// Token: 0x06007BDA RID: 31706 RVA: 0x00265B3E File Offset: 0x00263D3E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x00265B40 File Offset: 0x00263D40
	public static void ResetStaticDefaultValue()
	{
		AndroidBackController._Instance = null;
	}

	// Token: 0x06007BDC RID: 31708 RVA: 0x00265B48 File Offset: 0x00263D48
	static AndroidBackController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AndroidBackController.CreateStaticDefaultValue), new Action(AndroidBackController.ResetStaticDefaultValue));
	}

	// Token: 0x04004C53 RID: 19539
	private const int ANDROID_BACK_POINT_ID = 1;

	// Token: 0x04004C54 RID: 19540
	public bool IsLogOpen;

	// Token: 0x04004C55 RID: 19541
	[Nullable(2)]
	private AActor TestAndroidBack;

	// Token: 0x04004C56 RID: 19542
	[Nullable(2)]
	private static AndroidBackController _Instance;
}
