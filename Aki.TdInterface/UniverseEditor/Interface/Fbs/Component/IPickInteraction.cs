using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D40 RID: 23872
	public struct IPickInteraction : IFlatbufferObject
	{
		// Token: 0x1700AF98 RID: 44952
		// (get) Token: 0x06027B49 RID: 162633 RVA: 0x0056EAB3 File Offset: 0x0056CCB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B4A RID: 162634 RVA: 0x0056EAC0 File Offset: 0x0056CCC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B4B RID: 162635 RVA: 0x0056EAC8 File Offset: 0x0056CCC8
		public static IPickInteraction GetRootAsIPickInteraction(ByteBuffer _bb)
		{
			return IPickInteraction.GetRootAsIPickInteraction(_bb, default(IPickInteraction));
		}

		// Token: 0x06027B4C RID: 162636 RVA: 0x0056EAE4 File Offset: 0x0056CCE4
		public static IPickInteraction GetRootAsIPickInteraction(ByteBuffer _bb, IPickInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B4D RID: 162637 RVA: 0x0056EB01 File Offset: 0x0056CD01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B4E RID: 162638 RVA: 0x0056EB10 File Offset: 0x0056CD10
		public IPickInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF99 RID: 44953
		// (get) Token: 0x06027B4F RID: 162639 RVA: 0x0056EB20 File Offset: 0x0056CD20
		public EPickInteraction Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPickInteraction.ChessmanInteract;
				}
				return (EPickInteraction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B50 RID: 162640 RVA: 0x0056EB5C File Offset: 0x0056CD5C
		public IActionInfo? CheckedActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF9A RID: 44954
		// (get) Token: 0x06027B51 RID: 162641 RVA: 0x0056EBBC File Offset: 0x0056CDBC
		public int CheckedActionsLength
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

		// Token: 0x06027B52 RID: 162642 RVA: 0x0056EBE8 File Offset: 0x0056CDE8
		public IActionInfo? UncheckedActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF9B RID: 44955
		// (get) Token: 0x06027B53 RID: 162643 RVA: 0x0056EC48 File Offset: 0x0056CE48
		public int UncheckedActionsLength
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

		// Token: 0x1700AF9C RID: 44956
		// (get) Token: 0x06027B54 RID: 162644 RVA: 0x0056EC74 File Offset: 0x0056CE74
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B55 RID: 162645 RVA: 0x0056ECB1 File Offset: 0x0056CEB1
		public static Offset<IPickInteraction> CreateIPickInteraction(FlatBufferBuilder builder, EPickInteraction Type = EPickInteraction.ChessmanInteract, VectorOffset CheckedActionsOffset = default(VectorOffset), VectorOffset UncheckedActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPickInteraction.AddUncheckedActions(builder, UncheckedActionsOffset);
			IPickInteraction.AddCheckedActions(builder, CheckedActionsOffset);
			IPickInteraction.AddNullMask(builder, NullMask);
			IPickInteraction.AddType(builder, Type);
			return IPickInteraction.EndIPickInteraction(builder);
		}

		// Token: 0x06027B56 RID: 162646 RVA: 0x0056ECDD File Offset: 0x0056CEDD
		public static void StartIPickInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027B57 RID: 162647 RVA: 0x0056ECE6 File Offset: 0x0056CEE6
		public static void AddType(FlatBufferBuilder builder, EPickInteraction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027B58 RID: 162648 RVA: 0x0056ECF1 File Offset: 0x0056CEF1
		public static void AddCheckedActions(FlatBufferBuilder builder, VectorOffset checkedActionsOffset)
		{
			builder.AddOffset(1, checkedActionsOffset.Value, 0);
		}

		// Token: 0x06027B59 RID: 162649 RVA: 0x0056ED04 File Offset: 0x0056CF04
		public static VectorOffset CreateCheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027B5A RID: 162650 RVA: 0x0056ED44 File Offset: 0x0056CF44
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B5B RID: 162651 RVA: 0x0056ED5E File Offset: 0x0056CF5E
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B5C RID: 162652 RVA: 0x0056ED7C File Offset: 0x0056CF7C
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027B5D RID: 162653 RVA: 0x0056ED95 File Offset: 0x0056CF95
		public static void StartCheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027B5E RID: 162654 RVA: 0x0056EDA0 File Offset: 0x0056CFA0
		public static void AddUncheckedActions(FlatBufferBuilder builder, VectorOffset uncheckedActionsOffset)
		{
			builder.AddOffset(2, uncheckedActionsOffset.Value, 0);
		}

		// Token: 0x06027B5F RID: 162655 RVA: 0x0056EDB0 File Offset: 0x0056CFB0
		public static VectorOffset CreateUncheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027B60 RID: 162656 RVA: 0x0056EDF0 File Offset: 0x0056CFF0
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B61 RID: 162657 RVA: 0x0056EE0A File Offset: 0x0056D00A
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B62 RID: 162658 RVA: 0x0056EE28 File Offset: 0x0056D028
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027B63 RID: 162659 RVA: 0x0056EE41 File Offset: 0x0056D041
		public static void StartUncheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027B64 RID: 162660 RVA: 0x0056EE4C File Offset: 0x0056D04C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027B65 RID: 162661 RVA: 0x0056EE57 File Offset: 0x0056D057
		public static Offset<IPickInteraction> EndIPickInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IPickInteraction>(builder.EndTable());
		}

		// Token: 0x06027B66 RID: 162662 RVA: 0x0056EE64 File Offset: 0x0056D064
		public IPickInteractionT UnPack()
		{
			IPickInteractionT pickInteractionT = new IPickInteractionT();
			this.UnPackTo(pickInteractionT);
			return pickInteractionT;
		}

		// Token: 0x06027B67 RID: 162663 RVA: 0x0056EE80 File Offset: 0x0056D080
		public void UnPackTo(IPickInteractionT _o)
		{
			_o.Type = this.Type;
			_o.CheckedActions = new List<IActionInfoT>();
			for (int i = 0; i < this.CheckedActionsLength; i++)
			{
				_o.CheckedActions.Add((this.CheckedActions(i) != null) ? this.CheckedActions(i).Value.UnPack() : null);
			}
			_o.UncheckedActions = new List<IActionInfoT>();
			for (int j = 0; j < this.UncheckedActionsLength; j++)
			{
				_o.UncheckedActions.Add((this.UncheckedActions(j) != null) ? this.UncheckedActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027B68 RID: 162664 RVA: 0x0056EF4C File Offset: 0x0056D14C
		public static Offset<IPickInteraction> Pack(FlatBufferBuilder builder, IPickInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPickInteraction>);
			}
			VectorOffset checkedActionsOffset = default(VectorOffset);
			if (_o.CheckedActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.CheckedActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.CheckedActions[i]);
				}
				checkedActionsOffset = IPickInteraction.CreateCheckedActionsVector(builder, array);
			}
			VectorOffset uncheckedActionsOffset = default(VectorOffset);
			if (_o.UncheckedActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.UncheckedActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.UncheckedActions[j]);
				}
				uncheckedActionsOffset = IPickInteraction.CreateUncheckedActionsVector(builder, array2);
			}
			return IPickInteraction.CreateIPickInteraction(builder, _o.Type, checkedActionsOffset, uncheckedActionsOffset, _o.NullMask);
		}

		// Token: 0x0400F8A9 RID: 63657
		private Table __p;
	}
}
