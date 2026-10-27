using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046AF RID: 18095
	[NullableContext(1)]
	[Nullable(0)]
	public class InputExtraShowCursorCenter : Singleton
	{
		// Token: 0x0602EA7B RID: 191099 RVA: 0x00ACC230 File Offset: 0x00ACA430
		public void RegisterExtraRefreshData(string tag, IExtraShowCursor data)
		{
			this.ExtraShowCursorDataMap[tag] = data;
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注册额外的显示鼠标数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EA7C RID: 191100 RVA: 0x00ACC284 File Offset: 0x00ACA484
		public void UnRegisterExtraRefreshData(string tag)
		{
			this.ExtraShowCursorDataMap.Remove(tag);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注销额外的显示鼠标数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EA7D RID: 191101 RVA: 0x00ACC2C8 File Offset: 0x00ACA4C8
		public bool CheckShowCursorData()
		{
			using (Dictionary<string, IExtraShowCursor>.ValueCollection.Enumerator enumerator = this.ExtraShowCursorDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsShowCursor())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602EA7E RID: 191102 RVA: 0x00ACC328 File Offset: 0x00ACA528
		public bool HasExtraShowCursorData()
		{
			return this.ExtraShowCursorDataMap.Count > 0;
		}

		// Token: 0x1700765D RID: 30301
		// (get) Token: 0x0602EA7F RID: 191103 RVA: 0x00ACC338 File Offset: 0x00ACA538
		public static InputExtraShowCursorCenter Instance
		{
			get
			{
				if (InputExtraShowCursorCenter._instance == null)
				{
					InputExtraShowCursorCenter._instance = new InputExtraShowCursorCenter();
					InputExtraShowCursorCenter._instance.OnInit();
				}
				return InputExtraShowCursorCenter._instance;
			}
		}

		// Token: 0x0602EA80 RID: 191104 RVA: 0x00ACC35B File Offset: 0x00ACA55B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EA81 RID: 191105 RVA: 0x00ACC35D File Offset: 0x00ACA55D
		public static void ResetStaticDefaultValue()
		{
			InputExtraShowCursorCenter instance = InputExtraShowCursorCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputExtraShowCursorCenter._instance = null;
		}

		// Token: 0x0602EA82 RID: 191106 RVA: 0x00ACC376 File Offset: 0x00ACA576
		static InputExtraShowCursorCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputExtraShowCursorCenter.CreateStaticDefaultValue), new Action(InputExtraShowCursorCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04019696 RID: 104086
		private readonly Dictionary<string, IExtraShowCursor> ExtraShowCursorDataMap = new Dictionary<string, IExtraShowCursor>();

		// Token: 0x04019697 RID: 104087
		[Nullable(2)]
		private static InputExtraShowCursorCenter _instance;
	}
}
