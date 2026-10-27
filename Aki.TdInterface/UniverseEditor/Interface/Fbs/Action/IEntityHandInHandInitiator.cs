using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DB RID: 26331
	public struct IEntityHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700C39C RID: 50076
		// (get) Token: 0x0602DC61 RID: 187489 RVA: 0x00642AA4 File Offset: 0x00640CA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC62 RID: 187490 RVA: 0x00642AB1 File Offset: 0x00640CB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC63 RID: 187491 RVA: 0x00642AB8 File Offset: 0x00640CB8
		public static IEntityHandInHandInitiator GetRootAsIEntityHandInHandInitiator(ByteBuffer _bb)
		{
			return IEntityHandInHandInitiator.GetRootAsIEntityHandInHandInitiator(_bb, default(IEntityHandInHandInitiator));
		}

		// Token: 0x0602DC64 RID: 187492 RVA: 0x00642AD4 File Offset: 0x00640CD4
		public static IEntityHandInHandInitiator GetRootAsIEntityHandInHandInitiator(ByteBuffer _bb, IEntityHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC65 RID: 187493 RVA: 0x00642AF1 File Offset: 0x00640CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC66 RID: 187494 RVA: 0x00642B00 File Offset: 0x00640D00
		public IEntityHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C39D RID: 50077
		// (get) Token: 0x0602DC67 RID: 187495 RVA: 0x00642B10 File Offset: 0x00640D10
		public EHandInHandInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInHandInitiatorType.Player;
				}
				return (EHandInHandInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C39E RID: 50078
		// (get) Token: 0x0602DC68 RID: 187496 RVA: 0x00642B4C File Offset: 0x00640D4C
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

		// Token: 0x0602DC69 RID: 187497 RVA: 0x00642B88 File Offset: 0x00640D88
		public static Offset<IEntityHandInHandInitiator> CreateIEntityHandInHandInitiator(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			IEntityHandInHandInitiator.AddEntityId(builder, EntityId);
			IEntityHandInHandInitiator.AddType(builder, Type);
			return IEntityHandInHandInitiator.EndIEntityHandInHandInitiator(builder);
		}

		// Token: 0x0602DC6A RID: 187498 RVA: 0x00642BA5 File Offset: 0x00640DA5
		public static void StartIEntityHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC6B RID: 187499 RVA: 0x00642BAE File Offset: 0x00640DAE
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC6C RID: 187500 RVA: 0x00642BB9 File Offset: 0x00640DB9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602DC6D RID: 187501 RVA: 0x00642BC4 File Offset: 0x00640DC4
		public static Offset<IEntityHandInHandInitiator> EndIEntityHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IEntityHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x0602DC6E RID: 187502 RVA: 0x00642BD4 File Offset: 0x00640DD4
		public IEntityHandInHandInitiatorT UnPack()
		{
			IEntityHandInHandInitiatorT entityHandInHandInitiatorT = new IEntityHandInHandInitiatorT();
			this.UnPackTo(entityHandInHandInitiatorT);
			return entityHandInHandInitiatorT;
		}

		// Token: 0x0602DC6F RID: 187503 RVA: 0x00642BEF File Offset: 0x00640DEF
		public void UnPackTo(IEntityHandInHandInitiatorT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602DC70 RID: 187504 RVA: 0x00642C0C File Offset: 0x00640E0C
		public static Offset<IEntityHandInHandInitiator> Pack(FlatBufferBuilder builder, IEntityHandInHandInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityHandInHandInitiator>);
			}
			return IEntityHandInHandInitiator.CreateIEntityHandInHandInitiator(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04010DA5 RID: 69029
		private Table __p;
	}
}
