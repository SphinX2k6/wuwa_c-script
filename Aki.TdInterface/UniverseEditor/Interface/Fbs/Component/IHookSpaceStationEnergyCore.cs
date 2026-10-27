using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DA RID: 21466
	public struct IHookSpaceStationEnergyCore : IFlatbufferObject
	{
		// Token: 0x17009DE9 RID: 40425
		// (get) Token: 0x060233A1 RID: 144289 RVA: 0x004E0BE7 File Offset: 0x004DEDE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233A2 RID: 144290 RVA: 0x004E0BF4 File Offset: 0x004DEDF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233A3 RID: 144291 RVA: 0x004E0BFC File Offset: 0x004DEDFC
		public static IHookSpaceStationEnergyCore GetRootAsIHookSpaceStationEnergyCore(ByteBuffer _bb)
		{
			return IHookSpaceStationEnergyCore.GetRootAsIHookSpaceStationEnergyCore(_bb, default(IHookSpaceStationEnergyCore));
		}

		// Token: 0x060233A4 RID: 144292 RVA: 0x004E0C18 File Offset: 0x004DEE18
		public static IHookSpaceStationEnergyCore GetRootAsIHookSpaceStationEnergyCore(ByteBuffer _bb, IHookSpaceStationEnergyCore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233A5 RID: 144293 RVA: 0x004E0C35 File Offset: 0x004DEE35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060233A6 RID: 144294 RVA: 0x004E0C44 File Offset: 0x004DEE44
		public IHookSpaceStationEnergyCore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DEA RID: 40426
		// (get) Token: 0x060233A7 RID: 144295 RVA: 0x004E0C54 File Offset: 0x004DEE54
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

		// Token: 0x060233A8 RID: 144296 RVA: 0x004E0C90 File Offset: 0x004DEE90
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DEB RID: 40427
		// (get) Token: 0x060233A9 RID: 144297 RVA: 0x004E0CF0 File Offset: 0x004DEEF0
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

		// Token: 0x060233AA RID: 144298 RVA: 0x004E0D1C File Offset: 0x004DEF1C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DEC RID: 40428
		// (get) Token: 0x060233AB RID: 144299 RVA: 0x004E0D7C File Offset: 0x004DEF7C
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

		// Token: 0x060233AC RID: 144300 RVA: 0x004E0DA8 File Offset: 0x004DEFA8
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DED RID: 40429
		// (get) Token: 0x060233AD RID: 144301 RVA: 0x004E0E0C File Offset: 0x004DF00C
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

		// Token: 0x17009DEE RID: 40430
		// (get) Token: 0x060233AE RID: 144302 RVA: 0x004E0E38 File Offset: 0x004DF038
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

		// Token: 0x17009DEF RID: 40431
		// (get) Token: 0x060233AF RID: 144303 RVA: 0x004E0E98 File Offset: 0x004DF098
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

		// Token: 0x17009DF0 RID: 40432
		// (get) Token: 0x060233B0 RID: 144304 RVA: 0x004E0ED8 File Offset: 0x004DF0D8
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

		// Token: 0x060233B1 RID: 144305 RVA: 0x004E0F18 File Offset: 0x004DF118
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

		// Token: 0x060233B2 RID: 144306 RVA: 0x004E0F67 File Offset: 0x004DF167
		public static void StartIHookSpaceStationEnergyCore(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060233B3 RID: 144307 RVA: 0x004E0F70 File Offset: 0x004DF170
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060233B4 RID: 144308 RVA: 0x004E0F7B File Offset: 0x004DF17B
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060233B5 RID: 144309 RVA: 0x004E0F8C File Offset: 0x004DF18C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060233B6 RID: 144310 RVA: 0x004E0FCC File Offset: 0x004DF1CC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233B7 RID: 144311 RVA: 0x004E0FE6 File Offset: 0x004DF1E6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233B8 RID: 144312 RVA: 0x004E1004 File Offset: 0x004DF204
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060233B9 RID: 144313 RVA: 0x004E101D File Offset: 0x004DF21D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060233BA RID: 144314 RVA: 0x004E1028 File Offset: 0x004DF228
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060233BB RID: 144315 RVA: 0x004E1038 File Offset: 0x004DF238
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060233BC RID: 144316 RVA: 0x004E1078 File Offset: 0x004DF278
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233BD RID: 144317 RVA: 0x004E1092 File Offset: 0x004DF292
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233BE RID: 144318 RVA: 0x004E10B0 File Offset: 0x004DF2B0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060233BF RID: 144319 RVA: 0x004E10C9 File Offset: 0x004DF2C9
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060233C0 RID: 144320 RVA: 0x004E10D4 File Offset: 0x004DF2D4
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060233C1 RID: 144321 RVA: 0x004E10E4 File Offset: 0x004DF2E4
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060233C2 RID: 144322 RVA: 0x004E1124 File Offset: 0x004DF324
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233C3 RID: 144323 RVA: 0x004E113E File Offset: 0x004DF33E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060233C4 RID: 144324 RVA: 0x004E115C File Offset: 0x004DF35C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060233C5 RID: 144325 RVA: 0x004E1175 File Offset: 0x004DF375
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060233C6 RID: 144326 RVA: 0x004E1180 File Offset: 0x004DF380
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060233C7 RID: 144327 RVA: 0x004E1190 File Offset: 0x004DF390
		public static void AddHookSpeed(FlatBufferBuilder builder, int hookSpeed)
		{
			builder.AddInt(5, hookSpeed, 0);
		}

		// Token: 0x060233C8 RID: 144328 RVA: 0x004E119B File Offset: 0x004DF39B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060233C9 RID: 144329 RVA: 0x004E11A6 File Offset: 0x004DF3A6
		public static Offset<IHookSpaceStationEnergyCore> EndIHookSpaceStationEnergyCore(FlatBufferBuilder builder)
		{
			return new Offset<IHookSpaceStationEnergyCore>(builder.EndTable());
		}

		// Token: 0x060233CA RID: 144330 RVA: 0x004E11B4 File Offset: 0x004DF3B4
		public IHookSpaceStationEnergyCoreT UnPack()
		{
			IHookSpaceStationEnergyCoreT hookSpaceStationEnergyCoreT = new IHookSpaceStationEnergyCoreT();
			this.UnPackTo(hookSpaceStationEnergyCoreT);
			return hookSpaceStationEnergyCoreT;
		}

		// Token: 0x060233CB RID: 144331 RVA: 0x004E11D0 File Offset: 0x004DF3D0
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

		// Token: 0x060233CC RID: 144332 RVA: 0x004E1330 File Offset: 0x004DF530
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

		// Token: 0x0400E60F RID: 58895
		private Table __p;
	}
}
