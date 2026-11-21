using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD5 RID: 3285
	public struct DirectTrainMain : IFlatbufferObject
	{
		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x00233755 File Offset: 0x00231955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00233762 File Offset: 0x00231962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x0023376C File Offset: 0x0023196C
		public static DirectTrainMain GetRootAsDirectTrainMain(ByteBuffer _bb)
		{
			return DirectTrainMain.GetRootAsDirectTrainMain(_bb, default(DirectTrainMain));
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00233788 File Offset: 0x00231988
		public static DirectTrainMain GetRootAsDirectTrainMain(ByteBuffer _bb, DirectTrainMain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x002337A5 File Offset: 0x002319A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x002337B4 File Offset: 0x002319B4
		public DirectTrainMain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x002337C4 File Offset: 0x002319C4
		public int ActivityId
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

		// Token: 0x06006868 RID: 26728 RVA: 0x00233800 File Offset: 0x00231A00
		public int SubActivityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x00233840 File Offset: 0x00231A40
		public int SubActivityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x0023386B File Offset: 0x00231A6B
		public Span<int> GetSubActivityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x0023387A File Offset: 0x00231A7A
		public int[] GetSubActivityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600686C RID: 26732 RVA: 0x00233894 File Offset: 0x00231A94
		public string BottomTipText
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

		// Token: 0x0600686D RID: 26733 RVA: 0x002338CB File Offset: 0x00231ACB
		public Span<byte> GetBottomTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x002338DA File Offset: 0x00231ADA
		public byte[] GetBottomTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x002338F1 File Offset: 0x00231AF1
		[NullableContext(1)]
		public int[] SubActivityIds()
		{
			return this.GetSubActivityIdsArray();
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x002338F9 File Offset: 0x00231AF9
		[NullableContext(1)]
		public IEnumerable<int> SubActivityIdsIter()
		{
			DirectTrainMain.<SubActivityIdsIter>d__20 <SubActivityIdsIter>d__ = new DirectTrainMain.<SubActivityIdsIter>d__20(-2);
			<SubActivityIdsIter>d__.<>3__<>4__this = this;
			return <SubActivityIdsIter>d__;
		}

		// Token: 0x04005202 RID: 20994
		private Table __p;
	}
}
