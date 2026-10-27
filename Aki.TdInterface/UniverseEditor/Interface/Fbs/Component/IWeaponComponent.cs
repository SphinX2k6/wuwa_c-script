using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B68 RID: 23400
	public struct IWeaponComponent : IFlatbufferObject
	{
		// Token: 0x1700B0C7 RID: 45255
		// (get) Token: 0x060280A3 RID: 164003 RVA: 0x0058142C File Offset: 0x0057F62C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280A4 RID: 164004 RVA: 0x00581439 File Offset: 0x0057F639
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280A5 RID: 164005 RVA: 0x00581440 File Offset: 0x0057F640
		public static IWeaponComponent GetRootAsIWeaponComponent(ByteBuffer _bb)
		{
			return IWeaponComponent.GetRootAsIWeaponComponent(_bb, default(IWeaponComponent));
		}

		// Token: 0x060280A6 RID: 164006 RVA: 0x0058145C File Offset: 0x0057F65C
		public static IWeaponComponent GetRootAsIWeaponComponent(ByteBuffer _bb, IWeaponComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280A7 RID: 164007 RVA: 0x00581479 File Offset: 0x0057F679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280A8 RID: 164008 RVA: 0x00581488 File Offset: 0x0057F688
		public IWeaponComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0C8 RID: 45256
		// (get) Token: 0x060280A9 RID: 164009 RVA: 0x00581498 File Offset: 0x0057F698
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B0C9 RID: 45257
		// (get) Token: 0x060280AA RID: 164010 RVA: 0x005814D8 File Offset: 0x0057F6D8
		public int WeaponId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0CA RID: 45258
		// (get) Token: 0x060280AB RID: 164011 RVA: 0x00581514 File Offset: 0x0057F714
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060280AC RID: 164012 RVA: 0x00581550 File Offset: 0x0057F750
		public static Offset<IWeaponComponent> CreateIWeaponComponent(FlatBufferBuilder builder, bool Disabled = false, int WeaponId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWeaponComponent.AddWeaponId(builder, WeaponId);
			IWeaponComponent.AddNullMask(builder, NullMask);
			IWeaponComponent.AddDisabled(builder, Disabled);
			return IWeaponComponent.EndIWeaponComponent(builder);
		}

		// Token: 0x060280AD RID: 164013 RVA: 0x00581574 File Offset: 0x0057F774
		public static void StartIWeaponComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060280AE RID: 164014 RVA: 0x0058157D File Offset: 0x0057F77D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060280AF RID: 164015 RVA: 0x00581588 File Offset: 0x0057F788
		public static void AddWeaponId(FlatBufferBuilder builder, int weaponId)
		{
			builder.AddInt(1, weaponId, 0);
		}

		// Token: 0x060280B0 RID: 164016 RVA: 0x00581593 File Offset: 0x0057F793
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060280B1 RID: 164017 RVA: 0x0058159E File Offset: 0x0057F79E
		public static Offset<IWeaponComponent> EndIWeaponComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponComponent>(builder.EndTable());
		}

		// Token: 0x060280B2 RID: 164018 RVA: 0x005815AC File Offset: 0x0057F7AC
		public IWeaponComponentT UnPack()
		{
			IWeaponComponentT weaponComponentT = new IWeaponComponentT();
			this.UnPackTo(weaponComponentT);
			return weaponComponentT;
		}

		// Token: 0x060280B3 RID: 164019 RVA: 0x005815C7 File Offset: 0x0057F7C7
		public void UnPackTo(IWeaponComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WeaponId = this.WeaponId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060280B4 RID: 164020 RVA: 0x005815F0 File Offset: 0x0057F7F0
		public static Offset<IWeaponComponent> Pack(FlatBufferBuilder builder, IWeaponComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponComponent>);
			}
			return IWeaponComponent.CreateIWeaponComponent(builder, _o.Disabled, _o.WeaponId, _o.NullMask);
		}

		// Token: 0x0400F2B6 RID: 62134
		private Table __p;
	}
}
