using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F36 RID: 24374
	public struct ISlashHook : IFlatbufferObject
	{
		// Token: 0x1700B460 RID: 46176
		// (get) Token: 0x06028EE6 RID: 167654 RVA: 0x0059771C File Offset: 0x0059591C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EE7 RID: 167655 RVA: 0x00597729 File Offset: 0x00595929
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EE8 RID: 167656 RVA: 0x00597730 File Offset: 0x00595930
		public static ISlashHook GetRootAsISlashHook(ByteBuffer _bb)
		{
			return ISlashHook.GetRootAsISlashHook(_bb, default(ISlashHook));
		}

		// Token: 0x06028EE9 RID: 167657 RVA: 0x0059774C File Offset: 0x0059594C
		public static ISlashHook GetRootAsISlashHook(ByteBuffer _bb, ISlashHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EEA RID: 167658 RVA: 0x00597769 File Offset: 0x00595969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EEB RID: 167659 RVA: 0x00597778 File Offset: 0x00595978
		public ISlashHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B461 RID: 46177
		// (get) Token: 0x06028EEC RID: 167660 RVA: 0x00597788 File Offset: 0x00595988
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

		// Token: 0x06028EED RID: 167661 RVA: 0x005977C4 File Offset: 0x005959C4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B462 RID: 46178
		// (get) Token: 0x06028EEE RID: 167662 RVA: 0x00597824 File Offset: 0x00595A24
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

		// Token: 0x06028EEF RID: 167663 RVA: 0x00597850 File Offset: 0x00595A50
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B463 RID: 46179
		// (get) Token: 0x06028EF0 RID: 167664 RVA: 0x005978B0 File Offset: 0x00595AB0
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

		// Token: 0x06028EF1 RID: 167665 RVA: 0x005978DC File Offset: 0x00595ADC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B464 RID: 46180
		// (get) Token: 0x06028EF2 RID: 167666 RVA: 0x00597940 File Offset: 0x00595B40
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

		// Token: 0x1700B465 RID: 46181
		// (get) Token: 0x06028EF3 RID: 167667 RVA: 0x0059796C File Offset: 0x00595B6C
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

		// Token: 0x1700B466 RID: 46182
		// (get) Token: 0x06028EF4 RID: 167668 RVA: 0x005979CC File Offset: 0x00595BCC
		public ESlashHitType SlashHitType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ESlashHitType.HeavySlash;
				}
				return (ESlashHitType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B467 RID: 46183
		// (get) Token: 0x06028EF5 RID: 167669 RVA: 0x00597A0C File Offset: 0x00595C0C
		public ESlashAngleType SlashAngleType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ESlashAngleType.Slash45;
				}
				return (ESlashAngleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B468 RID: 46184
		// (get) Token: 0x06028EF6 RID: 167670 RVA: 0x00597A4C File Offset: 0x00595C4C
		public ESlashDirType DefaultSlashDir
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return ESlashDirType.Horizontal;
				}
				return (ESlashDirType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B469 RID: 46185
		// (get) Token: 0x06028EF7 RID: 167671 RVA: 0x00597A8C File Offset: 0x00595C8C
		public IVectorInfo? CharacterLookAt
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B46A RID: 46186
		// (get) Token: 0x06028EF8 RID: 167672 RVA: 0x00597AEC File Offset: 0x00595CEC
		public int CharacterLookAtPointId
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

		// Token: 0x1700B46B RID: 46187
		// (get) Token: 0x06028EF9 RID: 167673 RVA: 0x00597B2C File Offset: 0x00595D2C
		public int SlashBackSafePointId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B46C RID: 46188
		// (get) Token: 0x06028EFA RID: 167674 RVA: 0x00597B6C File Offset: 0x00595D6C
		public bool IsAdjustCameraConfig
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B46D RID: 46189
		// (get) Token: 0x06028EFB RID: 167675 RVA: 0x00597BAC File Offset: 0x00595DAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028EFC RID: 167676 RVA: 0x00597BEC File Offset: 0x00595DEC
		public static Offset<ISlashHook> CreateISlashHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), ESlashHitType SlashHitType = ESlashHitType.HeavySlash, ESlashAngleType SlashAngleType = ESlashAngleType.Slash45, ESlashDirType DefaultSlashDir = ESlashDirType.Horizontal, Offset<IVectorInfo> CharacterLookAtOffset = default(Offset<IVectorInfo>), int CharacterLookAtPointId = 0, int SlashBackSafePointId = 0, bool IsAdjustCameraConfig = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			ISlashHook.AddSlashBackSafePointId(builder, SlashBackSafePointId);
			ISlashHook.AddCharacterLookAtPointId(builder, CharacterLookAtPointId);
			ISlashHook.AddCharacterLookAt(builder, CharacterLookAtOffset);
			ISlashHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ISlashHook.AddFinishActions(builder, FinishActionsOffset);
			ISlashHook.AddExitHookActions(builder, ExitHookActionsOffset);
			ISlashHook.AddHookActions(builder, HookActionsOffset);
			ISlashHook.AddNullMask(builder, NullMask);
			ISlashHook.AddIsAdjustCameraConfig(builder, IsAdjustCameraConfig);
			ISlashHook.AddDefaultSlashDir(builder, DefaultSlashDir);
			ISlashHook.AddSlashAngleType(builder, SlashAngleType);
			ISlashHook.AddSlashHitType(builder, SlashHitType);
			ISlashHook.AddType(builder, Type);
			return ISlashHook.EndISlashHook(builder);
		}

		// Token: 0x06028EFD RID: 167677 RVA: 0x00597C6C File Offset: 0x00595E6C
		public static void StartISlashHook(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06028EFE RID: 167678 RVA: 0x00597C76 File Offset: 0x00595E76
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028EFF RID: 167679 RVA: 0x00597C81 File Offset: 0x00595E81
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06028F00 RID: 167680 RVA: 0x00597C94 File Offset: 0x00595E94
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028F01 RID: 167681 RVA: 0x00597CD4 File Offset: 0x00595ED4
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F02 RID: 167682 RVA: 0x00597CEE File Offset: 0x00595EEE
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F03 RID: 167683 RVA: 0x00597D0C File Offset: 0x00595F0C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028F04 RID: 167684 RVA: 0x00597D25 File Offset: 0x00595F25
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028F05 RID: 167685 RVA: 0x00597D30 File Offset: 0x00595F30
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06028F06 RID: 167686 RVA: 0x00597D40 File Offset: 0x00595F40
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028F07 RID: 167687 RVA: 0x00597D80 File Offset: 0x00595F80
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F08 RID: 167688 RVA: 0x00597D9A File Offset: 0x00595F9A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F09 RID: 167689 RVA: 0x00597DB8 File Offset: 0x00595FB8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028F0A RID: 167690 RVA: 0x00597DD1 File Offset: 0x00595FD1
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028F0B RID: 167691 RVA: 0x00597DDC File Offset: 0x00595FDC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06028F0C RID: 167692 RVA: 0x00597DEC File Offset: 0x00595FEC
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028F0D RID: 167693 RVA: 0x00597E2C File Offset: 0x0059602C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F0E RID: 167694 RVA: 0x00597E46 File Offset: 0x00596046
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028F0F RID: 167695 RVA: 0x00597E64 File Offset: 0x00596064
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028F10 RID: 167696 RVA: 0x00597E7D File Offset: 0x0059607D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028F11 RID: 167697 RVA: 0x00597E88 File Offset: 0x00596088
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06028F12 RID: 167698 RVA: 0x00597E98 File Offset: 0x00596098
		public static void AddSlashHitType(FlatBufferBuilder builder, ESlashHitType slashHitType)
		{
			builder.AddByte(5, (byte)slashHitType, 0);
		}

		// Token: 0x06028F13 RID: 167699 RVA: 0x00597EA3 File Offset: 0x005960A3
		public static void AddSlashAngleType(FlatBufferBuilder builder, ESlashAngleType slashAngleType)
		{
			builder.AddByte(6, (byte)slashAngleType, 0);
		}

		// Token: 0x06028F14 RID: 167700 RVA: 0x00597EAE File Offset: 0x005960AE
		public static void AddDefaultSlashDir(FlatBufferBuilder builder, ESlashDirType defaultSlashDir)
		{
			builder.AddByte(7, (byte)defaultSlashDir, 0);
		}

		// Token: 0x06028F15 RID: 167701 RVA: 0x00597EB9 File Offset: 0x005960B9
		public static void AddCharacterLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> characterLookAtOffset)
		{
			builder.AddOffset(8, characterLookAtOffset.Value, 0);
		}

		// Token: 0x06028F16 RID: 167702 RVA: 0x00597EC9 File Offset: 0x005960C9
		public static void AddCharacterLookAtPointId(FlatBufferBuilder builder, int characterLookAtPointId)
		{
			builder.AddInt(9, characterLookAtPointId, 0);
		}

		// Token: 0x06028F17 RID: 167703 RVA: 0x00597ED5 File Offset: 0x005960D5
		public static void AddSlashBackSafePointId(FlatBufferBuilder builder, int slashBackSafePointId)
		{
			builder.AddInt(10, slashBackSafePointId, 0);
		}

		// Token: 0x06028F18 RID: 167704 RVA: 0x00597EE1 File Offset: 0x005960E1
		public static void AddIsAdjustCameraConfig(FlatBufferBuilder builder, bool isAdjustCameraConfig)
		{
			builder.AddBool(11, isAdjustCameraConfig, false);
		}

		// Token: 0x06028F19 RID: 167705 RVA: 0x00597EED File Offset: 0x005960ED
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06028F1A RID: 167706 RVA: 0x00597EF9 File Offset: 0x005960F9
		public static Offset<ISlashHook> EndISlashHook(FlatBufferBuilder builder)
		{
			return new Offset<ISlashHook>(builder.EndTable());
		}

		// Token: 0x06028F1B RID: 167707 RVA: 0x00597F08 File Offset: 0x00596108
		public ISlashHookT UnPack()
		{
			ISlashHookT slashHookT = new ISlashHookT();
			this.UnPackTo(slashHookT);
			return slashHookT;
		}

		// Token: 0x06028F1C RID: 167708 RVA: 0x00597F24 File Offset: 0x00596124
		public void UnPackTo(ISlashHookT _o)
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
			_o.SlashHitType = this.SlashHitType;
			_o.SlashAngleType = this.SlashAngleType;
			_o.DefaultSlashDir = this.DefaultSlashDir;
			_o.CharacterLookAt = ((this.CharacterLookAt != null) ? this.CharacterLookAt.Value.UnPack() : null);
			_o.CharacterLookAtPointId = this.CharacterLookAtPointId;
			_o.SlashBackSafePointId = this.SlashBackSafePointId;
			_o.IsAdjustCameraConfig = this.IsAdjustCameraConfig;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028F1D RID: 167709 RVA: 0x005980F4 File Offset: 0x005962F4
		public static Offset<ISlashHook> Pack(FlatBufferBuilder builder, ISlashHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ISlashHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ISlashHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ISlashHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			Offset<IVectorInfo> characterLookAtOffset = (_o.CharacterLookAt == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CharacterLookAt);
			return ISlashHook.CreateISlashHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.SlashHitType, _o.SlashAngleType, _o.DefaultSlashDir, characterLookAtOffset, _o.CharacterLookAtPointId, _o.SlashBackSafePointId, _o.IsAdjustCameraConfig, _o.NullMask);
		}

		// Token: 0x0400FBD4 RID: 64468
		private Table __p;
	}
}
