using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695B RID: 26971
	public struct IChangeEntityState : IFlatbufferObject
	{
		// Token: 0x1700C67E RID: 50814
		// (get) Token: 0x0602E3A6 RID: 189350 RVA: 0x00650450 File Offset: 0x0064E650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3A7 RID: 189351 RVA: 0x0065045D File Offset: 0x0064E65D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3A8 RID: 189352 RVA: 0x00650464 File Offset: 0x0064E664
		public static IChangeEntityState GetRootAsIChangeEntityState(ByteBuffer _bb)
		{
			return IChangeEntityState.GetRootAsIChangeEntityState(_bb, default(IChangeEntityState));
		}

		// Token: 0x0602E3A9 RID: 189353 RVA: 0x00650480 File Offset: 0x0064E680
		public static IChangeEntityState GetRootAsIChangeEntityState(ByteBuffer _bb, IChangeEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3AA RID: 189354 RVA: 0x0065049D File Offset: 0x0064E69D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3AB RID: 189355 RVA: 0x006504AC File Offset: 0x0064E6AC
		public IChangeEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C67F RID: 50815
		// (get) Token: 0x0602E3AC RID: 189356 RVA: 0x006504BC File Offset: 0x0064E6BC
		public EChangeEntityState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityState.Directly;
				}
				return (EChangeEntityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C680 RID: 50816
		// (get) Token: 0x0602E3AD RID: 189357 RVA: 0x006504F8 File Offset: 0x0064E6F8
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

		// Token: 0x0602E3AE RID: 189358 RVA: 0x00650534 File Offset: 0x0064E734
		public static Offset<IChangeEntityState> CreateIChangeEntityState(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0)
		{
			builder.StartTable(2);
			IChangeEntityState.AddEntityId(builder, EntityId);
			IChangeEntityState.AddType(builder, Type);
			return IChangeEntityState.EndIChangeEntityState(builder);
		}

		// Token: 0x0602E3AF RID: 189359 RVA: 0x00650551 File Offset: 0x0064E751
		public static void StartIChangeEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E3B0 RID: 189360 RVA: 0x0065055A File Offset: 0x0064E75A
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3B1 RID: 189361 RVA: 0x00650565 File Offset: 0x0064E765
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E3B2 RID: 189362 RVA: 0x00650570 File Offset: 0x0064E770
		public static Offset<IChangeEntityState> EndIChangeEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityState>(builder.EndTable());
		}

		// Token: 0x0602E3B3 RID: 189363 RVA: 0x00650580 File Offset: 0x0064E780
		public IChangeEntityStateT UnPack()
		{
			IChangeEntityStateT changeEntityStateT = new IChangeEntityStateT();
			this.UnPackTo(changeEntityStateT);
			return changeEntityStateT;
		}

		// Token: 0x0602E3B4 RID: 189364 RVA: 0x0065059B File Offset: 0x0064E79B
		public void UnPackTo(IChangeEntityStateT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602E3B5 RID: 189365 RVA: 0x006505B8 File Offset: 0x0064E7B8
		public static Offset<IChangeEntityState> Pack(FlatBufferBuilder builder, IChangeEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityState>);
			}
			return IChangeEntityState.CreateIChangeEntityState(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040116AD RID: 71341
		private Table __p;
	}
}
