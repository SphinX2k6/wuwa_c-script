using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB2 RID: 7346
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSystemBoardWithReturnType
	{
		// Token: 0x06009DB5 RID: 40373 RVA: 0x00169178 File Offset: 0x00167378
		private IOpenSystemBoardWithReturnType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSystemBoardWithReturnType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSystemBoardWithReturnType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSystemBoardWithReturnType_SetValue());
			}
			return result;
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x001691B0 File Offset: 0x001673B0
		public static IOpenSystemBoardWithReturnType Create([Nullable(2)] IOpenSystemBoardWithReturnType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x001691C3 File Offset: 0x001673C3
		public static IOpenSystemBoardWithReturnType CreateFromSetValue([Nullable(2)] IOpenSystemBoardWithReturnType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSystemBoardWithReturnType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x001691D6 File Offset: 0x001673D6
		public IOpenSystemBoardWithReturnType_SetValue ToSetValue()
		{
			return new IOpenSystemBoardWithReturnType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x001691E9 File Offset: 0x001673E9
		// (set) Token: 0x06009DBA RID: 40378 RVA: 0x00169214 File Offset: 0x00167414
		public virtual ESystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemType.Shop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F71 RID: 24433
		[Nullable(2)]
		protected IOpenSystemBoardWithReturnType FbInstance;

		// Token: 0x04005F72 RID: 24434
		[Nullable(2)]
		protected IOpenSystemBoardWithReturnType_SetValue PocoInterface;
	}
}
