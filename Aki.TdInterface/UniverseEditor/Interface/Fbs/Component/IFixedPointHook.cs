using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005273 RID: 21107
	public struct IFixedPointHook : IFlatbufferObject
	{
		// Token: 0x17009AA7 RID: 39591
		// (get) Token: 0x06022595 RID: 140693 RVA: 0x004C2E5D File Offset: 0x004C105D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022596 RID: 140694 RVA: 0x004C2E6A File Offset: 0x004C106A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022597 RID: 140695 RVA: 0x004C2E74 File Offset: 0x004C1074
		public static IFixedPointHook GetRootAsIFixedPointHook(ByteBuffer _bb)
		{
			return IFixedPointHook.GetRootAsIFixedPointHook(_bb, default(IFixedPointHook));
		}

		// Token: 0x06022598 RID: 140696 RVA: 0x004C2E90 File Offset: 0x004C1090
		public static IFixedPointHook GetRootAsIFixedPointHook(ByteBuffer _bb, IFixedPointHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022599 RID: 140697 RVA: 0x004C2EAD File Offset: 0x004C10AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602259A RID: 140698 RVA: 0x004C2EBC File Offset: 0x004C10BC
		public IFixedPointHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AA8 RID: 39592
		// (get) Token: 0x0602259B RID: 140699 RVA: 0x004C2ECC File Offset: 0x004C10CC
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

		// Token: 0x0602259C RID: 140700 RVA: 0x004C2F08 File Offset: 0x004C1108
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AA9 RID: 39593
		// (get) Token: 0x0602259D RID: 140701 RVA: 0x004C2F68 File Offset: 0x004C1168
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

		// Token: 0x0602259E RID: 140702 RVA: 0x004C2F94 File Offset: 0x004C1194
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AAA RID: 39594
		// (get) Token: 0x0602259F RID: 140703 RVA: 0x004C2FF4 File Offset: 0x004C11F4
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

		// Token: 0x060225A0 RID: 140704 RVA: 0x004C3020 File Offset: 0x004C1220
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AAB RID: 39595
		// (get) Token: 0x060225A1 RID: 140705 RVA: 0x004C3084 File Offset: 0x004C1284
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

		// Token: 0x17009AAC RID: 39596
		// (get) Token: 0x060225A2 RID: 140706 RVA: 0x004C30B0 File Offset: 0x004C12B0
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

		// Token: 0x17009AAD RID: 39597
		// (get) Token: 0x060225A3 RID: 140707 RVA: 0x004C3110 File Offset: 0x004C1310
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060225A4 RID: 140708 RVA: 0x004C314D File Offset: 0x004C134D
		public static Offset<IFixedPointHook> CreateIFixedPointHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFixedPointHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFixedPointHook.AddFinishActions(builder, FinishActionsOffset);
			IFixedPointHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IFixedPointHook.AddHookActions(builder, HookActionsOffset);
			IFixedPointHook.AddNullMask(builder, NullMask);
			IFixedPointHook.AddType(builder, Type);
			return IFixedPointHook.EndIFixedPointHook(builder);
		}

		// Token: 0x060225A5 RID: 140709 RVA: 0x004C3189 File Offset: 0x004C1389
		public static void StartIFixedPointHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060225A6 RID: 140710 RVA: 0x004C3192 File Offset: 0x004C1392
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060225A7 RID: 140711 RVA: 0x004C319D File Offset: 0x004C139D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060225A8 RID: 140712 RVA: 0x004C31B0 File Offset: 0x004C13B0
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060225A9 RID: 140713 RVA: 0x004C31F0 File Offset: 0x004C13F0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225AA RID: 140714 RVA: 0x004C320A File Offset: 0x004C140A
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225AB RID: 140715 RVA: 0x004C3228 File Offset: 0x004C1428
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060225AC RID: 140716 RVA: 0x004C3241 File Offset: 0x004C1441
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060225AD RID: 140717 RVA: 0x004C324C File Offset: 0x004C144C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060225AE RID: 140718 RVA: 0x004C325C File Offset: 0x004C145C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060225AF RID: 140719 RVA: 0x004C329C File Offset: 0x004C149C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225B0 RID: 140720 RVA: 0x004C32B6 File Offset: 0x004C14B6
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225B1 RID: 140721 RVA: 0x004C32D4 File Offset: 0x004C14D4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060225B2 RID: 140722 RVA: 0x004C32ED File Offset: 0x004C14ED
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060225B3 RID: 140723 RVA: 0x004C32F8 File Offset: 0x004C14F8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060225B4 RID: 140724 RVA: 0x004C3308 File Offset: 0x004C1508
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060225B5 RID: 140725 RVA: 0x004C3348 File Offset: 0x004C1548
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225B6 RID: 140726 RVA: 0x004C3362 File Offset: 0x004C1562
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225B7 RID: 140727 RVA: 0x004C3380 File Offset: 0x004C1580
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060225B8 RID: 140728 RVA: 0x004C3399 File Offset: 0x004C1599
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060225B9 RID: 140729 RVA: 0x004C33A4 File Offset: 0x004C15A4
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060225BA RID: 140730 RVA: 0x004C33B4 File Offset: 0x004C15B4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060225BB RID: 140731 RVA: 0x004C33BF File Offset: 0x004C15BF
		public static Offset<IFixedPointHook> EndIFixedPointHook(FlatBufferBuilder builder)
		{
			return new Offset<IFixedPointHook>(builder.EndTable());
		}

		// Token: 0x060225BC RID: 140732 RVA: 0x004C33CC File Offset: 0x004C15CC
		public IFixedPointHookT UnPack()
		{
			IFixedPointHookT fixedPointHookT = new IFixedPointHookT();
			this.UnPackTo(fixedPointHookT);
			return fixedPointHookT;
		}

		// Token: 0x060225BD RID: 140733 RVA: 0x004C33E8 File Offset: 0x004C15E8
		public void UnPackTo(IFixedPointHookT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060225BE RID: 140734 RVA: 0x004C353C File Offset: 0x004C173C
		public static Offset<IFixedPointHook> Pack(FlatBufferBuilder builder, IFixedPointHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedPointHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFixedPointHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFixedPointHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFixedPointHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFixedPointHook.CreateIFixedPointHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E3CE RID: 58318
		private Table __p;
	}
}
