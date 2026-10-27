using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710C RID: 28940
	public struct ISignalDevice : IFlatbufferObject
	{
		// Token: 0x1700D71F RID: 55071
		// (get) Token: 0x060334DD RID: 210141 RVA: 0x006EA931 File Offset: 0x006E8B31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334DE RID: 210142 RVA: 0x006EA93E File Offset: 0x006E8B3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334DF RID: 210143 RVA: 0x006EA948 File Offset: 0x006E8B48
		public static ISignalDevice GetRootAsISignalDevice(ByteBuffer _bb)
		{
			return ISignalDevice.GetRootAsISignalDevice(_bb, default(ISignalDevice));
		}

		// Token: 0x060334E0 RID: 210144 RVA: 0x006EA964 File Offset: 0x006E8B64
		public static ISignalDevice GetRootAsISignalDevice(ByteBuffer _bb, ISignalDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334E1 RID: 210145 RVA: 0x006EA981 File Offset: 0x006E8B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334E2 RID: 210146 RVA: 0x006EA990 File Offset: 0x006E8B90
		public ISignalDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D720 RID: 55072
		// (get) Token: 0x060334E3 RID: 210147 RVA: 0x006EA9A0 File Offset: 0x006E8BA0
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

		// Token: 0x060334E4 RID: 210148 RVA: 0x006EA9DC File Offset: 0x006E8BDC
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700D721 RID: 55073
		// (get) Token: 0x060334E5 RID: 210149 RVA: 0x006EAA30 File Offset: 0x006E8C30
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

		// Token: 0x060334E6 RID: 210150 RVA: 0x006EAA5B File Offset: 0x006E8C5B
		public static Offset<ISignalDevice> CreateISignalDevice(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISignalDevice.AddConfig(builder, ConfigOffset);
			ISignalDevice.AddType(builder, Type);
			return ISignalDevice.EndISignalDevice(builder);
		}

		// Token: 0x060334E7 RID: 210151 RVA: 0x006EAA78 File Offset: 0x006E8C78
		public static void StartISignalDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060334E8 RID: 210152 RVA: 0x006EAA81 File Offset: 0x006E8C81
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060334E9 RID: 210153 RVA: 0x006EAA8C File Offset: 0x006E8C8C
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x060334EA RID: 210154 RVA: 0x006EAA9C File Offset: 0x006E8C9C
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060334EB RID: 210155 RVA: 0x006EAAA7 File Offset: 0x006E8CA7
		public static Offset<ISignalDevice> EndISignalDevice(FlatBufferBuilder builder)
		{
			return new Offset<ISignalDevice>(builder.EndTable());
		}

		// Token: 0x060334EC RID: 210156 RVA: 0x006EAAB4 File Offset: 0x006E8CB4
		public ISignalDeviceT UnPack()
		{
			ISignalDeviceT signalDeviceT = new ISignalDeviceT();
			this.UnPackTo(signalDeviceT);
			return signalDeviceT;
		}

		// Token: 0x060334ED RID: 210157 RVA: 0x006EAAD0 File Offset: 0x006E8CD0
		public void UnPackTo(ISignalDeviceT _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IColorPieceT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060334EE RID: 210158 RVA: 0x006EAB3C File Offset: 0x006E8D3C
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

		// Token: 0x04011B9A RID: 72602
		private Table __p;
	}
}
