using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E0 RID: 4320
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallData
	{
		// Token: 0x060061B4 RID: 25012 RVA: 0x000EBBE8 File Offset: 0x000E9DE8
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

		// Token: 0x060061B5 RID: 25013 RVA: 0x000EBC20 File Offset: 0x000E9E20
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

		// Token: 0x060061B6 RID: 25014 RVA: 0x000EBC33 File Offset: 0x000E9E33
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

		// Token: 0x060061B7 RID: 25015 RVA: 0x000EBC46 File Offset: 0x000E9E46
		public IRecallData_SetValue ToSetValue()
		{
			return new IRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060061B8 RID: 25016 RVA: 0x000EBC65 File Offset: 0x000E9E65
		// (set) Token: 0x060061B9 RID: 25017 RVA: 0x000EBC90 File Offset: 0x000E9E90
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

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060061BA RID: 25018 RVA: 0x000EBC9E File Offset: 0x000E9E9E
		// (set) Token: 0x060061BB RID: 25019 RVA: 0x000EBCC9 File Offset: 0x000E9EC9
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

		// Token: 0x04003AC5 RID: 15045
		[Nullable(2)]
		protected IRecallData FbInstance;

		// Token: 0x04003AC6 RID: 15046
		[Nullable(2)]
		protected IRecallData_SetValue PocoInterface;
	}
}
