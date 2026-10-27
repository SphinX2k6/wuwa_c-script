using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF3 RID: 27891
	public struct IPlayerHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700CFBB RID: 53179
		// (get) Token: 0x060312E7 RID: 201447 RVA: 0x006AC2F4 File Offset: 0x006AA4F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312E8 RID: 201448 RVA: 0x006AC301 File Offset: 0x006AA501
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312E9 RID: 201449 RVA: 0x006AC308 File Offset: 0x006AA508
		public static IPlayerHandInHandInitiator GetRootAsIPlayerHandInHandInitiator(ByteBuffer _bb)
		{
			return IPlayerHandInHandInitiator.GetRootAsIPlayerHandInHandInitiator(_bb, default(IPlayerHandInHandInitiator));
		}

		// Token: 0x060312EA RID: 201450 RVA: 0x006AC324 File Offset: 0x006AA524
		public static IPlayerHandInHandInitiator GetRootAsIPlayerHandInHandInitiator(ByteBuffer _bb, IPlayerHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312EB RID: 201451 RVA: 0x006AC341 File Offset: 0x006AA541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312EC RID: 201452 RVA: 0x006AC350 File Offset: 0x006AA550
		public IPlayerHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFBC RID: 53180
		// (get) Token: 0x060312ED RID: 201453 RVA: 0x006AC360 File Offset: 0x006AA560
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

		// Token: 0x060312EE RID: 201454 RVA: 0x006AC39C File Offset: 0x006AA59C
		public static Offset<IPlayerHandInHandInitiator> CreateIPlayerHandInHandInitiator(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player)
		{
			builder.StartTable(1);
			IPlayerHandInHandInitiator.AddType(builder, Type);
			return IPlayerHandInHandInitiator.EndIPlayerHandInHandInitiator(builder);
		}

		// Token: 0x060312EF RID: 201455 RVA: 0x006AC3B2 File Offset: 0x006AA5B2
		public static void StartIPlayerHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060312F0 RID: 201456 RVA: 0x006AC3BB File Offset: 0x006AA5BB
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312F1 RID: 201457 RVA: 0x006AC3C6 File Offset: 0x006AA5C6
		public static Offset<IPlayerHandInHandInitiator> EndIPlayerHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x060312F2 RID: 201458 RVA: 0x006AC3D4 File Offset: 0x006AA5D4
		public IPlayerHandInHandInitiatorT UnPack()
		{
			IPlayerHandInHandInitiatorT playerHandInHandInitiatorT = new IPlayerHandInHandInitiatorT();
			this.UnPackTo(playerHandInHandInitiatorT);
			return playerHandInHandInitiatorT;
		}

		// Token: 0x060312F3 RID: 201459 RVA: 0x006AC3EF File Offset: 0x006AA5EF
		public void UnPackTo(IPlayerHandInHandInitiatorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060312F4 RID: 201460 RVA: 0x006AC400 File Offset: 0x006AA600
		public static Offset<IPlayerHandInHandInitiator> Pack(FlatBufferBuilder builder, IPlayerHandInHandInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerHandInHandInitiator>);
			}
			return IPlayerHandInHandInitiator.CreateIPlayerHandInHandInitiator(builder, _o.Type);
		}

		// Token: 0x04011671 RID: 71281
		private Table __p;
	}
}
