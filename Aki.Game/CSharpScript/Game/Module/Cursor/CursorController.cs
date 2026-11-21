using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Cursor
{
	// Token: 0x02004ACF RID: 19151
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CursorController : UiControllerBase
	{
		// Token: 0x0602FE3D RID: 196157 RVA: 0x00D5D352 File Offset: 0x00D5B552
		public void CursorEnterExit(bool isEnter)
		{
			this.EnterCurrentCursor(isEnter);
		}

		// Token: 0x0602FE3E RID: 196158 RVA: 0x00D5D35C File Offset: 0x00D5B55C
		private void EnterCurrentCursor(bool isEnter)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			if (isEnter)
			{
				characterController.CurrentMouseCursor = EMouseCursor.CursorEnter;
				return;
			}
			characterController.CurrentMouseCursor = EMouseCursor.Default;
		}

		// Token: 0x0602FE3F RID: 196159 RVA: 0x00D5D390 File Offset: 0x00D5B590
		public unsafe void InitMouseByMousePos()
		{
			FVector2D slateApplicationCursorPos = UKuroStaticLibrary.GetSlateApplicationCursorPos();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "InitMouseByMousePos";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewPortMousePosition.X", slateApplicationCursorPos.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("viewPortMousePosition.Y", slateApplicationCursorPos.Y);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (slateApplicationCursorPos.X > 0f || slateApplicationCursorPos.Y > 0f)
			{
				Log.Instance.Info(ELogModule.UiCommon, ELogAuthor.YZY, "Mouse在屏幕内", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKuroStaticLibrary.DoGameViewPortMouseEnter(UKuroStaticLibrary.GetGameViewPort(), (int)slateApplicationCursorPos.X, (int)slateApplicationCursorPos.Y);
			}
		}

		// Token: 0x0602FE40 RID: 196160 RVA: 0x00D5D458 File Offset: 0x00D5B658
		public void SetWindowCursorStyle()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				string text = "Aki/Cursor";
				FName? dynamicFName = FNameUtil.GetDynamicFName(text + "/CursorNor");
				FName? dynamicFName2 = FNameUtil.GetDynamicFName(text + "/CursorHi");
				FName? dynamicFName3 = FNameUtil.GetDynamicFName(text + "/CursorPre");
				FVector2D hotSpot = new FVector2D(0f, 0f);
				UWorld world = GlobalData.World.GetWorld();
				UWidgetBlueprintLibrary.SetHardwareCursor(world, EMouseCursor.Default, dynamicFName.Value, hotSpot);
				UWidgetBlueprintLibrary.SetHardwareCursor(world, EMouseCursor.CursorEnter, dynamicFName2.Value, hotSpot);
				UWidgetBlueprintLibrary.SetHardwareCursor(world, EMouseCursor.CursorPress, dynamicFName3.Value, hotSpot);
				string cursor = UBlueprintPathsLibrary.ProjectContentDir() + "/" + text + "/CursorNor.png";
				KuroSdkController.Instance.SetCursor(cursor);
			}
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x0602FE41 RID: 196161 RVA: 0x00D5D525 File Offset: 0x00D5B725
		public static CursorController Instance
		{
			get
			{
				return CursorController._Instance;
			}
		}

		// Token: 0x0602FE42 RID: 196162 RVA: 0x00D5D52C File Offset: 0x00D5B72C
		public static CursorController GetOrCreateInstance()
		{
			if (CursorController._Instance == null)
			{
				CursorController.CreateInstance();
			}
			return CursorController._Instance;
		}

		// Token: 0x0602FE43 RID: 196163 RVA: 0x00D5D540 File Offset: 0x00D5B740
		public static bool CreateInstance()
		{
			if (CursorController._Instance != null)
			{
				return true;
			}
			CursorController._Instance = new CursorController();
			return true;
		}

		// Token: 0x0602FE44 RID: 196164 RVA: 0x00D5D556 File Offset: 0x00D5B756
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FE45 RID: 196165 RVA: 0x00D5D558 File Offset: 0x00D5B758
		public static void ResetStaticDefaultValue()
		{
			CursorController._Instance = null;
		}

		// Token: 0x0602FE46 RID: 196166 RVA: 0x00D5D560 File Offset: 0x00D5B760
		static CursorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CursorController.CreateStaticDefaultValue), new Action(CursorController.ResetStaticDefaultValue));
		}

		// Token: 0x040196E0 RID: 104160
		[Nullable(2)]
		private static CursorController _Instance;
	}
}
