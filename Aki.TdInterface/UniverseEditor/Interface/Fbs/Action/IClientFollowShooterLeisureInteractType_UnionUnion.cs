using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3F RID: 27199
	public class IClientFollowShooterLeisureInteractType_UnionUnion
	{
		// Token: 0x1700C7DA RID: 51162
		// (get) Token: 0x0602EA6E RID: 191086 RVA: 0x0065C2BD File Offset: 0x0065A4BD
		// (set) Token: 0x0602EA6F RID: 191087 RVA: 0x0065C2C5 File Offset: 0x0065A4C5
		public IClientFollowShooterLeisureInteractType_Union Type { get; set; }

		// Token: 0x1700C7DB RID: 51163
		// (get) Token: 0x0602EA70 RID: 191088 RVA: 0x0065C2CE File Offset: 0x0065A4CE
		// (set) Token: 0x0602EA71 RID: 191089 RVA: 0x0065C2D6 File Offset: 0x0065A4D6
		public object Value { get; set; }

		// Token: 0x0602EA72 RID: 191090 RVA: 0x0065C2DF File Offset: 0x0065A4DF
		public IClientFollowShooterLeisureInteractType_UnionUnion()
		{
			this.Type = IClientFollowShooterLeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EA73 RID: 191091 RVA: 0x0065C2F5 File Offset: 0x0065A4F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EA74 RID: 191092 RVA: 0x0065C307 File Offset: 0x0065A507
		public IClientFollowShooterLeisureInteractTypeT AsIClientFollowShooterLeisureInteractType()
		{
			return this.As<IClientFollowShooterLeisureInteractTypeT>();
		}

		// Token: 0x0602EA75 RID: 191093 RVA: 0x0065C30F File Offset: 0x0065A50F
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterLeisureInteractType(IClientFollowShooterLeisureInteractTypeT _iclientfollowshooterleisureinteracttype)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterLeisureInteractType,
				Value = _iclientfollowshooterleisureinteracttype
			};
		}

		// Token: 0x0602EA76 RID: 191094 RVA: 0x0065C324 File Offset: 0x0065A524
		public IClientFollowShooterResetToPlayerT AsIClientFollowShooterResetToPlayer()
		{
			return this.As<IClientFollowShooterResetToPlayerT>();
		}

		// Token: 0x0602EA77 RID: 191095 RVA: 0x0065C32C File Offset: 0x0065A52C
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterResetToPlayer(IClientFollowShooterResetToPlayerT _iclientfollowshooterresettoplayer)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterResetToPlayer,
				Value = _iclientfollowshooterresettoplayer
			};
		}

		// Token: 0x0602EA78 RID: 191096 RVA: 0x0065C341 File Offset: 0x0065A541
		public IClientFollowShooterPlayAnimationT AsIClientFollowShooterPlayAnimation()
		{
			return this.As<IClientFollowShooterPlayAnimationT>();
		}

		// Token: 0x0602EA79 RID: 191097 RVA: 0x0065C349 File Offset: 0x0065A549
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterPlayAnimation(IClientFollowShooterPlayAnimationT _iclientfollowshooterplayanimation)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterPlayAnimation,
				Value = _iclientfollowshooterplayanimation
			};
		}

		// Token: 0x0602EA7A RID: 191098 RVA: 0x0065C35E File Offset: 0x0065A55E
		public IClientFollowShooterPlaySkillT AsIClientFollowShooterPlaySkill()
		{
			return this.As<IClientFollowShooterPlaySkillT>();
		}

		// Token: 0x0602EA7B RID: 191099 RVA: 0x0065C366 File Offset: 0x0065A566
		public static IClientFollowShooterLeisureInteractType_UnionUnion FromIClientFollowShooterPlaySkill(IClientFollowShooterPlaySkillT _iclientfollowshooterplayskill)
		{
			return new IClientFollowShooterLeisureInteractType_UnionUnion
			{
				Type = IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterPlaySkill,
				Value = _iclientfollowshooterplayskill
			};
		}

		// Token: 0x0602EA7C RID: 191100 RVA: 0x0065C37C File Offset: 0x0065A57C
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
			case IClientFollowShooterLeisureInteractType_Union.IClientFollowShooterPlaySkill:
				return IClientFollowShooterPlaySkill.Pack(builder, _o.AsIClientFollowShooterPlaySkill()).Value;
			default:
				return 0;
			}
		}
	}
}
