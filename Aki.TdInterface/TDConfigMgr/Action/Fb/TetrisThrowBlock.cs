using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE8 RID: 11752
	public class TetrisThrowBlock : ActionParams
	{
		// Token: 0x0600FFA0 RID: 65440 RVA: 0x0024D293 File Offset: 0x0024B493
		public static TetrisThrowBlock Create(ITetrisThrowBlock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisThrowBlock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x0600FFA1 RID: 65441 RVA: 0x0024D2B2 File Offset: 0x0024B4B2
		public virtual string ShapeName
		{
			get
			{
				return this.Instance.ShapeName;
			}
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x0600FFA2 RID: 65442 RVA: 0x0024D2BF File Offset: 0x0024B4BF
		public virtual int PosIndex
		{
			get
			{
				return this.Instance.PosIndex;
			}
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x0600FFA3 RID: 65443 RVA: 0x0024D2CC File Offset: 0x0024B4CC
		public virtual int HeightIndex
		{
			get
			{
				return this.Instance.HeightIndex;
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x0600FFA4 RID: 65444 RVA: 0x0024D2D9 File Offset: 0x0024B4D9
		public virtual ETetrisRotation Rotation
		{
			get
			{
				return (ETetrisRotation)this.Instance.Rotation;
			}
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x0600FFA5 RID: 65445 RVA: 0x0024D2E8 File Offset: 0x0024B4E8
		public virtual bool? IsDelayFall
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDelayFall);
			}
		}

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x0600FFA6 RID: 65446 RVA: 0x0024D320 File Offset: 0x0024B520
		public virtual int? FallSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FallSpeed);
			}
		}

		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x0600FFA7 RID: 65447 RVA: 0x0024D358 File Offset: 0x0024B558
		public virtual int? FallAcceleration
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FallAcceleration);
			}
		}

		// Token: 0x04008B8C RID: 35724
		private ITetrisThrowBlock Instance;
	}
}
