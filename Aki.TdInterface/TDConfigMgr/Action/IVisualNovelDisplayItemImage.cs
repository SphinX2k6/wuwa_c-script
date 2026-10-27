using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206F RID: 8303
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelDisplayItemImage : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600B662 RID: 46690 RVA: 0x001A6DCC File Offset: 0x001A4FCC
		private IVisualNovelDisplayItemImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x001A6E04 File Offset: 0x001A5004
		public static IVisualNovelDisplayItemImage Create([Nullable(2)] IVisualNovelDisplayItemImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x001A6E17 File Offset: 0x001A5017
		public static IVisualNovelDisplayItemImage CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x001A6E2A File Offset: 0x001A502A
		public new IVisualNovelDisplayItemImage_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemImage_SetValue
			{
				Type = this.Type,
				DisplayImageId = this.DisplayImageId
			};
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600B666 RID: 46694 RVA: 0x001A6E49 File Offset: 0x001A5049
		// (set) Token: 0x0600B667 RID: 46695 RVA: 0x001A6E74 File Offset: 0x001A5074
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelDisplayItemType.Image;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600B668 RID: 46696 RVA: 0x001A6E82 File Offset: 0x001A5082
		// (set) Token: 0x0600B669 RID: 46697 RVA: 0x001A6EAD File Offset: 0x001A50AD
		public virtual int DisplayImageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayImageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DisplayImageId;
			}
			set
			{
				this.GetOrCreatePoco().DisplayImageId = value;
			}
		}

		// Token: 0x04006D90 RID: 28048
		[Nullable(2)]
		protected new IVisualNovelDisplayItemImage FbInstance;

		// Token: 0x04006D91 RID: 28049
		[Nullable(2)]
		protected new IVisualNovelDisplayItemImage_SetValue PocoInterface;
	}
}
