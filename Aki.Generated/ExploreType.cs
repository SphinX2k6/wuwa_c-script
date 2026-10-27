using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C57 RID: 3159
	public struct ExploreType : IFlatbufferObject
	{
		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06006C36 RID: 27702 RVA: 0x0022A2B4 File Offset: 0x002284B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0022A2C1 File Offset: 0x002284C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x0022A2C8 File Offset: 0x002284C8
		public static ExploreType GetRootAsExploreType(ByteBuffer _bb)
		{
			return ExploreType.GetRootAsExploreType(_bb, default(ExploreType));
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x0022A2E4 File Offset: 0x002284E4
		public static ExploreType GetRootAsExploreType(ByteBuffer _bb, ExploreType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x0022A301 File Offset: 0x00228501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x0022A310 File Offset: 0x00228510
		public ExploreType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06006C3C RID: 27708 RVA: 0x0022A320 File Offset: 0x00228520
		public int ExploreTypeKey
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x0022A35C File Offset: 0x0022855C
		public string Name
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

		// Token: 0x06006C3E RID: 27710 RVA: 0x0022A393 File Offset: 0x00228593
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x0022A3A2 File Offset: 0x002285A2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06006C40 RID: 27712 RVA: 0x0022A3BC File Offset: 0x002285BC
		public string Icon
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

		// Token: 0x06006C41 RID: 27713 RVA: 0x0022A3F3 File Offset: 0x002285F3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x0022A402 File Offset: 0x00228602
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06006C43 RID: 27715 RVA: 0x0022A41C File Offset: 0x0022861C
		public string DescBg
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

		// Token: 0x06006C44 RID: 27716 RVA: 0x0022A454 File Offset: 0x00228654
		public Span<byte> GetDescBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x0022A464 File Offset: 0x00228664
		public byte[] GetDescBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06006C46 RID: 27718 RVA: 0x0022A47C File Offset: 0x0022867C
		public string LockDescId
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

		// Token: 0x06006C47 RID: 27719 RVA: 0x0022A4B4 File Offset: 0x002286B4
		public Span<byte> GetLockDescIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x0022A4C4 File Offset: 0x002286C4
		public byte[] GetLockDescIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06006C49 RID: 27721 RVA: 0x0022A4DC File Offset: 0x002286DC
		public string DescId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x0022A514 File Offset: 0x00228714
		public Span<byte> GetDescIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x0022A524 File Offset: 0x00228724
		public byte[] GetDescIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x0022A53C File Offset: 0x0022873C
		public int CountMode
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06006C4D RID: 27725 RVA: 0x0022A57C File Offset: 0x0022877C
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CA2 RID: 19618
		private Table __p;
	}
}
