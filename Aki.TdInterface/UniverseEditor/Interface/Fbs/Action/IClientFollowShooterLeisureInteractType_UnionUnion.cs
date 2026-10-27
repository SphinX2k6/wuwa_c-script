using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C5 RID: 25541
	public class IClientFollowShooterLeisureInteractType_UnionUnion
	{
		// Token: 0x1700BE4E RID: 48718
		// (get) Token: 0x0602C2DB RID: 180955 RVA: 0x00610DB5 File Offset: 0x0060EFB5
		// (set) Token: 0x0602C2DC RID: 180956 RVA: 0x00610DBD File Offset: 0x0060EFBD
		public IClientFollowShooterLeisureInteractType_Union Type { get; set; }

		// Token: 0x1700BE4F RID: 48719
		// (get) Token: 0x0602C2DD RID: 180957 RVA: 0x00610DC6 File Offset: 0x0060EFC6
		// (set) Token: 0x0602C2DE RID: 180958 RVA: 0x00610DCE File Offset: 0x0060EFCE
		public object Value { get; set; }

		// Token: 0x0602C2DF RID: 180959 RVA: 0x00610DD7 File Offset: 0x0060EFD7
		public IClientFollowShooterLeisureInteractType_UnionUnion()
		{
			this.Type = IClientFollowShooterLeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C2E0 RID: 180960 RVA: 0x00610DED File Offset: 0x0060EFED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C2E1 RID: 180961 RVA: 0x00610DFF File Offset: 0x0060EFFF
		public IClientFollowShooterLeisureInteractTypeT AsIClientFollowShooterLeisureInteractType()
		{
			return this.As<IClientFollowShooterLeisureInteractTypeT>();
		}

		// Token: 0x0602C2E2 RID: 180962 RVA: 0x00610E07 File Offset: 0x0060F007
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterLeisureInteractType(IClientFollowShooterLeisureInteractTypeT _iclientfollowshooterleisureinteracttype)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterLeisureInteractType,
				Value = _iclientfollowshooterleisureinteracttype
			};
		}

		// Token: 0x0602C2E3 RID: 180963 RVA: 0x00610E1C File Offset: 0x0060F01C
		public IClientFollowShooterResetToPlayerT AsIClientFollowShooterResetToPlayer()
		{
			return this.As<IClientFollowShooterResetToPlayerT>();
		}

		// Token: 0x0602C2E4 RID: 180964 RVA: 0x00610E24 File Offset: 0x0060F024
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterResetToPlayer(IClientFollowShooterResetToPlayerT _iclientfollowshooterresettoplayer)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterResetToPlayer,
				Value = _iclientfollowshooterresettoplayer
			};
		}

		// Token: 0x0602C2E5 RID: 180965 RVA: 0x00610E39 File Offset: 0x0060F039
		public IClientFollowShooterPlayAnimationT AsIClientFollowShooterPlayAnimation()
		{
			return this.As<IClientFollowShooterPlayAnimationT>();
		}

		// Token: 0x0602C2E6 RID: 180966 RVA: 0x00610E41 File Offset: 0x0060F041
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterPlayAnimation(IClientFollowShooterPlayAnimationT _iclientfollowshooterplayanimation)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterPlayAnimation,
				Value = _iclientfollowshooterplayanimation
			};
		}

		// Token: 0x0602C2E7 RID: 180967 RVA: 0x00610E58 File Offset: 0x0060F058
		public static int Pack(FlatBufferBuilder builder, IClientFollowShooterLeisureInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterLeisureInteractType:
				return IClientFollowShooterLeisureInteractType.Pack(builder, _o.AsIClientFollowShooterLeisureInteractType()).Value;
			case IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterResetToPlayer:
				return IClientFollowShooterResetToPlayer.Pack(builder, _o.AsIClientFollowShooterResetToPlayer()).Value;
			case IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterPlayAnimation:
				return IClientFollowShooterPlayAnimation.Pack(builder, _o.AsIClientFollowShooterPlayAnimation()).Value;
			default:
				return 0;
			}
		}
	}
}
