using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199C RID: 6556
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableAlertAreaCondition
	{
		// Token: 0x06008C4F RID: 35919 RVA: 0x001494A0 File Offset: 0x001476A0
		private IDisableAlertAreaCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAlertAreaCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAlertAreaCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAlertAreaCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x001494D8 File Offset: 0x001476D8
		public static IDisableAlertAreaCondition Create([Nullable(2)] IDisableAlertAreaCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x001494EB File Offset: 0x001476EB
		public static IDisableAlertAreaCondition CreateFromSetValue([Nullable(2)] IDisableAlertAreaCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x001494FE File Offset: 0x001476FE
		public IDisableAlertAreaCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x00149511 File Offset: 0x00147711
		// (set) Token: 0x06008C54 RID: 35924 RVA: 0x0014953C File Offset: 0x0014773C
		public virtual EDisableAlertAreaCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400575D RID: 22365
		[Nullable(2)]
		protected IDisableAlertAreaCondition FbInstance;

		// Token: 0x0400575E RID: 22366
		[Nullable(2)]
		protected IDisableAlertAreaCondition_SetValue PocoInterface;
	}
}
