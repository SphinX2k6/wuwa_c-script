using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546C RID: 21612
	public struct IBulletCreateCondition : IFlatbufferObject
	{
		// Token: 0x170099B1 RID: 39345
		// (get) Token: 0x06021F29 RID: 139049 RVA: 0x004ADD6E File Offset: 0x004ABF6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F2A RID: 139050 RVA: 0x004ADD7B File Offset: 0x004ABF7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F2B RID: 139051 RVA: 0x004ADD84 File Offset: 0x004ABF84
		public static IBulletCreateCondition GetRootAsIBulletCreateCondition(ByteBuffer _bb)
		{
			return IBulletCreateCondition.GetRootAsIBulletCreateCondition(_bb, default(IBulletCreateCondition));
		}

		// Token: 0x06021F2C RID: 139052 RVA: 0x004ADDA0 File Offset: 0x004ABFA0
		public static IBulletCreateCondition GetRootAsIBulletCreateCondition(ByteBuffer _bb, IBulletCreateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F2D RID: 139053 RVA: 0x004ADDBD File Offset: 0x004ABFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F2E RID: 139054 RVA: 0x004ADDCC File Offset: 0x004ABFCC
		public IBulletCreateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099B2 RID: 39346
		// (get) Token: 0x06021F2F RID: 139055 RVA: 0x004ADDDC File Offset: 0x004ABFDC
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

		// Token: 0x170099B3 RID: 39347
		// (get) Token: 0x06021F30 RID: 139056 RVA: 0x004ADE18 File Offset: 0x004AC018
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

		// Token: 0x06021F31 RID: 139057 RVA: 0x004ADE55 File Offset: 0x004AC055
		public static Offset<IBulletCreateCondition> CreateIBulletCreateCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IBulletCreateCondition.AddBulletId(builder, BulletId);
			IBulletCreateCondition.AddType(builder, Type);
			return IBulletCreateCondition.EndIBulletCreateCondition(builder);
		}

		// Token: 0x06021F32 RID: 139058 RVA: 0x004ADE72 File Offset: 0x004AC072
		public static void StartIBulletCreateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021F33 RID: 139059 RVA: 0x004ADE7B File Offset: 0x004AC07B
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021F34 RID: 139060 RVA: 0x004ADE86 File Offset: 0x004AC086
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06021F35 RID: 139061 RVA: 0x004ADE92 File Offset: 0x004AC092
		public static Offset<IBulletCreateCondition> EndIBulletCreateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBulletCreateCondition>(builder.EndTable());
		}

		// Token: 0x06021F36 RID: 139062 RVA: 0x004ADEA0 File Offset: 0x004AC0A0
		public IBulletCreateConditionT UnPack()
		{
			IBulletCreateConditionT bulletCreateConditionT = new IBulletCreateConditionT();
			this.UnPackTo(bulletCreateConditionT);
			return bulletCreateConditionT;
		}

		// Token: 0x06021F37 RID: 139063 RVA: 0x004ADEBB File Offset: 0x004AC0BB
		public void UnPackTo(IBulletCreateConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x06021F38 RID: 139064 RVA: 0x004ADED8 File Offset: 0x004AC0D8
		public static Offset<IBulletCreateCondition> Pack(FlatBufferBuilder builder, IBulletCreateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletCreateCondition>);
			}
			return IBulletCreateCondition.CreateIBulletCreateCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400E94F RID: 59727
		private Table __p;
	}
}
