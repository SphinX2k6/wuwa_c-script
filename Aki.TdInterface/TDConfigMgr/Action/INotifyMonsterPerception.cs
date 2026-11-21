using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5B RID: 7771
	public class INotifyMonsterPerception : ISendBattleStateType
	{
		// Token: 0x0600A539 RID: 42297 RVA: 0x00178F4C File Offset: 0x0017714C
		private INotifyMonsterPerception_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INotifyMonsterPerception 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INotifyMonsterPerception_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INotifyMonsterPerception_SetValue());
			}
			return result;
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x00178F84 File Offset: 0x00177184
		public static INotifyMonsterPerception Create([Nullable(2)] INotifyMonsterPerception instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INotifyMonsterPerception
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x00178F97 File Offset: 0x00177197
		public static INotifyMonsterPerception CreateFromSetValue([Nullable(2)] INotifyMonsterPerception_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INotifyMonsterPerception
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x00178FAA File Offset: 0x001771AA
		public new INotifyMonsterPerception_SetValue ToSetValue()
		{
			return new INotifyMonsterPerception_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				PerceptionBehaviorOption = this.PerceptionBehaviorOption
			};
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A53D RID: 42301 RVA: 0x00178FD5 File Offset: 0x001771D5
		// (set) Token: 0x0600A53E RID: 42302 RVA: 0x00179000 File Offset: 0x00177200
		public override ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A53F RID: 42303 RVA: 0x0017900E File Offset: 0x0017720E
		// (set) Token: 0x0600A540 RID: 42304 RVA: 0x00179035 File Offset: 0x00177235
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				INotifyMonsterPerception_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A541 RID: 42305 RVA: 0x00179043 File Offset: 0x00177243
		// (set) Token: 0x0600A542 RID: 42306 RVA: 0x0017906A File Offset: 0x0017726A
		public virtual IBattleStatePerceptionBehaviorType PerceptionBehaviorOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerceptionBehaviorOption;
				}
				INotifyMonsterPerception_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerceptionBehaviorOption;
			}
			set
			{
				this.GetOrCreatePoco().PerceptionBehaviorOption = value;
			}
		}

		// Token: 0x040063CF RID: 25551
		[Nullable(2)]
		protected new INotifyMonsterPerception FbInstance;

		// Token: 0x040063D0 RID: 25552
		[Nullable(2)]
		protected new INotifyMonsterPerception_SetValue PocoInterface;
	}
}
