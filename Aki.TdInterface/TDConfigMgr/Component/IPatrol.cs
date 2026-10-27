using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E0 RID: 1504
	[NullableContext(2)]
	[Nullable(0)]
	public class IPatrol : IComponentBase
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x00058FF0 File Offset: 0x000571F0
		[NullableContext(1)]
		private IPatrol_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrol 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrol_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrol_SetValue());
			}
			return result;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00059028 File Offset: 0x00057228
		[NullableContext(1)]
		public static IPatrol Create([Nullable(2)] IPatrol instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrol
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0005903B File Offset: 0x0005723B
		[NullableContext(1)]
		public static IPatrol CreateFromSetValue([Nullable(2)] IPatrol_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrol
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00059050 File Offset: 0x00057250
		[NullableContext(1)]
		public new IPatrol_SetValue ToSetValue()
		{
			return new IPatrol_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SplineEntityId = this.SplineEntityId,
				SplineEntityIds = this.SplineEntityIds,
				IsCircle = this.IsCircle,
				Actions = this.Actions
			};
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x000590AC File Offset: 0x000572AC
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x000590E6 File Offset: 0x000572E6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000590F4 File Offset: 0x000572F4
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0005911E File Offset: 0x0005731E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0005912C File Offset: 0x0005732C
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x00059157 File Offset: 0x00057357
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00059165 File Offset: 0x00057365
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0005918C File Offset: 0x0005738C
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityIds;
				}
				IPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityIds = value;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0005919A File Offset: 0x0005739A
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x000591C5 File Offset: 0x000573C5
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000591D4 File Offset: 0x000573D4
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00059267 File Offset: 0x00057467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPatrolAction> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IPatrolAction> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<IPatrolAction>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(IPatrolAction.Create(actions[i]));
						}
					}
				}
				else
				{
					IPatrol_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001669 RID: 5737
		protected new IPatrol FbInstance;

		// Token: 0x0400166A RID: 5738
		protected new IPatrol_SetValue PocoInterface;

		// Token: 0x0400166B RID: 5739
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPatrolAction> _ActionsCache;

		// Token: 0x0400166C RID: 5740
		private bool _ActionsInited;
	}
}
