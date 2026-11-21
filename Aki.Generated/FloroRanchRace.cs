using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D90 RID: 3472
	public struct FloroRanchRace : IFlatbufferObject
	{
		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x0025A5B5 File Offset: 0x002587B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x0025A5C2 File Offset: 0x002587C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x0025A5CC File Offset: 0x002587CC
		public static FloroRanchRace GetRootAsFloroRanchRace(ByteBuffer _bb)
		{
			return FloroRanchRace.GetRootAsFloroRanchRace(_bb, default(FloroRanchRace));
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0025A5E8 File Offset: 0x002587E8
		public static FloroRanchRace GetRootAsFloroRanchRace(ByteBuffer _bb, FloroRanchRace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x0025A605 File Offset: 0x00258805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0025A614 File Offset: 0x00258814
		public FloroRanchRace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06007992 RID: 31122 RVA: 0x0025A624 File Offset: 0x00258824
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

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x0025A660 File Offset: 0x00258860
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

		// Token: 0x06007994 RID: 31124 RVA: 0x0025A697 File Offset: 0x00258897
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x0025A6A6 File Offset: 0x002588A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x0025A6C0 File Offset: 0x002588C0
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

		// Token: 0x06007997 RID: 31127 RVA: 0x0025A6F7 File Offset: 0x002588F7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x0025A706 File Offset: 0x00258906
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x0025A720 File Offset: 0x00258920
		public string Description
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

		// Token: 0x0600799A RID: 31130 RVA: 0x0025A758 File Offset: 0x00258958
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x0025A768 File Offset: 0x00258968
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x0025A780 File Offset: 0x00258980
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x0025A7C0 File Offset: 0x002589C0
		public string SmallIcon
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

		// Token: 0x0600799E RID: 31134 RVA: 0x0025A7F8 File Offset: 0x002589F8
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x0025A808 File Offset: 0x00258A08
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052F4 RID: 21236
		private Table __p;
	}
}
