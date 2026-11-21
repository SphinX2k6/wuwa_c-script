using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D8 RID: 30936
	public struct ISignalDevice : IFlatbufferObject
	{
		// Token: 0x1700E302 RID: 58114
		// (get) Token: 0x0603677F RID: 223103 RVA: 0x0074AF3D File Offset: 0x0074913D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036780 RID: 223104 RVA: 0x0074AF4A File Offset: 0x0074914A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036781 RID: 223105 RVA: 0x0074AF54 File Offset: 0x00749154
		public static ISignalDevice GetRootAsISignalDevice(ByteBuffer _bb)
		{
			return ISignalDevice.GetRootAsISignalDevice(_bb, default(ISignalDevice));
		}

		// Token: 0x06036782 RID: 223106 RVA: 0x0074AF70 File Offset: 0x00749170
		public static ISignalDevice GetRootAsISignalDevice(ByteBuffer _bb, ISignalDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036783 RID: 223107 RVA: 0x0074AF8D File Offset: 0x0074918D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036784 RID: 223108 RVA: 0x0074AF9C File Offset: 0x0074919C
		public ISignalDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E303 RID: 58115
		// (get) Token: 0x06036785 RID: 223109 RVA: 0x0074AFAC File Offset: 0x007491AC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036786 RID: 223110 RVA: 0x0074AFE8 File Offset: 0x007491E8
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700E304 RID: 58116
		// (get) Token: 0x06036787 RID: 223111 RVA: 0x0074B03C File Offset: 0x0074923C
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06036788 RID: 223112 RVA: 0x0074B067 File Offset: 0x00749267
		public static Offset<ISignalDevice> CreateISignalDevice(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISignalDevice.AddConfig(builder, ConfigOffset);
			ISignalDevice.AddType(builder, Type);
			return ISignalDevice.EndISignalDevice(builder);
		}

		// Token: 0x06036789 RID: 223113 RVA: 0x0074B084 File Offset: 0x00749284
		public static void StartISignalDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603678A RID: 223114 RVA: 0x0074B08D File Offset: 0x0074928D
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603678B RID: 223115 RVA: 0x0074B098 File Offset: 0x00749298
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0603678C RID: 223116 RVA: 0x0074B0A8 File Offset: 0x007492A8
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603678D RID: 223117 RVA: 0x0074B0B3 File Offset: 0x007492B3
		public static Offset<ISignalDevice> EndISignalDevice(FlatBufferBuilder builder)
		{
			return new Offset<ISignalDevice>(builder.EndTable());
		}

		// Token: 0x0603678E RID: 223118 RVA: 0x0074B0C0 File Offset: 0x007492C0
		public ISignalDeviceT UnPack()
		{
			ISignalDeviceT signalDeviceT = new ISignalDeviceT();
			this.UnPackTo(signalDeviceT);
			return signalDeviceT;
		}

		// Token: 0x0603678F RID: 223119 RVA: 0x0074B0DC File Offset: 0x007492DC
		public void UnPackTo(ISignalDeviceT _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IColorPieceT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036790 RID: 223120 RVA: 0x0074B148 File Offset: 0x00749348
		public static Offset<ISignalDevice> Pack(FlatBufferBuilder builder, ISignalDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISignalDevice>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				ISignalDevice.StartConfigVector(builder, _o.Config.Count);
				for (int i = _o.Config.Count - 1; i >= 0; i--)
				{
					IColorPiece.Pack(builder, _o.Config[i]);
				}
				configOffset = builder.EndVector();
			}
			return ISignalDevice.CreateISignalDevice(builder, _o.Type, configOffset);
		}

		// Token: 0x04012B88 RID: 76680
		private Table __p;
	}
}
