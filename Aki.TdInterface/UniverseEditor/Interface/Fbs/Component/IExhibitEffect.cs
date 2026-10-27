using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D1 RID: 20945
	public struct IExhibitEffect : IFlatbufferObject
	{
		// Token: 0x1700994B RID: 39243
		// (get) Token: 0x06021F68 RID: 139112 RVA: 0x004B6320 File Offset: 0x004B4520
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F69 RID: 139113 RVA: 0x004B632D File Offset: 0x004B452D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F6A RID: 139114 RVA: 0x004B6334 File Offset: 0x004B4534
		public static IExhibitEffect GetRootAsIExhibitEffect(ByteBuffer _bb)
		{
			return IExhibitEffect.GetRootAsIExhibitEffect(_bb, default(IExhibitEffect));
		}

		// Token: 0x06021F6B RID: 139115 RVA: 0x004B6350 File Offset: 0x004B4550
		public static IExhibitEffect GetRootAsIExhibitEffect(ByteBuffer _bb, IExhibitEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F6C RID: 139116 RVA: 0x004B636D File Offset: 0x004B456D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F6D RID: 139117 RVA: 0x004B637C File Offset: 0x004B457C
		public IExhibitEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700994C RID: 39244
		// (get) Token: 0x06021F6E RID: 139118 RVA: 0x004B638C File Offset: 0x004B458C
		public string Path
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021F6F RID: 139119 RVA: 0x004B63C3 File Offset: 0x004B45C3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021F70 RID: 139120 RVA: 0x004B63D2 File Offset: 0x004B45D2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700994D RID: 39245
		// (get) Token: 0x06021F71 RID: 139121 RVA: 0x004B63E0 File Offset: 0x004B45E0
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700994E RID: 39246
		// (get) Token: 0x06021F72 RID: 139122 RVA: 0x004B6420 File Offset: 0x004B4620
		public IVectorInfo? Offset
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

		// Token: 0x06021F73 RID: 139123 RVA: 0x004B647D File Offset: 0x004B467D
		public static Offset<IExhibitEffect> CreateIExhibitEffect(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), float Scale = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExhibitEffect.AddOffset(builder, OffsetOffset);
			IExhibitEffect.AddScale(builder, Scale);
			IExhibitEffect.AddPath(builder, PathOffset);
			return IExhibitEffect.EndIExhibitEffect(builder);
		}

		// Token: 0x06021F74 RID: 139124 RVA: 0x004B64A1 File Offset: 0x004B46A1
		public static void StartIExhibitEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021F75 RID: 139125 RVA: 0x004B64AA File Offset: 0x004B46AA
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x06021F76 RID: 139126 RVA: 0x004B64BA File Offset: 0x004B46BA
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x06021F77 RID: 139127 RVA: 0x004B64CD File Offset: 0x004B46CD
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06021F78 RID: 139128 RVA: 0x004B64DD File Offset: 0x004B46DD
		public static Offset<IExhibitEffect> EndIExhibitEffect(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitEffect>(builder.EndTable());
		}

		// Token: 0x06021F79 RID: 139129 RVA: 0x004B64EC File Offset: 0x004B46EC
		public IExhibitEffectT UnPack()
		{
			IExhibitEffectT exhibitEffectT = new IExhibitEffectT();
			this.UnPackTo(exhibitEffectT);
			return exhibitEffectT;
		}

		// Token: 0x06021F7A RID: 139130 RVA: 0x004B6508 File Offset: 0x004B4708
		public void UnPackTo(IExhibitEffectT _o)
		{
			_o.Path = this.Path;
			_o.Scale = this.Scale;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06021F7B RID: 139131 RVA: 0x004B655C File Offset: 0x004B475C
		public static Offset<IExhibitEffect> Pack(FlatBufferBuilder builder, IExhibitEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IExhibitEffect.CreateIExhibitEffect(builder, pathOffset, _o.Scale, offsetOffset);
		}

		// Token: 0x0400E2D6 RID: 58070
		private Table __p;
	}
}
