using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C80 RID: 7296
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSwingGetUp : INpcLeisureInteractType
	{
		// Token: 0x06009C7D RID: 40061 RVA: 0x00166E1C File Offset: 0x0016501C
		private INpcSwingGetUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSwingGetUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSwingGetUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSwingGetUp_SetValue());
			}
			return result;
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x00166E54 File Offset: 0x00165054
		public static INpcSwingGetUp Create([Nullable(2)] INpcSwingGetUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwingGetUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x00166E67 File Offset: 0x00165067
		public static INpcSwingGetUp CreateFromSetValue([Nullable(2)] INpcSwingGetUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSwingGetUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x00166E7A File Offset: 0x0016507A
		public new INpcSwingGetUp_SetValue ToSetValue()
		{
			return new INpcSwingGetUp_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState,
				TargetNpcId = this.TargetNpcId
			};
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x00166EA5 File Offset: 0x001650A5
		// (set) Token: 0x06009C82 RID: 40066 RVA: 0x00166ED0 File Offset: 0x001650D0
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

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x00166EE0 File Offset: 0x001650E0
		// (set) Token: 0x06009C84 RID: 40068 RVA: 0x00166F1A File Offset: 0x0016511A
		public override bool? KeepState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepState;
				}
				INpcSwingGetUp_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009C85 RID: 40069 RVA: 0x00166F28 File Offset: 0x00165128
		// (set) Token: 0x06009C86 RID: 40070 RVA: 0x00166F53 File Offset: 0x00165153
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

		// Token: 0x04005EE2 RID: 24290
		[Nullable(2)]
		protected new INpcSwingGetUp FbInstance;

		// Token: 0x04005EE3 RID: 24291
		[Nullable(2)]
		protected new INpcSwingGetUp_SetValue PocoInterface;
	}
}
