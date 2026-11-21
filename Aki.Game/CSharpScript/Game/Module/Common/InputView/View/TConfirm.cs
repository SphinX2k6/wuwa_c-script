using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B59 RID: 19289
	// (Invoke) Token: 0x06030352 RID: 197458
	public delegate UniTask<ErrorCode> TConfirm([Nullable(1)] string inputText);
}
