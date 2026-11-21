using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FCC RID: 24524
	public struct IStateRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700B59A RID: 46490
		// (get) Token: 0x06029445 RID: 169029 RVA: 0x005A1CA3 File Offset: 0x0059FEA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029446 RID: 169030 RVA: 0x005A1CB0 File Offset: 0x0059FEB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029447 RID: 169031 RVA: 0x005A1CB8 File Offset: 0x0059FEB8
		public static IStateRotationConfig GetRootAsIStateRotationConfig(ByteBuffer _bb)
		{
			return IStateRotationConfig.GetRootAsIStateRotationConfig(_bb, default(IStateRotationConfig));
		}

		// Token: 0x06029448 RID: 169032 RVA: 0x005A1CD4 File Offset: 0x0059FED4
		public static IStateRotationConfig GetRootAsIStateRotationConfig(ByteBuffer _bb, IStateRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029449 RID: 169033 RVA: 0x005A1CF1 File Offset: 0x0059FEF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602944A RID: 169034 RVA: 0x005A1D00 File Offset: 0x0059FF00
		public IStateRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B59B RID: 46491
		// (get) Token: 0x0602944B RID: 169035 RVA: 0x005A1D10 File Offset: 0x0059FF10
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

		// Token: 0x0602944C RID: 169036 RVA: 0x005A1D47 File Offset: 0x0059FF47
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602944D RID: 169037 RVA: 0x005A1D56 File Offset: 0x0059FF56
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B59C RID: 46492
		// (get) Token: 0x0602944E RID: 169038 RVA: 0x005A1D64 File Offset: 0x0059FF64
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B59D RID: 46493
		// (get) Token: 0x0602944F RID: 169039 RVA: 0x005A1DA4 File Offset: 0x0059FFA4
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

		// Token: 0x1700B59E RID: 46494
		// (get) Token: 0x06029450 RID: 169040 RVA: 0x005A1E04 File Offset: 0x005A0004
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

		// Token: 0x06029451 RID: 169041 RVA: 0x005A1E3C File Offset: 0x005A003C
		public Span<byte> GetRotatePointBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06029452 RID: 169042 RVA: 0x005A1E4C File Offset: 0x005A004C
		public byte[] GetRotatePointArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06029453 RID: 169043 RVA: 0x005A1E5C File Offset: 0x005A005C
		public IRotationConfig? RotationConfig(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IRotationConfig?(default(IRotationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B59F RID: 46495
		// (get) Token: 0x06029454 RID: 169044 RVA: 0x005A1EC0 File Offset: 0x005A00C0
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

		// Token: 0x06029455 RID: 169045 RVA: 0x005A1EEC File Offset: 0x005A00EC
		public IKeyRotatorConfig? KeyRotatorConfig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IKeyRotatorConfig?(default(IKeyRotatorConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5A0 RID: 46496
		// (get) Token: 0x06029456 RID: 169046 RVA: 0x005A1F50 File Offset: 0x005A0150
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

		// Token: 0x06029457 RID: 169047 RVA: 0x005A1F7C File Offset: 0x005A017C
		public IAxisAngleMethodConfig? AxisAngleMethodConfig(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IAxisAngleMethodConfig?(default(IAxisAngleMethodConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5A1 RID: 46497
		// (get) Token: 0x06029458 RID: 169048 RVA: 0x005A1FE0 File Offset: 0x005A01E0
		public int AxisAngleMethodConfigLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B5A2 RID: 46498
		// (get) Token: 0x06029459 RID: 169049 RVA: 0x005A200C File Offset: 0x005A020C
		public bool KeepLastRotation
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5A3 RID: 46499
		// (get) Token: 0x0602945A RID: 169050 RVA: 0x005A204C File Offset: 0x005A024C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602945B RID: 169051 RVA: 0x005A208C File Offset: 0x005A028C
		public static Offset<IStateRotationConfig> CreateIStateRotationConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), bool IsLoop = false, Offset<IStartRotationConfig> StartRotationConfigOffset = default(Offset<IStartRotationConfig>), StringOffset RotatePointOffset = default(StringOffset), VectorOffset RotationConfigOffset = default(VectorOffset), VectorOffset KeyRotatorConfigOffset = default(VectorOffset), VectorOffset AxisAngleMethodConfigOffset = default(VectorOffset), bool KeepLastRotation = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			IStateRotationConfig.AddAxisAngleMethodConfig(builder, AxisAngleMethodConfigOffset);
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

		// Token: 0x0602945C RID: 169052 RVA: 0x005A20EC File Offset: 0x005A02EC
		public static void StartIStateRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602945D RID: 169053 RVA: 0x005A20F6 File Offset: 0x005A02F6
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602945E RID: 169054 RVA: 0x005A2106 File Offset: 0x005A0306
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(1, isLoop, false);
		}

		// Token: 0x0602945F RID: 169055 RVA: 0x005A2111 File Offset: 0x005A0311
		public static void AddStartRotationConfig(FlatBufferBuilder builder, Offset<IStartRotationConfig> startRotationConfigOffset)
		{
			builder.AddOffset(2, startRotationConfigOffset.Value, 0);
		}

		// Token: 0x06029460 RID: 169056 RVA: 0x005A2121 File Offset: 0x005A0321
		public static void AddRotatePoint(FlatBufferBuilder builder, StringOffset rotatePointOffset)
		{
			builder.AddOffset(3, rotatePointOffset.Value, 0);
		}

		// Token: 0x06029461 RID: 169057 RVA: 0x005A2131 File Offset: 0x005A0331
		public static void AddRotationConfig(FlatBufferBuilder builder, VectorOffset rotationConfigOffset)
		{
			builder.AddOffset(4, rotationConfigOffset.Value, 0);
		}

		// Token: 0x06029462 RID: 169058 RVA: 0x005A2144 File Offset: 0x005A0344
		public static VectorOffset CreateRotationConfigVector(FlatBufferBuilder builder, Offset<IRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029463 RID: 169059 RVA: 0x005A2184 File Offset: 0x005A0384
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, Offset<IRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029464 RID: 169060 RVA: 0x005A219E File Offset: 0x005A039E
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRotationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029465 RID: 169061 RVA: 0x005A21BC File Offset: 0x005A03BC
		public static VectorOffset CreateRotationConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRotationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029466 RID: 169062 RVA: 0x005A21D5 File Offset: 0x005A03D5
		public static void StartRotationConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029467 RID: 169063 RVA: 0x005A21E0 File Offset: 0x005A03E0
		public static void AddKeyRotatorConfig(FlatBufferBuilder builder, VectorOffset keyRotatorConfigOffset)
		{
			builder.AddOffset(5, keyRotatorConfigOffset.Value, 0);
		}

		// Token: 0x06029468 RID: 169064 RVA: 0x005A21F0 File Offset: 0x005A03F0
		public static VectorOffset CreateKeyRotatorConfigVector(FlatBufferBuilder builder, Offset<IKeyRotatorConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029469 RID: 169065 RVA: 0x005A2230 File Offset: 0x005A0430
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, Offset<IKeyRotatorConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IKeyRotatorConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602946A RID: 169066 RVA: 0x005A224A File Offset: 0x005A044A
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IKeyRotatorConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IKeyRotatorConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602946B RID: 169067 RVA: 0x005A2268 File Offset: 0x005A0468
		public static VectorOffset CreateKeyRotatorConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IKeyRotatorConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602946C RID: 169068 RVA: 0x005A2281 File Offset: 0x005A0481
		public static void StartKeyRotatorConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602946D RID: 169069 RVA: 0x005A228C File Offset: 0x005A048C
		public static void AddAxisAngleMethodConfig(FlatBufferBuilder builder, VectorOffset axisAngleMethodConfigOffset)
		{
			builder.AddOffset(6, axisAngleMethodConfigOffset.Value, 0);
		}

		// Token: 0x0602946E RID: 169070 RVA: 0x005A229C File Offset: 0x005A049C
		public static VectorOffset CreateAxisAngleMethodConfigVector(FlatBufferBuilder builder, Offset<IAxisAngleMethodConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602946F RID: 169071 RVA: 0x005A22DC File Offset: 0x005A04DC
		public static VectorOffset CreateAxisAngleMethodConfigVectorBlock(FlatBufferBuilder builder, Offset<IAxisAngleMethodConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAxisAngleMethodConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029470 RID: 169072 RVA: 0x005A22F6 File Offset: 0x005A04F6
		public static VectorOffset CreateAxisAngleMethodConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAxisAngleMethodConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAxisAngleMethodConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029471 RID: 169073 RVA: 0x005A2314 File Offset: 0x005A0514
		public static VectorOffset CreateAxisAngleMethodConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAxisAngleMethodConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029472 RID: 169074 RVA: 0x005A232D File Offset: 0x005A052D
		public static void StartAxisAngleMethodConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029473 RID: 169075 RVA: 0x005A2338 File Offset: 0x005A0538
		public static void AddKeepLastRotation(FlatBufferBuilder builder, bool keepLastRotation)
		{
			builder.AddBool(7, keepLastRotation, false);
		}

		// Token: 0x06029474 RID: 169076 RVA: 0x005A2343 File Offset: 0x005A0543
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029475 RID: 169077 RVA: 0x005A234E File Offset: 0x005A054E
		public static Offset<IStateRotationConfig> EndIStateRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateRotationConfig>(builder.EndTable());
		}

		// Token: 0x06029476 RID: 169078 RVA: 0x005A235C File Offset: 0x005A055C
		public IStateRotationConfigT UnPack()
		{
			IStateRotationConfigT stateRotationConfigT = new IStateRotationConfigT();
			this.UnPackTo(stateRotationConfigT);
			return stateRotationConfigT;
		}

		// Token: 0x06029477 RID: 169079 RVA: 0x005A2378 File Offset: 0x005A0578
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
			_o.AxisAngleMethodConfig = new List<IAxisAngleMethodConfigT>();
			for (int k = 0; k < this.AxisAngleMethodConfigLength; k++)
			{
				_o.AxisAngleMethodConfig.Add((this.AxisAngleMethodConfig(k) != null) ? this.AxisAngleMethodConfig(k).Value.UnPack() : null);
			}
			_o.KeepLastRotation = this.KeepLastRotation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029478 RID: 169080 RVA: 0x005A24FC File Offset: 0x005A06FC
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
			VectorOffset axisAngleMethodConfigOffset = default(VectorOffset);
			if (_o.AxisAngleMethodConfig != null)
			{
				Offset<IAxisAngleMethodConfig>[] array3 = new Offset<IAxisAngleMethodConfig>[_o.AxisAngleMethodConfig.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IAxisAngleMethodConfig.Pack(builder, _o.AxisAngleMethodConfig[k]);
				}
				axisAngleMethodConfigOffset = IStateRotationConfig.CreateAxisAngleMethodConfigVector(builder, array3);
			}
			return IStateRotationConfig.CreateIStateRotationConfig(builder, stateOffset, _o.IsLoop, startRotationConfigOffset, rotatePointOffset, rotationConfigOffset, keyRotatorConfigOffset, axisAngleMethodConfigOffset, _o.KeepLastRotation, _o.NullMask);
		}

		// Token: 0x0400FCC8 RID: 64712
		private Table __p;
	}
}
