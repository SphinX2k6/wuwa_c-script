using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004085 RID: 16517
	public struct IVolumeTriggerShape : IFlatbufferObject
	{
		// Token: 0x17007073 RID: 28787
		// (get) Token: 0x06016BE3 RID: 93155 RVA: 0x0033FB14 File Offset: 0x0033DD14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BE4 RID: 93156 RVA: 0x0033FB21 File Offset: 0x0033DD21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x0033FB28 File Offset: 0x0033DD28
		public static IVolumeTriggerShape GetRootAsIVolumeTriggerShape(ByteBuffer _bb)
		{
			return IVolumeTriggerShape.GetRootAsIVolumeTriggerShape(_bb, default(IVolumeTriggerShape));
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x0033FB44 File Offset: 0x0033DD44
		public static IVolumeTriggerShape GetRootAsIVolumeTriggerShape(ByteBuffer _bb, IVolumeTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x0033FB61 File Offset: 0x0033DD61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x0033FB70 File Offset: 0x0033DD70
		public IVolumeTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007074 RID: 28788
		// (get) Token: 0x06016BE9 RID: 93161 RVA: 0x0033FB80 File Offset: 0x0033DD80
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007075 RID: 28789
		// (get) Token: 0x06016BEA RID: 93162 RVA: 0x0033FBBC File Offset: 0x0033DDBC
		public string VolumeKey
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

		// Token: 0x06016BEB RID: 93163 RVA: 0x0033FBF3 File Offset: 0x0033DDF3
		public Span<byte> GetVolumeKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016BEC RID: 93164 RVA: 0x0033FC02 File Offset: 0x0033DE02
		public byte[] GetVolumeKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06016BED RID: 93165 RVA: 0x0033FC10 File Offset: 0x0033DE10
		public static Offset<IVolumeTriggerShape> CreateIVolumeTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, StringOffset VolumeKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVolumeTriggerShape.AddVolumeKey(builder, VolumeKeyOffset);
			IVolumeTriggerShape.AddType(builder, Type);
			return IVolumeTriggerShape.EndIVolumeTriggerShape(builder);
		}

		// Token: 0x06016BEE RID: 93166 RVA: 0x0033FC2D File Offset: 0x0033DE2D
		public static void StartIVolumeTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016BEF RID: 93167 RVA: 0x0033FC36 File Offset: 0x0033DE36
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x0033FC41 File Offset: 0x0033DE41
		public static void AddVolumeKey(FlatBufferBuilder builder, StringOffset volumeKeyOffset)
		{
			builder.AddOffset(1, volumeKeyOffset.Value, 0);
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x0033FC51 File Offset: 0x0033DE51
		public static Offset<IVolumeTriggerShape> EndIVolumeTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IVolumeTriggerShape>(builder.EndTable());
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x0033FC60 File Offset: 0x0033DE60
		public IVolumeTriggerShapeT UnPack()
		{
			IVolumeTriggerShapeT volumeTriggerShapeT = new IVolumeTriggerShapeT();
			this.UnPackTo(volumeTriggerShapeT);
			return volumeTriggerShapeT;
		}

		// Token: 0x06016BF3 RID: 93171 RVA: 0x0033FC7B File Offset: 0x0033DE7B
		public void UnPackTo(IVolumeTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.VolumeKey = this.VolumeKey;
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x0033FC98 File Offset: 0x0033DE98
		public static Offset<IVolumeTriggerShape> Pack(FlatBufferBuilder builder, IVolumeTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVolumeTriggerShape>);
			}
			StringOffset volumeKeyOffset = (_o.VolumeKey == null) ? default(StringOffset) : builder.CreateString(_o.VolumeKey);
			return IVolumeTriggerShape.CreateIVolumeTriggerShape(builder, _o.Type, volumeKeyOffset);
		}

		// Token: 0x0400BC3E RID: 48190
		private Table __p;
	}
}
