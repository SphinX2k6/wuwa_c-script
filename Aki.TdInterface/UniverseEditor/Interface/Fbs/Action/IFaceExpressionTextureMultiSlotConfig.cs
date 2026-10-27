using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006756 RID: 26454
	public struct IFaceExpressionTextureMultiSlotConfig : IFlatbufferObject
	{
		// Token: 0x1700C462 RID: 50274
		// (get) Token: 0x0602E047 RID: 188487 RVA: 0x00649EAA File Offset: 0x006480AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E048 RID: 188488 RVA: 0x00649EB7 File Offset: 0x006480B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E049 RID: 188489 RVA: 0x00649EC0 File Offset: 0x006480C0
		public static IFaceExpressionTextureMultiSlotConfig GetRootAsIFaceExpressionTextureMultiSlotConfig(ByteBuffer _bb)
		{
			return IFaceExpressionTextureMultiSlotConfig.GetRootAsIFaceExpressionTextureMultiSlotConfig(_bb, default(IFaceExpressionTextureMultiSlotConfig));
		}

		// Token: 0x0602E04A RID: 188490 RVA: 0x00649EDC File Offset: 0x006480DC
		public static IFaceExpressionTextureMultiSlotConfig GetRootAsIFaceExpressionTextureMultiSlotConfig(ByteBuffer _bb, IFaceExpressionTextureMultiSlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E04B RID: 188491 RVA: 0x00649EF9 File Offset: 0x006480F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E04C RID: 188492 RVA: 0x00649F08 File Offset: 0x00648108
		public IFaceExpressionTextureMultiSlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C463 RID: 50275
		// (get) Token: 0x0602E04D RID: 188493 RVA: 0x00649F18 File Offset: 0x00648118
		public EFaceExpressionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return (EFaceExpressionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C464 RID: 50276
		// (get) Token: 0x0602E04E RID: 188494 RVA: 0x00649F54 File Offset: 0x00648154
		public int SlotIndex
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

		// Token: 0x1700C465 RID: 50277
		// (get) Token: 0x0602E04F RID: 188495 RVA: 0x00649F90 File Offset: 0x00648190
		public int FaceIndex
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

		// Token: 0x0602E050 RID: 188496 RVA: 0x00649FCC File Offset: 0x006481CC
		public static Offset<IFaceExpressionTextureMultiSlotConfig> CreateIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, int SlotIndex = 0, int FaceIndex = 0)
		{
			builder.StartTable(3);
			IFaceExpressionTextureMultiSlotConfig.AddFaceIndex(builder, FaceIndex);
			IFaceExpressionTextureMultiSlotConfig.AddSlotIndex(builder, SlotIndex);
			IFaceExpressionTextureMultiSlotConfig.AddType(builder, Type);
			return IFaceExpressionTextureMultiSlotConfig.EndIFaceExpressionTextureMultiSlotConfig(builder);
		}

		// Token: 0x0602E051 RID: 188497 RVA: 0x00649FF0 File Offset: 0x006481F0
		public static void StartIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E052 RID: 188498 RVA: 0x00649FF9 File Offset: 0x006481F9
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E053 RID: 188499 RVA: 0x0064A004 File Offset: 0x00648204
		public static void AddSlotIndex(FlatBufferBuilder builder, int slotIndex)
		{
			builder.AddInt(1, slotIndex, 0);
		}

		// Token: 0x0602E054 RID: 188500 RVA: 0x0064A00F File Offset: 0x0064820F
		public static void AddFaceIndex(FlatBufferBuilder builder, int faceIndex)
		{
			builder.AddInt(2, faceIndex, 0);
		}

		// Token: 0x0602E055 RID: 188501 RVA: 0x0064A01A File Offset: 0x0064821A
		public static Offset<IFaceExpressionTextureMultiSlotConfig> EndIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionTextureMultiSlotConfig>(builder.EndTable());
		}

		// Token: 0x0602E056 RID: 188502 RVA: 0x0064A028 File Offset: 0x00648228
		public IFaceExpressionTextureMultiSlotConfigT UnPack()
		{
			IFaceExpressionTextureMultiSlotConfigT faceExpressionTextureMultiSlotConfigT = new IFaceExpressionTextureMultiSlotConfigT();
			this.UnPackTo(faceExpressionTextureMultiSlotConfigT);
			return faceExpressionTextureMultiSlotConfigT;
		}

		// Token: 0x0602E057 RID: 188503 RVA: 0x0064A043 File Offset: 0x00648243
		public void UnPackTo(IFaceExpressionTextureMultiSlotConfigT _o)
		{
			_o.Type = this.Type;
			_o.SlotIndex = this.SlotIndex;
			_o.FaceIndex = this.FaceIndex;
		}

		// Token: 0x0602E058 RID: 188504 RVA: 0x0064A06C File Offset: 0x0064826C
		public static Offset<IFaceExpressionTextureMultiSlotConfig> Pack(FlatBufferBuilder builder, IFaceExpressionTextureMultiSlotConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionTextureMultiSlotConfig>);
			}
			return IFaceExpressionTextureMultiSlotConfig.CreateIFaceExpressionTextureMultiSlotConfig(builder, _o.Type, _o.SlotIndex, _o.FaceIndex);
		}

		// Token: 0x04010E48 RID: 69192
		private Table __p;
	}
}
