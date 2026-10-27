using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005389 RID: 21385
	public struct IHitComponentBase : IFlatbufferObject
	{
		// Token: 0x17009D21 RID: 40225
		// (get) Token: 0x0602302A RID: 143402 RVA: 0x004D8F73 File Offset: 0x004D7173
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602302B RID: 143403 RVA: 0x004D8F80 File Offset: 0x004D7180
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602302C RID: 143404 RVA: 0x004D8F88 File Offset: 0x004D7188
		public static IHitComponentBase GetRootAsIHitComponentBase(ByteBuffer _bb)
		{
			return IHitComponentBase.GetRootAsIHitComponentBase(_bb, default(IHitComponentBase));
		}

		// Token: 0x0602302D RID: 143405 RVA: 0x004D8FA4 File Offset: 0x004D71A4
		public static IHitComponentBase GetRootAsIHitComponentBase(ByteBuffer _bb, IHitComponentBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602302E RID: 143406 RVA: 0x004D8FC1 File Offset: 0x004D71C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602302F RID: 143407 RVA: 0x004D8FD0 File Offset: 0x004D71D0
		public IHitComponentBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D22 RID: 40226
		// (get) Token: 0x06023030 RID: 143408 RVA: 0x004D8FE0 File Offset: 0x004D71E0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D23 RID: 40227
		// (get) Token: 0x06023031 RID: 143409 RVA: 0x004D9020 File Offset: 0x004D7220
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

		// Token: 0x06023032 RID: 143410 RVA: 0x004D905C File Offset: 0x004D725C
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023033 RID: 143411 RVA: 0x004D90A0 File Offset: 0x004D72A0
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06023034 RID: 143412 RVA: 0x004D90BC File Offset: 0x004D72BC
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06023035 RID: 143413 RVA: 0x004D90D8 File Offset: 0x004D72D8
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06023036 RID: 143414 RVA: 0x004D90F4 File Offset: 0x004D72F4
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06023037 RID: 143415 RVA: 0x004D9110 File Offset: 0x004D7310
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06023038 RID: 143416 RVA: 0x004D912C File Offset: 0x004D732C
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x17009D24 RID: 40228
		// (get) Token: 0x06023039 RID: 143417 RVA: 0x004D9148 File Offset: 0x004D7348
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

		// Token: 0x17009D25 RID: 40229
		// (get) Token: 0x0602303A RID: 143418 RVA: 0x004D91A8 File Offset: 0x004D73A8
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

		// Token: 0x0602303B RID: 143419 RVA: 0x004D9208 File Offset: 0x004D7408
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D26 RID: 40230
		// (get) Token: 0x0602303C RID: 143420 RVA: 0x004D926C File Offset: 0x004D746C
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

		// Token: 0x17009D27 RID: 40231
		// (get) Token: 0x0602303D RID: 143421 RVA: 0x004D9298 File Offset: 0x004D7498
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

		// Token: 0x0602303E RID: 143422 RVA: 0x004D92D8 File Offset: 0x004D74D8
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

		// Token: 0x0602303F RID: 143423 RVA: 0x004D9327 File Offset: 0x004D7527
		public static void StartIHitComponentBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023040 RID: 143424 RVA: 0x004D9330 File Offset: 0x004D7530
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023041 RID: 143425 RVA: 0x004D933B File Offset: 0x004D753B
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06023042 RID: 143426 RVA: 0x004D9346 File Offset: 0x004D7546
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06023043 RID: 143427 RVA: 0x004D9351 File Offset: 0x004D7551
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023044 RID: 143428 RVA: 0x004D9361 File Offset: 0x004D7561
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023045 RID: 143429 RVA: 0x004D9371 File Offset: 0x004D7571
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06023046 RID: 143430 RVA: 0x004D9384 File Offset: 0x004D7584
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023047 RID: 143431 RVA: 0x004D93C4 File Offset: 0x004D75C4
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023048 RID: 143432 RVA: 0x004D93DE File Offset: 0x004D75DE
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023049 RID: 143433 RVA: 0x004D93FC File Offset: 0x004D75FC
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602304A RID: 143434 RVA: 0x004D9415 File Offset: 0x004D7615
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602304B RID: 143435 RVA: 0x004D9420 File Offset: 0x004D7620
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602304C RID: 143436 RVA: 0x004D942B File Offset: 0x004D762B
		public static Offset<IHitComponentBase> EndIHitComponentBase(FlatBufferBuilder builder)
		{
			return new Offset<IHitComponentBase>(builder.EndTable());
		}

		// Token: 0x0602304D RID: 143437 RVA: 0x004D9438 File Offset: 0x004D7638
		public IHitComponentBaseT UnPack()
		{
			IHitComponentBaseT hitComponentBaseT = new IHitComponentBaseT();
			this.UnPackTo(hitComponentBaseT);
			return hitComponentBaseT;
		}

		// Token: 0x0602304E RID: 143438 RVA: 0x004D9454 File Offset: 0x004D7654
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

		// Token: 0x0602304F RID: 143439 RVA: 0x004D96D8 File Offset: 0x004D78D8
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

		// Token: 0x0400E571 RID: 58737
		private Table __p;
	}
}
