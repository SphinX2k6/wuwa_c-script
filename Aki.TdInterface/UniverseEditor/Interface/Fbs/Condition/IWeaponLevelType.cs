using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200521A RID: 21018
	public struct IWeaponLevelType : IFlatbufferObject
	{
		// Token: 0x1700965E RID: 38494
		// (get) Token: 0x060211A5 RID: 135589 RVA: 0x00492854 File Offset: 0x00490A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060211A6 RID: 135590 RVA: 0x00492861 File Offset: 0x00490A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060211A7 RID: 135591 RVA: 0x00492868 File Offset: 0x00490A68
		public static IWeaponLevelType GetRootAsIWeaponLevelType(ByteBuffer _bb)
		{
			return IWeaponLevelType.GetRootAsIWeaponLevelType(_bb, default(IWeaponLevelType));
		}

		// Token: 0x060211A8 RID: 135592 RVA: 0x00492884 File Offset: 0x00490A84
		public static IWeaponLevelType GetRootAsIWeaponLevelType(ByteBuffer _bb, IWeaponLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060211A9 RID: 135593 RVA: 0x004928A1 File Offset: 0x00490AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060211AA RID: 135594 RVA: 0x004928B0 File Offset: 0x00490AB0
		public IWeaponLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700965F RID: 38495
		// (get) Token: 0x060211AB RID: 135595 RVA: 0x004928C0 File Offset: 0x00490AC0
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

		// Token: 0x060211AC RID: 135596 RVA: 0x004928FC File Offset: 0x00490AFC
		public static Offset<IWeaponLevelType> CreateIWeaponLevelType(FlatBufferBuilder builder, EWeaponLevelType Type = EWeaponLevelType.SpecifyRole)
		{
			builder.StartTable(1);
			IWeaponLevelType.AddType(builder, Type);
			return IWeaponLevelType.EndIWeaponLevelType(builder);
		}

		// Token: 0x060211AD RID: 135597 RVA: 0x00492912 File Offset: 0x00490B12
		public static void StartIWeaponLevelType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060211AE RID: 135598 RVA: 0x0049291B File Offset: 0x00490B1B
		public static void AddType(FlatBufferBuilder builder, EWeaponLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060211AF RID: 135599 RVA: 0x00492926 File Offset: 0x00490B26
		public static Offset<IWeaponLevelType> EndIWeaponLevelType(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponLevelType>(builder.EndTable());
		}

		// Token: 0x060211B0 RID: 135600 RVA: 0x00492934 File Offset: 0x00490B34
		public IWeaponLevelTypeT UnPack()
		{
			IWeaponLevelTypeT weaponLevelTypeT = new IWeaponLevelTypeT();
			this.UnPackTo(weaponLevelTypeT);
			return weaponLevelTypeT;
		}

		// Token: 0x060211B1 RID: 135601 RVA: 0x0049294F File Offset: 0x00490B4F
		public void UnPackTo(IWeaponLevelTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060211B2 RID: 135602 RVA: 0x00492960 File Offset: 0x00490B60
		public static Offset<IWeaponLevelType> Pack(FlatBufferBuilder builder, IWeaponLevelTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponLevelType>);
			}
			return IWeaponLevelType.CreateIWeaponLevelType(builder, _o.Type);
		}

		// Token: 0x0400E235 RID: 57909
		private Table __p;
	}
}
