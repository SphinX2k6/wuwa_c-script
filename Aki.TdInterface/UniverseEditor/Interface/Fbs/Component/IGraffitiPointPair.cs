using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005880 RID: 22656
	public struct IGraffitiPointPair : IFlatbufferObject
	{
		// Token: 0x1700A433 RID: 42035
		// (get) Token: 0x06024BCE RID: 150478 RVA: 0x0050BCAB File Offset: 0x00509EAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BCF RID: 150479 RVA: 0x0050BCB8 File Offset: 0x00509EB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BD0 RID: 150480 RVA: 0x0050BCC0 File Offset: 0x00509EC0
		public static IGraffitiPointPair GetRootAsIGraffitiPointPair(ByteBuffer _bb)
		{
			return IGraffitiPointPair.GetRootAsIGraffitiPointPair(_bb, default(IGraffitiPointPair));
		}

		// Token: 0x06024BD1 RID: 150481 RVA: 0x0050BCDC File Offset: 0x00509EDC
		public static IGraffitiPointPair GetRootAsIGraffitiPointPair(ByteBuffer _bb, IGraffitiPointPair obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BD2 RID: 150482 RVA: 0x0050BCF9 File Offset: 0x00509EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BD3 RID: 150483 RVA: 0x0050BD08 File Offset: 0x00509F08
		public IGraffitiPointPair __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A434 RID: 42036
		// (get) Token: 0x06024BD4 RID: 150484 RVA: 0x0050BD18 File Offset: 0x00509F18
		public IVectorInfo? SourcePos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A435 RID: 42037
		// (get) Token: 0x06024BD5 RID: 150485 RVA: 0x0050BD78 File Offset: 0x00509F78
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A436 RID: 42038
		// (get) Token: 0x06024BD6 RID: 150486 RVA: 0x0050BDD8 File Offset: 0x00509FD8
		public float ErrorRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BD7 RID: 150487 RVA: 0x0050BE18 File Offset: 0x0050A018
		public static Offset<IGraffitiPointPair> CreateIGraffitiPointPair(FlatBufferBuilder builder, Offset<IVectorInfo> SourcePosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), float ErrorRange = 0f)
		{
			builder.StartTable(3);
			IGraffitiPointPair.AddErrorRange(builder, ErrorRange);
			IGraffitiPointPair.AddTargetPos(builder, TargetPosOffset);
			IGraffitiPointPair.AddSourcePos(builder, SourcePosOffset);
			return IGraffitiPointPair.EndIGraffitiPointPair(builder);
		}

		// Token: 0x06024BD8 RID: 150488 RVA: 0x0050BE3C File Offset: 0x0050A03C
		public static void StartIGraffitiPointPair(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024BD9 RID: 150489 RVA: 0x0050BE45 File Offset: 0x0050A045
		public static void AddSourcePos(FlatBufferBuilder builder, Offset<IVectorInfo> sourcePosOffset)
		{
			builder.AddOffset(0, sourcePosOffset.Value, 0);
		}

		// Token: 0x06024BDA RID: 150490 RVA: 0x0050BE55 File Offset: 0x0050A055
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06024BDB RID: 150491 RVA: 0x0050BE65 File Offset: 0x0050A065
		public static void AddErrorRange(FlatBufferBuilder builder, float errorRange)
		{
			builder.AddFloat(2, errorRange, 0.0);
		}

		// Token: 0x06024BDC RID: 150492 RVA: 0x0050BE78 File Offset: 0x0050A078
		public static Offset<IGraffitiPointPair> EndIGraffitiPointPair(FlatBufferBuilder builder)
		{
			return new Offset<IGraffitiPointPair>(builder.EndTable());
		}

		// Token: 0x06024BDD RID: 150493 RVA: 0x0050BE88 File Offset: 0x0050A088
		public IGraffitiPointPairT UnPack()
		{
			IGraffitiPointPairT graffitiPointPairT = new IGraffitiPointPairT();
			this.UnPackTo(graffitiPointPairT);
			return graffitiPointPairT;
		}

		// Token: 0x06024BDE RID: 150494 RVA: 0x0050BEA4 File Offset: 0x0050A0A4
		public void UnPackTo(IGraffitiPointPairT _o)
		{
			_o.SourcePos = ((this.SourcePos != null) ? this.SourcePos.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.ErrorRange = this.ErrorRange;
		}

		// Token: 0x06024BDF RID: 150495 RVA: 0x0050BF1C File Offset: 0x0050A11C
		public static Offset<IGraffitiPointPair> Pack(FlatBufferBuilder builder, IGraffitiPointPairT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraffitiPointPair>);
			}
			Offset<IVectorInfo> sourcePosOffset = (_o.SourcePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SourcePos);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IGraffitiPointPair.CreateIGraffitiPointPair(builder, sourcePosOffset, targetPosOffset, _o.ErrorRange);
		}

		// Token: 0x0400F0D8 RID: 61656
		private Table __p;
	}
}
