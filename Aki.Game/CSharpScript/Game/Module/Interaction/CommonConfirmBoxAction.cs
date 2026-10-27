using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584C RID: 22604
	public class CommonConfirmBoxAction : InteractConfirmBoxActionBase
	{
		// Token: 0x06039765 RID: 235365 RVA: 0x00DA42A4 File Offset: 0x00DA24A4
		[NullableContext(2)]
		protected override ConfirmBoxDataNew ConfigConfirmBoxData()
		{
			ICommonConfirmBox commonConfirmBox = this.Context.Option.ConfirmBox.Type as ICommonConfirmBox;
			if (commonConfirmBox == null)
			{
				return null;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)commonConfirmBox.Id);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				base.ExecuteFinish(false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.ExecuteFinish(true);
			};
			return confirmBoxDataNew;
		}
	}
}
