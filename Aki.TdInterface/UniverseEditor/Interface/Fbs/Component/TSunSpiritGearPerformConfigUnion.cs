using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E6 RID: 25318
	public class TSunSpiritGearPerformConfigUnion
	{
		// Token: 0x1700BBB0 RID: 48048
		// (get) Token: 0x0602B061 RID: 176225 RVA: 0x005DDD5E File Offset: 0x005DBF5E
		// (set) Token: 0x0602B062 RID: 176226 RVA: 0x005DDD66 File Offset: 0x005DBF66
		public TSunSpiritGearPerformConfig Type { get; set; }

		// Token: 0x1700BBB1 RID: 48049
		// (get) Token: 0x0602B063 RID: 176227 RVA: 0x005DDD6F File Offset: 0x005DBF6F
		// (set) Token: 0x0602B064 RID: 176228 RVA: 0x005DDD77 File Offset: 0x005DBF77
		public object Value { get; set; }

		// Token: 0x0602B065 RID: 176229 RVA: 0x005DDD80 File Offset: 0x005DBF80
		public TSunSpiritGearPerformConfigUnion()
		{
			this.Type = TSunSpiritGearPerformConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602B066 RID: 176230 RVA: 0x005DDD96 File Offset: 0x005DBF96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B067 RID: 176231 RVA: 0x005DDDA8 File Offset: 0x005DBFA8
		public ISunSpiritGearPerformScaleUpT AsISunSpiritGearPerformScaleUp()
		{
			return this.As<ISunSpiritGearPerformScaleUpT>();
		}

		// Token: 0x0602B068 RID: 176232 RVA: 0x005DDDB0 File Offset: 0x005DBFB0
		public static TSunSpiritGearPerformConfigUnion FromISunSpiritGearPerformScaleUp(ISunSpiritGearPerformScaleUpT _isunspiritgearperformscaleup)
		{
			return new TSunSpiritGearPerformConfigUnion
			{
				Type = TSunSpiritGearPerformConfig.ISunSpiritGearPerformScaleUp,
				Value = _isunspiritgearperformscaleup
			};
		}

		// Token: 0x0602B069 RID: 176233 RVA: 0x005DDDC5 File Offset: 0x005DBFC5
		public ISunSpiritGearPerformToGearRelativePosT AsISunSpiritGearPerformToGearRelativePos()
		{
			return this.As<ISunSpiritGearPerformToGearRelativePosT>();
		}

		// Token: 0x0602B06A RID: 176234 RVA: 0x005DDDCD File Offset: 0x005DBFCD
		public static TSunSpiritGearPerformConfigUnion FromISunSpiritGearPerformToGearRelativePos(ISunSpiritGearPerformToGearRelativePosT _isunspiritgearperformtogearrelativepos)
		{
			return new TSunSpiritGearPerformConfigUnion
			{
				Type = TSunSpiritGearPerformConfig.ISunSpiritGearPerformToGearRelativePos,
				Value = _isunspiritgearperformtogearrelativepos
			};
		}

		// Token: 0x0602B06B RID: 176235 RVA: 0x005DDDE4 File Offset: 0x005DBFE4
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
