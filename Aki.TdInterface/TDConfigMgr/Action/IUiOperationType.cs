using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002011 RID: 8209
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IUiOperationTypeConverter))]
	public class IUiOperationType
	{
		// Token: 0x0600B484 RID: 46212 RVA: 0x001A3BE0 File Offset: 0x001A1DE0
		private IUiOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x001A3C18 File Offset: 0x001A1E18
		public static IUiOperationType Create([Nullable(2)] IUiOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x001A3C2B File Offset: 0x001A1E2B
		public static IUiOperationType CreateFromSetValue([Nullable(2)] IUiOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x001A3C3E File Offset: 0x001A1E3E
		public IUiOperationType_SetValue ToSetValue()
		{
			return new IUiOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600B488 RID: 46216 RVA: 0x001A3C51 File Offset: 0x001A1E51
		// (set) Token: 0x0600B489 RID: 46217 RVA: 0x001A3C7C File Offset: 0x001A1E7C
		public virtual EUiOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006CC6 RID: 27846
		[Nullable(2)]
		protected IUiOperationType FbInstance;

		// Token: 0x04006CC7 RID: 27847
		[Nullable(2)]
		protected IUiOperationType_SetValue PocoInterface;
	}
}
