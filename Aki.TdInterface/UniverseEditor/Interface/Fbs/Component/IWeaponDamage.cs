using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6B RID: 23403
	public struct IWeaponDamage : IFlatbufferObject
	{
		// Token: 0x1700B0CE RID: 45262
		// (get) Token: 0x060280BD RID: 164029 RVA: 0x005816C0 File Offset: 0x0057F8C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280BE RID: 164030 RVA: 0x005816CD File Offset: 0x0057F8CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280BF RID: 164031 RVA: 0x005816D4 File Offset: 0x0057F8D4
		public static IWeaponDamage GetRootAsIWeaponDamage(ByteBuffer _bb)
		{
			return IWeaponDamage.GetRootAsIWeaponDamage(_bb, default(IWeaponDamage));
		}

		// Token: 0x060280C0 RID: 164032 RVA: 0x005816F0 File Offset: 0x0057F8F0
		public static IWeaponDamage GetRootAsIWeaponDamage(ByteBuffer _bb, IWeaponDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280C1 RID: 164033 RVA: 0x0058170D File Offset: 0x0057F90D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280C2 RID: 164034 RVA: 0x0058171C File Offset: 0x0057F91C
		public IWeaponDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0CF RID: 45263
		// (get) Token: 0x060280C3 RID: 164035 RVA: 0x0058172C File Offset: 0x0057F92C
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

		// Token: 0x1700B0D0 RID: 45264
		// (get) Token: 0x060280C4 RID: 164036 RVA: 0x00581768 File Offset: 0x0057F968
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

		// Token: 0x1700B0D1 RID: 45265
		// (get) Token: 0x060280C5 RID: 164037 RVA: 0x005817A4 File Offset: 0x0057F9A4
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

		// Token: 0x1700B0D2 RID: 45266
		// (get) Token: 0x060280C6 RID: 164038 RVA: 0x005817E0 File Offset: 0x0057F9E0
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

		// Token: 0x1700B0D3 RID: 45267
		// (get) Token: 0x060280C7 RID: 164039 RVA: 0x00581820 File Offset: 0x0057FA20
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

		// Token: 0x1700B0D4 RID: 45268
		// (get) Token: 0x060280C8 RID: 164040 RVA: 0x00581860 File Offset: 0x0057FA60
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

		// Token: 0x1700B0D5 RID: 45269
		// (get) Token: 0x060280C9 RID: 164041 RVA: 0x005818A0 File Offset: 0x0057FAA0
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

		// Token: 0x060280CA RID: 164042 RVA: 0x005818E0 File Offset: 0x0057FAE0
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

		// Token: 0x060280CB RID: 164043 RVA: 0x0058192F File Offset: 0x0057FB2F
		public static void StartIWeaponDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060280CC RID: 164044 RVA: 0x00581938 File Offset: 0x0057FB38
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x060280CD RID: 164045 RVA: 0x00581943 File Offset: 0x0057FB43
		public static void AddGreatSword(FlatBufferBuilder builder, int greatSword)
		{
			builder.AddInt(1, greatSword, 0);
		}

		// Token: 0x060280CE RID: 164046 RVA: 0x0058194E File Offset: 0x0057FB4E
		public static void AddDagger(FlatBufferBuilder builder, int dagger)
		{
			builder.AddInt(2, dagger, 0);
		}

		// Token: 0x060280CF RID: 164047 RVA: 0x00581959 File Offset: 0x0057FB59
		public static void AddPistol(FlatBufferBuilder builder, int pistol)
		{
			builder.AddInt(3, pistol, 0);
		}

		// Token: 0x060280D0 RID: 164048 RVA: 0x00581964 File Offset: 0x0057FB64
		public static void AddPugilism(FlatBufferBuilder builder, int pugilism)
		{
			builder.AddInt(4, pugilism, 0);
		}

		// Token: 0x060280D1 RID: 164049 RVA: 0x0058196F File Offset: 0x0057FB6F
		public static void AddRing(FlatBufferBuilder builder, int ring)
		{
			builder.AddInt(5, ring, 0);
		}

		// Token: 0x060280D2 RID: 164050 RVA: 0x0058197A File Offset: 0x0057FB7A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060280D3 RID: 164051 RVA: 0x00581985 File Offset: 0x0057FB85
		public static Offset<IWeaponDamage> EndIWeaponDamage(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponDamage>(builder.EndTable());
		}

		// Token: 0x060280D4 RID: 164052 RVA: 0x00581994 File Offset: 0x0057FB94
		public IWeaponDamageT UnPack()
		{
			IWeaponDamageT weaponDamageT = new IWeaponDamageT();
			this.UnPackTo(weaponDamageT);
			return weaponDamageT;
		}

		// Token: 0x060280D5 RID: 164053 RVA: 0x005819B0 File Offset: 0x0057FBB0
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

		// Token: 0x060280D6 RID: 164054 RVA: 0x00581A14 File Offset: 0x0057FC14
		public static Offset<IWeaponDamage> Pack(FlatBufferBuilder builder, IWeaponDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponDamage>);
			}
			return IWeaponDamage.CreateIWeaponDamage(builder, _o.DefaultValue, _o.GreatSword, _o.Dagger, _o.Pistol, _o.Pugilism, _o.Ring, _o.NullMask);
		}

		// Token: 0x0400F2BA RID: 62138
		private Table __p;
	}
}
