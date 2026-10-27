using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543A RID: 21562
	public struct IInteractBehaviourActions : IFlatbufferObject
	{
		// Token: 0x17009E92 RID: 40594
		// (get) Token: 0x060236BB RID: 145083 RVA: 0x004E666F File Offset: 0x004E486F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236BC RID: 145084 RVA: 0x004E667C File Offset: 0x004E487C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236BD RID: 145085 RVA: 0x004E6684 File Offset: 0x004E4884
		public static IInteractBehaviourActions GetRootAsIInteractBehaviourActions(ByteBuffer _bb)
		{
			return IInteractBehaviourActions.GetRootAsIInteractBehaviourActions(_bb, default(IInteractBehaviourActions));
		}

		// Token: 0x060236BE RID: 145086 RVA: 0x004E66A0 File Offset: 0x004E48A0
		public static IInteractBehaviourActions GetRootAsIInteractBehaviourActions(ByteBuffer _bb, IInteractBehaviourActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236BF RID: 145087 RVA: 0x004E66BD File Offset: 0x004E48BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236C0 RID: 145088 RVA: 0x004E66CC File Offset: 0x004E48CC
		public IInteractBehaviourActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E93 RID: 40595
		// (get) Token: 0x060236C1 RID: 145089 RVA: 0x004E66DC File Offset: 0x004E48DC
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

		// Token: 0x060236C2 RID: 145090 RVA: 0x004E6718 File Offset: 0x004E4918
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E94 RID: 40596
		// (get) Token: 0x060236C3 RID: 145091 RVA: 0x004E6778 File Offset: 0x004E4978
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

		// Token: 0x060236C4 RID: 145092 RVA: 0x004E67A3 File Offset: 0x004E49A3
		public static Offset<IInteractBehaviourActions> CreateIInteractBehaviourActions(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractBehaviourActions.AddActions(builder, ActionsOffset);
			IInteractBehaviourActions.AddType(builder, Type);
			return IInteractBehaviourActions.EndIInteractBehaviourActions(builder);
		}

		// Token: 0x060236C5 RID: 145093 RVA: 0x004E67C0 File Offset: 0x004E49C0
		public static void StartIInteractBehaviourActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060236C6 RID: 145094 RVA: 0x004E67C9 File Offset: 0x004E49C9
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060236C7 RID: 145095 RVA: 0x004E67D4 File Offset: 0x004E49D4
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060236C8 RID: 145096 RVA: 0x004E67E4 File Offset: 0x004E49E4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060236C9 RID: 145097 RVA: 0x004E6824 File Offset: 0x004E4A24
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060236CA RID: 145098 RVA: 0x004E683E File Offset: 0x004E4A3E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060236CB RID: 145099 RVA: 0x004E685C File Offset: 0x004E4A5C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060236CC RID: 145100 RVA: 0x004E6875 File Offset: 0x004E4A75
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060236CD RID: 145101 RVA: 0x004E6880 File Offset: 0x004E4A80
		public static Offset<IInteractBehaviourActions> EndIInteractBehaviourActions(FlatBufferBuilder builder)
		{
			return new Offset<IInteractBehaviourActions>(builder.EndTable());
		}

		// Token: 0x060236CE RID: 145102 RVA: 0x004E6890 File Offset: 0x004E4A90
		public IInteractBehaviourActionsT UnPack()
		{
			IInteractBehaviourActionsT interactBehaviourActionsT = new IInteractBehaviourActionsT();
			this.UnPackTo(interactBehaviourActionsT);
			return interactBehaviourActionsT;
		}

		// Token: 0x060236CF RID: 145103 RVA: 0x004E68AC File Offset: 0x004E4AAC
		public void UnPackTo(IInteractBehaviourActionsT _o)
		{
			_o.Type = this.Type;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060236D0 RID: 145104 RVA: 0x004E6918 File Offset: 0x004E4B18
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

		// Token: 0x0400E691 RID: 59025
		private Table __p;
	}
}
