using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005141 RID: 20801
	public struct IElementDamage : IFlatbufferObject
	{
		// Token: 0x170097A2 RID: 38818
		// (get) Token: 0x060218E4 RID: 137444 RVA: 0x004A8907 File Offset: 0x004A6B07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060218E5 RID: 137445 RVA: 0x004A8914 File Offset: 0x004A6B14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060218E6 RID: 137446 RVA: 0x004A891C File Offset: 0x004A6B1C
		public static IElementDamage GetRootAsIElementDamage(ByteBuffer _bb)
		{
			return IElementDamage.GetRootAsIElementDamage(_bb, default(IElementDamage));
		}

		// Token: 0x060218E7 RID: 137447 RVA: 0x004A8938 File Offset: 0x004A6B38
		public static IElementDamage GetRootAsIElementDamage(ByteBuffer _bb, IElementDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060218E8 RID: 137448 RVA: 0x004A8955 File Offset: 0x004A6B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060218E9 RID: 137449 RVA: 0x004A8964 File Offset: 0x004A6B64
		public IElementDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097A3 RID: 38819
		// (get) Token: 0x060218EA RID: 137450 RVA: 0x004A8974 File Offset: 0x004A6B74
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

		// Token: 0x170097A4 RID: 38820
		// (get) Token: 0x060218EB RID: 137451 RVA: 0x004A89B0 File Offset: 0x004A6BB0
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

		// Token: 0x170097A5 RID: 38821
		// (get) Token: 0x060218EC RID: 137452 RVA: 0x004A89EC File Offset: 0x004A6BEC
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

		// Token: 0x170097A6 RID: 38822
		// (get) Token: 0x060218ED RID: 137453 RVA: 0x004A8A28 File Offset: 0x004A6C28
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

		// Token: 0x170097A7 RID: 38823
		// (get) Token: 0x060218EE RID: 137454 RVA: 0x004A8A68 File Offset: 0x004A6C68
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

		// Token: 0x170097A8 RID: 38824
		// (get) Token: 0x060218EF RID: 137455 RVA: 0x004A8AA8 File Offset: 0x004A6CA8
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

		// Token: 0x170097A9 RID: 38825
		// (get) Token: 0x060218F0 RID: 137456 RVA: 0x004A8AE8 File Offset: 0x004A6CE8
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

		// Token: 0x170097AA RID: 38826
		// (get) Token: 0x060218F1 RID: 137457 RVA: 0x004A8B28 File Offset: 0x004A6D28
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

		// Token: 0x170097AB RID: 38827
		// (get) Token: 0x060218F2 RID: 137458 RVA: 0x004A8B68 File Offset: 0x004A6D68
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

		// Token: 0x060218F3 RID: 137459 RVA: 0x004A8BA8 File Offset: 0x004A6DA8
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

		// Token: 0x060218F4 RID: 137460 RVA: 0x004A8C08 File Offset: 0x004A6E08
		public static void StartIElementDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060218F5 RID: 137461 RVA: 0x004A8C12 File Offset: 0x004A6E12
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x060218F6 RID: 137462 RVA: 0x004A8C1D File Offset: 0x004A6E1D
		public static void AddPhysics(FlatBufferBuilder builder, int physics)
		{
			builder.AddInt(1, physics, 0);
		}

		// Token: 0x060218F7 RID: 137463 RVA: 0x004A8C28 File Offset: 0x004A6E28
		public static void AddIce(FlatBufferBuilder builder, int ice)
		{
			builder.AddInt(2, ice, 0);
		}

		// Token: 0x060218F8 RID: 137464 RVA: 0x004A8C33 File Offset: 0x004A6E33
		public static void AddFire(FlatBufferBuilder builder, int fire)
		{
			builder.AddInt(3, fire, 0);
		}

		// Token: 0x060218F9 RID: 137465 RVA: 0x004A8C3E File Offset: 0x004A6E3E
		public static void AddThunder(FlatBufferBuilder builder, int thunder)
		{
			builder.AddInt(4, thunder, 0);
		}

		// Token: 0x060218FA RID: 137466 RVA: 0x004A8C49 File Offset: 0x004A6E49
		public static void AddWind(FlatBufferBuilder builder, int wind)
		{
			builder.AddInt(5, wind, 0);
		}

		// Token: 0x060218FB RID: 137467 RVA: 0x004A8C54 File Offset: 0x004A6E54
		public static void AddLight(FlatBufferBuilder builder, int light)
		{
			builder.AddInt(6, light, 0);
		}

		// Token: 0x060218FC RID: 137468 RVA: 0x004A8C5F File Offset: 0x004A6E5F
		public static void AddDark(FlatBufferBuilder builder, int dark)
		{
			builder.AddInt(7, dark, 0);
		}

		// Token: 0x060218FD RID: 137469 RVA: 0x004A8C6A File Offset: 0x004A6E6A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060218FE RID: 137470 RVA: 0x004A8C75 File Offset: 0x004A6E75
		public static Offset<IElementDamage> EndIElementDamage(FlatBufferBuilder builder)
		{
			return new Offset<IElementDamage>(builder.EndTable());
		}

		// Token: 0x060218FF RID: 137471 RVA: 0x004A8C84 File Offset: 0x004A6E84
		public IElementDamageT UnPack()
		{
			IElementDamageT elementDamageT = new IElementDamageT();
			this.UnPackTo(elementDamageT);
			return elementDamageT;
		}

		// Token: 0x06021900 RID: 137472 RVA: 0x004A8CA0 File Offset: 0x004A6EA0
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

		// Token: 0x06021901 RID: 137473 RVA: 0x004A8D1C File Offset: 0x004A6F1C
		public static Offset<IElementDamage> Pack(FlatBufferBuilder builder, IElementDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementDamage>);
			}
			return IElementDamage.CreateIElementDamage(builder, _o.DefaultValue, _o.Physics, _o.Ice, _o.Fire, _o.Thunder, _o.Wind, _o.Light, _o.Dark, _o.NullMask);
		}

		// Token: 0x0400E1D2 RID: 57810
		private Table __p;
	}
}
