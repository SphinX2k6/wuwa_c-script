using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002DE5 RID: 11749
[NullableContext(2)]
public interface IBatchBulletPositionShape
{
	// Token: 0x06018A98 RID: 101016
	Transform ToTransform(int index);

	// Token: 0x06018A99 RID: 101017
	Vector ToTargetLocation(Transform transform);

	// Token: 0x06018A9A RID: 101018
	void OnBreak();

	// Token: 0x06018A9B RID: 101019
	void OnEnd();

	// Token: 0x06018A9C RID: 101020
	UniTask Load();

	// Token: 0x06018A9D RID: 101021
	float GetDelay();

	// Token: 0x06018A9E RID: 101022
	bool IsDestroyOnEnd();

	// Token: 0x06018A9F RID: 101023
	bool IsSummonChildBullet();
}
