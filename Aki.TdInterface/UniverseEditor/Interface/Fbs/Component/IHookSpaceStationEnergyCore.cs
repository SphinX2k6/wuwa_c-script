using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005960 RID: 22880
	public struct IHookSpaceStationEnergyCore : IFlatbufferObject
	{
		// Token: 0x1700A623 RID: 42531
		// (get) Token: 0x06025459 RID: 152665 RVA: 0x0051DC13 File Offset: 0x0051BE13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602545A RID: 152666 RVA: 0x0051DC20 File Offset: 0x0051BE20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602545B RID: 152667 RVA: 0x0051DC28 File Offset: 0x0051BE28
		public static IHookSpaceStationEnergyCore GetRootAsIHookSpaceStationEnergyCore(ByteBuffer _bb)
		{
			return IHookSpaceStationEnergyCore.GetRootAsIHookSpaceStationEnergyCore(_bb, default(IHookSpaceStationEnergyCore));
		}

		// Token: 0x0602545C RID: 152668 RVA: 0x0051DC44 File Offset: 0x0051BE44
		public static IHookSpaceStationEnergyCore GetRootAsIHookSpaceStationEnergyCore(ByteBuffer _bb, IHookSpaceStationEnergyCore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602545D RID: 152669 RVA: 0x0051DC61 File Offset: 0x0051BE61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602545E RID: 152670 RVA: 0x0051DC70 File Offset: 0x0051BE70
		public IHookSpaceStationEnergyCore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A624 RID: 42532
		// (get) Token: 0x0602545F RID: 152671 RVA: 0x0051DC80 File Offset: 0x0051BE80
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

		// Token: 0x06025460 RID: 152672 RVA: 0x0051DCBC File Offset: 0x0051BEBC
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A625 RID: 42533
		// (get) Token: 0x06025461 RID: 152673 RVA: 0x0051DD1C File Offset: 0x0051BF1C
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

		// Token: 0x06025462 RID: 152674 RVA: 0x0051DD48 File Offset: 0x0051BF48
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A626 RID: 42534
		// (get) Token: 0x06025463 RID: 152675 RVA: 0x0051DDA8 File Offset: 0x0051BFA8
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

		// Token: 0x06025464 RID: 152676 RVA: 0x0051DDD4 File Offset: 0x0051BFD4
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A627 RID: 42535
		// (get) Token: 0x06025465 RID: 152677 RVA: 0x0051DE38 File Offset: 0x0051C038
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

		// Token: 0x1700A628 RID: 42536
		// (get) Token: 0x06025466 RID: 152678 RVA: 0x0051DE64 File Offset: 0x0051C064
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

		// Token: 0x1700A629 RID: 42537
		// (get) Token: 0x06025467 RID: 152679 RVA: 0x0051DEC4 File Offset: 0x0051C0C4
		public int HookSpeed
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

		// Token: 0x1700A62A RID: 42538
		// (get) Token: 0x06025468 RID: 152680 RVA: 0x0051DF04 File Offset: 0x0051C104
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025469 RID: 152681 RVA: 0x0051DF44 File Offset: 0x0051C144
		public static Offset<IHookSpaceStationEnergyCore> CreateIHookSpaceStationEnergyCore(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), int HookSpeed = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IHookSpaceStationEnergyCore.AddHookSpeed(builder, HookSpeed);
			IHookSpaceStationEnergyCore.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IHookSpaceStationEnergyCore.AddFinishActions(builder, FinishActionsOffset);
			IHookSpaceStationEnergyCore.AddExitHookActions(builder, ExitHookActionsOffset);
			IHookSpaceStationEnergyCore.AddHookActions(builder, HookActionsOffset);
			IHookSpaceStationEnergyCore.AddNullMask(builder, NullMask);
			IHookSpaceStationEnergyCore.AddType(builder, Type);
			return IHookSpaceStationEnergyCore.EndIHookSpaceStationEnergyCore(builder);
		}

		// Token: 0x0602546A RID: 152682 RVA: 0x0051DF93 File Offset: 0x0051C193
		public static void StartIHookSpaceStationEnergyCore(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602546B RID: 152683 RVA: 0x0051DF9C File Offset: 0x0051C19C
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602546C RID: 152684 RVA: 0x0051DFA7 File Offset: 0x0051C1A7
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602546D RID: 152685 RVA: 0x0051DFB8 File Offset: 0x0051C1B8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602546E RID: 152686 RVA: 0x0051DFF8 File Offset: 0x0051C1F8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602546F RID: 152687 RVA: 0x0051E012 File Offset: 0x0051C212
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025470 RID: 152688 RVA: 0x0051E030 File Offset: 0x0051C230
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025471 RID: 152689 RVA: 0x0051E049 File Offset: 0x0051C249
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025472 RID: 152690 RVA: 0x0051E054 File Offset: 0x0051C254
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025473 RID: 152691 RVA: 0x0051E064 File Offset: 0x0051C264
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025474 RID: 152692 RVA: 0x0051E0A4 File Offset: 0x0051C2A4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025475 RID: 152693 RVA: 0x0051E0BE File Offset: 0x0051C2BE
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025476 RID: 152694 RVA: 0x0051E0DC File Offset: 0x0051C2DC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025477 RID: 152695 RVA: 0x0051E0F5 File Offset: 0x0051C2F5
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025478 RID: 152696 RVA: 0x0051E100 File Offset: 0x0051C300
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025479 RID: 152697 RVA: 0x0051E110 File Offset: 0x0051C310
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602547A RID: 152698 RVA: 0x0051E150 File Offset: 0x0051C350
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602547B RID: 152699 RVA: 0x0051E16A File Offset: 0x0051C36A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602547C RID: 152700 RVA: 0x0051E188 File Offset: 0x0051C388
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602547D RID: 152701 RVA: 0x0051E1A1 File Offset: 0x0051C3A1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602547E RID: 152702 RVA: 0x0051E1AC File Offset: 0x0051C3AC
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602547F RID: 152703 RVA: 0x0051E1BC File Offset: 0x0051C3BC
		public static void AddHookSpeed(FlatBufferBuilder builder, int hookSpeed)
		{
			builder.AddInt(5, hookSpeed, 0);
		}

		// Token: 0x06025480 RID: 152704 RVA: 0x0051E1C7 File Offset: 0x0051C3C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025481 RID: 152705 RVA: 0x0051E1D2 File Offset: 0x0051C3D2
		public static Offset<IHookSpaceStationEnergyCore> EndIHookSpaceStationEnergyCore(FlatBufferBuilder builder)
		{
			return new Offset<IHookSpaceStationEnergyCore>(builder.EndTable());
		}

		// Token: 0x06025482 RID: 152706 RVA: 0x0051E1E0 File Offset: 0x0051C3E0
		public IHookSpaceStationEnergyCoreT UnPack()
		{
			IHookSpaceStationEnergyCoreT hookSpaceStationEnergyCoreT = new IHookSpaceStationEnergyCoreT();
			this.UnPackTo(hookSpaceStationEnergyCoreT);
			return hookSpaceStationEnergyCoreT;
		}

		// Token: 0x06025483 RID: 152707 RVA: 0x0051E1FC File Offset: 0x0051C3FC
		public void UnPackTo(IHookSpaceStationEnergyCoreT _o)
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
			_o.HookSpeed = this.HookSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025484 RID: 152708 RVA: 0x0051E35C File Offset: 0x0051C55C
		public static Offset<IHookSpaceStationEnergyCore> Pack(FlatBufferBuilder builder, IHookSpaceStationEnergyCoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookSpaceStationEnergyCore>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IHookSpaceStationEnergyCore.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IHookSpaceStationEnergyCore.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IHookSpaceStationEnergyCore.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IHookSpaceStationEnergyCore.CreateIHookSpaceStationEnergyCore(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.HookSpeed, _o.NullMask);
		}

		// Token: 0x0400F240 RID: 62016
		private Table __p;
	}
}
