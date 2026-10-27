using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E18 RID: 24088
	public struct IOutAreaBorderEffectType : IFlatbufferObject
	{
		// Token: 0x1700B43A RID: 46138
		// (get) Token: 0x060293DE RID: 168926 RVA: 0x005A8409 File Offset: 0x005A6609
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293DF RID: 168927 RVA: 0x005A8416 File Offset: 0x005A6616
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293E0 RID: 168928 RVA: 0x005A8420 File Offset: 0x005A6620
		public static IOutAreaBorderEffectType GetRootAsIOutAreaBorderEffectType(ByteBuffer _bb)
		{
			return IOutAreaBorderEffectType.GetRootAsIOutAreaBorderEffectType(_bb, default(IOutAreaBorderEffectType));
		}

		// Token: 0x060293E1 RID: 168929 RVA: 0x005A843C File Offset: 0x005A663C
		public static IOutAreaBorderEffectType GetRootAsIOutAreaBorderEffectType(ByteBuffer _bb, IOutAreaBorderEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293E2 RID: 168930 RVA: 0x005A8459 File Offset: 0x005A6659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293E3 RID: 168931 RVA: 0x005A8468 File Offset: 0x005A6668
		public IOutAreaBorderEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B43B RID: 46139
		// (get) Token: 0x060293E4 RID: 168932 RVA: 0x005A8478 File Offset: 0x005A6678
		public EOutAreaBorderEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderEffectType.BuffId;
				}
				return (EOutAreaBorderEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060293E5 RID: 168933 RVA: 0x005A84B4 File Offset: 0x005A66B4
		public static Offset<IOutAreaBorderEffectType> CreateIOutAreaBorderEffectType(FlatBufferBuilder builder, EOutAreaBorderEffectType Type = EOutAreaBorderEffectType.BuffId)
		{
			builder.StartTable(1);
			IOutAreaBorderEffectType.AddType(builder, Type);
			return IOutAreaBorderEffectType.EndIOutAreaBorderEffectType(builder);
		}

		// Token: 0x060293E6 RID: 168934 RVA: 0x005A84CA File Offset: 0x005A66CA
		public static void StartIOutAreaBorderEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060293E7 RID: 168935 RVA: 0x005A84D3 File Offset: 0x005A66D3
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060293E8 RID: 168936 RVA: 0x005A84DE File Offset: 0x005A66DE
		public static Offset<IOutAreaBorderEffectType> EndIOutAreaBorderEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderEffectType>(builder.EndTable());
		}

		// Token: 0x060293E9 RID: 168937 RVA: 0x005A84EC File Offset: 0x005A66EC
		public IOutAreaBorderEffectTypeT UnPack()
		{
			IOutAreaBorderEffectTypeT outAreaBorderEffectTypeT = new IOutAreaBorderEffectTypeT();
			this.UnPackTo(outAreaBorderEffectTypeT);
			return outAreaBorderEffectTypeT;
		}

		// Token: 0x060293EA RID: 168938 RVA: 0x005A8507 File Offset: 0x005A6707
		public void UnPackTo(IOutAreaBorderEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060293EB RID: 168939 RVA: 0x005A8518 File Offset: 0x005A6718
		public static Offset<IOutAreaBorderEffectType> Pack(FlatBufferBuilder builder, IOutAreaBorderEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderEffectType>);
			}
			return IOutAreaBorderEffectType.CreateIOutAreaBorderEffectType(builder, _o.Type);
		}

		// Token: 0x0400F80D RID: 63501
		private Table __p;
	}
}
