using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000601 RID: 1537
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnVillageInfr : INpcUiInteractType
	{
		// Token: 0x06001FFA RID: 8186 RVA: 0x00059F2C File Offset: 0x0005812C
		[NullableContext(0)]
		private INpcUiInteractOnVillageInfr_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnVillageInfr 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnVillageInfr_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnVillageInfr_SetValue());
			}
			return result;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00059F64 File Offset: 0x00058164
		[NullableContext(0)]
		public static INpcUiInteractOnVillageInfr Create([Nullable(2)] INpcUiInteractOnVillageInfr instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnVillageInfr
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00059F77 File Offset: 0x00058177
		[NullableContext(0)]
		public static INpcUiInteractOnVillageInfr CreateFromSetValue([Nullable(2)] INpcUiInteractOnVillageInfr_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnVillageInfr
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00059F8C File Offset: 0x0005818C
		[NullableContext(0)]
		public new INpcUiInteractOnVillageInfr_SetValue ToSetValue()
		{
			return new INpcUiInteractOnVillageInfr_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				DeliverSuccessMontage = this.DeliverSuccessMontage,
				CompleteMontage = this.CompleteMontage,
				EnterFlow = this.EnterFlow,
				DeliverSuccessFlow = this.DeliverSuccessFlow,
				CompleteFlow = this.CompleteFlow
			};
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00059FF2 File Offset: 0x000581F2
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0005A01D File Offset: 0x0005821D
		public override ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0005A02B File Offset: 0x0005822B
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x0005A052 File Offset: 0x00058252
		public virtual IMontageConfig EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnterMontage;
			}
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0005A060 File Offset: 0x00058260
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x0005A087 File Offset: 0x00058287
		public virtual IMontageConfig DeliverSuccessMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeliverSuccessMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DeliverSuccessMontage;
			}
			set
			{
				this.GetOrCreatePoco().DeliverSuccessMontage = value;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0005A095 File Offset: 0x00058295
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0005A0BC File Offset: 0x000582BC
		public virtual IMontageConfig CompleteMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteMontage;
				}
				INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CompleteMontage;
			}
			set
			{
				this.GetOrCreatePoco().CompleteMontage = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0005A0CC File Offset: 0x000582CC
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0005A12D File Offset: 0x0005832D
		public virtual PlayFlow EnterFlow
		{
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				if (this.FbInstance != null)
				{
					this._EnterFlowCache = PlayFlow.Create(this.FbInstance.EnterFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._EnterFlowCache = ((pocoInterface != null) ? pocoInterface.EnterFlow : null);
				}
				return this._EnterFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().EnterFlow = value;
				this._EnterFlowInited = false;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0005A144 File Offset: 0x00058344
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0005A1A5 File Offset: 0x000583A5
		public virtual PlayFlow DeliverSuccessFlow
		{
			get
			{
				if (this._DeliverSuccessFlowInited)
				{
					return this._DeliverSuccessFlowCache;
				}
				this._DeliverSuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._DeliverSuccessFlowCache = PlayFlow.Create(this.FbInstance.DeliverSuccessFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._DeliverSuccessFlowCache = ((pocoInterface != null) ? pocoInterface.DeliverSuccessFlow : null);
				}
				return this._DeliverSuccessFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().DeliverSuccessFlow = value;
				this._DeliverSuccessFlowInited = false;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0005A1BC File Offset: 0x000583BC
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0005A21D File Offset: 0x0005841D
		public virtual PlayFlow CompleteFlow
		{
			get
			{
				if (this._CompleteFlowInited)
				{
					return this._CompleteFlowCache;
				}
				this._CompleteFlowInited = true;
				if (this.FbInstance != null)
				{
					this._CompleteFlowCache = PlayFlow.Create(this.FbInstance.CompleteFlow);
				}
				else
				{
					INpcUiInteractOnVillageInfr_SetValue pocoInterface = this.PocoInterface;
					this._CompleteFlowCache = ((pocoInterface != null) ? pocoInterface.CompleteFlow : null);
				}
				return this._CompleteFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().CompleteFlow = value;
				this._CompleteFlowInited = false;
			}
		}

		// Token: 0x040016CD RID: 5837
		protected new INpcUiInteractOnVillageInfr FbInstance;

		// Token: 0x040016CE RID: 5838
		protected new INpcUiInteractOnVillageInfr_SetValue PocoInterface;

		// Token: 0x040016CF RID: 5839
		[Nullable(0)]
		private PlayFlow _EnterFlowCache;

		// Token: 0x040016D0 RID: 5840
		private bool _EnterFlowInited;

		// Token: 0x040016D1 RID: 5841
		[Nullable(0)]
		private PlayFlow _DeliverSuccessFlowCache;

		// Token: 0x040016D2 RID: 5842
		private bool _DeliverSuccessFlowInited;

		// Token: 0x040016D3 RID: 5843
		[Nullable(0)]
		private PlayFlow _CompleteFlowCache;

		// Token: 0x040016D4 RID: 5844
		private bool _CompleteFlowInited;
	}
}
