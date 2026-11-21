using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001169 RID: 4457
	public struct RougeResMiraclecreation : IFlatbufferObject
	{
		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600D43A RID: 54330 RVA: 0x003225CB File Offset: 0x003207CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x003225D8 File Offset: 0x003207D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x003225E0 File Offset: 0x003207E0
		public static RougeResMiraclecreation GetRootAsRougeResMiraclecreation(ByteBuffer _bb)
		{
			return RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(_bb, default(RougeResMiraclecreation));
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x003225FC File Offset: 0x003207FC
		public static RougeResMiraclecreation GetRootAsRougeResMiraclecreation(ByteBuffer _bb, RougeResMiraclecreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x00322619 File Offset: 0x00320819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D43F RID: 54335 RVA: 0x00322628 File Offset: 0x00320828
		public RougeResMiraclecreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600D440 RID: 54336 RVA: 0x00322638 File Offset: 0x00320838
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

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600D441 RID: 54337 RVA: 0x00322674 File Offset: 0x00320874
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

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600D442 RID: 54338 RVA: 0x003226B0 File Offset: 0x003208B0
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

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600D443 RID: 54339 RVA: 0x003226EC File Offset: 0x003208EC
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

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600D444 RID: 54340 RVA: 0x0032272C File Offset: 0x0032092C
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600D445 RID: 54341 RVA: 0x0032276C File Offset: 0x0032096C
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

		// Token: 0x0600D446 RID: 54342 RVA: 0x003227A4 File Offset: 0x003209A4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x003227B4 File Offset: 0x003209B4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600D448 RID: 54344 RVA: 0x003227CC File Offset: 0x003209CC
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

		// Token: 0x0600D449 RID: 54345 RVA: 0x00322804 File Offset: 0x00320A04
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D44A RID: 54346 RVA: 0x00322814 File Offset: 0x00320A14
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600D44B RID: 54347 RVA: 0x0032282C File Offset: 0x00320A2C
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

		// Token: 0x0600D44C RID: 54348 RVA: 0x00322864 File Offset: 0x00320A64
		public Span<byte> GetBriefDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x00322874 File Offset: 0x00320A74
		public byte[] GetBriefDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600D44E RID: 54350 RVA: 0x0032288C File Offset: 0x00320A8C
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

		// Token: 0x0600D44F RID: 54351 RVA: 0x003228C4 File Offset: 0x00320AC4
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x003228D4 File Offset: 0x00320AD4
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600D451 RID: 54353 RVA: 0x003228EC File Offset: 0x00320AEC
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

		// Token: 0x0600D452 RID: 54354 RVA: 0x00322924 File Offset: 0x00320B24
		public Span<byte> GetStoryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x00322934 File Offset: 0x00320B34
		public byte[] GetStoryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005772 RID: 22386
		private Table __p;
	}
}
