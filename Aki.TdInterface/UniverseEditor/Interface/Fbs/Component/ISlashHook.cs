using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005929 RID: 22825
	public struct ISlashHook : IFlatbufferObject
	{
		// Token: 0x1700AB2C RID: 43820
		// (get) Token: 0x0602697C RID: 158076 RVA: 0x00550AB0 File Offset: 0x0054ECB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602697D RID: 158077 RVA: 0x00550ABD File Offset: 0x0054ECBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602697E RID: 158078 RVA: 0x00550AC4 File Offset: 0x0054ECC4
		public static ISlashHook GetRootAsISlashHook(ByteBuffer _bb)
		{
			return ISlashHook.GetRootAsISlashHook(_bb, default(ISlashHook));
		}

		// Token: 0x0602697F RID: 158079 RVA: 0x00550AE0 File Offset: 0x0054ECE0
		public static ISlashHook GetRootAsISlashHook(ByteBuffer _bb, ISlashHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026980 RID: 158080 RVA: 0x00550AFD File Offset: 0x0054ECFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026981 RID: 158081 RVA: 0x00550B0C File Offset: 0x0054ED0C
		public ISlashHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB2D RID: 43821
		// (get) Token: 0x06026982 RID: 158082 RVA: 0x00550B1C File Offset: 0x0054ED1C
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

		// Token: 0x06026983 RID: 158083 RVA: 0x00550B58 File Offset: 0x0054ED58
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB2E RID: 43822
		// (get) Token: 0x06026984 RID: 158084 RVA: 0x00550BB8 File Offset: 0x0054EDB8
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

		// Token: 0x06026985 RID: 158085 RVA: 0x00550BE4 File Offset: 0x0054EDE4
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB2F RID: 43823
		// (get) Token: 0x06026986 RID: 158086 RVA: 0x00550C44 File Offset: 0x0054EE44
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

		// Token: 0x06026987 RID: 158087 RVA: 0x00550C70 File Offset: 0x0054EE70
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB30 RID: 43824
		// (get) Token: 0x06026988 RID: 158088 RVA: 0x00550CD4 File Offset: 0x0054EED4
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

		// Token: 0x1700AB31 RID: 43825
		// (get) Token: 0x06026989 RID: 158089 RVA: 0x00550D00 File Offset: 0x0054EF00
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

		// Token: 0x1700AB32 RID: 43826
		// (get) Token: 0x0602698A RID: 158090 RVA: 0x00550D60 File Offset: 0x0054EF60
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

		// Token: 0x1700AB33 RID: 43827
		// (get) Token: 0x0602698B RID: 158091 RVA: 0x00550DA0 File Offset: 0x0054EFA0
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

		// Token: 0x1700AB34 RID: 43828
		// (get) Token: 0x0602698C RID: 158092 RVA: 0x00550DE0 File Offset: 0x0054EFE0
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

		// Token: 0x1700AB35 RID: 43829
		// (get) Token: 0x0602698D RID: 158093 RVA: 0x00550E20 File Offset: 0x0054F020
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

		// Token: 0x1700AB36 RID: 43830
		// (get) Token: 0x0602698E RID: 158094 RVA: 0x00550E80 File Offset: 0x0054F080
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

		// Token: 0x1700AB37 RID: 43831
		// (get) Token: 0x0602698F RID: 158095 RVA: 0x00550EC0 File Offset: 0x0054F0C0
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

		// Token: 0x1700AB38 RID: 43832
		// (get) Token: 0x06026990 RID: 158096 RVA: 0x00550F00 File Offset: 0x0054F100
		public bool IsAdjustCameraConfig
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB39 RID: 43833
		// (get) Token: 0x06026991 RID: 158097 RVA: 0x00550F40 File Offset: 0x0054F140
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

		// Token: 0x06026992 RID: 158098 RVA: 0x00550F80 File Offset: 0x0054F180
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

		// Token: 0x06026993 RID: 158099 RVA: 0x00551000 File Offset: 0x0054F200
		public static void StartISlashHook(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06026994 RID: 158100 RVA: 0x0055100A File Offset: 0x0054F20A
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026995 RID: 158101 RVA: 0x00551015 File Offset: 0x0054F215
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06026996 RID: 158102 RVA: 0x00551028 File Offset: 0x0054F228
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026997 RID: 158103 RVA: 0x00551068 File Offset: 0x0054F268
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026998 RID: 158104 RVA: 0x00551082 File Offset: 0x0054F282
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026999 RID: 158105 RVA: 0x005510A0 File Offset: 0x0054F2A0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602699A RID: 158106 RVA: 0x005510B9 File Offset: 0x0054F2B9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602699B RID: 158107 RVA: 0x005510C4 File Offset: 0x0054F2C4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602699C RID: 158108 RVA: 0x005510D4 File Offset: 0x0054F2D4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602699D RID: 158109 RVA: 0x00551114 File Offset: 0x0054F314
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602699E RID: 158110 RVA: 0x0055112E File Offset: 0x0054F32E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602699F RID: 158111 RVA: 0x0055114C File Offset: 0x0054F34C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060269A0 RID: 158112 RVA: 0x00551165 File Offset: 0x0054F365
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060269A1 RID: 158113 RVA: 0x00551170 File Offset: 0x0054F370
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060269A2 RID: 158114 RVA: 0x00551180 File Offset: 0x0054F380
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060269A3 RID: 158115 RVA: 0x005511C0 File Offset: 0x0054F3C0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060269A4 RID: 158116 RVA: 0x005511DA File Offset: 0x0054F3DA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060269A5 RID: 158117 RVA: 0x005511F8 File Offset: 0x0054F3F8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060269A6 RID: 158118 RVA: 0x00551211 File Offset: 0x0054F411
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060269A7 RID: 158119 RVA: 0x0055121C File Offset: 0x0054F41C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060269A8 RID: 158120 RVA: 0x0055122C File Offset: 0x0054F42C
		public static void AddSlashHitType(FlatBufferBuilder builder, ESlashHitType slashHitType)
		{
			builder.AddByte(5, (byte)slashHitType, 0);
		}

		// Token: 0x060269A9 RID: 158121 RVA: 0x00551237 File Offset: 0x0054F437
		public static void AddSlashAngleType(FlatBufferBuilder builder, ESlashAngleType slashAngleType)
		{
			builder.AddByte(6, (byte)slashAngleType, 0);
		}

		// Token: 0x060269AA RID: 158122 RVA: 0x00551242 File Offset: 0x0054F442
		public static void AddDefaultSlashDir(FlatBufferBuilder builder, ESlashDirType defaultSlashDir)
		{
			builder.AddByte(7, (byte)defaultSlashDir, 0);
		}

		// Token: 0x060269AB RID: 158123 RVA: 0x0055124D File Offset: 0x0054F44D
		public static void AddCharacterLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> characterLookAtOffset)
		{
			builder.AddOffset(8, characterLookAtOffset.Value, 0);
		}

		// Token: 0x060269AC RID: 158124 RVA: 0x0055125D File Offset: 0x0054F45D
		public static void AddCharacterLookAtPointId(FlatBufferBuilder builder, int characterLookAtPointId)
		{
			builder.AddInt(9, characterLookAtPointId, 0);
		}

		// Token: 0x060269AD RID: 158125 RVA: 0x00551269 File Offset: 0x0054F469
		public static void AddSlashBackSafePointId(FlatBufferBuilder builder, int slashBackSafePointId)
		{
			builder.AddInt(10, slashBackSafePointId, 0);
		}

		// Token: 0x060269AE RID: 158126 RVA: 0x00551275 File Offset: 0x0054F475
		public static void AddIsAdjustCameraConfig(FlatBufferBuilder builder, bool isAdjustCameraConfig)
		{
			builder.AddBool(11, isAdjustCameraConfig, false);
		}

		// Token: 0x060269AF RID: 158127 RVA: 0x00551281 File Offset: 0x0054F481
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060269B0 RID: 158128 RVA: 0x0055128D File Offset: 0x0054F48D
		public static Offset<ISlashHook> EndISlashHook(FlatBufferBuilder builder)
		{
			return new Offset<ISlashHook>(builder.EndTable());
		}

		// Token: 0x060269B1 RID: 158129 RVA: 0x0055129C File Offset: 0x0054F49C
		public ISlashHookT UnPack()
		{
			ISlashHookT slashHookT = new ISlashHookT();
			this.UnPackTo(slashHookT);
			return slashHookT;
		}

		// Token: 0x060269B2 RID: 158130 RVA: 0x005512B8 File Offset: 0x0054F4B8
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

		// Token: 0x060269B3 RID: 158131 RVA: 0x00551488 File Offset: 0x0054F688
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

		// Token: 0x0400EEDF RID: 61151
		private Table __p;
	}
}
