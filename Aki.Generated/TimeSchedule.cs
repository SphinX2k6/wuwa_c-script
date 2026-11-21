using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001265 RID: 4709
	public struct TimeSchedule : IFlatbufferObject
	{
		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600EC5A RID: 60506 RVA: 0x00359761 File Offset: 0x00357961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC5B RID: 60507 RVA: 0x0035976E File Offset: 0x0035796E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC5C RID: 60508 RVA: 0x00359778 File Offset: 0x00357978
		public static TimeSchedule GetRootAsTimeSchedule(ByteBuffer _bb)
		{
			return TimeSchedule.GetRootAsTimeSchedule(_bb, default(TimeSchedule));
		}

		// Token: 0x0600EC5D RID: 60509 RVA: 0x00359794 File Offset: 0x00357994
		public static TimeSchedule GetRootAsTimeSchedule(ByteBuffer _bb, TimeSchedule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x003597B1 File Offset: 0x003579B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC5F RID: 60511 RVA: 0x003597C0 File Offset: 0x003579C0
		public TimeSchedule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600EC60 RID: 60512 RVA: 0x003597D0 File Offset: 0x003579D0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600EC61 RID: 60513 RVA: 0x0035980C File Offset: 0x00357A0C
		public string TimeScheduleTag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x00359843 File Offset: 0x00357A43
		public Span<byte> GetTimeScheduleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x00359852 File Offset: 0x00357A52
		public byte[] GetTimeScheduleTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600EC64 RID: 60516 RVA: 0x0035986C File Offset: 0x00357A6C
		public string StartTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EC65 RID: 60517 RVA: 0x003598A3 File Offset: 0x00357AA3
		public Span<byte> GetStartTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x003598B2 File Offset: 0x00357AB2
		public byte[] GetStartTimeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x003598CC File Offset: 0x00357ACC
		public float Position(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600EC68 RID: 60520 RVA: 0x00359910 File Offset: 0x00357B10
		public int PositionLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EC69 RID: 60521 RVA: 0x0035993C File Offset: 0x00357B3C
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600EC6A RID: 60522 RVA: 0x0035994C File Offset: 0x00357B4C
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x0600EC6B RID: 60523 RVA: 0x00359964 File Offset: 0x00357B64
		public float Rotation(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600EC6C RID: 60524 RVA: 0x003599A8 File Offset: 0x00357BA8
		public int RotationLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x003599D4 File Offset: 0x00357BD4
		public Span<float> GetRotationBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x0600EC6E RID: 60526 RVA: 0x003599E4 File Offset: 0x00357BE4
		public float[] GetRotationArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x003599FC File Offset: 0x00357BFC
		public int BehaviorTree
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600EC70 RID: 60528 RVA: 0x00359A3C File Offset: 0x00357C3C
		public string CommonBtOverride
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EC71 RID: 60529 RVA: 0x00359A74 File Offset: 0x00357C74
		public Span<byte> GetCommonBtOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EC72 RID: 60530 RVA: 0x00359A84 File Offset: 0x00357C84
		public byte[] GetCommonBtOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x00359A9C File Offset: 0x00357C9C
		public string SplineEntityUid
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x00359AD4 File Offset: 0x00357CD4
		public Span<byte> GetSplineEntityUidBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x00359AE4 File Offset: 0x00357CE4
		public byte[] GetSplineEntityUidArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x00359AFC File Offset: 0x00357CFC
		[NullableContext(1)]
		public float[] Position()
		{
			return this.GetPositionArray();
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x00359B04 File Offset: 0x00357D04
		[NullableContext(1)]
		public IEnumerable<float> PositionIter()
		{
			TimeSchedule.<PositionIter>d__39 <PositionIter>d__ = new TimeSchedule.<PositionIter>d__39(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x00359B19 File Offset: 0x00357D19
		[NullableContext(1)]
		public float[] Rotation()
		{
			return this.GetRotationArray();
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x00359B21 File Offset: 0x00357D21
		[NullableContext(1)]
		public IEnumerable<float> RotationIter()
		{
			TimeSchedule.<RotationIter>d__41 <RotationIter>d__ = new TimeSchedule.<RotationIter>d__41(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x040058B3 RID: 22707
		private Table __p;
	}
}
