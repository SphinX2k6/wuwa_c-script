using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A2 RID: 4514
	public struct WeekCardContent : IFlatbufferObject
	{
		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600E8F7 RID: 59639 RVA: 0x00345118 File Offset: 0x00343318
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x00345125 File Offset: 0x00343325
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x0034512C File Offset: 0x0034332C
		public static WeekCardContent GetRootAsWeekCardContent(ByteBuffer _bb)
		{
			return WeekCardContent.GetRootAsWeekCardContent(_bb, default(WeekCardContent));
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00345148 File Offset: 0x00343348
		public static WeekCardContent GetRootAsWeekCardContent(ByteBuffer _bb, WeekCardContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8FB RID: 59643 RVA: 0x00345165 File Offset: 0x00343365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x00345174 File Offset: 0x00343374
		public WeekCardContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600E8FD RID: 59645 RVA: 0x00345184 File Offset: 0x00343384
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

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600E8FE RID: 59646 RVA: 0x003451C0 File Offset: 0x003433C0
		public string RewardTexture
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

		// Token: 0x0600E8FF RID: 59647 RVA: 0x003451F7 File Offset: 0x003433F7
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x00345206 File Offset: 0x00343406
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052EE RID: 21230
		private Table __p;
	}
}
