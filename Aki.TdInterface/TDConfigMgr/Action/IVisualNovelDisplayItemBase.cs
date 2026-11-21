using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B4 RID: 8884
	public class IVisualNovelDisplayItemBase
	{
		// Token: 0x0600C17E RID: 49534 RVA: 0x001BD4AC File Offset: 0x001BB6AC
		private IVisualNovelDisplayItemBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x001BD4E4 File Offset: 0x001BB6E4
		public static IVisualNovelDisplayItemBase Create([Nullable(2)] IVisualNovelDisplayItemBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x001BD4F7 File Offset: 0x001BB6F7
		public static IVisualNovelDisplayItemBase CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x001BD50A File Offset: 0x001BB70A
		public IVisualNovelDisplayItemBase_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x001BD51D File Offset: 0x001BB71D
		// (set) Token: 0x0600C183 RID: 49539 RVA: 0x001BD548 File Offset: 0x001BB748
		public virtual EVisualNovelDisplayItemType Type
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

		// Token: 0x04007396 RID: 29590
		[Nullable(2)]
		protected IVisualNovelDisplayItemBase FbInstance;

		// Token: 0x04007397 RID: 29591
		[Nullable(2)]
		protected IVisualNovelDisplayItemBase_SetValue PocoInterface;
	}
}
