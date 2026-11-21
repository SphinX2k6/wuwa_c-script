using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C7 RID: 13767
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InputTouchHandle : InputDistributeHandle<InputDistributeDefine.ITouchData>
	{
		// Token: 0x06023106 RID: 143622 RVA: 0x009F93A7 File Offset: 0x009F75A7
		public InputTouchHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x06023107 RID: 143623 RVA: 0x009F93B1 File Offset: 0x009F75B1
		public void BindTouch(TInputHandle<InputDistributeDefine.ITouchData> touchBeginCallback)
		{
			base.Bind(touchBeginCallback);
		}

		// Token: 0x06023108 RID: 143624 RVA: 0x009F93BA File Offset: 0x009F75BA
		public void UnBindTouch(TInputHandle<InputDistributeDefine.ITouchData> touchBeginCallback)
		{
			base.UnBind(touchBeginCallback);
		}

		// Token: 0x06023109 RID: 143625 RVA: 0x009F93C3 File Offset: 0x009F75C3
		public void InputTouch(InputDistributeDefine.ITouchData touchData)
		{
			base.Call(touchData);
		}
	}
}
