using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3E RID: 23102
	public struct IKiteHook : IFlatbufferObject
	{
		// Token: 0x1700A804 RID: 43012
		// (get) Token: 0x06025C5C RID: 154716 RVA: 0x0052D9F7 File Offset: 0x0052BBF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C5D RID: 154717 RVA: 0x0052DA04 File Offset: 0x0052BC04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C5E RID: 154718 RVA: 0x0052DA0C File Offset: 0x0052BC0C
		public static IKiteHook GetRootAsIKiteHook(ByteBuffer _bb)
		{
			return IKiteHook.GetRootAsIKiteHook(_bb, default(IKiteHook));
		}

		// Token: 0x06025C5F RID: 154719 RVA: 0x0052DA28 File Offset: 0x0052BC28
		public static IKiteHook GetRootAsIKiteHook(ByteBuffer _bb, IKiteHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C60 RID: 154720 RVA: 0x0052DA45 File Offset: 0x0052BC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C61 RID: 154721 RVA: 0x0052DA54 File Offset: 0x0052BC54
		public IKiteHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A805 RID: 43013
		// (get) Token: 0x06025C62 RID: 154722 RVA: 0x0052DA64 File Offset: 0x0052BC64
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

		// Token: 0x06025C63 RID: 154723 RVA: 0x0052DAA0 File Offset: 0x0052BCA0
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A806 RID: 43014
		// (get) Token: 0x06025C64 RID: 154724 RVA: 0x0052DB00 File Offset: 0x0052BD00
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

		// Token: 0x06025C65 RID: 154725 RVA: 0x0052DB2C File Offset: 0x0052BD2C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A807 RID: 43015
		// (get) Token: 0x06025C66 RID: 154726 RVA: 0x0052DB8C File Offset: 0x0052BD8C
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

		// Token: 0x06025C67 RID: 154727 RVA: 0x0052DBB8 File Offset: 0x0052BDB8
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A808 RID: 43016
		// (get) Token: 0x06025C68 RID: 154728 RVA: 0x0052DC1C File Offset: 0x0052BE1C
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

		// Token: 0x1700A809 RID: 43017
		// (get) Token: 0x06025C69 RID: 154729 RVA: 0x0052DC48 File Offset: 0x0052BE48
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

		// Token: 0x1700A80A RID: 43018
		// (get) Token: 0x06025C6A RID: 154730 RVA: 0x0052DCA8 File Offset: 0x0052BEA8
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

		// Token: 0x06025C6B RID: 154731 RVA: 0x0052DCE0 File Offset: 0x0052BEE0
		public Span<byte> GetHookDataAssetOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06025C6C RID: 154732 RVA: 0x0052DCF0 File Offset: 0x0052BEF0
		public byte[] GetHookDataAssetOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700A80B RID: 43019
		// (get) Token: 0x06025C6D RID: 154733 RVA: 0x0052DD00 File Offset: 0x0052BF00
		public bool SupportSwitchHookMidway
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A80C RID: 43020
		// (get) Token: 0x06025C6E RID: 154734 RVA: 0x0052DD40 File Offset: 0x0052BF40
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

		// Token: 0x06025C6F RID: 154735 RVA: 0x0052DD80 File Offset: 0x0052BF80
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

		// Token: 0x06025C70 RID: 154736 RVA: 0x0052DDD7 File Offset: 0x0052BFD7
		public static void StartIKiteHook(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06025C71 RID: 154737 RVA: 0x0052DDE0 File Offset: 0x0052BFE0
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025C72 RID: 154738 RVA: 0x0052DDEB File Offset: 0x0052BFEB
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06025C73 RID: 154739 RVA: 0x0052DDFC File Offset: 0x0052BFFC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C74 RID: 154740 RVA: 0x0052DE3C File Offset: 0x0052C03C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C75 RID: 154741 RVA: 0x0052DE56 File Offset: 0x0052C056
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C76 RID: 154742 RVA: 0x0052DE74 File Offset: 0x0052C074
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C77 RID: 154743 RVA: 0x0052DE8D File Offset: 0x0052C08D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C78 RID: 154744 RVA: 0x0052DE98 File Offset: 0x0052C098
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025C79 RID: 154745 RVA: 0x0052DEA8 File Offset: 0x0052C0A8
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C7A RID: 154746 RVA: 0x0052DEE8 File Offset: 0x0052C0E8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C7B RID: 154747 RVA: 0x0052DF02 File Offset: 0x0052C102
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C7C RID: 154748 RVA: 0x0052DF20 File Offset: 0x0052C120
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C7D RID: 154749 RVA: 0x0052DF39 File Offset: 0x0052C139
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C7E RID: 154750 RVA: 0x0052DF44 File Offset: 0x0052C144
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025C7F RID: 154751 RVA: 0x0052DF54 File Offset: 0x0052C154
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C80 RID: 154752 RVA: 0x0052DF94 File Offset: 0x0052C194
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C81 RID: 154753 RVA: 0x0052DFAE File Offset: 0x0052C1AE
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C82 RID: 154754 RVA: 0x0052DFCC File Offset: 0x0052C1CC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C83 RID: 154755 RVA: 0x0052DFE5 File Offset: 0x0052C1E5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C84 RID: 154756 RVA: 0x0052DFF0 File Offset: 0x0052C1F0
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06025C85 RID: 154757 RVA: 0x0052E000 File Offset: 0x0052C200
		public static void AddHookDataAssetOverride(FlatBufferBuilder builder, StringOffset hookDataAssetOverrideOffset)
		{
			builder.AddOffset(5, hookDataAssetOverrideOffset.Value, 0);
		}

		// Token: 0x06025C86 RID: 154758 RVA: 0x0052E010 File Offset: 0x0052C210
		public static void AddSupportSwitchHookMidway(FlatBufferBuilder builder, bool supportSwitchHookMidway)
		{
			builder.AddBool(6, supportSwitchHookMidway, false);
		}

		// Token: 0x06025C87 RID: 154759 RVA: 0x0052E01B File Offset: 0x0052C21B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06025C88 RID: 154760 RVA: 0x0052E026 File Offset: 0x0052C226
		public static Offset<IKiteHook> EndIKiteHook(FlatBufferBuilder builder)
		{
			return new Offset<IKiteHook>(builder.EndTable());
		}

		// Token: 0x06025C89 RID: 154761 RVA: 0x0052E034 File Offset: 0x0052C234
		public IKiteHookT UnPack()
		{
			IKiteHookT kiteHookT = new IKiteHookT();
			this.UnPackTo(kiteHookT);
			return kiteHookT;
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x0052E050 File Offset: 0x0052C250
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

		// Token: 0x06025C8B RID: 154763 RVA: 0x0052E1BC File Offset: 0x0052C3BC
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

		// Token: 0x0400F39B RID: 62363
		private Table __p;
	}
}
