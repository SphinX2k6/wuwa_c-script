using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC3 RID: 15043
	public struct IScoreDisplayMaterialParams : IFlatbufferObject
	{
		// Token: 0x17006736 RID: 26422
		// (get) Token: 0x06014758 RID: 83800 RVA: 0x002FB2A0 File Offset: 0x002F94A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014759 RID: 83801 RVA: 0x002FB2AD File Offset: 0x002F94AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601475A RID: 83802 RVA: 0x002FB2B4 File Offset: 0x002F94B4
		public static IScoreDisplayMaterialParams GetRootAsIScoreDisplayMaterialParams(ByteBuffer _bb)
		{
			return IScoreDisplayMaterialParams.GetRootAsIScoreDisplayMaterialParams(_bb, default(IScoreDisplayMaterialParams));
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x002FB2D0 File Offset: 0x002F94D0
		public static IScoreDisplayMaterialParams GetRootAsIScoreDisplayMaterialParams(ByteBuffer _bb, IScoreDisplayMaterialParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601475C RID: 83804 RVA: 0x002FB2ED File Offset: 0x002F94ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601475D RID: 83805 RVA: 0x002FB2FC File Offset: 0x002F94FC
		public IScoreDisplayMaterialParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006737 RID: 26423
		// (get) Token: 0x0601475E RID: 83806 RVA: 0x002FB30C File Offset: 0x002F950C
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

		// Token: 0x17006738 RID: 26424
		// (get) Token: 0x0601475F RID: 83807 RVA: 0x002FB348 File Offset: 0x002F9548
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

		// Token: 0x06014760 RID: 83808 RVA: 0x002FB3A5 File Offset: 0x002F95A5
		public static Offset<IScoreDisplayMaterialParams> CreateIScoreDisplayMaterialParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, Offset<IScoreDisplayParamsVar> ScoreDisplayParamsOffset = default(Offset<IScoreDisplayParamsVar>))
		{
			builder.StartTable(2);
			IScoreDisplayMaterialParams.AddScoreDisplayParams(builder, ScoreDisplayParamsOffset);
			IScoreDisplayMaterialParams.AddType(builder, Type);
			return IScoreDisplayMaterialParams.EndIScoreDisplayMaterialParams(builder);
		}

		// Token: 0x06014761 RID: 83809 RVA: 0x002FB3C2 File Offset: 0x002F95C2
		public static void StartIScoreDisplayMaterialParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014762 RID: 83810 RVA: 0x002FB3CB File Offset: 0x002F95CB
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014763 RID: 83811 RVA: 0x002FB3D6 File Offset: 0x002F95D6
		public static void AddScoreDisplayParams(FlatBufferBuilder builder, Offset<IScoreDisplayParamsVar> scoreDisplayParamsOffset)
		{
			builder.AddOffset(1, scoreDisplayParamsOffset.Value, 0);
		}

		// Token: 0x06014764 RID: 83812 RVA: 0x002FB3E6 File Offset: 0x002F95E6
		public static Offset<IScoreDisplayMaterialParams> EndIScoreDisplayMaterialParams(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayMaterialParams>(builder.EndTable());
		}

		// Token: 0x06014765 RID: 83813 RVA: 0x002FB3F4 File Offset: 0x002F95F4
		public IScoreDisplayMaterialParamsT UnPack()
		{
			IScoreDisplayMaterialParamsT scoreDisplayMaterialParamsT = new IScoreDisplayMaterialParamsT();
			this.UnPackTo(scoreDisplayMaterialParamsT);
			return scoreDisplayMaterialParamsT;
		}

		// Token: 0x06014766 RID: 83814 RVA: 0x002FB410 File Offset: 0x002F9610
		public void UnPackTo(IScoreDisplayMaterialParamsT _o)
		{
			_o.Type = this.Type;
			_o.ScoreDisplayParams = ((this.ScoreDisplayParams != null) ? this.ScoreDisplayParams.Value.UnPack() : null);
		}

		// Token: 0x06014767 RID: 83815 RVA: 0x002FB458 File Offset: 0x002F9658
		public static Offset<IScoreDisplayMaterialParams> Pack(FlatBufferBuilder builder, IScoreDisplayMaterialParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScoreDisplayMaterialParams>);
			}
			Offset<IScoreDisplayParamsVar> scoreDisplayParamsOffset = (_o.ScoreDisplayParams == null) ? default(Offset<IScoreDisplayParamsVar>) : IScoreDisplayParamsVar.Pack(builder, _o.ScoreDisplayParams);
			return IScoreDisplayMaterialParams.CreateIScoreDisplayMaterialParams(builder, _o.Type, scoreDisplayParamsOffset);
		}

		// Token: 0x0400AF63 RID: 44899
		private Table __p;
	}
}
