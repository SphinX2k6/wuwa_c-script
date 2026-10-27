using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x0200013F RID: 319
	// (Invoke) Token: 0x06000B33 RID: 2867
	[return: Nullable(new byte[]
	{
		0,
		0,
		1,
		1
	})]
	public delegate OneOf<UniTask<object>, object> TFunction(params object[] args);
}
