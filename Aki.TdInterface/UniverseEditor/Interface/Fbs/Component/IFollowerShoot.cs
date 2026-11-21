using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FF RID: 22527
	public struct IFollowerShoot : IFlatbufferObject
	{
		// Token: 0x1700A300 RID: 41728
		// (get) Token: 0x060246D8 RID: 149208 RVA: 0x005016F6 File Offset: 0x004FF8F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060246D9 RID: 149209 RVA: 0x00501703 File Offset: 0x004FF903
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060246DA RID: 149210 RVA: 0x0050170C File Offset: 0x004FF90C
		public static IFollowerShoot GetRootAsIFollowerShoot(ByteBuffer _bb)
		{
			return IFollowerShoot.GetRootAsIFollowerShoot(_bb, default(IFollowerShoot));
		}

		// Token: 0x060246DB RID: 149211 RVA: 0x00501728 File Offset: 0x004FF928
		public static IFollowerShoot GetRootAsIFollowerShoot(ByteBuffer _bb, IFollowerShoot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060246DC RID: 149212 RVA: 0x00501745 File Offset: 0x004FF945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060246DD RID: 149213 RVA: 0x00501754 File Offset: 0x004FF954
		public IFollowerShoot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A301 RID: 41729
		// (get) Token: 0x060246DE RID: 149214 RVA: 0x00501764 File Offset: 0x004FF964
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

		// Token: 0x060246DF RID: 149215 RVA: 0x005017A0 File Offset: 0x004FF9A0
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A302 RID: 41730
		// (get) Token: 0x060246E0 RID: 149216 RVA: 0x00501800 File Offset: 0x004FFA00
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

		// Token: 0x060246E1 RID: 149217 RVA: 0x0050182C File Offset: 0x004FFA2C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A303 RID: 41731
		// (get) Token: 0x060246E2 RID: 149218 RVA: 0x0050188C File Offset: 0x004FFA8C
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

		// Token: 0x060246E3 RID: 149219 RVA: 0x005018B8 File Offset: 0x004FFAB8
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A304 RID: 41732
		// (get) Token: 0x060246E4 RID: 149220 RVA: 0x0050191C File Offset: 0x004FFB1C
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

		// Token: 0x1700A305 RID: 41733
		// (get) Token: 0x060246E5 RID: 149221 RVA: 0x00501948 File Offset: 0x004FFB48
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

		// Token: 0x1700A306 RID: 41734
		// (get) Token: 0x060246E6 RID: 149222 RVA: 0x005019A8 File Offset: 0x004FFBA8
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

		// Token: 0x060246E7 RID: 149223 RVA: 0x005019E5 File Offset: 0x004FFBE5
		public static Offset<IFollowerShoot> CreateIFollowerShoot(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFollowerShoot.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFollowerShoot.AddFinishActions(builder, FinishActionsOffset);
			IFollowerShoot.AddExitHookActions(builder, ExitHookActionsOffset);
			IFollowerShoot.AddHookActions(builder, HookActionsOffset);
			IFollowerShoot.AddNullMask(builder, NullMask);
			IFollowerShoot.AddType(builder, Type);
			return IFollowerShoot.EndIFollowerShoot(builder);
		}

		// Token: 0x060246E8 RID: 149224 RVA: 0x00501A21 File Offset: 0x004FFC21
		public static void StartIFollowerShoot(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060246E9 RID: 149225 RVA: 0x00501A2A File Offset: 0x004FFC2A
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060246EA RID: 149226 RVA: 0x00501A35 File Offset: 0x004FFC35
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060246EB RID: 149227 RVA: 0x00501A48 File Offset: 0x004FFC48
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060246EC RID: 149228 RVA: 0x00501A88 File Offset: 0x004FFC88
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246ED RID: 149229 RVA: 0x00501AA2 File Offset: 0x004FFCA2
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246EE RID: 149230 RVA: 0x00501AC0 File Offset: 0x004FFCC0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060246EF RID: 149231 RVA: 0x00501AD9 File Offset: 0x004FFCD9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060246F0 RID: 149232 RVA: 0x00501AE4 File Offset: 0x004FFCE4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060246F1 RID: 149233 RVA: 0x00501AF4 File Offset: 0x004FFCF4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060246F2 RID: 149234 RVA: 0x00501B34 File Offset: 0x004FFD34
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246F3 RID: 149235 RVA: 0x00501B4E File Offset: 0x004FFD4E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246F4 RID: 149236 RVA: 0x00501B6C File Offset: 0x004FFD6C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060246F5 RID: 149237 RVA: 0x00501B85 File Offset: 0x004FFD85
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060246F6 RID: 149238 RVA: 0x00501B90 File Offset: 0x004FFD90
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060246F7 RID: 149239 RVA: 0x00501BA0 File Offset: 0x004FFDA0
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060246F8 RID: 149240 RVA: 0x00501BE0 File Offset: 0x004FFDE0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246F9 RID: 149241 RVA: 0x00501BFA File Offset: 0x004FFDFA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060246FA RID: 149242 RVA: 0x00501C18 File Offset: 0x004FFE18
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060246FB RID: 149243 RVA: 0x00501C31 File Offset: 0x004FFE31
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060246FC RID: 149244 RVA: 0x00501C3C File Offset: 0x004FFE3C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060246FD RID: 149245 RVA: 0x00501C4C File Offset: 0x004FFE4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060246FE RID: 149246 RVA: 0x00501C57 File Offset: 0x004FFE57
		public static Offset<IFollowerShoot> EndIFollowerShoot(FlatBufferBuilder builder)
		{
			return new Offset<IFollowerShoot>(builder.EndTable());
		}

		// Token: 0x060246FF RID: 149247 RVA: 0x00501C64 File Offset: 0x004FFE64
		public IFollowerShootT UnPack()
		{
			IFollowerShootT followerShootT = new IFollowerShootT();
			this.UnPackTo(followerShootT);
			return followerShootT;
		}

		// Token: 0x06024700 RID: 149248 RVA: 0x00501C80 File Offset: 0x004FFE80
		public void UnPackTo(IFollowerShootT _o)
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

		// Token: 0x06024701 RID: 149249 RVA: 0x00501DD4 File Offset: 0x004FFFD4
		public static Offset<IFollowerShoot> Pack(FlatBufferBuilder builder, IFollowerShootT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowerShoot>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFollowerShoot.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFollowerShoot.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFollowerShoot.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFollowerShoot.CreateIFollowerShoot(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F00D RID: 61453
		private Table __p;
	}
}
