using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006181 RID: 24961
	public struct IWeaponDamage : IFlatbufferObject
	{
		// Token: 0x1700BA16 RID: 47638
		// (get) Token: 0x0602A681 RID: 173697 RVA: 0x005C9150 File Offset: 0x005C7350
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A682 RID: 173698 RVA: 0x005C915D File Offset: 0x005C735D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A683 RID: 173699 RVA: 0x005C9164 File Offset: 0x005C7364
		public static IWeaponDamage GetRootAsIWeaponDamage(ByteBuffer _bb)
		{
			return IWeaponDamage.GetRootAsIWeaponDamage(_bb, default(IWeaponDamage));
		}

		// Token: 0x0602A684 RID: 173700 RVA: 0x005C9180 File Offset: 0x005C7380
		public static IWeaponDamage GetRootAsIWeaponDamage(ByteBuffer _bb, IWeaponDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A685 RID: 173701 RVA: 0x005C919D File Offset: 0x005C739D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A686 RID: 173702 RVA: 0x005C91AC File Offset: 0x005C73AC
		public IWeaponDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA17 RID: 47639
		// (get) Token: 0x0602A687 RID: 173703 RVA: 0x005C91BC File Offset: 0x005C73BC
		public int DefaultValue
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA18 RID: 47640
		// (get) Token: 0x0602A688 RID: 173704 RVA: 0x005C91F8 File Offset: 0x005C73F8
		public int GreatSword
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

		// Token: 0x1700BA19 RID: 47641
		// (get) Token: 0x0602A689 RID: 173705 RVA: 0x005C9234 File Offset: 0x005C7434
		public int Dagger
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA1A RID: 47642
		// (get) Token: 0x0602A68A RID: 173706 RVA: 0x005C9270 File Offset: 0x005C7470
		public int Pistol
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA1B RID: 47643
		// (get) Token: 0x0602A68B RID: 173707 RVA: 0x005C92B0 File Offset: 0x005C74B0
		public int Pugilism
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA1C RID: 47644
		// (get) Token: 0x0602A68C RID: 173708 RVA: 0x005C92F0 File Offset: 0x005C74F0
		public int Ring
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA1D RID: 47645
		// (get) Token: 0x0602A68D RID: 173709 RVA: 0x005C9330 File Offset: 0x005C7530
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

		// Token: 0x0602A68E RID: 173710 RVA: 0x005C9370 File Offset: 0x005C7570
		public static Offset<IWeaponDamage> CreateIWeaponDamage(FlatBufferBuilder builder, int DefaultValue = 0, int GreatSword = 0, int Dagger = 0, int Pistol = 0, int Pugilism = 0, int Ring = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IWeaponDamage.AddRing(builder, Ring);
			IWeaponDamage.AddPugilism(builder, Pugilism);
			IWeaponDamage.AddPistol(builder, Pistol);
			IWeaponDamage.AddDagger(builder, Dagger);
			IWeaponDamage.AddGreatSword(builder, GreatSword);
			IWeaponDamage.AddDefaultValue(builder, DefaultValue);
			IWeaponDamage.AddNullMask(builder, NullMask);
			return IWeaponDamage.EndIWeaponDamage(builder);
		}

		// Token: 0x0602A68F RID: 173711 RVA: 0x005C93BF File Offset: 0x005C75BF
		public static void StartIWeaponDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602A690 RID: 173712 RVA: 0x005C93C8 File Offset: 0x005C75C8
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x0602A691 RID: 173713 RVA: 0x005C93D3 File Offset: 0x005C75D3
		public static void AddGreatSword(FlatBufferBuilder builder, int greatSword)
		{
			builder.AddInt(1, greatSword, 0);
		}

		// Token: 0x0602A692 RID: 173714 RVA: 0x005C93DE File Offset: 0x005C75DE
		public static void AddDagger(FlatBufferBuilder builder, int dagger)
		{
			builder.AddInt(2, dagger, 0);
		}

		// Token: 0x0602A693 RID: 173715 RVA: 0x005C93E9 File Offset: 0x005C75E9
		public static void AddPistol(FlatBufferBuilder builder, int pistol)
		{
			builder.AddInt(3, pistol, 0);
		}

		// Token: 0x0602A694 RID: 173716 RVA: 0x005C93F4 File Offset: 0x005C75F4
		public static void AddPugilism(FlatBufferBuilder builder, int pugilism)
		{
			builder.AddInt(4, pugilism, 0);
		}

		// Token: 0x0602A695 RID: 173717 RVA: 0x005C93FF File Offset: 0x005C75FF
		public static void AddRing(FlatBufferBuilder builder, int ring)
		{
			builder.AddInt(5, ring, 0);
		}

		// Token: 0x0602A696 RID: 173718 RVA: 0x005C940A File Offset: 0x005C760A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602A697 RID: 173719 RVA: 0x005C9415 File Offset: 0x005C7615
		public static Offset<IWeaponDamage> EndIWeaponDamage(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponDamage>(builder.EndTable());
		}

		// Token: 0x0602A698 RID: 173720 RVA: 0x005C9424 File Offset: 0x005C7624
		public IWeaponDamageT UnPack()
		{
			IWeaponDamageT weaponDamageT = new IWeaponDamageT();
			this.UnPackTo(weaponDamageT);
			return weaponDamageT;
		}

		// Token: 0x0602A699 RID: 173721 RVA: 0x005C9440 File Offset: 0x005C7640
		public void UnPackTo(IWeaponDamageT _o)
		{
			_o.DefaultValue = this.DefaultValue;
			_o.GreatSword = this.GreatSword;
			_o.Dagger = this.Dagger;
			_o.Pistol = this.Pistol;
			_o.Pugilism = this.Pugilism;
			_o.Ring = this.Ring;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A69A RID: 173722 RVA: 0x005C94A4 File Offset: 0x005C76A4
		public static Offset<IWeaponDamage> Pack(FlatBufferBuilder builder, IWeaponDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponDamage>);
			}
			return IWeaponDamage.CreateIWeaponDamage(builder, _o.DefaultValue, _o.GreatSword, _o.Dagger, _o.Pistol, _o.Pugilism, _o.Ring, _o.NullMask);
		}

		// Token: 0x0400FFC0 RID: 65472
		private Table __p;
	}
}
