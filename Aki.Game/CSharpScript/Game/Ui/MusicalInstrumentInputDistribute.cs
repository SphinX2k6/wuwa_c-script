using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004689 RID: 18057
	public class MusicalInstrumentInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E99C RID: 190876 RVA: 0x00ACA414 File Offset: 0x00AC8614
		public override bool OnRefresh()
		{
			MusicalInstrumentModel instance = MusicalInstrumentModel.Instance;
			if (instance == null || !instance.IsAnyInputRestricted)
			{
				return false;
			}
			this.TagNames.Clear();
			this.TagNames.Add("UiInputRoot");
			if (!UiManager.Instance.IsViewOpen(EUiViewName.HelpView))
			{
				if (!Info.Instance.IsInGamepad())
				{
					this.TagNames.Add("FightInputRoot.FightInput.AxisInput.CameraInput");
				}
				else
				{
					this.TagNames.Add("FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation");
				}
			}
			base.SetInputDistributeTags(this.TagNames);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.CB;
			string message = "[InputDistribute] 乐器玩法下允许的输入";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagNames", this.TagNames);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x04019542 RID: 103746
		[Nullable(1)]
		private readonly List<string> TagNames = new List<string>();
	}
}
