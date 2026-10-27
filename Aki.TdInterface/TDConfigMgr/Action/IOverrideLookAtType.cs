using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBC RID: 7356
	[NullableContext(1)]
	[Nullable(0)]
	public class IOverrideLookAtType
	{
		// Token: 0x06009DF1 RID: 40433 RVA: 0x001697C8 File Offset: 0x001679C8
		private IOverrideLookAtType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOverrideLookAtType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOverrideLookAtType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOverrideLookAtType_SetValue());
			}
			return result;
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x00169800 File Offset: 0x00167A00
		public static IOverrideLookAtType Create([Nullable(2)] IOverrideLookAtType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x00169813 File Offset: 0x00167A13
		public static IOverrideLookAtType CreateFromSetValue([Nullable(2)] IOverrideLookAtType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x00169826 File Offset: 0x00167A26
		public IOverrideLookAtType_SetValue ToSetValue()
		{
			return new IOverrideLookAtType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x00169839 File Offset: 0x00167A39
		// (set) Token: 0x06009DF6 RID: 40438 RVA: 0x00169864 File Offset: 0x00167A64
		public virtual EOverrideLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F8A RID: 24458
		[Nullable(2)]
		protected IOverrideLookAtType FbInstance;

		// Token: 0x04005F8B RID: 24459
		[Nullable(2)]
		protected IOverrideLookAtType_SetValue PocoInterface;
	}
}
