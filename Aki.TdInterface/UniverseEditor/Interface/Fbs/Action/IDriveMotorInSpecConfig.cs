using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006612 RID: 26130
	public struct IDriveMotorInSpecConfig : IFlatbufferObject
	{
		// Token: 0x1700C226 RID: 49702
		// (get) Token: 0x0602D5F1 RID: 185841 RVA: 0x006379D4 File Offset: 0x00635BD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D5F2 RID: 185842 RVA: 0x006379E1 File Offset: 0x00635BE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D5F3 RID: 185843 RVA: 0x006379E8 File Offset: 0x00635BE8
		public static IDriveMotorInSpecConfig GetRootAsIDriveMotorInSpecConfig(ByteBuffer _bb)
		{
			return IDriveMotorInSpecConfig.GetRootAsIDriveMotorInSpecConfig(_bb, default(IDriveMotorInSpecConfig));
		}

		// Token: 0x0602D5F4 RID: 185844 RVA: 0x00637A04 File Offset: 0x00635C04
		public static IDriveMotorInSpecConfig GetRootAsIDriveMotorInSpecConfig(ByteBuffer _bb, IDriveMotorInSpecConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D5F5 RID: 185845 RVA: 0x00637A21 File Offset: 0x00635C21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D5F6 RID: 185846 RVA: 0x00637A30 File Offset: 0x00635C30
		public IDriveMotorInSpecConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C227 RID: 49703
		// (get) Token: 0x0602D5F7 RID: 185847 RVA: 0x00637A40 File Offset: 0x00635C40
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

		// Token: 0x0602D5F8 RID: 185848 RVA: 0x00637A7C File Offset: 0x00635C7C
		public TTable? MotorParamsChangeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D5F9 RID: 185849 RVA: 0x00637AC0 File Offset: 0x00635CC0
		public IMotorSpeedDownConfig MotorParamsChangeConfigAsIMotorSpeedDownConfig()
		{
			return this.MotorParamsChangeConfig<IMotorSpeedDownConfig>().Value;
		}

		// Token: 0x0602D5FA RID: 185850 RVA: 0x00637ADC File Offset: 0x00635CDC
		public IMotorSpeedUpConfig MotorParamsChangeConfigAsIMotorSpeedUpConfig()
		{
			return this.MotorParamsChangeConfig<IMotorSpeedUpConfig>().Value;
		}

		// Token: 0x1700C228 RID: 49704
		// (get) Token: 0x0602D5FB RID: 185851 RVA: 0x00637AF8 File Offset: 0x00635CF8
		public bool IsEnableNitrogen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D5FC RID: 185852 RVA: 0x00637B38 File Offset: 0x00635D38
		public EPlayerInputConstraintType DisableInput(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return EPlayerInputConstraintType.Left;
			}
			return (EPlayerInputConstraintType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C229 RID: 49705
		// (get) Token: 0x0602D5FD RID: 185853 RVA: 0x00637B78 File Offset: 0x00635D78
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

		// Token: 0x0602D5FE RID: 185854 RVA: 0x00637BA4 File Offset: 0x00635DA4
		public Span<EPlayerInputConstraintType> GetDisableInputBytes()
		{
			return this.__p.__vector_as_span<EPlayerInputConstraintType>(10, 1);
		}

		// Token: 0x0602D5FF RID: 185855 RVA: 0x00637BB4 File Offset: 0x00635DB4
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

		// Token: 0x1700C22A RID: 49706
		// (get) Token: 0x0602D600 RID: 185856 RVA: 0x00637C20 File Offset: 0x00635E20
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

		// Token: 0x1700C22B RID: 49707
		// (get) Token: 0x0602D601 RID: 185857 RVA: 0x00637C64 File Offset: 0x00635E64
		public bool IsAffectedByTimeStop
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C22C RID: 49708
		// (get) Token: 0x0602D602 RID: 185858 RVA: 0x00637CA4 File Offset: 0x00635EA4
		public bool CanBeInterrupted
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C22D RID: 49709
		// (get) Token: 0x0602D603 RID: 185859 RVA: 0x00637CE4 File Offset: 0x00635EE4
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

		// Token: 0x0602D604 RID: 185860 RVA: 0x00637D24 File Offset: 0x00635F24
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

		// Token: 0x0602D605 RID: 185861 RVA: 0x00637D7B File Offset: 0x00635F7B
		public static void StartIDriveMotorInSpecConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602D606 RID: 185862 RVA: 0x00637D84 File Offset: 0x00635F84
		public static void AddMotorParamsChangeConfigType(FlatBufferBuilder builder, TMotorParamsChangeConfig motorParamsChangeConfigType)
		{
			builder.AddByte(0, (byte)motorParamsChangeConfigType, 0);
		}

		// Token: 0x0602D607 RID: 185863 RVA: 0x00637D8F File Offset: 0x00635F8F
		public static void AddMotorParamsChangeConfig(FlatBufferBuilder builder, int motorParamsChangeConfigOffset)
		{
			builder.AddOffset(1, motorParamsChangeConfigOffset, 0);
		}

		// Token: 0x0602D608 RID: 185864 RVA: 0x00637D9A File Offset: 0x00635F9A
		public static void AddIsEnableNitrogen(FlatBufferBuilder builder, bool isEnableNitrogen)
		{
			builder.AddBool(2, isEnableNitrogen, false);
		}

		// Token: 0x0602D609 RID: 185865 RVA: 0x00637DA5 File Offset: 0x00635FA5
		public static void AddDisableInput(FlatBufferBuilder builder, VectorOffset disableInputOffset)
		{
			builder.AddOffset(3, disableInputOffset.Value, 0);
		}

		// Token: 0x0602D60A RID: 185866 RVA: 0x00637DB8 File Offset: 0x00635FB8
		public static VectorOffset CreateDisableInputVector(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D60B RID: 185867 RVA: 0x00637DEF File Offset: 0x00635FEF
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, EPlayerInputConstraintType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D60C RID: 185868 RVA: 0x00637E09 File Offset: 0x00636009
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, ArraySegment<EPlayerInputConstraintType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPlayerInputConstraintType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D60D RID: 185869 RVA: 0x00637E27 File Offset: 0x00636027
		public static VectorOffset CreateDisableInputVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPlayerInputConstraintType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D60E RID: 185870 RVA: 0x00637E40 File Offset: 0x00636040
		public static void StartDisableInputVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602D60F RID: 185871 RVA: 0x00637E4B File Offset: 0x0063604B
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0602D610 RID: 185872 RVA: 0x00637E5E File Offset: 0x0063605E
		public static void AddIsAffectedByTimeStop(FlatBufferBuilder builder, bool isAffectedByTimeStop)
		{
			builder.AddBool(5, isAffectedByTimeStop, false);
		}

		// Token: 0x0602D611 RID: 185873 RVA: 0x00637E69 File Offset: 0x00636069
		public static void AddCanBeInterrupted(FlatBufferBuilder builder, bool canBeInterrupted)
		{
			builder.AddBool(6, canBeInterrupted, false);
		}

		// Token: 0x0602D612 RID: 185874 RVA: 0x00637E74 File Offset: 0x00636074
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602D613 RID: 185875 RVA: 0x00637E7F File Offset: 0x0063607F
		public static Offset<IDriveMotorInSpecConfig> EndIDriveMotorInSpecConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDriveMotorInSpecConfig>(builder.EndTable());
		}

		// Token: 0x0602D614 RID: 185876 RVA: 0x00637E8C File Offset: 0x0063608C
		public IDriveMotorInSpecConfigT UnPack()
		{
			IDriveMotorInSpecConfigT driveMotorInSpecConfigT = new IDriveMotorInSpecConfigT();
			this.UnPackTo(driveMotorInSpecConfigT);
			return driveMotorInSpecConfigT;
		}

		// Token: 0x0602D615 RID: 185877 RVA: 0x00637EA8 File Offset: 0x006360A8
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

		// Token: 0x0602D616 RID: 185878 RVA: 0x00637FBC File Offset: 0x006361BC
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

		// Token: 0x04010C99 RID: 68761
		private Table __p;
	}
}
