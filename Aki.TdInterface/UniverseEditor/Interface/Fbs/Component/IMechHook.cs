using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553F RID: 21823
	public struct IMechHook : IFlatbufferObject
	{
		// Token: 0x1700A119 RID: 41241
		// (get) Token: 0x060240E3 RID: 147683 RVA: 0x004FB0FC File Offset: 0x004F92FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x004FB109 File Offset: 0x004F9309
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x004FB110 File Offset: 0x004F9310
		public static IMechHook GetRootAsIMechHook(ByteBuffer _bb)
		{
			return IMechHook.GetRootAsIMechHook(_bb, default(IMechHook));
		}

		// Token: 0x060240E6 RID: 147686 RVA: 0x004FB12C File Offset: 0x004F932C
		public static IMechHook GetRootAsIMechHook(ByteBuffer _bb, IMechHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240E7 RID: 147687 RVA: 0x004FB149 File Offset: 0x004F9349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240E8 RID: 147688 RVA: 0x004FB158 File Offset: 0x004F9358
		public IMechHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A11A RID: 41242
		// (get) Token: 0x060240E9 RID: 147689 RVA: 0x004FB168 File Offset: 0x004F9368
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

		// Token: 0x060240EA RID: 147690 RVA: 0x004FB1A4 File Offset: 0x004F93A4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A11B RID: 41243
		// (get) Token: 0x060240EB RID: 147691 RVA: 0x004FB204 File Offset: 0x004F9404
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

		// Token: 0x060240EC RID: 147692 RVA: 0x004FB230 File Offset: 0x004F9430
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A11C RID: 41244
		// (get) Token: 0x060240ED RID: 147693 RVA: 0x004FB290 File Offset: 0x004F9490
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

		// Token: 0x060240EE RID: 147694 RVA: 0x004FB2BC File Offset: 0x004F94BC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A11D RID: 41245
		// (get) Token: 0x060240EF RID: 147695 RVA: 0x004FB320 File Offset: 0x004F9520
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

		// Token: 0x1700A11E RID: 41246
		// (get) Token: 0x060240F0 RID: 147696 RVA: 0x004FB34C File Offset: 0x004F954C
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

		// Token: 0x1700A11F RID: 41247
		// (get) Token: 0x060240F1 RID: 147697 RVA: 0x004FB3AC File Offset: 0x004F95AC
		public TMechHookConfig HookConfigType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TMechHookConfig.NONE;
				}
				return (TMechHookConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060240F2 RID: 147698 RVA: 0x004FB3EC File Offset: 0x004F95EC
		public TTable? HookConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060240F3 RID: 147699 RVA: 0x004FB434 File Offset: 0x004F9634
		public IBurrowHook HookConfigAsIBurrowHook()
		{
			return this.HookConfig<IBurrowHook>().Value;
		}

		// Token: 0x060240F4 RID: 147700 RVA: 0x004FB450 File Offset: 0x004F9650
		public IMechFixedPointHook HookConfigAsIMechFixedPointHook()
		{
			return this.HookConfig<IMechFixedPointHook>().Value;
		}

		// Token: 0x1700A120 RID: 41248
		// (get) Token: 0x060240F5 RID: 147701 RVA: 0x004FB46C File Offset: 0x004F966C
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

		// Token: 0x060240F6 RID: 147702 RVA: 0x004FB4AC File Offset: 0x004F96AC
		public static Offset<IMechHook> CreateIMechHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), TMechHookConfig HookConfig_type = TMechHookConfig.NONE, int HookConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IMechHook.AddHookConfig(builder, HookConfigOffset);
			IMechHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechHook.AddFinishActions(builder, FinishActionsOffset);
			IMechHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechHook.AddHookActions(builder, HookActionsOffset);
			IMechHook.AddNullMask(builder, NullMask);
			IMechHook.AddHookConfigType(builder, HookConfig_type);
			IMechHook.AddType(builder, Type);
			return IMechHook.EndIMechHook(builder);
		}

		// Token: 0x060240F7 RID: 147703 RVA: 0x004FB503 File Offset: 0x004F9703
		public static void StartIMechHook(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060240F8 RID: 147704 RVA: 0x004FB50C File Offset: 0x004F970C
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240F9 RID: 147705 RVA: 0x004FB517 File Offset: 0x004F9717
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060240FA RID: 147706 RVA: 0x004FB528 File Offset: 0x004F9728
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060240FB RID: 147707 RVA: 0x004FB568 File Offset: 0x004F9768
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060240FC RID: 147708 RVA: 0x004FB582 File Offset: 0x004F9782
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060240FD RID: 147709 RVA: 0x004FB5A0 File Offset: 0x004F97A0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060240FE RID: 147710 RVA: 0x004FB5B9 File Offset: 0x004F97B9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060240FF RID: 147711 RVA: 0x004FB5C4 File Offset: 0x004F97C4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024100 RID: 147712 RVA: 0x004FB5D4 File Offset: 0x004F97D4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024101 RID: 147713 RVA: 0x004FB614 File Offset: 0x004F9814
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024102 RID: 147714 RVA: 0x004FB62E File Offset: 0x004F982E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024103 RID: 147715 RVA: 0x004FB64C File Offset: 0x004F984C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024104 RID: 147716 RVA: 0x004FB665 File Offset: 0x004F9865
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024105 RID: 147717 RVA: 0x004FB670 File Offset: 0x004F9870
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06024106 RID: 147718 RVA: 0x004FB680 File Offset: 0x004F9880
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024107 RID: 147719 RVA: 0x004FB6C0 File Offset: 0x004F98C0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024108 RID: 147720 RVA: 0x004FB6DA File Offset: 0x004F98DA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024109 RID: 147721 RVA: 0x004FB6F8 File Offset: 0x004F98F8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602410A RID: 147722 RVA: 0x004FB711 File Offset: 0x004F9911
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602410B RID: 147723 RVA: 0x004FB71C File Offset: 0x004F991C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602410C RID: 147724 RVA: 0x004FB72C File Offset: 0x004F992C
		public static void AddHookConfigType(FlatBufferBuilder builder, TMechHookConfig hookConfigType)
		{
			builder.AddByte(5, (byte)hookConfigType, 0);
		}

		// Token: 0x0602410D RID: 147725 RVA: 0x004FB737 File Offset: 0x004F9937
		public static void AddHookConfig(FlatBufferBuilder builder, int hookConfigOffset)
		{
			builder.AddOffset(6, hookConfigOffset, 0);
		}

		// Token: 0x0602410E RID: 147726 RVA: 0x004FB742 File Offset: 0x004F9942
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602410F RID: 147727 RVA: 0x004FB74D File Offset: 0x004F994D
		public static Offset<IMechHook> EndIMechHook(FlatBufferBuilder builder)
		{
			return new Offset<IMechHook>(builder.EndTable());
		}

		// Token: 0x06024110 RID: 147728 RVA: 0x004FB75C File Offset: 0x004F995C
		public IMechHookT UnPack()
		{
			IMechHookT mechHookT = new IMechHookT();
			this.UnPackTo(mechHookT);
			return mechHookT;
		}

		// Token: 0x06024111 RID: 147729 RVA: 0x004FB778 File Offset: 0x004F9978
		public void UnPackTo(IMechHookT _o)
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
			_o.HookConfig = new TMechHookConfigUnion();
			_o.HookConfig.Type = this.HookConfigType;
			TMechHookConfig hookConfigType = this.HookConfigType;
			if (hookConfigType != TMechHookConfig.IBurrowHook)
			{
				if (hookConfigType == TMechHookConfig.IMechFixedPointHook)
				{
					_o.HookConfig.Value = ((this.HookConfig<IMechFixedPointHook>() != null) ? this.HookConfig<IMechFixedPointHook>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.HookConfig.Value = ((this.HookConfig<IBurrowHook>() != null) ? this.HookConfig<IBurrowHook>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024112 RID: 147730 RVA: 0x004FB96C File Offset: 0x004F9B6C
		public static Offset<IMechHook> Pack(FlatBufferBuilder builder, IMechHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			TMechHookConfig hookConfig_type = (_o.HookConfig == null) ? TMechHookConfig.NONE : _o.HookConfig.Type;
			int hookConfigOffset = (_o.HookConfig == null) ? 0 : TMechHookConfigUnion.Pack(builder, _o.HookConfig);
			return IMechHook.CreateIMechHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, hookConfig_type, hookConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E83D RID: 59453
		private Table __p;
	}
}
