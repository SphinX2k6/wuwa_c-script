using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002265 RID: 8805
public class MotorcycleTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x060112EA RID: 70378 RVA: 0x00430186 File Offset: 0x0042E386
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUISprite)));
	}

	// Token: 0x060112EB RID: 70379 RVA: 0x004301AC File Offset: 0x0042E3AC
	protected override void OnStart()
	{
		base.OnStart();
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorPreviewRedDotIcon");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.SetSpriteByPath(stringConfig, base.GetSprite(4), true, null, null);
		}
	}

	// Token: 0x060112EC RID: 70380 RVA: 0x004301EB File Offset: 0x0042E3EB
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		Action<UiTabViewBase> onRegisterViewCallback = this.OnRegisterViewCallback;
		if (onRegisterViewCallback == null)
		{
			return;
		}
		onRegisterViewCallback(tabView);
	}

	// Token: 0x060112ED RID: 70381 RVA: 0x00430220 File Offset: 0x0042E420
	public void BindPreviewRedDot(ERedDotName redDotName)
	{
		this.UnBindPreviewRedDot();
		UUISprite sprite = base.GetSprite(4);
		this.PreviewRedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, sprite, null, 0);
	}

	// Token: 0x060112EE RID: 70382 RVA: 0x00430255 File Offset: 0x0042E455
	public void UnBindPreviewRedDot()
	{
		if (this.PreviewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.PreviewRedDotName.Value, base.GetSprite(4), 0);
			this.PreviewRedDotName = null;
		}
	}

	// Token: 0x060112EF RID: 70383 RVA: 0x0043028D File Offset: 0x0042E48D
	public void SetSubRedDotVisible(bool isVisible)
	{
		base.GetSprite(4).SetUIActive(isVisible);
	}

	// Token: 0x040082C9 RID: 33481
	private ERedDotName? PreviewRedDotName;

	// Token: 0x040082CA RID: 33482
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UiTabViewBase> OnRegisterViewCallback;

	// Token: 0x0200878C RID: 34700
	protected class ECommonTabItem
	{
		// Token: 0x0402C0E4 RID: 180452
		public const int Icon = 0;

		// Token: 0x0402C0E5 RID: 180453
		public const int Toggle = 1;

		// Token: 0x0402C0E6 RID: 180454
		public const int RedDot = 2;

		// Token: 0x0402C0E7 RID: 180455
		public const int Transition = 3;

		// Token: 0x0402C0E8 RID: 180456
		public const int SubRedDot = 4;
	}
}
