using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F59 RID: 16217
	public struct INewHandInItemsProjectionMachine : IFlatbufferObject
	{
		// Token: 0x170070C3 RID: 28867
		// (get) Token: 0x060170F8 RID: 94456 RVA: 0x0035317A File Offset: 0x0035137A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170F9 RID: 94457 RVA: 0x00353187 File Offset: 0x00351387
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170FA RID: 94458 RVA: 0x00353190 File Offset: 0x00351390
		public static INewHandInItemsProjectionMachine GetRootAsINewHandInItemsProjectionMachine(ByteBuffer _bb)
		{
			return INewHandInItemsProjectionMachine.GetRootAsINewHandInItemsProjectionMachine(_bb, default(INewHandInItemsProjectionMachine));
		}

		// Token: 0x060170FB RID: 94459 RVA: 0x003531AC File Offset: 0x003513AC
		public static INewHandInItemsProjectionMachine GetRootAsINewHandInItemsProjectionMachine(ByteBuffer _bb, INewHandInItemsProjectionMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170FC RID: 94460 RVA: 0x003531C9 File Offset: 0x003513C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170FD RID: 94461 RVA: 0x003531D8 File Offset: 0x003513D8
		public INewHandInItemsProjectionMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070C4 RID: 28868
		// (get) Token: 0x060170FE RID: 94462 RVA: 0x003531E8 File Offset: 0x003513E8
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

		// Token: 0x170070C5 RID: 28869
		// (get) Token: 0x060170FF RID: 94463 RVA: 0x00353224 File Offset: 0x00351424
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

		// Token: 0x170070C6 RID: 28870
		// (get) Token: 0x06017100 RID: 94464 RVA: 0x00353260 File Offset: 0x00351460
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

		// Token: 0x06017101 RID: 94465 RVA: 0x0035329C File Offset: 0x0035149C
		public static Offset<INewHandInItemsProjectionMachine> CreateINewHandInItemsProjectionMachine(FlatBufferBuilder builder, ENewHandInItemsType Type = ENewHandInItemsType.ProjectionMachine, int EntityId = 0, int ItemId = 0)
		{
			builder.StartTable(3);
			INewHandInItemsProjectionMachine.AddItemId(builder, ItemId);
			INewHandInItemsProjectionMachine.AddEntityId(builder, EntityId);
			INewHandInItemsProjectionMachine.AddType(builder, Type);
			return INewHandInItemsProjectionMachine.EndINewHandInItemsProjectionMachine(builder);
		}

		// Token: 0x06017102 RID: 94466 RVA: 0x003532C0 File Offset: 0x003514C0
		public static void StartINewHandInItemsProjectionMachine(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017103 RID: 94467 RVA: 0x003532C9 File Offset: 0x003514C9
		public static void AddType(FlatBufferBuilder builder, ENewHandInItemsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017104 RID: 94468 RVA: 0x003532D4 File Offset: 0x003514D4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06017105 RID: 94469 RVA: 0x003532DF File Offset: 0x003514DF
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(2, itemId, 0);
		}

		// Token: 0x06017106 RID: 94470 RVA: 0x003532EA File Offset: 0x003514EA
		public static Offset<INewHandInItemsProjectionMachine> EndINewHandInItemsProjectionMachine(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsProjectionMachine>(builder.EndTable());
		}

		// Token: 0x06017107 RID: 94471 RVA: 0x003532F8 File Offset: 0x003514F8
		public INewHandInItemsProjectionMachineT UnPack()
		{
			INewHandInItemsProjectionMachineT newHandInItemsProjectionMachineT = new INewHandInItemsProjectionMachineT();
			this.UnPackTo(newHandInItemsProjectionMachineT);
			return newHandInItemsProjectionMachineT;
		}

		// Token: 0x06017108 RID: 94472 RVA: 0x00353313 File Offset: 0x00351513
		public void UnPackTo(INewHandInItemsProjectionMachineT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x06017109 RID: 94473 RVA: 0x0035333C File Offset: 0x0035153C
		public static Offset<INewHandInItemsProjectionMachine> Pack(FlatBufferBuilder builder, INewHandInItemsProjectionMachineT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewHandInItemsProjectionMachine>);
			}
			return INewHandInItemsProjectionMachine.CreateINewHandInItemsProjectionMachine(builder, _o.Type, _o.EntityId, _o.ItemId);
		}

		// Token: 0x0400B96D RID: 47469
		private Table __p;
	}
}
