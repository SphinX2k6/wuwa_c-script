using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C0 RID: 22976
	public struct IInteractBehaviourActions : IFlatbufferObject
	{
		// Token: 0x1700A6CC RID: 42700
		// (get) Token: 0x06025773 RID: 153459 RVA: 0x0052369B File Offset: 0x0052189B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x005236A8 File Offset: 0x005218A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025775 RID: 153461 RVA: 0x005236B0 File Offset: 0x005218B0
		public static IInteractBehaviourActions GetRootAsIInteractBehaviourActions(ByteBuffer _bb)
		{
			return IInteractBehaviourActions.GetRootAsIInteractBehaviourActions(_bb, default(IInteractBehaviourActions));
		}

		// Token: 0x06025776 RID: 153462 RVA: 0x005236CC File Offset: 0x005218CC
		public static IInteractBehaviourActions GetRootAsIInteractBehaviourActions(ByteBuffer _bb, IInteractBehaviourActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025777 RID: 153463 RVA: 0x005236E9 File Offset: 0x005218E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025778 RID: 153464 RVA: 0x005236F8 File Offset: 0x005218F8
		public IInteractBehaviourActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6CD RID: 42701
		// (get) Token: 0x06025779 RID: 153465 RVA: 0x00523708 File Offset: 0x00521908
		public ELevelAIBehaviourType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return (ELevelAIBehaviourType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602577A RID: 153466 RVA: 0x00523744 File Offset: 0x00521944
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6CE RID: 42702
		// (get) Token: 0x0602577B RID: 153467 RVA: 0x005237A4 File Offset: 0x005219A4
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

		// Token: 0x0602577C RID: 153468 RVA: 0x005237CF File Offset: 0x005219CF
		public static Offset<IInteractBehaviourActions> CreateIInteractBehaviourActions(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractBehaviourActions.AddActions(builder, ActionsOffset);
			IInteractBehaviourActions.AddType(builder, Type);
			return IInteractBehaviourActions.EndIInteractBehaviourActions(builder);
		}

		// Token: 0x0602577D RID: 153469 RVA: 0x005237EC File Offset: 0x005219EC
		public static void StartIInteractBehaviourActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602577E RID: 153470 RVA: 0x005237F5 File Offset: 0x005219F5
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602577F RID: 153471 RVA: 0x00523800 File Offset: 0x00521A00
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06025780 RID: 153472 RVA: 0x00523810 File Offset: 0x00521A10
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025781 RID: 153473 RVA: 0x00523850 File Offset: 0x00521A50
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025782 RID: 153474 RVA: 0x0052386A File Offset: 0x00521A6A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025783 RID: 153475 RVA: 0x00523888 File Offset: 0x00521A88
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025784 RID: 153476 RVA: 0x005238A1 File Offset: 0x00521AA1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025785 RID: 153477 RVA: 0x005238AC File Offset: 0x00521AAC
		public static Offset<IInteractBehaviourActions> EndIInteractBehaviourActions(FlatBufferBuilder builder)
		{
			return new Offset<IInteractBehaviourActions>(builder.EndTable());
		}

		// Token: 0x06025786 RID: 153478 RVA: 0x005238BC File Offset: 0x00521ABC
		public IInteractBehaviourActionsT UnPack()
		{
			IInteractBehaviourActionsT interactBehaviourActionsT = new IInteractBehaviourActionsT();
			this.UnPackTo(interactBehaviourActionsT);
			return interactBehaviourActionsT;
		}

		// Token: 0x06025787 RID: 153479 RVA: 0x005238D8 File Offset: 0x00521AD8
		public void UnPackTo(IInteractBehaviourActionsT _o)
		{
			_o.Type = this.Type;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025788 RID: 153480 RVA: 0x00523944 File Offset: 0x00521B44
		public static Offset<IInteractBehaviourActions> Pack(FlatBufferBuilder builder, IInteractBehaviourActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractBehaviourActions>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IInteractBehaviourActions.CreateActionsVector(builder, array);
			}
			return IInteractBehaviourActions.CreateIInteractBehaviourActions(builder, _o.Type, actionsOffset);
		}

		// Token: 0x0400F2C2 RID: 62146
		private Table __p;
	}
}
