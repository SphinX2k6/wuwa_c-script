using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4D RID: 23373
	public struct IWaterBoxBigWeaponHook : IFlatbufferObject
	{
		// Token: 0x1700B07B RID: 45179
		// (get) Token: 0x06027F73 RID: 163699 RVA: 0x0057EA74 File Offset: 0x0057CC74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F74 RID: 163700 RVA: 0x0057EA81 File Offset: 0x0057CC81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F75 RID: 163701 RVA: 0x0057EA88 File Offset: 0x0057CC88
		public static IWaterBoxBigWeaponHook GetRootAsIWaterBoxBigWeaponHook(ByteBuffer _bb)
		{
			return IWaterBoxBigWeaponHook.GetRootAsIWaterBoxBigWeaponHook(_bb, default(IWaterBoxBigWeaponHook));
		}

		// Token: 0x06027F76 RID: 163702 RVA: 0x0057EAA4 File Offset: 0x0057CCA4
		public static IWaterBoxBigWeaponHook GetRootAsIWaterBoxBigWeaponHook(ByteBuffer _bb, IWaterBoxBigWeaponHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F77 RID: 163703 RVA: 0x0057EAC1 File Offset: 0x0057CCC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F78 RID: 163704 RVA: 0x0057EAD0 File Offset: 0x0057CCD0
		public IWaterBoxBigWeaponHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B07C RID: 45180
		// (get) Token: 0x06027F79 RID: 163705 RVA: 0x0057EAE0 File Offset: 0x0057CCE0
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

		// Token: 0x06027F7A RID: 163706 RVA: 0x0057EB1C File Offset: 0x0057CD1C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B07D RID: 45181
		// (get) Token: 0x06027F7B RID: 163707 RVA: 0x0057EB7C File Offset: 0x0057CD7C
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

		// Token: 0x06027F7C RID: 163708 RVA: 0x0057EBA8 File Offset: 0x0057CDA8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B07E RID: 45182
		// (get) Token: 0x06027F7D RID: 163709 RVA: 0x0057EC08 File Offset: 0x0057CE08
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

		// Token: 0x06027F7E RID: 163710 RVA: 0x0057EC34 File Offset: 0x0057CE34
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B07F RID: 45183
		// (get) Token: 0x06027F7F RID: 163711 RVA: 0x0057EC98 File Offset: 0x0057CE98
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

		// Token: 0x1700B080 RID: 45184
		// (get) Token: 0x06027F80 RID: 163712 RVA: 0x0057ECC4 File Offset: 0x0057CEC4
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

		// Token: 0x1700B081 RID: 45185
		// (get) Token: 0x06027F81 RID: 163713 RVA: 0x0057ED24 File Offset: 0x0057CF24
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

		// Token: 0x06027F82 RID: 163714 RVA: 0x0057ED61 File Offset: 0x0057CF61
		public static Offset<IWaterBoxBigWeaponHook> CreateIWaterBoxBigWeaponHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IWaterBoxBigWeaponHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IWaterBoxBigWeaponHook.AddFinishActions(builder, FinishActionsOffset);
			IWaterBoxBigWeaponHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IWaterBoxBigWeaponHook.AddHookActions(builder, HookActionsOffset);
			IWaterBoxBigWeaponHook.AddNullMask(builder, NullMask);
			IWaterBoxBigWeaponHook.AddType(builder, Type);
			return IWaterBoxBigWeaponHook.EndIWaterBoxBigWeaponHook(builder);
		}

		// Token: 0x06027F83 RID: 163715 RVA: 0x0057ED9D File Offset: 0x0057CF9D
		public static void StartIWaterBoxBigWeaponHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027F84 RID: 163716 RVA: 0x0057EDA6 File Offset: 0x0057CFA6
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027F85 RID: 163717 RVA: 0x0057EDB1 File Offset: 0x0057CFB1
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06027F86 RID: 163718 RVA: 0x0057EDC4 File Offset: 0x0057CFC4
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027F87 RID: 163719 RVA: 0x0057EE04 File Offset: 0x0057D004
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F88 RID: 163720 RVA: 0x0057EE1E File Offset: 0x0057D01E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F89 RID: 163721 RVA: 0x0057EE3C File Offset: 0x0057D03C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027F8A RID: 163722 RVA: 0x0057EE55 File Offset: 0x0057D055
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027F8B RID: 163723 RVA: 0x0057EE60 File Offset: 0x0057D060
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06027F8C RID: 163724 RVA: 0x0057EE70 File Offset: 0x0057D070
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027F8D RID: 163725 RVA: 0x0057EEB0 File Offset: 0x0057D0B0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F8E RID: 163726 RVA: 0x0057EECA File Offset: 0x0057D0CA
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F8F RID: 163727 RVA: 0x0057EEE8 File Offset: 0x0057D0E8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027F90 RID: 163728 RVA: 0x0057EF01 File Offset: 0x0057D101
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027F91 RID: 163729 RVA: 0x0057EF0C File Offset: 0x0057D10C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06027F92 RID: 163730 RVA: 0x0057EF1C File Offset: 0x0057D11C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027F93 RID: 163731 RVA: 0x0057EF5C File Offset: 0x0057D15C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F94 RID: 163732 RVA: 0x0057EF76 File Offset: 0x0057D176
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027F95 RID: 163733 RVA: 0x0057EF94 File Offset: 0x0057D194
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027F96 RID: 163734 RVA: 0x0057EFAD File Offset: 0x0057D1AD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027F97 RID: 163735 RVA: 0x0057EFB8 File Offset: 0x0057D1B8
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06027F98 RID: 163736 RVA: 0x0057EFC8 File Offset: 0x0057D1C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06027F99 RID: 163737 RVA: 0x0057EFD3 File Offset: 0x0057D1D3
		public static Offset<IWaterBoxBigWeaponHook> EndIWaterBoxBigWeaponHook(FlatBufferBuilder builder)
		{
			return new Offset<IWaterBoxBigWeaponHook>(builder.EndTable());
		}

		// Token: 0x06027F9A RID: 163738 RVA: 0x0057EFE0 File Offset: 0x0057D1E0
		public IWaterBoxBigWeaponHookT UnPack()
		{
			IWaterBoxBigWeaponHookT waterBoxBigWeaponHookT = new IWaterBoxBigWeaponHookT();
			this.UnPackTo(waterBoxBigWeaponHookT);
			return waterBoxBigWeaponHookT;
		}

		// Token: 0x06027F9B RID: 163739 RVA: 0x0057EFFC File Offset: 0x0057D1FC
		public void UnPackTo(IWaterBoxBigWeaponHookT _o)
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

		// Token: 0x06027F9C RID: 163740 RVA: 0x0057F150 File Offset: 0x0057D350
		public static Offset<IWaterBoxBigWeaponHook> Pack(FlatBufferBuilder builder, IWaterBoxBigWeaponHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterBoxBigWeaponHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IWaterBoxBigWeaponHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IWaterBoxBigWeaponHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IWaterBoxBigWeaponHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IWaterBoxBigWeaponHook.CreateIWaterBoxBigWeaponHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F286 RID: 62086
		private Table __p;
	}
}
