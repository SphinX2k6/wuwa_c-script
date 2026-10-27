using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8B RID: 20363
	public struct IChargeSlashHook : IFlatbufferObject
	{
		// Token: 0x17009334 RID: 37684
		// (get) Token: 0x06020569 RID: 132457 RVA: 0x0047FB0E File Offset: 0x0047DD0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602056A RID: 132458 RVA: 0x0047FB1B File Offset: 0x0047DD1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602056B RID: 132459 RVA: 0x0047FB24 File Offset: 0x0047DD24
		public static IChargeSlashHook GetRootAsIChargeSlashHook(ByteBuffer _bb)
		{
			return IChargeSlashHook.GetRootAsIChargeSlashHook(_bb, default(IChargeSlashHook));
		}

		// Token: 0x0602056C RID: 132460 RVA: 0x0047FB40 File Offset: 0x0047DD40
		public static IChargeSlashHook GetRootAsIChargeSlashHook(ByteBuffer _bb, IChargeSlashHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602056D RID: 132461 RVA: 0x0047FB5D File Offset: 0x0047DD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602056E RID: 132462 RVA: 0x0047FB6C File Offset: 0x0047DD6C
		public IChargeSlashHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009335 RID: 37685
		// (get) Token: 0x0602056F RID: 132463 RVA: 0x0047FB7C File Offset: 0x0047DD7C
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

		// Token: 0x06020570 RID: 132464 RVA: 0x0047FBB8 File Offset: 0x0047DDB8
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009336 RID: 37686
		// (get) Token: 0x06020571 RID: 132465 RVA: 0x0047FC18 File Offset: 0x0047DE18
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

		// Token: 0x06020572 RID: 132466 RVA: 0x0047FC44 File Offset: 0x0047DE44
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009337 RID: 37687
		// (get) Token: 0x06020573 RID: 132467 RVA: 0x0047FCA4 File Offset: 0x0047DEA4
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

		// Token: 0x06020574 RID: 132468 RVA: 0x0047FCD0 File Offset: 0x0047DED0
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009338 RID: 37688
		// (get) Token: 0x06020575 RID: 132469 RVA: 0x0047FD34 File Offset: 0x0047DF34
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

		// Token: 0x17009339 RID: 37689
		// (get) Token: 0x06020576 RID: 132470 RVA: 0x0047FD60 File Offset: 0x0047DF60
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

		// Token: 0x06020577 RID: 132471 RVA: 0x0047FDC0 File Offset: 0x0047DFC0
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700933A RID: 37690
		// (get) Token: 0x06020578 RID: 132472 RVA: 0x0047FE00 File Offset: 0x0047E000
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

		// Token: 0x06020579 RID: 132473 RVA: 0x0047FE2C File Offset: 0x0047E02C
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0602057A RID: 132474 RVA: 0x0047FE3C File Offset: 0x0047E03C
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700933B RID: 37691
		// (get) Token: 0x0602057B RID: 132475 RVA: 0x0047FE4C File Offset: 0x0047E04C
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

		// Token: 0x1700933C RID: 37692
		// (get) Token: 0x0602057C RID: 132476 RVA: 0x0047FE90 File Offset: 0x0047E090
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

		// Token: 0x1700933D RID: 37693
		// (get) Token: 0x0602057D RID: 132477 RVA: 0x0047FEF0 File Offset: 0x0047E0F0
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

		// Token: 0x1700933E RID: 37694
		// (get) Token: 0x0602057E RID: 132478 RVA: 0x0047FF30 File Offset: 0x0047E130
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

		// Token: 0x1700933F RID: 37695
		// (get) Token: 0x0602057F RID: 132479 RVA: 0x0047FF70 File Offset: 0x0047E170
		public bool IsAdjustCameraConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009340 RID: 37696
		// (get) Token: 0x06020580 RID: 132480 RVA: 0x0047FFB0 File Offset: 0x0047E1B0
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

		// Token: 0x06020581 RID: 132481 RVA: 0x0047FFF0 File Offset: 0x0047E1F0
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

		// Token: 0x06020582 RID: 132482 RVA: 0x00480068 File Offset: 0x0047E268
		public static void StartIChargeSlashHook(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06020583 RID: 132483 RVA: 0x00480072 File Offset: 0x0047E272
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020584 RID: 132484 RVA: 0x0048007D File Offset: 0x0047E27D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06020585 RID: 132485 RVA: 0x00480090 File Offset: 0x0047E290
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020586 RID: 132486 RVA: 0x004800D0 File Offset: 0x0047E2D0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020587 RID: 132487 RVA: 0x004800EA File Offset: 0x0047E2EA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020588 RID: 132488 RVA: 0x00480108 File Offset: 0x0047E308
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020589 RID: 132489 RVA: 0x00480121 File Offset: 0x0047E321
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602058A RID: 132490 RVA: 0x0048012C File Offset: 0x0047E32C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602058B RID: 132491 RVA: 0x0048013C File Offset: 0x0047E33C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602058C RID: 132492 RVA: 0x0048017C File Offset: 0x0047E37C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602058D RID: 132493 RVA: 0x00480196 File Offset: 0x0047E396
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602058E RID: 132494 RVA: 0x004801B4 File Offset: 0x0047E3B4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602058F RID: 132495 RVA: 0x004801CD File Offset: 0x0047E3CD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020590 RID: 132496 RVA: 0x004801D8 File Offset: 0x0047E3D8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06020591 RID: 132497 RVA: 0x004801E8 File Offset: 0x0047E3E8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020592 RID: 132498 RVA: 0x00480228 File Offset: 0x0047E428
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020593 RID: 132499 RVA: 0x00480242 File Offset: 0x0047E442
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020594 RID: 132500 RVA: 0x00480260 File Offset: 0x0047E460
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020595 RID: 132501 RVA: 0x00480279 File Offset: 0x0047E479
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020596 RID: 132502 RVA: 0x00480284 File Offset: 0x0047E484
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x00480294 File Offset: 0x0047E494
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(5, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x004802A4 File Offset: 0x0047E4A4
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020599 RID: 132505 RVA: 0x004802DB File Offset: 0x0047E4DB
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602059A RID: 132506 RVA: 0x004802F5 File Offset: 0x0047E4F5
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602059B RID: 132507 RVA: 0x00480313 File Offset: 0x0047E513
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602059C RID: 132508 RVA: 0x0048032C File Offset: 0x0047E52C
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602059D RID: 132509 RVA: 0x00480337 File Offset: 0x0047E537
		public static void AddMaxRandomDelayTime(FlatBufferBuilder builder, float maxRandomDelayTime)
		{
			builder.AddFloat(6, maxRandomDelayTime, 0.0);
		}

		// Token: 0x0602059E RID: 132510 RVA: 0x0048034A File Offset: 0x0047E54A
		public static void AddCharacterLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> characterLookAtOffset)
		{
			builder.AddOffset(7, characterLookAtOffset.Value, 0);
		}

		// Token: 0x0602059F RID: 132511 RVA: 0x0048035A File Offset: 0x0047E55A
		public static void AddCharacterLookAtPointId(FlatBufferBuilder builder, int characterLookAtPointId)
		{
			builder.AddInt(8, characterLookAtPointId, 0);
		}

		// Token: 0x060205A0 RID: 132512 RVA: 0x00480365 File Offset: 0x0047E565
		public static void AddSlashBackSafePointId(FlatBufferBuilder builder, int slashBackSafePointId)
		{
			builder.AddInt(9, slashBackSafePointId, 0);
		}

		// Token: 0x060205A1 RID: 132513 RVA: 0x00480371 File Offset: 0x0047E571
		public static void AddIsAdjustCameraConfig(FlatBufferBuilder builder, bool isAdjustCameraConfig)
		{
			builder.AddBool(10, isAdjustCameraConfig, false);
		}

		// Token: 0x060205A2 RID: 132514 RVA: 0x0048037D File Offset: 0x0047E57D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060205A3 RID: 132515 RVA: 0x00480389 File Offset: 0x0047E589
		public static Offset<IChargeSlashHook> EndIChargeSlashHook(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashHook>(builder.EndTable());
		}

		// Token: 0x060205A4 RID: 132516 RVA: 0x00480398 File Offset: 0x0047E598
		public IChargeSlashHookT UnPack()
		{
			IChargeSlashHookT chargeSlashHookT = new IChargeSlashHookT();
			this.UnPackTo(chargeSlashHookT);
			return chargeSlashHookT;
		}

		// Token: 0x060205A5 RID: 132517 RVA: 0x004803B4 File Offset: 0x0047E5B4
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

		// Token: 0x060205A6 RID: 132518 RVA: 0x0048059C File Offset: 0x0047E79C
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

		// Token: 0x0400DE3D RID: 56893
		private Table __p;
	}
}
