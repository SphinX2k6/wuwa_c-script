using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6F RID: 3183
	public struct CommonRewardViewDisplay : IFlatbufferObject
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x0021A645 File Offset: 0x00218845
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x0021A652 File Offset: 0x00218852
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x0021A65C File Offset: 0x0021885C
		public static CommonRewardViewDisplay GetRootAsCommonRewardViewDisplay(ByteBuffer _bb)
		{
			return CommonRewardViewDisplay.GetRootAsCommonRewardViewDisplay(_bb, default(CommonRewardViewDisplay));
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x0021A678 File Offset: 0x00218878
		public static CommonRewardViewDisplay GetRootAsCommonRewardViewDisplay(ByteBuffer _bb, CommonRewardViewDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x0021A695 File Offset: 0x00218895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x0021A6A4 File Offset: 0x002188A4
		public CommonRewardViewDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06005D3A RID: 23866 RVA: 0x0021A6B4 File Offset: 0x002188B4
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x0021A6F0 File Offset: 0x002188F0
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

		// Token: 0x06005D3C RID: 23868 RVA: 0x0021A727 File Offset: 0x00218927
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x0021A736 File Offset: 0x00218936
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x0021A750 File Offset: 0x00218950
		public string ContinueText
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

		// Token: 0x06005D3F RID: 23871 RVA: 0x0021A787 File Offset: 0x00218987
		public Span<byte> GetContinueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x0021A796 File Offset: 0x00218996
		public byte[] GetContinueTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x0021A7B0 File Offset: 0x002189B0
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06005D42 RID: 23874 RVA: 0x0021A7F0 File Offset: 0x002189F0
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x0021A830 File Offset: 0x00218A30
		public string AudioId
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

		// Token: 0x06005D44 RID: 23876 RVA: 0x0021A868 File Offset: 0x00218A68
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x0021A878 File Offset: 0x00218A78
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400517E RID: 20862
		private Table __p;
	}
}
