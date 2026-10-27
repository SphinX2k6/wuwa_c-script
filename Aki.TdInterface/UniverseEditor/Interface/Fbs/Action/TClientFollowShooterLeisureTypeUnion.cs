using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007678 RID: 30328
	public class TClientFollowShooterLeisureTypeUnion
	{
		// Token: 0x1700E5E3 RID: 58851
		// (get) Token: 0x0603730E RID: 226062 RVA: 0x0077B2AA File Offset: 0x007794AA
		// (set) Token: 0x0603730F RID: 226063 RVA: 0x0077B2B2 File Offset: 0x007794B2
		public TClientFollowShooterLeisureType Type { get; set; }

		// Token: 0x1700E5E4 RID: 58852
		// (get) Token: 0x06037310 RID: 226064 RVA: 0x0077B2BB File Offset: 0x007794BB
		// (set) Token: 0x06037311 RID: 226065 RVA: 0x0077B2C3 File Offset: 0x007794C3
		public object Value { get; set; }

		// Token: 0x06037312 RID: 226066 RVA: 0x0077B2CC File Offset: 0x007794CC
		public TClientFollowShooterLeisureTypeUnion()
		{
			this.Type = TClientFollowShooterLeisureType.NONE;
			this.Value = null;
		}

		// Token: 0x06037313 RID: 226067 RVA: 0x0077B2E2 File Offset: 0x007794E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037314 RID: 226068 RVA: 0x0077B2F4 File Offset: 0x007794F4
		public IClientFollowShooterPlayAnimationT AsIClientFollowShooterPlayAnimation()
		{
			return this.As<IClientFollowShooterPlayAnimationT>();
		}

		// Token: 0x06037315 RID: 226069 RVA: 0x0077B2FC File Offset: 0x007794FC
		public static TClientFollowShooterLeisureTypeUnion FromIClientFollowShooterPlayAnimation(IClientFollowShooterPlayAnimationT _iclientfollowshooterplayanimation)
		{
			return new TClientFollowShooterLeisureTypeUnion
			{
				Type = TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation,
				Value = _iclientfollowshooterplayanimation
			};
		}

		// Token: 0x06037316 RID: 226070 RVA: 0x0077B311 File Offset: 0x00779511
		public IClientFollowShooterResetToPlayerT AsIClientFollowShooterResetToPlayer()
		{
			return this.As<IClientFollowShooterResetToPlayerT>();
		}

		// Token: 0x06037317 RID: 226071 RVA: 0x0077B319 File Offset: 0x00779519
		public static TClientFollowShooterLeisureTypeUnion FromIClientFollowShooterResetToPlayer(IClientFollowShooterResetToPlayerT _iclientfollowshooterresettoplayer)
		{
			return new TClientFollowShooterLeisureTypeUnion
			{
				Type = TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer,
				Value = _iclientfollowshooterresettoplayer
			};
		}

		// Token: 0x06037318 RID: 226072 RVA: 0x0077B330 File Offset: 0x00779530
		public static int Pack(FlatBufferBuilder builder, TClientFollowShooterLeisureTypeUnion _o)
		{
			TClientFollowShooterLeisureType type = _o.Type;
			if (type == TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation)
			{
				return IClientFollowShooterPlayAnimation.Pack(builder, _o.AsIClientFollowShooterPlayAnimation()).Value;
			}
			if (type != TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer)
			{
				return 0;
			}
			return IClientFollowShooterResetToPlayer.Pack(builder, _o.AsIClientFollowShooterResetToPlayer()).Value;
		}
	}
}
