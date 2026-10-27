using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005739 RID: 22329
	public struct IPickInteraction : IFlatbufferObject
	{
		// Token: 0x1700A674 RID: 42612
		// (get) Token: 0x06025629 RID: 153129 RVA: 0x00528927 File Offset: 0x00526B27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602562A RID: 153130 RVA: 0x00528934 File Offset: 0x00526B34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602562B RID: 153131 RVA: 0x0052893C File Offset: 0x00526B3C
		public static IPickInteraction GetRootAsIPickInteraction(ByteBuffer _bb)
		{
			return IPickInteraction.GetRootAsIPickInteraction(_bb, default(IPickInteraction));
		}

		// Token: 0x0602562C RID: 153132 RVA: 0x00528958 File Offset: 0x00526B58
		public static IPickInteraction GetRootAsIPickInteraction(ByteBuffer _bb, IPickInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602562D RID: 153133 RVA: 0x00528975 File Offset: 0x00526B75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602562E RID: 153134 RVA: 0x00528984 File Offset: 0x00526B84
		public IPickInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A675 RID: 42613
		// (get) Token: 0x0602562F RID: 153135 RVA: 0x00528994 File Offset: 0x00526B94
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

		// Token: 0x06025630 RID: 153136 RVA: 0x005289D0 File Offset: 0x00526BD0
		public IActionInfo? CheckedActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A676 RID: 42614
		// (get) Token: 0x06025631 RID: 153137 RVA: 0x00528A30 File Offset: 0x00526C30
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

		// Token: 0x06025632 RID: 153138 RVA: 0x00528A5C File Offset: 0x00526C5C
		public IActionInfo? UncheckedActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A677 RID: 42615
		// (get) Token: 0x06025633 RID: 153139 RVA: 0x00528ABC File Offset: 0x00526CBC
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

		// Token: 0x1700A678 RID: 42616
		// (get) Token: 0x06025634 RID: 153140 RVA: 0x00528AE8 File Offset: 0x00526CE8
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

		// Token: 0x06025635 RID: 153141 RVA: 0x00528B25 File Offset: 0x00526D25
		public static Offset<IPickInteraction> CreateIPickInteraction(FlatBufferBuilder builder, EPickInteraction Type = EPickInteraction.ChessmanInteract, VectorOffset CheckedActionsOffset = default(VectorOffset), VectorOffset UncheckedActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPickInteraction.AddUncheckedActions(builder, UncheckedActionsOffset);
			IPickInteraction.AddCheckedActions(builder, CheckedActionsOffset);
			IPickInteraction.AddNullMask(builder, NullMask);
			IPickInteraction.AddType(builder, Type);
			return IPickInteraction.EndIPickInteraction(builder);
		}

		// Token: 0x06025636 RID: 153142 RVA: 0x00528B51 File Offset: 0x00526D51
		public static void StartIPickInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025637 RID: 153143 RVA: 0x00528B5A File Offset: 0x00526D5A
		public static void AddType(FlatBufferBuilder builder, EPickInteraction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025638 RID: 153144 RVA: 0x00528B65 File Offset: 0x00526D65
		public static void AddCheckedActions(FlatBufferBuilder builder, VectorOffset checkedActionsOffset)
		{
			builder.AddOffset(1, checkedActionsOffset.Value, 0);
		}

		// Token: 0x06025639 RID: 153145 RVA: 0x00528B78 File Offset: 0x00526D78
		public static VectorOffset CreateCheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602563A RID: 153146 RVA: 0x00528BB8 File Offset: 0x00526DB8
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602563B RID: 153147 RVA: 0x00528BD2 File Offset: 0x00526DD2
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602563C RID: 153148 RVA: 0x00528BF0 File Offset: 0x00526DF0
		public static VectorOffset CreateCheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602563D RID: 153149 RVA: 0x00528C09 File Offset: 0x00526E09
		public static void StartCheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602563E RID: 153150 RVA: 0x00528C14 File Offset: 0x00526E14
		public static void AddUncheckedActions(FlatBufferBuilder builder, VectorOffset uncheckedActionsOffset)
		{
			builder.AddOffset(2, uncheckedActionsOffset.Value, 0);
		}

		// Token: 0x0602563F RID: 153151 RVA: 0x00528C24 File Offset: 0x00526E24
		public static VectorOffset CreateUncheckedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025640 RID: 153152 RVA: 0x00528C64 File Offset: 0x00526E64
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025641 RID: 153153 RVA: 0x00528C7E File Offset: 0x00526E7E
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025642 RID: 153154 RVA: 0x00528C9C File Offset: 0x00526E9C
		public static VectorOffset CreateUncheckedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025643 RID: 153155 RVA: 0x00528CB5 File Offset: 0x00526EB5
		public static void StartUncheckedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025644 RID: 153156 RVA: 0x00528CC0 File Offset: 0x00526EC0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025645 RID: 153157 RVA: 0x00528CCB File Offset: 0x00526ECB
		public static Offset<IPickInteraction> EndIPickInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IPickInteraction>(builder.EndTable());
		}

		// Token: 0x06025646 RID: 153158 RVA: 0x00528CD8 File Offset: 0x00526ED8
		public IPickInteractionT UnPack()
		{
			IPickInteractionT pickInteractionT = new IPickInteractionT();
			this.UnPackTo(pickInteractionT);
			return pickInteractionT;
		}

		// Token: 0x06025647 RID: 153159 RVA: 0x00528CF4 File Offset: 0x00526EF4
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

		// Token: 0x06025648 RID: 153160 RVA: 0x00528DC0 File Offset: 0x00526FC0
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

		// Token: 0x0400EBBE RID: 60350
		private Table __p;
	}
}
