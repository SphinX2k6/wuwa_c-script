using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F0 RID: 8944
	public class IVisualNovelPortraitTransform
	{
		// Token: 0x0600C2F2 RID: 49906 RVA: 0x001C0294 File Offset: 0x001BE494
		private IVisualNovelPortraitTransform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPortraitTransform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPortraitTransform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPortraitTransform_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x001C02CC File Offset: 0x001BE4CC
		public static IVisualNovelPortraitTransform Create([Nullable(2)] IVisualNovelPortraitTransform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPortraitTransform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x001C02DF File Offset: 0x001BE4DF
		public static IVisualNovelPortraitTransform CreateFromSetValue([Nullable(2)] IVisualNovelPortraitTransform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPortraitTransform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x001C02F2 File Offset: 0x001BE4F2
		public IVisualNovelPortraitTransform_SetValue ToSetValue()
		{
			return new IVisualNovelPortraitTransform_SetValue
			{
				PosX = this.PosX,
				PosY = this.PosY,
				Scale = this.Scale
			};
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x001C0320 File Offset: 0x001BE520
		// (set) Token: 0x0600C2F7 RID: 49911 RVA: 0x001C035A File Offset: 0x001BE55A
		public virtual int? PosX
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosX;
				}
				IVisualNovelPortraitTransform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PosX;
			}
			set
			{
				this.GetOrCreatePoco().PosX = value;
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600C2F8 RID: 49912 RVA: 0x001C0368 File Offset: 0x001BE568
		// (set) Token: 0x0600C2F9 RID: 49913 RVA: 0x001C03A2 File Offset: 0x001BE5A2
		public virtual int? PosY
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosY;
				}
				IVisualNovelPortraitTransform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PosY;
			}
			set
			{
				this.GetOrCreatePoco().PosY = value;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600C2FA RID: 49914 RVA: 0x001C03B0 File Offset: 0x001BE5B0
		// (set) Token: 0x0600C2FB RID: 49915 RVA: 0x001C03EA File Offset: 0x001BE5EA
		public virtual float? Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				IVisualNovelPortraitTransform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x04007452 RID: 29778
		[Nullable(2)]
		protected IVisualNovelPortraitTransform FbInstance;

		// Token: 0x04007453 RID: 29779
		[Nullable(2)]
		protected IVisualNovelPortraitTransform_SetValue PocoInterface;
	}
}
