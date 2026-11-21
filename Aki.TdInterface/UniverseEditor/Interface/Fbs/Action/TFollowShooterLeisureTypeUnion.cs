using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE9 RID: 32489
	public class TFollowShooterLeisureTypeUnion
	{
		// Token: 0x1700F269 RID: 62057
		// (get) Token: 0x0603A9ED RID: 240109 RVA: 0x007E2EAA File Offset: 0x007E10AA
		// (set) Token: 0x0603A9EE RID: 240110 RVA: 0x007E2EB2 File Offset: 0x007E10B2
		public TFollowShooterLeisureType Type { get; set; }

		// Token: 0x1700F26A RID: 62058
		// (get) Token: 0x0603A9EF RID: 240111 RVA: 0x007E2EBB File Offset: 0x007E10BB
		// (set) Token: 0x0603A9F0 RID: 240112 RVA: 0x007E2EC3 File Offset: 0x007E10C3
		public object Value { get; set; }

		// Token: 0x0603A9F1 RID: 240113 RVA: 0x007E2ECC File Offset: 0x007E10CC
		public TFollowShooterLeisureTypeUnion()
		{
			this.Type = TFollowShooterLeisureType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9F2 RID: 240114 RVA: 0x007E2EE2 File Offset: 0x007E10E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9F3 RID: 240115 RVA: 0x007E2EF4 File Offset: 0x007E10F4
		public IFollowShooterLeaveThrowInteractionPointT AsIFollowShooterLeaveThrowInteractionPoint()
		{
			return this.As<IFollowShooterLeaveThrowInteractionPointT>();
		}

		// Token: 0x0603A9F4 RID: 240116 RVA: 0x007E2EFC File Offset: 0x007E10FC
		public static TFollowShooterLeisureTypeUnion FromIFollowShooterLeaveThrowInteractionPoint(IFollowShooterLeaveThrowInteractionPointT _ifollowshooterleavethrowinteractionpoint)
		{
			return new TFollowShooterLeisureTypeUnion
			{
				Type = TFollowShooterLeisureType.IFollowShooterLeaveThrowInteractionPoint,
				Value = _ifollowshooterleavethrowinteractionpoint
			};
		}

		// Token: 0x0603A9F5 RID: 240117 RVA: 0x007E2F11 File Offset: 0x007E1111
		public IFollowShooterResetToPlayerT AsIFollowShooterResetToPlayer()
		{
			return this.As<IFollowShooterResetToPlayerT>();
		}

		// Token: 0x0603A9F6 RID: 240118 RVA: 0x007E2F19 File Offset: 0x007E1119
		public static TFollowShooterLeisureTypeUnion FromIFollowShooterResetToPlayer(IFollowShooterResetToPlayerT _ifollowshooterresettoplayer)
		{
			return new TFollowShooterLeisureTypeUnion
			{
				Type = TFollowShooterLeisureType.IFollowShooterResetToPlayer,
				Value = _ifollowshooterresettoplayer
			};
		}

		// Token: 0x0603A9F7 RID: 240119 RVA: 0x007E2F30 File Offset: 0x007E1130
		public static int Pack(FlatBufferBuilder builder, TFollowShooterLeisureTypeUnion _o)
		{
			TFollowShooterLeisureType type = _o.Type;
			if (type == TFollowShooterLeisureType.IFollowShooterLeaveThrowInteractionPoint)
			{
				return IFollowShooterLeaveThrowInteractionPoint.Pack(builder, _o.AsIFollowShooterLeaveThrowInteractionPoint()).Value;
			}
			if (type != TFollowShooterLeisureType.IFollowShooterResetToPlayer)
			{
				return 0;
			}
			return IFollowShooterResetToPlayer.Pack(builder, _o.AsIFollowShooterResetToPlayer()).Value;
		}
	}
}
