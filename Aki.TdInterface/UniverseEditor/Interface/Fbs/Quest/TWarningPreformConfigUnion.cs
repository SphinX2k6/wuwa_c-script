using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200479B RID: 18331
	public class TWarningPreformConfigUnion
	{
		// Token: 0x17007FBD RID: 32701
		// (get) Token: 0x0601AFC9 RID: 110537 RVA: 0x003D3130 File Offset: 0x003D1330
		// (set) Token: 0x0601AFCA RID: 110538 RVA: 0x003D3138 File Offset: 0x003D1338
		public TWarningPreformConfig Type { get; set; }

		// Token: 0x17007FBE RID: 32702
		// (get) Token: 0x0601AFCB RID: 110539 RVA: 0x003D3141 File Offset: 0x003D1341
		// (set) Token: 0x0601AFCC RID: 110540 RVA: 0x003D3149 File Offset: 0x003D1349
		public object Value { get; set; }

		// Token: 0x0601AFCD RID: 110541 RVA: 0x003D3152 File Offset: 0x003D1352
		public TWarningPreformConfigUnion()
		{
			this.Type = TWarningPreformConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601AFCE RID: 110542 RVA: 0x003D3168 File Offset: 0x003D1368
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AFCF RID: 110543 RVA: 0x003D317A File Offset: 0x003D137A
		public IWarningPreformActivateStateRecordEntityT AsIWarningPreformActivateStateRecordEntity()
		{
			return this.As<IWarningPreformActivateStateRecordEntityT>();
		}

		// Token: 0x0601AFD0 RID: 110544 RVA: 0x003D3182 File Offset: 0x003D1382
		public static TWarningPreformConfigUnion FromIWarningPreformActivateStateRecordEntity(IWarningPreformActivateStateRecordEntityT _iwarningpreformactivatestaterecordentity)
		{
			return new TWarningPreformConfigUnion
			{
				Type = TWarningPreformConfig.IWarningPreformActivateStateRecordEntity,
				Value = _iwarningpreformactivatestaterecordentity
			};
		}

		// Token: 0x0601AFD1 RID: 110545 RVA: 0x003D3197 File Offset: 0x003D1397
		public IWarningPreformFadeInScreenT AsIWarningPreformFadeInScreen()
		{
			return this.As<IWarningPreformFadeInScreenT>();
		}

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x003D319F File Offset: 0x003D139F
		public static TWarningPreformConfigUnion FromIWarningPreformFadeInScreen(IWarningPreformFadeInScreenT _iwarningpreformfadeinscreen)
		{
			return new TWarningPreformConfigUnion
			{
				Type = TWarningPreformConfig.IWarningPreformFadeInScreen,
				Value = _iwarningpreformfadeinscreen
			};
		}

		// Token: 0x0601AFD3 RID: 110547 RVA: 0x003D31B4 File Offset: 0x003D13B4
		public static int Pack(FlatBufferBuilder builder, TWarningPreformConfigUnion _o)
		{
			TWarningPreformConfig type = _o.Type;
			if (type == TWarningPreformConfig.IWarningPreformActivateStateRecordEntity)
			{
				return IWarningPreformActivateStateRecordEntity.Pack(builder, _o.AsIWarningPreformActivateStateRecordEntity()).Value;
			}
			if (type != TWarningPreformConfig.IWarningPreformFadeInScreen)
			{
				return 0;
			}
			return IWarningPreformFadeInScreen.Pack(builder, _o.AsIWarningPreformFadeInScreen()).Value;
		}
	}
}
