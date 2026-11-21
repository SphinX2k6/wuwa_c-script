using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762E RID: 30254
	public class IResetPosType_UnionUnion
	{
		// Token: 0x1700DE3F RID: 56895
		// (get) Token: 0x06035155 RID: 217429 RVA: 0x00721205 File Offset: 0x0071F405
		// (set) Token: 0x06035156 RID: 217430 RVA: 0x0072120D File Offset: 0x0071F40D
		public IResetPosType_Union Type { get; set; }

		// Token: 0x1700DE40 RID: 56896
		// (get) Token: 0x06035157 RID: 217431 RVA: 0x00721216 File Offset: 0x0071F416
		// (set) Token: 0x06035158 RID: 217432 RVA: 0x0072121E File Offset: 0x0071F41E
		public object Value { get; set; }

		// Token: 0x06035159 RID: 217433 RVA: 0x00721227 File Offset: 0x0071F427
		public IResetPosType_UnionUnion()
		{
			this.Type = IResetPosType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603515A RID: 217434 RVA: 0x0072123D File Offset: 0x0071F43D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603515B RID: 217435 RVA: 0x0072124F File Offset: 0x0071F44F
		public IResetPosTypeT AsIResetPosType()
		{
			return this.As<IResetPosTypeT>();
		}

		// Token: 0x0603515C RID: 217436 RVA: 0x00721257 File Offset: 0x0071F457
		public static IResetPosType_UnionUnion FromIResetPosType(IResetPosTypeT _iresetpostype)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosType,
				Value = _iresetpostype
			};
		}

		// Token: 0x0603515D RID: 217437 RVA: 0x0072126C File Offset: 0x0071F46C
		public IResetPosByPosEntityT AsIResetPosByPosEntity()
		{
			return this.As<IResetPosByPosEntityT>();
		}

		// Token: 0x0603515E RID: 217438 RVA: 0x00721274 File Offset: 0x0071F474
		public static IResetPosType_UnionUnion FromIResetPosByPosEntity(IResetPosByPosEntityT _iresetposbyposentity)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosByPosEntity,
				Value = _iresetposbyposentity
			};
		}

		// Token: 0x0603515F RID: 217439 RVA: 0x00721289 File Offset: 0x0071F489
		public IResetPosByResetPointT AsIResetPosByResetPoint()
		{
			return this.As<IResetPosByResetPointT>();
		}

		// Token: 0x06035160 RID: 217440 RVA: 0x00721291 File Offset: 0x0071F491
		public static IResetPosType_UnionUnion FromIResetPosByResetPoint(IResetPosByResetPointT _iresetposbyresetpoint)
		{
			return new IResetPosType_UnionUnion
			{
				Type = IResetPosType_Union.IResetPosByResetPoint,
				Value = _iresetposbyresetpoint
			};
		}

		// Token: 0x06035161 RID: 217441 RVA: 0x007212A8 File Offset: 0x0071F4A8
		public static int Pack(FlatBufferBuilder builder, IResetPosType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IResetPosType_Union.IResetPosType:
				return IResetPosType.Pack(builder, _o.AsIResetPosType()).Value;
			case IResetPosType_Union.IResetPosByPosEntity:
				return IResetPosByPosEntity.Pack(builder, _o.AsIResetPosByPosEntity()).Value;
			case IResetPosType_Union.IResetPosByResetPoint:
				return IResetPosByResetPoint.Pack(builder, _o.AsIResetPosByResetPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
