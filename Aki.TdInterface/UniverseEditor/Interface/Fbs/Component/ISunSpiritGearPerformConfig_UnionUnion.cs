using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FF RID: 23039
	public class ISunSpiritGearPerformConfig_UnionUnion
	{
		// Token: 0x1700AD18 RID: 44312
		// (get) Token: 0x06027196 RID: 160150 RVA: 0x00560FB9 File Offset: 0x0055F1B9
		// (set) Token: 0x06027197 RID: 160151 RVA: 0x00560FC1 File Offset: 0x0055F1C1
		public ISunSpiritGearPerformConfig_Union Type { get; set; }

		// Token: 0x1700AD19 RID: 44313
		// (get) Token: 0x06027198 RID: 160152 RVA: 0x00560FCA File Offset: 0x0055F1CA
		// (set) Token: 0x06027199 RID: 160153 RVA: 0x00560FD2 File Offset: 0x0055F1D2
		public object Value { get; set; }

		// Token: 0x0602719A RID: 160154 RVA: 0x00560FDB File Offset: 0x0055F1DB
		public ISunSpiritGearPerformConfig_UnionUnion()
		{
			this.Type = ISunSpiritGearPerformConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602719B RID: 160155 RVA: 0x00560FF1 File Offset: 0x0055F1F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602719C RID: 160156 RVA: 0x00561003 File Offset: 0x0055F203
		public ISunSpiritGearPerformConfigT AsISunSpiritGearPerformConfig()
		{
			return this.As<ISunSpiritGearPerformConfigT>();
		}

		// Token: 0x0602719D RID: 160157 RVA: 0x0056100B File Offset: 0x0055F20B
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformConfig(ISunSpiritGearPerformConfigT _isunspiritgearperformconfig)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformConfig,
				Value = _isunspiritgearperformconfig
			};
		}

		// Token: 0x0602719E RID: 160158 RVA: 0x00561020 File Offset: 0x0055F220
		public ISunSpiritGearPerformToGearRelativePosT AsISunSpiritGearPerformToGearRelativePos()
		{
			return this.As<ISunSpiritGearPerformToGearRelativePosT>();
		}

		// Token: 0x0602719F RID: 160159 RVA: 0x00561028 File Offset: 0x0055F228
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformToGearRelativePos(ISunSpiritGearPerformToGearRelativePosT _isunspiritgearperformtogearrelativepos)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformToGearRelativePos,
				Value = _isunspiritgearperformtogearrelativepos
			};
		}

		// Token: 0x060271A0 RID: 160160 RVA: 0x0056103D File Offset: 0x0055F23D
		public ISunSpiritGearPerformScaleUpT AsISunSpiritGearPerformScaleUp()
		{
			return this.As<ISunSpiritGearPerformScaleUpT>();
		}

		// Token: 0x060271A1 RID: 160161 RVA: 0x00561045 File Offset: 0x0055F245
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformScaleUp(ISunSpiritGearPerformScaleUpT _isunspiritgearperformscaleup)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformScaleUp,
				Value = _isunspiritgearperformscaleup
			};
		}

		// Token: 0x060271A2 RID: 160162 RVA: 0x0056105C File Offset: 0x0055F25C
		public static int Pack(FlatBufferBuilder builder, ISunSpiritGearPerformConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformConfig:
				return ISunSpiritGearPerformConfig.Pack(builder, _o.AsISunSpiritGearPerformConfig()).Value;
			case ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformToGearRelativePos:
				return ISunSpiritGearPerformToGearRelativePos.Pack(builder, _o.AsISunSpiritGearPerformToGearRelativePos()).Value;
			case ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformScaleUp:
				return ISunSpiritGearPerformScaleUp.Pack(builder, _o.AsISunSpiritGearPerformScaleUp()).Value;
			default:
				return 0;
			}
		}
	}
}
