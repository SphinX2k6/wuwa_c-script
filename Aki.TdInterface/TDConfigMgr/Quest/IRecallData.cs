using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120E RID: 4622
	public class IRecallData
	{
		// Token: 0x060067AD RID: 26541 RVA: 0x000F8D08 File Offset: 0x000F6F08
		private IRecallData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallData_SetValue());
			}
			return result;
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x000F8D40 File Offset: 0x000F6F40
		public static IRecallData Create([Nullable(2)] IRecallData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x000F8D53 File Offset: 0x000F6F53
		public static IRecallData CreateFromSetValue([Nullable(2)] IRecallData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x000F8D66 File Offset: 0x000F6F66
		public IRecallData_SetValue ToSetValue()
		{
			return new IRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x060067B1 RID: 26545 RVA: 0x000F8D85 File Offset: 0x000F6F85
		// (set) Token: 0x060067B2 RID: 26546 RVA: 0x000F8DB0 File Offset: 0x000F6FB0
		public virtual ERecallDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallDataType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x000F8DBE File Offset: 0x000F6FBE
		// (set) Token: 0x060067B4 RID: 26548 RVA: 0x000F8DE9 File Offset: 0x000F6FE9
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

		// Token: 0x04003E12 RID: 15890
		[Nullable(2)]
		protected IRecallData FbInstance;

		// Token: 0x04003E13 RID: 15891
		[Nullable(2)]
		protected IRecallData_SetValue PocoInterface;
	}
}
