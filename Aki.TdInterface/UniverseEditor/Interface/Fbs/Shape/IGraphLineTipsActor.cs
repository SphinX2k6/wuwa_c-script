using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200401F RID: 16415
	public struct IGraphLineTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F64 RID: 28516
		// (get) Token: 0x06016819 RID: 92185 RVA: 0x00338AF7 File Offset: 0x00336CF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601681A RID: 92186 RVA: 0x00338B04 File Offset: 0x00336D04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601681B RID: 92187 RVA: 0x00338B0C File Offset: 0x00336D0C
		public static IGraphLineTipsActor GetRootAsIGraphLineTipsActor(ByteBuffer _bb)
		{
			return IGraphLineTipsActor.GetRootAsIGraphLineTipsActor(_bb, default(IGraphLineTipsActor));
		}

		// Token: 0x0601681C RID: 92188 RVA: 0x00338B28 File Offset: 0x00336D28
		public static IGraphLineTipsActor GetRootAsIGraphLineTipsActor(ByteBuffer _bb, IGraphLineTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601681D RID: 92189 RVA: 0x00338B45 File Offset: 0x00336D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601681E RID: 92190 RVA: 0x00338B54 File Offset: 0x00336D54
		public IGraphLineTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F65 RID: 28517
		// (get) Token: 0x0601681F RID: 92191 RVA: 0x00338B64 File Offset: 0x00336D64
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

		// Token: 0x17006F66 RID: 28518
		// (get) Token: 0x06016820 RID: 92192 RVA: 0x00338BA0 File Offset: 0x00336DA0
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

		// Token: 0x17006F67 RID: 28519
		// (get) Token: 0x06016821 RID: 92193 RVA: 0x00338BDC File Offset: 0x00336DDC
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

		// Token: 0x17006F68 RID: 28520
		// (get) Token: 0x06016822 RID: 92194 RVA: 0x00338C3C File Offset: 0x00336E3C
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

		// Token: 0x17006F69 RID: 28521
		// (get) Token: 0x06016823 RID: 92195 RVA: 0x00338C9C File Offset: 0x00336E9C
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

		// Token: 0x17006F6A RID: 28522
		// (get) Token: 0x06016824 RID: 92196 RVA: 0x00338CE0 File Offset: 0x00336EE0
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

		// Token: 0x06016825 RID: 92197 RVA: 0x00338D1D File Offset: 0x00336F1D
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

		// Token: 0x06016826 RID: 92198 RVA: 0x00338D59 File Offset: 0x00336F59
		public static void StartIGraphLineTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016827 RID: 92199 RVA: 0x00338D62 File Offset: 0x00336F62
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016828 RID: 92200 RVA: 0x00338D6D File Offset: 0x00336F6D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016829 RID: 92201 RVA: 0x00338D78 File Offset: 0x00336F78
		public static void AddStart(FlatBufferBuilder builder, Offset<IVectorInfo> startOffset)
		{
			builder.AddOffset(2, startOffset.Value, 0);
		}

		// Token: 0x0601682A RID: 92202 RVA: 0x00338D88 File Offset: 0x00336F88
		public static void AddEnd(FlatBufferBuilder builder, Offset<IVectorInfo> endOffset)
		{
			builder.AddOffset(3, endOffset.Value, 0);
		}

		// Token: 0x0601682B RID: 92203 RVA: 0x00338D98 File Offset: 0x00336F98
		public static void AddThickness(FlatBufferBuilder builder, float thickness)
		{
			builder.AddFloat(4, thickness, 0.0);
		}

		// Token: 0x0601682C RID: 92204 RVA: 0x00338DAB File Offset: 0x00336FAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601682D RID: 92205 RVA: 0x00338DB6 File Offset: 0x00336FB6
		public static Offset<IGraphLineTipsActor> EndIGraphLineTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IGraphLineTipsActor>(builder.EndTable());
		}

		// Token: 0x0601682E RID: 92206 RVA: 0x00338DC4 File Offset: 0x00336FC4
		public IGraphLineTipsActorT UnPack()
		{
			IGraphLineTipsActorT graphLineTipsActorT = new IGraphLineTipsActorT();
			this.UnPackTo(graphLineTipsActorT);
			return graphLineTipsActorT;
		}

		// Token: 0x0601682F RID: 92207 RVA: 0x00338DE0 File Offset: 0x00336FE0
		public void UnPackTo(IGraphLineTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
			_o.Thickness = this.Thickness;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016830 RID: 92208 RVA: 0x00338E7C File Offset: 0x0033707C
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

		// Token: 0x0400BB80 RID: 48000
		private Table __p;
	}
}
