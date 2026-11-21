using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Game.Module.WaterMask
{
	// Token: 0x02003798 RID: 14232
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class WaterMaskView : UiControllerBase
	{
		// Token: 0x0602501D RID: 151581 RVA: 0x00A743BC File Offset: 0x00A725BC
		public static bool ShouldRegister()
		{
			return BaseConfigController.Instance.GetPackageConfigOrDefault("WaterMask", "false") == "true";
		}

		// Token: 0x0602501E RID: 151582 RVA: 0x00A743DC File Offset: 0x00A725DC
		public bool CanOpenView()
		{
			return false;
		}

		// Token: 0x0602501F RID: 151583 RVA: 0x00A743E0 File Offset: 0x00A725E0
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.CreateWaterMask));
			EventSystem.Instance.Add(EEventName.SetResolution, new Action(this.ResolutionChange));
			EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.RemoveWaterMask));
		}

		// Token: 0x06025020 RID: 151584 RVA: 0x00A74444 File Offset: 0x00A72644
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.CreateWaterMask));
			EventSystem.Instance.Remove(EEventName.SetResolution, new Action(this.ResolutionChange));
			EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.RemoveWaterMask));
		}

		// Token: 0x06025021 RID: 151585 RVA: 0x00A744A8 File Offset: 0x00A726A8
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

		// Token: 0x06025022 RID: 151586 RVA: 0x00A74701 File Offset: 0x00A72901
		private void RemoveWaterMask()
		{
			if (this.ContainerActor != null)
			{
				this.ContainerActor.K2_DestroyActor();
				this.ContainerActor = null;
			}
		}

		// Token: 0x06025023 RID: 151587 RVA: 0x00A7471D File Offset: 0x00A7291D
		private void ResolutionChange()
		{
			this.RemoveWaterMask();
			this.CreateWaterMask();
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x06025024 RID: 151588 RVA: 0x00A7472B File Offset: 0x00A7292B
		public static WaterMaskView Instance
		{
			get
			{
				return WaterMaskView._Instance;
			}
		}

		// Token: 0x06025025 RID: 151589 RVA: 0x00A74732 File Offset: 0x00A72932
		public static WaterMaskView GetOrCreateInstance()
		{
			if (WaterMaskView._Instance == null)
			{
				WaterMaskView.CreateInstance();
			}
			return WaterMaskView._Instance;
		}

		// Token: 0x06025026 RID: 151590 RVA: 0x00A74746 File Offset: 0x00A72946
		public static bool CreateInstance()
		{
			if (WaterMaskView._Instance != null)
			{
				return true;
			}
			WaterMaskView._Instance = new WaterMaskView();
			return true;
		}

		// Token: 0x06025027 RID: 151591 RVA: 0x00A7475C File Offset: 0x00A7295C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025028 RID: 151592 RVA: 0x00A7475E File Offset: 0x00A7295E
		public static void ResetStaticDefaultValue()
		{
			WaterMaskView._Instance = null;
		}

		// Token: 0x06025029 RID: 151593 RVA: 0x00A74766 File Offset: 0x00A72966
		static WaterMaskView()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WaterMaskView.CreateStaticDefaultValue), new Action(WaterMaskView.ResetStaticDefaultValue));
		}

		// Token: 0x0401479F RID: 83871
		[Nullable(2)]
		private AActor ContainerActor;

		// Token: 0x040147A0 RID: 83872
		private const int ColSpace = 300;

		// Token: 0x040147A1 RID: 83873
		private const int RowSpace = 300;

		// Token: 0x040147A2 RID: 83874
		private const float TextRotation = 30f;

		// Token: 0x040147A3 RID: 83875
		private const float TextAlpha = 0.09f;

		// Token: 0x040147A4 RID: 83876
		private const int FontSize = 40;

		// Token: 0x040147A5 RID: 83877
		[Nullable(2)]
		private static WaterMaskView _Instance;
	}
}
