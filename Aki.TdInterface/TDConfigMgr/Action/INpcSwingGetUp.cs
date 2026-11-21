using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E85 RID: 7813
	public class INpcSwingGetUp : INpcLeisureInteractType
	{
		// Token: 0x0600A617 RID: 42519 RVA: 0x0017A810 File Offset: 0x00178A10
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

		// Token: 0x0600A618 RID: 42520 RVA: 0x0017A848 File Offset: 0x00178A48
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

		// Token: 0x0600A619 RID: 42521 RVA: 0x0017A85B File Offset: 0x00178A5B
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

		// Token: 0x0600A61A RID: 42522 RVA: 0x0017A86E File Offset: 0x00178A6E
		public new INpcSwingGetUp_SetValue ToSetValue()
		{
			return new INpcSwingGetUp_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState,
				TargetNpcId = this.TargetNpcId
			};
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x0017A899 File Offset: 0x00178A99
		// (set) Token: 0x0600A61C RID: 42524 RVA: 0x0017A8C4 File Offset: 0x00178AC4
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

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x0017A8D4 File Offset: 0x00178AD4
		// (set) Token: 0x0600A61E RID: 42526 RVA: 0x0017A90E File Offset: 0x00178B0E
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

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A61F RID: 42527 RVA: 0x0017A91C File Offset: 0x00178B1C
		// (set) Token: 0x0600A620 RID: 42528 RVA: 0x0017A947 File Offset: 0x00178B47
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

		// Token: 0x04006435 RID: 25653
		[Nullable(2)]
		protected new INpcSwingGetUp FbInstance;

		// Token: 0x04006436 RID: 25654
		[Nullable(2)]
		protected new INpcSwingGetUp_SetValue PocoInterface;
	}
}
