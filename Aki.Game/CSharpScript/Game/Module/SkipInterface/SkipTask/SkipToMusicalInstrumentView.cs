using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.MusicalInstrument;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B7E RID: 15230
	public class SkipToMusicalInstrumentView : SkipTask
	{
		// Token: 0x060270C9 RID: 159945 RVA: 0x00AEE9A4 File Offset: 0x00AECBA4
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
