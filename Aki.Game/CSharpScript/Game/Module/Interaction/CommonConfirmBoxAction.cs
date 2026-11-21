using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004824 RID: 18468
	public class CommonConfirmBoxAction : InteractConfirmBoxActionBase
	{
		// Token: 0x0602E681 RID: 190081 RVA: 0x00CF2F64 File Offset: 0x00CF1164
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
