using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002298 RID: 8856
	public class IVillageInfrVillageLevel : IVillageInfrBuildOption
	{
		// Token: 0x0600C0E2 RID: 49378 RVA: 0x001BC410 File Offset: 0x001BA610
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

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x001BC448 File Offset: 0x001BA648
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

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x001BC45B File Offset: 0x001BA65B
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

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x001BC46E File Offset: 0x001BA66E
		public new IVillageInfrVillageLevel_SetValue ToSetValue()
		{
			return new IVillageInfrVillageLevel_SetValue
			{
				Type = this.Type,
				Level = this.Level
			};
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0600C0E6 RID: 49382 RVA: 0x001BC48D File Offset: 0x001BA68D
		// (set) Token: 0x0600C0E7 RID: 49383 RVA: 0x001BC4B8 File Offset: 0x001BA6B8
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

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0600C0E8 RID: 49384 RVA: 0x001BC4C6 File Offset: 0x001BA6C6
		// (set) Token: 0x0600C0E9 RID: 49385 RVA: 0x001BC4F1 File Offset: 0x001BA6F1
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

		// Token: 0x04007354 RID: 29524
		[Nullable(2)]
		protected new IVillageInfrVillageLevel FbInstance;

		// Token: 0x04007355 RID: 29525
		[Nullable(2)]
		protected new IVillageInfrVillageLevel_SetValue PocoInterface;
	}
}
