using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C9A RID: 7322
	public class IHeadStyle
	{
		// Token: 0x06009B8A RID: 39818 RVA: 0x0016739C File Offset: 0x0016559C
		private IHeadStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x001673D4 File Offset: 0x001655D4
		public static IHeadStyle Create([Nullable(2)] IHeadStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x001673E7 File Offset: 0x001655E7
		public static IHeadStyle CreateFromSetValue([Nullable(2)] IHeadStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x001673FA File Offset: 0x001655FA
		public IHeadStyle_SetValue ToSetValue()
		{
			return new IHeadStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06009B8E RID: 39822 RVA: 0x0016740D File Offset: 0x0016560D
		// (set) Token: 0x06009B8F RID: 39823 RVA: 0x00167438 File Offset: 0x00165638
		public virtual EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F4A RID: 24394
		[Nullable(2)]
		protected IHeadStyle FbInstance;

		// Token: 0x04005F4B RID: 24395
		[Nullable(2)]
		protected IHeadStyle_SetValue PocoInterface;
	}
}
