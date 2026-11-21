using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002340 RID: 9024
[NullableContext(2)]
public interface IBatchBulletPositionShape
{
	// Token: 0x06016345 RID: 90949
	Transform ToTransform(int index);

	// Token: 0x06016346 RID: 90950
	Vector ToTargetLocation(Transform transform);

	// Token: 0x06016347 RID: 90951
	void OnBreak();

	// Token: 0x06016348 RID: 90952
	void OnEnd();

	// Token: 0x06016349 RID: 90953
	UniTask Load();

	// Token: 0x0601634A RID: 90954
	float GetDelay();

	// Token: 0x0601634B RID: 90955
	bool IsDestroyOnEnd();

	// Token: 0x0601634C RID: 90956
	bool IsSummonChildBullet();
}
