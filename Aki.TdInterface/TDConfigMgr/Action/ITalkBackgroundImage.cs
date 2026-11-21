using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002155 RID: 8533
	public class ITalkBackgroundImage : ITalkBackground
	{
		// Token: 0x0600B516 RID: 46358 RVA: 0x0019573C File Offset: 0x0019393C
		private ITalkBackgroundImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x00195774 File Offset: 0x00193974
		public static ITalkBackgroundImage Create([Nullable(2)] ITalkBackgroundImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x00195787 File Offset: 0x00193987
		public static ITalkBackgroundImage CreateFromSetValue([Nullable(2)] ITalkBackgroundImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x0019579A File Offset: 0x0019399A
		public new ITalkBackgroundImage_SetValue ToSetValue()
		{
			return new ITalkBackgroundImage_SetValue
			{
				Type = this.Type,
				ImageAsset = this.ImageAsset
			};
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600B51A RID: 46362 RVA: 0x001957B9 File Offset: 0x001939B9
		// (set) Token: 0x0600B51B RID: 46363 RVA: 0x001957E4 File Offset: 0x001939E4
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600B51C RID: 46364 RVA: 0x001957F2 File Offset: 0x001939F2
		// (set) Token: 0x0600B51D RID: 46365 RVA: 0x0019581D File Offset: 0x00193A1D
		public virtual string ImageAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAsset;
			}
			set
			{
				this.GetOrCreatePoco().ImageAsset = value;
			}
		}

		// Token: 0x04006B17 RID: 27415
		[Nullable(2)]
		protected new ITalkBackgroundImage FbInstance;

		// Token: 0x04006B18 RID: 27416
		[Nullable(2)]
		protected new ITalkBackgroundImage_SetValue PocoInterface;
	}
}
