using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BA RID: 21690
	public struct IChargeSlashHook : IFlatbufferObject
	{
		// Token: 0x17009AAD RID: 39597
		// (get) Token: 0x060222BB RID: 139963 RVA: 0x004B5AFE File Offset: 0x004B3CFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222BC RID: 139964 RVA: 0x004B5B0B File Offset: 0x004B3D0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222BD RID: 139965 RVA: 0x004B5B14 File Offset: 0x004B3D14
		public static IChargeSlashHook GetRootAsIChargeSlashHook(ByteBuffer _bb)
		{
			return IChargeSlashHook.GetRootAsIChargeSlashHook(_bb, default(IChargeSlashHook));
		}

		// Token: 0x060222BE RID: 139966 RVA: 0x004B5B30 File Offset: 0x004B3D30
		public static IChargeSlashHook GetRootAsIChargeSlashHook(ByteBuffer _bb, IChargeSlashHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060222BF RID: 139967 RVA: 0x004B5B4D File Offset: 0x004B3D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060222C0 RID: 139968 RVA: 0x004B5B5C File Offset: 0x004B3D5C
		public IChargeSlashHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AAE RID: 39598
		// (get) Token: 0x060222C1 RID: 139969 RVA: 0x004B5B6C File Offset: 0x004B3D6C
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

		// Token: 0x060222C2 RID: 139970 RVA: 0x004B5BA8 File Offset: 0x004B3DA8
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AAF RID: 39599
		// (get) Token: 0x060222C3 RID: 139971 RVA: 0x004B5C08 File Offset: 0x004B3E08
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

		// Token: 0x060222C4 RID: 139972 RVA: 0x004B5C34 File Offset: 0x004B3E34
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AB0 RID: 39600
		// (get) Token: 0x060222C5 RID: 139973 RVA: 0x004B5C94 File Offset: 0x004B3E94
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

		// Token: 0x060222C6 RID: 139974 RVA: 0x004B5CC0 File Offset: 0x004B3EC0
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AB1 RID: 39601
		// (get) Token: 0x060222C7 RID: 139975 RVA: 0x004B5D24 File Offset: 0x004B3F24
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

		// Token: 0x17009AB2 RID: 39602
		// (get) Token: 0x060222C8 RID: 139976 RVA: 0x004B5D50 File Offset: 0x004B3F50
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

		// Token: 0x060222C9 RID: 139977 RVA: 0x004B5DB0 File Offset: 0x004B3FB0
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009AB3 RID: 39603
		// (get) Token: 0x060222CA RID: 139978 RVA: 0x004B5DF0 File Offset: 0x004B3FF0
		public int TargetEntityIdsLength
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

		// Token: 0x060222CB RID: 139979 RVA: 0x004B5E1C File Offset: 0x004B401C
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060222CC RID: 139980 RVA: 0x004B5E2C File Offset: 0x004B402C
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x17009AB4 RID: 39604
		// (get) Token: 0x060222CD RID: 139981 RVA: 0x004B5E3C File Offset: 0x004B403C
		public float MaxRandomDelayTime
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

		// Token: 0x17009AB5 RID: 39605
		// (get) Token: 0x060222CE RID: 139982 RVA: 0x004B5E80 File Offset: 0x004B4080
		public IVectorInfo? CharacterLookAt
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009AB6 RID: 39606
		// (get) Token: 0x060222CF RID: 139983 RVA: 0x004B5EE0 File Offset: 0x004B40E0
		public int CharacterLookAtPointId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009AB7 RID: 39607
		// (get) Token: 0x060222D0 RID: 139984 RVA: 0x004B5F20 File Offset: 0x004B4120
		public int SlashBackSafePointId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009AB8 RID: 39608
		// (get) Token: 0x060222D1 RID: 139985 RVA: 0x004B5F60 File Offset: 0x004B4160
		public bool IsAdjustCameraConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009AB9 RID: 39609
		// (get) Token: 0x060222D2 RID: 139986 RVA: 0x004B5FA0 File Offset: 0x004B41A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060222D3 RID: 139987 RVA: 0x004B5FE0 File Offset: 0x004B41E0
		public static Offset<IChargeSlashHook> CreateIChargeSlashHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), VectorOffset TargetEntityIdsOffset = default(VectorOffset), float MaxRandomDelayTime = 0f, Offset<IVectorInfo> CharacterLookAtOffset = default(Offset<IVectorInfo>), int CharacterLookAtPointId = 0, int SlashBackSafePointId = 0, bool IsAdjustCameraConfig = false, byte NullMask = 0)
		{
			builder.StartTable(12);
			IChargeSlashHook.AddSlashBackSafePointId(builder, SlashBackSafePointId);
			IChargeSlashHook.AddCharacterLookAtPointId(builder, CharacterLookAtPointId);
			IChargeSlashHook.AddCharacterLookAt(builder, CharacterLookAtOffset);
			IChargeSlashHook.AddMaxRandomDelayTime(builder, MaxRandomDelayTime);
			IChargeSlashHook.AddTargetEntityIds(builder, TargetEntityIdsOffset);
			IChargeSlashHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IChargeSlashHook.AddFinishActions(builder, FinishActionsOffset);
			IChargeSlashHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IChargeSlashHook.AddHookActions(builder, HookActionsOffset);
			IChargeSlashHook.AddNullMask(builder, NullMask);
			IChargeSlashHook.AddIsAdjustCameraConfig(builder, IsAdjustCameraConfig);
			IChargeSlashHook.AddType(builder, Type);
			return IChargeSlashHook.EndIChargeSlashHook(builder);
		}

		// Token: 0x060222D4 RID: 139988 RVA: 0x004B6058 File Offset: 0x004B4258
		public static void StartIChargeSlashHook(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060222D5 RID: 139989 RVA: 0x004B6062 File Offset: 0x004B4262
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060222D6 RID: 139990 RVA: 0x004B606D File Offset: 0x004B426D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060222D7 RID: 139991 RVA: 0x004B6080 File Offset: 0x004B4280
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060222D8 RID: 139992 RVA: 0x004B60C0 File Offset: 0x004B42C0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222D9 RID: 139993 RVA: 0x004B60DA File Offset: 0x004B42DA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222DA RID: 139994 RVA: 0x004B60F8 File Offset: 0x004B42F8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222DB RID: 139995 RVA: 0x004B6111 File Offset: 0x004B4311
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222DC RID: 139996 RVA: 0x004B611C File Offset: 0x004B431C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060222DD RID: 139997 RVA: 0x004B612C File Offset: 0x004B432C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060222DE RID: 139998 RVA: 0x004B616C File Offset: 0x004B436C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222DF RID: 139999 RVA: 0x004B6186 File Offset: 0x004B4386
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222E0 RID: 140000 RVA: 0x004B61A4 File Offset: 0x004B43A4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222E1 RID: 140001 RVA: 0x004B61BD File Offset: 0x004B43BD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222E2 RID: 140002 RVA: 0x004B61C8 File Offset: 0x004B43C8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060222E3 RID: 140003 RVA: 0x004B61D8 File Offset: 0x004B43D8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060222E4 RID: 140004 RVA: 0x004B6218 File Offset: 0x004B4418
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222E5 RID: 140005 RVA: 0x004B6232 File Offset: 0x004B4432
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060222E6 RID: 140006 RVA: 0x004B6250 File Offset: 0x004B4450
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222E7 RID: 140007 RVA: 0x004B6269 File Offset: 0x004B4469
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222E8 RID: 140008 RVA: 0x004B6274 File Offset: 0x004B4474
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060222E9 RID: 140009 RVA: 0x004B6284 File Offset: 0x004B4484
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(5, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x060222EA RID: 140010 RVA: 0x004B6294 File Offset: 0x004B4494
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060222EB RID: 140011 RVA: 0x004B62CB File Offset: 0x004B44CB
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222EC RID: 140012 RVA: 0x004B62E5 File Offset: 0x004B44E5
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222ED RID: 140013 RVA: 0x004B6303 File Offset: 0x004B4503
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222EE RID: 140014 RVA: 0x004B631C File Offset: 0x004B451C
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222EF RID: 140015 RVA: 0x004B6327 File Offset: 0x004B4527
		public static void AddMaxRandomDelayTime(FlatBufferBuilder builder, float maxRandomDelayTime)
		{
			builder.AddFloat(6, maxRandomDelayTime, 0.0);
		}

		// Token: 0x060222F0 RID: 140016 RVA: 0x004B633A File Offset: 0x004B453A
		public static void AddCharacterLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> characterLookAtOffset)
		{
			builder.AddOffset(7, characterLookAtOffset.Value, 0);
		}

		// Token: 0x060222F1 RID: 140017 RVA: 0x004B634A File Offset: 0x004B454A
		public static void AddCharacterLookAtPointId(FlatBufferBuilder builder, int characterLookAtPointId)
		{
			builder.AddInt(8, characterLookAtPointId, 0);
		}

		// Token: 0x060222F2 RID: 140018 RVA: 0x004B6355 File Offset: 0x004B4555
		public static void AddSlashBackSafePointId(FlatBufferBuilder builder, int slashBackSafePointId)
		{
			builder.AddInt(9, slashBackSafePointId, 0);
		}

		// Token: 0x060222F3 RID: 140019 RVA: 0x004B6361 File Offset: 0x004B4561
		public static void AddIsAdjustCameraConfig(FlatBufferBuilder builder, bool isAdjustCameraConfig)
		{
			builder.AddBool(10, isAdjustCameraConfig, false);
		}

		// Token: 0x060222F4 RID: 140020 RVA: 0x004B636D File Offset: 0x004B456D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060222F5 RID: 140021 RVA: 0x004B6379 File Offset: 0x004B4579
		public static Offset<IChargeSlashHook> EndIChargeSlashHook(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashHook>(builder.EndTable());
		}

		// Token: 0x060222F6 RID: 140022 RVA: 0x004B6388 File Offset: 0x004B4588
		public IChargeSlashHookT UnPack()
		{
			IChargeSlashHookT chargeSlashHookT = new IChargeSlashHookT();
			this.UnPackTo(chargeSlashHookT);
			return chargeSlashHookT;
		}

		// Token: 0x060222F7 RID: 140023 RVA: 0x004B63A4 File Offset: 0x004B45A4
		public void UnPackTo(IChargeSlashHookT _o)
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
			_o.TargetEntityIds = new List<int>();
			for (int l = 0; l < this.TargetEntityIdsLength; l++)
			{
				_o.TargetEntityIds.Add(this.TargetEntityIds(l));
			}
			_o.MaxRandomDelayTime = this.MaxRandomDelayTime;
			_o.CharacterLookAt = ((this.CharacterLookAt != null) ? this.CharacterLookAt.Value.UnPack() : null);
			_o.CharacterLookAtPointId = this.CharacterLookAtPointId;
			_o.SlashBackSafePointId = this.SlashBackSafePointId;
			_o.IsAdjustCameraConfig = this.IsAdjustCameraConfig;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060222F8 RID: 140024 RVA: 0x004B658C File Offset: 0x004B478C
		public static Offset<IChargeSlashHook> Pack(FlatBufferBuilder builder, IChargeSlashHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargeSlashHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IChargeSlashHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IChargeSlashHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IChargeSlashHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			VectorOffset targetEntityIdsOffset = default(VectorOffset);
			if (_o.TargetEntityIds != null)
			{
				int[] data = _o.TargetEntityIds.ToArray();
				targetEntityIdsOffset = IChargeSlashHook.CreateTargetEntityIdsVector(builder, data);
			}
			Offset<IVectorInfo> characterLookAtOffset = (_o.CharacterLookAt == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CharacterLookAt);
			return IChargeSlashHook.CreateIChargeSlashHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, targetEntityIdsOffset, _o.MaxRandomDelayTime, characterLookAtOffset, _o.CharacterLookAtPointId, _o.SlashBackSafePointId, _o.IsAdjustCameraConfig, _o.NullMask);
		}

		// Token: 0x0400E9E7 RID: 59879
		private Table __p;
	}
}
