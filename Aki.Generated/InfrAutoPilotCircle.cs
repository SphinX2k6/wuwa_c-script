using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E48 RID: 3656
	public struct InfrAutoPilotCircle : IFlatbufferObject
	{
		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x0027CAE0 File Offset: 0x0027ACE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x0027CAED File Offset: 0x0027ACED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x0027CAF4 File Offset: 0x0027ACF4
		public static InfrAutoPilotCircle GetRootAsInfrAutoPilotCircle(ByteBuffer _bb)
		{
			return InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(_bb, default(InfrAutoPilotCircle));
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x0027CB10 File Offset: 0x0027AD10
		public static InfrAutoPilotCircle GetRootAsInfrAutoPilotCircle(ByteBuffer _bb, InfrAutoPilotCircle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0027CB2D File Offset: 0x0027AD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x0027CB3C File Offset: 0x0027AD3C
		public InfrAutoPilotCircle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06008943 RID: 35139 RVA: 0x0027CB4C File Offset: 0x0027AD4C
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

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06008944 RID: 35140 RVA: 0x0027CB88 File Offset: 0x0027AD88
		public int AutoPilotCirclePathId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06008945 RID: 35141 RVA: 0x0027CBC4 File Offset: 0x0027ADC4
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x0027CC00 File Offset: 0x0027AE00
		public int RoadBuildIdArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06008947 RID: 35143 RVA: 0x0027CC40 File Offset: 0x0027AE40
		public int RoadBuildIdArrayLength
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

		// Token: 0x06008948 RID: 35144 RVA: 0x0027CC6C File Offset: 0x0027AE6C
		public Span<int> GetRoadBuildIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x0027CC7C File Offset: 0x0027AE7C
		public int[] GetRoadBuildIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x0027CC94 File Offset: 0x0027AE94
		public string PrefabPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x0027CCCC File Offset: 0x0027AECC
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x0027CCDC File Offset: 0x0027AEDC
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0027CCF4 File Offset: 0x0027AEF4
		[NullableContext(1)]
		public int[] RoadBuildIdArray()
		{
			return this.GetRoadBuildIdArrayArray();
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0027CCFC File Offset: 0x0027AEFC
		[NullableContext(1)]
		public IEnumerable<int> RoadBuildIdArrayIter()
		{
			InfrAutoPilotCircle.<RoadBuildIdArrayIter>d__24 <RoadBuildIdArrayIter>d__ = new InfrAutoPilotCircle.<RoadBuildIdArrayIter>d__24(-2);
			<RoadBuildIdArrayIter>d__.<>3__<>4__this = this;
			return <RoadBuildIdArrayIter>d__;
		}

		// Token: 0x040053C7 RID: 21447
		private Table __p;
	}
}
