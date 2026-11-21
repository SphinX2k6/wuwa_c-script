using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590C RID: 22796
	public struct IHitComponent : IFlatbufferObject
	{
		// Token: 0x1700A54A RID: 42314
		// (get) Token: 0x060250A0 RID: 151712 RVA: 0x00515218 File Offset: 0x00513418
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060250A1 RID: 151713 RVA: 0x00515225 File Offset: 0x00513425
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060250A2 RID: 151714 RVA: 0x0051522C File Offset: 0x0051342C
		public static IHitComponent GetRootAsIHitComponent(ByteBuffer _bb)
		{
			return IHitComponent.GetRootAsIHitComponent(_bb, default(IHitComponent));
		}

		// Token: 0x060250A3 RID: 151715 RVA: 0x00515248 File Offset: 0x00513448
		public static IHitComponent GetRootAsIHitComponent(ByteBuffer _bb, IHitComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060250A4 RID: 151716 RVA: 0x00515265 File Offset: 0x00513465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060250A5 RID: 151717 RVA: 0x00515274 File Offset: 0x00513474
		public IHitComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A54B RID: 42315
		// (get) Token: 0x060250A6 RID: 151718 RVA: 0x00515284 File Offset: 0x00513484
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A54C RID: 42316
		// (get) Token: 0x060250A7 RID: 151719 RVA: 0x005152C4 File Offset: 0x005134C4
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

		// Token: 0x060250A8 RID: 151720 RVA: 0x00515300 File Offset: 0x00513500
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060250A9 RID: 151721 RVA: 0x00515344 File Offset: 0x00513544
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x060250AA RID: 151722 RVA: 0x00515360 File Offset: 0x00513560
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x060250AB RID: 151723 RVA: 0x0051537C File Offset: 0x0051357C
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x060250AC RID: 151724 RVA: 0x00515398 File Offset: 0x00513598
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x060250AD RID: 151725 RVA: 0x005153B4 File Offset: 0x005135B4
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x060250AE RID: 151726 RVA: 0x005153D0 File Offset: 0x005135D0
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700A54D RID: 42317
		// (get) Token: 0x060250AF RID: 151727 RVA: 0x005153EC File Offset: 0x005135EC
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

		// Token: 0x1700A54E RID: 42318
		// (get) Token: 0x060250B0 RID: 151728 RVA: 0x0051544C File Offset: 0x0051364C
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

		// Token: 0x060250B1 RID: 151729 RVA: 0x005154AC File Offset: 0x005136AC
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A54F RID: 42319
		// (get) Token: 0x060250B2 RID: 151730 RVA: 0x00515510 File Offset: 0x00513710
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

		// Token: 0x060250B3 RID: 151731 RVA: 0x0051553C File Offset: 0x0051373C
		public IBulletHitConfig? BulletHitConfigs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IBulletHitConfig?(default(IBulletHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A550 RID: 42320
		// (get) Token: 0x060250B4 RID: 151732 RVA: 0x005155A0 File Offset: 0x005137A0
		public int BulletHitConfigsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A551 RID: 42321
		// (get) Token: 0x060250B5 RID: 151733 RVA: 0x005155CC File Offset: 0x005137CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060250B6 RID: 151734 RVA: 0x0051560C File Offset: 0x0051380C
		public static Offset<IHitComponent> CreateIHitComponent(FlatBufferBuilder builder, bool Disabled = false, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), VectorOffset AimPartsOffset = default(VectorOffset), VectorOffset BulletHitConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IHitComponent.AddBulletHitConfigs(builder, BulletHitConfigsOffset);
			IHitComponent.AddAimParts(builder, AimPartsOffset);
			IHitComponent.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IHitComponent.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IHitComponent.AddHitBullet(builder, HitBulletOffset);
			IHitComponent.AddNullMask(builder, NullMask);
			IHitComponent.AddHitBulletType(builder, HitBullet_type);
			IHitComponent.AddDisabled(builder, Disabled);
			return IHitComponent.EndIHitComponent(builder);
		}

		// Token: 0x060250B7 RID: 151735 RVA: 0x00515663 File Offset: 0x00513863
		public static void StartIHitComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060250B8 RID: 151736 RVA: 0x0051566C File Offset: 0x0051386C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060250B9 RID: 151737 RVA: 0x00515677 File Offset: 0x00513877
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x060250BA RID: 151738 RVA: 0x00515682 File Offset: 0x00513882
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x060250BB RID: 151739 RVA: 0x0051568D File Offset: 0x0051388D
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060250BC RID: 151740 RVA: 0x0051569D File Offset: 0x0051389D
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060250BD RID: 151741 RVA: 0x005156AD File Offset: 0x005138AD
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x060250BE RID: 151742 RVA: 0x005156C0 File Offset: 0x005138C0
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060250BF RID: 151743 RVA: 0x00515700 File Offset: 0x00513900
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250C0 RID: 151744 RVA: 0x0051571A File Offset: 0x0051391A
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250C1 RID: 151745 RVA: 0x00515738 File Offset: 0x00513938
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060250C2 RID: 151746 RVA: 0x00515751 File Offset: 0x00513951
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060250C3 RID: 151747 RVA: 0x0051575C File Offset: 0x0051395C
		public static void AddBulletHitConfigs(FlatBufferBuilder builder, VectorOffset bulletHitConfigsOffset)
		{
			builder.AddOffset(6, bulletHitConfigsOffset.Value, 0);
		}

		// Token: 0x060250C4 RID: 151748 RVA: 0x0051576C File Offset: 0x0051396C
		public static VectorOffset CreateBulletHitConfigsVector(FlatBufferBuilder builder, Offset<IBulletHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060250C5 RID: 151749 RVA: 0x005157AC File Offset: 0x005139AC
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, Offset<IBulletHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBulletHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250C6 RID: 151750 RVA: 0x005157C6 File Offset: 0x005139C6
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBulletHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBulletHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250C7 RID: 151751 RVA: 0x005157E4 File Offset: 0x005139E4
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBulletHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060250C8 RID: 151752 RVA: 0x005157FD File Offset: 0x005139FD
		public static void StartBulletHitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060250C9 RID: 151753 RVA: 0x00515808 File Offset: 0x00513A08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060250CA RID: 151754 RVA: 0x00515813 File Offset: 0x00513A13
		public static Offset<IHitComponent> EndIHitComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHitComponent>(builder.EndTable());
		}

		// Token: 0x060250CB RID: 151755 RVA: 0x00515820 File Offset: 0x00513A20
		public IHitComponentT UnPack()
		{
			IHitComponentT hitComponentT = new IHitComponentT();
			this.UnPackTo(hitComponentT);
			return hitComponentT;
		}

		// Token: 0x060250CC RID: 151756 RVA: 0x0051583C File Offset: 0x00513A3C
		public void UnPackTo(IHitComponentT _o)
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
			_o.BulletHitConfigs = new List<IBulletHitConfigT>();
			for (int j = 0; j < this.BulletHitConfigsLength; j++)
			{
				_o.BulletHitConfigs.Add((this.BulletHitConfigs(j) != null) ? this.BulletHitConfigs(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060250CD RID: 151757 RVA: 0x00515B1C File Offset: 0x00513D1C
		public static Offset<IHitComponent> Pack(FlatBufferBuilder builder, IHitComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitComponent>);
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
				aimPartsOffset = IHitComponent.CreateAimPartsVector(builder, array);
			}
			VectorOffset bulletHitConfigsOffset = default(VectorOffset);
			if (_o.BulletHitConfigs != null)
			{
				Offset<IBulletHitConfig>[] array2 = new Offset<IBulletHitConfig>[_o.BulletHitConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IBulletHitConfig.Pack(builder, _o.BulletHitConfigs[j]);
				}
				bulletHitConfigsOffset = IHitComponent.CreateBulletHitConfigsVector(builder, array2);
			}
			return IHitComponent.CreateIHitComponent(builder, _o.Disabled, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset, aimPartsOffset, bulletHitConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F199 RID: 61849
		private Table __p;
	}
}
