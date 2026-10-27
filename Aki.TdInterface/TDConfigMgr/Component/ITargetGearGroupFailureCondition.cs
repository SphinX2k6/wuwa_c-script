using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074E RID: 1870
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetGearGroupFailureCondition
	{
		// Token: 0x06002865 RID: 10341 RVA: 0x0006B110 File Offset: 0x00069310
		private ITargetGearGroupFailureCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetGearGroupFailureCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetGearGroupFailureCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetGearGroupFailureCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0006B148 File Offset: 0x00069348
		public static ITargetGearGroupFailureCondition Create([Nullable(2)] ITargetGearGroupFailureCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0006B15B File Offset: 0x0006935B
		public static ITargetGearGroupFailureCondition CreateFromSetValue([Nullable(2)] ITargetGearGroupFailureCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0006B16E File Offset: 0x0006936E
		public ITargetGearGroupFailureCondition_SetValue ToSetValue()
		{
			return new ITargetGearGroupFailureCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0006B181 File Offset: 0x00069381
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x0006B1AC File Offset: 0x000693AC
		public virtual ETargetGearGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001B31 RID: 6961
		[Nullable(2)]
		protected ITargetGearGroupFailureCondition FbInstance;

		// Token: 0x04001B32 RID: 6962
		[Nullable(2)]
		protected ITargetGearGroupFailureCondition_SetValue PocoInterface;
	}
}
