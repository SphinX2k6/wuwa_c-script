using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004696 RID: 18070
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InputTouchHandle : InputDistributeHandle<InputDistributeDefine.ITouchData>
	{
		// Token: 0x0602E9BA RID: 190906 RVA: 0x00ACAAD1 File Offset: 0x00AC8CD1
		public InputTouchHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x0602E9BB RID: 190907 RVA: 0x00ACAADB File Offset: 0x00AC8CDB
		public void BindTouch(TInputHandle<InputDistributeDefine.ITouchData> touchBeginCallback)
		{
			base.Bind(touchBeginCallback);
		}

		// Token: 0x0602E9BC RID: 190908 RVA: 0x00ACAAE4 File Offset: 0x00AC8CE4
		public void UnBindTouch(TInputHandle<InputDistributeDefine.ITouchData> touchBeginCallback)
		{
			base.UnBind(touchBeginCallback);
		}

		// Token: 0x0602E9BD RID: 190909 RVA: 0x00ACAAED File Offset: 0x00AC8CED
		public void InputTouch(InputDistributeDefine.ITouchData touchData)
		{
			base.Call(touchData);
		}
	}
}
