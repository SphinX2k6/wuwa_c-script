using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204F RID: 8271
	[NullableContext(1)]
	[Nullable(0)]
	public class IVillageInfrVillageLevel : IVillageInfrBuildOption
	{
		// Token: 0x0600B5BC RID: 46524 RVA: 0x001A5CA4 File Offset: 0x001A3EA4
		private IVillageInfrVillageLevel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVillageInfrVillageLevel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVillageInfrVillageLevel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVillageInfrVillageLevel_SetValue());
			}
			return result;
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x001A5CDC File Offset: 0x001A3EDC
		public static IVillageInfrVillageLevel Create([Nullable(2)] IVillageInfrVillageLevel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrVillageLevel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x001A5CEF File Offset: 0x001A3EEF
		public static IVillageInfrVillageLevel CreateFromSetValue([Nullable(2)] IVillageInfrVillageLevel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVillageInfrVillageLevel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x001A5D02 File Offset: 0x001A3F02
		public new IVillageInfrVillageLevel_SetValue ToSetValue()
		{
			return new IVillageInfrVillageLevel_SetValue
			{
				Type = this.Type,
				Level = this.Level
			};
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x001A5D21 File Offset: 0x001A3F21
		// (set) Token: 0x0600B5C1 RID: 46529 RVA: 0x001A5D4C File Offset: 0x001A3F4C
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

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B5C2 RID: 46530 RVA: 0x001A5D5A File Offset: 0x001A3F5A
		// (set) Token: 0x0600B5C3 RID: 46531 RVA: 0x001A5D85 File Offset: 0x001A3F85
		public virtual int Level
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Level;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Level;
			}
			set
			{
				this.GetOrCreatePoco().Level = value;
			}
		}

		// Token: 0x04006D4B RID: 27979
		[Nullable(2)]
		protected new IVillageInfrVillageLevel FbInstance;

		// Token: 0x04006D4C RID: 27980
		[Nullable(2)]
		protected new IVillageInfrVillageLevel_SetValue PocoInterface;
	}
}
