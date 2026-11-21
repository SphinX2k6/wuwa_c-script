using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C88 RID: 7304
	public class IGroupAiCommunicateMode
	{
		// Token: 0x06009B36 RID: 39734 RVA: 0x00166B8C File Offset: 0x00164D8C
		private IGroupAiCommunicateMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiCommunicateMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiCommunicateMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiCommunicateMode_SetValue());
			}
			return result;
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x00166BC4 File Offset: 0x00164DC4
		public static IGroupAiCommunicateMode Create([Nullable(2)] IGroupAiCommunicateMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x00166BD7 File Offset: 0x00164DD7
		public static IGroupAiCommunicateMode CreateFromSetValue([Nullable(2)] IGroupAiCommunicateMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiCommunicateMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x00166BEA File Offset: 0x00164DEA
		public IGroupAiCommunicateMode_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009B3A RID: 39738 RVA: 0x00166BFD File Offset: 0x00164DFD
		// (set) Token: 0x06009B3B RID: 39739 RVA: 0x00166C28 File Offset: 0x00164E28
		public virtual EGroupAiCommunicateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F29 RID: 24361
		[Nullable(2)]
		protected IGroupAiCommunicateMode FbInstance;

		// Token: 0x04005F2A RID: 24362
		[Nullable(2)]
		protected IGroupAiCommunicateMode_SetValue PocoInterface;
	}
}
