using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC7 RID: 24007
	public struct IQteType : IFlatbufferObject
	{
		// Token: 0x1700B0CE RID: 45262
		// (get) Token: 0x06028060 RID: 163936 RVA: 0x005794B8 File Offset: 0x005776B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028061 RID: 163937 RVA: 0x005794C5 File Offset: 0x005776C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028062 RID: 163938 RVA: 0x005794CC File Offset: 0x005776CC
		public static IQteType GetRootAsIQteType(ByteBuffer _bb)
		{
			return IQteType.GetRootAsIQteType(_bb, default(IQteType));
		}

		// Token: 0x06028063 RID: 163939 RVA: 0x005794E8 File Offset: 0x005776E8
		public static IQteType GetRootAsIQteType(ByteBuffer _bb, IQteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028064 RID: 163940 RVA: 0x00579505 File Offset: 0x00577705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028065 RID: 163941 RVA: 0x00579514 File Offset: 0x00577714
		public IQteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0CF RID: 45263
		// (get) Token: 0x06028066 RID: 163942 RVA: 0x00579524 File Offset: 0x00577724
		public EQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQteType.SingleBtn;
				}
				return (EQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0D0 RID: 45264
		// (get) Token: 0x06028067 RID: 163943 RVA: 0x00579560 File Offset: 0x00577760
		public int QteId
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

		// Token: 0x06028068 RID: 163944 RVA: 0x0057959C File Offset: 0x0057779C
		public static Offset<IQteType> CreateIQteType(FlatBufferBuilder builder, EQteType Type = EQteType.SingleBtn, int QteId = 0)
		{
			builder.StartTable(2);
			IQteType.AddQteId(builder, QteId);
			IQteType.AddType(builder, Type);
			return IQteType.EndIQteType(builder);
		}

		// Token: 0x06028069 RID: 163945 RVA: 0x005795B9 File Offset: 0x005777B9
		public static void StartIQteType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602806A RID: 163946 RVA: 0x005795C2 File Offset: 0x005777C2
		public static void AddType(FlatBufferBuilder builder, EQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602806B RID: 163947 RVA: 0x005795CD File Offset: 0x005777CD
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(1, qteId, 0);
		}

		// Token: 0x0602806C RID: 163948 RVA: 0x005795D8 File Offset: 0x005777D8
		public static Offset<IQteType> EndIQteType(FlatBufferBuilder builder)
		{
			return new Offset<IQteType>(builder.EndTable());
		}

		// Token: 0x0602806D RID: 163949 RVA: 0x005795E8 File Offset: 0x005777E8
		public IQteTypeT UnPack()
		{
			IQteTypeT qteTypeT = new IQteTypeT();
			this.UnPackTo(qteTypeT);
			return qteTypeT;
		}

		// Token: 0x0602806E RID: 163950 RVA: 0x00579603 File Offset: 0x00577803
		public void UnPackTo(IQteTypeT _o)
		{
			_o.Type = this.Type;
			_o.QteId = this.QteId;
		}

		// Token: 0x0602806F RID: 163951 RVA: 0x00579620 File Offset: 0x00577820
		public static Offset<IQteType> Pack(FlatBufferBuilder builder, IQteTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQteType>);
			}
			return IQteType.CreateIQteType(builder, _o.Type, _o.QteId);
		}

		// Token: 0x0400F984 RID: 63876
		private Table __p;
	}
}
