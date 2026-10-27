using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C50 RID: 3152
	public struct ExploreRewardDisplay : IFlatbufferObject
	{
		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x002288E1 File Offset: 0x00226AE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x002288EE File Offset: 0x00226AEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x002288F8 File Offset: 0x00226AF8
		public static ExploreRewardDisplay GetRootAsExploreRewardDisplay(ByteBuffer _bb)
		{
			return ExploreRewardDisplay.GetRootAsExploreRewardDisplay(_bb, default(ExploreRewardDisplay));
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00228914 File Offset: 0x00226B14
		public static ExploreRewardDisplay GetRootAsExploreRewardDisplay(ByteBuffer _bb, ExploreRewardDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00228931 File Offset: 0x00226B31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00228940 File Offset: 0x00226B40
		public ExploreRewardDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x00228950 File Offset: 0x00226B50
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x0022898C File Offset: 0x00226B8C
		public string Title
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

		// Token: 0x06006B95 RID: 27541 RVA: 0x002289C3 File Offset: 0x00226BC3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x002289D2 File Offset: 0x00226BD2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06006B97 RID: 27543 RVA: 0x002289EC File Offset: 0x00226BEC
		public string TitleHexColor
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

		// Token: 0x06006B98 RID: 27544 RVA: 0x00228A23 File Offset: 0x00226C23
		public Span<byte> GetTitleHexColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00228A32 File Offset: 0x00226C32
		public byte[] GetTitleHexColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06006B9A RID: 27546 RVA: 0x00228A4C File Offset: 0x00226C4C
		public string TitleIconPath
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

		// Token: 0x06006B9B RID: 27547 RVA: 0x00228A84 File Offset: 0x00226C84
		public Span<byte> GetTitleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00228A94 File Offset: 0x00226C94
		public byte[] GetTitleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x00228AAC File Offset: 0x00226CAC
		public string TitleIconHexColor
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

		// Token: 0x06006B9E RID: 27550 RVA: 0x00228AE4 File Offset: 0x00226CE4
		public Span<byte> GetTitleIconHexColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00228AF4 File Offset: 0x00226CF4
		public byte[] GetTitleIconHexColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x00228B0C File Offset: 0x00226D0C
		public bool IsRecordVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x00228B4C File Offset: 0x00226D4C
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06006BA2 RID: 27554 RVA: 0x00228B8C File Offset: 0x00226D8C
		public bool IsExploreProgressVisible
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x00228BCC File Offset: 0x00226DCC
		public string ExploreBarTipsTextId
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

		// Token: 0x06006BA4 RID: 27556 RVA: 0x00228C04 File Offset: 0x00226E04
		public Span<byte> GetExploreBarTipsTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x00228C14 File Offset: 0x00226E14
		public byte[] GetExploreBarTipsTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06006BA6 RID: 27558 RVA: 0x00228C2C File Offset: 0x00226E2C
		public bool IsDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06006BA7 RID: 27559 RVA: 0x00228C6C File Offset: 0x00226E6C
		public string Description
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00228CA4 File Offset: 0x00226EA4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00228CB4 File Offset: 0x00226EB4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06006BAA RID: 27562 RVA: 0x00228CCC File Offset: 0x00226ECC
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x00228D0C File Offset: 0x00226F0C
		public string AudioId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00228D44 File Offset: 0x00226F44
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00228D54 File Offset: 0x00226F54
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C97 RID: 19607
		private Table __p;
	}
}
