using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A0 RID: 22688
	public struct ISceneActorRefGroup : IFlatbufferObject
	{
		// Token: 0x1700A9DA RID: 43482
		// (get) Token: 0x06026448 RID: 156744 RVA: 0x00546789 File Offset: 0x00544989
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026449 RID: 156745 RVA: 0x00546796 File Offset: 0x00544996
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602644A RID: 156746 RVA: 0x005467A0 File Offset: 0x005449A0
		public static ISceneActorRefGroup GetRootAsISceneActorRefGroup(ByteBuffer _bb)
		{
			return ISceneActorRefGroup.GetRootAsISceneActorRefGroup(_bb, default(ISceneActorRefGroup));
		}

		// Token: 0x0602644B RID: 156747 RVA: 0x005467BC File Offset: 0x005449BC
		public static ISceneActorRefGroup GetRootAsISceneActorRefGroup(ByteBuffer _bb, ISceneActorRefGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602644C RID: 156748 RVA: 0x005467D9 File Offset: 0x005449D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602644D RID: 156749 RVA: 0x005467E8 File Offset: 0x005449E8
		public ISceneActorRefGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9DB RID: 43483
		// (get) Token: 0x0602644E RID: 156750 RVA: 0x005467F8 File Offset: 0x005449F8
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602644F RID: 156751 RVA: 0x0054682F File Offset: 0x00544A2F
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026450 RID: 156752 RVA: 0x0054683E File Offset: 0x00544A3E
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026451 RID: 156753 RVA: 0x0054684C File Offset: 0x00544A4C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9DC RID: 43484
		// (get) Token: 0x06026452 RID: 156754 RVA: 0x005468AC File Offset: 0x00544AAC
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

		// Token: 0x06026453 RID: 156755 RVA: 0x005468D7 File Offset: 0x00544AD7
		public static Offset<ISceneActorRefGroup> CreateISceneActorRefGroup(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISceneActorRefGroup.AddActions(builder, ActionsOffset);
			ISceneActorRefGroup.AddEntityState(builder, EntityStateOffset);
			return ISceneActorRefGroup.EndISceneActorRefGroup(builder);
		}

		// Token: 0x06026454 RID: 156756 RVA: 0x005468F4 File Offset: 0x00544AF4
		public static void StartISceneActorRefGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026455 RID: 156757 RVA: 0x005468FD File Offset: 0x00544AFD
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x06026456 RID: 156758 RVA: 0x0054690D File Offset: 0x00544B0D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06026457 RID: 156759 RVA: 0x00546920 File Offset: 0x00544B20
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026458 RID: 156760 RVA: 0x00546960 File Offset: 0x00544B60
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026459 RID: 156761 RVA: 0x0054697A File Offset: 0x00544B7A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602645A RID: 156762 RVA: 0x00546998 File Offset: 0x00544B98
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602645B RID: 156763 RVA: 0x005469B1 File Offset: 0x00544BB1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602645C RID: 156764 RVA: 0x005469BC File Offset: 0x00544BBC
		public static Offset<ISceneActorRefGroup> EndISceneActorRefGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorRefGroup>(builder.EndTable());
		}

		// Token: 0x0602645D RID: 156765 RVA: 0x005469CC File Offset: 0x00544BCC
		public ISceneActorRefGroupT UnPack()
		{
			ISceneActorRefGroupT sceneActorRefGroupT = new ISceneActorRefGroupT();
			this.UnPackTo(sceneActorRefGroupT);
			return sceneActorRefGroupT;
		}

		// Token: 0x0602645E RID: 156766 RVA: 0x005469E8 File Offset: 0x00544BE8
		public void UnPackTo(ISceneActorRefGroupT _o)
		{
			_o.EntityState = this.EntityState;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602645F RID: 156767 RVA: 0x00546A54 File Offset: 0x00544C54
		public static Offset<ISceneActorRefGroup> Pack(FlatBufferBuilder builder, ISceneActorRefGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorRefGroup>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ISceneActorRefGroup.CreateActionsVector(builder, array);
			}
			return ISceneActorRefGroup.CreateISceneActorRefGroup(builder, entityStateOffset, actionsOffset);
		}

		// Token: 0x0400EE06 RID: 60934
		private Table __p;
	}
}
