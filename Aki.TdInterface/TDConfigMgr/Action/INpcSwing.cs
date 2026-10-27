using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7E RID: 7294
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSwing : INpcLeisureInteractType
	{
		// Token: 0x06009C6B RID: 40043 RVA: 0x00166BDC File Offset: 0x00164DDC
		private INpcSwing_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSwing 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSwing_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSwing_SetValue());
			}
			return result;
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x00166C14 File Offset: 0x00164E14
		public static INpcSwing Create([Nullable(2)] INpcSwing instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwing
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x00166C27 File Offset: 0x00164E27
		public static INpcSwing CreateFromSetValue([Nullable(2)] INpcSwing_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSwing
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x00166C3C File Offset: 0x00164E3C
		public new INpcSwing_SetValue ToSetValue()
		{
			return new INpcSwing_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState,
				TargetNpcId = this.TargetNpcId,
				SwingDa = this.SwingDa,
				EntityId = this.EntityId,
				SkipSitDown = this.SkipSitDown
			};
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009C6F RID: 40047 RVA: 0x00166C96 File Offset: 0x00164E96
		// (set) Token: 0x06009C70 RID: 40048 RVA: 0x00166CC1 File Offset: 0x00164EC1
		public override ENpcLeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009C71 RID: 40049 RVA: 0x00166CD0 File Offset: 0x00164ED0
		// (set) Token: 0x06009C72 RID: 40050 RVA: 0x00166D0A File Offset: 0x00164F0A
		public override bool? KeepState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepState;
				}
				INpcSwing_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepState;
			}
			set
			{
				this.GetOrCreatePoco().KeepState = value;
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009C73 RID: 40051 RVA: 0x00166D18 File Offset: 0x00164F18
		// (set) Token: 0x06009C74 RID: 40052 RVA: 0x00166D43 File Offset: 0x00164F43
		public virtual int TargetNpcId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetNpcId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetNpcId;
			}
			set
			{
				this.GetOrCreatePoco().TargetNpcId = value;
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009C75 RID: 40053 RVA: 0x00166D51 File Offset: 0x00164F51
		// (set) Token: 0x06009C76 RID: 40054 RVA: 0x00166D7C File Offset: 0x00164F7C
		public virtual string SwingDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwingDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SwingDa;
			}
			set
			{
				this.GetOrCreatePoco().SwingDa = value;
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009C77 RID: 40055 RVA: 0x00166D8A File Offset: 0x00164F8A
		// (set) Token: 0x06009C78 RID: 40056 RVA: 0x00166DB5 File Offset: 0x00164FB5
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009C79 RID: 40057 RVA: 0x00166DC4 File Offset: 0x00164FC4
		// (set) Token: 0x06009C7A RID: 40058 RVA: 0x00166DFE File Offset: 0x00164FFE
		public virtual bool? SkipSitDown
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkipSitDown;
				}
				INpcSwing_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkipSitDown;
			}
			set
			{
				this.GetOrCreatePoco().SkipSitDown = value;
			}
		}

		// Token: 0x04005EDA RID: 24282
		[Nullable(2)]
		protected new INpcSwing FbInstance;

		// Token: 0x04005EDB RID: 24283
		[Nullable(2)]
		protected new INpcSwing_SetValue PocoInterface;
	}
}
