using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1E RID: 19742
	public struct IWeaponLevelType : IFlatbufferObject
	{
		// Token: 0x17008F25 RID: 36645
		// (get) Token: 0x0601F55E RID: 128350 RVA: 0x0045E8C4 File Offset: 0x0045CAC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F55F RID: 128351 RVA: 0x0045E8D1 File Offset: 0x0045CAD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F560 RID: 128352 RVA: 0x0045E8D8 File Offset: 0x0045CAD8
		public static IWeaponLevelType GetRootAsIWeaponLevelType(ByteBuffer _bb)
		{
			return IWeaponLevelType.GetRootAsIWeaponLevelType(_bb, default(IWeaponLevelType));
		}

		// Token: 0x0601F561 RID: 128353 RVA: 0x0045E8F4 File Offset: 0x0045CAF4
		public static IWeaponLevelType GetRootAsIWeaponLevelType(ByteBuffer _bb, IWeaponLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F562 RID: 128354 RVA: 0x0045E911 File Offset: 0x0045CB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F563 RID: 128355 RVA: 0x0045E920 File Offset: 0x0045CB20
		public IWeaponLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F26 RID: 36646
		// (get) Token: 0x0601F564 RID: 128356 RVA: 0x0045E930 File Offset: 0x0045CB30
		public EWeaponLevelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWeaponLevelType.SpecifyRole;
				}
				return (EWeaponLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F565 RID: 128357 RVA: 0x0045E96C File Offset: 0x0045CB6C
		public static Offset<IWeaponLevelType> CreateIWeaponLevelType(FlatBufferBuilder builder, EWeaponLevelType Type = EWeaponLevelType.SpecifyRole)
		{
			builder.StartTable(1);
			IWeaponLevelType.AddType(builder, Type);
			return IWeaponLevelType.EndIWeaponLevelType(builder);
		}

		// Token: 0x0601F566 RID: 128358 RVA: 0x0045E982 File Offset: 0x0045CB82
		public static void StartIWeaponLevelType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F567 RID: 128359 RVA: 0x0045E98B File Offset: 0x0045CB8B
		public static void AddType(FlatBufferBuilder builder, EWeaponLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F568 RID: 128360 RVA: 0x0045E996 File Offset: 0x0045CB96
		public static Offset<IWeaponLevelType> EndIWeaponLevelType(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponLevelType>(builder.EndTable());
		}

		// Token: 0x0601F569 RID: 128361 RVA: 0x0045E9A4 File Offset: 0x0045CBA4
		public IWeaponLevelTypeT UnPack()
		{
			IWeaponLevelTypeT weaponLevelTypeT = new IWeaponLevelTypeT();
			this.UnPackTo(weaponLevelTypeT);
			return weaponLevelTypeT;
		}

		// Token: 0x0601F56A RID: 128362 RVA: 0x0045E9BF File Offset: 0x0045CBBF
		public void UnPackTo(IWeaponLevelTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F56B RID: 128363 RVA: 0x0045E9D0 File Offset: 0x0045CBD0
		public static Offset<IWeaponLevelType> Pack(FlatBufferBuilder builder, IWeaponLevelTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponLevelType>);
			}
			return IWeaponLevelType.CreateIWeaponLevelType(builder, _o.Type);
		}

		// Token: 0x0400D707 RID: 55047
		private Table __p;
	}
}
