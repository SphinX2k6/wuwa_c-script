using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5B RID: 27995
	public struct IEntityHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700CD52 RID: 52562
		// (get) Token: 0x0603049E RID: 197790 RVA: 0x00690018 File Offset: 0x0068E218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603049F RID: 197791 RVA: 0x00690025 File Offset: 0x0068E225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304A0 RID: 197792 RVA: 0x0069002C File Offset: 0x0068E22C
		public static IEntityHandInHandInitiator GetRootAsIEntityHandInHandInitiator(ByteBuffer _bb)
		{
			return IEntityHandInHandInitiator.GetRootAsIEntityHandInHandInitiator(_bb, default(IEntityHandInHandInitiator));
		}

		// Token: 0x060304A1 RID: 197793 RVA: 0x00690048 File Offset: 0x0068E248
		public static IEntityHandInHandInitiator GetRootAsIEntityHandInHandInitiator(ByteBuffer _bb, IEntityHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304A2 RID: 197794 RVA: 0x00690065 File Offset: 0x0068E265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304A3 RID: 197795 RVA: 0x00690074 File Offset: 0x0068E274
		public IEntityHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD53 RID: 52563
		// (get) Token: 0x060304A4 RID: 197796 RVA: 0x00690084 File Offset: 0x0068E284
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

		// Token: 0x1700CD54 RID: 52564
		// (get) Token: 0x060304A5 RID: 197797 RVA: 0x006900C0 File Offset: 0x0068E2C0
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

		// Token: 0x060304A6 RID: 197798 RVA: 0x006900FC File Offset: 0x0068E2FC
		public static Offset<IEntityHandInHandInitiator> CreateIEntityHandInHandInitiator(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			IEntityHandInHandInitiator.AddEntityId(builder, EntityId);
			IEntityHandInHandInitiator.AddType(builder, Type);
			return IEntityHandInHandInitiator.EndIEntityHandInHandInitiator(builder);
		}

		// Token: 0x060304A7 RID: 197799 RVA: 0x00690119 File Offset: 0x0068E319
		public static void StartIEntityHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060304A8 RID: 197800 RVA: 0x00690122 File Offset: 0x0068E322
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060304A9 RID: 197801 RVA: 0x0069012D File Offset: 0x0068E32D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060304AA RID: 197802 RVA: 0x00690138 File Offset: 0x0068E338
		public static Offset<IEntityHandInHandInitiator> EndIEntityHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IEntityHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x060304AB RID: 197803 RVA: 0x00690148 File Offset: 0x0068E348
		public IEntityHandInHandInitiatorT UnPack()
		{
			IEntityHandInHandInitiatorT entityHandInHandInitiatorT = new IEntityHandInHandInitiatorT();
			this.UnPackTo(entityHandInHandInitiatorT);
			return entityHandInHandInitiatorT;
		}

		// Token: 0x060304AC RID: 197804 RVA: 0x00690163 File Offset: 0x0068E363
		public void UnPackTo(IEntityHandInHandInitiatorT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060304AD RID: 197805 RVA: 0x00690180 File Offset: 0x0068E380
		public static Offset<IEntityHandInHandInitiator> Pack(FlatBufferBuilder builder, IEntityHandInHandInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityHandInHandInitiator>);
			}
			return IEntityHandInHandInitiator.CreateIEntityHandInHandInitiator(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011BD4 RID: 72660
		private Table __p;
	}
}
