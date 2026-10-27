using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200468F RID: 18063
	public class UiProhibitFightInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E9AA RID: 190890 RVA: 0x00ACA8CC File Offset: 0x00AC8ACC
		public unsafe override bool OnRefresh()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			if (instance == null)
			{
				return false;
			}
			if (!instance.HasAnyNotAllowFightInputViewIsOpen())
			{
				return false;
			}
			string text = UiProhibitFightInputCenter.Instance.CheckExtraRefreshData();
			if (!StringUtils.IsBlank(text))
			{
				string[] distributeTags = UiProhibitFightInputCenter.Instance.GetExtraRefreshData(text).GetDistributeTags();
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]禁止战斗输入的界面的输入分发,检测到额外注册的刷新数据条件判断成功";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotAllowFightInputViewNameSet", instance.GetNotAllowFightInputViewNameSet());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("额外注册名字", text);
				instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.SetInputDistributeTags(distributeTags);
				return true;
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Input;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "[InputDistribute]禁止战斗输入的界面的输入分发，有不允许战斗输入的界面打开";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NotAllowFightInputViewNameSet", instance.GetNotAllowFightInputViewNameSet());
			instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.SetInputDistributeTags(new string[]
			{
				"UiInputRoot.ShortcutKeyTag",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			});
			return true;
		}
	}
}
