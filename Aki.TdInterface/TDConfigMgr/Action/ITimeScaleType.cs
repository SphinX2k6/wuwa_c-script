using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200220B RID: 8715
	public class ITimeScaleType
	{
		// Token: 0x0600BDFC RID: 48636 RVA: 0x001B7188 File Offset: 0x001B5388
		private ITimeScaleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScaleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScaleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScaleType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x001B71C0 File Offset: 0x001B53C0
		public static ITimeScaleType Create([Nullable(2)] ITimeScaleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x001B71D3 File Offset: 0x001B53D3
		public static ITimeScaleType CreateFromSetValue([Nullable(2)] ITimeScaleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x001B71E6 File Offset: 0x001B53E6
		public ITimeScaleType_SetValue ToSetValue()
		{
			return new ITimeScaleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x001B71F9 File Offset: 0x001B53F9
		// (set) Token: 0x0600BE01 RID: 48641 RVA: 0x001B7224 File Offset: 0x001B5424
		public virtual ETimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScaleType.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007202 RID: 29186
		[Nullable(2)]
		protected ITimeScaleType FbInstance;

		// Token: 0x04007203 RID: 29187
		[Nullable(2)]
		protected ITimeScaleType_SetValue PocoInterface;
	}
}
