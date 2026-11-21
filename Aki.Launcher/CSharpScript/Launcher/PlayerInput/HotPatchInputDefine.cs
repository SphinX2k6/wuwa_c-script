using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x0200011D RID: 285
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchInputDefine : Singleton
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00043E57 File Offset: 0x00042057
		public static HotPatchInputDefine Instance
		{
			get
			{
				if (HotPatchInputDefine._instance == null)
				{
					HotPatchInputDefine._instance = new HotPatchInputDefine();
					HotPatchInputDefine._instance.OnInit();
				}
				return HotPatchInputDefine._instance;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00043E7A File Offset: 0x0004207A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00043E7C File Offset: 0x0004207C
		public static void ResetStaticDefaultValue()
		{
			HotPatchInputDefine instance = HotPatchInputDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchInputDefine._instance = null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00043E95 File Offset: 0x00042095
		static HotPatchInputDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchInputDefine.CreateStaticDefaultValue), new Action(HotPatchInputDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00043EB4 File Offset: 0x000420B4
		public HotPatchInputDefine()
		{
			Dictionary<string, EMouseKey> dictionary = new Dictionary<string, EMouseKey>();
			dictionary["UI左键点击"] = EMouseKey.LeftMouseButton;
			this.pcInputMap = dictionary;
			Dictionary<string, EGamepadKey> dictionary2 = new Dictionary<string, EGamepadKey>();
			dictionary2["手柄右边上键"] = EGamepadKey.Gamepad_FaceButton_Top;
			dictionary2["手柄右边左键"] = EGamepadKey.Gamepad_FaceButton_Left;
			dictionary2["手柄右边右键"] = EGamepadKey.Gamepad_FaceButton_Right;
			dictionary2["手柄右边下键"] = EGamepadKey.Gamepad_FaceButton_Bottom;
			dictionary2["手柄左边上键"] = EGamepadKey.Gamepad_DPad_Up;
			dictionary2["手柄左边左键"] = EGamepadKey.Gamepad_DPad_Left;
			dictionary2["手柄左边右键"] = EGamepadKey.Gamepad_DPad_Right;
			dictionary2["手柄左边下键"] = EGamepadKey.Gamepad_DPad_Down;
			dictionary2["手柄左摇杆上"] = EGamepadKey.Gamepad_LeftStick_Up;
			dictionary2["手柄左摇杆下"] = EGamepadKey.Gamepad_LeftStick_Down;
			dictionary2["手柄LB"] = EGamepadKey.Gamepad_LeftShoulder;
			dictionary2["手柄LT"] = EGamepadKey.Gamepad_LeftTrigger;
			dictionary2["手柄RB"] = EGamepadKey.Gamepad_RightShoulder;
			dictionary2["手柄RT"] = EGamepadKey.Gamepad_RightTrigger;
			this.gamepadActionInputMap = dictionary2;
			Dictionary<string, ValueTuple<string, int>> dictionary3 = new Dictionary<string, ValueTuple<string, int>>();
			dictionary3["手柄右摇杆垂直方向"] = new ValueTuple<string, int>("Gamepad_RightY", 1);
			dictionary3["手柄左摇杆垂直方向"] = new ValueTuple<string, int>("Gamepad_LeftY", 1);
			this.gamepadAxisInputMap = dictionary3;
			Dictionary<EGamepadKey, IKeyPath> dictionary4 = new Dictionary<EGamepadKey, IKeyPath>();
			dictionary4[EGamepadKey.Gamepad_FaceButton_Top] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_FaceButton_Top_UI.T_IconPcBtn_XboxGamepad_FaceButton_Top_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsJian_UI.T_IconPcBtn_PsJian_UI"
			};
			dictionary4[EGamepadKey.Gamepad_FaceButton_Left] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_FaceButton_Left_UI.T_IconPcBtn_XboxGamepad_FaceButton_Left_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsKuang_UI.T_IconPcBtn_PsKuang_UI"
			};
			dictionary4[EGamepadKey.Gamepad_FaceButton_Right] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_KeyB_UI.T_IconPcBtn_KeyB_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsYuan_UI.T_IconPcBtn_PsYuan_UI"
			};
			dictionary4[EGamepadKey.Gamepad_FaceButton_Bottom] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_KeyA_UI.T_IconPcBtn_KeyA_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsCha_UI.T_IconPcBtn_PsCha_UI"
			};
			dictionary4[EGamepadKey.Gamepad_LeftShoulder] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_LeftShoulder_UI.T_IconPcBtn_XboxGamepad_LeftShoulder_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsL1_UI.T_IconPcBtn_PsL1_UI"
			};
			dictionary4[EGamepadKey.Gamepad_LeftTrigger] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_LeftTrigger_UI.T_IconPcBtn_XboxGamepad_LeftTrigger_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsL2_UI.T_IconPcBtn_PsL2_UI"
			};
			dictionary4[EGamepadKey.Gamepad_RightShoulder] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_RightShoulder_UI.T_IconPcBtn_XboxGamepad_RightShoulder_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsR1_UI.T_IconPcBtn_PsR1_UI"
			};
			dictionary4[EGamepadKey.Gamepad_RightTrigger] = new KeyPath
			{
				XBox = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_XboxGamepad_RightTrigger_UI.T_IconPcBtn_XboxGamepad_RightTrigger_UI",
				Ps = "/Game/Aki/UI/Module/HotFix/Image/T_IconPcBtn_PsR2_UI.T_IconPcBtn_PsR2_UI"
			};
			this.gamepadKeyPathMap = dictionary4;
			base..ctor();
		}

		// Token: 0x0400056A RID: 1386
		public const string ANY_KEY = "AnyKey";

		// Token: 0x0400056B RID: 1387
		public const int SCROLLBAR_INTERVAL = 800;

		// Token: 0x0400056C RID: 1388
		public readonly Dictionary<string, EMouseKey> pcInputMap;

		// Token: 0x0400056D RID: 1389
		public readonly Dictionary<string, EGamepadKey> gamepadActionInputMap;

		// Token: 0x0400056E RID: 1390
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		public readonly Dictionary<string, ValueTuple<string, int>> gamepadAxisInputMap;

		// Token: 0x0400056F RID: 1391
		public readonly Dictionary<EGamepadKey, IKeyPath> gamepadKeyPathMap;

		// Token: 0x04000570 RID: 1392
		[Nullable(2)]
		private static HotPatchInputDefine _instance;
	}
}
