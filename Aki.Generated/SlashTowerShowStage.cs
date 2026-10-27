using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D0 RID: 4304
	public struct SlashTowerShowStage : IFlatbufferObject
	{
		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600D6BB RID: 54971 RVA: 0x0031B675 File Offset: 0x00319875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x0031B682 File Offset: 0x00319882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6BD RID: 54973 RVA: 0x0031B68C File Offset: 0x0031988C
		public static SlashTowerShowStage GetRootAsSlashTowerShowStage(ByteBuffer _bb)
		{
			return SlashTowerShowStage.GetRootAsSlashTowerShowStage(_bb, default(SlashTowerShowStage));
		}

		// Token: 0x0600D6BE RID: 54974 RVA: 0x0031B6A8 File Offset: 0x003198A8
		public static SlashTowerShowStage GetRootAsSlashTowerShowStage(ByteBuffer _bb, SlashTowerShowStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x0031B6C5 File Offset: 0x003198C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x0031B6D4 File Offset: 0x003198D4
		public SlashTowerShowStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x0031B6E4 File Offset: 0x003198E4
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

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x0031B720 File Offset: 0x00319920
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

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x0031B757 File Offset: 0x00319957
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x0031B766 File Offset: 0x00319966
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600D6C5 RID: 54981 RVA: 0x0031B780 File Offset: 0x00319980
		public int OutIndex
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

		// Token: 0x04005202 RID: 20994
		private Table __p;
	}
}
