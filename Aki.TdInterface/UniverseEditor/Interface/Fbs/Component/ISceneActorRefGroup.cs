using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAD RID: 24237
	public struct ISceneActorRefGroup : IFlatbufferObject
	{
		// Token: 0x1700B30A RID: 45834
		// (get) Token: 0x060289AA RID: 166314 RVA: 0x0058D2D5 File Offset: 0x0058B4D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060289AB RID: 166315 RVA: 0x0058D2E2 File Offset: 0x0058B4E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060289AC RID: 166316 RVA: 0x0058D2EC File Offset: 0x0058B4EC
		public static ISceneActorRefGroup GetRootAsISceneActorRefGroup(ByteBuffer _bb)
		{
			return ISceneActorRefGroup.GetRootAsISceneActorRefGroup(_bb, default(ISceneActorRefGroup));
		}

		// Token: 0x060289AD RID: 166317 RVA: 0x0058D308 File Offset: 0x0058B508
		public static ISceneActorRefGroup GetRootAsISceneActorRefGroup(ByteBuffer _bb, ISceneActorRefGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060289AE RID: 166318 RVA: 0x0058D325 File Offset: 0x0058B525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060289AF RID: 166319 RVA: 0x0058D334 File Offset: 0x0058B534
		public ISceneActorRefGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B30B RID: 45835
		// (get) Token: 0x060289B0 RID: 166320 RVA: 0x0058D344 File Offset: 0x0058B544
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

		// Token: 0x060289B1 RID: 166321 RVA: 0x0058D37B File Offset: 0x0058B57B
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060289B2 RID: 166322 RVA: 0x0058D38A File Offset: 0x0058B58A
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060289B3 RID: 166323 RVA: 0x0058D398 File Offset: 0x0058B598
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B30C RID: 45836
		// (get) Token: 0x060289B4 RID: 166324 RVA: 0x0058D3F8 File Offset: 0x0058B5F8
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

		// Token: 0x060289B5 RID: 166325 RVA: 0x0058D423 File Offset: 0x0058B623
		public static Offset<ISceneActorRefGroup> CreateISceneActorRefGroup(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISceneActorRefGroup.AddActions(builder, ActionsOffset);
			ISceneActorRefGroup.AddEntityState(builder, EntityStateOffset);
			return ISceneActorRefGroup.EndISceneActorRefGroup(builder);
		}

		// Token: 0x060289B6 RID: 166326 RVA: 0x0058D440 File Offset: 0x0058B640
		public static void StartISceneActorRefGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060289B7 RID: 166327 RVA: 0x0058D449 File Offset: 0x0058B649
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x060289B8 RID: 166328 RVA: 0x0058D459 File Offset: 0x0058B659
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060289B9 RID: 166329 RVA: 0x0058D46C File Offset: 0x0058B66C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060289BA RID: 166330 RVA: 0x0058D4AC File Offset: 0x0058B6AC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060289BB RID: 166331 RVA: 0x0058D4C6 File Offset: 0x0058B6C6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060289BC RID: 166332 RVA: 0x0058D4E4 File Offset: 0x0058B6E4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060289BD RID: 166333 RVA: 0x0058D4FD File Offset: 0x0058B6FD
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060289BE RID: 166334 RVA: 0x0058D508 File Offset: 0x0058B708
		public static Offset<ISceneActorRefGroup> EndISceneActorRefGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorRefGroup>(builder.EndTable());
		}

		// Token: 0x060289BF RID: 166335 RVA: 0x0058D518 File Offset: 0x0058B718
		public ISceneActorRefGroupT UnPack()
		{
			ISceneActorRefGroupT sceneActorRefGroupT = new ISceneActorRefGroupT();
			this.UnPackTo(sceneActorRefGroupT);
			return sceneActorRefGroupT;
		}

		// Token: 0x060289C0 RID: 166336 RVA: 0x0058D534 File Offset: 0x0058B734
		public void UnPackTo(ISceneActorRefGroupT _o)
		{
			_o.EntityState = this.EntityState;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060289C1 RID: 166337 RVA: 0x0058D5A0 File Offset: 0x0058B7A0
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

		// Token: 0x0400FAF9 RID: 64249
		private Table __p;
	}
}
