using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D63 RID: 3427
	public struct InfrAutoPilotCircle : IFlatbufferObject
	{
		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06008323 RID: 33571 RVA: 0x0025E430 File Offset: 0x0025C630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x0025E43D File Offset: 0x0025C63D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x0025E444 File Offset: 0x0025C644
		public static InfrAutoPilotCircle GetRootAsInfrAutoPilotCircle(ByteBuffer _bb)
		{
			return InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(_bb, default(InfrAutoPilotCircle));
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x0025E460 File Offset: 0x0025C660
		public static InfrAutoPilotCircle GetRootAsInfrAutoPilotCircle(ByteBuffer _bb, InfrAutoPilotCircle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x0025E47D File Offset: 0x0025C67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x0025E48C File Offset: 0x0025C68C
		public InfrAutoPilotCircle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06008329 RID: 33577 RVA: 0x0025E49C File Offset: 0x0025C69C
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

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600832A RID: 33578 RVA: 0x0025E4D8 File Offset: 0x0025C6D8
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600832B RID: 33579 RVA: 0x0025E514 File Offset: 0x0025C714
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

		// Token: 0x0600832C RID: 33580 RVA: 0x0025E550 File Offset: 0x0025C750
		public int RoadBuildIdArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x0600832D RID: 33581 RVA: 0x0025E590 File Offset: 0x0025C790
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

		// Token: 0x0600832E RID: 33582 RVA: 0x0025E5BC File Offset: 0x0025C7BC
		public Span<int> GetRoadBuildIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0025E5CC File Offset: 0x0025C7CC
		public int[] GetRoadBuildIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x0025E5E4 File Offset: 0x0025C7E4
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

		// Token: 0x06008331 RID: 33585 RVA: 0x0025E61C File Offset: 0x0025C81C
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0025E62C File Offset: 0x0025C82C
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x0025E644 File Offset: 0x0025C844
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoadBuildIdArrayIter()或GetRoadBuildIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoadBuildIdArray()
		{
			InfrAutoPilotCircle infrAutoPilotCircle = this;
			return infrAutoPilotCircle.GetRoadBuildIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0025E668 File Offset: 0x0025C868
		[NullableContext(1)]
		public readonly IEnumerable<int> RoadBuildIdArrayIter()
		{
			InfrAutoPilotCircle.<RoadBuildIdArrayIter>d__24 <RoadBuildIdArrayIter>d__ = new InfrAutoPilotCircle.<RoadBuildIdArrayIter>d__24(-2);
			<RoadBuildIdArrayIter>d__.<>3__<>4__this = this;
			return <RoadBuildIdArrayIter>d__;
		}

		// Token: 0x04004DE2 RID: 19938
		private Table __p;
	}
}
