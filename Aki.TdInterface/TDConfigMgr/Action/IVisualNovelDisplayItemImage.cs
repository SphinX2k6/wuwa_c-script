using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B8 RID: 8888
	public class IVisualNovelDisplayItemImage : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600C18E RID: 49550 RVA: 0x001BD624 File Offset: 0x001BB824
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

		// Token: 0x0600C18F RID: 49551 RVA: 0x001BD65C File Offset: 0x001BB85C
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

		// Token: 0x0600C190 RID: 49552 RVA: 0x001BD66F File Offset: 0x001BB86F
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

		// Token: 0x0600C191 RID: 49553 RVA: 0x001BD682 File Offset: 0x001BB882
		public new IVisualNovelDisplayItemImage_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemImage_SetValue
			{
				Type = this.Type,
				DisplayImageId = this.DisplayImageId
			};
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600C192 RID: 49554 RVA: 0x001BD6A1 File Offset: 0x001BB8A1
		// (set) Token: 0x0600C193 RID: 49555 RVA: 0x001BD6CC File Offset: 0x001BB8CC
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

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600C194 RID: 49556 RVA: 0x001BD6DA File Offset: 0x001BB8DA
		// (set) Token: 0x0600C195 RID: 49557 RVA: 0x001BD705 File Offset: 0x001BB905
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

		// Token: 0x0400739C RID: 29596
		[Nullable(2)]
		protected new IVisualNovelDisplayItemImage FbInstance;

		// Token: 0x0400739D RID: 29597
		[Nullable(2)]
		protected new IVisualNovelDisplayItemImage_SetValue PocoInterface;
	}
}
