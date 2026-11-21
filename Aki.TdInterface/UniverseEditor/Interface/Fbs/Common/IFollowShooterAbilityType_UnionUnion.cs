using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063ED RID: 25581
	public class IFollowShooterAbilityType_UnionUnion
	{
		// Token: 0x1700BD00 RID: 48384
		// (get) Token: 0x0602B752 RID: 178002 RVA: 0x005EBBA9 File Offset: 0x005E9DA9
		// (set) Token: 0x0602B753 RID: 178003 RVA: 0x005EBBB1 File Offset: 0x005E9DB1
		public IFollowShooterAbilityType_Union Type { get; set; }

		// Token: 0x1700BD01 RID: 48385
		// (get) Token: 0x0602B754 RID: 178004 RVA: 0x005EBBBA File Offset: 0x005E9DBA
		// (set) Token: 0x0602B755 RID: 178005 RVA: 0x005EBBC2 File Offset: 0x005E9DC2
		public object Value { get; set; }

		// Token: 0x0602B756 RID: 178006 RVA: 0x005EBBCB File Offset: 0x005E9DCB
		public IFollowShooterAbilityType_UnionUnion()
		{
			this.Type = IFollowShooterAbilityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B757 RID: 178007 RVA: 0x005EBBE1 File Offset: 0x005E9DE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B758 RID: 178008 RVA: 0x005EBBF3 File Offset: 0x005E9DF3
		public IFollowShooterAbilityTypeT AsIFollowShooterAbilityType()
		{
			return this.As<IFollowShooterAbilityTypeT>();
		}

		// Token: 0x0602B759 RID: 178009 RVA: 0x005EBBFB File Offset: 0x005E9DFB
		public static IFollowShooterAbilityType_UnionUnion FromIFollowShooterAbilityType(IFollowShooterAbilityTypeT _ifollowshooterabilitytype)
		{
			return new IFollowShooterAbilityType_UnionUnion
			{
				Type = IFollowShooterAbilityType_Union.IFollowShooterAbilityType,
				Value = _ifollowshooterabilitytype
			};
		}

		// Token: 0x0602B75A RID: 178010 RVA: 0x005EBC10 File Offset: 0x005E9E10
		public IFollowShooterJellyFishAbilityT AsIFollowShooterJellyFishAbility()
		{
			return this.As<IFollowShooterJellyFishAbilityT>();
		}

		// Token: 0x0602B75B RID: 178011 RVA: 0x005EBC18 File Offset: 0x005E9E18
		public static IFollowShooterAbilityType_UnionUnion FromIFollowShooterJellyFishAbility(IFollowShooterJellyFishAbilityT _ifollowshooterjellyfishability)
		{
			return new IFollowShooterAbilityType_UnionUnion
			{
				Type = IFollowShooterAbilityType_Union.IFollowShooterJellyFishAbility,
				Value = _ifollowshooterjellyfishability
			};
		}

		// Token: 0x0602B75C RID: 178012 RVA: 0x005EBC30 File Offset: 0x005E9E30
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
