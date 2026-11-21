using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007175 RID: 29045
	public struct ILongPressProgressAction : IFlatbufferObject
	{
		// Token: 0x1700D497 RID: 54423
		// (get) Token: 0x060327A8 RID: 206760 RVA: 0x006D27FD File Offset: 0x006D09FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327A9 RID: 206761 RVA: 0x006D280A File Offset: 0x006D0A0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327AA RID: 206762 RVA: 0x006D2814 File Offset: 0x006D0A14
		public static ILongPressProgressAction GetRootAsILongPressProgressAction(ByteBuffer _bb)
		{
			return ILongPressProgressAction.GetRootAsILongPressProgressAction(_bb, default(ILongPressProgressAction));
		}

		// Token: 0x060327AB RID: 206763 RVA: 0x006D2830 File Offset: 0x006D0A30
		public static ILongPressProgressAction GetRootAsILongPressProgressAction(ByteBuffer _bb, ILongPressProgressAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327AC RID: 206764 RVA: 0x006D284D File Offset: 0x006D0A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327AD RID: 206765 RVA: 0x006D285C File Offset: 0x006D0A5C
		public ILongPressProgressAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D498 RID: 54424
		// (get) Token: 0x060327AE RID: 206766 RVA: 0x006D286C File Offset: 0x006D0A6C
		public float Percentage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060327AF RID: 206767 RVA: 0x006D28AC File Offset: 0x006D0AAC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D499 RID: 54425
		// (get) Token: 0x060327B0 RID: 206768 RVA: 0x006D290C File Offset: 0x006D0B0C
		public int ActionsLength
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

		// Token: 0x060327B1 RID: 206769 RVA: 0x006D2937 File Offset: 0x006D0B37
		public static Offset<ILongPressProgressAction> CreateILongPressProgressAction(FlatBufferBuilder builder, float Percentage = 0f, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILongPressProgressAction.AddActions(builder, ActionsOffset);
			ILongPressProgressAction.AddPercentage(builder, Percentage);
			return ILongPressProgressAction.EndILongPressProgressAction(builder);
		}

		// Token: 0x060327B2 RID: 206770 RVA: 0x006D2954 File Offset: 0x006D0B54
		public static void StartILongPressProgressAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060327B3 RID: 206771 RVA: 0x006D295D File Offset: 0x006D0B5D
		public static void AddPercentage(FlatBufferBuilder builder, float percentage)
		{
			builder.AddFloat(0, percentage, 0.0);
		}

		// Token: 0x060327B4 RID: 206772 RVA: 0x006D2970 File Offset: 0x006D0B70
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060327B5 RID: 206773 RVA: 0x006D2980 File Offset: 0x006D0B80
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060327B6 RID: 206774 RVA: 0x006D29C0 File Offset: 0x006D0BC0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060327B7 RID: 206775 RVA: 0x006D29DA File Offset: 0x006D0BDA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060327B8 RID: 206776 RVA: 0x006D29F8 File Offset: 0x006D0BF8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060327B9 RID: 206777 RVA: 0x006D2A11 File Offset: 0x006D0C11
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060327BA RID: 206778 RVA: 0x006D2A1C File Offset: 0x006D0C1C
		public static Offset<ILongPressProgressAction> EndILongPressProgressAction(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressProgressAction>(builder.EndTable());
		}

		// Token: 0x060327BB RID: 206779 RVA: 0x006D2A2C File Offset: 0x006D0C2C
		public ILongPressProgressActionT UnPack()
		{
			ILongPressProgressActionT longPressProgressActionT = new ILongPressProgressActionT();
			this.UnPackTo(longPressProgressActionT);
			return longPressProgressActionT;
		}

		// Token: 0x060327BC RID: 206780 RVA: 0x006D2A48 File Offset: 0x006D0C48
		public void UnPackTo(ILongPressProgressActionT _o)
		{
			_o.Percentage = this.Percentage;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060327BD RID: 206781 RVA: 0x006D2AB4 File Offset: 0x006D0CB4
		public static Offset<ILongPressProgressAction> Pack(FlatBufferBuilder builder, ILongPressProgressActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressProgressAction>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ILongPressProgressAction.CreateActionsVector(builder, array);
			}
			return ILongPressProgressAction.CreateILongPressProgressAction(builder, _o.Percentage, actionsOffset);
		}

		// Token: 0x0401216A RID: 74090
		private Table __p;
	}
}
