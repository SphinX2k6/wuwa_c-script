using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001814 RID: 6164
	[NullableContext(1)]
	[Nullable(0)]
	public class IBpActorFuncTypeBase
	{
		// Token: 0x0600844F RID: 33871 RVA: 0x0013B470 File Offset: 0x00139670
		private IBpActorFuncTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBpActorFuncTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBpActorFuncTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBpActorFuncTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x0013B4A8 File Offset: 0x001396A8
		public static IBpActorFuncTypeBase Create([Nullable(2)] IBpActorFuncTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBpActorFuncTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008451 RID: 33873 RVA: 0x0013B4BB File Offset: 0x001396BB
		public static IBpActorFuncTypeBase CreateFromSetValue([Nullable(2)] IBpActorFuncTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBpActorFuncTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x0013B4CE File Offset: 0x001396CE
		public IBpActorFuncTypeBase_SetValue ToSetValue()
		{
			return new IBpActorFuncTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x0013B4E1 File Offset: 0x001396E1
		// (set) Token: 0x06008454 RID: 33876 RVA: 0x0013B50C File Offset: 0x0013970C
		public virtual EBpActorFuncType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBpActorFuncType.CarPaintChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040053C1 RID: 21441
		[Nullable(2)]
		protected IBpActorFuncTypeBase FbInstance;

		// Token: 0x040053C2 RID: 21442
		[Nullable(2)]
		protected IBpActorFuncTypeBase_SetValue PocoInterface;
	}
}
