using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124B RID: 4683
	public struct TalkOptionIcon : IFlatbufferObject
	{
		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x003546D8 File Offset: 0x003528D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA16 RID: 59926 RVA: 0x003546E5 File Offset: 0x003528E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x003546EC File Offset: 0x003528EC
		public static TalkOptionIcon GetRootAsTalkOptionIcon(ByteBuffer _bb)
		{
			return TalkOptionIcon.GetRootAsTalkOptionIcon(_bb, default(TalkOptionIcon));
		}

		// Token: 0x0600EA18 RID: 59928 RVA: 0x00354708 File Offset: 0x00352908
		public static TalkOptionIcon GetRootAsTalkOptionIcon(ByteBuffer _bb, TalkOptionIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x00354725 File Offset: 0x00352925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x00354734 File Offset: 0x00352934
		public TalkOptionIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x00354744 File Offset: 0x00352944
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

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600EA1C RID: 59932 RVA: 0x00354780 File Offset: 0x00352980
		public string Type
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

		// Token: 0x0600EA1D RID: 59933 RVA: 0x003547B7 File Offset: 0x003529B7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x003547C6 File Offset: 0x003529C6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x003547E0 File Offset: 0x003529E0
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

		// Token: 0x0600EA20 RID: 59936 RVA: 0x00354817 File Offset: 0x00352A17
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x00354826 File Offset: 0x00352A26
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005895 RID: 22677
		private Table __p;
	}
}
