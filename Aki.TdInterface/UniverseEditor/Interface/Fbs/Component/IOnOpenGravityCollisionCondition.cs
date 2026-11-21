using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C48 RID: 23624
	public struct IOnOpenGravityCollisionCondition : IFlatbufferObject
	{
		// Token: 0x1700AD85 RID: 44421
		// (get) Token: 0x0602729B RID: 160411 RVA: 0x0055D91E File Offset: 0x0055BB1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602729C RID: 160412 RVA: 0x0055D92B File Offset: 0x0055BB2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602729D RID: 160413 RVA: 0x0055D934 File Offset: 0x0055BB34
		public static IOnOpenGravityCollisionCondition GetRootAsIOnOpenGravityCollisionCondition(ByteBuffer _bb)
		{
			return IOnOpenGravityCollisionCondition.GetRootAsIOnOpenGravityCollisionCondition(_bb, default(IOnOpenGravityCollisionCondition));
		}

		// Token: 0x0602729E RID: 160414 RVA: 0x0055D950 File Offset: 0x0055BB50
		public static IOnOpenGravityCollisionCondition GetRootAsIOnOpenGravityCollisionCondition(ByteBuffer _bb, IOnOpenGravityCollisionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602729F RID: 160415 RVA: 0x0055D96D File Offset: 0x0055BB6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272A0 RID: 160416 RVA: 0x0055D97C File Offset: 0x0055BB7C
		public IOnOpenGravityCollisionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD86 RID: 44422
		// (get) Token: 0x060272A1 RID: 160417 RVA: 0x0055D98C File Offset: 0x0055BB8C
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

		// Token: 0x1700AD87 RID: 44423
		// (get) Token: 0x060272A2 RID: 160418 RVA: 0x0055D9C8 File Offset: 0x0055BBC8
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

		// Token: 0x060272A3 RID: 160419 RVA: 0x0055DA05 File Offset: 0x0055BC05
		public static Offset<IOnOpenGravityCollisionCondition> CreateIOnOpenGravityCollisionCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnOpenGravityCollisionCondition.AddBulletId(builder, BulletId);
			IOnOpenGravityCollisionCondition.AddType(builder, Type);
			return IOnOpenGravityCollisionCondition.EndIOnOpenGravityCollisionCondition(builder);
		}

		// Token: 0x060272A4 RID: 160420 RVA: 0x0055DA22 File Offset: 0x0055BC22
		public static void StartIOnOpenGravityCollisionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060272A5 RID: 160421 RVA: 0x0055DA2B File Offset: 0x0055BC2B
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060272A6 RID: 160422 RVA: 0x0055DA36 File Offset: 0x0055BC36
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060272A7 RID: 160423 RVA: 0x0055DA42 File Offset: 0x0055BC42
		public static Offset<IOnOpenGravityCollisionCondition> EndIOnOpenGravityCollisionCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnOpenGravityCollisionCondition>(builder.EndTable());
		}

		// Token: 0x060272A8 RID: 160424 RVA: 0x0055DA50 File Offset: 0x0055BC50
		public IOnOpenGravityCollisionConditionT UnPack()
		{
			IOnOpenGravityCollisionConditionT onOpenGravityCollisionConditionT = new IOnOpenGravityCollisionConditionT();
			this.UnPackTo(onOpenGravityCollisionConditionT);
			return onOpenGravityCollisionConditionT;
		}

		// Token: 0x060272A9 RID: 160425 RVA: 0x0055DA6B File Offset: 0x0055BC6B
		public void UnPackTo(IOnOpenGravityCollisionConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x060272AA RID: 160426 RVA: 0x0055DA88 File Offset: 0x0055BC88
		public static Offset<IOnOpenGravityCollisionCondition> Pack(FlatBufferBuilder builder, IOnOpenGravityCollisionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnOpenGravityCollisionCondition>);
			}
			return IOnOpenGravityCollisionCondition.CreateIOnOpenGravityCollisionCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400F734 RID: 63284
		private Table __p;
	}
}
