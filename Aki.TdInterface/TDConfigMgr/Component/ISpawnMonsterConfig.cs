using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E6 RID: 1766
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterConfig
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x00066148 File Offset: 0x00064348
		private ISpawnMonsterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00066180 File Offset: 0x00064380
		public static ISpawnMonsterConfig Create([Nullable(2)] ISpawnMonsterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00066193 File Offset: 0x00064393
		public static ISpawnMonsterConfig CreateFromSetValue([Nullable(2)] ISpawnMonsterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000661A8 File Offset: 0x000643A8
		public ISpawnMonsterConfig_SetValue ToSetValue()
		{
			return new ISpawnMonsterConfig_SetValue
			{
				Id = this.Id,
				DelayTime = this.DelayTime,
				TargetsToAwake = this.TargetsToAwake,
				CompleteCondition = this.CompleteCondition,
				PreCondition = this.PreCondition
			};
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000661F6 File Offset: 0x000643F6
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x00066221 File Offset: 0x00064421
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x0006622F File Offset: 0x0006442F
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0006625E File Offset: 0x0006445E
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x0006626C File Offset: 0x0006446C
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x00066293 File Offset: 0x00064493
		[Nullable(2)]
		public virtual List<int> TargetsToAwake
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetsToAwake;
				}
				ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetsToAwake;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetsToAwake = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000662A1 File Offset: 0x000644A1
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x000662C8 File Offset: 0x000644C8
		public virtual ISpawnMonsterCompleteCondition CompleteCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteCondition;
				}
				ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CompleteCondition;
			}
			set
			{
				this.GetOrCreatePoco().CompleteCondition = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000662D8 File Offset: 0x000644D8
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x00066339 File Offset: 0x00064539
		public virtual ISpawnMonsterPreDependOnPreceding PreCondition
		{
			get
			{
				if (this._PreConditionInited)
				{
					return this._PreConditionCache;
				}
				this._PreConditionInited = true;
				if (this.FbInstance != null)
				{
					this._PreConditionCache = ISpawnMonsterPreDependOnPreceding.Create(this.FbInstance.PreCondition);
				}
				else
				{
					ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
					this._PreConditionCache = ((pocoInterface != null) ? pocoInterface.PreCondition : null);
				}
				return this._PreConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().PreCondition = value;
				this._PreConditionInited = false;
			}
		}

		// Token: 0x040019E2 RID: 6626
		[Nullable(2)]
		protected ISpawnMonsterConfig FbInstance;

		// Token: 0x040019E3 RID: 6627
		[Nullable(2)]
		protected ISpawnMonsterConfig_SetValue PocoInterface;

		// Token: 0x040019E4 RID: 6628
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x040019E5 RID: 6629
		private bool _PreConditionInited;
	}
}
