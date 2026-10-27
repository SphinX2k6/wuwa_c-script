using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005374 RID: 21364
	public struct IHitBulletTypeCrystalAttack : IFlatbufferObject
	{
		// Token: 0x17009CF9 RID: 40185
		// (get) Token: 0x06022F64 RID: 143204 RVA: 0x004D75B1 File Offset: 0x004D57B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F65 RID: 143205 RVA: 0x004D75BE File Offset: 0x004D57BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F66 RID: 143206 RVA: 0x004D75C8 File Offset: 0x004D57C8
		public static IHitBulletTypeCrystalAttack GetRootAsIHitBulletTypeCrystalAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeCrystalAttack.GetRootAsIHitBulletTypeCrystalAttack(_bb, default(IHitBulletTypeCrystalAttack));
		}

		// Token: 0x06022F67 RID: 143207 RVA: 0x004D75E4 File Offset: 0x004D57E4
		public static IHitBulletTypeCrystalAttack GetRootAsIHitBulletTypeCrystalAttack(ByteBuffer _bb, IHitBulletTypeCrystalAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F68 RID: 143208 RVA: 0x004D7601 File Offset: 0x004D5801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F69 RID: 143209 RVA: 0x004D7610 File Offset: 0x004D5810
		public IHitBulletTypeCrystalAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CFA RID: 40186
		// (get) Token: 0x06022F6A RID: 143210 RVA: 0x004D7620 File Offset: 0x004D5820
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

		// Token: 0x17009CFB RID: 40187
		// (get) Token: 0x06022F6B RID: 143211 RVA: 0x004D765C File Offset: 0x004D585C
		public IVectorInfo? TrackOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x004D76B9 File Offset: 0x004D58B9
		public static Offset<IHitBulletTypeCrystalAttack> CreateIHitBulletTypeCrystalAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack, Offset<IVectorInfo> TrackOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IHitBulletTypeCrystalAttack.AddTrackOffset(builder, TrackOffsetOffset);
			IHitBulletTypeCrystalAttack.AddType(builder, Type);
			return IHitBulletTypeCrystalAttack.EndIHitBulletTypeCrystalAttack(builder);
		}

		// Token: 0x06022F6D RID: 143213 RVA: 0x004D76D6 File Offset: 0x004D58D6
		public static void StartIHitBulletTypeCrystalAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022F6E RID: 143214 RVA: 0x004D76DF File Offset: 0x004D58DF
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F6F RID: 143215 RVA: 0x004D76EA File Offset: 0x004D58EA
		public static void AddTrackOffset(FlatBufferBuilder builder, Offset<IVectorInfo> trackOffsetOffset)
		{
			builder.AddOffset(1, trackOffsetOffset.Value, 0);
		}

		// Token: 0x06022F70 RID: 143216 RVA: 0x004D76FA File Offset: 0x004D58FA
		public static Offset<IHitBulletTypeCrystalAttack> EndIHitBulletTypeCrystalAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeCrystalAttack>(builder.EndTable());
		}

		// Token: 0x06022F71 RID: 143217 RVA: 0x004D7708 File Offset: 0x004D5908
		public IHitBulletTypeCrystalAttackT UnPack()
		{
			IHitBulletTypeCrystalAttackT hitBulletTypeCrystalAttackT = new IHitBulletTypeCrystalAttackT();
			this.UnPackTo(hitBulletTypeCrystalAttackT);
			return hitBulletTypeCrystalAttackT;
		}

		// Token: 0x06022F72 RID: 143218 RVA: 0x004D7724 File Offset: 0x004D5924
		public void UnPackTo(IHitBulletTypeCrystalAttackT _o)
		{
			_o.Type = this.Type;
			_o.TrackOffset = ((this.TrackOffset != null) ? this.TrackOffset.Value.UnPack() : null);
		}

		// Token: 0x06022F73 RID: 143219 RVA: 0x004D776C File Offset: 0x004D596C
		public static Offset<IHitBulletTypeCrystalAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeCrystalAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeCrystalAttack>);
			}
			Offset<IVectorInfo> trackOffsetOffset = (_o.TrackOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TrackOffset);
			return IHitBulletTypeCrystalAttack.CreateIHitBulletTypeCrystalAttack(builder, _o.Type, trackOffsetOffset);
		}

		// Token: 0x0400E550 RID: 58704
		private Table __p;
	}
}
