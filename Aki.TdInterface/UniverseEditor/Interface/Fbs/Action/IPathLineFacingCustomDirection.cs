using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CD RID: 29645
	public struct IPathLineFacingCustomDirection : IFlatbufferObject
	{
		// Token: 0x1700D9C3 RID: 55747
		// (get) Token: 0x06033DA2 RID: 212386 RVA: 0x006FE314 File Offset: 0x006FC514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DA3 RID: 212387 RVA: 0x006FE321 File Offset: 0x006FC521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DA4 RID: 212388 RVA: 0x006FE328 File Offset: 0x006FC528
		public static IPathLineFacingCustomDirection GetRootAsIPathLineFacingCustomDirection(ByteBuffer _bb)
		{
			return IPathLineFacingCustomDirection.GetRootAsIPathLineFacingCustomDirection(_bb, default(IPathLineFacingCustomDirection));
		}

		// Token: 0x06033DA5 RID: 212389 RVA: 0x006FE344 File Offset: 0x006FC544
		public static IPathLineFacingCustomDirection GetRootAsIPathLineFacingCustomDirection(ByteBuffer _bb, IPathLineFacingCustomDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DA6 RID: 212390 RVA: 0x006FE361 File Offset: 0x006FC561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DA7 RID: 212391 RVA: 0x006FE370 File Offset: 0x006FC570
		public IPathLineFacingCustomDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9C4 RID: 55748
		// (get) Token: 0x06033DA8 RID: 212392 RVA: 0x006FE380 File Offset: 0x006FC580
		public EPathLineFacingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathLineFacingType.Current;
				}
				return (EPathLineFacingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9C5 RID: 55749
		// (get) Token: 0x06033DA9 RID: 212393 RVA: 0x006FE3BC File Offset: 0x006FC5BC
		public float Yaw
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

		// Token: 0x06033DAA RID: 212394 RVA: 0x006FE3FC File Offset: 0x006FC5FC
		public static Offset<IPathLineFacingCustomDirection> CreateIPathLineFacingCustomDirection(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current, float Yaw = 0f)
		{
			builder.StartTable(2);
			IPathLineFacingCustomDirection.AddYaw(builder, Yaw);
			IPathLineFacingCustomDirection.AddType(builder, Type);
			return IPathLineFacingCustomDirection.EndIPathLineFacingCustomDirection(builder);
		}

		// Token: 0x06033DAB RID: 212395 RVA: 0x006FE419 File Offset: 0x006FC619
		public static void StartIPathLineFacingCustomDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033DAC RID: 212396 RVA: 0x006FE422 File Offset: 0x006FC622
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DAD RID: 212397 RVA: 0x006FE42D File Offset: 0x006FC62D
		public static void AddYaw(FlatBufferBuilder builder, float yaw)
		{
			builder.AddFloat(1, yaw, 0.0);
		}

		// Token: 0x06033DAE RID: 212398 RVA: 0x006FE440 File Offset: 0x006FC640
		public static Offset<IPathLineFacingCustomDirection> EndIPathLineFacingCustomDirection(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingCustomDirection>(builder.EndTable());
		}

		// Token: 0x06033DAF RID: 212399 RVA: 0x006FE450 File Offset: 0x006FC650
		public IPathLineFacingCustomDirectionT UnPack()
		{
			IPathLineFacingCustomDirectionT pathLineFacingCustomDirectionT = new IPathLineFacingCustomDirectionT();
			this.UnPackTo(pathLineFacingCustomDirectionT);
			return pathLineFacingCustomDirectionT;
		}

		// Token: 0x06033DB0 RID: 212400 RVA: 0x006FE46B File Offset: 0x006FC66B
		public void UnPackTo(IPathLineFacingCustomDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Yaw = this.Yaw;
		}

		// Token: 0x06033DB1 RID: 212401 RVA: 0x006FE488 File Offset: 0x006FC688
		public static Offset<IPathLineFacingCustomDirection> Pack(FlatBufferBuilder builder, IPathLineFacingCustomDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingCustomDirection>);
			}
			return IPathLineFacingCustomDirection.CreateIPathLineFacingCustomDirection(builder, _o.Type, _o.Yaw);
		}

		// Token: 0x04012503 RID: 75011
		private Table __p;
	}
}
