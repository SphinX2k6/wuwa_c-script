using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A1 RID: 17057
	public struct IWordArtDefaultResourceType : IFlatbufferObject
	{
		// Token: 0x17007915 RID: 30997
		// (get) Token: 0x0601945D RID: 103517 RVA: 0x003A129F File Offset: 0x0039F49F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601945E RID: 103518 RVA: 0x003A12AC File Offset: 0x0039F4AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601945F RID: 103519 RVA: 0x003A12B4 File Offset: 0x0039F4B4
		public static IWordArtDefaultResourceType GetRootAsIWordArtDefaultResourceType(ByteBuffer _bb)
		{
			return IWordArtDefaultResourceType.GetRootAsIWordArtDefaultResourceType(_bb, default(IWordArtDefaultResourceType));
		}

		// Token: 0x06019460 RID: 103520 RVA: 0x003A12D0 File Offset: 0x0039F4D0
		public static IWordArtDefaultResourceType GetRootAsIWordArtDefaultResourceType(ByteBuffer _bb, IWordArtDefaultResourceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019461 RID: 103521 RVA: 0x003A12ED File Offset: 0x0039F4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019462 RID: 103522 RVA: 0x003A12FC File Offset: 0x0039F4FC
		public IWordArtDefaultResourceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007916 RID: 30998
		// (get) Token: 0x06019463 RID: 103523 RVA: 0x003A130C File Offset: 0x0039F50C
		public EWordArtResourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWordArtResourceType.Default;
				}
				return (EWordArtResourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007917 RID: 30999
		// (get) Token: 0x06019464 RID: 103524 RVA: 0x003A1348 File Offset: 0x0039F548
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

		// Token: 0x17007918 RID: 31000
		// (get) Token: 0x06019465 RID: 103525 RVA: 0x003A1388 File Offset: 0x0039F588
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019466 RID: 103526 RVA: 0x003A13C4 File Offset: 0x0039F5C4
		public static Offset<IWordArtDefaultResourceType> CreateIWordArtDefaultResourceType(FlatBufferBuilder builder, EWordArtResourceType Type = EWordArtResourceType.Default, float Scale = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWordArtDefaultResourceType.AddScale(builder, Scale);
			IWordArtDefaultResourceType.AddNullMask(builder, NullMask);
			IWordArtDefaultResourceType.AddType(builder, Type);
			return IWordArtDefaultResourceType.EndIWordArtDefaultResourceType(builder);
		}

		// Token: 0x06019467 RID: 103527 RVA: 0x003A13E8 File Offset: 0x0039F5E8
		public static void StartIWordArtDefaultResourceType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019468 RID: 103528 RVA: 0x003A13F1 File Offset: 0x0039F5F1
		public static void AddType(FlatBufferBuilder builder, EWordArtResourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019469 RID: 103529 RVA: 0x003A13FC File Offset: 0x0039F5FC
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x0601946A RID: 103530 RVA: 0x003A140F File Offset: 0x0039F60F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x003A141A File Offset: 0x0039F61A
		public static Offset<IWordArtDefaultResourceType> EndIWordArtDefaultResourceType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtDefaultResourceType>(builder.EndTable());
		}

		// Token: 0x0601946C RID: 103532 RVA: 0x003A1428 File Offset: 0x0039F628
		public IWordArtDefaultResourceTypeT UnPack()
		{
			IWordArtDefaultResourceTypeT wordArtDefaultResourceTypeT = new IWordArtDefaultResourceTypeT();
			this.UnPackTo(wordArtDefaultResourceTypeT);
			return wordArtDefaultResourceTypeT;
		}

		// Token: 0x0601946D RID: 103533 RVA: 0x003A1443 File Offset: 0x0039F643
		public void UnPackTo(IWordArtDefaultResourceTypeT _o)
		{
			_o.Type = this.Type;
			_o.Scale = this.Scale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601946E RID: 103534 RVA: 0x003A146C File Offset: 0x0039F66C
		public static Offset<IWordArtDefaultResourceType> Pack(FlatBufferBuilder builder, IWordArtDefaultResourceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtDefaultResourceType>);
			}
			return IWordArtDefaultResourceType.CreateIWordArtDefaultResourceType(builder, _o.Type, _o.Scale, _o.NullMask);
		}

		// Token: 0x0400BF42 RID: 48962
		private Table __p;
	}
}
