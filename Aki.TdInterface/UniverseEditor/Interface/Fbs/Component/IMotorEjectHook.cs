using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B1 RID: 21937
	public struct IMotorEjectHook : IFlatbufferObject
	{
		// Token: 0x1700A200 RID: 41472
		// (get) Token: 0x06024509 RID: 148745 RVA: 0x0050325A File Offset: 0x0050145A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602450A RID: 148746 RVA: 0x00503267 File Offset: 0x00501467
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602450B RID: 148747 RVA: 0x00503270 File Offset: 0x00501470
		public static IMotorEjectHook GetRootAsIMotorEjectHook(ByteBuffer _bb)
		{
			return IMotorEjectHook.GetRootAsIMotorEjectHook(_bb, default(IMotorEjectHook));
		}

		// Token: 0x0602450C RID: 148748 RVA: 0x0050328C File Offset: 0x0050148C
		public static IMotorEjectHook GetRootAsIMotorEjectHook(ByteBuffer _bb, IMotorEjectHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602450D RID: 148749 RVA: 0x005032A9 File Offset: 0x005014A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602450E RID: 148750 RVA: 0x005032B8 File Offset: 0x005014B8
		public IMotorEjectHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A201 RID: 41473
		// (get) Token: 0x0602450F RID: 148751 RVA: 0x005032C8 File Offset: 0x005014C8
		public EHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookInteractType.FixedPointHook;
				}
				return (EHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024510 RID: 148752 RVA: 0x00503304 File Offset: 0x00501504
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A202 RID: 41474
		// (get) Token: 0x06024511 RID: 148753 RVA: 0x00503364 File Offset: 0x00501564
		public int HookActionsLength
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

		// Token: 0x06024512 RID: 148754 RVA: 0x00503390 File Offset: 0x00501590
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A203 RID: 41475
		// (get) Token: 0x06024513 RID: 148755 RVA: 0x005033F0 File Offset: 0x005015F0
		public int ExitHookActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024514 RID: 148756 RVA: 0x0050341C File Offset: 0x0050161C
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A204 RID: 41476
		// (get) Token: 0x06024515 RID: 148757 RVA: 0x00503480 File Offset: 0x00501680
		public int FinishActionsLength
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

		// Token: 0x1700A205 RID: 41477
		// (get) Token: 0x06024516 RID: 148758 RVA: 0x005034AC File Offset: 0x005016AC
		public IClientHookActionConfig? ClientHookActionConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IClientHookActionConfig?(default(IClientHookActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A206 RID: 41478
		// (get) Token: 0x06024517 RID: 148759 RVA: 0x0050350C File Offset: 0x0050170C
		public float MinPitchAngle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A207 RID: 41479
		// (get) Token: 0x06024518 RID: 148760 RVA: 0x00503550 File Offset: 0x00501750
		public float DefaultPitchAngle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A208 RID: 41480
		// (get) Token: 0x06024519 RID: 148761 RVA: 0x00503594 File Offset: 0x00501794
		public float MaxPitchAngle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A209 RID: 41481
		// (get) Token: 0x0602451A RID: 148762 RVA: 0x005035D8 File Offset: 0x005017D8
		public float MaxYawAngleDelta
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A20A RID: 41482
		// (get) Token: 0x0602451B RID: 148763 RVA: 0x0050361C File Offset: 0x0050181C
		public float MaxEjectDistance
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A20B RID: 41483
		// (get) Token: 0x0602451C RID: 148764 RVA: 0x00503660 File Offset: 0x00501860
		public float InterpSpeed
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A20C RID: 41484
		// (get) Token: 0x0602451D RID: 148765 RVA: 0x005036A4 File Offset: 0x005018A4
		public TMotorAutoEjectConfig AutoEjectConfigType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return TMotorAutoEjectConfig.NONE;
				}
				return (TMotorAutoEjectConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602451E RID: 148766 RVA: 0x005036E4 File Offset: 0x005018E4
		public TTable? AutoEjectConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602451F RID: 148767 RVA: 0x0050372C File Offset: 0x0050192C
		public IMotorAutoEjectNextHookConfig AutoEjectConfigAsIMotorAutoEjectNextHookConfig()
		{
			return this.AutoEjectConfig<IMotorAutoEjectNextHookConfig>().Value;
		}

		// Token: 0x06024520 RID: 148768 RVA: 0x00503748 File Offset: 0x00501948
		public IMotorAutoEjectPositionEntityConfig AutoEjectConfigAsIMotorAutoEjectPositionEntityConfig()
		{
			return this.AutoEjectConfig<IMotorAutoEjectPositionEntityConfig>().Value;
		}

		// Token: 0x1700A20D RID: 41485
		// (get) Token: 0x06024521 RID: 148769 RVA: 0x00503764 File Offset: 0x00501964
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024522 RID: 148770 RVA: 0x005037A4 File Offset: 0x005019A4
		public static Offset<IMotorEjectHook> CreateIMotorEjectHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), float MinPitchAngle = 0f, float DefaultPitchAngle = 0f, float MaxPitchAngle = 0f, float MaxYawAngleDelta = 0f, float MaxEjectDistance = 0f, float InterpSpeed = 0f, TMotorAutoEjectConfig AutoEjectConfig_type = TMotorAutoEjectConfig.NONE, int AutoEjectConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(14);
			IMotorEjectHook.AddAutoEjectConfig(builder, AutoEjectConfigOffset);
			IMotorEjectHook.AddInterpSpeed(builder, InterpSpeed);
			IMotorEjectHook.AddMaxEjectDistance(builder, MaxEjectDistance);
			IMotorEjectHook.AddMaxYawAngleDelta(builder, MaxYawAngleDelta);
			IMotorEjectHook.AddMaxPitchAngle(builder, MaxPitchAngle);
			IMotorEjectHook.AddDefaultPitchAngle(builder, DefaultPitchAngle);
			IMotorEjectHook.AddMinPitchAngle(builder, MinPitchAngle);
			IMotorEjectHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMotorEjectHook.AddFinishActions(builder, FinishActionsOffset);
			IMotorEjectHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IMotorEjectHook.AddHookActions(builder, HookActionsOffset);
			IMotorEjectHook.AddNullMask(builder, NullMask);
			IMotorEjectHook.AddAutoEjectConfigType(builder, AutoEjectConfig_type);
			IMotorEjectHook.AddType(builder, Type);
			return IMotorEjectHook.EndIMotorEjectHook(builder);
		}

		// Token: 0x06024523 RID: 148771 RVA: 0x0050382C File Offset: 0x00501A2C
		public static void StartIMotorEjectHook(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06024524 RID: 148772 RVA: 0x00503836 File Offset: 0x00501A36
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024525 RID: 148773 RVA: 0x00503841 File Offset: 0x00501A41
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06024526 RID: 148774 RVA: 0x00503854 File Offset: 0x00501A54
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024527 RID: 148775 RVA: 0x00503894 File Offset: 0x00501A94
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024528 RID: 148776 RVA: 0x005038AE File Offset: 0x00501AAE
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024529 RID: 148777 RVA: 0x005038CC File Offset: 0x00501ACC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602452A RID: 148778 RVA: 0x005038E5 File Offset: 0x00501AE5
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602452B RID: 148779 RVA: 0x005038F0 File Offset: 0x00501AF0
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602452C RID: 148780 RVA: 0x00503900 File Offset: 0x00501B00
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602452D RID: 148781 RVA: 0x00503940 File Offset: 0x00501B40
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602452E RID: 148782 RVA: 0x0050395A File Offset: 0x00501B5A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602452F RID: 148783 RVA: 0x00503978 File Offset: 0x00501B78
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024530 RID: 148784 RVA: 0x00503991 File Offset: 0x00501B91
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024531 RID: 148785 RVA: 0x0050399C File Offset: 0x00501B9C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06024532 RID: 148786 RVA: 0x005039AC File Offset: 0x00501BAC
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024533 RID: 148787 RVA: 0x005039EC File Offset: 0x00501BEC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024534 RID: 148788 RVA: 0x00503A06 File Offset: 0x00501C06
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024535 RID: 148789 RVA: 0x00503A24 File Offset: 0x00501C24
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024536 RID: 148790 RVA: 0x00503A3D File Offset: 0x00501C3D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024537 RID: 148791 RVA: 0x00503A48 File Offset: 0x00501C48
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024538 RID: 148792 RVA: 0x00503A58 File Offset: 0x00501C58
		public static void AddMinPitchAngle(FlatBufferBuilder builder, float minPitchAngle)
		{
			builder.AddFloat(5, minPitchAngle, 0.0);
		}

		// Token: 0x06024539 RID: 148793 RVA: 0x00503A6B File Offset: 0x00501C6B
		public static void AddDefaultPitchAngle(FlatBufferBuilder builder, float defaultPitchAngle)
		{
			builder.AddFloat(6, defaultPitchAngle, 0.0);
		}

		// Token: 0x0602453A RID: 148794 RVA: 0x00503A7E File Offset: 0x00501C7E
		public static void AddMaxPitchAngle(FlatBufferBuilder builder, float maxPitchAngle)
		{
			builder.AddFloat(7, maxPitchAngle, 0.0);
		}

		// Token: 0x0602453B RID: 148795 RVA: 0x00503A91 File Offset: 0x00501C91
		public static void AddMaxYawAngleDelta(FlatBufferBuilder builder, float maxYawAngleDelta)
		{
			builder.AddFloat(8, maxYawAngleDelta, 0.0);
		}

		// Token: 0x0602453C RID: 148796 RVA: 0x00503AA4 File Offset: 0x00501CA4
		public static void AddMaxEjectDistance(FlatBufferBuilder builder, float maxEjectDistance)
		{
			builder.AddFloat(9, maxEjectDistance, 0.0);
		}

		// Token: 0x0602453D RID: 148797 RVA: 0x00503AB8 File Offset: 0x00501CB8
		public static void AddInterpSpeed(FlatBufferBuilder builder, float interpSpeed)
		{
			builder.AddFloat(10, interpSpeed, 0.0);
		}

		// Token: 0x0602453E RID: 148798 RVA: 0x00503ACC File Offset: 0x00501CCC
		public static void AddAutoEjectConfigType(FlatBufferBuilder builder, TMotorAutoEjectConfig autoEjectConfigType)
		{
			builder.AddByte(11, (byte)autoEjectConfigType, 0);
		}

		// Token: 0x0602453F RID: 148799 RVA: 0x00503AD8 File Offset: 0x00501CD8
		public static void AddAutoEjectConfig(FlatBufferBuilder builder, int autoEjectConfigOffset)
		{
			builder.AddOffset(12, autoEjectConfigOffset, 0);
		}

		// Token: 0x06024540 RID: 148800 RVA: 0x00503AE4 File Offset: 0x00501CE4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06024541 RID: 148801 RVA: 0x00503AF0 File Offset: 0x00501CF0
		public static Offset<IMotorEjectHook> EndIMotorEjectHook(FlatBufferBuilder builder)
		{
			return new Offset<IMotorEjectHook>(builder.EndTable());
		}

		// Token: 0x06024542 RID: 148802 RVA: 0x00503B00 File Offset: 0x00501D00
		public IMotorEjectHookT UnPack()
		{
			IMotorEjectHookT motorEjectHookT = new IMotorEjectHookT();
			this.UnPackTo(motorEjectHookT);
			return motorEjectHookT;
		}

		// Token: 0x06024543 RID: 148803 RVA: 0x00503B1C File Offset: 0x00501D1C
		public void UnPackTo(IMotorEjectHookT _o)
		{
			_o.Type = this.Type;
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.ExitHookActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitHookActionsLength; j++)
			{
				_o.ExitHookActions.Add((this.ExitHookActions(j) != null) ? this.ExitHookActions(j).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int k = 0; k < this.FinishActionsLength; k++)
			{
				_o.FinishActions.Add((this.FinishActions(k) != null) ? this.FinishActions(k).Value.UnPack() : null);
			}
			_o.ClientHookActionConfig = ((this.ClientHookActionConfig != null) ? this.ClientHookActionConfig.Value.UnPack() : null);
			_o.MinPitchAngle = this.MinPitchAngle;
			_o.DefaultPitchAngle = this.DefaultPitchAngle;
			_o.MaxPitchAngle = this.MaxPitchAngle;
			_o.MaxYawAngleDelta = this.MaxYawAngleDelta;
			_o.MaxEjectDistance = this.MaxEjectDistance;
			_o.InterpSpeed = this.InterpSpeed;
			_o.AutoEjectConfig = new TMotorAutoEjectConfigUnion();
			_o.AutoEjectConfig.Type = this.AutoEjectConfigType;
			TMotorAutoEjectConfig autoEjectConfigType = this.AutoEjectConfigType;
			if (autoEjectConfigType != TMotorAutoEjectConfig.IMotorAutoEjectNextHookConfig)
			{
				if (autoEjectConfigType == TMotorAutoEjectConfig.IMotorAutoEjectPositionEntityConfig)
				{
					_o.AutoEjectConfig.Value = ((this.AutoEjectConfig<IMotorAutoEjectPositionEntityConfig>() != null) ? this.AutoEjectConfig<IMotorAutoEjectPositionEntityConfig>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.AutoEjectConfig.Value = ((this.AutoEjectConfig<IMotorAutoEjectNextHookConfig>() != null) ? this.AutoEjectConfig<IMotorAutoEjectNextHookConfig>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024544 RID: 148804 RVA: 0x00503D58 File Offset: 0x00501F58
		public static Offset<IMotorEjectHook> Pack(FlatBufferBuilder builder, IMotorEjectHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorEjectHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMotorEjectHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMotorEjectHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMotorEjectHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			TMotorAutoEjectConfig autoEjectConfig_type = (_o.AutoEjectConfig == null) ? TMotorAutoEjectConfig.NONE : _o.AutoEjectConfig.Type;
			int autoEjectConfigOffset = (_o.AutoEjectConfig == null) ? 0 : TMotorAutoEjectConfigUnion.Pack(builder, _o.AutoEjectConfig);
			return IMotorEjectHook.CreateIMotorEjectHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.MinPitchAngle, _o.DefaultPitchAngle, _o.MaxPitchAngle, _o.MaxYawAngleDelta, _o.MaxEjectDistance, _o.InterpSpeed, autoEjectConfig_type, autoEjectConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E8E6 RID: 59622
		private Table __p;
	}
}
