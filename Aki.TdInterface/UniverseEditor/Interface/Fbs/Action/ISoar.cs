using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715D RID: 29021
	public struct ISoar : IFlatbufferObject
	{
		// Token: 0x1700D7A8 RID: 55208
		// (get) Token: 0x0603374C RID: 210764 RVA: 0x006EED0D File Offset: 0x006ECF0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603374D RID: 210765 RVA: 0x006EED1A File Offset: 0x006ECF1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603374E RID: 210766 RVA: 0x006EED24 File Offset: 0x006ECF24
		public static ISoar GetRootAsISoar(ByteBuffer _bb)
		{
			return ISoar.GetRootAsISoar(_bb, default(ISoar));
		}

		// Token: 0x0603374F RID: 210767 RVA: 0x006EED40 File Offset: 0x006ECF40
		public static ISoar GetRootAsISoar(ByteBuffer _bb, ISoar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033750 RID: 210768 RVA: 0x006EED5D File Offset: 0x006ECF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033751 RID: 210769 RVA: 0x006EED6C File Offset: 0x006ECF6C
		public ISoar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7A9 RID: 55209
		// (get) Token: 0x06033752 RID: 210770 RVA: 0x006EED7C File Offset: 0x006ECF7C
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

		// Token: 0x06033753 RID: 210771 RVA: 0x006EEDB8 File Offset: 0x006ECFB8
		public static Offset<ISoar> CreateISoar(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISoar.AddType(builder, Type);
			return ISoar.EndISoar(builder);
		}

		// Token: 0x06033754 RID: 210772 RVA: 0x006EEDCE File Offset: 0x006ECFCE
		public static void StartISoar(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033755 RID: 210773 RVA: 0x006EEDD7 File Offset: 0x006ECFD7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033756 RID: 210774 RVA: 0x006EEDE2 File Offset: 0x006ECFE2
		public static Offset<ISoar> EndISoar(FlatBufferBuilder builder)
		{
			return new Offset<ISoar>(builder.EndTable());
		}

		// Token: 0x06033757 RID: 210775 RVA: 0x006EEDF0 File Offset: 0x006ECFF0
		public ISoarT UnPack()
		{
			ISoarT soarT = new ISoarT();
			this.UnPackTo(soarT);
			return soarT;
		}

		// Token: 0x06033758 RID: 210776 RVA: 0x006EEE0B File Offset: 0x006ED00B
		public void UnPackTo(ISoarT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033759 RID: 210777 RVA: 0x006EEE1C File Offset: 0x006ED01C
		public static Offset<ISoar> Pack(FlatBufferBuilder builder, ISoarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoar>);
			}
			return ISoar.CreateISoar(builder, _o.Type);
		}

		// Token: 0x04011C03 RID: 72707
		private Table __p;
	}
}
