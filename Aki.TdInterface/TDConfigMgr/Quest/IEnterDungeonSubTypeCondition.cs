using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001083 RID: 4227
	public class IEnterDungeonSubTypeCondition : IEnterDungeon
	{
		// Token: 0x06005D26 RID: 23846 RVA: 0x000E2404 File Offset: 0x000E0604
		private IEnterDungeonSubTypeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterDungeonSubTypeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterDungeonSubTypeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterDungeonSubTypeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x000E243C File Offset: 0x000E063C
		public static IEnterDungeonSubTypeCondition Create([Nullable(2)] IEnterDungeonSubTypeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x000E244F File Offset: 0x000E064F
		public static IEnterDungeonSubTypeCondition CreateFromSetValue([Nullable(2)] IEnterDungeonSubTypeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x000E2462 File Offset: 0x000E0662
		public new IEnterDungeonSubTypeCondition_SetValue ToSetValue()
		{
			return new IEnterDungeonSubTypeCondition_SetValue
			{
				Type = this.Type,
				DungeonSubType = this.DungeonSubType
			};
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06005D2A RID: 23850 RVA: 0x000E2481 File Offset: 0x000E0681
		// (set) Token: 0x06005D2B RID: 23851 RVA: 0x000E24AC File Offset: 0x000E06AC
		public override EDungeonConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x000E24BA File Offset: 0x000E06BA
		// (set) Token: 0x06005D2D RID: 23853 RVA: 0x000E24E5 File Offset: 0x000E06E5
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonSubType;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonSubType.Test;
				}
				return this.PocoInterface.DungeonSubType;
			}
			set
			{
				this.GetOrCreatePoco().DungeonSubType = value;
			}
		}

		// Token: 0x04003807 RID: 14343
		[Nullable(2)]
		protected new IEnterDungeonSubTypeCondition FbInstance;

		// Token: 0x04003808 RID: 14344
		[Nullable(2)]
		protected new IEnterDungeonSubTypeCondition_SetValue PocoInterface;
	}
}
