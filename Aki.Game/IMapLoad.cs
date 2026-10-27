using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02003505 RID: 13573
[NullableContext(1)]
public interface IMapLoad
{
	// Token: 0x0601DC53 RID: 121939
	UniTask Load(SceneInformation sceneInformation);
}
