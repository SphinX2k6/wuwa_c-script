using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573F RID: 22335
	public struct IPilotThrow : IFlatbufferObject
	{
		// Token: 0x1700A67F RID: 42623
		// (get) Token: 0x0602565F RID: 153183 RVA: 0x0052908E File Offset: 0x0052728E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025660 RID: 153184 RVA: 0x0052909B File Offset: 0x0052729B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025661 RID: 153185 RVA: 0x005290A4 File Offset: 0x005272A4
		public static IPilotThrow GetRootAsIPilotThrow(ByteBuffer _bb)
		{
			return IPilotThrow.GetRootAsIPilotThrow(_bb, default(IPilotThrow));
		}

		// Token: 0x06025662 RID: 153186 RVA: 0x005290C0 File Offset: 0x005272C0
		public static IPilotThrow GetRootAsIPilotThrow(ByteBuffer _bb, IPilotThrow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025663 RID: 153187 RVA: 0x005290DD File Offset: 0x005272DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025664 RID: 153188 RVA: 0x005290EC File Offset: 0x005272EC
		public IPilotThrow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A680 RID: 42624
		// (get) Token: 0x06025665 RID: 153189 RVA: 0x005290FC File Offset: 0x005272FC
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

		// Token: 0x06025666 RID: 153190 RVA: 0x00529138 File Offset: 0x00527338
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A681 RID: 42625
		// (get) Token: 0x06025667 RID: 153191 RVA: 0x00529198 File Offset: 0x00527398
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

		// Token: 0x06025668 RID: 153192 RVA: 0x005291C4 File Offset: 0x005273C4
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A682 RID: 42626
		// (get) Token: 0x06025669 RID: 153193 RVA: 0x00529224 File Offset: 0x00527424
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

		// Token: 0x0602566A RID: 153194 RVA: 0x00529250 File Offset: 0x00527450
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A683 RID: 42627
		// (get) Token: 0x0602566B RID: 153195 RVA: 0x005292B4 File Offset: 0x005274B4
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

		// Token: 0x1700A684 RID: 42628
		// (get) Token: 0x0602566C RID: 153196 RVA: 0x005292E0 File Offset: 0x005274E0
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

		// Token: 0x1700A685 RID: 42629
		// (get) Token: 0x0602566D RID: 153197 RVA: 0x00529340 File Offset: 0x00527540
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

		// Token: 0x1700A686 RID: 42630
		// (get) Token: 0x0602566E RID: 153198 RVA: 0x00529380 File Offset: 0x00527580
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

		// Token: 0x1700A687 RID: 42631
		// (get) Token: 0x0602566F RID: 153199 RVA: 0x005293C4 File Offset: 0x005275C4
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

		// Token: 0x1700A688 RID: 42632
		// (get) Token: 0x06025670 RID: 153200 RVA: 0x00529408 File Offset: 0x00527608
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

		// Token: 0x1700A689 RID: 42633
		// (get) Token: 0x06025671 RID: 153201 RVA: 0x0052944C File Offset: 0x0052764C
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

		// Token: 0x1700A68A RID: 42634
		// (get) Token: 0x06025672 RID: 153202 RVA: 0x00529490 File Offset: 0x00527690
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

		// Token: 0x1700A68B RID: 42635
		// (get) Token: 0x06025673 RID: 153203 RVA: 0x005294D4 File Offset: 0x005276D4
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

		// Token: 0x06025674 RID: 153204 RVA: 0x00529518 File Offset: 0x00527718
		public IPilotThrowTarget? TargetList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IPilotThrowTarget?(default(IPilotThrowTarget).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A68C RID: 42636
		// (get) Token: 0x06025675 RID: 153205 RVA: 0x0052957C File Offset: 0x0052777C
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

		// Token: 0x1700A68D RID: 42637
		// (get) Token: 0x06025676 RID: 153206 RVA: 0x005295A8 File Offset: 0x005277A8
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

		// Token: 0x1700A68E RID: 42638
		// (get) Token: 0x06025677 RID: 153207 RVA: 0x005295E8 File Offset: 0x005277E8
		public bool IsAutoRide
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A68F RID: 42639
		// (get) Token: 0x06025678 RID: 153208 RVA: 0x00529628 File Offset: 0x00527828
		public bool DisableInterrupt
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A690 RID: 42640
		// (get) Token: 0x06025679 RID: 153209 RVA: 0x00529668 File Offset: 0x00527868
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

		// Token: 0x0602567A RID: 153210 RVA: 0x005296A8 File Offset: 0x005278A8
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

		// Token: 0x0602567B RID: 153211 RVA: 0x00529748 File Offset: 0x00527948
		public static void StartIPilotThrow(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602567C RID: 153212 RVA: 0x00529752 File Offset: 0x00527952
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602567D RID: 153213 RVA: 0x0052975D File Offset: 0x0052795D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602567E RID: 153214 RVA: 0x00529770 File Offset: 0x00527970
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602567F RID: 153215 RVA: 0x005297B0 File Offset: 0x005279B0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025680 RID: 153216 RVA: 0x005297CA File Offset: 0x005279CA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025681 RID: 153217 RVA: 0x005297E8 File Offset: 0x005279E8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025682 RID: 153218 RVA: 0x00529801 File Offset: 0x00527A01
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025683 RID: 153219 RVA: 0x0052980C File Offset: 0x00527A0C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025684 RID: 153220 RVA: 0x0052981C File Offset: 0x00527A1C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025685 RID: 153221 RVA: 0x0052985C File Offset: 0x00527A5C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025686 RID: 153222 RVA: 0x00529876 File Offset: 0x00527A76
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025687 RID: 153223 RVA: 0x00529894 File Offset: 0x00527A94
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025688 RID: 153224 RVA: 0x005298AD File Offset: 0x00527AAD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025689 RID: 153225 RVA: 0x005298B8 File Offset: 0x00527AB8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602568A RID: 153226 RVA: 0x005298C8 File Offset: 0x00527AC8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602568B RID: 153227 RVA: 0x00529908 File Offset: 0x00527B08
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602568C RID: 153228 RVA: 0x00529922 File Offset: 0x00527B22
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602568D RID: 153229 RVA: 0x00529940 File Offset: 0x00527B40
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602568E RID: 153230 RVA: 0x00529959 File Offset: 0x00527B59
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602568F RID: 153231 RVA: 0x00529964 File Offset: 0x00527B64
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06025690 RID: 153232 RVA: 0x00529974 File Offset: 0x00527B74
		public static void AddTitanEntityId(FlatBufferBuilder builder, int titanEntityId)
		{
			builder.AddInt(5, titanEntityId, 0);
		}

		// Token: 0x06025691 RID: 153233 RVA: 0x0052997F File Offset: 0x00527B7F
		public static void AddMinPitchAngle(FlatBufferBuilder builder, float minPitchAngle)
		{
			builder.AddFloat(6, minPitchAngle, 0.0);
		}

		// Token: 0x06025692 RID: 153234 RVA: 0x00529992 File Offset: 0x00527B92
		public static void AddDefaultPitchAngle(FlatBufferBuilder builder, float defaultPitchAngle)
		{
			builder.AddFloat(7, defaultPitchAngle, 0.0);
		}

		// Token: 0x06025693 RID: 153235 RVA: 0x005299A5 File Offset: 0x00527BA5
		public static void AddMaxPitchAngle(FlatBufferBuilder builder, float maxPitchAngle)
		{
			builder.AddFloat(8, maxPitchAngle, 0.0);
		}

		// Token: 0x06025694 RID: 153236 RVA: 0x005299B8 File Offset: 0x00527BB8
		public static void AddMaxYawAngleDelta(FlatBufferBuilder builder, float maxYawAngleDelta)
		{
			builder.AddFloat(9, maxYawAngleDelta, 0.0);
		}

		// Token: 0x06025695 RID: 153237 RVA: 0x005299CC File Offset: 0x00527BCC
		public static void AddFlySpeed(FlatBufferBuilder builder, float flySpeed)
		{
			builder.AddFloat(10, flySpeed, 0.0);
		}

		// Token: 0x06025696 RID: 153238 RVA: 0x005299E0 File Offset: 0x00527BE0
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(11, gravity, 0.0);
		}

		// Token: 0x06025697 RID: 153239 RVA: 0x005299F4 File Offset: 0x00527BF4
		public static void AddTargetList(FlatBufferBuilder builder, VectorOffset targetListOffset)
		{
			builder.AddOffset(12, targetListOffset.Value, 0);
		}

		// Token: 0x06025698 RID: 153240 RVA: 0x00529A08 File Offset: 0x00527C08
		public static VectorOffset CreateTargetListVector(FlatBufferBuilder builder, Offset<IPilotThrowTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025699 RID: 153241 RVA: 0x00529A48 File Offset: 0x00527C48
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, Offset<IPilotThrowTarget>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPilotThrowTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602569A RID: 153242 RVA: 0x00529A62 File Offset: 0x00527C62
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPilotThrowTarget>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPilotThrowTarget>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602569B RID: 153243 RVA: 0x00529A80 File Offset: 0x00527C80
		public static VectorOffset CreateTargetListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPilotThrowTarget>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602569C RID: 153244 RVA: 0x00529A99 File Offset: 0x00527C99
		public static void StartTargetListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602569D RID: 153245 RVA: 0x00529AA4 File Offset: 0x00527CA4
		public static void AddAutoThrowType(FlatBufferBuilder builder, EPilotThrowAutoThrowType autoThrowType)
		{
			builder.AddByte(13, (byte)autoThrowType, 0);
		}

		// Token: 0x0602569E RID: 153246 RVA: 0x00529AB0 File Offset: 0x00527CB0
		public static void AddIsAutoRide(FlatBufferBuilder builder, bool isAutoRide)
		{
			builder.AddBool(14, isAutoRide, false);
		}

		// Token: 0x0602569F RID: 153247 RVA: 0x00529ABC File Offset: 0x00527CBC
		public static void AddDisableInterrupt(FlatBufferBuilder builder, bool disableInterrupt)
		{
			builder.AddBool(15, disableInterrupt, false);
		}

		// Token: 0x060256A0 RID: 153248 RVA: 0x00529AC8 File Offset: 0x00527CC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x060256A1 RID: 153249 RVA: 0x00529AD4 File Offset: 0x00527CD4
		public static Offset<IPilotThrow> EndIPilotThrow(FlatBufferBuilder builder)
		{
			return new Offset<IPilotThrow>(builder.EndTable());
		}

		// Token: 0x060256A2 RID: 153250 RVA: 0x00529AE4 File Offset: 0x00527CE4
		public IPilotThrowT UnPack()
		{
			IPilotThrowT pilotThrowT = new IPilotThrowT();
			this.UnPackTo(pilotThrowT);
			return pilotThrowT;
		}

		// Token: 0x060256A3 RID: 153251 RVA: 0x00529B00 File Offset: 0x00527D00
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

		// Token: 0x060256A4 RID: 153252 RVA: 0x00529D28 File Offset: 0x00527F28
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

		// Token: 0x0400EBC9 RID: 60361
		private Table __p;
	}
}
