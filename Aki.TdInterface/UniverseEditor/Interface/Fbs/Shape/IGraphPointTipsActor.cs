using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C16 RID: 15382
	public struct IGraphPointTipsActor : IFlatbufferObject
	{
		// Token: 0x170069C9 RID: 27081
		// (get) Token: 0x06015349 RID: 86857 RVA: 0x003124BC File Offset: 0x003106BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601534A RID: 86858 RVA: 0x003124C9 File Offset: 0x003106C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x003124D0 File Offset: 0x003106D0
		public static IGraphPointTipsActor GetRootAsIGraphPointTipsActor(ByteBuffer _bb)
		{
			return IGraphPointTipsActor.GetRootAsIGraphPointTipsActor(_bb, default(IGraphPointTipsActor));
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x003124EC File Offset: 0x003106EC
		public static IGraphPointTipsActor GetRootAsIGraphPointTipsActor(ByteBuffer _bb, IGraphPointTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x00312509 File Offset: 0x00310709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x00312518 File Offset: 0x00310718
		public IGraphPointTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069CA RID: 27082
		// (get) Token: 0x0601534F RID: 86863 RVA: 0x00312528 File Offset: 0x00310728
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

		// Token: 0x170069CB RID: 27083
		// (get) Token: 0x06015350 RID: 86864 RVA: 0x00312564 File Offset: 0x00310764
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

		// Token: 0x170069CC RID: 27084
		// (get) Token: 0x06015351 RID: 86865 RVA: 0x003125A0 File Offset: 0x003107A0
		public float Size
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

		// Token: 0x170069CD RID: 27085
		// (get) Token: 0x06015352 RID: 86866 RVA: 0x003125E0 File Offset: 0x003107E0
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

		// Token: 0x06015353 RID: 86867 RVA: 0x0031261D File Offset: 0x0031081D
		public static Offset<IGraphPointTipsActor> CreateIGraphPointTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Size = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGraphPointTipsActor.AddSize(builder, Size);
			IGraphPointTipsActor.AddNullMask(builder, NullMask);
			IGraphPointTipsActor.AddColorType(builder, ColorType);
			IGraphPointTipsActor.AddType(builder, Type);
			return IGraphPointTipsActor.EndIGraphPointTipsActor(builder);
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x00312649 File Offset: 0x00310849
		public static void StartIGraphPointTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x00312652 File Offset: 0x00310852
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015356 RID: 86870 RVA: 0x0031265D File Offset: 0x0031085D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015357 RID: 86871 RVA: 0x00312668 File Offset: 0x00310868
		public static void AddSize(FlatBufferBuilder builder, float size)
		{
			builder.AddFloat(2, size, 0.0);
		}

		// Token: 0x06015358 RID: 86872 RVA: 0x0031267B File Offset: 0x0031087B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06015359 RID: 86873 RVA: 0x00312686 File Offset: 0x00310886
		public static Offset<IGraphPointTipsActor> EndIGraphPointTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IGraphPointTipsActor>(builder.EndTable());
		}

		// Token: 0x0601535A RID: 86874 RVA: 0x00312694 File Offset: 0x00310894
		public IGraphPointTipsActorT UnPack()
		{
			IGraphPointTipsActorT graphPointTipsActorT = new IGraphPointTipsActorT();
			this.UnPackTo(graphPointTipsActorT);
			return graphPointTipsActorT;
		}

		// Token: 0x0601535B RID: 86875 RVA: 0x003126AF File Offset: 0x003108AF
		public void UnPackTo(IGraphPointTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Size = this.Size;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601535C RID: 86876 RVA: 0x003126E4 File Offset: 0x003108E4
		public static Offset<IGraphPointTipsActor> Pack(FlatBufferBuilder builder, IGraphPointTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraphPointTipsActor>);
			}
			return IGraphPointTipsActor.CreateIGraphPointTipsActor(builder, _o.Type, _o.ColorType, _o.Size, _o.NullMask);
		}

		// Token: 0x0400B1FC RID: 45564
		private Table __p;
	}
}
