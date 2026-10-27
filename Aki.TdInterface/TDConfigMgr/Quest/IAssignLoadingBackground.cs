using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ECC RID: 3788
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssignLoadingBackground : IOperation
	{
		// Token: 0x060053A2 RID: 21410 RVA: 0x000CDABC File Offset: 0x000CBCBC
		private IAssignLoadingBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssignLoadingBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssignLoadingBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssignLoadingBackground_SetValue());
			}
			return result;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x000CDAF4 File Offset: 0x000CBCF4
		public static IAssignLoadingBackground Create([Nullable(2)] IAssignLoadingBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x000CDB07 File Offset: 0x000CBD07
		public static IAssignLoadingBackground CreateFromSetValue([Nullable(2)] IAssignLoadingBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x000CDB1A File Offset: 0x000CBD1A
		public new IAssignLoadingBackground_SetValue ToSetValue()
		{
			return new IAssignLoadingBackground_SetValue
			{
				Type = this.Type,
				ImagePath = this.ImagePath
			};
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x000CDB39 File Offset: 0x000CBD39
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x000CDB64 File Offset: 0x000CBD64
		public override EOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOperation.DisableHLOD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x000CDB72 File Offset: 0x000CBD72
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x000CDB9D File Offset: 0x000CBD9D
		public virtual string ImagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImagePath;
			}
			set
			{
				this.GetOrCreatePoco().ImagePath = value;
			}
		}

		// Token: 0x040032A6 RID: 12966
		[Nullable(2)]
		protected new IAssignLoadingBackground FbInstance;

		// Token: 0x040032A7 RID: 12967
		[Nullable(2)]
		protected new IAssignLoadingBackground_SetValue PocoInterface;
	}
}
