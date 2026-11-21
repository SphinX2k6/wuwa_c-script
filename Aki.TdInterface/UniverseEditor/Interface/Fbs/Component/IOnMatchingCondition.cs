using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C42 RID: 23618
	public struct IOnMatchingCondition : IFlatbufferObject
	{
		// Token: 0x1700AD7B RID: 44411
		// (get) Token: 0x0602726F RID: 160367 RVA: 0x0055D51F File Offset: 0x0055B71F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027270 RID: 160368 RVA: 0x0055D52C File Offset: 0x0055B72C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027271 RID: 160369 RVA: 0x0055D534 File Offset: 0x0055B734
		public static IOnMatchingCondition GetRootAsIOnMatchingCondition(ByteBuffer _bb)
		{
			return IOnMatchingCondition.GetRootAsIOnMatchingCondition(_bb, default(IOnMatchingCondition));
		}

		// Token: 0x06027272 RID: 160370 RVA: 0x0055D550 File Offset: 0x0055B750
		public static IOnMatchingCondition GetRootAsIOnMatchingCondition(ByteBuffer _bb, IOnMatchingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027273 RID: 160371 RVA: 0x0055D56D File Offset: 0x0055B76D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027274 RID: 160372 RVA: 0x0055D57C File Offset: 0x0055B77C
		public IOnMatchingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD7C RID: 44412
		// (get) Token: 0x06027275 RID: 160373 RVA: 0x0055D58C File Offset: 0x0055B78C
		public EBulletCreateCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBulletCreateCondition.OnHit;
				}
				return (EBulletCreateCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD7D RID: 44413
		// (get) Token: 0x06027276 RID: 160374 RVA: 0x0055D5C8 File Offset: 0x0055B7C8
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027277 RID: 160375 RVA: 0x0055D605 File Offset: 0x0055B805
		public static Offset<IOnMatchingCondition> CreateIOnMatchingCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnMatchingCondition.AddBulletId(builder, BulletId);
			IOnMatchingCondition.AddType(builder, Type);
			return IOnMatchingCondition.EndIOnMatchingCondition(builder);
		}

		// Token: 0x06027278 RID: 160376 RVA: 0x0055D622 File Offset: 0x0055B822
		public static void StartIOnMatchingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027279 RID: 160377 RVA: 0x0055D62B File Offset: 0x0055B82B
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602727A RID: 160378 RVA: 0x0055D636 File Offset: 0x0055B836
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602727B RID: 160379 RVA: 0x0055D642 File Offset: 0x0055B842
		public static Offset<IOnMatchingCondition> EndIOnMatchingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnMatchingCondition>(builder.EndTable());
		}

		// Token: 0x0602727C RID: 160380 RVA: 0x0055D650 File Offset: 0x0055B850
		public IOnMatchingConditionT UnPack()
		{
			IOnMatchingConditionT onMatchingConditionT = new IOnMatchingConditionT();
			this.UnPackTo(onMatchingConditionT);
			return onMatchingConditionT;
		}

		// Token: 0x0602727D RID: 160381 RVA: 0x0055D66B File Offset: 0x0055B86B
		public void UnPackTo(IOnMatchingConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x0602727E RID: 160382 RVA: 0x0055D688 File Offset: 0x0055B888
		public static Offset<IOnMatchingCondition> Pack(FlatBufferBuilder builder, IOnMatchingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnMatchingCondition>);
			}
			return IOnMatchingCondition.CreateIOnMatchingCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400F72E RID: 63278
		private Table __p;
	}
}
