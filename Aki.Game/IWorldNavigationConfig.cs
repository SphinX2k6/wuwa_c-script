using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E8E RID: 3726
[NullableContext(1)]
public interface IWorldNavigationConfig
{
	// Token: 0x17001042 RID: 4162
	// (get) Token: 0x060094F6 RID: 38134
	// (set) Token: 0x060094F7 RID: 38135
	Vector SourcePosition { get; set; }

	// Token: 0x17001043 RID: 4163
	// (get) Token: 0x060094F8 RID: 38136
	// (set) Token: 0x060094F9 RID: 38137
	Vector DestPosition { get; set; }

	// Token: 0x17001044 RID: 4164
	// (get) Token: 0x060094FA RID: 38138
	// (set) Token: 0x060094FB RID: 38139
	int MapId { get; set; }

	// Token: 0x17001045 RID: 4165
	// (get) Token: 0x060094FC RID: 38140
	// (set) Token: 0x060094FD RID: 38141
	[Nullable(2)]
	BaseMoveComponent MoveComponent { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001046 RID: 4166
	// (get) Token: 0x060094FE RID: 38142
	// (set) Token: 0x060094FF RID: 38143
	int? DistanceThreshold { get; set; }

	// Token: 0x17001047 RID: 4167
	// (get) Token: 0x06009500 RID: 38144
	// (set) Token: 0x06009501 RID: 38145
	int? TryFindPathTimes { get; set; }

	// Token: 0x17001048 RID: 4168
	// (get) Token: 0x06009502 RID: 38146
	// (set) Token: 0x06009503 RID: 38147
	[Nullable(2)]
	TWorldNavigationCallback Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
