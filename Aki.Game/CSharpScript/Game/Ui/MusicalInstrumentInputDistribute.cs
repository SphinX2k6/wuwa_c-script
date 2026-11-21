using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.MusicalInstrument;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035BA RID: 13754
	public class MusicalInstrumentInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230E6 RID: 143590 RVA: 0x009F8148 File Offset: 0x009F6348
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

		// Token: 0x04013BE9 RID: 80873
		[Nullable(1)]
		private readonly List<string> TagNames = new List<string>();
	}
}
