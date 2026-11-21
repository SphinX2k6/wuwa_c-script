using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C03 RID: 3075
	public struct BabelTowerQuick : IFlatbufferObject
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x001FE4E8 File Offset: 0x001FC6E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x001FE4F5 File Offset: 0x001FC6F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x001FE4FC File Offset: 0x001FC6FC
		public static BabelTowerQuick GetRootAsBabelTowerQuick(ByteBuffer _bb)
		{
			return BabelTowerQuick.GetRootAsBabelTowerQuick(_bb, default(BabelTowerQuick));
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x001FE518 File Offset: 0x001FC718
		public static BabelTowerQuick GetRootAsBabelTowerQuick(ByteBuffer _bb, BabelTowerQuick obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x001FE535 File Offset: 0x001FC735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x001FE544 File Offset: 0x001FC744
		public BabelTowerQuick __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x001FE554 File Offset: 0x001FC754
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x001FE590 File Offset: 0x001FC790
		public int InstId
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x001FE5CC File Offset: 0x001FC7CC
		public int ActivityId
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x001FE608 File Offset: 0x001FC808
		public string Des
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

		// Token: 0x0600510F RID: 20751 RVA: 0x001FE640 File Offset: 0x001FC840
		public Span<byte> GetDesBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x001FE650 File Offset: 0x001FC850
		public byte[] GetDesArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06005111 RID: 20753 RVA: 0x001FE668 File Offset: 0x001FC868
		public string DifficultyTextKey
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

		// Token: 0x06005112 RID: 20754 RVA: 0x001FE6A0 File Offset: 0x001FC8A0
		public Span<byte> GetDifficultyTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x001FE6B0 File Offset: 0x001FC8B0
		public byte[] GetDifficultyTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x001FE6C8 File Offset: 0x001FC8C8
		public int QuickSelect
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

		// Token: 0x06005115 RID: 20757 RVA: 0x001FE708 File Offset: 0x001FC908
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x001FE748 File Offset: 0x001FC948
		public int BuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x001FE774 File Offset: 0x001FC974
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x001FE784 File Offset: 0x001FC984
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x001FE79C File Offset: 0x001FC99C
		[NullableContext(1)]
		public int[] BuffGroup()
		{
			return this.GetBuffGroupArray();
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x001FE7A4 File Offset: 0x001FC9A4
		[NullableContext(1)]
		public IEnumerable<int> BuffGroupIter()
		{
			BabelTowerQuick.<BuffGroupIter>d__30 <BuffGroupIter>d__ = new BabelTowerQuick.<BuffGroupIter>d__30(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x040050F5 RID: 20725
		private Table __p;
	}
}
