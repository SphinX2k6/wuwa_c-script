using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B8 RID: 21688
	public struct IKiteHook : IFlatbufferObject
	{
		// Token: 0x17009FCA RID: 40906
		// (get) Token: 0x06023BA4 RID: 146340 RVA: 0x004F0983 File Offset: 0x004EEB83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023BA5 RID: 146341 RVA: 0x004F0990 File Offset: 0x004EEB90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023BA6 RID: 146342 RVA: 0x004F0998 File Offset: 0x004EEB98
		public static IKiteHook GetRootAsIKiteHook(ByteBuffer _bb)
		{
			return IKiteHook.GetRootAsIKiteHook(_bb, default(IKiteHook));
		}

		// Token: 0x06023BA7 RID: 146343 RVA: 0x004F09B4 File Offset: 0x004EEBB4
		public static IKiteHook GetRootAsIKiteHook(ByteBuffer _bb, IKiteHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023BA8 RID: 146344 RVA: 0x004F09D1 File Offset: 0x004EEBD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023BA9 RID: 146345 RVA: 0x004F09E0 File Offset: 0x004EEBE0
		public IKiteHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FCB RID: 40907
		// (get) Token: 0x06023BAA RID: 146346 RVA: 0x004F09F0 File Offset: 0x004EEBF0
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

		// Token: 0x06023BAB RID: 146347 RVA: 0x004F0A2C File Offset: 0x004EEC2C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FCC RID: 40908
		// (get) Token: 0x06023BAC RID: 146348 RVA: 0x004F0A8C File Offset: 0x004EEC8C
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

		// Token: 0x06023BAD RID: 146349 RVA: 0x004F0AB8 File Offset: 0x004EECB8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FCD RID: 40909
		// (get) Token: 0x06023BAE RID: 146350 RVA: 0x004F0B18 File Offset: 0x004EED18
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

		// Token: 0x06023BAF RID: 146351 RVA: 0x004F0B44 File Offset: 0x004EED44
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FCE RID: 40910
		// (get) Token: 0x06023BB0 RID: 146352 RVA: 0x004F0BA8 File Offset: 0x004EEDA8
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

		// Token: 0x17009FCF RID: 40911
		// (get) Token: 0x06023BB1 RID: 146353 RVA: 0x004F0BD4 File Offset: 0x004EEDD4
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

		// Token: 0x17009FD0 RID: 40912
		// (get) Token: 0x06023BB2 RID: 146354 RVA: 0x004F0C34 File Offset: 0x004EEE34
		public string HookDataAssetOverride
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023BB3 RID: 146355 RVA: 0x004F0C6C File Offset: 0x004EEE6C
		public Span<byte> GetHookDataAssetOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06023BB4 RID: 146356 RVA: 0x004F0C7C File Offset: 0x004EEE7C
		public byte[] GetHookDataAssetOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009FD1 RID: 40913
		// (get) Token: 0x06023BB5 RID: 146357 RVA: 0x004F0C8C File Offset: 0x004EEE8C
		public bool SupportSwitchHookMidway
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FD2 RID: 40914
		// (get) Token: 0x06023BB6 RID: 146358 RVA: 0x004F0CCC File Offset: 0x004EEECC
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

		// Token: 0x06023BB7 RID: 146359 RVA: 0x004F0D0C File Offset: 0x004EEF0C
		public static Offset<IKiteHook> CreateIKiteHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), StringOffset HookDataAssetOverrideOffset = default(StringOffset), bool SupportSwitchHookMidway = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IKiteHook.AddHookDataAssetOverride(builder, HookDataAssetOverrideOffset);
			IKiteHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IKiteHook.AddFinishActions(builder, FinishActionsOffset);
			IKiteHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IKiteHook.AddHookActions(builder, HookActionsOffset);
			IKiteHook.AddNullMask(builder, NullMask);
			IKiteHook.AddSupportSwitchHookMidway(builder, SupportSwitchHookMidway);
			IKiteHook.AddType(builder, Type);
			return IKiteHook.EndIKiteHook(builder);
		}

		// Token: 0x06023BB8 RID: 146360 RVA: 0x004F0D63 File Offset: 0x004EEF63
		public static void StartIKiteHook(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023BB9 RID: 146361 RVA: 0x004F0D6C File Offset: 0x004EEF6C
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023BBA RID: 146362 RVA: 0x004F0D77 File Offset: 0x004EEF77
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06023BBB RID: 146363 RVA: 0x004F0D88 File Offset: 0x004EEF88
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BBC RID: 146364 RVA: 0x004F0DC8 File Offset: 0x004EEFC8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BBD RID: 146365 RVA: 0x004F0DE2 File Offset: 0x004EEFE2
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BBE RID: 146366 RVA: 0x004F0E00 File Offset: 0x004EF000
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BBF RID: 146367 RVA: 0x004F0E19 File Offset: 0x004EF019
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BC0 RID: 146368 RVA: 0x004F0E24 File Offset: 0x004EF024
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06023BC1 RID: 146369 RVA: 0x004F0E34 File Offset: 0x004EF034
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BC2 RID: 146370 RVA: 0x004F0E74 File Offset: 0x004EF074
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BC3 RID: 146371 RVA: 0x004F0E8E File Offset: 0x004EF08E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BC4 RID: 146372 RVA: 0x004F0EAC File Offset: 0x004EF0AC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BC5 RID: 146373 RVA: 0x004F0EC5 File Offset: 0x004EF0C5
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BC6 RID: 146374 RVA: 0x004F0ED0 File Offset: 0x004EF0D0
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06023BC7 RID: 146375 RVA: 0x004F0EE0 File Offset: 0x004EF0E0
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BC8 RID: 146376 RVA: 0x004F0F20 File Offset: 0x004EF120
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BC9 RID: 146377 RVA: 0x004F0F3A File Offset: 0x004EF13A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BCA RID: 146378 RVA: 0x004F0F58 File Offset: 0x004EF158
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BCB RID: 146379 RVA: 0x004F0F71 File Offset: 0x004EF171
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BCC RID: 146380 RVA: 0x004F0F7C File Offset: 0x004EF17C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06023BCD RID: 146381 RVA: 0x004F0F8C File Offset: 0x004EF18C
		public static void AddHookDataAssetOverride(FlatBufferBuilder builder, StringOffset hookDataAssetOverrideOffset)
		{
			builder.AddOffset(5, hookDataAssetOverrideOffset.Value, 0);
		}

		// Token: 0x06023BCE RID: 146382 RVA: 0x004F0F9C File Offset: 0x004EF19C
		public static void AddSupportSwitchHookMidway(FlatBufferBuilder builder, bool supportSwitchHookMidway)
		{
			builder.AddBool(6, supportSwitchHookMidway, false);
		}

		// Token: 0x06023BCF RID: 146383 RVA: 0x004F0FA7 File Offset: 0x004EF1A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023BD0 RID: 146384 RVA: 0x004F0FB2 File Offset: 0x004EF1B2
		public static Offset<IKiteHook> EndIKiteHook(FlatBufferBuilder builder)
		{
			return new Offset<IKiteHook>(builder.EndTable());
		}

		// Token: 0x06023BD1 RID: 146385 RVA: 0x004F0FC0 File Offset: 0x004EF1C0
		public IKiteHookT UnPack()
		{
			IKiteHookT kiteHookT = new IKiteHookT();
			this.UnPackTo(kiteHookT);
			return kiteHookT;
		}

		// Token: 0x06023BD2 RID: 146386 RVA: 0x004F0FDC File Offset: 0x004EF1DC
		public void UnPackTo(IKiteHookT _o)
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
			_o.HookDataAssetOverride = this.HookDataAssetOverride;
			_o.SupportSwitchHookMidway = this.SupportSwitchHookMidway;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023BD3 RID: 146387 RVA: 0x004F1148 File Offset: 0x004EF348
		public static Offset<IKiteHook> Pack(FlatBufferBuilder builder, IKiteHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKiteHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IKiteHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IKiteHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IKiteHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			StringOffset hookDataAssetOverrideOffset = (_o.HookDataAssetOverride == null) ? default(StringOffset) : builder.CreateString(_o.HookDataAssetOverride);
			return IKiteHook.CreateIKiteHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, hookDataAssetOverrideOffset, _o.SupportSwitchHookMidway, _o.NullMask);
		}

		// Token: 0x0400E76A RID: 59242
		private Table __p;
	}
}
