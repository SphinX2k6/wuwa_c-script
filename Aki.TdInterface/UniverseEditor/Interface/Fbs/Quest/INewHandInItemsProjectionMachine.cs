using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004397 RID: 17303
	public struct INewHandInItemsProjectionMachine : IFlatbufferObject
	{
		// Token: 0x170076B4 RID: 30388
		// (get) Token: 0x0601875A RID: 100186 RVA: 0x0037C5EE File Offset: 0x0037A7EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601875B RID: 100187 RVA: 0x0037C5FB File Offset: 0x0037A7FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601875C RID: 100188 RVA: 0x0037C604 File Offset: 0x0037A804
		public static INewHandInItemsProjectionMachine GetRootAsINewHandInItemsProjectionMachine(ByteBuffer _bb)
		{
			return INewHandInItemsProjectionMachine.GetRootAsINewHandInItemsProjectionMachine(_bb, default(INewHandInItemsProjectionMachine));
		}

		// Token: 0x0601875D RID: 100189 RVA: 0x0037C620 File Offset: 0x0037A820
		public static INewHandInItemsProjectionMachine GetRootAsINewHandInItemsProjectionMachine(ByteBuffer _bb, INewHandInItemsProjectionMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601875E RID: 100190 RVA: 0x0037C63D File Offset: 0x0037A83D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601875F RID: 100191 RVA: 0x0037C64C File Offset: 0x0037A84C
		public INewHandInItemsProjectionMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076B5 RID: 30389
		// (get) Token: 0x06018760 RID: 100192 RVA: 0x0037C65C File Offset: 0x0037A85C
		public ENewHandInItemsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewHandInItemsType.ProjectionMachine;
				}
				return (ENewHandInItemsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076B6 RID: 30390
		// (get) Token: 0x06018761 RID: 100193 RVA: 0x0037C698 File Offset: 0x0037A898
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076B7 RID: 30391
		// (get) Token: 0x06018762 RID: 100194 RVA: 0x0037C6D4 File Offset: 0x0037A8D4
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018763 RID: 100195 RVA: 0x0037C710 File Offset: 0x0037A910
		public static Offset<INewHandInItemsProjectionMachine> CreateINewHandInItemsProjectionMachine(FlatBufferBuilder builder, ENewHandInItemsType Type = ENewHandInItemsType.ProjectionMachine, int EntityId = 0, int ItemId = 0)
		{
			builder.StartTable(3);
			INewHandInItemsProjectionMachine.AddItemId(builder, ItemId);
			INewHandInItemsProjectionMachine.AddEntityId(builder, EntityId);
			INewHandInItemsProjectionMachine.AddType(builder, Type);
			return INewHandInItemsProjectionMachine.EndINewHandInItemsProjectionMachine(builder);
		}

		// Token: 0x06018764 RID: 100196 RVA: 0x0037C734 File Offset: 0x0037A934
		public static void StartINewHandInItemsProjectionMachine(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018765 RID: 100197 RVA: 0x0037C73D File Offset: 0x0037A93D
		public static void AddType(FlatBufferBuilder builder, ENewHandInItemsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018766 RID: 100198 RVA: 0x0037C748 File Offset: 0x0037A948
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06018767 RID: 100199 RVA: 0x0037C753 File Offset: 0x0037A953
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(2, itemId, 0);
		}

		// Token: 0x06018768 RID: 100200 RVA: 0x0037C75E File Offset: 0x0037A95E
		public static Offset<INewHandInItemsProjectionMachine> EndINewHandInItemsProjectionMachine(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsProjectionMachine>(builder.EndTable());
		}

		// Token: 0x06018769 RID: 100201 RVA: 0x0037C76C File Offset: 0x0037A96C
		public INewHandInItemsProjectionMachineT UnPack()
		{
			INewHandInItemsProjectionMachineT newHandInItemsProjectionMachineT = new INewHandInItemsProjectionMachineT();
			this.UnPackTo(newHandInItemsProjectionMachineT);
			return newHandInItemsProjectionMachineT;
		}

		// Token: 0x0601876A RID: 100202 RVA: 0x0037C787 File Offset: 0x0037A987
		public void UnPackTo(INewHandInItemsProjectionMachineT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x0601876B RID: 100203 RVA: 0x0037C7B0 File Offset: 0x0037A9B0
		public static Offset<INewHandInItemsProjectionMachine> Pack(FlatBufferBuilder builder, INewHandInItemsProjectionMachineT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewHandInItemsProjectionMachine>);
			}
			return INewHandInItemsProjectionMachine.CreateINewHandInItemsProjectionMachine(builder, _o.Type, _o.EntityId, _o.ItemId);
		}

		// Token: 0x0400C34B RID: 49995
		private Table __p;
	}
}
