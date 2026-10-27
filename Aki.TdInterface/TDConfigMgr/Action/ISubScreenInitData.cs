using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED7 RID: 7895
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenInitData
	{
		// Token: 0x0600A8F0 RID: 43248 RVA: 0x0017D32C File Offset: 0x0017B52C
		private ISubScreenInitData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenInitData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenInitData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenInitData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x0017D364 File Offset: 0x0017B564
		public static ISubScreenInitData Create([Nullable(2)] ISubScreenInitData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x0017D377 File Offset: 0x0017B577
		public static ISubScreenInitData CreateFromSetValue([Nullable(2)] ISubScreenInitData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x0017D38A File Offset: 0x0017B58A
		public ISubScreenInitData_SetValue ToSetValue()
		{
			return new ISubScreenInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x0017D3A9 File Offset: 0x0017B5A9
		// (set) Token: 0x0600A8F5 RID: 43253 RVA: 0x0017D3D4 File Offset: 0x0017B5D4
		public virtual ESubScreenInitDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitDataType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600A8F6 RID: 43254 RVA: 0x0017D3E2 File Offset: 0x0017B5E2
		// (set) Token: 0x0600A8F7 RID: 43255 RVA: 0x0017D40D File Offset: 0x0017B60D
		public virtual string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x04006496 RID: 25750
		[Nullable(2)]
		protected ISubScreenInitData FbInstance;

		// Token: 0x04006497 RID: 25751
		[Nullable(2)]
		protected ISubScreenInitData_SetValue PocoInterface;
	}
}
