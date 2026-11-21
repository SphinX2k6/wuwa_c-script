using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E4 RID: 30948
	public struct ISitDown : IFlatbufferObject
	{
		// Token: 0x1700E31E RID: 58142
		// (get) Token: 0x060367EB RID: 223211 RVA: 0x0074BC28 File Offset: 0x00749E28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367EC RID: 223212 RVA: 0x0074BC35 File Offset: 0x00749E35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367ED RID: 223213 RVA: 0x0074BC3C File Offset: 0x00749E3C
		public static ISitDown GetRootAsISitDown(ByteBuffer _bb)
		{
			return ISitDown.GetRootAsISitDown(_bb, default(ISitDown));
		}

		// Token: 0x060367EE RID: 223214 RVA: 0x0074BC58 File Offset: 0x00749E58
		public static ISitDown GetRootAsISitDown(ByteBuffer _bb, ISitDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367EF RID: 223215 RVA: 0x0074BC75 File Offset: 0x00749E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367F0 RID: 223216 RVA: 0x0074BC84 File Offset: 0x00749E84
		public ISitDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E31F RID: 58143
		// (get) Token: 0x060367F1 RID: 223217 RVA: 0x0074BC94 File Offset: 0x00749E94
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E320 RID: 58144
		// (get) Token: 0x060367F2 RID: 223218 RVA: 0x0074BCD0 File Offset: 0x00749ED0
		public bool OnlyAllowForwardStandUp
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E321 RID: 58145
		// (get) Token: 0x060367F3 RID: 223219 RVA: 0x0074BD10 File Offset: 0x00749F10
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

		// Token: 0x060367F4 RID: 223220 RVA: 0x0074BD4C File Offset: 0x00749F4C
		public static Offset<ISitDown> CreateISitDown(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, bool OnlyAllowForwardStandUp = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISitDown.AddNullMask(builder, NullMask);
			ISitDown.AddOnlyAllowForwardStandUp(builder, OnlyAllowForwardStandUp);
			ISitDown.AddType(builder, Type);
			return ISitDown.EndISitDown(builder);
		}

		// Token: 0x060367F5 RID: 223221 RVA: 0x0074BD70 File Offset: 0x00749F70
		public static void StartISitDown(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060367F6 RID: 223222 RVA: 0x0074BD79 File Offset: 0x00749F79
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060367F7 RID: 223223 RVA: 0x0074BD84 File Offset: 0x00749F84
		public static void AddOnlyAllowForwardStandUp(FlatBufferBuilder builder, bool onlyAllowForwardStandUp)
		{
			builder.AddBool(1, onlyAllowForwardStandUp, false);
		}

		// Token: 0x060367F8 RID: 223224 RVA: 0x0074BD8F File Offset: 0x00749F8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060367F9 RID: 223225 RVA: 0x0074BD9A File Offset: 0x00749F9A
		public static Offset<ISitDown> EndISitDown(FlatBufferBuilder builder)
		{
			return new Offset<ISitDown>(builder.EndTable());
		}

		// Token: 0x060367FA RID: 223226 RVA: 0x0074BDA8 File Offset: 0x00749FA8
		public ISitDownT UnPack()
		{
			ISitDownT sitDownT = new ISitDownT();
			this.UnPackTo(sitDownT);
			return sitDownT;
		}

		// Token: 0x060367FB RID: 223227 RVA: 0x0074BDC3 File Offset: 0x00749FC3
		public void UnPackTo(ISitDownT _o)
		{
			_o.Type = this.Type;
			_o.OnlyAllowForwardStandUp = this.OnlyAllowForwardStandUp;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060367FC RID: 223228 RVA: 0x0074BDEC File Offset: 0x00749FEC
		public static Offset<ISitDown> Pack(FlatBufferBuilder builder, ISitDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISitDown>);
			}
			return ISitDown.CreateISitDown(builder, _o.Type, _o.OnlyAllowForwardStandUp, _o.NullMask);
		}

		// Token: 0x04012B98 RID: 76696
		private Table __p;
	}
}
