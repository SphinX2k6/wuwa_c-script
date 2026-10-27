using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106E RID: 4206
	public struct RougeResMiraclecreation : IFlatbufferObject
	{
		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600CC67 RID: 52327 RVA: 0x00302D51 File Offset: 0x00300F51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00302D5E File Offset: 0x00300F5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x00302D68 File Offset: 0x00300F68
		public static RougeResMiraclecreation GetRootAsRougeResMiraclecreation(ByteBuffer _bb)
		{
			return RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(_bb, default(RougeResMiraclecreation));
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00302D84 File Offset: 0x00300F84
		public static RougeResMiraclecreation GetRootAsRougeResMiraclecreation(ByteBuffer _bb, RougeResMiraclecreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00302DA1 File Offset: 0x00300FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00302DB0 File Offset: 0x00300FB0
		public RougeResMiraclecreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600CC6D RID: 52333 RVA: 0x00302DC0 File Offset: 0x00300FC0
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

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600CC6E RID: 52334 RVA: 0x00302DFC File Offset: 0x00300FFC
		public int Category
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

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600CC6F RID: 52335 RVA: 0x00302E38 File Offset: 0x00301038
		public int DefaultLevel
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

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600CC70 RID: 52336 RVA: 0x00302E74 File Offset: 0x00301074
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x00302EB4 File Offset: 0x003010B4
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600CC72 RID: 52338 RVA: 0x00302EF4 File Offset: 0x003010F4
		public string Icon
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

		// Token: 0x0600CC73 RID: 52339 RVA: 0x00302F2C File Offset: 0x0030112C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x00302F3C File Offset: 0x0030113C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600CC75 RID: 52341 RVA: 0x00302F54 File Offset: 0x00301154
		public string Name
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

		// Token: 0x0600CC76 RID: 52342 RVA: 0x00302F8C File Offset: 0x0030118C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x00302F9C File Offset: 0x0030119C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600CC78 RID: 52344 RVA: 0x00302FB4 File Offset: 0x003011B4
		public string BriefDescribe
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

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00302FEC File Offset: 0x003011EC
		public Span<byte> GetBriefDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00302FFC File Offset: 0x003011FC
		public byte[] GetBriefDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600CC7B RID: 52347 RVA: 0x00303014 File Offset: 0x00301214
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x0030304C File Offset: 0x0030124C
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x0030305C File Offset: 0x0030125C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x00303074 File Offset: 0x00301274
		public string StoryDescribe
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x003030AC File Offset: 0x003012AC
		public Span<byte> GetStoryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x003030BC File Offset: 0x003012BC
		public byte[] GetStoryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005173 RID: 20851
		private Table __p;
	}
}
