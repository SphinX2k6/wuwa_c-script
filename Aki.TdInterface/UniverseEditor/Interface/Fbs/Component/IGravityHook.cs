using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532A RID: 21290
	public struct IGravityHook : IFlatbufferObject
	{
		// Token: 0x17009C55 RID: 40021
		// (get) Token: 0x06022CAA RID: 142506 RVA: 0x004D1EA3 File Offset: 0x004D00A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022CAB RID: 142507 RVA: 0x004D1EB0 File Offset: 0x004D00B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022CAC RID: 142508 RVA: 0x004D1EB8 File Offset: 0x004D00B8
		public static IGravityHook GetRootAsIGravityHook(ByteBuffer _bb)
		{
			return IGravityHook.GetRootAsIGravityHook(_bb, default(IGravityHook));
		}

		// Token: 0x06022CAD RID: 142509 RVA: 0x004D1ED4 File Offset: 0x004D00D4
		public static IGravityHook GetRootAsIGravityHook(ByteBuffer _bb, IGravityHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022CAE RID: 142510 RVA: 0x004D1EF1 File Offset: 0x004D00F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022CAF RID: 142511 RVA: 0x004D1F00 File Offset: 0x004D0100
		public IGravityHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C56 RID: 40022
		// (get) Token: 0x06022CB0 RID: 142512 RVA: 0x004D1F10 File Offset: 0x004D0110
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

		// Token: 0x06022CB1 RID: 142513 RVA: 0x004D1F4C File Offset: 0x004D014C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C57 RID: 40023
		// (get) Token: 0x06022CB2 RID: 142514 RVA: 0x004D1FAC File Offset: 0x004D01AC
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

		// Token: 0x06022CB3 RID: 142515 RVA: 0x004D1FD8 File Offset: 0x004D01D8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C58 RID: 40024
		// (get) Token: 0x06022CB4 RID: 142516 RVA: 0x004D2038 File Offset: 0x004D0238
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

		// Token: 0x06022CB5 RID: 142517 RVA: 0x004D2064 File Offset: 0x004D0264
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C59 RID: 40025
		// (get) Token: 0x06022CB6 RID: 142518 RVA: 0x004D20C8 File Offset: 0x004D02C8
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

		// Token: 0x17009C5A RID: 40026
		// (get) Token: 0x06022CB7 RID: 142519 RVA: 0x004D20F4 File Offset: 0x004D02F4
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

		// Token: 0x17009C5B RID: 40027
		// (get) Token: 0x06022CB8 RID: 142520 RVA: 0x004D2154 File Offset: 0x004D0354
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022CB9 RID: 142521 RVA: 0x004D2194 File Offset: 0x004D0394
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022CBA RID: 142522 RVA: 0x004D21DC File Offset: 0x004D03DC
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06022CBB RID: 142523 RVA: 0x004D21F8 File Offset: 0x004D03F8
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06022CBC RID: 142524 RVA: 0x004D2214 File Offset: 0x004D0414
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06022CBD RID: 142525 RVA: 0x004D2230 File Offset: 0x004D0430
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17009C5C RID: 40028
		// (get) Token: 0x06022CBE RID: 142526 RVA: 0x004D224C File Offset: 0x004D044C
		public int SafePointId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C5D RID: 40029
		// (get) Token: 0x06022CBF RID: 142527 RVA: 0x004D228C File Offset: 0x004D048C
		public int CameraLookAtPointId
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

		// Token: 0x17009C5E RID: 40030
		// (get) Token: 0x06022CC0 RID: 142528 RVA: 0x004D22CC File Offset: 0x004D04CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022CC1 RID: 142529 RVA: 0x004D230C File Offset: 0x004D050C
		public static Offset<IGravityHook> CreateIGravityHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, int SafePointId = 0, int CameraLookAtPointId = 0, byte NullMask = 0)
		{
			builder.StartTable(10);
			IGravityHook.AddCameraLookAtPointId(builder, CameraLookAtPointId);
			IGravityHook.AddSafePointId(builder, SafePointId);
			IGravityHook.AddGravityDirection(builder, GravityDirectionOffset);
			IGravityHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IGravityHook.AddFinishActions(builder, FinishActionsOffset);
			IGravityHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IGravityHook.AddHookActions(builder, HookActionsOffset);
			IGravityHook.AddNullMask(builder, NullMask);
			IGravityHook.AddGravityDirectionType(builder, GravityDirection_type);
			IGravityHook.AddType(builder, Type);
			return IGravityHook.EndIGravityHook(builder);
		}

		// Token: 0x06022CC2 RID: 142530 RVA: 0x004D2374 File Offset: 0x004D0574
		public static void StartIGravityHook(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06022CC3 RID: 142531 RVA: 0x004D237E File Offset: 0x004D057E
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022CC4 RID: 142532 RVA: 0x004D2389 File Offset: 0x004D0589
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06022CC5 RID: 142533 RVA: 0x004D239C File Offset: 0x004D059C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022CC6 RID: 142534 RVA: 0x004D23DC File Offset: 0x004D05DC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CC7 RID: 142535 RVA: 0x004D23F6 File Offset: 0x004D05F6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CC8 RID: 142536 RVA: 0x004D2414 File Offset: 0x004D0614
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022CC9 RID: 142537 RVA: 0x004D242D File Offset: 0x004D062D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022CCA RID: 142538 RVA: 0x004D2438 File Offset: 0x004D0638
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06022CCB RID: 142539 RVA: 0x004D2448 File Offset: 0x004D0648
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022CCC RID: 142540 RVA: 0x004D2488 File Offset: 0x004D0688
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CCD RID: 142541 RVA: 0x004D24A2 File Offset: 0x004D06A2
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CCE RID: 142542 RVA: 0x004D24C0 File Offset: 0x004D06C0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022CCF RID: 142543 RVA: 0x004D24D9 File Offset: 0x004D06D9
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022CD0 RID: 142544 RVA: 0x004D24E4 File Offset: 0x004D06E4
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06022CD1 RID: 142545 RVA: 0x004D24F4 File Offset: 0x004D06F4
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022CD2 RID: 142546 RVA: 0x004D2534 File Offset: 0x004D0734
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CD3 RID: 142547 RVA: 0x004D254E File Offset: 0x004D074E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CD4 RID: 142548 RVA: 0x004D256C File Offset: 0x004D076C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022CD5 RID: 142549 RVA: 0x004D2585 File Offset: 0x004D0785
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022CD6 RID: 142550 RVA: 0x004D2590 File Offset: 0x004D0790
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06022CD7 RID: 142551 RVA: 0x004D25A0 File Offset: 0x004D07A0
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(5, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06022CD8 RID: 142552 RVA: 0x004D25AB File Offset: 0x004D07AB
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(6, gravityDirectionOffset, 0);
		}

		// Token: 0x06022CD9 RID: 142553 RVA: 0x004D25B6 File Offset: 0x004D07B6
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(7, safePointId, 0);
		}

		// Token: 0x06022CDA RID: 142554 RVA: 0x004D25C1 File Offset: 0x004D07C1
		public static void AddCameraLookAtPointId(FlatBufferBuilder builder, int cameraLookAtPointId)
		{
			builder.AddInt(8, cameraLookAtPointId, 0);
		}

		// Token: 0x06022CDB RID: 142555 RVA: 0x004D25CC File Offset: 0x004D07CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06022CDC RID: 142556 RVA: 0x004D25D8 File Offset: 0x004D07D8
		public static Offset<IGravityHook> EndIGravityHook(FlatBufferBuilder builder)
		{
			return new Offset<IGravityHook>(builder.EndTable());
		}

		// Token: 0x06022CDD RID: 142557 RVA: 0x004D25E8 File Offset: 0x004D07E8
		public IGravityHookT UnPack()
		{
			IGravityHookT gravityHookT = new IGravityHookT();
			this.UnPackTo(gravityHookT);
			return gravityHookT;
		}

		// Token: 0x06022CDE RID: 142558 RVA: 0x004D2604 File Offset: 0x004D0804
		public void UnPackTo(IGravityHookT _o)
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
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.SafePointId = this.SafePointId;
			_o.CameraLookAtPointId = this.CameraLookAtPointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022CDF RID: 142559 RVA: 0x004D2898 File Offset: 0x004D0A98
		public static Offset<IGravityHook> Pack(FlatBufferBuilder builder, IGravityHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IGravityHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IGravityHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IGravityHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return IGravityHook.CreateIGravityHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, gravityDirection_type, gravityDirectionOffset, _o.SafePointId, _o.CameraLookAtPointId, _o.NullMask);
		}

		// Token: 0x0400E4E6 RID: 58598
		private Table __p;
	}
}
