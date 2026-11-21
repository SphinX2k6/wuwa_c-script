using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC8 RID: 16072
	public struct IScoreDisplayParams : IFlatbufferObject
	{
		// Token: 0x17006CD6 RID: 27862
		// (get) Token: 0x06015C18 RID: 89112 RVA: 0x003217BC File Offset: 0x0031F9BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C19 RID: 89113 RVA: 0x003217C9 File Offset: 0x0031F9C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C1A RID: 89114 RVA: 0x003217D0 File Offset: 0x0031F9D0
		public static IScoreDisplayParams GetRootAsIScoreDisplayParams(ByteBuffer _bb)
		{
			return IScoreDisplayParams.GetRootAsIScoreDisplayParams(_bb, default(IScoreDisplayParams));
		}

		// Token: 0x06015C1B RID: 89115 RVA: 0x003217EC File Offset: 0x0031F9EC
		public static IScoreDisplayParams GetRootAsIScoreDisplayParams(ByteBuffer _bb, IScoreDisplayParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C1C RID: 89116 RVA: 0x00321809 File Offset: 0x0031FA09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C1D RID: 89117 RVA: 0x00321818 File Offset: 0x0031FA18
		public IScoreDisplayParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CD7 RID: 27863
		// (get) Token: 0x06015C1E RID: 89118 RVA: 0x00321828 File Offset: 0x0031FA28
		public EScoreDisplayDataSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScoreDisplayDataSource.Var;
				}
				return (EScoreDisplayDataSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015C1F RID: 89119 RVA: 0x00321864 File Offset: 0x0031FA64
		public static Offset<IScoreDisplayParams> CreateIScoreDisplayParams(FlatBufferBuilder builder, EScoreDisplayDataSource Type = EScoreDisplayDataSource.Var)
		{
			builder.StartTable(1);
			IScoreDisplayParams.AddType(builder, Type);
			return IScoreDisplayParams.EndIScoreDisplayParams(builder);
		}

		// Token: 0x06015C20 RID: 89120 RVA: 0x0032187A File Offset: 0x0031FA7A
		public static void StartIScoreDisplayParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015C21 RID: 89121 RVA: 0x00321883 File Offset: 0x0031FA83
		public static void AddType(FlatBufferBuilder builder, EScoreDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C22 RID: 89122 RVA: 0x0032188E File Offset: 0x0031FA8E
		public static Offset<IScoreDisplayParams> EndIScoreDisplayParams(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayParams>(builder.EndTable());
		}

		// Token: 0x06015C23 RID: 89123 RVA: 0x0032189C File Offset: 0x0031FA9C
		public IScoreDisplayParamsT UnPack()
		{
			IScoreDisplayParamsT scoreDisplayParamsT = new IScoreDisplayParamsT();
			this.UnPackTo(scoreDisplayParamsT);
			return scoreDisplayParamsT;
		}

		// Token: 0x06015C24 RID: 89124 RVA: 0x003218B7 File Offset: 0x0031FAB7
		public void UnPackTo(IScoreDisplayParamsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015C25 RID: 89125 RVA: 0x003218C8 File Offset: 0x0031FAC8
		public static Offset<IScoreDisplayParams> Pack(FlatBufferBuilder builder, IScoreDisplayParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScoreDisplayParams>);
			}
			return IScoreDisplayParams.CreateIScoreDisplayParams(builder, _o.Type);
		}

		// Token: 0x0400B8D3 RID: 47315
		private Table __p;
	}
}
