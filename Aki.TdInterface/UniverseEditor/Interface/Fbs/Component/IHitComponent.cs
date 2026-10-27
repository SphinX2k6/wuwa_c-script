using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005386 RID: 21382
	public struct IHitComponent : IFlatbufferObject
	{
		// Token: 0x17009D12 RID: 40210
		// (get) Token: 0x06022FEC RID: 143340 RVA: 0x004D8344 File Offset: 0x004D6544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FED RID: 143341 RVA: 0x004D8351 File Offset: 0x004D6551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FEE RID: 143342 RVA: 0x004D8358 File Offset: 0x004D6558
		public static IHitComponent GetRootAsIHitComponent(ByteBuffer _bb)
		{
			return IHitComponent.GetRootAsIHitComponent(_bb, default(IHitComponent));
		}

		// Token: 0x06022FEF RID: 143343 RVA: 0x004D8374 File Offset: 0x004D6574
		public static IHitComponent GetRootAsIHitComponent(ByteBuffer _bb, IHitComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FF0 RID: 143344 RVA: 0x004D8391 File Offset: 0x004D6591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FF1 RID: 143345 RVA: 0x004D83A0 File Offset: 0x004D65A0
		public IHitComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D13 RID: 40211
		// (get) Token: 0x06022FF2 RID: 143346 RVA: 0x004D83B0 File Offset: 0x004D65B0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D14 RID: 40212
		// (get) Token: 0x06022FF3 RID: 143347 RVA: 0x004D83F0 File Offset: 0x004D65F0
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

		// Token: 0x06022FF4 RID: 143348 RVA: 0x004D842C File Offset: 0x004D662C
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022FF5 RID: 143349 RVA: 0x004D8470 File Offset: 0x004D6670
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06022FF6 RID: 143350 RVA: 0x004D848C File Offset: 0x004D668C
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06022FF7 RID: 143351 RVA: 0x004D84A8 File Offset: 0x004D66A8
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06022FF8 RID: 143352 RVA: 0x004D84C4 File Offset: 0x004D66C4
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06022FF9 RID: 143353 RVA: 0x004D84E0 File Offset: 0x004D66E0
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06022FFA RID: 143354 RVA: 0x004D84FC File Offset: 0x004D66FC
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x17009D15 RID: 40213
		// (get) Token: 0x06022FFB RID: 143355 RVA: 0x004D8518 File Offset: 0x004D6718
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

		// Token: 0x17009D16 RID: 40214
		// (get) Token: 0x06022FFC RID: 143356 RVA: 0x004D8578 File Offset: 0x004D6778
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

		// Token: 0x06022FFD RID: 143357 RVA: 0x004D85D8 File Offset: 0x004D67D8
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D17 RID: 40215
		// (get) Token: 0x06022FFE RID: 143358 RVA: 0x004D863C File Offset: 0x004D683C
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

		// Token: 0x06022FFF RID: 143359 RVA: 0x004D8668 File Offset: 0x004D6868
		public IBulletHitConfig? BulletHitConfigs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IBulletHitConfig?(default(IBulletHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D18 RID: 40216
		// (get) Token: 0x06023000 RID: 143360 RVA: 0x004D86CC File Offset: 0x004D68CC
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

		// Token: 0x17009D19 RID: 40217
		// (get) Token: 0x06023001 RID: 143361 RVA: 0x004D86F8 File Offset: 0x004D68F8
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

		// Token: 0x06023002 RID: 143362 RVA: 0x004D8738 File Offset: 0x004D6938
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

		// Token: 0x06023003 RID: 143363 RVA: 0x004D878F File Offset: 0x004D698F
		public static void StartIHitComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023004 RID: 143364 RVA: 0x004D8798 File Offset: 0x004D6998
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023005 RID: 143365 RVA: 0x004D87A3 File Offset: 0x004D69A3
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06023006 RID: 143366 RVA: 0x004D87AE File Offset: 0x004D69AE
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06023007 RID: 143367 RVA: 0x004D87B9 File Offset: 0x004D69B9
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023008 RID: 143368 RVA: 0x004D87C9 File Offset: 0x004D69C9
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023009 RID: 143369 RVA: 0x004D87D9 File Offset: 0x004D69D9
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x0602300A RID: 143370 RVA: 0x004D87EC File Offset: 0x004D69EC
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602300B RID: 143371 RVA: 0x004D882C File Offset: 0x004D6A2C
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602300C RID: 143372 RVA: 0x004D8846 File Offset: 0x004D6A46
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602300D RID: 143373 RVA: 0x004D8864 File Offset: 0x004D6A64
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602300E RID: 143374 RVA: 0x004D887D File Offset: 0x004D6A7D
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602300F RID: 143375 RVA: 0x004D8888 File Offset: 0x004D6A88
		public static void AddBulletHitConfigs(FlatBufferBuilder builder, VectorOffset bulletHitConfigsOffset)
		{
			builder.AddOffset(6, bulletHitConfigsOffset.Value, 0);
		}

		// Token: 0x06023010 RID: 143376 RVA: 0x004D8898 File Offset: 0x004D6A98
		public static VectorOffset CreateBulletHitConfigsVector(FlatBufferBuilder builder, Offset<IBulletHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023011 RID: 143377 RVA: 0x004D88D8 File Offset: 0x004D6AD8
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, Offset<IBulletHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBulletHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023012 RID: 143378 RVA: 0x004D88F2 File Offset: 0x004D6AF2
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBulletHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBulletHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023013 RID: 143379 RVA: 0x004D8910 File Offset: 0x004D6B10
		public static VectorOffset CreateBulletHitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBulletHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023014 RID: 143380 RVA: 0x004D8929 File Offset: 0x004D6B29
		public static void StartBulletHitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x004D8934 File Offset: 0x004D6B34
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023016 RID: 143382 RVA: 0x004D893F File Offset: 0x004D6B3F
		public static Offset<IHitComponent> EndIHitComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHitComponent>(builder.EndTable());
		}

		// Token: 0x06023017 RID: 143383 RVA: 0x004D894C File Offset: 0x004D6B4C
		public IHitComponentT UnPack()
		{
			IHitComponentT hitComponentT = new IHitComponentT();
			this.UnPackTo(hitComponentT);
			return hitComponentT;
		}

		// Token: 0x06023018 RID: 143384 RVA: 0x004D8968 File Offset: 0x004D6B68
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

		// Token: 0x06023019 RID: 143385 RVA: 0x004D8C48 File Offset: 0x004D6E48
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

		// Token: 0x0400E569 RID: 58729
		private Table __p;
	}
}
