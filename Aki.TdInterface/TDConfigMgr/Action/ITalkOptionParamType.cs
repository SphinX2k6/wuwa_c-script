using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F72 RID: 8050
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionParamType
	{
		// Token: 0x0600B126 RID: 45350 RVA: 0x0019D9A8 File Offset: 0x0019BBA8
		private ITalkOptionParamType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionParamType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionParamType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionParamType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x0019D9E0 File Offset: 0x0019BBE0
		public static ITalkOptionParamType Create([Nullable(2)] ITalkOptionParamType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x0019D9F3 File Offset: 0x0019BBF3
		public static ITalkOptionParamType CreateFromSetValue([Nullable(2)] ITalkOptionParamType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x0019DA06 File Offset: 0x0019BC06
		public ITalkOptionParamType_SetValue ToSetValue()
		{
			return new ITalkOptionParamType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600B12A RID: 45354 RVA: 0x0019DA19 File Offset: 0x0019BC19
		// (set) Token: 0x0600B12B RID: 45355 RVA: 0x0019DA44 File Offset: 0x0019BC44
		public virtual ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B2F RID: 27439
		[Nullable(2)]
		protected ITalkOptionParamType FbInstance;

		// Token: 0x04006B30 RID: 27440
		[Nullable(2)]
		protected ITalkOptionParamType_SetValue PocoInterface;
	}
}
