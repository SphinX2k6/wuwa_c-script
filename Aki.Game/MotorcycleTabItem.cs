using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001749 RID: 5961
public class MotorcycleTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600E780 RID: 59264 RVA: 0x0043CD92 File Offset: 0x0043AF92
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUISprite)));
	}

	// Token: 0x0600E781 RID: 59265 RVA: 0x0043CDB8 File Offset: 0x0043AFB8
	protected override void OnStart()
	{
		base.OnStart();
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorPreviewRedDotIcon");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.SetSpriteByPath(stringConfig, base.GetSprite(4), true, null, null);
		}
	}

	// Token: 0x0600E782 RID: 59266 RVA: 0x0043CDF7 File Offset: 0x0043AFF7
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

	// Token: 0x0600E783 RID: 59267 RVA: 0x0043CE2C File Offset: 0x0043B02C
	public void BindPreviewRedDot(ERedDotName redDotName)
	{
		this.UnBindPreviewRedDot();
		UUISprite sprite = base.GetSprite(4);
		this.PreviewRedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, sprite, null, 0);
	}

	// Token: 0x0600E784 RID: 59268 RVA: 0x0043CE61 File Offset: 0x0043B061
	public void UnBindPreviewRedDot()
	{
		if (this.PreviewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.PreviewRedDotName.Value, base.GetSprite(4), 0);
			this.PreviewRedDotName = null;
		}
	}

	// Token: 0x0600E785 RID: 59269 RVA: 0x0043CE99 File Offset: 0x0043B099
	public void SetSubRedDotVisible(bool isVisible)
	{
		base.GetSprite(4).SetUIActive(isVisible);
	}

	// Token: 0x04008407 RID: 33799
	private ERedDotName? PreviewRedDotName;

	// Token: 0x04008408 RID: 33800
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UiTabViewBase> OnRegisterViewCallback;

	// Token: 0x02007915 RID: 30997
	protected class ECommonTabItem
	{
		// Token: 0x040273FC RID: 160764
		public const int Icon = 0;

		// Token: 0x040273FD RID: 160765
		public const int Toggle = 1;

		// Token: 0x040273FE RID: 160766
		public const int RedDot = 2;

		// Token: 0x040273FF RID: 160767
		public const int Transition = 3;

		// Token: 0x04027400 RID: 160768
		public const int SubRedDot = 4;
	}
}
