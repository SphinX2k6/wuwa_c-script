using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB0 RID: 23984
	public class IFollowShooterAbilityType_UnionUnion
	{
		// Token: 0x1700B39A RID: 45978
		// (get) Token: 0x060290C8 RID: 168136 RVA: 0x005A2E79 File Offset: 0x005A1079
		// (set) Token: 0x060290C9 RID: 168137 RVA: 0x005A2E81 File Offset: 0x005A1081
		public IFollowShooterAbilityType_Union Type { get; set; }

		// Token: 0x1700B39B RID: 45979
		// (get) Token: 0x060290CA RID: 168138 RVA: 0x005A2E8A File Offset: 0x005A108A
		// (set) Token: 0x060290CB RID: 168139 RVA: 0x005A2E92 File Offset: 0x005A1092
		public object Value { get; set; }

		// Token: 0x060290CC RID: 168140 RVA: 0x005A2E9B File Offset: 0x005A109B
		public IFollowShooterAbilityType_UnionUnion()
		{
			this.Type = IFollowShooterAbilityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060290CD RID: 168141 RVA: 0x005A2EB1 File Offset: 0x005A10B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060290CE RID: 168142 RVA: 0x005A2EC3 File Offset: 0x005A10C3
		public IFollowShooterAbilityTypeT AsIFollowShooterAbilityType()
		{
			return this.As<IFollowShooterAbilityTypeT>();
		}

		// Token: 0x060290CF RID: 168143 RVA: 0x005A2ECB File Offset: 0x005A10CB
		public static IFollowShooterAbilityType_UnionUnion FromIFollowShooterAbilityType(IFollowShooterAbilityTypeT _ifollowshooterabilitytype)
		{
			return new IFollowShooterAbilityType_UnionUnion
			{
				Type = IFollowShooterAbilityType_Union.IFollowShooterAbilityType,
				Value = _ifollowshooterabilitytype
			};
		}

		// Token: 0x060290D0 RID: 168144 RVA: 0x005A2EE0 File Offset: 0x005A10E0
		public IFollowShooterJellyFishAbilityT AsIFollowShooterJellyFishAbility()
		{
			return this.As<IFollowShooterJellyFishAbilityT>();
		}

		// Token: 0x060290D1 RID: 168145 RVA: 0x005A2EE8 File Offset: 0x005A10E8
		public static IFollowShooterAbilityType_UnionUnion FromIFollowShooterJellyFishAbility(IFollowShooterJellyFishAbilityT _ifollowshooterjellyfishability)
		{
			return new IFollowShooterAbilityType_UnionUnion
			{
				Type = IFollowShooterAbilityType_Union.IFollowShooterJellyFishAbility,
				Value = _ifollowshooterjellyfishability
			};
		}

		// Token: 0x060290D2 RID: 168146 RVA: 0x005A2F00 File Offset: 0x005A1100
		public static int Pack(FlatBufferBuilder builder, IFollowShooterAbilityType_UnionUnion _o)
		{
			IFollowShooterAbilityType_Union type = _o.Type;
			if (type == IFollowShooterAbilityType_Union.IFollowShooterAbilityType)
			{
				return IFollowShooterAbilityType.Pack(builder, _o.AsIFollowShooterAbilityType()).Value;
			}
			if (type != IFollowShooterAbilityType_Union.IFollowShooterJellyFishAbility)
			{
				return 0;
			}
			return IFollowShooterJellyFishAbility.Pack(builder, _o.AsIFollowShooterJellyFishAbility()).Value;
		}
	}
}
