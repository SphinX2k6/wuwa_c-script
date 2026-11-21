using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7C RID: 23420
	public struct IMovementPointHook : IFlatbufferObject
	{
		// Token: 0x1700AB28 RID: 43816
		// (get) Token: 0x0602695A RID: 158042 RVA: 0x005489C8 File Offset: 0x00546BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602695B RID: 158043 RVA: 0x005489D5 File Offset: 0x00546BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602695C RID: 158044 RVA: 0x005489DC File Offset: 0x00546BDC
		public static IMovementPointHook GetRootAsIMovementPointHook(ByteBuffer _bb)
		{
			return IMovementPointHook.GetRootAsIMovementPointHook(_bb, default(IMovementPointHook));
		}

		// Token: 0x0602695D RID: 158045 RVA: 0x005489F8 File Offset: 0x00546BF8
		public static IMovementPointHook GetRootAsIMovementPointHook(ByteBuffer _bb, IMovementPointHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602695E RID: 158046 RVA: 0x00548A15 File Offset: 0x00546C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602695F RID: 158047 RVA: 0x00548A24 File Offset: 0x00546C24
		public IMovementPointHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB29 RID: 43817
		// (get) Token: 0x06026960 RID: 158048 RVA: 0x00548A34 File Offset: 0x00546C34
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

		// Token: 0x06026961 RID: 158049 RVA: 0x00548A70 File Offset: 0x00546C70
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB2A RID: 43818
		// (get) Token: 0x06026962 RID: 158050 RVA: 0x00548AD0 File Offset: 0x00546CD0
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

		// Token: 0x06026963 RID: 158051 RVA: 0x00548AFC File Offset: 0x00546CFC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB2B RID: 43819
		// (get) Token: 0x06026964 RID: 158052 RVA: 0x00548B5C File Offset: 0x00546D5C
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

		// Token: 0x06026965 RID: 158053 RVA: 0x00548B88 File Offset: 0x00546D88
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB2C RID: 43820
		// (get) Token: 0x06026966 RID: 158054 RVA: 0x00548BEC File Offset: 0x00546DEC
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

		// Token: 0x1700AB2D RID: 43821
		// (get) Token: 0x06026967 RID: 158055 RVA: 0x00548C18 File Offset: 0x00546E18
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

		// Token: 0x1700AB2E RID: 43822
		// (get) Token: 0x06026968 RID: 158056 RVA: 0x00548C78 File Offset: 0x00546E78
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

		// Token: 0x06026969 RID: 158057 RVA: 0x00548CB5 File Offset: 0x00546EB5
		public static Offset<IMovementPointHook> CreateIMovementPointHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IMovementPointHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMovementPointHook.AddFinishActions(builder, FinishActionsOffset);
			IMovementPointHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IMovementPointHook.AddHookActions(builder, HookActionsOffset);
			IMovementPointHook.AddNullMask(builder, NullMask);
			IMovementPointHook.AddType(builder, Type);
			return IMovementPointHook.EndIMovementPointHook(builder);
		}

		// Token: 0x0602696A RID: 158058 RVA: 0x00548CF1 File Offset: 0x00546EF1
		public static void StartIMovementPointHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602696B RID: 158059 RVA: 0x00548CFA File Offset: 0x00546EFA
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602696C RID: 158060 RVA: 0x00548D05 File Offset: 0x00546F05
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602696D RID: 158061 RVA: 0x00548D18 File Offset: 0x00546F18
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602696E RID: 158062 RVA: 0x00548D58 File Offset: 0x00546F58
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602696F RID: 158063 RVA: 0x00548D72 File Offset: 0x00546F72
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026970 RID: 158064 RVA: 0x00548D90 File Offset: 0x00546F90
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026971 RID: 158065 RVA: 0x00548DA9 File Offset: 0x00546FA9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026972 RID: 158066 RVA: 0x00548DB4 File Offset: 0x00546FB4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06026973 RID: 158067 RVA: 0x00548DC4 File Offset: 0x00546FC4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026974 RID: 158068 RVA: 0x00548E04 File Offset: 0x00547004
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026975 RID: 158069 RVA: 0x00548E1E File Offset: 0x0054701E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026976 RID: 158070 RVA: 0x00548E3C File Offset: 0x0054703C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026977 RID: 158071 RVA: 0x00548E55 File Offset: 0x00547055
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026978 RID: 158072 RVA: 0x00548E60 File Offset: 0x00547060
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06026979 RID: 158073 RVA: 0x00548E70 File Offset: 0x00547070
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602697A RID: 158074 RVA: 0x00548EB0 File Offset: 0x005470B0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602697B RID: 158075 RVA: 0x00548ECA File Offset: 0x005470CA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602697C RID: 158076 RVA: 0x00548EE8 File Offset: 0x005470E8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602697D RID: 158077 RVA: 0x00548F01 File Offset: 0x00547101
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602697E RID: 158078 RVA: 0x00548F0C File Offset: 0x0054710C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602697F RID: 158079 RVA: 0x00548F1C File Offset: 0x0054711C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026980 RID: 158080 RVA: 0x00548F27 File Offset: 0x00547127
		public static Offset<IMovementPointHook> EndIMovementPointHook(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPointHook>(builder.EndTable());
		}

		// Token: 0x06026981 RID: 158081 RVA: 0x00548F34 File Offset: 0x00547134
		public IMovementPointHookT UnPack()
		{
			IMovementPointHookT movementPointHookT = new IMovementPointHookT();
			this.UnPackTo(movementPointHookT);
			return movementPointHookT;
		}

		// Token: 0x06026982 RID: 158082 RVA: 0x00548F50 File Offset: 0x00547150
		public void UnPackTo(IMovementPointHookT _o)
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

		// Token: 0x06026983 RID: 158083 RVA: 0x005490A4 File Offset: 0x005472A4
		public static Offset<IMovementPointHook> Pack(FlatBufferBuilder builder, IMovementPointHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementPointHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMovementPointHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMovementPointHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMovementPointHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMovementPointHook.CreateIMovementPointHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F5A4 RID: 62884
		private Table __p;
	}
}
