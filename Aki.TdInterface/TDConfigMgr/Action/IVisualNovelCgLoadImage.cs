using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AC RID: 8876
	public class IVisualNovelCgLoadImage : IVisualNovelCgBase
	{
		// Token: 0x0600C148 RID: 49480 RVA: 0x001BCE24 File Offset: 0x001BB024
		private IVisualNovelCgLoadImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgLoadImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgLoadImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgLoadImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x001BCE5C File Offset: 0x001BB05C
		public static IVisualNovelCgLoadImage Create([Nullable(2)] IVisualNovelCgLoadImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C14A RID: 49482 RVA: 0x001BCE6F File Offset: 0x001BB06F
		public static IVisualNovelCgLoadImage CreateFromSetValue([Nullable(2)] IVisualNovelCgLoadImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C14B RID: 49483 RVA: 0x001BCE82 File Offset: 0x001BB082
		public new IVisualNovelCgLoadImage_SetValue ToSetValue()
		{
			return new IVisualNovelCgLoadImage_SetValue
			{
				Type = this.Type,
				ImageId = this.ImageId
			};
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600C14C RID: 49484 RVA: 0x001BCEA1 File Offset: 0x001BB0A1
		// (set) Token: 0x0600C14D RID: 49485 RVA: 0x001BCECC File Offset: 0x001BB0CC
		public override EVisualNovelCgType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600C14E RID: 49486 RVA: 0x001BCEDA File Offset: 0x001BB0DA
		// (set) Token: 0x0600C14F RID: 49487 RVA: 0x001BCF05 File Offset: 0x001BB105
		public virtual int ImageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ImageId;
			}
			set
			{
				this.GetOrCreatePoco().ImageId = value;
			}
		}

		// Token: 0x0400737D RID: 29565
		[Nullable(2)]
		protected new IVisualNovelCgLoadImage FbInstance;

		// Token: 0x0400737E RID: 29566
		[Nullable(2)]
		protected new IVisualNovelCgLoadImage_SetValue PocoInterface;
	}
}
