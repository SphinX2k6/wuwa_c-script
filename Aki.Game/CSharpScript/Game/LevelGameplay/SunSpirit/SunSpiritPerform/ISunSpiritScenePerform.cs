using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02006A01 RID: 27137
	[NullableContext(1)]
	public interface ISunSpiritScenePerform
	{
		// Token: 0x06043805 RID: 276485
		[NullableContext(2)]
		bool GetTransformData(Vector outLocation = null, object outRotation = null, Vector outScale = null);

		// Token: 0x06043806 RID: 276486
		bool GetTransform(Transform outTransform);

		// Token: 0x06043807 RID: 276487
		[NullableContext(2)]
		bool SetTransformData(Vector inLocation = null, object inRotation = null, Vector inScale = null);

		// Token: 0x06043808 RID: 276488
		bool SetTransform(Transform inTransform);
	}
}
