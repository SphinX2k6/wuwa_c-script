using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204D RID: 8269
	[NullableContext(1)]
	[Nullable(0)]
	public class IVillageInfrTreeProcess : IVillageInfrBuildOption
	{
		// Token: 0x0600B5B2 RID: 46514 RVA: 0x001A5BA4 File Offset: 0x001A3DA4
		private IVillageInfrTreeProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVillageInfrTreeProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVillageInfrTreeProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVillageInfrTreeProcess_SetValue());
			}
			return result;
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x001A5BDC File Offset: 0x001A3DDC
		public static IVillageInfrTreeProcess Create([Nullable(2)] IVillageInfrTreeProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x001A5BEF File Offset: 0x001A3DEF
		public static IVillageInfrTreeProcess CreateFromSetValue([Nullable(2)] IVillageInfrTreeProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x001A5C02 File Offset: 0x001A3E02
		public new IVillageInfrTreeProcess_SetValue ToSetValue()
		{
			return new IVillageInfrTreeProcess_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x001A5C21 File Offset: 0x001A3E21
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x001A5C4C File Offset: 0x001A3E4C
		public override EVillageInfrBuildType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVillageInfrBuildType.Village;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x001A5C5A File Offset: 0x001A3E5A
		// (set) Token: 0x0600B5B9 RID: 46521 RVA: 0x001A5C85 File Offset: 0x001A3E85
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006D47 RID: 27975
		[Nullable(2)]
		protected new IVillageInfrTreeProcess FbInstance;

		// Token: 0x04006D48 RID: 27976
		[Nullable(2)]
		protected new IVillageInfrTreeProcess_SetValue PocoInterface;
	}
}
