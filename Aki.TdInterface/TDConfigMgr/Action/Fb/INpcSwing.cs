using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002818 RID: 10264
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSwing : INpcLeisureInteractType
	{
		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00218C44 File Offset: 0x00216E44
		public static INpcSwing Create(INpcSwing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x00218C63 File Offset: 0x00216E63
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x0600E3B3 RID: 58291 RVA: 0x00218C70 File Offset: 0x00216E70
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x00218CA6 File Offset: 0x00216EA6
		public virtual int TargetNpcId
		{
			get
			{
				return this.Instance.TargetNpcId;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x0600E3B5 RID: 58293 RVA: 0x00218CB3 File Offset: 0x00216EB3
		public virtual string SwingDa
		{
			get
			{
				return this.Instance.SwingDa;
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x00218CC0 File Offset: 0x00216EC0
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x00218CD0 File Offset: 0x00216ED0
		public virtual bool? SkipSitDown
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SkipSitDown);
			}
		}

		// Token: 0x04007E0E RID: 32270
		private INpcSwing Instance;
	}
}
