using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A07 RID: 23047
	public struct ISunSpiritLauncher : IFlatbufferObject
	{
		// Token: 0x1700AD24 RID: 44324
		// (get) Token: 0x060271D0 RID: 160208 RVA: 0x005615A1 File Offset: 0x0055F7A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271D1 RID: 160209 RVA: 0x005615AE File Offset: 0x0055F7AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271D2 RID: 160210 RVA: 0x005615B8 File Offset: 0x0055F7B8
		public static ISunSpiritLauncher GetRootAsISunSpiritLauncher(ByteBuffer _bb)
		{
			return ISunSpiritLauncher.GetRootAsISunSpiritLauncher(_bb, default(ISunSpiritLauncher));
		}

		// Token: 0x060271D3 RID: 160211 RVA: 0x005615D4 File Offset: 0x0055F7D4
		public static ISunSpiritLauncher GetRootAsISunSpiritLauncher(ByteBuffer _bb, ISunSpiritLauncher obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060271D4 RID: 160212 RVA: 0x005615F1 File Offset: 0x0055F7F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060271D5 RID: 160213 RVA: 0x00561600 File Offset: 0x0055F800
		public ISunSpiritLauncher __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD25 RID: 44325
		// (get) Token: 0x060271D6 RID: 160214 RVA: 0x00561610 File Offset: 0x0055F810
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

		// Token: 0x060271D7 RID: 160215 RVA: 0x0056164C File Offset: 0x0055F84C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD26 RID: 44326
		// (get) Token: 0x060271D8 RID: 160216 RVA: 0x005616AC File Offset: 0x0055F8AC
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

		// Token: 0x060271D9 RID: 160217 RVA: 0x005616D8 File Offset: 0x0055F8D8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD27 RID: 44327
		// (get) Token: 0x060271DA RID: 160218 RVA: 0x00561738 File Offset: 0x0055F938
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

		// Token: 0x060271DB RID: 160219 RVA: 0x00561764 File Offset: 0x0055F964
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD28 RID: 44328
		// (get) Token: 0x060271DC RID: 160220 RVA: 0x005617C8 File Offset: 0x0055F9C8
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

		// Token: 0x1700AD29 RID: 44329
		// (get) Token: 0x060271DD RID: 160221 RVA: 0x005617F4 File Offset: 0x0055F9F4
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

		// Token: 0x1700AD2A RID: 44330
		// (get) Token: 0x060271DE RID: 160222 RVA: 0x00561854 File Offset: 0x0055FA54
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

		// Token: 0x060271DF RID: 160223 RVA: 0x00561891 File Offset: 0x0055FA91
		public static Offset<ISunSpiritLauncher> CreateISunSpiritLauncher(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISunSpiritLauncher.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ISunSpiritLauncher.AddFinishActions(builder, FinishActionsOffset);
			ISunSpiritLauncher.AddExitHookActions(builder, ExitHookActionsOffset);
			ISunSpiritLauncher.AddHookActions(builder, HookActionsOffset);
			ISunSpiritLauncher.AddNullMask(builder, NullMask);
			ISunSpiritLauncher.AddType(builder, Type);
			return ISunSpiritLauncher.EndISunSpiritLauncher(builder);
		}

		// Token: 0x060271E0 RID: 160224 RVA: 0x005618CD File Offset: 0x0055FACD
		public static void StartISunSpiritLauncher(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060271E1 RID: 160225 RVA: 0x005618D6 File Offset: 0x0055FAD6
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060271E2 RID: 160226 RVA: 0x005618E1 File Offset: 0x0055FAE1
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060271E3 RID: 160227 RVA: 0x005618F4 File Offset: 0x0055FAF4
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060271E4 RID: 160228 RVA: 0x00561934 File Offset: 0x0055FB34
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271E5 RID: 160229 RVA: 0x0056194E File Offset: 0x0055FB4E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271E6 RID: 160230 RVA: 0x0056196C File Offset: 0x0055FB6C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060271E7 RID: 160231 RVA: 0x00561985 File Offset: 0x0055FB85
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060271E8 RID: 160232 RVA: 0x00561990 File Offset: 0x0055FB90
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060271E9 RID: 160233 RVA: 0x005619A0 File Offset: 0x0055FBA0
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060271EA RID: 160234 RVA: 0x005619E0 File Offset: 0x0055FBE0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271EB RID: 160235 RVA: 0x005619FA File Offset: 0x0055FBFA
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271EC RID: 160236 RVA: 0x00561A18 File Offset: 0x0055FC18
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060271ED RID: 160237 RVA: 0x00561A31 File Offset: 0x0055FC31
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060271EE RID: 160238 RVA: 0x00561A3C File Offset: 0x0055FC3C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060271EF RID: 160239 RVA: 0x00561A4C File Offset: 0x0055FC4C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060271F0 RID: 160240 RVA: 0x00561A8C File Offset: 0x0055FC8C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271F1 RID: 160241 RVA: 0x00561AA6 File Offset: 0x0055FCA6
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060271F2 RID: 160242 RVA: 0x00561AC4 File Offset: 0x0055FCC4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060271F3 RID: 160243 RVA: 0x00561ADD File Offset: 0x0055FCDD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060271F4 RID: 160244 RVA: 0x00561AE8 File Offset: 0x0055FCE8
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060271F5 RID: 160245 RVA: 0x00561AF8 File Offset: 0x0055FCF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060271F6 RID: 160246 RVA: 0x00561B03 File Offset: 0x0055FD03
		public static Offset<ISunSpiritLauncher> EndISunSpiritLauncher(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritLauncher>(builder.EndTable());
		}

		// Token: 0x060271F7 RID: 160247 RVA: 0x00561B10 File Offset: 0x0055FD10
		public ISunSpiritLauncherT UnPack()
		{
			ISunSpiritLauncherT sunSpiritLauncherT = new ISunSpiritLauncherT();
			this.UnPackTo(sunSpiritLauncherT);
			return sunSpiritLauncherT;
		}

		// Token: 0x060271F8 RID: 160248 RVA: 0x00561B2C File Offset: 0x0055FD2C
		public void UnPackTo(ISunSpiritLauncherT _o)
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

		// Token: 0x060271F9 RID: 160249 RVA: 0x00561C80 File Offset: 0x0055FE80
		public static Offset<ISunSpiritLauncher> Pack(FlatBufferBuilder builder, ISunSpiritLauncherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritLauncher>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ISunSpiritLauncher.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ISunSpiritLauncher.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ISunSpiritLauncher.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return ISunSpiritLauncher.CreateISunSpiritLauncher(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F049 RID: 61513
		private Table __p;
	}
}
