using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A6 RID: 22182
	public struct IElementDamage : IFlatbufferObject
	{
		// Token: 0x17009F8F RID: 40847
		// (get) Token: 0x06023838 RID: 145464 RVA: 0x004E2893 File Offset: 0x004E0A93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023839 RID: 145465 RVA: 0x004E28A0 File Offset: 0x004E0AA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602383A RID: 145466 RVA: 0x004E28A8 File Offset: 0x004E0AA8
		public static IElementDamage GetRootAsIElementDamage(ByteBuffer _bb)
		{
			return IElementDamage.GetRootAsIElementDamage(_bb, default(IElementDamage));
		}

		// Token: 0x0602383B RID: 145467 RVA: 0x004E28C4 File Offset: 0x004E0AC4
		public static IElementDamage GetRootAsIElementDamage(ByteBuffer _bb, IElementDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602383C RID: 145468 RVA: 0x004E28E1 File Offset: 0x004E0AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602383D RID: 145469 RVA: 0x004E28F0 File Offset: 0x004E0AF0
		public IElementDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F90 RID: 40848
		// (get) Token: 0x0602383E RID: 145470 RVA: 0x004E2900 File Offset: 0x004E0B00
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

		// Token: 0x17009F91 RID: 40849
		// (get) Token: 0x0602383F RID: 145471 RVA: 0x004E293C File Offset: 0x004E0B3C
		public int Physics
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

		// Token: 0x17009F92 RID: 40850
		// (get) Token: 0x06023840 RID: 145472 RVA: 0x004E2978 File Offset: 0x004E0B78
		public int Ice
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

		// Token: 0x17009F93 RID: 40851
		// (get) Token: 0x06023841 RID: 145473 RVA: 0x004E29B4 File Offset: 0x004E0BB4
		public int Fire
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

		// Token: 0x17009F94 RID: 40852
		// (get) Token: 0x06023842 RID: 145474 RVA: 0x004E29F4 File Offset: 0x004E0BF4
		public int Thunder
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

		// Token: 0x17009F95 RID: 40853
		// (get) Token: 0x06023843 RID: 145475 RVA: 0x004E2A34 File Offset: 0x004E0C34
		public int Wind
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

		// Token: 0x17009F96 RID: 40854
		// (get) Token: 0x06023844 RID: 145476 RVA: 0x004E2A74 File Offset: 0x004E0C74
		public int Light
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F97 RID: 40855
		// (get) Token: 0x06023845 RID: 145477 RVA: 0x004E2AB4 File Offset: 0x004E0CB4
		public int Dark
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F98 RID: 40856
		// (get) Token: 0x06023846 RID: 145478 RVA: 0x004E2AF4 File Offset: 0x004E0CF4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023847 RID: 145479 RVA: 0x004E2B34 File Offset: 0x004E0D34
		public static Offset<IElementDamage> CreateIElementDamage(FlatBufferBuilder builder, int DefaultValue = 0, int Physics = 0, int Ice = 0, int Fire = 0, int Thunder = 0, int Wind = 0, int Light = 0, int Dark = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IElementDamage.AddDark(builder, Dark);
			IElementDamage.AddLight(builder, Light);
			IElementDamage.AddWind(builder, Wind);
			IElementDamage.AddThunder(builder, Thunder);
			IElementDamage.AddFire(builder, Fire);
			IElementDamage.AddIce(builder, Ice);
			IElementDamage.AddPhysics(builder, Physics);
			IElementDamage.AddDefaultValue(builder, DefaultValue);
			IElementDamage.AddNullMask(builder, NullMask);
			return IElementDamage.EndIElementDamage(builder);
		}

		// Token: 0x06023848 RID: 145480 RVA: 0x004E2B94 File Offset: 0x004E0D94
		public static void StartIElementDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06023849 RID: 145481 RVA: 0x004E2B9E File Offset: 0x004E0D9E
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x0602384A RID: 145482 RVA: 0x004E2BA9 File Offset: 0x004E0DA9
		public static void AddPhysics(FlatBufferBuilder builder, int physics)
		{
			builder.AddInt(1, physics, 0);
		}

		// Token: 0x0602384B RID: 145483 RVA: 0x004E2BB4 File Offset: 0x004E0DB4
		public static void AddIce(FlatBufferBuilder builder, int ice)
		{
			builder.AddInt(2, ice, 0);
		}

		// Token: 0x0602384C RID: 145484 RVA: 0x004E2BBF File Offset: 0x004E0DBF
		public static void AddFire(FlatBufferBuilder builder, int fire)
		{
			builder.AddInt(3, fire, 0);
		}

		// Token: 0x0602384D RID: 145485 RVA: 0x004E2BCA File Offset: 0x004E0DCA
		public static void AddThunder(FlatBufferBuilder builder, int thunder)
		{
			builder.AddInt(4, thunder, 0);
		}

		// Token: 0x0602384E RID: 145486 RVA: 0x004E2BD5 File Offset: 0x004E0DD5
		public static void AddWind(FlatBufferBuilder builder, int wind)
		{
			builder.AddInt(5, wind, 0);
		}

		// Token: 0x0602384F RID: 145487 RVA: 0x004E2BE0 File Offset: 0x004E0DE0
		public static void AddLight(FlatBufferBuilder builder, int light)
		{
			builder.AddInt(6, light, 0);
		}

		// Token: 0x06023850 RID: 145488 RVA: 0x004E2BEB File Offset: 0x004E0DEB
		public static void AddDark(FlatBufferBuilder builder, int dark)
		{
			builder.AddInt(7, dark, 0);
		}

		// Token: 0x06023851 RID: 145489 RVA: 0x004E2BF6 File Offset: 0x004E0DF6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06023852 RID: 145490 RVA: 0x004E2C01 File Offset: 0x004E0E01
		public static Offset<IElementDamage> EndIElementDamage(FlatBufferBuilder builder)
		{
			return new Offset<IElementDamage>(builder.EndTable());
		}

		// Token: 0x06023853 RID: 145491 RVA: 0x004E2C10 File Offset: 0x004E0E10
		public IElementDamageT UnPack()
		{
			IElementDamageT elementDamageT = new IElementDamageT();
			this.UnPackTo(elementDamageT);
			return elementDamageT;
		}

		// Token: 0x06023854 RID: 145492 RVA: 0x004E2C2C File Offset: 0x004E0E2C
		public void UnPackTo(IElementDamageT _o)
		{
			_o.DefaultValue = this.DefaultValue;
			_o.Physics = this.Physics;
			_o.Ice = this.Ice;
			_o.Fire = this.Fire;
			_o.Thunder = this.Thunder;
			_o.Wind = this.Wind;
			_o.Light = this.Light;
			_o.Dark = this.Dark;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023855 RID: 145493 RVA: 0x004E2CA8 File Offset: 0x004E0EA8
		public static Offset<IElementDamage> Pack(FlatBufferBuilder builder, IElementDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementDamage>);
			}
			return IElementDamage.CreateIElementDamage(builder, _o.DefaultValue, _o.Physics, _o.Ice, _o.Fire, _o.Thunder, _o.Wind, _o.Light, _o.Dark, _o.NullMask);
		}

		// Token: 0x0400EDCF RID: 60879
		private Table __p;
	}
}
