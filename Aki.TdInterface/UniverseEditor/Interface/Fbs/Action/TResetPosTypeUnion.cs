using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776F RID: 30575
	public class TResetPosTypeUnion
	{
		// Token: 0x1700E68D RID: 59021
		// (get) Token: 0x06037870 RID: 227440 RVA: 0x00783C02 File Offset: 0x00781E02
		// (set) Token: 0x06037871 RID: 227441 RVA: 0x00783C0A File Offset: 0x00781E0A
		public TResetPosType Type { get; set; }

		// Token: 0x1700E68E RID: 59022
		// (get) Token: 0x06037872 RID: 227442 RVA: 0x00783C13 File Offset: 0x00781E13
		// (set) Token: 0x06037873 RID: 227443 RVA: 0x00783C1B File Offset: 0x00781E1B
		public object Value { get; set; }

		// Token: 0x06037874 RID: 227444 RVA: 0x00783C24 File Offset: 0x00781E24
		public TResetPosTypeUnion()
		{
			this.Type = TResetPosType.NONE;
			this.Value = null;
		}

		// Token: 0x06037875 RID: 227445 RVA: 0x00783C3A File Offset: 0x00781E3A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037876 RID: 227446 RVA: 0x00783C4C File Offset: 0x00781E4C
		public IResetPosByPosEntityT AsIResetPosByPosEntity()
		{
			return this.As<IResetPosByPosEntityT>();
		}

		// Token: 0x06037877 RID: 227447 RVA: 0x00783C54 File Offset: 0x00781E54
		public static TResetPosTypeUnion FromIResetPosByPosEntity(IResetPosByPosEntityT _iresetposbyposentity)
		{
			return new TResetPosTypeUnion
			{
				Type = TResetPosType.IResetPosByPosEntity,
				Value = _iresetposbyposentity
			};
		}

		// Token: 0x06037878 RID: 227448 RVA: 0x00783C69 File Offset: 0x00781E69
		public IResetPosByResetPointT AsIResetPosByResetPoint()
		{
			return this.As<IResetPosByResetPointT>();
		}

		// Token: 0x06037879 RID: 227449 RVA: 0x00783C71 File Offset: 0x00781E71
		public static TResetPosTypeUnion FromIResetPosByResetPoint(IResetPosByResetPointT _iresetposbyresetpoint)
		{
			return new TResetPosTypeUnion
			{
				Type = TResetPosType.IResetPosByResetPoint,
				Value = _iresetposbyresetpoint
			};
		}

		// Token: 0x0603787A RID: 227450 RVA: 0x00783C88 File Offset: 0x00781E88
		public static int Pack(FlatBufferBuilder builder, TResetPosTypeUnion _o)
		{
			TResetPosType type = _o.Type;
			if (type == TResetPosType.IResetPosByPosEntity)
			{
				return IResetPosByPosEntity.Pack(builder, _o.AsIResetPosByPosEntity()).Value;
			}
			if (type != TResetPosType.IResetPosByResetPoint)
			{
				return 0;
			}
			return IResetPosByResetPoint.Pack(builder, _o.AsIResetPosByResetPoint()).Value;
		}
	}
}
