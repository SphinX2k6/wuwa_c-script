using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC6 RID: 15046
	public struct IScoreDisplayParams : IFlatbufferObject
	{
		// Token: 0x1700673B RID: 26427
		// (get) Token: 0x0601476E RID: 83822 RVA: 0x002FB52C File Offset: 0x002F972C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601476F RID: 83823 RVA: 0x002FB539 File Offset: 0x002F9739
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014770 RID: 83824 RVA: 0x002FB540 File Offset: 0x002F9740
		public static IScoreDisplayParams GetRootAsIScoreDisplayParams(ByteBuffer _bb)
		{
			return IScoreDisplayParams.GetRootAsIScoreDisplayParams(_bb, default(IScoreDisplayParams));
		}

		// Token: 0x06014771 RID: 83825 RVA: 0x002FB55C File Offset: 0x002F975C
		public static IScoreDisplayParams GetRootAsIScoreDisplayParams(ByteBuffer _bb, IScoreDisplayParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014772 RID: 83826 RVA: 0x002FB579 File Offset: 0x002F9779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014773 RID: 83827 RVA: 0x002FB588 File Offset: 0x002F9788
		public IScoreDisplayParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x06014774 RID: 83828 RVA: 0x002FB598 File Offset: 0x002F9798
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

		// Token: 0x06014775 RID: 83829 RVA: 0x002FB5D4 File Offset: 0x002F97D4
		public static Offset<IScoreDisplayParams> CreateIScoreDisplayParams(FlatBufferBuilder builder, EScoreDisplayDataSource Type = EScoreDisplayDataSource.Var)
		{
			builder.StartTable(1);
			IScoreDisplayParams.AddType(builder, Type);
			return IScoreDisplayParams.EndIScoreDisplayParams(builder);
		}

		// Token: 0x06014776 RID: 83830 RVA: 0x002FB5EA File Offset: 0x002F97EA
		public static void StartIScoreDisplayParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014777 RID: 83831 RVA: 0x002FB5F3 File Offset: 0x002F97F3
		public static void AddType(FlatBufferBuilder builder, EScoreDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014778 RID: 83832 RVA: 0x002FB5FE File Offset: 0x002F97FE
		public static Offset<IScoreDisplayParams> EndIScoreDisplayParams(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayParams>(builder.EndTable());
		}

		// Token: 0x06014779 RID: 83833 RVA: 0x002FB60C File Offset: 0x002F980C
		public IScoreDisplayParamsT UnPack()
		{
			IScoreDisplayParamsT scoreDisplayParamsT = new IScoreDisplayParamsT();
			this.UnPackTo(scoreDisplayParamsT);
			return scoreDisplayParamsT;
		}

		// Token: 0x0601477A RID: 83834 RVA: 0x002FB627 File Offset: 0x002F9827
		public void UnPackTo(IScoreDisplayParamsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601477B RID: 83835 RVA: 0x002FB638 File Offset: 0x002F9838
		public static Offset<IScoreDisplayParams> Pack(FlatBufferBuilder builder, IScoreDisplayParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScoreDisplayParams>);
			}
			return IScoreDisplayParams.CreateIScoreDisplayParams(builder, _o.Type);
		}

		// Token: 0x0400AF66 RID: 44902
		private Table __p;
	}
}
