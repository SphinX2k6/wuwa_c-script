using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019EE RID: 6638
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableSectionalUiConverter))]
	public class IEnableSectionalUi : IUiOperationType
	{
		// Token: 0x06008E21 RID: 36385 RVA: 0x0014C904 File Offset: 0x0014AB04
		[NullableContext(1)]
		private IEnableSectionalUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSectionalUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSectionalUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSectionalUi_SetValue());
			}
			return result;
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x0014C93C File Offset: 0x0014AB3C
		[NullableContext(1)]
		public static IEnableSectionalUi Create([Nullable(2)] IEnableSectionalUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSectionalUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x0014C94F File Offset: 0x0014AB4F
		[NullableContext(1)]
		public static IEnableSectionalUi CreateFromSetValue([Nullable(2)] IEnableSectionalUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSectionalUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x0014C964 File Offset: 0x0014AB64
		[NullableContext(1)]
		public new IEnableSectionalUi_SetValue ToSetValue()
		{
			return new IEnableSectionalUi_SetValue
			{
				Type = this.Type,
				ShowMiniMap = this.ShowMiniMap,
				ShowQuestTrack = this.ShowQuestTrack,
				ShowEsc = this.ShowEsc,
				ShowSystem = this.ShowSystem,
				ShowScreenEffect = this.ShowScreenEffect,
				ShowRoleFormation = this.ShowRoleFormation,
				ShowRoleStatus = this.ShowRoleStatus,
				ShowBossStatus = this.ShowBossStatus,
				ShowGuideLayer = this.ShowGuideLayer,
				ShowMonsterHpBar = this.ShowMonsterHpBar,
				ShowDamageText = this.ShowDamageText,
				ShowPing = this.ShowPing,
				ShowOther = this.ShowOther,
				AlwaysShowUiSections = this.AlwaysShowUiSections,
				ShowPositionOfficial = this.ShowPositionOfficial
			};
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06008E25 RID: 36389 RVA: 0x0014CA36 File Offset: 0x0014AC36
		// (set) Token: 0x06008E26 RID: 36390 RVA: 0x0014CA61 File Offset: 0x0014AC61
		public override EUiOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x0014CA70 File Offset: 0x0014AC70
		// (set) Token: 0x06008E28 RID: 36392 RVA: 0x0014CAAA File Offset: 0x0014ACAA
		public virtual bool? ShowMiniMap
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowMiniMap;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowMiniMap;
			}
			set
			{
				this.GetOrCreatePoco().ShowMiniMap = value;
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x06008E29 RID: 36393 RVA: 0x0014CAB8 File Offset: 0x0014ACB8
		// (set) Token: 0x06008E2A RID: 36394 RVA: 0x0014CAF2 File Offset: 0x0014ACF2
		public virtual bool? ShowQuestTrack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowQuestTrack;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowQuestTrack;
			}
			set
			{
				this.GetOrCreatePoco().ShowQuestTrack = value;
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x0014CB00 File Offset: 0x0014AD00
		// (set) Token: 0x06008E2C RID: 36396 RVA: 0x0014CB3A File Offset: 0x0014AD3A
		public virtual bool? ShowEsc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowEsc;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowEsc;
			}
			set
			{
				this.GetOrCreatePoco().ShowEsc = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x0014CB48 File Offset: 0x0014AD48
		// (set) Token: 0x06008E2E RID: 36398 RVA: 0x0014CB82 File Offset: 0x0014AD82
		public virtual bool? ShowSystem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowSystem;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowSystem;
			}
			set
			{
				this.GetOrCreatePoco().ShowSystem = value;
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x06008E2F RID: 36399 RVA: 0x0014CB90 File Offset: 0x0014AD90
		// (set) Token: 0x06008E30 RID: 36400 RVA: 0x0014CBCA File Offset: 0x0014ADCA
		public virtual bool? ShowScreenEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowScreenEffect;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowScreenEffect;
			}
			set
			{
				this.GetOrCreatePoco().ShowScreenEffect = value;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x06008E31 RID: 36401 RVA: 0x0014CBD8 File Offset: 0x0014ADD8
		// (set) Token: 0x06008E32 RID: 36402 RVA: 0x0014CC12 File Offset: 0x0014AE12
		public virtual bool? ShowRoleFormation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowRoleFormation;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowRoleFormation;
			}
			set
			{
				this.GetOrCreatePoco().ShowRoleFormation = value;
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x0014CC20 File Offset: 0x0014AE20
		// (set) Token: 0x06008E34 RID: 36404 RVA: 0x0014CC5A File Offset: 0x0014AE5A
		public virtual bool? ShowRoleStatus
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowRoleStatus;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowRoleStatus;
			}
			set
			{
				this.GetOrCreatePoco().ShowRoleStatus = value;
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06008E35 RID: 36405 RVA: 0x0014CC68 File Offset: 0x0014AE68
		// (set) Token: 0x06008E36 RID: 36406 RVA: 0x0014CCA2 File Offset: 0x0014AEA2
		public virtual bool? ShowBossStatus
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowBossStatus;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowBossStatus;
			}
			set
			{
				this.GetOrCreatePoco().ShowBossStatus = value;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x0014CCB0 File Offset: 0x0014AEB0
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x0014CCEA File Offset: 0x0014AEEA
		public virtual bool? ShowGuideLayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowGuideLayer;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowGuideLayer;
			}
			set
			{
				this.GetOrCreatePoco().ShowGuideLayer = value;
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x0014CCF8 File Offset: 0x0014AEF8
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x0014CD32 File Offset: 0x0014AF32
		public virtual bool? ShowMonsterHpBar
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowMonsterHpBar;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowMonsterHpBar;
			}
			set
			{
				this.GetOrCreatePoco().ShowMonsterHpBar = value;
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x0014CD40 File Offset: 0x0014AF40
		// (set) Token: 0x06008E3C RID: 36412 RVA: 0x0014CD7A File Offset: 0x0014AF7A
		public virtual bool? ShowDamageText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowDamageText;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowDamageText;
			}
			set
			{
				this.GetOrCreatePoco().ShowDamageText = value;
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x06008E3D RID: 36413 RVA: 0x0014CD88 File Offset: 0x0014AF88
		// (set) Token: 0x06008E3E RID: 36414 RVA: 0x0014CDC2 File Offset: 0x0014AFC2
		public virtual bool? ShowPing
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowPing;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowPing;
			}
			set
			{
				this.GetOrCreatePoco().ShowPing = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x0014CDD0 File Offset: 0x0014AFD0
		// (set) Token: 0x06008E40 RID: 36416 RVA: 0x0014CE0A File Offset: 0x0014B00A
		public virtual bool? ShowOther
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowOther;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowOther;
			}
			set
			{
				this.GetOrCreatePoco().ShowOther = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x0014CE18 File Offset: 0x0014B018
		// (set) Token: 0x06008E42 RID: 36418 RVA: 0x0014CE3F File Offset: 0x0014B03F
		public virtual List<EUiElement> AlwaysShowUiSections
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AlwaysShowUiSections;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AlwaysShowUiSections;
			}
			set
			{
				this.GetOrCreatePoco().AlwaysShowUiSections = value;
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x0014CE50 File Offset: 0x0014B050
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x0014CE8A File Offset: 0x0014B08A
		public virtual bool? ShowPositionOfficial
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowPositionOfficial;
				}
				IEnableSectionalUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowPositionOfficial;
			}
			set
			{
				this.GetOrCreatePoco().ShowPositionOfficial = value;
			}
		}

		// Token: 0x04005829 RID: 22569
		protected new IEnableSectionalUi FbInstance;

		// Token: 0x0400582A RID: 22570
		protected new IEnableSectionalUi_SetValue PocoInterface;
	}
}
