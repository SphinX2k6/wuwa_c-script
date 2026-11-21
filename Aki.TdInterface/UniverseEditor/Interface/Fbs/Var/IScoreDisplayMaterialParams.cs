using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC5 RID: 16069
	public struct IScoreDisplayMaterialParams : IFlatbufferObject
	{
		// Token: 0x17006CD1 RID: 27857
		// (get) Token: 0x06015C02 RID: 89090 RVA: 0x00321530 File Offset: 0x0031F730
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C03 RID: 89091 RVA: 0x0032153D File Offset: 0x0031F73D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C04 RID: 89092 RVA: 0x00321544 File Offset: 0x0031F744
		public static IScoreDisplayMaterialParams GetRootAsIScoreDisplayMaterialParams(ByteBuffer _bb)
		{
			return IScoreDisplayMaterialParams.GetRootAsIScoreDisplayMaterialParams(_bb, default(IScoreDisplayMaterialParams));
		}

		// Token: 0x06015C05 RID: 89093 RVA: 0x00321560 File Offset: 0x0031F760
		public static IScoreDisplayMaterialParams GetRootAsIScoreDisplayMaterialParams(ByteBuffer _bb, IScoreDisplayMaterialParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C06 RID: 89094 RVA: 0x0032157D File Offset: 0x0031F77D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C07 RID: 89095 RVA: 0x0032158C File Offset: 0x0031F78C
		public IScoreDisplayMaterialParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CD2 RID: 27858
		// (get) Token: 0x06015C08 RID: 89096 RVA: 0x0032159C File Offset: 0x0031F79C
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006CD3 RID: 27859
		// (get) Token: 0x06015C09 RID: 89097 RVA: 0x003215D8 File Offset: 0x0031F7D8
		public IScoreDisplayParamsVar? ScoreDisplayParams
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IScoreDisplayParamsVar?(default(IScoreDisplayParamsVar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015C0A RID: 89098 RVA: 0x00321635 File Offset: 0x0031F835
		public static Offset<IScoreDisplayMaterialParams> CreateIScoreDisplayMaterialParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, Offset<IScoreDisplayParamsVar> ScoreDisplayParamsOffset = default(Offset<IScoreDisplayParamsVar>))
		{
			builder.StartTable(2);
			IScoreDisplayMaterialParams.AddScoreDisplayParams(builder, ScoreDisplayParamsOffset);
			IScoreDisplayMaterialParams.AddType(builder, Type);
			return IScoreDisplayMaterialParams.EndIScoreDisplayMaterialParams(builder);
		}

		// Token: 0x06015C0B RID: 89099 RVA: 0x00321652 File Offset: 0x0031F852
		public static void StartIScoreDisplayMaterialParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015C0C RID: 89100 RVA: 0x0032165B File Offset: 0x0031F85B
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C0D RID: 89101 RVA: 0x00321666 File Offset: 0x0031F866
		public static void AddScoreDisplayParams(FlatBufferBuilder builder, Offset<IScoreDisplayParamsVar> scoreDisplayParamsOffset)
		{
			builder.AddOffset(1, scoreDisplayParamsOffset.Value, 0);
		}

		// Token: 0x06015C0E RID: 89102 RVA: 0x00321676 File Offset: 0x0031F876
		public static Offset<IScoreDisplayMaterialParams> EndIScoreDisplayMaterialParams(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayMaterialParams>(builder.EndTable());
		}

		// Token: 0x06015C0F RID: 89103 RVA: 0x00321684 File Offset: 0x0031F884
		public IScoreDisplayMaterialParamsT UnPack()
		{
			IScoreDisplayMaterialParamsT scoreDisplayMaterialParamsT = new IScoreDisplayMaterialParamsT();
			this.UnPackTo(scoreDisplayMaterialParamsT);
			return scoreDisplayMaterialParamsT;
		}

		// Token: 0x06015C10 RID: 89104 RVA: 0x003216A0 File Offset: 0x0031F8A0
		public void UnPackTo(IScoreDisplayMaterialParamsT _o)
		{
			_o.Type = this.Type;
			_o.ScoreDisplayParams = ((this.ScoreDisplayParams != null) ? this.ScoreDisplayParams.Value.UnPack() : null);
		}

		// Token: 0x06015C11 RID: 89105 RVA: 0x003216E8 File Offset: 0x0031F8E8
		public static Offset<IScoreDisplayMaterialParams> Pack(FlatBufferBuilder builder, IScoreDisplayMaterialParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScoreDisplayMaterialParams>);
			}
			Offset<IScoreDisplayParamsVar> scoreDisplayParamsOffset = (_o.ScoreDisplayParams == null) ? default(Offset<IScoreDisplayParamsVar>) : IScoreDisplayParamsVar.Pack(builder, _o.ScoreDisplayParams);
			return IScoreDisplayMaterialParams.CreateIScoreDisplayMaterialParams(builder, _o.Type, scoreDisplayParamsOffset);
		}

		// Token: 0x0400B8D0 RID: 47312
		private Table __p;
	}
}
