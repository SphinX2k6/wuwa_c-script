using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD4 RID: 19412
	public class SkipToMusicalInstrumentView : SkipTask
	{
		// Token: 0x06032338 RID: 205624 RVA: 0x00BAA6EC File Offset: 0x00BA88EC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			int type = Convert.ToInt32(data[0]);
			base.Finish();
			MusicalInstrumentController.Instance.Enter(new MusicalInstrumentEnterParam
			{
				Type = (EInstrumentType)type
			}).Forget();
		}
	}
}
