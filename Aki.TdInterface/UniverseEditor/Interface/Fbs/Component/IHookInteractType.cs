using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005948 RID: 22856
	public struct IHookInteractType : IFlatbufferObject
	{
		// Token: 0x1700A5D2 RID: 42450
		// (get) Token: 0x060252F8 RID: 152312 RVA: 0x0051A398 File Offset: 0x00518598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252F9 RID: 152313 RVA: 0x0051A3A5 File Offset: 0x005185A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252FA RID: 152314 RVA: 0x0051A3AC File Offset: 0x005185AC
		public static IHookInteractType GetRootAsIHookInteractType(ByteBuffer _bb)
		{
			return IHookInteractType.GetRootAsIHookInteractType(_bb, default(IHookInteractType));
		}

		// Token: 0x060252FB RID: 152315 RVA: 0x0051A3C8 File Offset: 0x005185C8
		public static IHookInteractType GetRootAsIHookInteractType(ByteBuffer _bb, IHookInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252FC RID: 152316 RVA: 0x0051A3E5 File Offset: 0x005185E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252FD RID: 152317 RVA: 0x0051A3F4 File Offset: 0x005185F4
		public IHookInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5D3 RID: 42451
		// (get) Token: 0x060252FE RID: 152318 RVA: 0x0051A404 File Offset: 0x00518604
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

		// Token: 0x060252FF RID: 152319 RVA: 0x0051A440 File Offset: 0x00518640
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5D4 RID: 42452
		// (get) Token: 0x06025300 RID: 152320 RVA: 0x0051A4A0 File Offset: 0x005186A0
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

		// Token: 0x06025301 RID: 152321 RVA: 0x0051A4CC File Offset: 0x005186CC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5D5 RID: 42453
		// (get) Token: 0x06025302 RID: 152322 RVA: 0x0051A52C File Offset: 0x0051872C
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

		// Token: 0x06025303 RID: 152323 RVA: 0x0051A558 File Offset: 0x00518758
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5D6 RID: 42454
		// (get) Token: 0x06025304 RID: 152324 RVA: 0x0051A5BC File Offset: 0x005187BC
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

		// Token: 0x1700A5D7 RID: 42455
		// (get) Token: 0x06025305 RID: 152325 RVA: 0x0051A5E8 File Offset: 0x005187E8
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

		// Token: 0x1700A5D8 RID: 42456
		// (get) Token: 0x06025306 RID: 152326 RVA: 0x0051A648 File Offset: 0x00518848
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

		// Token: 0x06025307 RID: 152327 RVA: 0x0051A685 File Offset: 0x00518885
		public static Offset<IHookInteractType> CreateIHookInteractType(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IHookInteractType.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IHookInteractType.AddFinishActions(builder, FinishActionsOffset);
			IHookInteractType.AddExitHookActions(builder, ExitHookActionsOffset);
			IHookInteractType.AddHookActions(builder, HookActionsOffset);
			IHookInteractType.AddNullMask(builder, NullMask);
			IHookInteractType.AddType(builder, Type);
			return IHookInteractType.EndIHookInteractType(builder);
		}

		// Token: 0x06025308 RID: 152328 RVA: 0x0051A6C1 File Offset: 0x005188C1
		public static void StartIHookInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025309 RID: 152329 RVA: 0x0051A6CA File Offset: 0x005188CA
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602530A RID: 152330 RVA: 0x0051A6D5 File Offset: 0x005188D5
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602530B RID: 152331 RVA: 0x0051A6E8 File Offset: 0x005188E8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602530C RID: 152332 RVA: 0x0051A728 File Offset: 0x00518928
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602530D RID: 152333 RVA: 0x0051A742 File Offset: 0x00518942
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602530E RID: 152334 RVA: 0x0051A760 File Offset: 0x00518960
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602530F RID: 152335 RVA: 0x0051A779 File Offset: 0x00518979
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025310 RID: 152336 RVA: 0x0051A784 File Offset: 0x00518984
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025311 RID: 152337 RVA: 0x0051A794 File Offset: 0x00518994
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025312 RID: 152338 RVA: 0x0051A7D4 File Offset: 0x005189D4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025313 RID: 152339 RVA: 0x0051A7EE File Offset: 0x005189EE
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025314 RID: 152340 RVA: 0x0051A80C File Offset: 0x00518A0C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025315 RID: 152341 RVA: 0x0051A825 File Offset: 0x00518A25
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025316 RID: 152342 RVA: 0x0051A830 File Offset: 0x00518A30
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025317 RID: 152343 RVA: 0x0051A840 File Offset: 0x00518A40
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025318 RID: 152344 RVA: 0x0051A880 File Offset: 0x00518A80
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025319 RID: 152345 RVA: 0x0051A89A File Offset: 0x00518A9A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602531A RID: 152346 RVA: 0x0051A8B8 File Offset: 0x00518AB8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602531B RID: 152347 RVA: 0x0051A8D1 File Offset: 0x00518AD1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602531C RID: 152348 RVA: 0x0051A8DC File Offset: 0x00518ADC
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602531D RID: 152349 RVA: 0x0051A8EC File Offset: 0x00518AEC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602531E RID: 152350 RVA: 0x0051A8F7 File Offset: 0x00518AF7
		public static Offset<IHookInteractType> EndIHookInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IHookInteractType>(builder.EndTable());
		}

		// Token: 0x0602531F RID: 152351 RVA: 0x0051A904 File Offset: 0x00518B04
		public IHookInteractTypeT UnPack()
		{
			IHookInteractTypeT hookInteractTypeT = new IHookInteractTypeT();
			this.UnPackTo(hookInteractTypeT);
			return hookInteractTypeT;
		}

		// Token: 0x06025320 RID: 152352 RVA: 0x0051A920 File Offset: 0x00518B20
		public void UnPackTo(IHookInteractTypeT _o)
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

		// Token: 0x06025321 RID: 152353 RVA: 0x0051AA74 File Offset: 0x00518C74
		public static Offset<IHookInteractType> Pack(FlatBufferBuilder builder, IHookInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookInteractType>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IHookInteractType.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IHookInteractType.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IHookInteractType.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IHookInteractType.CreateIHookInteractType(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F1F6 RID: 61942
		private Table __p;
	}
}
