using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB5 RID: 23733
	public class TSunSpiritGearPerformConfigUnion
	{
		// Token: 0x1700B256 RID: 45654
		// (get) Token: 0x06028A19 RID: 166425 RVA: 0x005955EA File Offset: 0x005937EA
		// (set) Token: 0x06028A1A RID: 166426 RVA: 0x005955F2 File Offset: 0x005937F2
		public TSunSpiritGearPerformConfig Type { get; set; }

		// Token: 0x1700B257 RID: 45655
		// (get) Token: 0x06028A1B RID: 166427 RVA: 0x005955FB File Offset: 0x005937FB
		// (set) Token: 0x06028A1C RID: 166428 RVA: 0x00595603 File Offset: 0x00593803
		public object Value { get; set; }

		// Token: 0x06028A1D RID: 166429 RVA: 0x0059560C File Offset: 0x0059380C
		public TSunSpiritGearPerformConfigUnion()
		{
			this.Type = TSunSpiritGearPerformConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028A1E RID: 166430 RVA: 0x00595622 File Offset: 0x00593822
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A1F RID: 166431 RVA: 0x00595634 File Offset: 0x00593834
		public ISunSpiritGearPerformScaleUpT AsISunSpiritGearPerformScaleUp()
		{
			return this.As<ISunSpiritGearPerformScaleUpT>();
		}

		// Token: 0x06028A20 RID: 166432 RVA: 0x0059563C File Offset: 0x0059383C
		public static TSunSpiritGearPerformConfigUnion FromISunSpiritGearPerformScaleUp(ISunSpiritGearPerformScaleUpT _isunspiritgearperformscaleup)
		{
			return new TSunSpiritGearPerformConfigUnion
			{
				Type = TSunSpiritGearPerformConfig.ISunSpiritGearPerformScaleUp,
				Value = _isunspiritgearperformscaleup
			};
		}

		// Token: 0x06028A21 RID: 166433 RVA: 0x00595651 File Offset: 0x00593851
		public ISunSpiritGearPerformToGearRelativePosT AsISunSpiritGearPerformToGearRelativePos()
		{
			return this.As<ISunSpiritGearPerformToGearRelativePosT>();
		}

		// Token: 0x06028A22 RID: 166434 RVA: 0x00595659 File Offset: 0x00593859
		public static TSunSpiritGearPerformConfigUnion FromISunSpiritGearPerformToGearRelativePos(ISunSpiritGearPerformToGearRelativePosT _isunspiritgearperformtogearrelativepos)
		{
			return new TSunSpiritGearPerformConfigUnion
			{
				Type = TSunSpiritGearPerformConfig.ISunSpiritGearPerformToGearRelativePos,
				Value = _isunspiritgearperformtogearrelativepos
			};
		}

		// Token: 0x06028A23 RID: 166435 RVA: 0x00595670 File Offset: 0x00593870
		public static int Pack(FlatBufferBuilder builder, TSunSpiritGearPerformConfigUnion _o)
		{
			TSunSpiritGearPerformConfig type = _o.Type;
			if (type == TSunSpiritGearPerformConfig.ISunSpiritGearPerformScaleUp)
			{
				return ISunSpiritGearPerformScaleUp.Pack(builder, _o.AsISunSpiritGearPerformScaleUp()).Value;
			}
			if (type != TSunSpiritGearPerformConfig.ISunSpiritGearPerformToGearRelativePos)
			{
				return 0;
			}
			return ISunSpiritGearPerformToGearRelativePos.Pack(builder, _o.AsISunSpiritGearPerformToGearRelativePos()).Value;
		}
	}
}
