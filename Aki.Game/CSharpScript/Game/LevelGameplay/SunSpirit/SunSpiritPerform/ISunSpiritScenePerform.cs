using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02005B5E RID: 23390
	[NullableContext(1)]
	public interface ISunSpiritScenePerform
	{
		// Token: 0x06039851 RID: 235601
		[NullableContext(2)]
		bool GetTransformData(Vector outLocation = null, object outRotation = null, Vector outScale = null);

		// Token: 0x06039852 RID: 235602
		bool GetTransform(Transform outTransform);

		// Token: 0x06039853 RID: 235603
		[NullableContext(2)]
		bool SetTransformData(Vector inLocation = null, object inRotation = null, Vector inScale = null);

		// Token: 0x06039854 RID: 235604
		bool SetTransform(Transform inTransform);
	}
}
