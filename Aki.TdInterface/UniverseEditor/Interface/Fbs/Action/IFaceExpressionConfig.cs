using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006747 RID: 26439
	public struct IFaceExpressionConfig : IFlatbufferObject
	{
		// Token: 0x1700C448 RID: 50248
		// (get) Token: 0x0602DFC5 RID: 188357 RVA: 0x00648E45 File Offset: 0x00647045
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFC6 RID: 188358 RVA: 0x00648E52 File Offset: 0x00647052
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFC7 RID: 188359 RVA: 0x00648E5C File Offset: 0x0064705C
		public static IFaceExpressionConfig GetRootAsIFaceExpressionConfig(ByteBuffer _bb)
		{
			return IFaceExpressionConfig.GetRootAsIFaceExpressionConfig(_bb, default(IFaceExpressionConfig));
		}

		// Token: 0x0602DFC8 RID: 188360 RVA: 0x00648E78 File Offset: 0x00647078
		public static IFaceExpressionConfig GetRootAsIFaceExpressionConfig(ByteBuffer _bb, IFaceExpressionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFC9 RID: 188361 RVA: 0x00648E95 File Offset: 0x00647095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFCA RID: 188362 RVA: 0x00648EA4 File Offset: 0x006470A4
		public IFaceExpressionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C449 RID: 50249
		// (get) Token: 0x0602DFCB RID: 188363 RVA: 0x00648EB4 File Offset: 0x006470B4
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

		// Token: 0x0602DFCC RID: 188364 RVA: 0x00648EF0 File Offset: 0x006470F0
		public static Offset<IFaceExpressionConfig> CreateIFaceExpressionConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph)
		{
			builder.StartTable(1);
			IFaceExpressionConfig.AddType(builder, Type);
			return IFaceExpressionConfig.EndIFaceExpressionConfig(builder);
		}

		// Token: 0x0602DFCD RID: 188365 RVA: 0x00648F06 File Offset: 0x00647106
		public static void StartIFaceExpressionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DFCE RID: 188366 RVA: 0x00648F0F File Offset: 0x0064710F
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DFCF RID: 188367 RVA: 0x00648F1A File Offset: 0x0064711A
		public static Offset<IFaceExpressionConfig> EndIFaceExpressionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionConfig>(builder.EndTable());
		}

		// Token: 0x0602DFD0 RID: 188368 RVA: 0x00648F28 File Offset: 0x00647128
		public IFaceExpressionConfigT UnPack()
		{
			IFaceExpressionConfigT faceExpressionConfigT = new IFaceExpressionConfigT();
			this.UnPackTo(faceExpressionConfigT);
			return faceExpressionConfigT;
		}

		// Token: 0x0602DFD1 RID: 188369 RVA: 0x00648F43 File Offset: 0x00647143
		public void UnPackTo(IFaceExpressionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DFD2 RID: 188370 RVA: 0x00648F54 File Offset: 0x00647154
		public static Offset<IFaceExpressionConfig> Pack(FlatBufferBuilder builder, IFaceExpressionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionConfig>);
			}
			return IFaceExpressionConfig.CreateIFaceExpressionConfig(builder, _o.Type);
		}

		// Token: 0x04010E31 RID: 69169
		private Table __p;
	}
}
