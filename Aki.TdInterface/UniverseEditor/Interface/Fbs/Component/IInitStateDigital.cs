using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005422 RID: 21538
	public struct IInitStateDigital : IFlatbufferObject
	{
		// Token: 0x17009E6C RID: 40556
		// (get) Token: 0x060235F9 RID: 144889 RVA: 0x004E5155 File Offset: 0x004E3355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235FA RID: 144890 RVA: 0x004E5162 File Offset: 0x004E3362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235FB RID: 144891 RVA: 0x004E516C File Offset: 0x004E336C
		public static IInitStateDigital GetRootAsIInitStateDigital(ByteBuffer _bb)
		{
			return IInitStateDigital.GetRootAsIInitStateDigital(_bb, default(IInitStateDigital));
		}

		// Token: 0x060235FC RID: 144892 RVA: 0x004E5188 File Offset: 0x004E3388
		public static IInitStateDigital GetRootAsIInitStateDigital(ByteBuffer _bb, IInitStateDigital obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235FD RID: 144893 RVA: 0x004E51A5 File Offset: 0x004E33A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235FE RID: 144894 RVA: 0x004E51B4 File Offset: 0x004E33B4
		public IInitStateDigital __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E6D RID: 40557
		// (get) Token: 0x060235FF RID: 144895 RVA: 0x004E51C4 File Offset: 0x004E33C4
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023600 RID: 144896 RVA: 0x004E5200 File Offset: 0x004E3400
		public static Offset<IInitStateDigital> CreateIInitStateDigital(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateDigital.AddType(builder, Type);
			return IInitStateDigital.EndIInitStateDigital(builder);
		}

		// Token: 0x06023601 RID: 144897 RVA: 0x004E5216 File Offset: 0x004E3416
		public static void StartIInitStateDigital(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023602 RID: 144898 RVA: 0x004E521F File Offset: 0x004E341F
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023603 RID: 144899 RVA: 0x004E522A File Offset: 0x004E342A
		public static Offset<IInitStateDigital> EndIInitStateDigital(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateDigital>(builder.EndTable());
		}

		// Token: 0x06023604 RID: 144900 RVA: 0x004E5238 File Offset: 0x004E3438
		public IInitStateDigitalT UnPack()
		{
			IInitStateDigitalT initStateDigitalT = new IInitStateDigitalT();
			this.UnPackTo(initStateDigitalT);
			return initStateDigitalT;
		}

		// Token: 0x06023605 RID: 144901 RVA: 0x004E5253 File Offset: 0x004E3453
		public void UnPackTo(IInitStateDigitalT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023606 RID: 144902 RVA: 0x004E5264 File Offset: 0x004E3464
		public static Offset<IInitStateDigital> Pack(FlatBufferBuilder builder, IInitStateDigitalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateDigital>);
			}
			return IInitStateDigital.CreateIInitStateDigital(builder, _o.Type);
		}

		// Token: 0x0400E66C RID: 58988
		private Table __p;
	}
}
