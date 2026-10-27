using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Game.Module.WaterMask
{
	// Token: 0x02004867 RID: 18535
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class WaterMaskView : UiControllerBase
	{
		// Token: 0x0603084D RID: 198733 RVA: 0x00B441A8 File Offset: 0x00B423A8
		public static bool ShouldRegister()
		{
			return BaseConfigController.Instance.GetPackageConfigOrDefault("WaterMask", "false") == "true";
		}

		// Token: 0x0603084E RID: 198734 RVA: 0x00B441C8 File Offset: 0x00B423C8
		public bool CanOpenView()
		{
			return false;
		}

		// Token: 0x0603084F RID: 198735 RVA: 0x00B441CC File Offset: 0x00B423CC
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.CreateWaterMask));
			EventSystem.Instance.Add(EEventName.SetResolution, new Action(this.ResolutionChange));
			EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.RemoveWaterMask));
		}

		// Token: 0x06030850 RID: 198736 RVA: 0x00B44230 File Offset: 0x00B42430
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.CreateWaterMask));
			EventSystem.Instance.Remove(EEventName.SetResolution, new Action(this.ResolutionChange));
			EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.RemoveWaterMask));
		}

		// Token: 0x06030851 RID: 198737 RVA: 0x00B44294 File Offset: 0x00B42494
		private void CreateWaterMask()
		{
			if (this.ContainerActor != null)
			{
				this.RemoveWaterMask();
			}
			UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(ELayerType.WaterMask);
			this.ContainerActor = UKuroActorManager.D_SpawnActor(Info.Instance.World, AUIContainerActor.StaticClass(), FTransformDouble.Identity, ESpawnActorCollisionHandlingMethod.Undefined, null, null, false);
			UUIItem uuiitem = this.ContainerActor.RootComponent as UUIItem;
			uuiitem.SetDisplayName("WaterMaskContainer");
			UKuroStaticLibrary.SetActorPermanent(this.ContainerActor, true, true);
			this.ContainerActor.K2_AttachRootComponentTo(layerRootUiItem, default(FName), EAttachLocation.KeepRelativeOffset, true);
			UUIItem uuiitem2 = uuiitem.GetRootCanvas().GetOwner().RootComponent as UUIItem;
			float num = uuiitem2.widget.width % 300f / 2f;
			float num2 = uuiitem2.widget.height % 300f / 2f;
			float num3 = uuiitem2.widget.width / 2f;
			float num4 = uuiitem2.widget.height / 2f;
			int num5 = (int)Math.Ceiling((double)(uuiitem2.widget.width / 300f));
			int num6 = (int)Math.Ceiling((double)(uuiitem2.widget.height / 300f));
			string newText = FunctionModel.Instance.PlayerId.ToString();
			for (int i = 0; i < num5; i++)
			{
				for (int j = 0; j < num6; j++)
				{
					AActor aactor = UKuroActorManager.D_SpawnActor(Info.Instance.World, AUITextActor.StaticClass(), FTransformDouble.Identity, ESpawnActorCollisionHandlingMethod.Undefined, null, null, false);
					UUIItem uuiitem3 = aactor.RootComponent as UUIItem;
					aactor.K2_AttachRootComponentTo(uuiitem, default(FName), EAttachLocation.KeepRelativeOffset, true);
					uuiitem3.SetDisplayName("WaterMaskText");
					UUIText uuitext = aactor.GetComponentByClass(UUIText.StaticClass()) as UUIText;
					uuitext.SetFontSize(40f);
					uuitext.SetOverflowType(UITextOverflowType.HorizontalOverflow);
					uuitext.SetAlpha(0.09f);
					uuitext.SetFont(ULGUIFontData.GetDefaultFont());
					uuitext.SetText(newText, true);
					uuitext.SetUIRelativeLocation(new FVector((float)(i * 300) - num3 + num, (float)(j * 300) - num4 + num2, 0f));
					FRotator frotator = new FRotator(0f, 30f, 0f);
					uuitext.SetUIRelativeRotation(frotator);
					UKuroStaticLibrary.SetActorPermanent(aactor, true, true);
				}
			}
		}

		// Token: 0x06030852 RID: 198738 RVA: 0x00B444ED File Offset: 0x00B426ED
		private void RemoveWaterMask()
		{
			if (this.ContainerActor != null)
			{
				this.ContainerActor.K2_DestroyActor();
				this.ContainerActor = null;
			}
		}

		// Token: 0x06030853 RID: 198739 RVA: 0x00B44509 File Offset: 0x00B42709
		private void ResolutionChange()
		{
			this.RemoveWaterMask();
			this.CreateWaterMask();
		}

		// Token: 0x1700792A RID: 31018
		// (get) Token: 0x06030854 RID: 198740 RVA: 0x00B44517 File Offset: 0x00B42717
		public static WaterMaskView Instance
		{
			get
			{
				return WaterMaskView._Instance;
			}
		}

		// Token: 0x06030855 RID: 198741 RVA: 0x00B4451E File Offset: 0x00B4271E
		public static WaterMaskView GetOrCreateInstance()
		{
			if (WaterMaskView._Instance == null)
			{
				WaterMaskView.CreateInstance();
			}
			return WaterMaskView._Instance;
		}

		// Token: 0x06030856 RID: 198742 RVA: 0x00B44532 File Offset: 0x00B42732
		public static bool CreateInstance()
		{
			if (WaterMaskView._Instance != null)
			{
				return true;
			}
			WaterMaskView._Instance = new WaterMaskView();
			return true;
		}

		// Token: 0x06030857 RID: 198743 RVA: 0x00B44548 File Offset: 0x00B42748
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030858 RID: 198744 RVA: 0x00B4454A File Offset: 0x00B4274A
		public static void ResetStaticDefaultValue()
		{
			WaterMaskView._Instance = null;
		}

		// Token: 0x06030859 RID: 198745 RVA: 0x00B44552 File Offset: 0x00B42752
		static WaterMaskView()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WaterMaskView.CreateStaticDefaultValue), new Action(WaterMaskView.ResetStaticDefaultValue));
		}

		// Token: 0x0401A0EC RID: 106732
		[Nullable(2)]
		private AActor ContainerActor;

		// Token: 0x0401A0ED RID: 106733
		private const int ColSpace = 300;

		// Token: 0x0401A0EE RID: 106734
		private const int RowSpace = 300;

		// Token: 0x0401A0EF RID: 106735
		private const float TextRotation = 30f;

		// Token: 0x0401A0F0 RID: 106736
		private const float TextAlpha = 0.09f;

		// Token: 0x0401A0F1 RID: 106737
		private const int FontSize = 40;

		// Token: 0x0401A0F2 RID: 106738
		[Nullable(2)]
		private static WaterMaskView _Instance;
	}
}
