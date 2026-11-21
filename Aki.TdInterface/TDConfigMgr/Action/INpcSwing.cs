using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E83 RID: 7811
	public class INpcSwing : INpcLeisureInteractType
	{
		// Token: 0x0600A605 RID: 42501 RVA: 0x0017A5D0 File Offset: 0x001787D0
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

		// Token: 0x0600A606 RID: 42502 RVA: 0x0017A608 File Offset: 0x00178808
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

		// Token: 0x0600A607 RID: 42503 RVA: 0x0017A61B File Offset: 0x0017881B
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

		// Token: 0x0600A608 RID: 42504 RVA: 0x0017A630 File Offset: 0x00178830
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

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600A609 RID: 42505 RVA: 0x0017A68A File Offset: 0x0017888A
		// (set) Token: 0x0600A60A RID: 42506 RVA: 0x0017A6B5 File Offset: 0x001788B5
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

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600A60B RID: 42507 RVA: 0x0017A6C4 File Offset: 0x001788C4
		// (set) Token: 0x0600A60C RID: 42508 RVA: 0x0017A6FE File Offset: 0x001788FE
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

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A60D RID: 42509 RVA: 0x0017A70C File Offset: 0x0017890C
		// (set) Token: 0x0600A60E RID: 42510 RVA: 0x0017A737 File Offset: 0x00178937
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

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x0017A745 File Offset: 0x00178945
		// (set) Token: 0x0600A610 RID: 42512 RVA: 0x0017A770 File Offset: 0x00178970
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

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x0017A77E File Offset: 0x0017897E
		// (set) Token: 0x0600A612 RID: 42514 RVA: 0x0017A7A9 File Offset: 0x001789A9
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

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600A613 RID: 42515 RVA: 0x0017A7B8 File Offset: 0x001789B8
		// (set) Token: 0x0600A614 RID: 42516 RVA: 0x0017A7F2 File Offset: 0x001789F2
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

		// Token: 0x0400642D RID: 25645
		[Nullable(2)]
		protected new INpcSwing FbInstance;

		// Token: 0x0400642E RID: 25646
		[Nullable(2)]
		protected new INpcSwing_SetValue PocoInterface;
	}
}
