using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D46 RID: 23878
	public struct IPilotThrow : IFlatbufferObject
	{
		// Token: 0x1700AFA3 RID: 44963
		// (get) Token: 0x06027B7F RID: 162687 RVA: 0x0056F21A File Offset: 0x0056D41A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B80 RID: 162688 RVA: 0x0056F227 File Offset: 0x0056D427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B81 RID: 162689 RVA: 0x0056F230 File Offset: 0x0056D430
		public static IPilotThrow GetRootAsIPilotThrow(ByteBuffer _bb)
		{
			return IPilotThrow.GetRootAsIPilotThrow(_bb, default(IPilotThrow));
		}

		// Token: 0x06027B82 RID: 162690 RVA: 0x0056F24C File Offset: 0x0056D44C
		public static IPilotThrow GetRootAsIPilotThrow(ByteBuffer _bb, IPilotThrow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B83 RID: 162691 RVA: 0x0056F269 File Offset: 0x0056D469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B84 RID: 162692 RVA: 0x0056F278 File Offset: 0x0056D478
		public IPilotThrow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFA4 RID: 44964
		// (get) Token: 0x06027B85 RID: 162693 RVA: 0x0056F288 File Offset: 0x0056D488
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

		// Token: 0x06027B86 RID: 162694 RVA: 0x0056F2C4 File Offset: 0x0056D4C4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFA5 RID: 44965
		// (get) Token: 0x06027B87 RID: 162695 RVA: 0x0056F324 File Offset: 0x0056D524
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

		// Token: 0x06027B88 RID: 162696 RVA: 0x0056F350 File Offset: 0x0056D550
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFA6 RID: 44966
		// (get) Token: 0x06027B89 RID: 162697 RVA: 0x0056F3B0 File Offset: 0x0056D5B0
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

		// Token: 0x06027B8A RID: 162698 RVA: 0x0056F3DC File Offset: 0x0056D5DC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFA7 RID: 44967
		// (get) Token: 0x06027B8B RID: 162699 RVA: 0x0056F440 File Offset: 0x0056D640
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

		// Token: 0x1700AFA8 RID: 44968
		// (get) Token: 0x06027B8C RID: 162700 RVA: 0x0056F46C File Offset: 0x0056D66C
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

		// Token: 0x1700AFA9 RID: 44969
		// (get) Token: 0x06027B8D RID: 162701 RVA: 0x0056F4CC File Offset: 0x0056D6CC
		public int TitanEntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFAA RID: 44970
		// (get) Token: 0x06027B8E RID: 162702 RVA: 0x0056F50C File Offset: 0x0056D70C
		public float MinPitchAngle
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

		// Token: 0x1700AFAB RID: 44971
		// (get) Token: 0x06027B8F RID: 162703 RVA: 0x0056F550 File Offset: 0x0056D750
		public float DefaultPitchAngle
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

		// Token: 0x1700AFAC RID: 44972
		// (get) Token: 0x06027B90 RID: 162704 RVA: 0x0056F594 File Offset: 0x0056D794
		public float MaxPitchAngle
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

		// Token: 0x1700AFAD RID: 44973
		// (get) Token: 0x06027B91 RID: 162705 RVA: 0x0056F5D8 File Offset: 0x0056D7D8
		public float MaxYawAngleDelta
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

		// Token: 0x1700AFAE RID: 44974
		// (get) Token: 0x06027B92 RID: 162706 RVA: 0x0056F61C File Offset: 0x0056D81C
		public float FlySpeed
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

		// Token: 0x1700AFAF RID: 44975
		// (get) Token: 0x06027B93 RID: 162707 RVA: 0x0056F660 File Offset: 0x0056D860
		public float Gravity
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B94 RID: 162708 RVA: 0x0056F6A4 File Offset: 0x0056D8A4
		public IPilotThrowTarget? TargetList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IPilotThrowTarget?(default(IPilotThrowTarget).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFB0 RID: 44976
		// (get) Token: 0x06027B95 RID: 162709 RVA: 0x0056F708 File Offset: 0x0056D908
		public int TargetListLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AFB1 RID: 44977
		// (get) Token: 0x06027B96 RID: 162710 RVA: 0x0056F734 File Offset: 0x0056D934
		public EPilotThrowAutoThrowType AutoThrowType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return EPilotThrowAutoThrowType.LowAngle;
				}
				return (EPilotThrowAutoThrowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFB2 RID: 44978
		// (get) Token: 0x06027B97 RID: 162711 RVA: 0x0056F774 File Offset: 0x0056D974
		public bool IsAutoRide
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFB3 RID: 44979
		// (get) Token: 0x06027B98 RID: 162712 RVA: 0x0056F7B4 File Offset: 0x0056D9B4
		public bool DisableInterrupt
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFB4 RID: 44980
		// (get) Token: 0x06027B99 RID: 162713 RVA: 0x0056F7F4 File Offset: 0x0056D9F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B9A RID: 162714 RVA: 0x0056F834 File Offset: 0x0056DA34
		public static Offset<IPilotThrow> CreateIPilotThrow(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), int TitanEntityId = 0, float MinPitchAngle = 0f, float DefaultPitchAngle = 0f, float MaxPitchAngle = 0f, float MaxYawAngleDelta = 0f, float FlySpeed = 0f, float Gravity = 0f, VectorOffset TargetListOffset = default(VectorOffset), EPilotThrowAutoThrowType AutoThrowType = EPilotThrowAutoThrowType.LowAngle, bool IsAutoRide = false, bool DisableInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(17);
			IPilotThrow.AddTargetList(builder, TargetListOffset);
			IPilotThrow.AddGravity(builder, Gravity);
			IPilotThrow.AddFlySpeed(builder, FlySpeed);
			IPilotThrow.AddMaxYawAngleDelta(builder, MaxYawAngleDelta);
			IPilotThrow.AddMaxPitchAngle(builder, MaxPitchAngle);
			IPilotThrow.AddDefaultPitchAngle(builder, DefaultPitchAngle);
			IPilotThrow.AddMinPitchAngle(builder, MinPitchAngle);
			IPilotThrow.AddTitanEntityId(builder, TitanEntityId);
			IPilotThrow.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IPilotThrow.AddFinishActions(builder, FinishActionsOffset);
			IPilotThrow.AddExitHookActions(builder, ExitHookActionsOffset);
			IPilotThrow.AddHookActions(builder, HookActionsOffset);
			IPilotThrow.AddNullMask(builder, NullMask);
			IPilotThrow.AddDisableInterrupt(builder, DisableInterrupt);
			IPilotThrow.AddIsAutoRide(builder, IsAutoRide);
			IPilotThrow.AddAutoThrowType(builder, AutoThrowType);
			IPilotThrow.AddType(builder, Type);
			return IPilotThrow.EndIPilotThrow(builder);
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x0056F8D4 File Offset: 0x0056DAD4
		public static void StartIPilotThrow(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x0056F8DE File Offset: 0x0056DADE
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027B9D RID: 162717 RVA: 0x0056F8E9 File Offset: 0x0056DAE9
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x0056F8FC File Offset: 0x0056DAFC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027B9F RID: 162719 RVA: 0x0056F93C File Offset: 0x0056DB3C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BA0 RID: 162720 RVA: 0x0056F956 File Offset: 0x0056DB56
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BA1 RID: 162721 RVA: 0x0056F974 File Offset: 0x0056DB74
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027BA2 RID: 162722 RVA: 0x0056F98D File Offset: 0x0056DB8D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027BA3 RID: 162723 RVA: 0x0056F998 File Offset: 0x0056DB98
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06027BA4 RID: 162724 RVA: 0x0056F9A8 File Offset: 0x0056DBA8
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027BA5 RID: 162725 RVA: 0x0056F9E8 File Offset: 0x0056DBE8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BA6 RID: 162726 RVA: 0x0056FA02 File Offset: 0x0056DC02
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BA7 RID: 162727 RVA: 0x0056FA20 File Offset: 0x0056DC20
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027BA8 RID: 162728 RVA: 0x0056FA39 File Offset: 0x0056DC39
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027BA9 RID: 162729 RVA: 0x0056FA44 File Offset: 0x0056DC44
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06027BAA RID: 162730 RVA: 0x0056FA54 File Offset: 0x0056DC54
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027BAB RID: 162731 RVA: 0x0056FA94 File Offset: 0x0056DC94
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BAC RID: 162732 RVA: 0x0056FAAE File Offset: 0x0056DCAE
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BAD RID: 162733 RVA: 0x0056FACC File Offset: 0x0056DCCC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027BAE RID: 162734 RVA: 0x0056FAE5 File Offset: 0x0056DCE5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027BAF RID: 162735 RVA: 0x0056FAF0 File Offset: 0x0056DCF0
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06027BB0 RID: 162736 RVA: 0x0056FB00 File Offset: 0x0056DD00
		public static void AddTitanEntityId(FlatBufferBuilder builder, int titanEntityId)
		{
			builder.AddInt(5, titanEntityId, 0);
		}

		// Token: 0x06027BB1 RID: 162737 RVA: 0x0056FB0B File Offset: 0x0056DD0B
		public static void AddMinPitchAngle(FlatBufferBuilder builder, float minPitchAngle)
		{
			builder.AddFloat(6, minPitchAngle, 0.0);
		}

		// Token: 0x06027BB2 RID: 162738 RVA: 0x0056FB1E File Offset: 0x0056DD1E
		public static void AddDefaultPitchAngle(FlatBufferBuilder builder, float defaultPitchAngle)
		{
			builder.AddFloat(7, defaultPitchAngle, 0.0);
		}

		// Token: 0x06027BB3 RID: 162739 RVA: 0x0056FB31 File Offset: 0x0056DD31
		public static void AddMaxPitchAngle(FlatBufferBuilder builder, float maxPitchAngle)
		{
			builder.AddFloat(8, maxPitchAngle, 0.0);
		}

		// Token: 0x06027BB4 RID: 162740 RVA: 0x0056FB44 File Offset: 0x0056DD44
		public static void AddMaxYawAngleDelta(FlatBufferBuilder builder, float maxYawAngleDelta)
		{
			builder.AddFloat(9, maxYawAngleDelta, 0.0);
		}

		// Token: 0x06027BB5 RID: 162741 RVA: 0x0056FB58 File Offset: 0x0056DD58
		public static void AddFlySpeed(FlatBufferBuilder builder, float flySpeed)
		{
			builder.AddFloat(10, flySpeed, 0.0);
		}

		// Token: 0x06027BB6 RID: 162742 RVA: 0x0056FB6C File Offset: 0x0056DD6C
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(11, gravity, 0.0);
		}

		// Token: 0x06027BB7 RID: 162743 RVA: 0x0056FB80 File Offset: 0x0056DD80
		public static void AddTargetList(FlatBufferBuilder builder, VectorOffset targetListOffset)
		{
			builder.AddOffset(12, targetListOffset.Value, 0);
		}

		// Token: 0x06027BB8 RID: 162744 RVA: 0x0056FB94 File Offset: 0x0056DD94
		public static VectorOffset CreateTargetListVector(FlatBufferBuilder builder, Offset<IPilotThrowTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x0056FBD4 File Offset: 0x0056DDD4
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, Offset<IPilotThrowTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPilotThrowTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BBA RID: 162746 RVA: 0x0056FBEE File Offset: 0x0056DDEE
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPilotThrowTarget>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPilotThrowTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027BBB RID: 162747 RVA: 0x0056FC0C File Offset: 0x0056DE0C
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPilotThrowTarget>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027BBC RID: 162748 RVA: 0x0056FC25 File Offset: 0x0056DE25
		public static void StartTargetListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027BBD RID: 162749 RVA: 0x0056FC30 File Offset: 0x0056DE30
		public static void AddAutoThrowType(FlatBufferBuilder builder, EPilotThrowAutoThrowType autoThrowType)
		{
			builder.AddByte(13, (byte)autoThrowType, 0);
		}

		// Token: 0x06027BBE RID: 162750 RVA: 0x0056FC3C File Offset: 0x0056DE3C
		public static void AddIsAutoRide(FlatBufferBuilder builder, bool isAutoRide)
		{
			builder.AddBool(14, isAutoRide, false);
		}

		// Token: 0x06027BBF RID: 162751 RVA: 0x0056FC48 File Offset: 0x0056DE48
		public static void AddDisableInterrupt(FlatBufferBuilder builder, bool disableInterrupt)
		{
			builder.AddBool(15, disableInterrupt, false);
		}

		// Token: 0x06027BC0 RID: 162752 RVA: 0x0056FC54 File Offset: 0x0056DE54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x06027BC1 RID: 162753 RVA: 0x0056FC60 File Offset: 0x0056DE60
		public static Offset<IPilotThrow> EndIPilotThrow(FlatBufferBuilder builder)
		{
			return new Offset<IPilotThrow>(builder.EndTable());
		}

		// Token: 0x06027BC2 RID: 162754 RVA: 0x0056FC70 File Offset: 0x0056DE70
		public IPilotThrowT UnPack()
		{
			IPilotThrowT pilotThrowT = new IPilotThrowT();
			this.UnPackTo(pilotThrowT);
			return pilotThrowT;
		}

		// Token: 0x06027BC3 RID: 162755 RVA: 0x0056FC8C File Offset: 0x0056DE8C
		public void UnPackTo(IPilotThrowT _o)
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
			_o.TitanEntityId = this.TitanEntityId;
			_o.MinPitchAngle = this.MinPitchAngle;
			_o.DefaultPitchAngle = this.DefaultPitchAngle;
			_o.MaxPitchAngle = this.MaxPitchAngle;
			_o.MaxYawAngleDelta = this.MaxYawAngleDelta;
			_o.FlySpeed = this.FlySpeed;
			_o.Gravity = this.Gravity;
			_o.TargetList = new List<IPilotThrowTargetT>();
			for (int l = 0; l < this.TargetListLength; l++)
			{
				_o.TargetList.Add((this.TargetList(l) != null) ? this.TargetList(l).Value.UnPack() : null);
			}
			_o.AutoThrowType = this.AutoThrowType;
			_o.IsAutoRide = this.IsAutoRide;
			_o.DisableInterrupt = this.DisableInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027BC4 RID: 162756 RVA: 0x0056FEB4 File Offset: 0x0056E0B4
		public static Offset<IPilotThrow> Pack(FlatBufferBuilder builder, IPilotThrowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPilotThrow>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IPilotThrow.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IPilotThrow.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IPilotThrow.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			VectorOffset targetListOffset = default(VectorOffset);
			if (_o.TargetList != null)
			{
				Offset<IPilotThrowTarget>[] array4 = new Offset<IPilotThrowTarget>[_o.TargetList.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IPilotThrowTarget.Pack(builder, _o.TargetList[l]);
				}
				targetListOffset = IPilotThrow.CreateTargetListVector(builder, array4);
			}
			return IPilotThrow.CreateIPilotThrow(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.TitanEntityId, _o.MinPitchAngle, _o.DefaultPitchAngle, _o.MaxPitchAngle, _o.MaxYawAngleDelta, _o.FlySpeed, _o.Gravity, targetListOffset, _o.AutoThrowType, _o.IsAutoRide, _o.DisableInterrupt, _o.NullMask);
		}

		// Token: 0x0400F8B4 RID: 63668
		private Table __p;
	}
}
