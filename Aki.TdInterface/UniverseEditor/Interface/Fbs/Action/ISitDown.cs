using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007118 RID: 28952
	public struct ISitDown : IFlatbufferObject
	{
		// Token: 0x1700D73B RID: 55099
		// (get) Token: 0x06033549 RID: 210249 RVA: 0x006EB61C File Offset: 0x006E981C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603354A RID: 210250 RVA: 0x006EB629 File Offset: 0x006E9829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603354B RID: 210251 RVA: 0x006EB630 File Offset: 0x006E9830
		public static ISitDown GetRootAsISitDown(ByteBuffer _bb)
		{
			return ISitDown.GetRootAsISitDown(_bb, default(ISitDown));
		}

		// Token: 0x0603354C RID: 210252 RVA: 0x006EB64C File Offset: 0x006E984C
		public static ISitDown GetRootAsISitDown(ByteBuffer _bb, ISitDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603354D RID: 210253 RVA: 0x006EB669 File Offset: 0x006E9869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603354E RID: 210254 RVA: 0x006EB678 File Offset: 0x006E9878
		public ISitDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D73C RID: 55100
		// (get) Token: 0x0603354F RID: 210255 RVA: 0x006EB688 File Offset: 0x006E9888
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

		// Token: 0x1700D73D RID: 55101
		// (get) Token: 0x06033550 RID: 210256 RVA: 0x006EB6C4 File Offset: 0x006E98C4
		public bool OnlyAllowForwardStandUp
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D73E RID: 55102
		// (get) Token: 0x06033551 RID: 210257 RVA: 0x006EB704 File Offset: 0x006E9904
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

		// Token: 0x06033552 RID: 210258 RVA: 0x006EB740 File Offset: 0x006E9940
		public static Offset<ISitDown> CreateISitDown(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, bool OnlyAllowForwardStandUp = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISitDown.AddNullMask(builder, NullMask);
			ISitDown.AddOnlyAllowForwardStandUp(builder, OnlyAllowForwardStandUp);
			ISitDown.AddType(builder, Type);
			return ISitDown.EndISitDown(builder);
		}

		// Token: 0x06033553 RID: 210259 RVA: 0x006EB764 File Offset: 0x006E9964
		public static void StartISitDown(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033554 RID: 210260 RVA: 0x006EB76D File Offset: 0x006E996D
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033555 RID: 210261 RVA: 0x006EB778 File Offset: 0x006E9978
		public static void AddOnlyAllowForwardStandUp(FlatBufferBuilder builder, bool onlyAllowForwardStandUp)
		{
			builder.AddBool(1, onlyAllowForwardStandUp, false);
		}

		// Token: 0x06033556 RID: 210262 RVA: 0x006EB783 File Offset: 0x006E9983
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033557 RID: 210263 RVA: 0x006EB78E File Offset: 0x006E998E
		public static Offset<ISitDown> EndISitDown(FlatBufferBuilder builder)
		{
			return new Offset<ISitDown>(builder.EndTable());
		}

		// Token: 0x06033558 RID: 210264 RVA: 0x006EB79C File Offset: 0x006E999C
		public ISitDownT UnPack()
		{
			ISitDownT sitDownT = new ISitDownT();
			this.UnPackTo(sitDownT);
			return sitDownT;
		}

		// Token: 0x06033559 RID: 210265 RVA: 0x006EB7B7 File Offset: 0x006E99B7
		public void UnPackTo(ISitDownT _o)
		{
			_o.Type = this.Type;
			_o.OnlyAllowForwardStandUp = this.OnlyAllowForwardStandUp;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603355A RID: 210266 RVA: 0x006EB7E0 File Offset: 0x006E99E0
		public static Offset<ISitDown> Pack(FlatBufferBuilder builder, ISitDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISitDown>);
			}
			return ISitDown.CreateISitDown(builder, _o.Type, _o.OnlyAllowForwardStandUp, _o.NullMask);
		}

		// Token: 0x04011BAA RID: 72618
		private Table __p;
	}
}
