using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE2 RID: 28386
	public class IFollowShooterLeisureInteractType_UnionUnion
	{
		// Token: 0x1700D029 RID: 53289
		// (get) Token: 0x060311C3 RID: 201155 RVA: 0x006A881D File Offset: 0x006A6A1D
		// (set) Token: 0x060311C4 RID: 201156 RVA: 0x006A8825 File Offset: 0x006A6A25
		public IFollowShooterLeisureInteractType_Union Type { get; set; }

		// Token: 0x1700D02A RID: 53290
		// (get) Token: 0x060311C5 RID: 201157 RVA: 0x006A882E File Offset: 0x006A6A2E
		// (set) Token: 0x060311C6 RID: 201158 RVA: 0x006A8836 File Offset: 0x006A6A36
		public object Value { get; set; }

		// Token: 0x060311C7 RID: 201159 RVA: 0x006A883F File Offset: 0x006A6A3F
		public IFollowShooterLeisureInteractType_UnionUnion()
		{
			this.Type = IFollowShooterLeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060311C8 RID: 201160 RVA: 0x006A8855 File Offset: 0x006A6A55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060311C9 RID: 201161 RVA: 0x006A8867 File Offset: 0x006A6A67
		public IFollowShooterLeisureInteractTypeT AsIFollowShooterLeisureInteractType()
		{
			return this.As<IFollowShooterLeisureInteractTypeT>();
		}

		// Token: 0x060311CA RID: 201162 RVA: 0x006A886F File Offset: 0x006A6A6F
		public static IFollowShooterLeisureInteractType_UnionUnion FromIFollowShooterLeisureInteractType(IFollowShooterLeisureInteractTypeT _ifollowshooterleisureinteracttype)
		{
			return new IFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IFollowShooterLeisureInteractType_Union.IFollowShooterLeisureInteractType,
				Value = _ifollowshooterleisureinteracttype
			};
		}

		// Token: 0x060311CB RID: 201163 RVA: 0x006A8884 File Offset: 0x006A6A84
		public IFollowShooterResetToPlayerT AsIFollowShooterResetToPlayer()
		{
			return this.As<IFollowShooterResetToPlayerT>();
		}

		// Token: 0x060311CC RID: 201164 RVA: 0x006A888C File Offset: 0x006A6A8C
		public static IFollowShooterLeisureInteractType_UnionUnion FromIFollowShooterResetToPlayer(IFollowShooterResetToPlayerT _ifollowshooterresettoplayer)
		{
			return new IFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IFollowShooterLeisureInteractType_Union.IFollowShooterResetToPlayer,
				Value = _ifollowshooterresettoplayer
			};
		}

		// Token: 0x060311CD RID: 201165 RVA: 0x006A88A1 File Offset: 0x006A6AA1
		public IFollowShooterLeaveThrowInteractionPointT AsIFollowShooterLeaveThrowInteractionPoint()
		{
			return this.As<IFollowShooterLeaveThrowInteractionPointT>();
		}

		// Token: 0x060311CE RID: 201166 RVA: 0x006A88A9 File Offset: 0x006A6AA9
		public static IFollowShooterLeisureInteractType_UnionUnion FromIFollowShooterLeaveThrowInteractionPoint(IFollowShooterLeaveThrowInteractionPointT _ifollowshooterleavethrowinteractionpoint)
		{
			return new IFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IFollowShooterLeisureInteractType_Union.IFollowShooterLeaveThrowInteractionPoint,
				Value = _ifollowshooterleavethrowinteractionpoint
			};
		}

		// Token: 0x060311CF RID: 201167 RVA: 0x006A88C0 File Offset: 0x006A6AC0
		public static int Pack(FlatBufferBuilder builder, IFollowShooterLeisureInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFollowShooterLeisureInteractType_Union.IFollowShooterLeisureInteractType:
				return IFollowShooterLeisureInteractType.Pack(builder, _o.AsIFollowShooterLeisureInteractType()).Value;
			case IFollowShooterLeisureInteractType_Union.IFollowShooterResetToPlayer:
				return IFollowShooterResetToPlayer.Pack(builder, _o.AsIFollowShooterResetToPlayer()).Value;
			case IFollowShooterLeisureInteractType_Union.IFollowShooterLeaveThrowInteractionPoint:
				return IFollowShooterLeaveThrowInteractionPoint.Pack(builder, _o.AsIFollowShooterLeaveThrowInteractionPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
