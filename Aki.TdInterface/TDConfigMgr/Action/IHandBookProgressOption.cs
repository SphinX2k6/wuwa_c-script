using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C90 RID: 7312
	public class IHandBookProgressOption
	{
		// Token: 0x06009B5A RID: 39770 RVA: 0x00166EFC File Offset: 0x001650FC
		private IHandBookProgressOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandBookProgressOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandBookProgressOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandBookProgressOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x00166F34 File Offset: 0x00165134
		public static IHandBookProgressOption Create([Nullable(2)] IHandBookProgressOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookProgressOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x00166F47 File Offset: 0x00165147
		public static IHandBookProgressOption CreateFromSetValue([Nullable(2)] IHandBookProgressOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandBookProgressOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00166F5A File Offset: 0x0016515A
		public IHandBookProgressOption_SetValue ToSetValue()
		{
			return new IHandBookProgressOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x00166F6D File Offset: 0x0016516D
		// (set) Token: 0x06009B5F RID: 39775 RVA: 0x00166F98 File Offset: 0x00165198
		public virtual EHandBookProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandBookProgressType.GrantEmoji;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F37 RID: 24375
		[Nullable(2)]
		protected IHandBookProgressOption FbInstance;

		// Token: 0x04005F38 RID: 24376
		[Nullable(2)]
		protected IHandBookProgressOption_SetValue PocoInterface;
	}
}
