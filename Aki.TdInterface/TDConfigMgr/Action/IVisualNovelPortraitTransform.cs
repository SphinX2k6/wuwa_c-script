using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209F RID: 8351
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPortraitTransform
	{
		// Token: 0x0600B7AE RID: 47022 RVA: 0x001A9868 File Offset: 0x001A7A68
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

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001A98A0 File Offset: 0x001A7AA0
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

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x001A98B3 File Offset: 0x001A7AB3
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

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x001A98C6 File Offset: 0x001A7AC6
		public IVisualNovelPortraitTransform_SetValue ToSetValue()
		{
			return new IVisualNovelPortraitTransform_SetValue
			{
				PosX = this.PosX,
				PosY = this.PosY,
				Scale = this.Scale
			};
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600B7B2 RID: 47026 RVA: 0x001A98F4 File Offset: 0x001A7AF4
		// (set) Token: 0x0600B7B3 RID: 47027 RVA: 0x001A992E File Offset: 0x001A7B2E
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

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600B7B4 RID: 47028 RVA: 0x001A993C File Offset: 0x001A7B3C
		// (set) Token: 0x0600B7B5 RID: 47029 RVA: 0x001A9976 File Offset: 0x001A7B76
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

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600B7B6 RID: 47030 RVA: 0x001A9984 File Offset: 0x001A7B84
		// (set) Token: 0x0600B7B7 RID: 47031 RVA: 0x001A99BE File Offset: 0x001A7BBE
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

		// Token: 0x04006E3C RID: 28220
		[Nullable(2)]
		protected IVisualNovelPortraitTransform FbInstance;

		// Token: 0x04006E3D RID: 28221
		[Nullable(2)]
		protected IVisualNovelPortraitTransform_SetValue PocoInterface;
	}
}
