using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4F RID: 23375
	public struct IMotorEjectHook : IFlatbufferObject
	{
		// Token: 0x1700AA88 RID: 43656
		// (get) Token: 0x06026716 RID: 157462 RVA: 0x005437D2 File Offset: 0x005419D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026717 RID: 157463 RVA: 0x005437DF File Offset: 0x005419DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026718 RID: 157464 RVA: 0x005437E8 File Offset: 0x005419E8
		public static IMotorEjectHook GetRootAsIMotorEjectHook(ByteBuffer _bb)
		{
			return IMotorEjectHook.GetRootAsIMotorEjectHook(_bb, default(IMotorEjectHook));
		}

		// Token: 0x06026719 RID: 157465 RVA: 0x00543804 File Offset: 0x00541A04
		public static IMotorEjectHook GetRootAsIMotorEjectHook(ByteBuffer _bb, IMotorEjectHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602671A RID: 157466 RVA: 0x00543821 File Offset: 0x00541A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602671B RID: 157467 RVA: 0x00543830 File Offset: 0x00541A30
		public IMotorEjectHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA89 RID: 43657
		// (get) Token: 0x0602671C RID: 157468 RVA: 0x00543840 File Offset: 0x00541A40
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

		// Token: 0x0602671D RID: 157469 RVA: 0x0054387C File Offset: 0x00541A7C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA8A RID: 43658
		// (get) Token: 0x0602671E RID: 157470 RVA: 0x005438DC File Offset: 0x00541ADC
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

		// Token: 0x0602671F RID: 157471 RVA: 0x00543908 File Offset: 0x00541B08
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA8B RID: 43659
		// (get) Token: 0x06026720 RID: 157472 RVA: 0x00543968 File Offset: 0x00541B68
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

		// Token: 0x06026721 RID: 157473 RVA: 0x00543994 File Offset: 0x00541B94
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA8C RID: 43660
		// (get) Token: 0x06026722 RID: 157474 RVA: 0x005439F8 File Offset: 0x00541BF8
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

		// Token: 0x1700AA8D RID: 43661
		// (get) Token: 0x06026723 RID: 157475 RVA: 0x00543A24 File Offset: 0x00541C24
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

		// Token: 0x1700AA8E RID: 43662
		// (get) Token: 0x06026724 RID: 157476 RVA: 0x00543A84 File Offset: 0x00541C84
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

		// Token: 0x1700AA8F RID: 43663
		// (get) Token: 0x06026725 RID: 157477 RVA: 0x00543AC8 File Offset: 0x00541CC8
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

		// Token: 0x1700AA90 RID: 43664
		// (get) Token: 0x06026726 RID: 157478 RVA: 0x00543B0C File Offset: 0x00541D0C
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

		// Token: 0x1700AA91 RID: 43665
		// (get) Token: 0x06026727 RID: 157479 RVA: 0x00543B50 File Offset: 0x00541D50
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

		// Token: 0x1700AA92 RID: 43666
		// (get) Token: 0x06026728 RID: 157480 RVA: 0x00543B94 File Offset: 0x00541D94
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

		// Token: 0x1700AA93 RID: 43667
		// (get) Token: 0x06026729 RID: 157481 RVA: 0x00543BD8 File Offset: 0x00541DD8
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

		// Token: 0x1700AA94 RID: 43668
		// (get) Token: 0x0602672A RID: 157482 RVA: 0x00543C1C File Offset: 0x00541E1C
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

		// Token: 0x0602672B RID: 157483 RVA: 0x00543C5C File Offset: 0x00541E5C
		public TTable? AutoEjectConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602672C RID: 157484 RVA: 0x00543CA4 File Offset: 0x00541EA4
		public IMotorAutoEjectNextHookConfig AutoEjectConfigAsIMotorAutoEjectNextHookConfig()
		{
			return this.AutoEjectConfig<IMotorAutoEjectNextHookConfig>().Value;
		}

		// Token: 0x0602672D RID: 157485 RVA: 0x00543CC0 File Offset: 0x00541EC0
		public IMotorAutoEjectPositionEntityConfig AutoEjectConfigAsIMotorAutoEjectPositionEntityConfig()
		{
			return this.AutoEjectConfig<IMotorAutoEjectPositionEntityConfig>().Value;
		}

		// Token: 0x1700AA95 RID: 43669
		// (get) Token: 0x0602672E RID: 157486 RVA: 0x00543CDC File Offset: 0x00541EDC
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

		// Token: 0x0602672F RID: 157487 RVA: 0x00543D1C File Offset: 0x00541F1C
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

		// Token: 0x06026730 RID: 157488 RVA: 0x00543DA4 File Offset: 0x00541FA4
		public static void StartIMotorEjectHook(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06026731 RID: 157489 RVA: 0x00543DAE File Offset: 0x00541FAE
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026732 RID: 157490 RVA: 0x00543DB9 File Offset: 0x00541FB9
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06026733 RID: 157491 RVA: 0x00543DCC File Offset: 0x00541FCC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026734 RID: 157492 RVA: 0x00543E0C File Offset: 0x0054200C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026735 RID: 157493 RVA: 0x00543E26 File Offset: 0x00542026
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026736 RID: 157494 RVA: 0x00543E44 File Offset: 0x00542044
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026737 RID: 157495 RVA: 0x00543E5D File Offset: 0x0054205D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026738 RID: 157496 RVA: 0x00543E68 File Offset: 0x00542068
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06026739 RID: 157497 RVA: 0x00543E78 File Offset: 0x00542078
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602673A RID: 157498 RVA: 0x00543EB8 File Offset: 0x005420B8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602673B RID: 157499 RVA: 0x00543ED2 File Offset: 0x005420D2
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602673C RID: 157500 RVA: 0x00543EF0 File Offset: 0x005420F0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602673D RID: 157501 RVA: 0x00543F09 File Offset: 0x00542109
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602673E RID: 157502 RVA: 0x00543F14 File Offset: 0x00542114
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602673F RID: 157503 RVA: 0x00543F24 File Offset: 0x00542124
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026740 RID: 157504 RVA: 0x00543F64 File Offset: 0x00542164
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026741 RID: 157505 RVA: 0x00543F7E File Offset: 0x0054217E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026742 RID: 157506 RVA: 0x00543F9C File Offset: 0x0054219C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026743 RID: 157507 RVA: 0x00543FB5 File Offset: 0x005421B5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x00543FC0 File Offset: 0x005421C0
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06026745 RID: 157509 RVA: 0x00543FD0 File Offset: 0x005421D0
		public static void AddMinPitchAngle(FlatBufferBuilder builder, float minPitchAngle)
		{
			builder.AddFloat(5, minPitchAngle, 0.0);
		}

		// Token: 0x06026746 RID: 157510 RVA: 0x00543FE3 File Offset: 0x005421E3
		public static void AddDefaultPitchAngle(FlatBufferBuilder builder, float defaultPitchAngle)
		{
			builder.AddFloat(6, defaultPitchAngle, 0.0);
		}

		// Token: 0x06026747 RID: 157511 RVA: 0x00543FF6 File Offset: 0x005421F6
		public static void AddMaxPitchAngle(FlatBufferBuilder builder, float maxPitchAngle)
		{
			builder.AddFloat(7, maxPitchAngle, 0.0);
		}

		// Token: 0x06026748 RID: 157512 RVA: 0x00544009 File Offset: 0x00542209
		public static void AddMaxYawAngleDelta(FlatBufferBuilder builder, float maxYawAngleDelta)
		{
			builder.AddFloat(8, maxYawAngleDelta, 0.0);
		}

		// Token: 0x06026749 RID: 157513 RVA: 0x0054401C File Offset: 0x0054221C
		public static void AddMaxEjectDistance(FlatBufferBuilder builder, float maxEjectDistance)
		{
			builder.AddFloat(9, maxEjectDistance, 0.0);
		}

		// Token: 0x0602674A RID: 157514 RVA: 0x00544030 File Offset: 0x00542230
		public static void AddInterpSpeed(FlatBufferBuilder builder, float interpSpeed)
		{
			builder.AddFloat(10, interpSpeed, 0.0);
		}

		// Token: 0x0602674B RID: 157515 RVA: 0x00544044 File Offset: 0x00542244
		public static void AddAutoEjectConfigType(FlatBufferBuilder builder, TMotorAutoEjectConfig autoEjectConfigType)
		{
			builder.AddByte(11, (byte)autoEjectConfigType, 0);
		}

		// Token: 0x0602674C RID: 157516 RVA: 0x00544050 File Offset: 0x00542250
		public static void AddAutoEjectConfig(FlatBufferBuilder builder, int autoEjectConfigOffset)
		{
			builder.AddOffset(12, autoEjectConfigOffset, 0);
		}

		// Token: 0x0602674D RID: 157517 RVA: 0x0054405C File Offset: 0x0054225C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x0602674E RID: 157518 RVA: 0x00544068 File Offset: 0x00542268
		public static Offset<IMotorEjectHook> EndIMotorEjectHook(FlatBufferBuilder builder)
		{
			return new Offset<IMotorEjectHook>(builder.EndTable());
		}

		// Token: 0x0602674F RID: 157519 RVA: 0x00544078 File Offset: 0x00542278
		public IMotorEjectHookT UnPack()
		{
			IMotorEjectHookT motorEjectHookT = new IMotorEjectHookT();
			this.UnPackTo(motorEjectHookT);
			return motorEjectHookT;
		}

		// Token: 0x06026750 RID: 157520 RVA: 0x00544094 File Offset: 0x00542294
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

		// Token: 0x06026751 RID: 157521 RVA: 0x005442D0 File Offset: 0x005424D0
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

		// Token: 0x0400F548 RID: 62792
		private Table __p;
	}
}
