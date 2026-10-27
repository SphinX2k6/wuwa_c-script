using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004299 RID: 17049
	public class IWarningPreformType_UnionUnion
	{
		// Token: 0x1700790B RID: 30987
		// (get) Token: 0x06019427 RID: 103463 RVA: 0x003A0CD1 File Offset: 0x0039EED1
		// (set) Token: 0x06019428 RID: 103464 RVA: 0x003A0CD9 File Offset: 0x0039EED9
		public IWarningPreformType_Union Type { get; set; }

		// Token: 0x1700790C RID: 30988
		// (get) Token: 0x06019429 RID: 103465 RVA: 0x003A0CE2 File Offset: 0x0039EEE2
		// (set) Token: 0x0601942A RID: 103466 RVA: 0x003A0CEA File Offset: 0x0039EEEA
		public object Value { get; set; }

		// Token: 0x0601942B RID: 103467 RVA: 0x003A0CF3 File Offset: 0x0039EEF3
		public IWarningPreformType_UnionUnion()
		{
			this.Type = IWarningPreformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601942C RID: 103468 RVA: 0x003A0D09 File Offset: 0x0039EF09
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601942D RID: 103469 RVA: 0x003A0D1B File Offset: 0x0039EF1B
		public IWarningPreformTypeT AsIWarningPreformType()
		{
			return this.As<IWarningPreformTypeT>();
		}

		// Token: 0x0601942E RID: 103470 RVA: 0x003A0D23 File Offset: 0x0039EF23
		public static IWarningPreformType_UnionUnion FromIWarningPreformType(IWarningPreformTypeT _iwarningpreformtype)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformType,
				Value = _iwarningpreformtype
			};
		}

		// Token: 0x0601942F RID: 103471 RVA: 0x003A0D38 File Offset: 0x0039EF38
		public IWarningPreformFadeInScreenT AsIWarningPreformFadeInScreen()
		{
			return this.As<IWarningPreformFadeInScreenT>();
		}

		// Token: 0x06019430 RID: 103472 RVA: 0x003A0D40 File Offset: 0x0039EF40
		public static IWarningPreformType_UnionUnion FromIWarningPreformFadeInScreen(IWarningPreformFadeInScreenT _iwarningpreformfadeinscreen)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformFadeInScreen,
				Value = _iwarningpreformfadeinscreen
			};
		}

		// Token: 0x06019431 RID: 103473 RVA: 0x003A0D55 File Offset: 0x0039EF55
		public IWarningPreformActivateStateRecordEntityT AsIWarningPreformActivateStateRecordEntity()
		{
			return this.As<IWarningPreformActivateStateRecordEntityT>();
		}

		// Token: 0x06019432 RID: 103474 RVA: 0x003A0D5D File Offset: 0x0039EF5D
		public static IWarningPreformType_UnionUnion FromIWarningPreformActivateStateRecordEntity(IWarningPreformActivateStateRecordEntityT _iwarningpreformactivatestaterecordentity)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformActivateStateRecordEntity,
				Value = _iwarningpreformactivatestaterecordentity
			};
		}

		// Token: 0x06019433 RID: 103475 RVA: 0x003A0D74 File Offset: 0x0039EF74
		public static int Pack(FlatBufferBuilder builder, IWarningPreformType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWarningPreformType_Union.IWarningPreformType:
				return IWarningPreformType.Pack(builder, _o.AsIWarningPreformType()).Value;
			case IWarningPreformType_Union.IWarningPreformFadeInScreen:
				return IWarningPreformFadeInScreen.Pack(builder, _o.AsIWarningPreformFadeInScreen()).Value;
			case IWarningPreformType_Union.IWarningPreformActivateStateRecordEntity:
				return IWarningPreformActivateStateRecordEntity.Pack(builder, _o.AsIWarningPreformActivateStateRecordEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
