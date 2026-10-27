using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C73 RID: 15475
	public struct IVolumeTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006AB9 RID: 27321
		// (get) Token: 0x060156AF RID: 87727 RVA: 0x00318928 File Offset: 0x00316B28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060156B0 RID: 87728 RVA: 0x00318935 File Offset: 0x00316B35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060156B1 RID: 87729 RVA: 0x0031893C File Offset: 0x00316B3C
		public static IVolumeTriggerShape GetRootAsIVolumeTriggerShape(ByteBuffer _bb)
		{
			return IVolumeTriggerShape.GetRootAsIVolumeTriggerShape(_bb, default(IVolumeTriggerShape));
		}

		// Token: 0x060156B2 RID: 87730 RVA: 0x00318958 File Offset: 0x00316B58
		public static IVolumeTriggerShape GetRootAsIVolumeTriggerShape(ByteBuffer _bb, IVolumeTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060156B3 RID: 87731 RVA: 0x00318975 File Offset: 0x00316B75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060156B4 RID: 87732 RVA: 0x00318984 File Offset: 0x00316B84
		public IVolumeTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ABA RID: 27322
		// (get) Token: 0x060156B5 RID: 87733 RVA: 0x00318994 File Offset: 0x00316B94
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

		// Token: 0x17006ABB RID: 27323
		// (get) Token: 0x060156B6 RID: 87734 RVA: 0x003189D0 File Offset: 0x00316BD0
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

		// Token: 0x060156B7 RID: 87735 RVA: 0x00318A07 File Offset: 0x00316C07
		public Span<byte> GetVolumeKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060156B8 RID: 87736 RVA: 0x00318A16 File Offset: 0x00316C16
		public byte[] GetVolumeKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060156B9 RID: 87737 RVA: 0x00318A24 File Offset: 0x00316C24
		public static Offset<IVolumeTriggerShape> CreateIVolumeTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, StringOffset VolumeKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVolumeTriggerShape.AddVolumeKey(builder, VolumeKeyOffset);
			IVolumeTriggerShape.AddType(builder, Type);
			return IVolumeTriggerShape.EndIVolumeTriggerShape(builder);
		}

		// Token: 0x060156BA RID: 87738 RVA: 0x00318A41 File Offset: 0x00316C41
		public static void StartIVolumeTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060156BB RID: 87739 RVA: 0x00318A4A File Offset: 0x00316C4A
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060156BC RID: 87740 RVA: 0x00318A55 File Offset: 0x00316C55
		public static void AddVolumeKey(FlatBufferBuilder builder, StringOffset volumeKeyOffset)
		{
			builder.AddOffset(1, volumeKeyOffset.Value, 0);
		}

		// Token: 0x060156BD RID: 87741 RVA: 0x00318A65 File Offset: 0x00316C65
		public static Offset<IVolumeTriggerShape> EndIVolumeTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IVolumeTriggerShape>(builder.EndTable());
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x00318A74 File Offset: 0x00316C74
		public IVolumeTriggerShapeT UnPack()
		{
			IVolumeTriggerShapeT volumeTriggerShapeT = new IVolumeTriggerShapeT();
			this.UnPackTo(volumeTriggerShapeT);
			return volumeTriggerShapeT;
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x00318A8F File Offset: 0x00316C8F
		public void UnPackTo(IVolumeTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.VolumeKey = this.VolumeKey;
		}

		// Token: 0x060156C0 RID: 87744 RVA: 0x00318AAC File Offset: 0x00316CAC
		public static Offset<IVolumeTriggerShape> Pack(FlatBufferBuilder builder, IVolumeTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVolumeTriggerShape>);
			}
			StringOffset volumeKeyOffset = (_o.VolumeKey == null) ? default(StringOffset) : builder.CreateString(_o.VolumeKey);
			return IVolumeTriggerShape.CreateIVolumeTriggerShape(builder, _o.Type, volumeKeyOffset);
		}

		// Token: 0x0400B2A9 RID: 45737
		private Table __p;
	}
}
