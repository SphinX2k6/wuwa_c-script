using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD5 RID: 19413
	public class SkipToPhoneMsgSetting : SkipTask
	{
		// Token: 0x0603233A RID: 205626 RVA: 0x00BAA72C File Offset: 0x00BA892C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			base.Finish();
			int itemId = Convert.ToInt32(data[0]);
			if (!FunctionModel.Instance.IsOpen(EFunctionType.PhoneMsg))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MessageSystemUnlockTip", Array.Empty<object>());
				return;
			}
			this.OpenPhoneMsgSettingAsync(itemId).Forget();
		}

		// Token: 0x0603233B RID: 205627 RVA: 0x00BAA77C File Offset: 0x00BA897C
		private UniTask OpenPhoneMsgSettingAsync(int itemId)
		{
			SkipToPhoneMsgSetting.<OpenPhoneMsgSettingAsync>d__1 <OpenPhoneMsgSettingAsync>d__;
			<OpenPhoneMsgSettingAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenPhoneMsgSettingAsync>d__.itemId = itemId;
			<OpenPhoneMsgSettingAsync>d__.<>1__state = -1;
			<OpenPhoneMsgSettingAsync>d__.<>t__builder.Start<SkipToPhoneMsgSetting.<OpenPhoneMsgSettingAsync>d__1>(ref <OpenPhoneMsgSettingAsync>d__);
			return <OpenPhoneMsgSettingAsync>d__.<>t__builder.Task;
		}
	}
}
