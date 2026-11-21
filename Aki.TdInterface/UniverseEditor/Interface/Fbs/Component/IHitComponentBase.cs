using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590F RID: 22799
	public struct IHitComponentBase : IFlatbufferObject
	{
		// Token: 0x1700A559 RID: 42329
		// (get) Token: 0x060250DE RID: 151774 RVA: 0x00515E47 File Offset: 0x00514047
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060250DF RID: 151775 RVA: 0x00515E54 File Offset: 0x00514054
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060250E0 RID: 151776 RVA: 0x00515E5C File Offset: 0x0051405C
		public static IHitComponentBase GetRootAsIHitComponentBase(ByteBuffer _bb)
		{
			return IHitComponentBase.GetRootAsIHitComponentBase(_bb, default(IHitComponentBase));
		}

		// Token: 0x060250E1 RID: 151777 RVA: 0x00515E78 File Offset: 0x00514078
		public static IHitComponentBase GetRootAsIHitComponentBase(ByteBuffer _bb, IHitComponentBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060250E2 RID: 151778 RVA: 0x00515E95 File Offset: 0x00514095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060250E3 RID: 151779 RVA: 0x00515EA4 File Offset: 0x005140A4
		public IHitComponentBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A55A RID: 42330
		// (get) Token: 0x060250E4 RID: 151780 RVA: 0x00515EB4 File Offset: 0x005140B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A55B RID: 42331
		// (get) Token: 0x060250E5 RID: 151781 RVA: 0x00515EF4 File Offset: 0x005140F4
		public THitBulletType HitBulletType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060250E6 RID: 151782 RVA: 0x00515F30 File Offset: 0x00514130
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060250E7 RID: 151783 RVA: 0x00515F74 File Offset: 0x00514174
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x060250E8 RID: 151784 RVA: 0x00515F90 File Offset: 0x00514190
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x060250E9 RID: 151785 RVA: 0x00515FAC File Offset: 0x005141AC
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x060250EA RID: 151786 RVA: 0x00515FC8 File Offset: 0x005141C8
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x060250EB RID: 151787 RVA: 0x00515FE4 File Offset: 0x005141E4
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x060250EC RID: 151788 RVA: 0x00516000 File Offset: 0x00514200
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700A55C RID: 42332
		// (get) Token: 0x060250ED RID: 151789 RVA: 0x0051601C File Offset: 0x0051421C
		public IHitTimeScaleRatio? AttackerHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A55D RID: 42333
		// (get) Token: 0x060250EE RID: 151790 RVA: 0x0051607C File Offset: 0x0051427C
		public IHitTimeScaleRatio? VictimHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060250EF RID: 151791 RVA: 0x005160DC File Offset: 0x005142DC
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A55E RID: 42334
		// (get) Token: 0x060250F0 RID: 151792 RVA: 0x00516140 File Offset: 0x00514340
		public int AimPartsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A55F RID: 42335
		// (get) Token: 0x060250F1 RID: 151793 RVA: 0x0051616C File Offset: 0x0051436C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060250F2 RID: 151794 RVA: 0x005161AC File Offset: 0x005143AC
		public static Offset<IHitComponentBase> CreateIHitComponentBase(FlatBufferBuilder builder, bool Disabled = false, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), VectorOffset AimPartsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IHitComponentBase.AddAimParts(builder, AimPartsOffset);
			IHitComponentBase.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IHitComponentBase.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IHitComponentBase.AddHitBullet(builder, HitBulletOffset);
			IHitComponentBase.AddNullMask(builder, NullMask);
			IHitComponentBase.AddHitBulletType(builder, HitBullet_type);
			IHitComponentBase.AddDisabled(builder, Disabled);
			return IHitComponentBase.EndIHitComponentBase(builder);
		}

		// Token: 0x060250F3 RID: 151795 RVA: 0x005161FB File Offset: 0x005143FB
		public static void StartIHitComponentBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060250F4 RID: 151796 RVA: 0x00516204 File Offset: 0x00514404
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060250F5 RID: 151797 RVA: 0x0051620F File Offset: 0x0051440F
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x060250F6 RID: 151798 RVA: 0x0051621A File Offset: 0x0051441A
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x060250F7 RID: 151799 RVA: 0x00516225 File Offset: 0x00514425
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060250F8 RID: 151800 RVA: 0x00516235 File Offset: 0x00514435
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060250F9 RID: 151801 RVA: 0x00516245 File Offset: 0x00514445
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x060250FA RID: 151802 RVA: 0x00516258 File Offset: 0x00514458
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060250FB RID: 151803 RVA: 0x00516298 File Offset: 0x00514498
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250FC RID: 151804 RVA: 0x005162B2 File Offset: 0x005144B2
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250FD RID: 151805 RVA: 0x005162D0 File Offset: 0x005144D0
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060250FE RID: 151806 RVA: 0x005162E9 File Offset: 0x005144E9
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060250FF RID: 151807 RVA: 0x005162F4 File Offset: 0x005144F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025100 RID: 151808 RVA: 0x005162FF File Offset: 0x005144FF
		public static Offset<IHitComponentBase> EndIHitComponentBase(FlatBufferBuilder builder)
		{
			return new Offset<IHitComponentBase>(builder.EndTable());
		}

		// Token: 0x06025101 RID: 151809 RVA: 0x0051630C File Offset: 0x0051450C
		public IHitComponentBaseT UnPack()
		{
			IHitComponentBaseT hitComponentBaseT = new IHitComponentBaseT();
			this.UnPackTo(hitComponentBaseT);
			return hitComponentBaseT;
		}

		// Token: 0x06025102 RID: 151810 RVA: 0x00516328 File Offset: 0x00514528
		public void UnPackTo(IHitComponentBaseT _o)
		{
			_o.Disabled = this.Disabled;
			_o.HitBullet = new THitBulletTypeUnion();
			_o.HitBullet.Type = this.HitBulletType;
			switch (this.HitBulletType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullet<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullet<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.AttackerHitTimeScaleRatio = ((this.AttackerHitTimeScaleRatio != null) ? this.AttackerHitTimeScaleRatio.Value.UnPack() : null);
			_o.VictimHitTimeScaleRatio = ((this.VictimHitTimeScaleRatio != null) ? this.VictimHitTimeScaleRatio.Value.UnPack() : null);
			_o.AimParts = new List<IAimPartT>();
			for (int i = 0; i < this.AimPartsLength; i++)
			{
				_o.AimParts.Add((this.AimParts(i) != null) ? this.AimParts(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025103 RID: 151811 RVA: 0x005165AC File Offset: 0x005147AC
		public static Offset<IHitComponentBase> Pack(FlatBufferBuilder builder, IHitComponentBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitComponentBase>);
			}
			THitBulletType hitBullet_type = (_o.HitBullet == null) ? THitBulletType.NONE : _o.HitBullet.Type;
			int hitBulletOffset = (_o.HitBullet == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullet);
			Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset = (_o.AttackerHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.AttackerHitTimeScaleRatio);
			Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset = (_o.VictimHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.VictimHitTimeScaleRatio);
			VectorOffset aimPartsOffset = default(VectorOffset);
			if (_o.AimParts != null)
			{
				Offset<IAimPart>[] array = new Offset<IAimPart>[_o.AimParts.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAimPart.Pack(builder, _o.AimParts[i]);
				}
				aimPartsOffset = IHitComponentBase.CreateAimPartsVector(builder, array);
			}
			return IHitComponentBase.CreateIHitComponentBase(builder, _o.Disabled, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset, aimPartsOffset, _o.NullMask);
		}

		// Token: 0x0400F1A1 RID: 61857
		private Table __p;
	}
}
