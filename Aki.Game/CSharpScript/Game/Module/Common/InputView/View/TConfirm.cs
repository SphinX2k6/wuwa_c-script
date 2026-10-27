using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B79 RID: 23417
	// (Invoke) Token: 0x0603B405 RID: 242693
	public delegate UniTask<ErrorCode> TConfirm([Nullable(1)] string inputText);
}
