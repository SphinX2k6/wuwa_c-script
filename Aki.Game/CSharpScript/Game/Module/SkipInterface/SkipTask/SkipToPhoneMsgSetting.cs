using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B7F RID: 15231
	public class SkipToPhoneMsgSetting : SkipTask
	{
		// Token: 0x060270CB RID: 159947 RVA: 0x00AEE9E4 File Offset: 0x00AECBE4
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

		// Token: 0x060270CC RID: 159948 RVA: 0x00AEEA34 File Offset: 0x00AECC34
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
