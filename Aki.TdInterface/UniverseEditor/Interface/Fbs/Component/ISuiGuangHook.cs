using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EF RID: 23023
	public struct ISuiGuangHook : IFlatbufferObject
	{
		// Token: 0x1700ACF1 RID: 44273
		// (get) Token: 0x060270F6 RID: 159990 RVA: 0x0055F9B0 File Offset: 0x0055DBB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270F7 RID: 159991 RVA: 0x0055F9BD File Offset: 0x0055DBBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270F8 RID: 159992 RVA: 0x0055F9C4 File Offset: 0x0055DBC4
		public static ISuiGuangHook GetRootAsISuiGuangHook(ByteBuffer _bb)
		{
			return ISuiGuangHook.GetRootAsISuiGuangHook(_bb, default(ISuiGuangHook));
		}

		// Token: 0x060270F9 RID: 159993 RVA: 0x0055F9E0 File Offset: 0x0055DBE0
		public static ISuiGuangHook GetRootAsISuiGuangHook(ByteBuffer _bb, ISuiGuangHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270FA RID: 159994 RVA: 0x0055F9FD File Offset: 0x0055DBFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270FB RID: 159995 RVA: 0x0055FA0C File Offset: 0x0055DC0C
		public ISuiGuangHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACF2 RID: 44274
		// (get) Token: 0x060270FC RID: 159996 RVA: 0x0055FA1C File Offset: 0x0055DC1C
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

		// Token: 0x060270FD RID: 159997 RVA: 0x0055FA58 File Offset: 0x0055DC58
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ACF3 RID: 44275
		// (get) Token: 0x060270FE RID: 159998 RVA: 0x0055FAB8 File Offset: 0x0055DCB8
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

		// Token: 0x060270FF RID: 159999 RVA: 0x0055FAE4 File Offset: 0x0055DCE4
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ACF4 RID: 44276
		// (get) Token: 0x06027100 RID: 160000 RVA: 0x0055FB44 File Offset: 0x0055DD44
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

		// Token: 0x06027101 RID: 160001 RVA: 0x0055FB70 File Offset: 0x0055DD70
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ACF5 RID: 44277
		// (get) Token: 0x06027102 RID: 160002 RVA: 0x0055FBD4 File Offset: 0x0055DDD4
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

		// Token: 0x1700ACF6 RID: 44278
		// (get) Token: 0x06027103 RID: 160003 RVA: 0x0055FC00 File Offset: 0x0055DE00
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

		// Token: 0x1700ACF7 RID: 44279
		// (get) Token: 0x06027104 RID: 160004 RVA: 0x0055FC60 File Offset: 0x0055DE60
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

		// Token: 0x06027105 RID: 160005 RVA: 0x0055FC9D File Offset: 0x0055DE9D
		public static Offset<ISuiGuangHook> CreateISuiGuangHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISuiGuangHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ISuiGuangHook.AddFinishActions(builder, FinishActionsOffset);
			ISuiGuangHook.AddExitHookActions(builder, ExitHookActionsOffset);
			ISuiGuangHook.AddHookActions(builder, HookActionsOffset);
			ISuiGuangHook.AddNullMask(builder, NullMask);
			ISuiGuangHook.AddType(builder, Type);
			return ISuiGuangHook.EndISuiGuangHook(builder);
		}

		// Token: 0x06027106 RID: 160006 RVA: 0x0055FCD9 File Offset: 0x0055DED9
		public static void StartISuiGuangHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027107 RID: 160007 RVA: 0x0055FCE2 File Offset: 0x0055DEE2
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027108 RID: 160008 RVA: 0x0055FCED File Offset: 0x0055DEED
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06027109 RID: 160009 RVA: 0x0055FD00 File Offset: 0x0055DF00
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602710A RID: 160010 RVA: 0x0055FD40 File Offset: 0x0055DF40
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602710B RID: 160011 RVA: 0x0055FD5A File Offset: 0x0055DF5A
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602710C RID: 160012 RVA: 0x0055FD78 File Offset: 0x0055DF78
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602710D RID: 160013 RVA: 0x0055FD91 File Offset: 0x0055DF91
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602710E RID: 160014 RVA: 0x0055FD9C File Offset: 0x0055DF9C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602710F RID: 160015 RVA: 0x0055FDAC File Offset: 0x0055DFAC
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027110 RID: 160016 RVA: 0x0055FDEC File Offset: 0x0055DFEC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027111 RID: 160017 RVA: 0x0055FE06 File Offset: 0x0055E006
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027112 RID: 160018 RVA: 0x0055FE24 File Offset: 0x0055E024
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027113 RID: 160019 RVA: 0x0055FE3D File Offset: 0x0055E03D
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027114 RID: 160020 RVA: 0x0055FE48 File Offset: 0x0055E048
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06027115 RID: 160021 RVA: 0x0055FE58 File Offset: 0x0055E058
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027116 RID: 160022 RVA: 0x0055FE98 File Offset: 0x0055E098
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027117 RID: 160023 RVA: 0x0055FEB2 File Offset: 0x0055E0B2
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027118 RID: 160024 RVA: 0x0055FED0 File Offset: 0x0055E0D0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027119 RID: 160025 RVA: 0x0055FEE9 File Offset: 0x0055E0E9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602711A RID: 160026 RVA: 0x0055FEF4 File Offset: 0x0055E0F4
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602711B RID: 160027 RVA: 0x0055FF04 File Offset: 0x0055E104
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602711C RID: 160028 RVA: 0x0055FF0F File Offset: 0x0055E10F
		public static Offset<ISuiGuangHook> EndISuiGuangHook(FlatBufferBuilder builder)
		{
			return new Offset<ISuiGuangHook>(builder.EndTable());
		}

		// Token: 0x0602711D RID: 160029 RVA: 0x0055FF1C File Offset: 0x0055E11C
		public ISuiGuangHookT UnPack()
		{
			ISuiGuangHookT suiGuangHookT = new ISuiGuangHookT();
			this.UnPackTo(suiGuangHookT);
			return suiGuangHookT;
		}

		// Token: 0x0602711E RID: 160030 RVA: 0x0055FF38 File Offset: 0x0055E138
		public void UnPackTo(ISuiGuangHookT _o)
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

		// Token: 0x0602711F RID: 160031 RVA: 0x0056008C File Offset: 0x0055E28C
		public static Offset<ISuiGuangHook> Pack(FlatBufferBuilder builder, ISuiGuangHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuiGuangHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ISuiGuangHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ISuiGuangHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ISuiGuangHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return ISuiGuangHook.CreateISuiGuangHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F026 RID: 61478
		private Table __p;
	}
}
