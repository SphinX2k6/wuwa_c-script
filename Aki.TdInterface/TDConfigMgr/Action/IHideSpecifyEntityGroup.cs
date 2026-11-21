using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB6 RID: 7350
	public class IHideSpecifyEntityGroup : IHideGroupType
	{
		// Token: 0x06009C10 RID: 39952 RVA: 0x00168128 File Offset: 0x00166328
		private IHideSpecifyEntityGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideSpecifyEntityGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideSpecifyEntityGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideSpecifyEntityGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x00168160 File Offset: 0x00166360
		public static IHideSpecifyEntityGroup Create([Nullable(2)] IHideSpecifyEntityGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x00168173 File Offset: 0x00166373
		public static IHideSpecifyEntityGroup CreateFromSetValue([Nullable(2)] IHideSpecifyEntityGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x00168186 File Offset: 0x00166386
		public new IHideSpecifyEntityGroup_SetValue ToSetValue()
		{
			return new IHideSpecifyEntityGroup_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ForceClean = this.ForceClean
			};
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06009C14 RID: 39956 RVA: 0x001681B1 File Offset: 0x001663B1
		// (set) Token: 0x06009C15 RID: 39957 RVA: 0x001681DC File Offset: 0x001663DC
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009C16 RID: 39958 RVA: 0x001681EA File Offset: 0x001663EA
		// (set) Token: 0x06009C17 RID: 39959 RVA: 0x00168211 File Offset: 0x00166411
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IHideSpecifyEntityGroup_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x00168220 File Offset: 0x00166420
		// (set) Token: 0x06009C19 RID: 39961 RVA: 0x0016825A File Offset: 0x0016645A
		public virtual bool? ForceClean
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceClean;
				}
				IHideSpecifyEntityGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceClean;
			}
			set
			{
				this.GetOrCreatePoco().ForceClean = value;
			}
		}

		// Token: 0x04005F81 RID: 24449
		[Nullable(2)]
		protected new IHideSpecifyEntityGroup FbInstance;

		// Token: 0x04005F82 RID: 24450
		[Nullable(2)]
		protected new IHideSpecifyEntityGroup_SetValue PocoInterface;
	}
}
