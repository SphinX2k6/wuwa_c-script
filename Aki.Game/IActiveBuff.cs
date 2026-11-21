using System;
using System.Runtime.CompilerServices;

// Token: 0x020023CF RID: 9167
[NullableContext(2)]
public interface IActiveBuff
{
	// Token: 0x17002380 RID: 9088
	// (get) Token: 0x06016FE0 RID: 94176
	long? InstigatorId { get; }

	// Token: 0x06016FE1 RID: 94177
	Entity GetInstigator();

	// Token: 0x06016FE2 RID: 94178
	CharacterBuffComponent GetInstigatorBuffComponent();

	// Token: 0x06016FE3 RID: 94179
	CharacterActorComponent GetInstigatorActorComponent();

	// Token: 0x06016FE4 RID: 94180
	Entity GetOwner();

	// Token: 0x06016FE5 RID: 94181
	IBuffComponent GetOwnerBuffComponent();

	// Token: 0x06016FE6 RID: 94182
	[NullableContext(1)]
	string GetOwnerDebugName();

	// Token: 0x06016FE7 RID: 94183
	bool IsActive();

	// Token: 0x17002381 RID: 9089
	// (get) Token: 0x06016FE8 RID: 94184
	[Nullable(1)]
	BuffDefinition Config { [NullableContext(1)] get; }

	// Token: 0x17002382 RID: 9090
	// (get) Token: 0x06016FE9 RID: 94185
	float Duration { get; }

	// Token: 0x06016FEA RID: 94186
	float GetRemainDuration();

	// Token: 0x06016FEB RID: 94187
	bool IsValid();

	// Token: 0x17002383 RID: 9091
	// (get) Token: 0x06016FEC RID: 94188
	int StackCount { get; }

	// Token: 0x17002384 RID: 9092
	// (get) Token: 0x06016FED RID: 94189
	long Id { get; }

	// Token: 0x17002385 RID: 9093
	// (get) Token: 0x06016FEE RID: 94190
	int Handle { get; }

	// Token: 0x17002386 RID: 9094
	// (get) Token: 0x06016FEF RID: 94191
	int ServerId { get; }

	// Token: 0x17002387 RID: 9095
	// (get) Token: 0x06016FF0 RID: 94192
	int Level { get; }

	// Token: 0x17002388 RID: 9096
	// (get) Token: 0x06016FF1 RID: 94193
	long? MessageId { get; }

	// Token: 0x17002389 RID: 9097
	// (get) Token: 0x06016FF2 RID: 94194
	long? PreMessageId { get; }

	// Token: 0x06016FF3 RID: 94195
	bool IsInstantBuff();

	// Token: 0x06016FF4 RID: 94196
	void SetBuffTimeScale(int buffHandle, float timeScale);

	// Token: 0x06016FF5 RID: 94197
	void RemoveBuffTimeScale(int buffHandle);

	// Token: 0x1700238A RID: 9098
	// (get) Token: 0x06016FF6 RID: 94198
	float CreateTimestamp { get; }
}
