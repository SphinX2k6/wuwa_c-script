using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005217 RID: 21015
	public struct IWeaponLevel : IFlatbufferObject
	{
		// Token: 0x17009659 RID: 38489
		// (get) Token: 0x0602118F RID: 135567 RVA: 0x004925C5 File Offset: 0x004907C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021190 RID: 135568 RVA: 0x004925D2 File Offset: 0x004907D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x004925DC File Offset: 0x004907DC
		public static IWeaponLevel GetRootAsIWeaponLevel(ByteBuffer _bb)
		{
			return IWeaponLevel.GetRootAsIWeaponLevel(_bb, default(IWeaponLevel));
		}

		// Token: 0x06021192 RID: 135570 RVA: 0x004925F8 File Offset: 0x004907F8
		public static IWeaponLevel GetRootAsIWeaponLevel(ByteBuffer _bb, IWeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021193 RID: 135571 RVA: 0x00492615 File Offset: 0x00490815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021194 RID: 135572 RVA: 0x00492624 File Offset: 0x00490824
		public IWeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700965A RID: 38490
		// (get) Token: 0x06021195 RID: 135573 RVA: 0x00492634 File Offset: 0x00490834
		public EFormationRoleInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFormationRoleInfoType.RoleLevel;
				}
				return (EFormationRoleInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700965B RID: 38491
		// (get) Token: 0x06021196 RID: 135574 RVA: 0x00492670 File Offset: 0x00490870
		public ISpecifyRoleWeaponLevel? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISpecifyRoleWeaponLevel?(default(ISpecifyRoleWeaponLevel).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021197 RID: 135575 RVA: 0x004926CD File Offset: 0x004908CD
		public static Offset<IWeaponLevel> CreateIWeaponLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, Offset<ISpecifyRoleWeaponLevel> OptionOffset = default(Offset<ISpecifyRoleWeaponLevel>))
		{
			builder.StartTable(2);
			IWeaponLevel.AddOption(builder, OptionOffset);
			IWeaponLevel.AddType(builder, Type);
			return IWeaponLevel.EndIWeaponLevel(builder);
		}

		// Token: 0x06021198 RID: 135576 RVA: 0x004926EA File Offset: 0x004908EA
		public static void StartIWeaponLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021199 RID: 135577 RVA: 0x004926F3 File Offset: 0x004908F3
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602119A RID: 135578 RVA: 0x004926FE File Offset: 0x004908FE
		public static void AddOption(FlatBufferBuilder builder, Offset<ISpecifyRoleWeaponLevel> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x0602119B RID: 135579 RVA: 0x0049270E File Offset: 0x0049090E
		public static Offset<IWeaponLevel> EndIWeaponLevel(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponLevel>(builder.EndTable());
		}

		// Token: 0x0602119C RID: 135580 RVA: 0x0049271C File Offset: 0x0049091C
		public IWeaponLevelT UnPack()
		{
			IWeaponLevelT weaponLevelT = new IWeaponLevelT();
			this.UnPackTo(weaponLevelT);
			return weaponLevelT;
		}

		// Token: 0x0602119D RID: 135581 RVA: 0x00492738 File Offset: 0x00490938
		public void UnPackTo(IWeaponLevelT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x0602119E RID: 135582 RVA: 0x00492780 File Offset: 0x00490980
		public static Offset<IWeaponLevel> Pack(FlatBufferBuilder builder, IWeaponLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponLevel>);
			}
			Offset<ISpecifyRoleWeaponLevel> optionOffset = (_o.Option == null) ? default(Offset<ISpecifyRoleWeaponLevel>) : ISpecifyRoleWeaponLevel.Pack(builder, _o.Option);
			return IWeaponLevel.CreateIWeaponLevel(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400E232 RID: 57906
		private Table __p;
	}
}
