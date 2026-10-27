using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002910 RID: 10512
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall : IToggleAirWallType
	{
		// Token: 0x0600E958 RID: 59736 RVA: 0x002236CF File Offset: 0x002218CF
		[NullableContext(1)]
		public static IOpenAirWall Create(IOpenAirWall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenAirWall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x0600E959 RID: 59737 RVA: 0x002236EE File Offset: 0x002218EE
		public override EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x0600E95A RID: 59738 RVA: 0x002236FB File Offset: 0x002218FB
		public virtual string HitEffectData
		{
			get
			{
				return this.Instance.HitEffectData;
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x0600E95B RID: 59739 RVA: 0x00223708 File Offset: 0x00221908
		public virtual float? HitCd
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.HitCd);
			}
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x0600E95C RID: 59740 RVA: 0x0022373E File Offset: 0x0022193E
		public virtual string AirWallEffectData
		{
			get
			{
				return this.Instance.AirWallEffectData;
			}
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x0600E95D RID: 59741 RVA: 0x0022374B File Offset: 0x0022194B
		public virtual string VectorArrayAirWallEffectData
		{
			get
			{
				return this.Instance.VectorArrayAirWallEffectData;
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x0600E95E RID: 59742 RVA: 0x00223758 File Offset: 0x00221958
		public virtual float? AirWallEffectHeight
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.AirWallEffectHeight);
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x0600E95F RID: 59743 RVA: 0x00223790 File Offset: 0x00221990
		public virtual float? AirWallEffectThickness
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.AirWallEffectThickness);
			}
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x0600E960 RID: 59744 RVA: 0x002237C6 File Offset: 0x002219C6
		public virtual EAirWallCollisionPreset CollisionPreset
		{
			get
			{
				return (EAirWallCollisionPreset)this.Instance.CollisionPreset;
			}
		}

		// Token: 0x040080D0 RID: 32976
		private IOpenAirWall Instance;
	}
}
