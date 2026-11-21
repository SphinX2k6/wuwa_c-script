using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02002A7A RID: 10874
[NullableContext(1)]
public interface IMapLoad
{
	// Token: 0x0601B96D RID: 113005
	UniTask Load(SceneInformation sceneInformation);
}
