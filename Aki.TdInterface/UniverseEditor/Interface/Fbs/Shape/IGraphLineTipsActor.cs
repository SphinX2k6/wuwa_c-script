using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C13 RID: 15379
	public struct IGraphLineTipsActor : IFlatbufferObject
	{
		// Token: 0x170069BC RID: 27068
		// (get) Token: 0x06015323 RID: 86819 RVA: 0x00311F6F File Offset: 0x0031016F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015324 RID: 86820 RVA: 0x00311F7C File Offset: 0x0031017C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015325 RID: 86821 RVA: 0x00311F84 File Offset: 0x00310184
		public static IGraphLineTipsActor GetRootAsIGraphLineTipsActor(ByteBuffer _bb)
		{
			return IGraphLineTipsActor.GetRootAsIGraphLineTipsActor(_bb, default(IGraphLineTipsActor));
		}

		// Token: 0x06015326 RID: 86822 RVA: 0x00311FA0 File Offset: 0x003101A0
		public static IGraphLineTipsActor GetRootAsIGraphLineTipsActor(ByteBuffer _bb, IGraphLineTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015327 RID: 86823 RVA: 0x00311FBD File Offset: 0x003101BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015328 RID: 86824 RVA: 0x00311FCC File Offset: 0x003101CC
		public IGraphLineTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069BD RID: 27069
		// (get) Token: 0x06015329 RID: 86825 RVA: 0x00311FDC File Offset: 0x003101DC
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069BE RID: 27070
		// (get) Token: 0x0601532A RID: 86826 RVA: 0x00312018 File Offset: 0x00310218
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069BF RID: 27071
		// (get) Token: 0x0601532B RID: 86827 RVA: 0x00312054 File Offset: 0x00310254
		public IVectorInfo? Start
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170069C0 RID: 27072
		// (get) Token: 0x0601532C RID: 86828 RVA: 0x003120B4 File Offset: 0x003102B4
		public IVectorInfo? End
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170069C1 RID: 27073
		// (get) Token: 0x0601532D RID: 86829 RVA: 0x00312114 File Offset: 0x00310314
		public float Thickness
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170069C2 RID: 27074
		// (get) Token: 0x0601532E RID: 86830 RVA: 0x00312158 File Offset: 0x00310358
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x00312195 File Offset: 0x00310395
		public static Offset<IGraphLineTipsActor> CreateIGraphLineTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, Offset<IVectorInfo> StartOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> EndOffset = default(Offset<IVectorInfo>), float Thickness = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IGraphLineTipsActor.AddThickness(builder, Thickness);
			IGraphLineTipsActor.AddEnd(builder, EndOffset);
			IGraphLineTipsActor.AddStart(builder, StartOffset);
			IGraphLineTipsActor.AddNullMask(builder, NullMask);
			IGraphLineTipsActor.AddColorType(builder, ColorType);
			IGraphLineTipsActor.AddType(builder, Type);
			return IGraphLineTipsActor.EndIGraphLineTipsActor(builder);
		}

		// Token: 0x06015330 RID: 86832 RVA: 0x003121D1 File Offset: 0x003103D1
		public static void StartIGraphLineTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015331 RID: 86833 RVA: 0x003121DA File Offset: 0x003103DA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015332 RID: 86834 RVA: 0x003121E5 File Offset: 0x003103E5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x003121F0 File Offset: 0x003103F0
		public static void AddStart(FlatBufferBuilder builder, Offset<IVectorInfo> startOffset)
		{
			builder.AddOffset(2, startOffset.Value, 0);
		}

		// Token: 0x06015334 RID: 86836 RVA: 0x00312200 File Offset: 0x00310400
		public static void AddEnd(FlatBufferBuilder builder, Offset<IVectorInfo> endOffset)
		{
			builder.AddOffset(3, endOffset.Value, 0);
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x00312210 File Offset: 0x00310410
		public static void AddThickness(FlatBufferBuilder builder, float thickness)
		{
			builder.AddFloat(4, thickness, 0.0);
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x00312223 File Offset: 0x00310423
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06015337 RID: 86839 RVA: 0x0031222E File Offset: 0x0031042E
		public static Offset<IGraphLineTipsActor> EndIGraphLineTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IGraphLineTipsActor>(builder.EndTable());
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x0031223C File Offset: 0x0031043C
		public IGraphLineTipsActorT UnPack()
		{
			IGraphLineTipsActorT graphLineTipsActorT = new IGraphLineTipsActorT();
			this.UnPackTo(graphLineTipsActorT);
			return graphLineTipsActorT;
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x00312258 File Offset: 0x00310458
		public void UnPackTo(IGraphLineTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
			_o.Thickness = this.Thickness;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601533A RID: 86842 RVA: 0x003122F4 File Offset: 0x003104F4
		public static Offset<IGraphLineTipsActor> Pack(FlatBufferBuilder builder, IGraphLineTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraphLineTipsActor>);
			}
			Offset<IVectorInfo> startOffset = (_o.Start == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Start);
			Offset<IVectorInfo> endOffset = (_o.End == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.End);
			return IGraphLineTipsActor.CreateIGraphLineTipsActor(builder, _o.Type, _o.ColorType, startOffset, endOffset, _o.Thickness, _o.NullMask);
		}

		// Token: 0x0400B1F5 RID: 45557
		private Table __p;
	}
}
