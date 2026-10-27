using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001136 RID: 4406
	public struct TowerBuff : IFlatbufferObject
	{
		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x0032F18C File Offset: 0x0032D38C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF69 RID: 57193 RVA: 0x0032F199 File Offset: 0x0032D399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x0032F1A0 File Offset: 0x0032D3A0
		public static TowerBuff GetRootAsTowerBuff(ByteBuffer _bb)
		{
			return TowerBuff.GetRootAsTowerBuff(_bb, default(TowerBuff));
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x0032F1BC File Offset: 0x0032D3BC
		public static TowerBuff GetRootAsTowerBuff(ByteBuffer _bb, TowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x0032F1D9 File Offset: 0x0032D3D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x0032F1E8 File Offset: 0x0032D3E8
		public TowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600DF6E RID: 57198 RVA: 0x0032F1F8 File Offset: 0x0032D3F8
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600DF6F RID: 57199 RVA: 0x0032F240 File Offset: 0x0032D440
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

		// Token: 0x0600DF70 RID: 57200 RVA: 0x0032F277 File Offset: 0x0032D477
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DF71 RID: 57201 RVA: 0x0032F286 File Offset: 0x0032D486
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600DF72 RID: 57202 RVA: 0x0032F2A0 File Offset: 0x0032D4A0
		public string Desc
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

		// Token: 0x0600DF73 RID: 57203 RVA: 0x0032F2D7 File Offset: 0x0032D4D7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x0032F2E6 File Offset: 0x0032D4E6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600DF75 RID: 57205 RVA: 0x0032F300 File Offset: 0x0032D500
		public string Icon
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

		// Token: 0x0600DF76 RID: 57206 RVA: 0x0032F338 File Offset: 0x0032D538
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x0032F348 File Offset: 0x0032D548
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005277 RID: 21111
		private Table __p;
	}
}
