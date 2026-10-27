using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002063 RID: 8291
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelCgLoadImage : IVisualNovelCgBase
	{
		// Token: 0x0600B622 RID: 46626 RVA: 0x001A66B8 File Offset: 0x001A48B8
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

		// Token: 0x0600B623 RID: 46627 RVA: 0x001A66F0 File Offset: 0x001A48F0
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

		// Token: 0x0600B624 RID: 46628 RVA: 0x001A6703 File Offset: 0x001A4903
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

		// Token: 0x0600B625 RID: 46629 RVA: 0x001A6716 File Offset: 0x001A4916
		public new IVisualNovelCgLoadImage_SetValue ToSetValue()
		{
			return new IVisualNovelCgLoadImage_SetValue
			{
				Type = this.Type,
				ImageId = this.ImageId
			};
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B626 RID: 46630 RVA: 0x001A6735 File Offset: 0x001A4935
		// (set) Token: 0x0600B627 RID: 46631 RVA: 0x001A6760 File Offset: 0x001A4960
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
					return EVisualNovelCgType.LoadSpine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B628 RID: 46632 RVA: 0x001A676E File Offset: 0x001A496E
		// (set) Token: 0x0600B629 RID: 46633 RVA: 0x001A6799 File Offset: 0x001A4999
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

		// Token: 0x04006D74 RID: 28020
		[Nullable(2)]
		protected new IVisualNovelCgLoadImage FbInstance;

		// Token: 0x04006D75 RID: 28021
		[Nullable(2)]
		protected new IVisualNovelCgLoadImage_SetValue PocoInterface;
	}
}
