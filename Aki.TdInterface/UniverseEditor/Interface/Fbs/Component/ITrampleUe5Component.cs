using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E2 RID: 24802
	public struct ITrampleUe5Component : IFlatbufferObject
	{
		// Token: 0x1700B876 RID: 47222
		// (get) Token: 0x06029FF8 RID: 172024 RVA: 0x005BB8B0 File Offset: 0x005B9AB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029FF9 RID: 172025 RVA: 0x005BB8BD File Offset: 0x005B9ABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029FFA RID: 172026 RVA: 0x005BB8C4 File Offset: 0x005B9AC4
		public static ITrampleUe5Component GetRootAsITrampleUe5Component(ByteBuffer _bb)
		{
			return ITrampleUe5Component.GetRootAsITrampleUe5Component(_bb, default(ITrampleUe5Component));
		}

		// Token: 0x06029FFB RID: 172027 RVA: 0x005BB8E0 File Offset: 0x005B9AE0
		public static ITrampleUe5Component GetRootAsITrampleUe5Component(ByteBuffer _bb, ITrampleUe5Component obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029FFC RID: 172028 RVA: 0x005BB8FD File Offset: 0x005B9AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029FFD RID: 172029 RVA: 0x005BB90C File Offset: 0x005B9B0C
		public ITrampleUe5Component __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B877 RID: 47223
		// (get) Token: 0x06029FFE RID: 172030 RVA: 0x005BB91C File Offset: 0x005B9B1C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B878 RID: 47224
		// (get) Token: 0x06029FFF RID: 172031 RVA: 0x005BB95C File Offset: 0x005B9B5C
		public bool IsDisposable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602A000 RID: 172032 RVA: 0x005BB99C File Offset: 0x005B9B9C
		public IActionInfo? TriggerActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B879 RID: 47225
		// (get) Token: 0x0602A001 RID: 172033 RVA: 0x005BB9FC File Offset: 0x005B9BFC
		public int TriggerActionsLength
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

		// Token: 0x0602A002 RID: 172034 RVA: 0x005BBA28 File Offset: 0x005B9C28
		public IActionInfo? RecoveryActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B87A RID: 47226
		// (get) Token: 0x0602A003 RID: 172035 RVA: 0x005BBA8C File Offset: 0x005B9C8C
		public int RecoveryActionsLength
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

		// Token: 0x1700B87B RID: 47227
		// (get) Token: 0x0602A004 RID: 172036 RVA: 0x005BBAB8 File Offset: 0x005B9CB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A005 RID: 172037 RVA: 0x005BBAF5 File Offset: 0x005B9CF5
		public static Offset<ITrampleUe5Component> CreateITrampleUe5Component(FlatBufferBuilder builder, bool Disabled = false, bool IsDisposable = false, VectorOffset TriggerActionsOffset = default(VectorOffset), VectorOffset RecoveryActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITrampleUe5Component.AddRecoveryActions(builder, RecoveryActionsOffset);
			ITrampleUe5Component.AddTriggerActions(builder, TriggerActionsOffset);
			ITrampleUe5Component.AddNullMask(builder, NullMask);
			ITrampleUe5Component.AddIsDisposable(builder, IsDisposable);
			ITrampleUe5Component.AddDisabled(builder, Disabled);
			return ITrampleUe5Component.EndITrampleUe5Component(builder);
		}

		// Token: 0x0602A006 RID: 172038 RVA: 0x005BBB29 File Offset: 0x005B9D29
		public static void StartITrampleUe5Component(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A007 RID: 172039 RVA: 0x005BBB32 File Offset: 0x005B9D32
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A008 RID: 172040 RVA: 0x005BBB3D File Offset: 0x005B9D3D
		public static void AddIsDisposable(FlatBufferBuilder builder, bool isDisposable)
		{
			builder.AddBool(1, isDisposable, false);
		}

		// Token: 0x0602A009 RID: 172041 RVA: 0x005BBB48 File Offset: 0x005B9D48
		public static void AddTriggerActions(FlatBufferBuilder builder, VectorOffset triggerActionsOffset)
		{
			builder.AddOffset(2, triggerActionsOffset.Value, 0);
		}

		// Token: 0x0602A00A RID: 172042 RVA: 0x005BBB58 File Offset: 0x005B9D58
		public static VectorOffset CreateTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A00B RID: 172043 RVA: 0x005BBB98 File Offset: 0x005B9D98
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A00C RID: 172044 RVA: 0x005BBBB2 File Offset: 0x005B9DB2
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A00D RID: 172045 RVA: 0x005BBBD0 File Offset: 0x005B9DD0
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A00E RID: 172046 RVA: 0x005BBBE9 File Offset: 0x005B9DE9
		public static void StartTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A00F RID: 172047 RVA: 0x005BBBF4 File Offset: 0x005B9DF4
		public static void AddRecoveryActions(FlatBufferBuilder builder, VectorOffset recoveryActionsOffset)
		{
			builder.AddOffset(3, recoveryActionsOffset.Value, 0);
		}

		// Token: 0x0602A010 RID: 172048 RVA: 0x005BBC04 File Offset: 0x005B9E04
		public static VectorOffset CreateRecoveryActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A011 RID: 172049 RVA: 0x005BBC44 File Offset: 0x005B9E44
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A012 RID: 172050 RVA: 0x005BBC5E File Offset: 0x005B9E5E
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A013 RID: 172051 RVA: 0x005BBC7C File Offset: 0x005B9E7C
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A014 RID: 172052 RVA: 0x005BBC95 File Offset: 0x005B9E95
		public static void StartRecoveryActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A015 RID: 172053 RVA: 0x005BBCA0 File Offset: 0x005B9EA0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A016 RID: 172054 RVA: 0x005BBCAB File Offset: 0x005B9EAB
		public static Offset<ITrampleUe5Component> EndITrampleUe5Component(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleUe5Component>(builder.EndTable());
		}

		// Token: 0x0602A017 RID: 172055 RVA: 0x005BBCB8 File Offset: 0x005B9EB8
		public ITrampleUe5ComponentT UnPack()
		{
			ITrampleUe5ComponentT trampleUe5ComponentT = new ITrampleUe5ComponentT();
			this.UnPackTo(trampleUe5ComponentT);
			return trampleUe5ComponentT;
		}

		// Token: 0x0602A018 RID: 172056 RVA: 0x005BBCD4 File Offset: 0x005B9ED4
		public void UnPackTo(ITrampleUe5ComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsDisposable = this.IsDisposable;
			_o.TriggerActions = new List<IActionInfoT>();
			for (int i = 0; i < this.TriggerActionsLength; i++)
			{
				_o.TriggerActions.Add((this.TriggerActions(i) != null) ? this.TriggerActions(i).Value.UnPack() : null);
			}
			_o.RecoveryActions = new List<IActionInfoT>();
			for (int j = 0; j < this.RecoveryActionsLength; j++)
			{
				_o.RecoveryActions.Add((this.RecoveryActions(j) != null) ? this.RecoveryActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A019 RID: 172057 RVA: 0x005BBDAC File Offset: 0x005B9FAC
		public static Offset<ITrampleUe5Component> Pack(FlatBufferBuilder builder, ITrampleUe5ComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleUe5Component>);
			}
			VectorOffset triggerActionsOffset = default(VectorOffset);
			if (_o.TriggerActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.TriggerActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.TriggerActions[i]);
				}
				triggerActionsOffset = ITrampleUe5Component.CreateTriggerActionsVector(builder, array);
			}
			VectorOffset recoveryActionsOffset = default(VectorOffset);
			if (_o.RecoveryActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.RecoveryActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.RecoveryActions[j]);
				}
				recoveryActionsOffset = ITrampleUe5Component.CreateRecoveryActionsVector(builder, array2);
			}
			return ITrampleUe5Component.CreateITrampleUe5Component(builder, _o.Disabled, _o.IsDisposable, triggerActionsOffset, recoveryActionsOffset, _o.NullMask);
		}

		// Token: 0x0400FEAD RID: 65197
		private Table __p;
	}
}
