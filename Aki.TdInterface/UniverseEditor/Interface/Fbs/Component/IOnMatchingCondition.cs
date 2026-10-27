using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569E RID: 22174
	public struct IOnMatchingCondition : IFlatbufferObject
	{
		// Token: 0x1700A4E7 RID: 42215
		// (get) Token: 0x0602501A RID: 151578 RVA: 0x0051C5D7 File Offset: 0x0051A7D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602501B RID: 151579 RVA: 0x0051C5E4 File Offset: 0x0051A7E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602501C RID: 151580 RVA: 0x0051C5EC File Offset: 0x0051A7EC
		public static IOnMatchingCondition GetRootAsIOnMatchingCondition(ByteBuffer _bb)
		{
			return IOnMatchingCondition.GetRootAsIOnMatchingCondition(_bb, default(IOnMatchingCondition));
		}

		// Token: 0x0602501D RID: 151581 RVA: 0x0051C608 File Offset: 0x0051A808
		public static IOnMatchingCondition GetRootAsIOnMatchingCondition(ByteBuffer _bb, IOnMatchingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602501E RID: 151582 RVA: 0x0051C625 File Offset: 0x0051A825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602501F RID: 151583 RVA: 0x0051C634 File Offset: 0x0051A834
		public IOnMatchingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4E8 RID: 42216
		// (get) Token: 0x06025020 RID: 151584 RVA: 0x0051C644 File Offset: 0x0051A844
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

		// Token: 0x1700A4E9 RID: 42217
		// (get) Token: 0x06025021 RID: 151585 RVA: 0x0051C680 File Offset: 0x0051A880
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

		// Token: 0x06025022 RID: 151586 RVA: 0x0051C6BD File Offset: 0x0051A8BD
		public static Offset<IOnMatchingCondition> CreateIOnMatchingCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnMatchingCondition.AddBulletId(builder, BulletId);
			IOnMatchingCondition.AddType(builder, Type);
			return IOnMatchingCondition.EndIOnMatchingCondition(builder);
		}

		// Token: 0x06025023 RID: 151587 RVA: 0x0051C6DA File Offset: 0x0051A8DA
		public static void StartIOnMatchingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025024 RID: 151588 RVA: 0x0051C6E3 File Offset: 0x0051A8E3
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025025 RID: 151589 RVA: 0x0051C6EE File Offset: 0x0051A8EE
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06025026 RID: 151590 RVA: 0x0051C6FA File Offset: 0x0051A8FA
		public static Offset<IOnMatchingCondition> EndIOnMatchingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnMatchingCondition>(builder.EndTable());
		}

		// Token: 0x06025027 RID: 151591 RVA: 0x0051C708 File Offset: 0x0051A908
		public IOnMatchingConditionT UnPack()
		{
			IOnMatchingConditionT onMatchingConditionT = new IOnMatchingConditionT();
			this.UnPackTo(onMatchingConditionT);
			return onMatchingConditionT;
		}

		// Token: 0x06025028 RID: 151592 RVA: 0x0051C723 File Offset: 0x0051A923
		public void UnPackTo(IOnMatchingConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x06025029 RID: 151593 RVA: 0x0051C740 File Offset: 0x0051A940
		public static Offset<IOnMatchingCondition> Pack(FlatBufferBuilder builder, IOnMatchingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnMatchingCondition>);
			}
			return IOnMatchingCondition.CreateIOnMatchingCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400EAC2 RID: 60098
		private Table __p;
	}
}
