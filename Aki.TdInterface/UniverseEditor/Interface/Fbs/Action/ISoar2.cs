using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007160 RID: 29024
	public struct ISoar2 : IFlatbufferObject
	{
		// Token: 0x1700D7AB RID: 55211
		// (get) Token: 0x0603375E RID: 210782 RVA: 0x006EEE85 File Offset: 0x006ED085
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603375F RID: 210783 RVA: 0x006EEE92 File Offset: 0x006ED092
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033760 RID: 210784 RVA: 0x006EEE9C File Offset: 0x006ED09C
		public static ISoar2 GetRootAsISoar2(ByteBuffer _bb)
		{
			return ISoar2.GetRootAsISoar2(_bb, default(ISoar2));
		}

		// Token: 0x06033761 RID: 210785 RVA: 0x006EEEB8 File Offset: 0x006ED0B8
		public static ISoar2 GetRootAsISoar2(ByteBuffer _bb, ISoar2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033762 RID: 210786 RVA: 0x006EEED5 File Offset: 0x006ED0D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033763 RID: 210787 RVA: 0x006EEEE4 File Offset: 0x006ED0E4
		public ISoar2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7AC RID: 55212
		// (get) Token: 0x06033764 RID: 210788 RVA: 0x006EEEF4 File Offset: 0x006ED0F4
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

		// Token: 0x06033765 RID: 210789 RVA: 0x006EEF30 File Offset: 0x006ED130
		public static Offset<ISoar2> CreateISoar2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISoar2.AddType(builder, Type);
			return ISoar2.EndISoar2(builder);
		}

		// Token: 0x06033766 RID: 210790 RVA: 0x006EEF46 File Offset: 0x006ED146
		public static void StartISoar2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033767 RID: 210791 RVA: 0x006EEF4F File Offset: 0x006ED14F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033768 RID: 210792 RVA: 0x006EEF5A File Offset: 0x006ED15A
		public static Offset<ISoar2> EndISoar2(FlatBufferBuilder builder)
		{
			return new Offset<ISoar2>(builder.EndTable());
		}

		// Token: 0x06033769 RID: 210793 RVA: 0x006EEF68 File Offset: 0x006ED168
		public ISoar2T UnPack()
		{
			ISoar2T soar2T = new ISoar2T();
			this.UnPackTo(soar2T);
			return soar2T;
		}

		// Token: 0x0603376A RID: 210794 RVA: 0x006EEF83 File Offset: 0x006ED183
		public void UnPackTo(ISoar2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603376B RID: 210795 RVA: 0x006EEF94 File Offset: 0x006ED194
		public static Offset<ISoar2> Pack(FlatBufferBuilder builder, ISoar2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoar2>);
			}
			return ISoar2.CreateISoar2(builder, _o.Type);
		}

		// Token: 0x04011C05 RID: 72709
		private Table __p;
	}
}
