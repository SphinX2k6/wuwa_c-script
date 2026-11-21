using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002436 RID: 9270
	public class SetPlayerMoveControl : ActionParams
	{
		// Token: 0x0600C9B2 RID: 51634 RVA: 0x001CCC84 File Offset: 0x001CAE84
		private SetPlayerMoveControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPlayerMoveControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPlayerMoveControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPlayerMoveControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x001CCCBC File Offset: 0x001CAEBC
		public static SetPlayerMoveControl Create([Nullable(2)] SetPlayerMoveControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerMoveControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x001CCCCF File Offset: 0x001CAECF
		public static SetPlayerMoveControl CreateFromSetValue([Nullable(2)] SetPlayerMoveControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPlayerMoveControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C9B5 RID: 51637 RVA: 0x001CCCE2 File Offset: 0x001CAEE2
		public SetPlayerMoveControl_SetValue ToSetValue()
		{
			return new SetPlayerMoveControl_SetValue
			{
				Left = this.Left,
				Right = this.Right,
				Forward = this.Forward,
				Back = this.Back
			};
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x001CCD19 File Offset: 0x001CAF19
		// (set) Token: 0x0600C9B7 RID: 51639 RVA: 0x001CCD44 File Offset: 0x001CAF44
		public virtual int Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x001CCD52 File Offset: 0x001CAF52
		// (set) Token: 0x0600C9B9 RID: 51641 RVA: 0x001CCD7D File Offset: 0x001CAF7D
		public virtual int Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x001CCD8B File Offset: 0x001CAF8B
		// (set) Token: 0x0600C9BB RID: 51643 RVA: 0x001CCDB6 File Offset: 0x001CAFB6
		public virtual int Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x001CCDC4 File Offset: 0x001CAFC4
		// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x001CCDEF File Offset: 0x001CAFEF
		public virtual int Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x040077A5 RID: 30629
		[Nullable(2)]
		protected new SetPlayerMoveControl FbInstance;

		// Token: 0x040077A6 RID: 30630
		[Nullable(2)]
		protected SetPlayerMoveControl_SetValue PocoInterface;
	}
}
