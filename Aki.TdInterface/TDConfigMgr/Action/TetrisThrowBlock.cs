using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223D RID: 8765
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisThrowBlock : ActionParams
	{
		// Token: 0x0600C05A RID: 49242 RVA: 0x001B9E90 File Offset: 0x001B8090
		private TetrisThrowBlock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TetrisThrowBlock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TetrisThrowBlock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TetrisThrowBlock_SetValue());
			}
			return result;
		}

		// Token: 0x0600C05B RID: 49243 RVA: 0x001B9EC8 File Offset: 0x001B80C8
		public static TetrisThrowBlock Create([Nullable(2)] TetrisThrowBlock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisThrowBlock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x001B9EDB File Offset: 0x001B80DB
		public static TetrisThrowBlock CreateFromSetValue([Nullable(2)] TetrisThrowBlock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TetrisThrowBlock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C05D RID: 49245 RVA: 0x001B9EF0 File Offset: 0x001B80F0
		public TetrisThrowBlock_SetValue ToSetValue()
		{
			return new TetrisThrowBlock_SetValue
			{
				ShapeName = this.ShapeName,
				PosIndex = this.PosIndex,
				HeightIndex = this.HeightIndex,
				Rotation = this.Rotation,
				IsDelayFall = this.IsDelayFall,
				FallSpeed = this.FallSpeed,
				FallAcceleration = this.FallAcceleration
			};
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600C05E RID: 49246 RVA: 0x001B9F56 File Offset: 0x001B8156
		// (set) Token: 0x0600C05F RID: 49247 RVA: 0x001B9F81 File Offset: 0x001B8181
		public virtual string ShapeName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShapeName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ShapeName;
			}
			set
			{
				this.GetOrCreatePoco().ShapeName = value;
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600C060 RID: 49248 RVA: 0x001B9F8F File Offset: 0x001B818F
		// (set) Token: 0x0600C061 RID: 49249 RVA: 0x001B9FBA File Offset: 0x001B81BA
		public virtual int PosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PosIndex;
			}
			set
			{
				this.GetOrCreatePoco().PosIndex = value;
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600C062 RID: 49250 RVA: 0x001B9FC8 File Offset: 0x001B81C8
		// (set) Token: 0x0600C063 RID: 49251 RVA: 0x001B9FF3 File Offset: 0x001B81F3
		public virtual int HeightIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HeightIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HeightIndex;
			}
			set
			{
				this.GetOrCreatePoco().HeightIndex = value;
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600C064 RID: 49252 RVA: 0x001BA001 File Offset: 0x001B8201
		// (set) Token: 0x0600C065 RID: 49253 RVA: 0x001BA02C File Offset: 0x001B822C
		public virtual ETetrisRotation Rotation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Rotation;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisRotation.Origin;
				}
				return this.PocoInterface.Rotation;
			}
			set
			{
				this.GetOrCreatePoco().Rotation = value;
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600C066 RID: 49254 RVA: 0x001BA03C File Offset: 0x001B823C
		// (set) Token: 0x0600C067 RID: 49255 RVA: 0x001BA076 File Offset: 0x001B8276
		public virtual bool? IsDelayFall
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDelayFall;
				}
				TetrisThrowBlock_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDelayFall;
			}
			set
			{
				this.GetOrCreatePoco().IsDelayFall = value;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600C068 RID: 49256 RVA: 0x001BA084 File Offset: 0x001B8284
		// (set) Token: 0x0600C069 RID: 49257 RVA: 0x001BA0BE File Offset: 0x001B82BE
		public virtual int? FallSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallSpeed;
				}
				TetrisThrowBlock_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FallSpeed;
			}
			set
			{
				this.GetOrCreatePoco().FallSpeed = value;
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600C06A RID: 49258 RVA: 0x001BA0CC File Offset: 0x001B82CC
		// (set) Token: 0x0600C06B RID: 49259 RVA: 0x001BA106 File Offset: 0x001B8306
		public virtual int? FallAcceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallAcceleration;
				}
				TetrisThrowBlock_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FallAcceleration;
			}
			set
			{
				this.GetOrCreatePoco().FallAcceleration = value;
			}
		}

		// Token: 0x040072B3 RID: 29363
		[Nullable(2)]
		protected new TetrisThrowBlock FbInstance;

		// Token: 0x040072B4 RID: 29364
		[Nullable(2)]
		protected TetrisThrowBlock_SetValue PocoInterface;
	}
}
