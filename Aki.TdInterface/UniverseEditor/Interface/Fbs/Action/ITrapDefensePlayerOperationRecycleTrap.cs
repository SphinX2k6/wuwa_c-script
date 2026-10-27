using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007460 RID: 29792
	public struct ITrapDefensePlayerOperationRecycleTrap : IFlatbufferObject
	{
		// Token: 0x1700E228 RID: 57896
		// (get) Token: 0x06036204 RID: 221700 RVA: 0x0075C269 File Offset: 0x0075A469
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036205 RID: 221701 RVA: 0x0075C276 File Offset: 0x0075A476
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036206 RID: 221702 RVA: 0x0075C280 File Offset: 0x0075A480
		public static ITrapDefensePlayerOperationRecycleTrap GetRootAsITrapDefensePlayerOperationRecycleTrap(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationRecycleTrap.GetRootAsITrapDefensePlayerOperationRecycleTrap(_bb, default(ITrapDefensePlayerOperationRecycleTrap));
		}

		// Token: 0x06036207 RID: 221703 RVA: 0x0075C29C File Offset: 0x0075A49C
		public static ITrapDefensePlayerOperationRecycleTrap GetRootAsITrapDefensePlayerOperationRecycleTrap(ByteBuffer _bb, ITrapDefensePlayerOperationRecycleTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036208 RID: 221704 RVA: 0x0075C2B9 File Offset: 0x0075A4B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036209 RID: 221705 RVA: 0x0075C2C8 File Offset: 0x0075A4C8
		public ITrapDefensePlayerOperationRecycleTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E229 RID: 57897
		// (get) Token: 0x0603620A RID: 221706 RVA: 0x0075C2D8 File Offset: 0x0075A4D8
		public ETrapDefensePlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return (ETrapDefensePlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603620B RID: 221707 RVA: 0x0075C314 File Offset: 0x0075A514
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> CreateITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationRecycleTrap.AddType(builder, Type);
			return ITrapDefensePlayerOperationRecycleTrap.EndITrapDefensePlayerOperationRecycleTrap(builder);
		}

		// Token: 0x0603620C RID: 221708 RVA: 0x0075C32A File Offset: 0x0075A52A
		public static void StartITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603620D RID: 221709 RVA: 0x0075C333 File Offset: 0x0075A533
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603620E RID: 221710 RVA: 0x0075C33E File Offset: 0x0075A53E
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> EndITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationRecycleTrap>(builder.EndTable());
		}

		// Token: 0x0603620F RID: 221711 RVA: 0x0075C34C File Offset: 0x0075A54C
		public ITrapDefensePlayerOperationRecycleTrapT UnPack()
		{
			ITrapDefensePlayerOperationRecycleTrapT trapDefensePlayerOperationRecycleTrapT = new ITrapDefensePlayerOperationRecycleTrapT();
			this.UnPackTo(trapDefensePlayerOperationRecycleTrapT);
			return trapDefensePlayerOperationRecycleTrapT;
		}

		// Token: 0x06036210 RID: 221712 RVA: 0x0075C367 File Offset: 0x0075A567
		public void UnPackTo(ITrapDefensePlayerOperationRecycleTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036211 RID: 221713 RVA: 0x0075C378 File Offset: 0x0075A578
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationRecycleTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationRecycleTrap>);
			}
			return ITrapDefensePlayerOperationRecycleTrap.CreateITrapDefensePlayerOperationRecycleTrap(builder, _o.Type);
		}

		// Token: 0x040122E9 RID: 74473
		private Table __p;
	}
}
