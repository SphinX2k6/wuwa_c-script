using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112F RID: 4399
	public struct TimeSchedule : IFlatbufferObject
	{
		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600DEEC RID: 57068 RVA: 0x0032E18D File Offset: 0x0032C38D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEED RID: 57069 RVA: 0x0032E19A File Offset: 0x0032C39A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x0032E1A4 File Offset: 0x0032C3A4
		public static TimeSchedule GetRootAsTimeSchedule(ByteBuffer _bb)
		{
			return TimeSchedule.GetRootAsTimeSchedule(_bb, default(TimeSchedule));
		}

		// Token: 0x0600DEEF RID: 57071 RVA: 0x0032E1C0 File Offset: 0x0032C3C0
		public static TimeSchedule GetRootAsTimeSchedule(ByteBuffer _bb, TimeSchedule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEF0 RID: 57072 RVA: 0x0032E1DD File Offset: 0x0032C3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEF1 RID: 57073 RVA: 0x0032E1EC File Offset: 0x0032C3EC
		public TimeSchedule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600DEF2 RID: 57074 RVA: 0x0032E1FC File Offset: 0x0032C3FC
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

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0600DEF3 RID: 57075 RVA: 0x0032E238 File Offset: 0x0032C438
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

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x0032E26F File Offset: 0x0032C46F
		public Span<byte> GetTimeScheduleTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEF5 RID: 57077 RVA: 0x0032E27E File Offset: 0x0032C47E
		public byte[] GetTimeScheduleTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600DEF6 RID: 57078 RVA: 0x0032E298 File Offset: 0x0032C498
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

		// Token: 0x0600DEF7 RID: 57079 RVA: 0x0032E2CF File Offset: 0x0032C4CF
		public Span<byte> GetStartTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DEF8 RID: 57080 RVA: 0x0032E2DE File Offset: 0x0032C4DE
		public byte[] GetStartTimeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DEF9 RID: 57081 RVA: 0x0032E2F8 File Offset: 0x0032C4F8
		public float Position(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x0032E33C File Offset: 0x0032C53C
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

		// Token: 0x0600DEFB RID: 57083 RVA: 0x0032E368 File Offset: 0x0032C568
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600DEFC RID: 57084 RVA: 0x0032E378 File Offset: 0x0032C578
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x0600DEFD RID: 57085 RVA: 0x0032E390 File Offset: 0x0032C590
		public float Rotation(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x0032E3D4 File Offset: 0x0032C5D4
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

		// Token: 0x0600DEFF RID: 57087 RVA: 0x0032E400 File Offset: 0x0032C600
		public Span<float> GetRotationBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x0032E410 File Offset: 0x0032C610
		public float[] GetRotationArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600DF01 RID: 57089 RVA: 0x0032E428 File Offset: 0x0032C628
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

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x0032E468 File Offset: 0x0032C668
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

		// Token: 0x0600DF03 RID: 57091 RVA: 0x0032E4A0 File Offset: 0x0032C6A0
		public Span<byte> GetCommonBtOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DF04 RID: 57092 RVA: 0x0032E4B0 File Offset: 0x0032C6B0
		public byte[] GetCommonBtOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600DF05 RID: 57093 RVA: 0x0032E4C8 File Offset: 0x0032C6C8
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

		// Token: 0x0600DF06 RID: 57094 RVA: 0x0032E500 File Offset: 0x0032C700
		public Span<byte> GetSplineEntityUidBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DF07 RID: 57095 RVA: 0x0032E510 File Offset: 0x0032C710
		public byte[] GetSplineEntityUidArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DF08 RID: 57096 RVA: 0x0032E528 File Offset: 0x0032C728
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionIter()或GetPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Position()
		{
			TimeSchedule timeSchedule = this;
			return timeSchedule.GetPositionArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600DF09 RID: 57097 RVA: 0x0032E54C File Offset: 0x0032C74C
		[NullableContext(1)]
		public readonly IEnumerable<float> PositionIter()
		{
			TimeSchedule.<PositionIter>d__39 <PositionIter>d__ = new TimeSchedule.<PositionIter>d__39(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x0032E564 File Offset: 0x0032C764
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotationIter()或GetRotationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotation()
		{
			TimeSchedule timeSchedule = this;
			return timeSchedule.GetRotationArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x0032E588 File Offset: 0x0032C788
		[NullableContext(1)]
		public readonly IEnumerable<float> RotationIter()
		{
			TimeSchedule.<RotationIter>d__41 <RotationIter>d__ = new TimeSchedule.<RotationIter>d__41(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x04005270 RID: 21104
		private Table __p;
	}
}
