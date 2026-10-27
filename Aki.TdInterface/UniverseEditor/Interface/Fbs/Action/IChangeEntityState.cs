using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062EA RID: 25322
	public struct IChangeEntityState : IFlatbufferObject
	{
		// Token: 0x1700BCF4 RID: 48372
		// (get) Token: 0x0602BC3D RID: 179261 RVA: 0x00605444 File Offset: 0x00603644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC3E RID: 179262 RVA: 0x00605451 File Offset: 0x00603651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC3F RID: 179263 RVA: 0x00605458 File Offset: 0x00603658
		public static IChangeEntityState GetRootAsIChangeEntityState(ByteBuffer _bb)
		{
			return IChangeEntityState.GetRootAsIChangeEntityState(_bb, default(IChangeEntityState));
		}

		// Token: 0x0602BC40 RID: 179264 RVA: 0x00605474 File Offset: 0x00603674
		public static IChangeEntityState GetRootAsIChangeEntityState(ByteBuffer _bb, IChangeEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC41 RID: 179265 RVA: 0x00605491 File Offset: 0x00603691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC42 RID: 179266 RVA: 0x006054A0 File Offset: 0x006036A0
		public IChangeEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCF5 RID: 48373
		// (get) Token: 0x0602BC43 RID: 179267 RVA: 0x006054B0 File Offset: 0x006036B0
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

		// Token: 0x1700BCF6 RID: 48374
		// (get) Token: 0x0602BC44 RID: 179268 RVA: 0x006054EC File Offset: 0x006036EC
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

		// Token: 0x0602BC45 RID: 179269 RVA: 0x00605528 File Offset: 0x00603728
		public static Offset<IChangeEntityState> CreateIChangeEntityState(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0)
		{
			builder.StartTable(2);
			IChangeEntityState.AddEntityId(builder, EntityId);
			IChangeEntityState.AddType(builder, Type);
			return IChangeEntityState.EndIChangeEntityState(builder);
		}

		// Token: 0x0602BC46 RID: 179270 RVA: 0x00605545 File Offset: 0x00603745
		public static void StartIChangeEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BC47 RID: 179271 RVA: 0x0060554E File Offset: 0x0060374E
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BC48 RID: 179272 RVA: 0x00605559 File Offset: 0x00603759
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BC49 RID: 179273 RVA: 0x00605564 File Offset: 0x00603764
		public static Offset<IChangeEntityState> EndIChangeEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityState>(builder.EndTable());
		}

		// Token: 0x0602BC4A RID: 179274 RVA: 0x00605574 File Offset: 0x00603774
		public IChangeEntityStateT UnPack()
		{
			IChangeEntityStateT changeEntityStateT = new IChangeEntityStateT();
			this.UnPackTo(changeEntityStateT);
			return changeEntityStateT;
		}

		// Token: 0x0602BC4B RID: 179275 RVA: 0x0060558F File Offset: 0x0060378F
		public void UnPackTo(IChangeEntityStateT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602BC4C RID: 179276 RVA: 0x006055AC File Offset: 0x006037AC
		public static Offset<IChangeEntityState> Pack(FlatBufferBuilder builder, IChangeEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityState>);
			}
			return IChangeEntityState.CreateIChangeEntityState(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04010897 RID: 67735
		private Table __p;
	}
}
