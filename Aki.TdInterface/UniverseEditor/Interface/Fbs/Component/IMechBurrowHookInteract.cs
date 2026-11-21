using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC5 RID: 23237
	public struct IMechBurrowHookInteract : IFlatbufferObject
	{
		// Token: 0x1700A953 RID: 43347
		// (get) Token: 0x0602619F RID: 156063 RVA: 0x005381C5 File Offset: 0x005363C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060261A0 RID: 156064 RVA: 0x005381D2 File Offset: 0x005363D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060261A1 RID: 156065 RVA: 0x005381DC File Offset: 0x005363DC
		public static IMechBurrowHookInteract GetRootAsIMechBurrowHookInteract(ByteBuffer _bb)
		{
			return IMechBurrowHookInteract.GetRootAsIMechBurrowHookInteract(_bb, default(IMechBurrowHookInteract));
		}

		// Token: 0x060261A2 RID: 156066 RVA: 0x005381F8 File Offset: 0x005363F8
		public static IMechBurrowHookInteract GetRootAsIMechBurrowHookInteract(ByteBuffer _bb, IMechBurrowHookInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060261A3 RID: 156067 RVA: 0x00538215 File Offset: 0x00536415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060261A4 RID: 156068 RVA: 0x00538224 File Offset: 0x00536424
		public IMechBurrowHookInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A954 RID: 43348
		// (get) Token: 0x060261A5 RID: 156069 RVA: 0x00538234 File Offset: 0x00536434
		public EMechHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechHookInteractType.FixedPointHook;
				}
				return (EMechHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060261A6 RID: 156070 RVA: 0x00538270 File Offset: 0x00536470
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A955 RID: 43349
		// (get) Token: 0x060261A7 RID: 156071 RVA: 0x005382D0 File Offset: 0x005364D0
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

		// Token: 0x060261A8 RID: 156072 RVA: 0x005382FC File Offset: 0x005364FC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A956 RID: 43350
		// (get) Token: 0x060261A9 RID: 156073 RVA: 0x0053835C File Offset: 0x0053655C
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

		// Token: 0x060261AA RID: 156074 RVA: 0x00538388 File Offset: 0x00536588
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A957 RID: 43351
		// (get) Token: 0x060261AB RID: 156075 RVA: 0x005383EC File Offset: 0x005365EC
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

		// Token: 0x1700A958 RID: 43352
		// (get) Token: 0x060261AC RID: 156076 RVA: 0x00538418 File Offset: 0x00536618
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

		// Token: 0x1700A959 RID: 43353
		// (get) Token: 0x060261AD RID: 156077 RVA: 0x00538478 File Offset: 0x00536678
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A95A RID: 43354
		// (get) Token: 0x060261AE RID: 156078 RVA: 0x005384D8 File Offset: 0x005366D8
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A95B RID: 43355
		// (get) Token: 0x060261AF RID: 156079 RVA: 0x00538518 File Offset: 0x00536718
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

		// Token: 0x060261B0 RID: 156080 RVA: 0x00538558 File Offset: 0x00536758
		public static Offset<IMechBurrowHookInteract> CreateIMechBurrowHookInteract(FlatBufferBuilder builder, EMechHookInteractType Type = EMechHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), bool CanInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IMechBurrowHookInteract.AddTargetPos(builder, TargetPosOffset);
			IMechBurrowHookInteract.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechBurrowHookInteract.AddFinishActions(builder, FinishActionsOffset);
			IMechBurrowHookInteract.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechBurrowHookInteract.AddHookActions(builder, HookActionsOffset);
			IMechBurrowHookInteract.AddNullMask(builder, NullMask);
			IMechBurrowHookInteract.AddCanInterrupt(builder, CanInterrupt);
			IMechBurrowHookInteract.AddType(builder, Type);
			return IMechBurrowHookInteract.EndIMechBurrowHookInteract(builder);
		}

		// Token: 0x060261B1 RID: 156081 RVA: 0x005385AF File Offset: 0x005367AF
		public static void StartIMechBurrowHookInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060261B2 RID: 156082 RVA: 0x005385B8 File Offset: 0x005367B8
		public static void AddType(FlatBufferBuilder builder, EMechHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060261B3 RID: 156083 RVA: 0x005385C3 File Offset: 0x005367C3
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060261B4 RID: 156084 RVA: 0x005385D4 File Offset: 0x005367D4
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060261B5 RID: 156085 RVA: 0x00538614 File Offset: 0x00536814
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261B6 RID: 156086 RVA: 0x0053862E File Offset: 0x0053682E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261B7 RID: 156087 RVA: 0x0053864C File Offset: 0x0053684C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060261B8 RID: 156088 RVA: 0x00538665 File Offset: 0x00536865
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060261B9 RID: 156089 RVA: 0x00538670 File Offset: 0x00536870
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060261BA RID: 156090 RVA: 0x00538680 File Offset: 0x00536880
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060261BB RID: 156091 RVA: 0x005386C0 File Offset: 0x005368C0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261BC RID: 156092 RVA: 0x005386DA File Offset: 0x005368DA
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261BD RID: 156093 RVA: 0x005386F8 File Offset: 0x005368F8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060261BE RID: 156094 RVA: 0x00538711 File Offset: 0x00536911
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060261BF RID: 156095 RVA: 0x0053871C File Offset: 0x0053691C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060261C0 RID: 156096 RVA: 0x0053872C File Offset: 0x0053692C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060261C1 RID: 156097 RVA: 0x0053876C File Offset: 0x0053696C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261C2 RID: 156098 RVA: 0x00538786 File Offset: 0x00536986
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261C3 RID: 156099 RVA: 0x005387A4 File Offset: 0x005369A4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060261C4 RID: 156100 RVA: 0x005387BD File Offset: 0x005369BD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060261C5 RID: 156101 RVA: 0x005387C8 File Offset: 0x005369C8
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060261C6 RID: 156102 RVA: 0x005387D8 File Offset: 0x005369D8
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(5, targetPosOffset.Value, 0);
		}

		// Token: 0x060261C7 RID: 156103 RVA: 0x005387E8 File Offset: 0x005369E8
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(6, canInterrupt, false);
		}

		// Token: 0x060261C8 RID: 156104 RVA: 0x005387F3 File Offset: 0x005369F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060261C9 RID: 156105 RVA: 0x005387FE File Offset: 0x005369FE
		public static Offset<IMechBurrowHookInteract> EndIMechBurrowHookInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMechBurrowHookInteract>(builder.EndTable());
		}

		// Token: 0x060261CA RID: 156106 RVA: 0x0053880C File Offset: 0x00536A0C
		public IMechBurrowHookInteractT UnPack()
		{
			IMechBurrowHookInteractT mechBurrowHookInteractT = new IMechBurrowHookInteractT();
			this.UnPackTo(mechBurrowHookInteractT);
			return mechBurrowHookInteractT;
		}

		// Token: 0x060261CB RID: 156107 RVA: 0x00538828 File Offset: 0x00536A28
		public void UnPackTo(IMechBurrowHookInteractT _o)
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
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.CanInterrupt = this.CanInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060261CC RID: 156108 RVA: 0x005389BC File Offset: 0x00536BBC
		public static Offset<IMechBurrowHookInteract> Pack(FlatBufferBuilder builder, IMechBurrowHookInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechBurrowHookInteract>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechBurrowHookInteract.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechBurrowHookInteract.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechBurrowHookInteract.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IMechBurrowHookInteract.CreateIMechBurrowHookInteract(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, targetPosOffset, _o.CanInterrupt, _o.NullMask);
		}

		// Token: 0x0400F46E RID: 62574
		private Table __p;
	}
}
