using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC9 RID: 8137
	[JsonConverter(typeof(IResetPosTypeConverter))]
	public class IResetPosType
	{
		// Token: 0x0600ACE7 RID: 44263 RVA: 0x001869C8 File Offset: 0x00184BC8
		private IResetPosType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPosType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPosType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPosType_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x00186A00 File Offset: 0x00184C00
		public static IResetPosType Create([Nullable(2)] IResetPosType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x00186A13 File Offset: 0x00184C13
		public static IResetPosType CreateFromSetValue([Nullable(2)] IResetPosType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPosType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x00186A26 File Offset: 0x00184C26
		public IResetPosType_SetValue ToSetValue()
		{
			return new IResetPosType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600ACEB RID: 44267 RVA: 0x00186A39 File Offset: 0x00184C39
		// (set) Token: 0x0600ACEC RID: 44268 RVA: 0x00186A64 File Offset: 0x00184C64
		public virtual EResetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPosType.PosEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006749 RID: 26441
		[Nullable(2)]
		protected IResetPosType FbInstance;

		// Token: 0x0400674A RID: 26442
		[Nullable(2)]
		protected IResetPosType_SetValue PocoInterface;
	}
}
