using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2E RID: 23342
	public struct IMonsterNpcInteractionSwordRiding : IFlatbufferObject
	{
		// Token: 0x1700AA5D RID: 43613
		// (get) Token: 0x0602663C RID: 157244 RVA: 0x005422E5 File Offset: 0x005404E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x005422F2 File Offset: 0x005404F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x005422FC File Offset: 0x005404FC
		public static IMonsterNpcInteractionSwordRiding GetRootAsIMonsterNpcInteractionSwordRiding(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionSwordRiding.GetRootAsIMonsterNpcInteractionSwordRiding(_bb, default(IMonsterNpcInteractionSwordRiding));
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x00542318 File Offset: 0x00540518
		public static IMonsterNpcInteractionSwordRiding GetRootAsIMonsterNpcInteractionSwordRiding(ByteBuffer _bb, IMonsterNpcInteractionSwordRiding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x00542335 File Offset: 0x00540535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026641 RID: 157249 RVA: 0x00542344 File Offset: 0x00540544
		public IMonsterNpcInteractionSwordRiding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA5E RID: 43614
		// (get) Token: 0x06026642 RID: 157250 RVA: 0x00542354 File Offset: 0x00540554
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026643 RID: 157251 RVA: 0x00542390 File Offset: 0x00540590
		public static Offset<IMonsterNpcInteractionSwordRiding> CreateIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionSwordRiding.AddType(builder, Type);
			return IMonsterNpcInteractionSwordRiding.EndIMonsterNpcInteractionSwordRiding(builder);
		}

		// Token: 0x06026644 RID: 157252 RVA: 0x005423A6 File Offset: 0x005405A6
		public static void StartIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026645 RID: 157253 RVA: 0x005423AF File Offset: 0x005405AF
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026646 RID: 157254 RVA: 0x005423BA File Offset: 0x005405BA
		public static Offset<IMonsterNpcInteractionSwordRiding> EndIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionSwordRiding>(builder.EndTable());
		}

		// Token: 0x06026647 RID: 157255 RVA: 0x005423C8 File Offset: 0x005405C8
		public IMonsterNpcInteractionSwordRidingT UnPack()
		{
			IMonsterNpcInteractionSwordRidingT monsterNpcInteractionSwordRidingT = new IMonsterNpcInteractionSwordRidingT();
			this.UnPackTo(monsterNpcInteractionSwordRidingT);
			return monsterNpcInteractionSwordRidingT;
		}

		// Token: 0x06026648 RID: 157256 RVA: 0x005423E3 File Offset: 0x005405E3
		public void UnPackTo(IMonsterNpcInteractionSwordRidingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x005423F4 File Offset: 0x005405F4
		public static Offset<IMonsterNpcInteractionSwordRiding> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionSwordRidingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionSwordRiding>);
			}
			return IMonsterNpcInteractionSwordRiding.CreateIMonsterNpcInteractionSwordRiding(builder, _o.Type);
		}

		// Token: 0x0400F523 RID: 62755
		private Table __p;
	}
}
