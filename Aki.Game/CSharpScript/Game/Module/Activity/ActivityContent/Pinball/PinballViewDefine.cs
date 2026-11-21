using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x0200524A RID: 21066
	public class PinballViewDefine : IStaticVariableResetter
	{
		// Token: 0x06034712 RID: 214802 RVA: 0x00EACA58 File Offset: 0x00EAAC58
		static PinballViewDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballViewDefine.CreateStaticDefaultValue), new Action(PinballViewDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06034713 RID: 214803 RVA: 0x00EACA78 File Offset: 0x00EAAC78
		public static void CreateStaticDefaultValue()
		{
			Dictionary<string, ValueTuple<Func<PinballMainChildViewBase>, string>> dictionary = new Dictionary<string, ValueTuple<Func<PinballMainChildViewBase>, string>>();
			dictionary["PinballMainView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballMainView(), "UiView_PinballMain");
			dictionary["PinballLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballLevelView(), "UiView_PinballLevel");
			dictionary["PinballTowerLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballTowerLevelView(), "UiView_PinballTowerLevel");
			dictionary["PinballDailyLevelView"] = new ValueTuple<Func<PinballMainChildViewBase>, string>(() => new PinballDailyLevelView(), "UiView_PinballDailyLevel");
			PinballViewDefine.pinballMainChildViewCreateInfo = dictionary;
		}

		// Token: 0x06034714 RID: 214804 RVA: 0x00EACB5F File Offset: 0x00EAAD5F
		public static void ResetStaticDefaultValue()
		{
			PinballViewDefine.pinballMainChildViewCreateInfo = null;
		}

		// Token: 0x0401BD58 RID: 114008
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
