using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B6 RID: 8886
	public class IVisualNovelDisplayItemClose : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600C186 RID: 49542 RVA: 0x001BD568 File Offset: 0x001BB768
		private IVisualNovelDisplayItemClose_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDisplayItemClose 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDisplayItemClose_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDisplayItemClose_SetValue());
			}
			return result;
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x001BD5A0 File Offset: 0x001BB7A0
		public static IVisualNovelDisplayItemClose Create([Nullable(2)] IVisualNovelDisplayItemClose instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x001BD5B3 File Offset: 0x001BB7B3
		public static IVisualNovelDisplayItemClose CreateFromSetValue([Nullable(2)] IVisualNovelDisplayItemClose_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x001BD5C6 File Offset: 0x001BB7C6
		public new IVisualNovelDisplayItemClose_SetValue ToSetValue()
		{
			return new IVisualNovelDisplayItemClose_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600C18A RID: 49546 RVA: 0x001BD5D9 File Offset: 0x001BB7D9
		// (set) Token: 0x0600C18B RID: 49547 RVA: 0x001BD604 File Offset: 0x001BB804
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

		// Token: 0x04007399 RID: 29593
		[Nullable(2)]
		protected new IVisualNovelDisplayItemClose FbInstance;

		// Token: 0x0400739A RID: 29594
		[Nullable(2)]
		protected new IVisualNovelDisplayItemClose_SetValue PocoInterface;
	}
}
