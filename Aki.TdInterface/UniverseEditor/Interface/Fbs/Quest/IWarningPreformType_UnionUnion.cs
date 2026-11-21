using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F5 RID: 18165
	public class IWarningPreformType_UnionUnion
	{
		// Token: 0x17007F3C RID: 32572
		// (get) Token: 0x0601AB93 RID: 109459 RVA: 0x003CC3A9 File Offset: 0x003CA5A9
		// (set) Token: 0x0601AB94 RID: 109460 RVA: 0x003CC3B1 File Offset: 0x003CA5B1
		public IWarningPreformType_Union Type { get; set; }

		// Token: 0x17007F3D RID: 32573
		// (get) Token: 0x0601AB95 RID: 109461 RVA: 0x003CC3BA File Offset: 0x003CA5BA
		// (set) Token: 0x0601AB96 RID: 109462 RVA: 0x003CC3C2 File Offset: 0x003CA5C2
		public object Value { get; set; }

		// Token: 0x0601AB97 RID: 109463 RVA: 0x003CC3CB File Offset: 0x003CA5CB
		public IWarningPreformType_UnionUnion()
		{
			this.Type = IWarningPreformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AB98 RID: 109464 RVA: 0x003CC3E1 File Offset: 0x003CA5E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AB99 RID: 109465 RVA: 0x003CC3F3 File Offset: 0x003CA5F3
		public IWarningPreformTypeT AsIWarningPreformType()
		{
			return this.As<IWarningPreformTypeT>();
		}

		// Token: 0x0601AB9A RID: 109466 RVA: 0x003CC3FB File Offset: 0x003CA5FB
		public static IWarningPreformType_UnionUnion FromIWarningPreformType(IWarningPreformTypeT _iwarningpreformtype)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformType,
				Value = _iwarningpreformtype
			};
		}

		// Token: 0x0601AB9B RID: 109467 RVA: 0x003CC410 File Offset: 0x003CA610
		public IWarningPreformFadeInScreenT AsIWarningPreformFadeInScreen()
		{
			return this.As<IWarningPreformFadeInScreenT>();
		}

		// Token: 0x0601AB9C RID: 109468 RVA: 0x003CC418 File Offset: 0x003CA618
		public static IWarningPreformType_UnionUnion FromIWarningPreformFadeInScreen(IWarningPreformFadeInScreenT _iwarningpreformfadeinscreen)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformFadeInScreen,
				Value = _iwarningpreformfadeinscreen
			};
		}

		// Token: 0x0601AB9D RID: 109469 RVA: 0x003CC42D File Offset: 0x003CA62D
		public IWarningPreformActivateStateRecordEntityT AsIWarningPreformActivateStateRecordEntity()
		{
			return this.As<IWarningPreformActivateStateRecordEntityT>();
		}

		// Token: 0x0601AB9E RID: 109470 RVA: 0x003CC435 File Offset: 0x003CA635
		public static IWarningPreformType_UnionUnion FromIWarningPreformActivateStateRecordEntity(IWarningPreformActivateStateRecordEntityT _iwarningpreformactivatestaterecordentity)
		{
			return new IWarningPreformType_UnionUnion
			{
				Type = IWarningPreformType_Union.IWarningPreformActivateStateRecordEntity,
				Value = _iwarningpreformactivatestaterecordentity
			};
		}

		// Token: 0x0601AB9F RID: 109471 RVA: 0x003CC44C File Offset: 0x003CA64C
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
