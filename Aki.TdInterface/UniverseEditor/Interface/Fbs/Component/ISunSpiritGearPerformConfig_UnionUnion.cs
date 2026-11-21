using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200600C RID: 24588
	public class ISunSpiritGearPerformConfig_UnionUnion
	{
		// Token: 0x1700B650 RID: 46672
		// (get) Token: 0x0602970E RID: 169742 RVA: 0x005A7F7D File Offset: 0x005A617D
		// (set) Token: 0x0602970F RID: 169743 RVA: 0x005A7F85 File Offset: 0x005A6185
		public ISunSpiritGearPerformConfig_Union Type { get; set; }

		// Token: 0x1700B651 RID: 46673
		// (get) Token: 0x06029710 RID: 169744 RVA: 0x005A7F8E File Offset: 0x005A618E
		// (set) Token: 0x06029711 RID: 169745 RVA: 0x005A7F96 File Offset: 0x005A6196
		public object Value { get; set; }

		// Token: 0x06029712 RID: 169746 RVA: 0x005A7F9F File Offset: 0x005A619F
		public ISunSpiritGearPerformConfig_UnionUnion()
		{
			this.Type = ISunSpiritGearPerformConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029713 RID: 169747 RVA: 0x005A7FB5 File Offset: 0x005A61B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029714 RID: 169748 RVA: 0x005A7FC7 File Offset: 0x005A61C7
		public ISunSpiritGearPerformConfigT AsISunSpiritGearPerformConfig()
		{
			return this.As<ISunSpiritGearPerformConfigT>();
		}

		// Token: 0x06029715 RID: 169749 RVA: 0x005A7FCF File Offset: 0x005A61CF
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformConfig(ISunSpiritGearPerformConfigT _isunspiritgearperformconfig)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformConfig,
				Value = _isunspiritgearperformconfig
			};
		}

		// Token: 0x06029716 RID: 169750 RVA: 0x005A7FE4 File Offset: 0x005A61E4
		public ISunSpiritGearPerformToGearRelativePosT AsISunSpiritGearPerformToGearRelativePos()
		{
			return this.As<ISunSpiritGearPerformToGearRelativePosT>();
		}

		// Token: 0x06029717 RID: 169751 RVA: 0x005A7FEC File Offset: 0x005A61EC
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformToGearRelativePos(ISunSpiritGearPerformToGearRelativePosT _isunspiritgearperformtogearrelativepos)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformToGearRelativePos,
				Value = _isunspiritgearperformtogearrelativepos
			};
		}

		// Token: 0x06029718 RID: 169752 RVA: 0x005A8001 File Offset: 0x005A6201
		public ISunSpiritGearPerformScaleUpT AsISunSpiritGearPerformScaleUp()
		{
			return this.As<ISunSpiritGearPerformScaleUpT>();
		}

		// Token: 0x06029719 RID: 169753 RVA: 0x005A8009 File Offset: 0x005A6209
		public static ISunSpiritGearPerformConfig_UnionUnion FromISunSpiritGearPerformScaleUp(ISunSpiritGearPerformScaleUpT _isunspiritgearperformscaleup)
		{
			return new ISunSpiritGearPerformConfig_UnionUnion
			{
				Type = ISunSpiritGearPerformConfig_Union.ISunSpiritGearPerformScaleUp,
				Value = _isunspiritgearperformscaleup
			};
		}

		// Token: 0x0602971A RID: 169754 RVA: 0x005A8020 File Offset: 0x005A6220
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
