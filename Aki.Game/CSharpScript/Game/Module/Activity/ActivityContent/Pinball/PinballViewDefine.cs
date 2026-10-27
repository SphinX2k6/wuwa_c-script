using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062CC RID: 25292
	public class PinballViewDefine : IStaticVariableResetter
	{
		// Token: 0x0603FA51 RID: 260689 RVA: 0x00F65AFC File Offset: 0x00F63CFC
		static PinballViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballViewDefine.CreateStaticDefaultValue), new Action(PinballViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603FA52 RID: 260690 RVA: 0x00F65B1C File Offset: 0x00F63D1C
		public static void CreateStaticDefaultValue()
		{
			Dictionary<string, ValueTuple<Func<PinballMainChildViewBase>, string>> dictionary = new Dictionary<string, ValueTuple<Func<PinballMainChildViewBase>, string>>();
			dictionary["PinballMainView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballMainView(), "UiView_PinballMain");
			dictionary["PinballLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballLevelView(), "UiView_PinballLevel");
			dictionary["PinballTowerLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballTowerLevelView(), "UiView_PinballTowerLevel");
			dictionary["PinballDailyLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballDailyLevelView(), "UiView_PinballDailyLevel");
			PinballViewDefine.pinballMainChildViewCreateInfo = dictionary;
		}

		// Token: 0x0603FA53 RID: 260691 RVA: 0x00F65C03 File Offset: 0x00F63E03
		public static void ResetStaticDefaultValue()
		{
			PinballViewDefine.pinballMainChildViewCreateInfo = null;
		}

		// Token: 0x04021429 RID: 136233
		[Nullable(new byte[]
		{
			2,
			1,
			0,
			1,
			1,
			1
		})]
		public static Dictionary<string, ValueTuple<Func<PinballMainChildViewBase>, string>> pinballMainChildViewCreateInfo;
	}
}
