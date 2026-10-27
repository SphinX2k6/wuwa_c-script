using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020024F8 RID: 9464
public class VisionDefine : IStaticVariableResetter
{
	// Token: 0x0601308A RID: 77962 RVA: 0x004B6A15 File Offset: 0x004B4C15
	static VisionDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionDefine.CreateStaticDefaultValue), new Action(VisionDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601308B RID: 77963 RVA: 0x004B6A34 File Offset: 0x004B4C34
	public static void CreateStaticDefaultValue()
	{
		VisionDefine.tabViewWithLock = new HashSet<string>
		{
			EUiTabViewName.VisionIdentifyView.ToString(),
			EUiTabViewName.VisionRefineTabView.ToString()
		};
	}

	// Token: 0x0601308C RID: 77964 RVA: 0x004B6A6E File Offset: 0x004B4C6E
	public static void ResetStaticDefaultValue()
	{
		VisionDefine.tabViewWithLock = null;
	}

	// Token: 0x04008F3B RID: 36667
	public const int VISIONRAREGOLD = 3;

	// Token: 0x04008F3C RID: 36668
	public const int VISIONRAREPURPLE = 2;

	// Token: 0x04008F3D RID: 36669
	public const int VISIONRAREBLUE = 1;

	// Token: 0x04008F3E RID: 36670
	public const int CANNOTLEVELSUBQUALITY = 2;

	// Token: 0x04008F3F RID: 36671
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static HashSet<string> tabViewWithLock;
}
