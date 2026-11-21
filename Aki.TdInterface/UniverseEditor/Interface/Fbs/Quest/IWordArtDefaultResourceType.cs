using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046FD RID: 18173
	public struct IWordArtDefaultResourceType : IFlatbufferObject
	{
		// Token: 0x17007F46 RID: 32582
		// (get) Token: 0x0601ABC9 RID: 109513 RVA: 0x003CC977 File Offset: 0x003CAB77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABCA RID: 109514 RVA: 0x003CC984 File Offset: 0x003CAB84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABCB RID: 109515 RVA: 0x003CC98C File Offset: 0x003CAB8C
		public static IWordArtDefaultResourceType GetRootAsIWordArtDefaultResourceType(ByteBuffer _bb)
		{
			return IWordArtDefaultResourceType.GetRootAsIWordArtDefaultResourceType(_bb, default(IWordArtDefaultResourceType));
		}

		// Token: 0x0601ABCC RID: 109516 RVA: 0x003CC9A8 File Offset: 0x003CABA8
		public static IWordArtDefaultResourceType GetRootAsIWordArtDefaultResourceType(ByteBuffer _bb, IWordArtDefaultResourceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABCD RID: 109517 RVA: 0x003CC9C5 File Offset: 0x003CABC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABCE RID: 109518 RVA: 0x003CC9D4 File Offset: 0x003CABD4
		public IWordArtDefaultResourceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F47 RID: 32583
		// (get) Token: 0x0601ABCF RID: 109519 RVA: 0x003CC9E4 File Offset: 0x003CABE4
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

		// Token: 0x17007F48 RID: 32584
		// (get) Token: 0x0601ABD0 RID: 109520 RVA: 0x003CCA20 File Offset: 0x003CAC20
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

		// Token: 0x17007F49 RID: 32585
		// (get) Token: 0x0601ABD1 RID: 109521 RVA: 0x003CCA60 File Offset: 0x003CAC60
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

		// Token: 0x0601ABD2 RID: 109522 RVA: 0x003CCA9C File Offset: 0x003CAC9C
		public static Offset<IWordArtDefaultResourceType> CreateIWordArtDefaultResourceType(FlatBufferBuilder builder, EWordArtResourceType Type = EWordArtResourceType.Default, float Scale = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWordArtDefaultResourceType.AddScale(builder, Scale);
			IWordArtDefaultResourceType.AddNullMask(builder, NullMask);
			IWordArtDefaultResourceType.AddType(builder, Type);
			return IWordArtDefaultResourceType.EndIWordArtDefaultResourceType(builder);
		}

		// Token: 0x0601ABD3 RID: 109523 RVA: 0x003CCAC0 File Offset: 0x003CACC0
		public static void StartIWordArtDefaultResourceType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ABD4 RID: 109524 RVA: 0x003CCAC9 File Offset: 0x003CACC9
		public static void AddType(FlatBufferBuilder builder, EWordArtResourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ABD5 RID: 109525 RVA: 0x003CCAD4 File Offset: 0x003CACD4
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x0601ABD6 RID: 109526 RVA: 0x003CCAE7 File Offset: 0x003CACE7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601ABD7 RID: 109527 RVA: 0x003CCAF2 File Offset: 0x003CACF2
		public static Offset<IWordArtDefaultResourceType> EndIWordArtDefaultResourceType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtDefaultResourceType>(builder.EndTable());
		}

		// Token: 0x0601ABD8 RID: 109528 RVA: 0x003CCB00 File Offset: 0x003CAD00
		public IWordArtDefaultResourceTypeT UnPack()
		{
			IWordArtDefaultResourceTypeT wordArtDefaultResourceTypeT = new IWordArtDefaultResourceTypeT();
			this.UnPackTo(wordArtDefaultResourceTypeT);
			return wordArtDefaultResourceTypeT;
		}

		// Token: 0x0601ABD9 RID: 109529 RVA: 0x003CCB1B File Offset: 0x003CAD1B
		public void UnPackTo(IWordArtDefaultResourceTypeT _o)
		{
			_o.Type = this.Type;
			_o.Scale = this.Scale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601ABDA RID: 109530 RVA: 0x003CCB44 File Offset: 0x003CAD44
		public static Offset<IWordArtDefaultResourceType> Pack(FlatBufferBuilder builder, IWordArtDefaultResourceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtDefaultResourceType>);
			}
			return IWordArtDefaultResourceType.CreateIWordArtDefaultResourceType(builder, _o.Type, _o.Scale, _o.NullMask);
		}

		// Token: 0x0400C94F RID: 51535
		private Table __p;
	}
}
