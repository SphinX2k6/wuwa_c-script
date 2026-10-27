using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A4 RID: 22180
	public struct IOnOpenGravityCollisionCondition : IFlatbufferObject
	{
		// Token: 0x1700A4F1 RID: 42225
		// (get) Token: 0x06025046 RID: 151622 RVA: 0x0051C9D6 File Offset: 0x0051ABD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025047 RID: 151623 RVA: 0x0051C9E3 File Offset: 0x0051ABE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025048 RID: 151624 RVA: 0x0051C9EC File Offset: 0x0051ABEC
		public static IOnOpenGravityCollisionCondition GetRootAsIOnOpenGravityCollisionCondition(ByteBuffer _bb)
		{
			return IOnOpenGravityCollisionCondition.GetRootAsIOnOpenGravityCollisionCondition(_bb, default(IOnOpenGravityCollisionCondition));
		}

		// Token: 0x06025049 RID: 151625 RVA: 0x0051CA08 File Offset: 0x0051AC08
		public static IOnOpenGravityCollisionCondition GetRootAsIOnOpenGravityCollisionCondition(ByteBuffer _bb, IOnOpenGravityCollisionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602504A RID: 151626 RVA: 0x0051CA25 File Offset: 0x0051AC25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602504B RID: 151627 RVA: 0x0051CA34 File Offset: 0x0051AC34
		public IOnOpenGravityCollisionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4F2 RID: 42226
		// (get) Token: 0x0602504C RID: 151628 RVA: 0x0051CA44 File Offset: 0x0051AC44
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

		// Token: 0x1700A4F3 RID: 42227
		// (get) Token: 0x0602504D RID: 151629 RVA: 0x0051CA80 File Offset: 0x0051AC80
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

		// Token: 0x0602504E RID: 151630 RVA: 0x0051CABD File Offset: 0x0051ACBD
		public static Offset<IOnOpenGravityCollisionCondition> CreateIOnOpenGravityCollisionCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L)
		{
			builder.StartTable(2);
			IOnOpenGravityCollisionCondition.AddBulletId(builder, BulletId);
			IOnOpenGravityCollisionCondition.AddType(builder, Type);
			return IOnOpenGravityCollisionCondition.EndIOnOpenGravityCollisionCondition(builder);
		}

		// Token: 0x0602504F RID: 151631 RVA: 0x0051CADA File Offset: 0x0051ACDA
		public static void StartIOnOpenGravityCollisionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025050 RID: 151632 RVA: 0x0051CAE3 File Offset: 0x0051ACE3
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025051 RID: 151633 RVA: 0x0051CAEE File Offset: 0x0051ACEE
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06025052 RID: 151634 RVA: 0x0051CAFA File Offset: 0x0051ACFA
		public static Offset<IOnOpenGravityCollisionCondition> EndIOnOpenGravityCollisionCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnOpenGravityCollisionCondition>(builder.EndTable());
		}

		// Token: 0x06025053 RID: 151635 RVA: 0x0051CB08 File Offset: 0x0051AD08
		public IOnOpenGravityCollisionConditionT UnPack()
		{
			IOnOpenGravityCollisionConditionT onOpenGravityCollisionConditionT = new IOnOpenGravityCollisionConditionT();
			this.UnPackTo(onOpenGravityCollisionConditionT);
			return onOpenGravityCollisionConditionT;
		}

		// Token: 0x06025054 RID: 151636 RVA: 0x0051CB23 File Offset: 0x0051AD23
		public void UnPackTo(IOnOpenGravityCollisionConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
		}

		// Token: 0x06025055 RID: 151637 RVA: 0x0051CB40 File Offset: 0x0051AD40
		public static Offset<IOnOpenGravityCollisionCondition> Pack(FlatBufferBuilder builder, IOnOpenGravityCollisionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnOpenGravityCollisionCondition>);
			}
			return IOnOpenGravityCollisionCondition.CreateIOnOpenGravityCollisionCondition(builder, _o.Type, _o.BulletId);
		}

		// Token: 0x0400EAC8 RID: 60104
		private Table __p;
	}
}
