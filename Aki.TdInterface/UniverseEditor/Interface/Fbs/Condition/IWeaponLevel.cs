using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1B RID: 19739
	public struct IWeaponLevel : IFlatbufferObject
	{
		// Token: 0x17008F20 RID: 36640
		// (get) Token: 0x0601F548 RID: 128328 RVA: 0x0045E635 File Offset: 0x0045C835
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F549 RID: 128329 RVA: 0x0045E642 File Offset: 0x0045C842
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F54A RID: 128330 RVA: 0x0045E64C File Offset: 0x0045C84C
		public static IWeaponLevel GetRootAsIWeaponLevel(ByteBuffer _bb)
		{
			return IWeaponLevel.GetRootAsIWeaponLevel(_bb, default(IWeaponLevel));
		}

		// Token: 0x0601F54B RID: 128331 RVA: 0x0045E668 File Offset: 0x0045C868
		public static IWeaponLevel GetRootAsIWeaponLevel(ByteBuffer _bb, IWeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F54C RID: 128332 RVA: 0x0045E685 File Offset: 0x0045C885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F54D RID: 128333 RVA: 0x0045E694 File Offset: 0x0045C894
		public IWeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F21 RID: 36641
		// (get) Token: 0x0601F54E RID: 128334 RVA: 0x0045E6A4 File Offset: 0x0045C8A4
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

		// Token: 0x17008F22 RID: 36642
		// (get) Token: 0x0601F54F RID: 128335 RVA: 0x0045E6E0 File Offset: 0x0045C8E0
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

		// Token: 0x0601F550 RID: 128336 RVA: 0x0045E73D File Offset: 0x0045C93D
		public static Offset<IWeaponLevel> CreateIWeaponLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, Offset<ISpecifyRoleWeaponLevel> OptionOffset = default(Offset<ISpecifyRoleWeaponLevel>))
		{
			builder.StartTable(2);
			IWeaponLevel.AddOption(builder, OptionOffset);
			IWeaponLevel.AddType(builder, Type);
			return IWeaponLevel.EndIWeaponLevel(builder);
		}

		// Token: 0x0601F551 RID: 128337 RVA: 0x0045E75A File Offset: 0x0045C95A
		public static void StartIWeaponLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F552 RID: 128338 RVA: 0x0045E763 File Offset: 0x0045C963
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F553 RID: 128339 RVA: 0x0045E76E File Offset: 0x0045C96E
		public static void AddOption(FlatBufferBuilder builder, Offset<ISpecifyRoleWeaponLevel> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x0601F554 RID: 128340 RVA: 0x0045E77E File Offset: 0x0045C97E
		public static Offset<IWeaponLevel> EndIWeaponLevel(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponLevel>(builder.EndTable());
		}

		// Token: 0x0601F555 RID: 128341 RVA: 0x0045E78C File Offset: 0x0045C98C
		public IWeaponLevelT UnPack()
		{
			IWeaponLevelT weaponLevelT = new IWeaponLevelT();
			this.UnPackTo(weaponLevelT);
			return weaponLevelT;
		}

		// Token: 0x0601F556 RID: 128342 RVA: 0x0045E7A8 File Offset: 0x0045C9A8
		public void UnPackTo(IWeaponLevelT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x0601F557 RID: 128343 RVA: 0x0045E7F0 File Offset: 0x0045C9F0
		public static Offset<IWeaponLevel> Pack(FlatBufferBuilder builder, IWeaponLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponLevel>);
			}
			Offset<ISpecifyRoleWeaponLevel> optionOffset = (_o.Option == null) ? default(Offset<ISpecifyRoleWeaponLevel>) : ISpecifyRoleWeaponLevel.Pack(builder, _o.Option);
			return IWeaponLevel.CreateIWeaponLevel(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400D704 RID: 55044
		private Table __p;
	}
}
