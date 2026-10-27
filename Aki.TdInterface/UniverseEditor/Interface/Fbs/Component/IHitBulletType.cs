using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536E RID: 21358
	public struct IHitBulletType : IFlatbufferObject
	{
		// Token: 0x17009CF3 RID: 40179
		// (get) Token: 0x06022F40 RID: 143168 RVA: 0x004D72C3 File Offset: 0x004D54C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F41 RID: 143169 RVA: 0x004D72D0 File Offset: 0x004D54D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F42 RID: 143170 RVA: 0x004D72D8 File Offset: 0x004D54D8
		public static IHitBulletType GetRootAsIHitBulletType(ByteBuffer _bb)
		{
			return IHitBulletType.GetRootAsIHitBulletType(_bb, default(IHitBulletType));
		}

		// Token: 0x06022F43 RID: 143171 RVA: 0x004D72F4 File Offset: 0x004D54F4
		public static IHitBulletType GetRootAsIHitBulletType(ByteBuffer _bb, IHitBulletType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F44 RID: 143172 RVA: 0x004D7311 File Offset: 0x004D5511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F45 RID: 143173 RVA: 0x004D7320 File Offset: 0x004D5520
		public IHitBulletType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CF4 RID: 40180
		// (get) Token: 0x06022F46 RID: 143174 RVA: 0x004D7330 File Offset: 0x004D5530
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

		// Token: 0x06022F47 RID: 143175 RVA: 0x004D736C File Offset: 0x004D556C
		public static Offset<IHitBulletType> CreateIHitBulletType(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletType.AddType(builder, Type);
			return IHitBulletType.EndIHitBulletType(builder);
		}

		// Token: 0x06022F48 RID: 143176 RVA: 0x004D7382 File Offset: 0x004D5582
		public static void StartIHitBulletType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022F49 RID: 143177 RVA: 0x004D738B File Offset: 0x004D558B
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F4A RID: 143178 RVA: 0x004D7396 File Offset: 0x004D5596
		public static Offset<IHitBulletType> EndIHitBulletType(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletType>(builder.EndTable());
		}

		// Token: 0x06022F4B RID: 143179 RVA: 0x004D73A4 File Offset: 0x004D55A4
		public IHitBulletTypeT UnPack()
		{
			IHitBulletTypeT hitBulletTypeT = new IHitBulletTypeT();
			this.UnPackTo(hitBulletTypeT);
			return hitBulletTypeT;
		}

		// Token: 0x06022F4C RID: 143180 RVA: 0x004D73BF File Offset: 0x004D55BF
		public void UnPackTo(IHitBulletTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x004D73D0 File Offset: 0x004D55D0
		public static Offset<IHitBulletType> Pack(FlatBufferBuilder builder, IHitBulletTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletType>);
			}
			return IHitBulletType.CreateIHitBulletType(builder, _o.Type);
		}

		// Token: 0x0400E54C RID: 58700
		private Table __p;
	}
}
