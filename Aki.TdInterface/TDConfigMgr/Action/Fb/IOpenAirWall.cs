using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BEC RID: 11244
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall : IToggleAirWallType
	{
		// Token: 0x0600F7A9 RID: 63401 RVA: 0x002409EF File Offset: 0x0023EBEF
		[NullableContext(0)]
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

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x00240A0E File Offset: 0x0023EC0E
		public override EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x0600F7AB RID: 63403 RVA: 0x00240A1B File Offset: 0x0023EC1B
		public virtual string HitEffectData
		{
			get
			{
				return this.Instance.HitEffectData;
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x0600F7AC RID: 63404 RVA: 0x00240A28 File Offset: 0x0023EC28
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

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x0600F7AD RID: 63405 RVA: 0x00240A5E File Offset: 0x0023EC5E
		public virtual string AirWallEffectData
		{
			get
			{
				return this.Instance.AirWallEffectData;
			}
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x0600F7AE RID: 63406 RVA: 0x00240A6B File Offset: 0x0023EC6B
		public virtual string VectorArrayAirWallEffectData
		{
			get
			{
				return this.Instance.VectorArrayAirWallEffectData;
			}
		}

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x0600F7AF RID: 63407 RVA: 0x00240A78 File Offset: 0x0023EC78
		public virtual int? AirWallEffectSplineEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AirWallEffectSplineEntityId);
			}
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x00240AB0 File Offset: 0x0023ECB0
		public virtual float? AirWallEffectHeight
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.AirWallEffectHeight);
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x0600F7B1 RID: 63409 RVA: 0x00240AE8 File Offset: 0x0023ECE8
		public virtual float? AirWallEffectThickness
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.AirWallEffectThickness);
			}
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x00240B1E File Offset: 0x0023ED1E
		public virtual EAirWallCollisionPreset CollisionPreset
		{
			get
			{
				return (EAirWallCollisionPreset)this.Instance.CollisionPreset;
			}
		}

		// Token: 0x0400879E RID: 34718
		private IOpenAirWall Instance;
	}
}
