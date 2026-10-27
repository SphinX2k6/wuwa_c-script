using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD5 RID: 23253
	public struct ITrampleUe5Component : IFlatbufferObject
	{
		// Token: 0x1700AF3A RID: 44858
		// (get) Token: 0x06027A6C RID: 162412 RVA: 0x00574432 File Offset: 0x00572632
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x0057443F File Offset: 0x0057263F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A6E RID: 162414 RVA: 0x00574448 File Offset: 0x00572648
		public static ITrampleUe5Component GetRootAsITrampleUe5Component(ByteBuffer _bb)
		{
			return ITrampleUe5Component.GetRootAsITrampleUe5Component(_bb, default(ITrampleUe5Component));
		}

		// Token: 0x06027A6F RID: 162415 RVA: 0x00574464 File Offset: 0x00572664
		public static ITrampleUe5Component GetRootAsITrampleUe5Component(ByteBuffer _bb, ITrampleUe5Component obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A70 RID: 162416 RVA: 0x00574481 File Offset: 0x00572681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A71 RID: 162417 RVA: 0x00574490 File Offset: 0x00572690
		public ITrampleUe5Component __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF3B RID: 44859
		// (get) Token: 0x06027A72 RID: 162418 RVA: 0x005744A0 File Offset: 0x005726A0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF3C RID: 44860
		// (get) Token: 0x06027A73 RID: 162419 RVA: 0x005744E0 File Offset: 0x005726E0
		public bool IsDisposable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027A74 RID: 162420 RVA: 0x00574520 File Offset: 0x00572720
		public IActionInfo? TriggerActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF3D RID: 44861
		// (get) Token: 0x06027A75 RID: 162421 RVA: 0x00574580 File Offset: 0x00572780
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

		// Token: 0x06027A76 RID: 162422 RVA: 0x005745AC File Offset: 0x005727AC
		public IActionInfo? RecoveryActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF3E RID: 44862
		// (get) Token: 0x06027A77 RID: 162423 RVA: 0x00574610 File Offset: 0x00572810
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

		// Token: 0x1700AF3F RID: 44863
		// (get) Token: 0x06027A78 RID: 162424 RVA: 0x0057463C File Offset: 0x0057283C
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

		// Token: 0x06027A79 RID: 162425 RVA: 0x00574679 File Offset: 0x00572879
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

		// Token: 0x06027A7A RID: 162426 RVA: 0x005746AD File Offset: 0x005728AD
		public static void StartITrampleUe5Component(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027A7B RID: 162427 RVA: 0x005746B6 File Offset: 0x005728B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027A7C RID: 162428 RVA: 0x005746C1 File Offset: 0x005728C1
		public static void AddIsDisposable(FlatBufferBuilder builder, bool isDisposable)
		{
			builder.AddBool(1, isDisposable, false);
		}

		// Token: 0x06027A7D RID: 162429 RVA: 0x005746CC File Offset: 0x005728CC
		public static void AddTriggerActions(FlatBufferBuilder builder, VectorOffset triggerActionsOffset)
		{
			builder.AddOffset(2, triggerActionsOffset.Value, 0);
		}

		// Token: 0x06027A7E RID: 162430 RVA: 0x005746DC File Offset: 0x005728DC
		public static VectorOffset CreateTriggerActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A7F RID: 162431 RVA: 0x0057471C File Offset: 0x0057291C
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A80 RID: 162432 RVA: 0x00574736 File Offset: 0x00572936
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A81 RID: 162433 RVA: 0x00574754 File Offset: 0x00572954
		public static VectorOffset CreateTriggerActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A82 RID: 162434 RVA: 0x0057476D File Offset: 0x0057296D
		public static void StartTriggerActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A83 RID: 162435 RVA: 0x00574778 File Offset: 0x00572978
		public static void AddRecoveryActions(FlatBufferBuilder builder, VectorOffset recoveryActionsOffset)
		{
			builder.AddOffset(3, recoveryActionsOffset.Value, 0);
		}

		// Token: 0x06027A84 RID: 162436 RVA: 0x00574788 File Offset: 0x00572988
		public static VectorOffset CreateRecoveryActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A85 RID: 162437 RVA: 0x005747C8 File Offset: 0x005729C8
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A86 RID: 162438 RVA: 0x005747E2 File Offset: 0x005729E2
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A87 RID: 162439 RVA: 0x00574800 File Offset: 0x00572A00
		public static VectorOffset CreateRecoveryActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A88 RID: 162440 RVA: 0x00574819 File Offset: 0x00572A19
		public static void StartRecoveryActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A89 RID: 162441 RVA: 0x00574824 File Offset: 0x00572A24
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027A8A RID: 162442 RVA: 0x0057482F File Offset: 0x00572A2F
		public static Offset<ITrampleUe5Component> EndITrampleUe5Component(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleUe5Component>(builder.EndTable());
		}

		// Token: 0x06027A8B RID: 162443 RVA: 0x0057483C File Offset: 0x00572A3C
		public ITrampleUe5ComponentT UnPack()
		{
			ITrampleUe5ComponentT trampleUe5ComponentT = new ITrampleUe5ComponentT();
			this.UnPackTo(trampleUe5ComponentT);
			return trampleUe5ComponentT;
		}

		// Token: 0x06027A8C RID: 162444 RVA: 0x00574858 File Offset: 0x00572A58
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

		// Token: 0x06027A8D RID: 162445 RVA: 0x00574930 File Offset: 0x00572B30
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

		// Token: 0x0400F1B3 RID: 61875
		private Table __p;
	}
}
