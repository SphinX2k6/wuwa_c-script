using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F9B RID: 32667
	public class TResetPosTypeUnion
	{
		// Token: 0x1700F2DF RID: 62175
		// (get) Token: 0x0603ADB9 RID: 241081 RVA: 0x007E8CD2 File Offset: 0x007E6ED2
		// (set) Token: 0x0603ADBA RID: 241082 RVA: 0x007E8CDA File Offset: 0x007E6EDA
		public TResetPosType Type { get; set; }

		// Token: 0x1700F2E0 RID: 62176
		// (get) Token: 0x0603ADBB RID: 241083 RVA: 0x007E8CE3 File Offset: 0x007E6EE3
		// (set) Token: 0x0603ADBC RID: 241084 RVA: 0x007E8CEB File Offset: 0x007E6EEB
		public object Value { get; set; }

		// Token: 0x0603ADBD RID: 241085 RVA: 0x007E8CF4 File Offset: 0x007E6EF4
		public TResetPosTypeUnion()
		{
			this.Type = TResetPosType.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADBE RID: 241086 RVA: 0x007E8D0A File Offset: 0x007E6F0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADBF RID: 241087 RVA: 0x007E8D1C File Offset: 0x007E6F1C
		public IResetPosByPosEntityT AsIResetPosByPosEntity()
		{
			return this.As<IResetPosByPosEntityT>();
		}

		// Token: 0x0603ADC0 RID: 241088 RVA: 0x007E8D24 File Offset: 0x007E6F24
		public static TResetPosTypeUnion FromIResetPosByPosEntity(IResetPosByPosEntityT _iresetposbyposentity)
		{
			return new TResetPosTypeUnion
			{
				Type = TResetPosType.IResetPosByPosEntity,
				Value = _iresetposbyposentity
			};
		}

		// Token: 0x0603ADC1 RID: 241089 RVA: 0x007E8D39 File Offset: 0x007E6F39
		public IResetPosByResetPointT AsIResetPosByResetPoint()
		{
			return this.As<IResetPosByResetPointT>();
		}

		// Token: 0x0603ADC2 RID: 241090 RVA: 0x007E8D41 File Offset: 0x007E6F41
		public static TResetPosTypeUnion FromIResetPosByResetPoint(IResetPosByResetPointT _iresetposbyresetpoint)
		{
			return new TResetPosTypeUnion
			{
				Type = TResetPosType.IResetPosByResetPoint,
				Value = _iresetposbyresetpoint
			};
		}

		// Token: 0x0603ADC3 RID: 241091 RVA: 0x007E8D58 File Offset: 0x007E6F58
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
