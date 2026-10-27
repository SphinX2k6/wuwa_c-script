using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Cursor
{
	// Token: 0x02005AEE RID: 23278
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CursorController : UiControllerBase
	{
		// Token: 0x0603AECB RID: 241355 RVA: 0x00E0C67A File Offset: 0x00E0A87A
		public void CursorEnterExit(bool isEnter)
		{
			this.EnterCurrentCursor(isEnter);
		}

		// Token: 0x0603AECC RID: 241356 RVA: 0x00E0C684 File Offset: 0x00E0A884
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

		// Token: 0x0603AECD RID: 241357 RVA: 0x00E0C6B8 File Offset: 0x00E0A8B8
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

		// Token: 0x0603AECE RID: 241358 RVA: 0x00E0C780 File Offset: 0x00E0A980
		public void SetWindowCursorStyle()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				string text;
				if (Info.Instance.IsPlayInEditor)
				{
					text = "Aki/UI/Module/Cursor/SourceResource";
				}
				else
				{
					text = "Aki/Cursor";
				}
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

		// Token: 0x17008C34 RID: 35892
		// (get) Token: 0x0603AECF RID: 241359 RVA: 0x00E0C861 File Offset: 0x00E0AA61
		public static CursorController Instance
		{
			get
			{
				return CursorController._Instance;
			}
		}

		// Token: 0x0603AED0 RID: 241360 RVA: 0x00E0C868 File Offset: 0x00E0AA68
		public static CursorController GetOrCreateInstance()
		{
			if (CursorController._Instance == null)
			{
				CursorController.CreateInstance();
			}
			return CursorController._Instance;
		}

		// Token: 0x0603AED1 RID: 241361 RVA: 0x00E0C87C File Offset: 0x00E0AA7C
		public static bool CreateInstance()
		{
			if (CursorController._Instance != null)
			{
				return true;
			}
			CursorController._Instance = new CursorController();
			return true;
		}

		// Token: 0x0603AED2 RID: 241362 RVA: 0x00E0C892 File Offset: 0x00E0AA92
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AED3 RID: 241363 RVA: 0x00E0C894 File Offset: 0x00E0AA94
		public static void ResetStaticDefaultValue()
		{
			CursorController._Instance = null;
		}

		// Token: 0x0603AED4 RID: 241364 RVA: 0x00E0C89C File Offset: 0x00E0AA9C
		static CursorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CursorController.CreateStaticDefaultValue), new Action(CursorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC24 RID: 125988
		[Nullable(2)]
		private static CursorController _Instance;
	}
}
