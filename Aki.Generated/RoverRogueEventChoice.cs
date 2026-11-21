using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001174 RID: 4468
	public struct RoverRogueEventChoice : IFlatbufferObject
	{
		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600D57D RID: 54653 RVA: 0x003253B4 File Offset: 0x003235B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x003253C1 File Offset: 0x003235C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x003253C8 File Offset: 0x003235C8
		public static RoverRogueEventChoice GetRootAsRoverRogueEventChoice(ByteBuffer _bb)
		{
			return RoverRogueEventChoice.GetRootAsRoverRogueEventChoice(_bb, default(RoverRogueEventChoice));
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x003253E4 File Offset: 0x003235E4
		public static RoverRogueEventChoice GetRootAsRoverRogueEventChoice(ByteBuffer _bb, RoverRogueEventChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x00325401 File Offset: 0x00323601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D582 RID: 54658 RVA: 0x00325410 File Offset: 0x00323610
		public RoverRogueEventChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600D583 RID: 54659 RVA: 0x00325420 File Offset: 0x00323620
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

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600D584 RID: 54660 RVA: 0x0032545C File Offset: 0x0032365C
		public string Desc
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

		// Token: 0x0600D585 RID: 54661 RVA: 0x00325493 File Offset: 0x00323693
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D586 RID: 54662 RVA: 0x003254A2 File Offset: 0x003236A2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x003254BC File Offset: 0x003236BC
		public string Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600D588 RID: 54664 RVA: 0x003254F8 File Offset: 0x003236F8
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600D589 RID: 54665 RVA: 0x00325524 File Offset: 0x00323724
		public string BriefDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x0032555C File Offset: 0x0032375C
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x0032556C File Offset: 0x0032376C
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00325584 File Offset: 0x00323784
		public string BriefDescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600D58D RID: 54669 RVA: 0x003255C0 File Offset: 0x003237C0
		public int BriefDescParamsLength
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

		// Token: 0x0600D58E RID: 54670 RVA: 0x003255EC File Offset: 0x003237EC
		[NullableContext(1)]
		public string[] BriefDescParams()
		{
			return this.BriefDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x003255F9 File Offset: 0x003237F9
		[NullableContext(1)]
		public IEnumerable<string> BriefDescParamsIter()
		{
			RoverRogueEventChoice.<BriefDescParamsIter>d__25 <BriefDescParamsIter>d__ = new RoverRogueEventChoice.<BriefDescParamsIter>d__25(-2);
			<BriefDescParamsIter>d__.<>3__<>4__this = this;
			return <BriefDescParamsIter>d__;
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x0032560E File Offset: 0x0032380E
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600D591 RID: 54673 RVA: 0x0032561B File Offset: 0x0032381B
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			RoverRogueEventChoice.<ParamsIter>d__27 <ParamsIter>d__ = new RoverRogueEventChoice.<ParamsIter>d__27(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005782 RID: 22402
		private Table __p;
	}
}
