using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E86 RID: 32390
	public class TClientFollowShooterLeisureTypeUnion
	{
		// Token: 0x1700F221 RID: 61985
		// (get) Token: 0x0603A7B3 RID: 239539 RVA: 0x007DF3A6 File Offset: 0x007DD5A6
		// (set) Token: 0x0603A7B4 RID: 239540 RVA: 0x007DF3AE File Offset: 0x007DD5AE
		public TClientFollowShooterLeisureType Type { get; set; }

		// Token: 0x1700F222 RID: 61986
		// (get) Token: 0x0603A7B5 RID: 239541 RVA: 0x007DF3B7 File Offset: 0x007DD5B7
		// (set) Token: 0x0603A7B6 RID: 239542 RVA: 0x007DF3BF File Offset: 0x007DD5BF
		public object Value { get; set; }

		// Token: 0x0603A7B7 RID: 239543 RVA: 0x007DF3C8 File Offset: 0x007DD5C8
		public TClientFollowShooterLeisureTypeUnion()
		{
			this.Type = TClientFollowShooterLeisureType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7B8 RID: 239544 RVA: 0x007DF3DE File Offset: 0x007DD5DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7B9 RID: 239545 RVA: 0x007DF3F0 File Offset: 0x007DD5F0
		public IClientFollowShooterPlayAnimationT AsIClientFollowShooterPlayAnimation()
		{
			return this.As<IClientFollowShooterPlayAnimationT>();
		}

		// Token: 0x0603A7BA RID: 239546 RVA: 0x007DF3F8 File Offset: 0x007DD5F8
		public static TClientFollowShooterLeisureTypeUnion FromIClientFollowShooterPlayAnimation(IClientFollowShooterPlayAnimationT _iclientfollowshooterplayanimation)
		{
			return new TClientFollowShooterLeisureTypeUnion
			{
				Type = TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation,
				Value = _iclientfollowshooterplayanimation
			};
		}

		// Token: 0x0603A7BB RID: 239547 RVA: 0x007DF40D File Offset: 0x007DD60D
		public IClientFollowShooterPlaySkillT AsIClientFollowShooterPlaySkill()
		{
			return this.As<IClientFollowShooterPlaySkillT>();
		}

		// Token: 0x0603A7BC RID: 239548 RVA: 0x007DF415 File Offset: 0x007DD615
		public static TClientFollowShooterLeisureTypeUnion FromIClientFollowShooterPlaySkill(IClientFollowShooterPlaySkillT _iclientfollowshooterplayskill)
		{
			return new TClientFollowShooterLeisureTypeUnion
			{
				Type = TClientFollowShooterLeisureType.IClientFollowShooterPlaySkill,
				Value = _iclientfollowshooterplayskill
			};
		}

		// Token: 0x0603A7BD RID: 239549 RVA: 0x007DF42A File Offset: 0x007DD62A
		public IClientFollowShooterResetToPlayerT AsIClientFollowShooterResetToPlayer()
		{
			return this.As<IClientFollowShooterResetToPlayerT>();
		}

		// Token: 0x0603A7BE RID: 239550 RVA: 0x007DF432 File Offset: 0x007DD632
		public static TClientFollowShooterLeisureTypeUnion FromIClientFollowShooterResetToPlayer(IClientFollowShooterResetToPlayerT _iclientfollowshooterresettoplayer)
		{
			return new TClientFollowShooterLeisureTypeUnion
			{
				Type = TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer,
				Value = _iclientfollowshooterresettoplayer
			};
		}

		// Token: 0x0603A7BF RID: 239551 RVA: 0x007DF448 File Offset: 0x007DD648
		public static int Pack(FlatBufferBuilder builder, TClientFollowShooterLeisureTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation:
				return IClientFollowShooterPlayAnimation.Pack(builder, _o.AsIClientFollowShooterPlayAnimation()).Value;
			case TClientFollowShooterLeisureType.IClientFollowShooterPlaySkill:
				return IClientFollowShooterPlaySkill.Pack(builder, _o.AsIClientFollowShooterPlaySkill()).Value;
			case TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer:
				return IClientFollowShooterResetToPlayer.Pack(builder, _o.AsIClientFollowShooterResetToPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
