using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF4 RID: 10996
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisThrowBlock : ActionParams
	{
		// Token: 0x0600F0EA RID: 61674 RVA: 0x0022F587 File Offset: 0x0022D787
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

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x0600F0EB RID: 61675 RVA: 0x0022F5A6 File Offset: 0x0022D7A6
		public virtual string ShapeName
		{
			get
			{
				return this.Instance.ShapeName;
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x0022F5B3 File Offset: 0x0022D7B3
		public virtual int PosIndex
		{
			get
			{
				return this.Instance.PosIndex;
			}
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x0600F0ED RID: 61677 RVA: 0x0022F5C0 File Offset: 0x0022D7C0
		public virtual int HeightIndex
		{
			get
			{
				return this.Instance.HeightIndex;
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x0600F0EE RID: 61678 RVA: 0x0022F5CD File Offset: 0x0022D7CD
		public virtual ETetrisRotation Rotation
		{
			get
			{
				return (ETetrisRotation)this.Instance.Rotation;
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x0600F0EF RID: 61679 RVA: 0x0022F5DC File Offset: 0x0022D7DC
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

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x0600F0F0 RID: 61680 RVA: 0x0022F614 File Offset: 0x0022D814
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

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x0600F0F1 RID: 61681 RVA: 0x0022F64C File Offset: 0x0022D84C
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

		// Token: 0x04008488 RID: 33928
		private ITetrisThrowBlock Instance;
	}
}
