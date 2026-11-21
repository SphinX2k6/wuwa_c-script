using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AF RID: 17327
	public struct IParallaxPointPair : IFlatbufferObject
	{
		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x06018856 RID: 100438 RVA: 0x0037E694 File Offset: 0x0037C894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018857 RID: 100439 RVA: 0x0037E6A1 File Offset: 0x0037C8A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018858 RID: 100440 RVA: 0x0037E6A8 File Offset: 0x0037C8A8
		public static IParallaxPointPair GetRootAsIParallaxPointPair(ByteBuffer _bb)
		{
			return IParallaxPointPair.GetRootAsIParallaxPointPair(_bb, default(IParallaxPointPair));
		}

		// Token: 0x06018859 RID: 100441 RVA: 0x0037E6C4 File Offset: 0x0037C8C4
		public static IParallaxPointPair GetRootAsIParallaxPointPair(ByteBuffer _bb, IParallaxPointPair obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601885A RID: 100442 RVA: 0x0037E6E1 File Offset: 0x0037C8E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601885B RID: 100443 RVA: 0x0037E6F0 File Offset: 0x0037C8F0
		public IParallaxPointPair __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076FE RID: 30462
		// (get) Token: 0x0601885C RID: 100444 RVA: 0x0037E700 File Offset: 0x0037C900
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

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x0601885D RID: 100445 RVA: 0x0037E760 File Offset: 0x0037C960
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

		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x0601885E RID: 100446 RVA: 0x0037E7C0 File Offset: 0x0037C9C0
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

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x0601885F RID: 100447 RVA: 0x0037E800 File Offset: 0x0037CA00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018860 RID: 100448 RVA: 0x0037E83D File Offset: 0x0037CA3D
		public static Offset<IParallaxPointPair> CreateIParallaxPointPair(FlatBufferBuilder builder, Offset<IVectorInfo> SourcePosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), float ErrorRange = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IParallaxPointPair.AddErrorRange(builder, ErrorRange);
			IParallaxPointPair.AddTargetPos(builder, TargetPosOffset);
			IParallaxPointPair.AddSourcePos(builder, SourcePosOffset);
			IParallaxPointPair.AddNullMask(builder, NullMask);
			return IParallaxPointPair.EndIParallaxPointPair(builder);
		}

		// Token: 0x06018861 RID: 100449 RVA: 0x0037E869 File Offset: 0x0037CA69
		public static void StartIParallaxPointPair(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018862 RID: 100450 RVA: 0x0037E872 File Offset: 0x0037CA72
		public static void AddSourcePos(FlatBufferBuilder builder, Offset<IVectorInfo> sourcePosOffset)
		{
			builder.AddOffset(0, sourcePosOffset.Value, 0);
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x0037E882 File Offset: 0x0037CA82
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x0037E892 File Offset: 0x0037CA92
		public static void AddErrorRange(FlatBufferBuilder builder, float errorRange)
		{
			builder.AddFloat(2, errorRange, 0.0);
		}

		// Token: 0x06018865 RID: 100453 RVA: 0x0037E8A5 File Offset: 0x0037CAA5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018866 RID: 100454 RVA: 0x0037E8B0 File Offset: 0x0037CAB0
		public static Offset<IParallaxPointPair> EndIParallaxPointPair(FlatBufferBuilder builder)
		{
			return new Offset<IParallaxPointPair>(builder.EndTable());
		}

		// Token: 0x06018867 RID: 100455 RVA: 0x0037E8C0 File Offset: 0x0037CAC0
		public IParallaxPointPairT UnPack()
		{
			IParallaxPointPairT parallaxPointPairT = new IParallaxPointPairT();
			this.UnPackTo(parallaxPointPairT);
			return parallaxPointPairT;
		}

		// Token: 0x06018868 RID: 100456 RVA: 0x0037E8DC File Offset: 0x0037CADC
		public void UnPackTo(IParallaxPointPairT _o)
		{
			_o.SourcePos = ((this.SourcePos != null) ? this.SourcePos.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.ErrorRange = this.ErrorRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018869 RID: 100457 RVA: 0x0037E960 File Offset: 0x0037CB60
		public static Offset<IParallaxPointPair> Pack(FlatBufferBuilder builder, IParallaxPointPairT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParallaxPointPair>);
			}
			Offset<IVectorInfo> sourcePosOffset = (_o.SourcePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SourcePos);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IParallaxPointPair.CreateIParallaxPointPair(builder, sourcePosOffset, targetPosOffset, _o.ErrorRange, _o.NullMask);
		}

		// Token: 0x0400C379 RID: 50041
		private Table __p;
	}
}
