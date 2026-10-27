using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E7D RID: 11901
[NullableContext(2)]
public interface IActiveBuff
{
	// Token: 0x170022F5 RID: 8949
	// (get) Token: 0x0601970A RID: 104202
	long? InstigatorId { get; }

	// Token: 0x0601970B RID: 104203
	Entity GetInstigator();

	// Token: 0x0601970C RID: 104204
	CharacterBuffComponent GetInstigatorBuffComponent();

	// Token: 0x0601970D RID: 104205
	CharacterActorComponent GetInstigatorActorComponent();

	// Token: 0x0601970E RID: 104206
	Entity GetOwner();

	// Token: 0x0601970F RID: 104207
	IBuffComponent GetOwnerBuffComponent();

	// Token: 0x06019710 RID: 104208
	[NullableContext(1)]
	string GetOwnerDebugName();

	// Token: 0x06019711 RID: 104209
	bool IsActive();

	// Token: 0x170022F6 RID: 8950
	// (get) Token: 0x06019712 RID: 104210
	[Nullable(1)]
	BuffDefinition Config { [NullableContext(1)] get; }

	// Token: 0x170022F7 RID: 8951
	// (get) Token: 0x06019713 RID: 104211
	float Duration { get; }

	// Token: 0x06019714 RID: 104212
	float GetRemainDuration();

	// Token: 0x06019715 RID: 104213
	bool IsValid();

	// Token: 0x170022F8 RID: 8952
	// (get) Token: 0x06019716 RID: 104214
	int StackCount { get; }

	// Token: 0x170022F9 RID: 8953
	// (get) Token: 0x06019717 RID: 104215
	long Id { get; }

	// Token: 0x170022FA RID: 8954
	// (get) Token: 0x06019718 RID: 104216
	int Handle { get; }

	// Token: 0x170022FB RID: 8955
	// (get) Token: 0x06019719 RID: 104217
	int ServerId { get; }

	// Token: 0x170022FC RID: 8956
	// (get) Token: 0x0601971A RID: 104218
	int Level { get; }

	// Token: 0x170022FD RID: 8957
	// (get) Token: 0x0601971B RID: 104219
	long? MessageId { get; }

	// Token: 0x170022FE RID: 8958
	// (get) Token: 0x0601971C RID: 104220
	long? PreMessageId { get; }

	// Token: 0x0601971D RID: 104221
	bool IsInstantBuff();

	// Token: 0x0601971E RID: 104222
	void SetBuffTimeScale(int buffHandle, float timeScale);

	// Token: 0x0601971F RID: 104223
	void RemoveBuffTimeScale(int buffHandle);

	// Token: 0x170022FF RID: 8959
	// (get) Token: 0x06019720 RID: 104224
	float CreateTimestamp { get; }
}
