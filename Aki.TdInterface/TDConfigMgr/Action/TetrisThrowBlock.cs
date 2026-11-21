using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A8 RID: 9384
	public class TetrisThrowBlock : ActionParams
	{
		// Token: 0x0600CC18 RID: 52248 RVA: 0x001D155C File Offset: 0x001CF75C
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

		// Token: 0x0600CC19 RID: 52249 RVA: 0x001D1594 File Offset: 0x001CF794
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

		// Token: 0x0600CC1A RID: 52250 RVA: 0x001D15A7 File Offset: 0x001CF7A7
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

		// Token: 0x0600CC1B RID: 52251 RVA: 0x001D15BC File Offset: 0x001CF7BC
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

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x001D1622 File Offset: 0x001CF822
		// (set) Token: 0x0600CC1D RID: 52253 RVA: 0x001D164D File Offset: 0x001CF84D
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

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600CC1E RID: 52254 RVA: 0x001D165B File Offset: 0x001CF85B
		// (set) Token: 0x0600CC1F RID: 52255 RVA: 0x001D1686 File Offset: 0x001CF886
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

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600CC20 RID: 52256 RVA: 0x001D1694 File Offset: 0x001CF894
		// (set) Token: 0x0600CC21 RID: 52257 RVA: 0x001D16BF File Offset: 0x001CF8BF
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

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600CC22 RID: 52258 RVA: 0x001D16CD File Offset: 0x001CF8CD
		// (set) Token: 0x0600CC23 RID: 52259 RVA: 0x001D16F8 File Offset: 0x001CF8F8
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

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x001D1708 File Offset: 0x001CF908
		// (set) Token: 0x0600CC25 RID: 52261 RVA: 0x001D1742 File Offset: 0x001CF942
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

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x001D1750 File Offset: 0x001CF950
		// (set) Token: 0x0600CC27 RID: 52263 RVA: 0x001D178A File Offset: 0x001CF98A
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

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x001D1798 File Offset: 0x001CF998
		// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x001D17D2 File Offset: 0x001CF9D2
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

		// Token: 0x040078FD RID: 30973
		[Nullable(2)]
		protected new TetrisThrowBlock FbInstance;

		// Token: 0x040078FE RID: 30974
		[Nullable(2)]
		protected TetrisThrowBlock_SetValue PocoInterface;
	}
}
