using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BF RID: 22975
	public struct IStateRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700AC66 RID: 44134
		// (get) Token: 0x06026EDB RID: 159451 RVA: 0x0055B037 File Offset: 0x00559237
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026EDC RID: 159452 RVA: 0x0055B044 File Offset: 0x00559244
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026EDD RID: 159453 RVA: 0x0055B04C File Offset: 0x0055924C
		public static IStateRotationConfig GetRootAsIStateRotationConfig(ByteBuffer _bb)
		{
			return IStateRotationConfig.GetRootAsIStateRotationConfig(_bb, default(IStateRotationConfig));
		}

		// Token: 0x06026EDE RID: 159454 RVA: 0x0055B068 File Offset: 0x00559268
		public static IStateRotationConfig GetRootAsIStateRotationConfig(ByteBuffer _bb, IStateRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026EDF RID: 159455 RVA: 0x0055B085 File Offset: 0x00559285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026EE0 RID: 159456 RVA: 0x0055B094 File Offset: 0x00559294
		public IStateRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC67 RID: 44135
		// (get) Token: 0x06026EE1 RID: 159457 RVA: 0x0055B0A4 File Offset: 0x005592A4
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EE2 RID: 159458 RVA: 0x0055B0DB File Offset: 0x005592DB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026EE3 RID: 159459 RVA: 0x0055B0EA File Offset: 0x005592EA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC68 RID: 44136
		// (get) Token: 0x06026EE4 RID: 159460 RVA: 0x0055B0F8 File Offset: 0x005592F8
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC69 RID: 44137
		// (get) Token: 0x06026EE5 RID: 159461 RVA: 0x0055B138 File Offset: 0x00559338
		public IStartRotationConfig? StartRotationConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IStartRotationConfig?(default(IStartRotationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC6A RID: 44138
		// (get) Token: 0x06026EE6 RID: 159462 RVA: 0x0055B198 File Offset: 0x00559398
		public string RotatePoint
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

		// Token: 0x06026EE7 RID: 159463 RVA: 0x0055B1D0 File Offset: 0x005593D0
		public Span<byte> GetRotatePointBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026EE8 RID: 159464 RVA: 0x0055B1E0 File Offset: 0x005593E0
		public byte[] GetRotatePointArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06026EE9 RID: 159465 RVA: 0x0055B1F0 File Offset: 0x005593F0
		public IRotationConfig? RotationConfig(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IRotationConfig?(default(IRotationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC6B RID: 44139
		// (get) Token: 0x06026EEA RID: 159466 RVA: 0x0055B254 File Offset: 0x00559454
		public int RotationConfigLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026EEB RID: 159467 RVA: 0x0055B280 File Offset: 0x00559480
		public IKeyRotatorConfig? KeyRotatorConfig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IKeyRotatorConfig?(default(IKeyRotatorConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC6C RID: 44140
		// (get) Token: 0x06026EEC RID: 159468 RVA: 0x0055B2E4 File Offset: 0x005594E4
		public int KeyRotatorConfigLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AC6D RID: 44141
		// (get) Token: 0x06026EED RID: 159469 RVA: 0x0055B310 File Offset: 0x00559510
		public bool KeepLastRotation
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC6E RID: 44142
		// (get) Token: 0x06026EEE RID: 159470 RVA: 0x0055B350 File Offset: 0x00559550
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EEF RID: 159471 RVA: 0x0055B390 File Offset: 0x00559590
		public static Offset<IStateRotationConfig> CreateIStateRotationConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), bool IsLoop = false, Offset<IStartRotationConfig> StartRotationConfigOffset = default(Offset<IStartRotationConfig>), StringOffset RotatePointOffset = default(StringOffset), VectorOffset RotationConfigOffset = default(VectorOffset), VectorOffset KeyRotatorConfigOffset = default(VectorOffset), bool KeepLastRotation = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IStateRotationConfig.AddKeyRotatorConfig(builder, KeyRotatorConfigOffset);
			IStateRotationConfig.AddRotationConfig(builder, RotationConfigOffset);
			IStateRotationConfig.AddRotatePoint(builder, RotatePointOffset);
			IStateRotationConfig.AddStartRotationConfig(builder, StartRotationConfigOffset);
			IStateRotationConfig.AddState(builder, StateOffset);
			IStateRotationConfig.AddNullMask(builder, NullMask);
			IStateRotationConfig.AddKeepLastRotation(builder, KeepLastRotation);
			IStateRotationConfig.AddIsLoop(builder, IsLoop);
			return IStateRotationConfig.EndIStateRotationConfig(builder);
		}

		// Token: 0x06026EF0 RID: 159472 RVA: 0x0055B3E7 File Offset: 0x005595E7
		public static void StartIStateRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06026EF1 RID: 159473 RVA: 0x0055B3F0 File Offset: 0x005595F0
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026EF2 RID: 159474 RVA: 0x0055B400 File Offset: 0x00559600
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(1, isLoop, false);
		}

		// Token: 0x06026EF3 RID: 159475 RVA: 0x0055B40B File Offset: 0x0055960B
		public static void AddStartRotationConfig(FlatBufferBuilder builder, Offset<IStartRotationConfig> startRotationConfigOffset)
		{
			builder.AddOffset(2, startRotationConfigOffset.Value, 0);
		}

		// Token: 0x06026EF4 RID: 159476 RVA: 0x0055B41B File Offset: 0x0055961B
		public static void AddRotatePoint(FlatBufferBuilder builder, StringOffset rotatePointOffset)
		{
			builder.AddOffset(3, rotatePointOffset.Value, 0);
		}

		// Token: 0x06026EF5 RID: 159477 RVA: 0x0055B42B File Offset: 0x0055962B
		public static void AddRotationConfig(FlatBufferBuilder builder, VectorOffset rotationConfigOffset)
		{
			builder.AddOffset(4, rotationConfigOffset.Value, 0);
		}

		// Token: 0x06026EF6 RID: 159478 RVA: 0x0055B43C File Offset: 0x0055963C
		public static VectorOffset CreateRotationConfigVector(FlatBufferBuilder builder, Offset<IRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026EF7 RID: 159479 RVA: 0x0055B47C File Offset: 0x0055967C
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, Offset<IRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EF8 RID: 159480 RVA: 0x0055B496 File Offset: 0x00559696
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRotationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EF9 RID: 159481 RVA: 0x0055B4B4 File Offset: 0x005596B4
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRotationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026EFA RID: 159482 RVA: 0x0055B4CD File Offset: 0x005596CD
		public static void StartRotationConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026EFB RID: 159483 RVA: 0x0055B4D8 File Offset: 0x005596D8
		public static void AddKeyRotatorConfig(FlatBufferBuilder builder, VectorOffset keyRotatorConfigOffset)
		{
			builder.AddOffset(5, keyRotatorConfigOffset.Value, 0);
		}

		// Token: 0x06026EFC RID: 159484 RVA: 0x0055B4E8 File Offset: 0x005596E8
		public static VectorOffset CreateKeyRotatorConfigVector(FlatBufferBuilder builder, Offset<IKeyRotatorConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026EFD RID: 159485 RVA: 0x0055B528 File Offset: 0x00559728
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, Offset<IKeyRotatorConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKeyRotatorConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EFE RID: 159486 RVA: 0x0055B542 File Offset: 0x00559742
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKeyRotatorConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKeyRotatorConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EFF RID: 159487 RVA: 0x0055B560 File Offset: 0x00559760
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKeyRotatorConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026F00 RID: 159488 RVA: 0x0055B579 File Offset: 0x00559779
		public static void StartKeyRotatorConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026F01 RID: 159489 RVA: 0x0055B584 File Offset: 0x00559784
		public static void AddKeepLastRotation(FlatBufferBuilder builder, bool keepLastRotation)
		{
			builder.AddBool(6, keepLastRotation, false);
		}

		// Token: 0x06026F02 RID: 159490 RVA: 0x0055B58F File Offset: 0x0055978F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06026F03 RID: 159491 RVA: 0x0055B59A File Offset: 0x0055979A
		public static Offset<IStateRotationConfig> EndIStateRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateRotationConfig>(builder.EndTable());
		}

		// Token: 0x06026F04 RID: 159492 RVA: 0x0055B5A8 File Offset: 0x005597A8
		public IStateRotationConfigT UnPack()
		{
			IStateRotationConfigT stateRotationConfigT = new IStateRotationConfigT();
			this.UnPackTo(stateRotationConfigT);
			return stateRotationConfigT;
		}

		// Token: 0x06026F05 RID: 159493 RVA: 0x0055B5C4 File Offset: 0x005597C4
		public void UnPackTo(IStateRotationConfigT _o)
		{
			_o.State = this.State;
			_o.IsLoop = this.IsLoop;
			_o.StartRotationConfig = ((this.StartRotationConfig != null) ? this.StartRotationConfig.Value.UnPack() : null);
			_o.RotatePoint = this.RotatePoint;
			_o.RotationConfig = new List<IRotationConfigT>();
			for (int i = 0; i < this.RotationConfigLength; i++)
			{
				_o.RotationConfig.Add((this.RotationConfig(i) != null) ? this.RotationConfig(i).Value.UnPack() : null);
			}
			_o.KeyRotatorConfig = new List<IKeyRotatorConfigT>();
			for (int j = 0; j < this.KeyRotatorConfigLength; j++)
			{
				_o.KeyRotatorConfig.Add((this.KeyRotatorConfig(j) != null) ? this.KeyRotatorConfig(j).Value.UnPack() : null);
			}
			_o.KeepLastRotation = this.KeepLastRotation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026F06 RID: 159494 RVA: 0x0055B6EC File Offset: 0x005598EC
		public static Offset<IStateRotationConfig> Pack(FlatBufferBuilder builder, IStateRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRotationConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			Offset<IStartRotationConfig> startRotationConfigOffset = (_o.StartRotationConfig == null) ? default(Offset<IStartRotationConfig>) : IStartRotationConfig.Pack(builder, _o.StartRotationConfig);
			StringOffset rotatePointOffset = (_o.RotatePoint == null) ? default(StringOffset) : builder.CreateString(_o.RotatePoint);
			VectorOffset rotationConfigOffset = default(VectorOffset);
			if (_o.RotationConfig != null)
			{
				Offset<IRotationConfig>[] array = new Offset<IRotationConfig>[_o.RotationConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRotationConfig.Pack(builder, _o.RotationConfig[i]);
				}
				rotationConfigOffset = IStateRotationConfig.CreateRotationConfigVector(builder, array);
			}
			VectorOffset keyRotatorConfigOffset = default(VectorOffset);
			if (_o.KeyRotatorConfig != null)
			{
				Offset<IKeyRotatorConfig>[] array2 = new Offset<IKeyRotatorConfig>[_o.KeyRotatorConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IKeyRotatorConfig.Pack(builder, _o.KeyRotatorConfig[j]);
				}
				keyRotatorConfigOffset = IStateRotationConfig.CreateKeyRotatorConfigVector(builder, array2);
			}
			return IStateRotationConfig.CreateIStateRotationConfig(builder, stateOffset, _o.IsLoop, startRotationConfigOffset, rotatePointOffset, rotationConfigOffset, keyRotatorConfigOffset, _o.KeepLastRotation, _o.NullMask);
		}

		// Token: 0x0400EFD3 RID: 61395
		private Table __p;
	}
}
