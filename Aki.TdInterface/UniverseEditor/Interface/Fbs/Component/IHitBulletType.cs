using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F4 RID: 22772
	public struct IHitBulletType : IFlatbufferObject
	{
		// Token: 0x1700A52B RID: 42283
		// (get) Token: 0x06024FF4 RID: 151540 RVA: 0x00514197 File Offset: 0x00512397
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FF5 RID: 151541 RVA: 0x005141A4 File Offset: 0x005123A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FF6 RID: 151542 RVA: 0x005141AC File Offset: 0x005123AC
		public static IHitBulletType GetRootAsIHitBulletType(ByteBuffer _bb)
		{
			return IHitBulletType.GetRootAsIHitBulletType(_bb, default(IHitBulletType));
		}

		// Token: 0x06024FF7 RID: 151543 RVA: 0x005141C8 File Offset: 0x005123C8
		public static IHitBulletType GetRootAsIHitBulletType(ByteBuffer _bb, IHitBulletType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FF8 RID: 151544 RVA: 0x005141E5 File Offset: 0x005123E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FF9 RID: 151545 RVA: 0x005141F4 File Offset: 0x005123F4
		public IHitBulletType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A52C RID: 42284
		// (get) Token: 0x06024FFA RID: 151546 RVA: 0x00514204 File Offset: 0x00512404
		public EHitBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return (EHitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FFB RID: 151547 RVA: 0x00514240 File Offset: 0x00512440
		public static Offset<IHitBulletType> CreateIHitBulletType(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletType.AddType(builder, Type);
			return IHitBulletType.EndIHitBulletType(builder);
		}

		// Token: 0x06024FFC RID: 151548 RVA: 0x00514256 File Offset: 0x00512456
		public static void StartIHitBulletType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024FFD RID: 151549 RVA: 0x0051425F File Offset: 0x0051245F
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024FFE RID: 151550 RVA: 0x0051426A File Offset: 0x0051246A
		public static Offset<IHitBulletType> EndIHitBulletType(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletType>(builder.EndTable());
		}

		// Token: 0x06024FFF RID: 151551 RVA: 0x00514278 File Offset: 0x00512478
		public IHitBulletTypeT UnPack()
		{
			IHitBulletTypeT hitBulletTypeT = new IHitBulletTypeT();
			this.UnPackTo(hitBulletTypeT);
			return hitBulletTypeT;
		}

		// Token: 0x06025000 RID: 151552 RVA: 0x00514293 File Offset: 0x00512493
		public void UnPackTo(IHitBulletTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025001 RID: 151553 RVA: 0x005142A4 File Offset: 0x005124A4
		public static Offset<IHitBulletType> Pack(FlatBufferBuilder builder, IHitBulletTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletType>);
			}
			return IHitBulletType.CreateIHitBulletType(builder, _o.Type);
		}

		// Token: 0x0400F17C RID: 61820
		private Table __p;
	}
}
