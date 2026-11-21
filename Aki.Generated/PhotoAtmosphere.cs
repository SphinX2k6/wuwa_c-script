using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE9 RID: 4073
	public struct PhotoAtmosphere : IFlatbufferObject
	{
		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600B143 RID: 45379 RVA: 0x002D5BC9 File Offset: 0x002D3DC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x002D5BD6 File Offset: 0x002D3DD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x002D5BE0 File Offset: 0x002D3DE0
		public static PhotoAtmosphere GetRootAsPhotoAtmosphere(ByteBuffer _bb)
		{
			return PhotoAtmosphere.GetRootAsPhotoAtmosphere(_bb, default(PhotoAtmosphere));
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x002D5BFC File Offset: 0x002D3DFC
		public static PhotoAtmosphere GetRootAsPhotoAtmosphere(ByteBuffer _bb, PhotoAtmosphere obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x002D5C19 File Offset: 0x002D3E19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x002D5C28 File Offset: 0x002D3E28
		public PhotoAtmosphere __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600B149 RID: 45385 RVA: 0x002D5C38 File Offset: 0x002D3E38
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

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x002D5C74 File Offset: 0x002D3E74
		public string Icon
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

		// Token: 0x0600B14B RID: 45387 RVA: 0x002D5CAB File Offset: 0x002D3EAB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x002D5CBA File Offset: 0x002D3EBA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600B14D RID: 45389 RVA: 0x002D5CD4 File Offset: 0x002D3ED4
		public string Name
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

		// Token: 0x0600B14E RID: 45390 RVA: 0x002D5D0B File Offset: 0x002D3F0B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x002D5D1A File Offset: 0x002D3F1A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x002D5D34 File Offset: 0x002D3F34
		public int RelativeItem
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

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x0600B151 RID: 45393 RVA: 0x002D5D74 File Offset: 0x002D3F74
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x002D5DB4 File Offset: 0x002D3FB4
		public int EffectType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600B153 RID: 45395 RVA: 0x002D5DF4 File Offset: 0x002D3FF4
		public int DefaultStrength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 50;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055B1 RID: 21937
		private Table __p;
	}
}
