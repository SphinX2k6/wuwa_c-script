using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FA RID: 22778
	public struct IHitBulletTypeCrystalAttack : IFlatbufferObject
	{
		// Token: 0x1700A531 RID: 42289
		// (get) Token: 0x06025018 RID: 151576 RVA: 0x00514485 File Offset: 0x00512685
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025019 RID: 151577 RVA: 0x00514492 File Offset: 0x00512692
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602501A RID: 151578 RVA: 0x0051449C File Offset: 0x0051269C
		public static IHitBulletTypeCrystalAttack GetRootAsIHitBulletTypeCrystalAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeCrystalAttack.GetRootAsIHitBulletTypeCrystalAttack(_bb, default(IHitBulletTypeCrystalAttack));
		}

		// Token: 0x0602501B RID: 151579 RVA: 0x005144B8 File Offset: 0x005126B8
		public static IHitBulletTypeCrystalAttack GetRootAsIHitBulletTypeCrystalAttack(ByteBuffer _bb, IHitBulletTypeCrystalAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602501C RID: 151580 RVA: 0x005144D5 File Offset: 0x005126D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602501D RID: 151581 RVA: 0x005144E4 File Offset: 0x005126E4
		public IHitBulletTypeCrystalAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A532 RID: 42290
		// (get) Token: 0x0602501E RID: 151582 RVA: 0x005144F4 File Offset: 0x005126F4
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

		// Token: 0x1700A533 RID: 42291
		// (get) Token: 0x0602501F RID: 151583 RVA: 0x00514530 File Offset: 0x00512730
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

		// Token: 0x06025020 RID: 151584 RVA: 0x0051458D File Offset: 0x0051278D
		public static Offset<IHitBulletTypeCrystalAttack> CreateIHitBulletTypeCrystalAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack, Offset<IVectorInfo> TrackOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IHitBulletTypeCrystalAttack.AddTrackOffset(builder, TrackOffsetOffset);
			IHitBulletTypeCrystalAttack.AddType(builder, Type);
			return IHitBulletTypeCrystalAttack.EndIHitBulletTypeCrystalAttack(builder);
		}

		// Token: 0x06025021 RID: 151585 RVA: 0x005145AA File Offset: 0x005127AA
		public static void StartIHitBulletTypeCrystalAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025022 RID: 151586 RVA: 0x005145B3 File Offset: 0x005127B3
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025023 RID: 151587 RVA: 0x005145BE File Offset: 0x005127BE
		public static void AddTrackOffset(FlatBufferBuilder builder, Offset<IVectorInfo> trackOffsetOffset)
		{
			builder.AddOffset(1, trackOffsetOffset.Value, 0);
		}

		// Token: 0x06025024 RID: 151588 RVA: 0x005145CE File Offset: 0x005127CE
		public static Offset<IHitBulletTypeCrystalAttack> EndIHitBulletTypeCrystalAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeCrystalAttack>(builder.EndTable());
		}

		// Token: 0x06025025 RID: 151589 RVA: 0x005145DC File Offset: 0x005127DC
		public IHitBulletTypeCrystalAttackT UnPack()
		{
			IHitBulletTypeCrystalAttackT hitBulletTypeCrystalAttackT = new IHitBulletTypeCrystalAttackT();
			this.UnPackTo(hitBulletTypeCrystalAttackT);
			return hitBulletTypeCrystalAttackT;
		}

		// Token: 0x06025026 RID: 151590 RVA: 0x005145F8 File Offset: 0x005127F8
		public void UnPackTo(IHitBulletTypeCrystalAttackT _o)
		{
			_o.Type = this.Type;
			_o.TrackOffset = ((this.TrackOffset != null) ? this.TrackOffset.Value.UnPack() : null);
		}

		// Token: 0x06025027 RID: 151591 RVA: 0x00514640 File Offset: 0x00512840
		public static Offset<IHitBulletTypeCrystalAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeCrystalAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeCrystalAttack>);
			}
			Offset<IVectorInfo> trackOffsetOffset = (_o.TrackOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TrackOffset);
			return IHitBulletTypeCrystalAttack.CreateIHitBulletTypeCrystalAttack(builder, _o.Type, trackOffsetOffset);
		}

		// Token: 0x0400F180 RID: 61824
		private Table __p;
	}
}
