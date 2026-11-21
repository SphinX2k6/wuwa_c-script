using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B81 RID: 7041
	[JsonConverter(typeof(IEnableSectionalUiConverter))]
	public class IEnableSectionalUi : IUiOperationType
	{
		// Token: 0x06009583 RID: 38275 RVA: 0x0015C774 File Offset: 0x0015A974
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

		// Token: 0x06009584 RID: 38276 RVA: 0x0015C7AC File Offset: 0x0015A9AC
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

		// Token: 0x06009585 RID: 38277 RVA: 0x0015C7BF File Offset: 0x0015A9BF
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

		// Token: 0x06009586 RID: 38278 RVA: 0x0015C7D4 File Offset: 0x0015A9D4
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

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x06009587 RID: 38279 RVA: 0x0015C8A6 File Offset: 0x0015AAA6
		// (set) Token: 0x06009588 RID: 38280 RVA: 0x0015C8D1 File Offset: 0x0015AAD1
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

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06009589 RID: 38281 RVA: 0x0015C8E0 File Offset: 0x0015AAE0
		// (set) Token: 0x0600958A RID: 38282 RVA: 0x0015C91A File Offset: 0x0015AB1A
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

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x0015C928 File Offset: 0x0015AB28
		// (set) Token: 0x0600958C RID: 38284 RVA: 0x0015C962 File Offset: 0x0015AB62
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

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x0015C970 File Offset: 0x0015AB70
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x0015C9AA File Offset: 0x0015ABAA
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

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x0015C9B8 File Offset: 0x0015ABB8
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x0015C9F2 File Offset: 0x0015ABF2
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

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x0015CA00 File Offset: 0x0015AC00
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x0015CA3A File Offset: 0x0015AC3A
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

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x0015CA48 File Offset: 0x0015AC48
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x0015CA82 File Offset: 0x0015AC82
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

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x0015CA90 File Offset: 0x0015AC90
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x0015CACA File Offset: 0x0015ACCA
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

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x0015CAD8 File Offset: 0x0015ACD8
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x0015CB12 File Offset: 0x0015AD12
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

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x0015CB20 File Offset: 0x0015AD20
		// (set) Token: 0x0600959A RID: 38298 RVA: 0x0015CB5A File Offset: 0x0015AD5A
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

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x0015CB68 File Offset: 0x0015AD68
		// (set) Token: 0x0600959C RID: 38300 RVA: 0x0015CBA2 File Offset: 0x0015ADA2
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

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x0015CBB0 File Offset: 0x0015ADB0
		// (set) Token: 0x0600959E RID: 38302 RVA: 0x0015CBEA File Offset: 0x0015ADEA
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

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600959F RID: 38303 RVA: 0x0015CBF8 File Offset: 0x0015ADF8
		// (set) Token: 0x060095A0 RID: 38304 RVA: 0x0015CC32 File Offset: 0x0015AE32
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

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x060095A1 RID: 38305 RVA: 0x0015CC40 File Offset: 0x0015AE40
		// (set) Token: 0x060095A2 RID: 38306 RVA: 0x0015CC7A File Offset: 0x0015AE7A
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

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x0015CC88 File Offset: 0x0015AE88
		// (set) Token: 0x060095A4 RID: 38308 RVA: 0x0015CCAF File Offset: 0x0015AEAF
		[Nullable(2)]
		public virtual List<EUiElement> AlwaysShowUiSections
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AlwaysShowUiSections = value;
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x060095A5 RID: 38309 RVA: 0x0015CCC0 File Offset: 0x0015AEC0
		// (set) Token: 0x060095A6 RID: 38310 RVA: 0x0015CCFA File Offset: 0x0015AEFA
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

		// Token: 0x04005C8B RID: 23691
		[Nullable(2)]
		protected new IEnableSectionalUi FbInstance;

		// Token: 0x04005C8C RID: 23692
		[Nullable(2)]
		protected new IEnableSectionalUi_SetValue PocoInterface;
	}
}
