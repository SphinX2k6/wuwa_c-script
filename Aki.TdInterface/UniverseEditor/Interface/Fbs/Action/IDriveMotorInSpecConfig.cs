using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C83 RID: 27779
	public struct IDriveMotorInSpecConfig : IFlatbufferObject
	{
		// Token: 0x1700CBC4 RID: 52164
		// (get) Token: 0x0602FDC2 RID: 196034 RVA: 0x0068453C File Offset: 0x0068273C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDC3 RID: 196035 RVA: 0x00684549 File Offset: 0x00682749
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDC4 RID: 196036 RVA: 0x00684550 File Offset: 0x00682750
		public static IDriveMotorInSpecConfig GetRootAsIDriveMotorInSpecConfig(ByteBuffer _bb)
		{
			return IDriveMotorInSpecConfig.GetRootAsIDriveMotorInSpecConfig(_bb, default(IDriveMotorInSpecConfig));
		}

		// Token: 0x0602FDC5 RID: 196037 RVA: 0x0068456C File Offset: 0x0068276C
		public static IDriveMotorInSpecConfig GetRootAsIDriveMotorInSpecConfig(ByteBuffer _bb, IDriveMotorInSpecConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDC6 RID: 196038 RVA: 0x00684589 File Offset: 0x00682789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDC7 RID: 196039 RVA: 0x00684598 File Offset: 0x00682798
		public IDriveMotorInSpecConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBC5 RID: 52165
		// (get) Token: 0x0602FDC8 RID: 196040 RVA: 0x006845A8 File Offset: 0x006827A8
		public TMotorParamsChangeConfig MotorParamsChangeConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TMotorParamsChangeConfig.NONE;
				}
				return (TMotorParamsChangeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FDC9 RID: 196041 RVA: 0x006845E4 File Offset: 0x006827E4
		public TTable? MotorParamsChangeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FDCA RID: 196042 RVA: 0x00684628 File Offset: 0x00682828
		public IMotorSpeedDownConfig MotorParamsChangeConfigAsIMotorSpeedDownConfig()
		{
			return this.MotorParamsChangeConfig<IMotorSpeedDownConfig>().Value;
		}

		// Token: 0x0602FDCB RID: 196043 RVA: 0x00684644 File Offset: 0x00682844
		public IMotorSpeedUpConfig MotorParamsChangeConfigAsIMotorSpeedUpConfig()
		{
			return this.MotorParamsChangeConfig<IMotorSpeedUpConfig>().Value;
		}

		// Token: 0x1700CBC6 RID: 52166
		// (get) Token: 0x0602FDCC RID: 196044 RVA: 0x00684660 File Offset: 0x00682860
		public bool IsEnableNitrogen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FDCD RID: 196045 RVA: 0x006846A0 File Offset: 0x006828A0
		public EPlayerInputConstraintType DisableInput(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return EPlayerInputConstraintType.Left;
			}
			return (EPlayerInputConstraintType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700CBC7 RID: 52167
		// (get) Token: 0x0602FDCE RID: 196046 RVA: 0x006846E0 File Offset: 0x006828E0
		public int DisableInputLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602FDCF RID: 196047 RVA: 0x0068470C File Offset: 0x0068290C
		public Span<EPlayerInputConstraintType> GetDisableInputBytes()
		{
			return this.__p.__vector_as_span<EPlayerInputConstraintType>(10, 1);
		}

		// Token: 0x0602FDD0 RID: 196048 RVA: 0x0068471C File Offset: 0x0068291C
		public EPlayerInputConstraintType[] GetDisableInputArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EPlayerInputConstraintType[] array = new EPlayerInputConstraintType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EPlayerInputConstraintType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700CBC8 RID: 52168
		// (get) Token: 0x0602FDD1 RID: 196049 RVA: 0x00684788 File Offset: 0x00682988
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBC9 RID: 52169
		// (get) Token: 0x0602FDD2 RID: 196050 RVA: 0x006847CC File Offset: 0x006829CC
		public bool IsAffectedByTimeStop
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CBCA RID: 52170
		// (get) Token: 0x0602FDD3 RID: 196051 RVA: 0x0068480C File Offset: 0x00682A0C
		public bool CanBeInterrupted
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CBCB RID: 52171
		// (get) Token: 0x0602FDD4 RID: 196052 RVA: 0x0068484C File Offset: 0x00682A4C
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

		// Token: 0x0602FDD5 RID: 196053 RVA: 0x0068488C File Offset: 0x00682A8C
		public static Offset<IDriveMotorInSpecConfig> CreateIDriveMotorInSpecConfig(FlatBufferBuilder builder, TMotorParamsChangeConfig MotorParamsChangeConfig_type = TMotorParamsChangeConfig.NONE, int MotorParamsChangeConfigOffset = 0, bool IsEnableNitrogen = false, VectorOffset DisableInputOffset = default(VectorOffset), float Duration = 0f, bool IsAffectedByTimeStop = false, bool CanBeInterrupted = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IDriveMotorInSpecConfig.AddDuration(builder, Duration);
			IDriveMotorInSpecConfig.AddDisableInput(builder, DisableInputOffset);
			IDriveMotorInSpecConfig.AddMotorParamsChangeConfig(builder, MotorParamsChangeConfigOffset);
			IDriveMotorInSpecConfig.AddNullMask(builder, NullMask);
			IDriveMotorInSpecConfig.AddCanBeInterrupted(builder, CanBeInterrupted);
			IDriveMotorInSpecConfig.AddIsAffectedByTimeStop(builder, IsAffectedByTimeStop);
			IDriveMotorInSpecConfig.AddIsEnableNitrogen(builder, IsEnableNitrogen);
			IDriveMotorInSpecConfig.AddMotorParamsChangeConfigType(builder, MotorParamsChangeConfig_type);
			return IDriveMotorInSpecConfig.EndIDriveMotorInSpecConfig(builder);
		}

		// Token: 0x0602FDD6 RID: 196054 RVA: 0x006848E3 File Offset: 0x00682AE3
		public static void StartIDriveMotorInSpecConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602FDD7 RID: 196055 RVA: 0x006848EC File Offset: 0x00682AEC
		public static void AddMotorParamsChangeConfigType(FlatBufferBuilder builder, TMotorParamsChangeConfig motorParamsChangeConfigType)
		{
			builder.AddByte(0, (byte)motorParamsChangeConfigType, 0);
		}

		// Token: 0x0602FDD8 RID: 196056 RVA: 0x006848F7 File Offset: 0x00682AF7
		public static void AddMotorParamsChangeConfig(FlatBufferBuilder builder, int motorParamsChangeConfigOffset)
		{
			builder.AddOffset(1, motorParamsChangeConfigOffset, 0);
		}

		// Token: 0x0602FDD9 RID: 196057 RVA: 0x00684902 File Offset: 0x00682B02
		public static void AddIsEnableNitrogen(FlatBufferBuilder builder, bool isEnableNitrogen)
		{
			builder.AddBool(2, isEnableNitrogen, false);
		}

		// Token: 0x0602FDDA RID: 196058 RVA: 0x0068490D File Offset: 0x00682B0D
		public static void AddDisableInput(FlatBufferBuilder builder, VectorOffset disableInputOffset)
		{
			builder.AddOffset(3, disableInputOffset.Value, 0);
		}

		// Token: 0x0602FDDB RID: 196059 RVA: 0x00684920 File Offset: 0x00682B20
		public static VectorOffset CreateDisableInputVector(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FDDC RID: 196060 RVA: 0x00684957 File Offset: 0x00682B57
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FDDD RID: 196061 RVA: 0x00684971 File Offset: 0x00682B71
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, ArraySegment<EPlayerInputConstraintType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FDDE RID: 196062 RVA: 0x0068498F File Offset: 0x00682B8F
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPlayerInputConstraintType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FDDF RID: 196063 RVA: 0x006849A8 File Offset: 0x00682BA8
		public static void StartDisableInputVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602FDE0 RID: 196064 RVA: 0x006849B3 File Offset: 0x00682BB3
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0602FDE1 RID: 196065 RVA: 0x006849C6 File Offset: 0x00682BC6
		public static void AddIsAffectedByTimeStop(FlatBufferBuilder builder, bool isAffectedByTimeStop)
		{
			builder.AddBool(5, isAffectedByTimeStop, false);
		}

		// Token: 0x0602FDE2 RID: 196066 RVA: 0x006849D1 File Offset: 0x00682BD1
		public static void AddCanBeInterrupted(FlatBufferBuilder builder, bool canBeInterrupted)
		{
			builder.AddBool(6, canBeInterrupted, false);
		}

		// Token: 0x0602FDE3 RID: 196067 RVA: 0x006849DC File Offset: 0x00682BDC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602FDE4 RID: 196068 RVA: 0x006849E7 File Offset: 0x00682BE7
		public static Offset<IDriveMotorInSpecConfig> EndIDriveMotorInSpecConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDriveMotorInSpecConfig>(builder.EndTable());
		}

		// Token: 0x0602FDE5 RID: 196069 RVA: 0x006849F4 File Offset: 0x00682BF4
		public IDriveMotorInSpecConfigT UnPack()
		{
			IDriveMotorInSpecConfigT driveMotorInSpecConfigT = new IDriveMotorInSpecConfigT();
			this.UnPackTo(driveMotorInSpecConfigT);
			return driveMotorInSpecConfigT;
		}

		// Token: 0x0602FDE6 RID: 196070 RVA: 0x00684A10 File Offset: 0x00682C10
		public void UnPackTo(IDriveMotorInSpecConfigT _o)
		{
			_o.MotorParamsChangeConfig = new TMotorParamsChangeConfigUnion();
			_o.MotorParamsChangeConfig.Type = this.MotorParamsChangeConfigType;
			TMotorParamsChangeConfig motorParamsChangeConfigType = this.MotorParamsChangeConfigType;
			if (motorParamsChangeConfigType != TMotorParamsChangeConfig.IMotorSpeedDownConfig)
			{
				if (motorParamsChangeConfigType == TMotorParamsChangeConfig.IMotorSpeedUpConfig)
				{
					_o.MotorParamsChangeConfig.Value = ((this.MotorParamsChangeConfig<IMotorSpeedUpConfig>() != null) ? this.MotorParamsChangeConfig<IMotorSpeedUpConfig>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MotorParamsChangeConfig.Value = ((this.MotorParamsChangeConfig<IMotorSpeedDownConfig>() != null) ? this.MotorParamsChangeConfig<IMotorSpeedDownConfig>().Value.UnPack() : null);
			}
			_o.IsEnableNitrogen = this.IsEnableNitrogen;
			_o.DisableInput = new List<EPlayerInputConstraintType>();
			for (int i = 0; i < this.DisableInputLength; i++)
			{
				_o.DisableInput.Add(this.DisableInput(i));
			}
			_o.Duration = this.Duration;
			_o.IsAffectedByTimeStop = this.IsAffectedByTimeStop;
			_o.CanBeInterrupted = this.CanBeInterrupted;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FDE7 RID: 196071 RVA: 0x00684B24 File Offset: 0x00682D24
		public static Offset<IDriveMotorInSpecConfig> Pack(FlatBufferBuilder builder, IDriveMotorInSpecConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDriveMotorInSpecConfig>);
			}
			TMotorParamsChangeConfig motorParamsChangeConfig_type = (_o.MotorParamsChangeConfig == null) ? TMotorParamsChangeConfig.NONE : _o.MotorParamsChangeConfig.Type;
			int motorParamsChangeConfigOffset = (_o.MotorParamsChangeConfig == null) ? 0 : TMotorParamsChangeConfigUnion.Pack(builder, _o.MotorParamsChangeConfig);
			VectorOffset disableInputOffset = default(VectorOffset);
			if (_o.DisableInput != null)
			{
				EPlayerInputConstraintType[] data = _o.DisableInput.ToArray();
				disableInputOffset = IDriveMotorInSpecConfig.CreateDisableInputVector(builder, data);
			}
			return IDriveMotorInSpecConfig.CreateIDriveMotorInSpecConfig(builder, motorParamsChangeConfig_type, motorParamsChangeConfigOffset, _o.IsEnableNitrogen, disableInputOffset, _o.Duration, _o.IsAffectedByTimeStop, _o.CanBeInterrupted, _o.NullMask);
		}

		// Token: 0x04011AB4 RID: 72372
		private Table __p;
	}
}
