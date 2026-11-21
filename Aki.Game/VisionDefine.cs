using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019DF RID: 6623
public class VisionDefine : IStaticVariableResetter
{
	// Token: 0x06010549 RID: 66889 RVA: 0x004C46A5 File Offset: 0x004C28A5
	static VisionDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionDefine.CreateStaticDefaultValue), new Action(VisionDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601054A RID: 66890 RVA: 0x004C46C4 File Offset: 0x004C28C4
	public static void CreateStaticDefaultValue()
	{
		VisionDefine.tabViewWithLock = new HashSet<string>
		{
			EUiTabViewName.VisionIdentifyView.ToString(),
			EUiTabViewName.VisionRefineTabView.ToString()
		};
	}

	// Token: 0x0601054B RID: 66891 RVA: 0x004C46FE File Offset: 0x004C28FE
	public static void ResetStaticDefaultValue()
	{
		VisionDefine.tabViewWithLock = null;
	}

	// Token: 0x04009085 RID: 36997
	public const int VISIONRAREGOLD = 3;

	// Token: 0x04009086 RID: 36998
	public const int VISIONRAREPURPLE = 2;

	// Token: 0x04009087 RID: 36999
	public const int VISIONRAREBLUE = 1;

	// Token: 0x04009088 RID: 37000
	public const int CANNOTLEVELSUBQUALITY = 2;

	// Token: 0x04009089 RID: 37001
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static HashSet<string> tabViewWithLock;
}
