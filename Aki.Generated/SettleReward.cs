using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001194 RID: 4500
	public struct SettleReward : IFlatbufferObject
	{
		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600D830 RID: 55344 RVA: 0x0032AF11 File Offset: 0x00329111
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D831 RID: 55345 RVA: 0x0032AF1E File Offset: 0x0032911E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x0032AF28 File Offset: 0x00329128
		public static SettleReward GetRootAsSettleReward(ByteBuffer _bb)
		{
			return SettleReward.GetRootAsSettleReward(_bb, default(SettleReward));
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x0032AF44 File Offset: 0x00329144
		public static SettleReward GetRootAsSettleReward(ByteBuffer _bb, SettleReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x0032AF61 File Offset: 0x00329161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D835 RID: 55349 RVA: 0x0032AF70 File Offset: 0x00329170
		public SettleReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600D836 RID: 55350 RVA: 0x0032AF80 File Offset: 0x00329180
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

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600D837 RID: 55351 RVA: 0x0032AFBC File Offset: 0x003291BC
		public int PhotoReward
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

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600D838 RID: 55352 RVA: 0x0032AFF8 File Offset: 0x003291F8
		public int PhotoRewardFemale
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

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600D839 RID: 55353 RVA: 0x0032B034 File Offset: 0x00329234
		public int SkinReward
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

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600D83A RID: 55354 RVA: 0x0032B074 File Offset: 0x00329274
		public string MalePhotoPath
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

		// Token: 0x0600D83B RID: 55355 RVA: 0x0032B0AC File Offset: 0x003292AC
		public Span<byte> GetMalePhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D83C RID: 55356 RVA: 0x0032B0BC File Offset: 0x003292BC
		public byte[] GetMalePhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600D83D RID: 55357 RVA: 0x0032B0D4 File Offset: 0x003292D4
		public string FemalePhotoPath
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

		// Token: 0x0600D83E RID: 55358 RVA: 0x0032B10C File Offset: 0x0032930C
		public Span<byte> GetFemalePhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D83F RID: 55359 RVA: 0x0032B11C File Offset: 0x0032931C
		public byte[] GetFemalePhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040057A5 RID: 22437
		private Table __p;
	}
}
