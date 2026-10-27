using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3A RID: 20282
	public struct IBulletCreateCondition : IFlatbufferObject
	{
		// Token: 0x1700922F RID: 37423
		// (get) Token: 0x060201B9 RID: 131513 RVA: 0x004779DA File Offset: 0x00475BDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060201BA RID: 131514 RVA: 0x004779E7 File Offset: 0x00475BE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060201BB RID: 131515 RVA: 0x004779F0 File Offset: 0x00475BF0
		public static IBulletCreateCondition GetRootAsIBulletCreateCondition(ByteBuffer _bb)
		{
			return IBulletCreateCondition.GetRootAsIBulletCreateCondition(_bb, default(IBulletCreateCondition));
		}

		// Token: 0x060201BC RID: 131516 RVA: 0x00477A0C File Offset: 0x00475C0C
		public static IBulletCreateCondition GetRootAsIBulletCreateCondition(ByteBuffer _bb, IBulletCreateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060201BD RID: 131517 RVA: 0x00477A29 File Offset: 0x00475C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060201BE RID: 131518 RVA: 0x00477A38 File Offset: 0x00475C38
		public IBulletCreateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009230 RID: 37424
		// (get) Token: 0x060201BF RID: 131519 RVA: 0x00477A48 File Offset: 0x00475C48
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

		// Token: 0x17009231 RID: 37425
		// (get) Token: 0x060201C0 RID: 131520 RVA: 0x00477A84 File Offset: 0x00475C84
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

		// Token: 0x060201C1 RID: 131521 RVA: 0x00477AC1 File Offset: 0x00475CC1
		public static Offset<IBulletCreateCondition> CreateIBulletCreateCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IBulletCreateCondition.AddBulletId(builder, BulletId);
			IBulletCreateCondition.AddType(builder, Type);
			return IBulletCreateCondition.EndIBulletCreateCondition(builder);
		}

		// Token: 0x060201C2 RID: 131522 RVA: 0x00477ADE File Offset: 0x00475CDE
		public static void StartIBulletCreateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060201C3 RID: 131523 RVA: 0x00477AE7 File Offset: 0x00475CE7
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060201C4 RID: 131524 RVA: 0x00477AF2 File Offset: 0x00475CF2
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060201C5 RID: 131525 RVA: 0x00477AFE File Offset: 0x00475CFE
		public static Offset<IBulletCreateCondition> EndIBulletCreateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBulletCreateCondition>(builder.EndTable());
		}

		// Token: 0x060201C6 RID: 131526 RVA: 0x00477B0C File Offset: 0x00475D0C
		public IBulletCreateConditionT UnPack()
		{
			IBulletCreateConditionT bulletCreateConditionT = new IBulletCreateConditionT();
			this.UnPackTo(bulletCreateConditionT);
			return bulletCreateConditionT;
		}

		// Token: 0x060201C7 RID: 131527 RVA: 0x00477B27 File Offset: 0x00475D27
		public void UnPackTo(IBulletCreateConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x060201C8 RID: 131528 RVA: 0x00477B44 File Offset: 0x00475D44
		public static Offset<IBulletCreateCondition> Pack(FlatBufferBuilder builder, IBulletCreateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletCreateCondition>);
			}
			return IBulletCreateCondition.CreateIBulletCreateCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400DDA0 RID: 56736
		private Table __p;
	}
}
