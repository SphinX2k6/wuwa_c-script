using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CA RID: 29642
	public struct IPathLineFacingCurrentDirection : IFlatbufferObject
	{
		// Token: 0x1700D9BC RID: 55740
		// (get) Token: 0x06033D88 RID: 212360 RVA: 0x006FE072 File Offset: 0x006FC272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D89 RID: 212361 RVA: 0x006FE07F File Offset: 0x006FC27F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D8A RID: 212362 RVA: 0x006FE088 File Offset: 0x006FC288
		public static IPathLineFacingCurrentDirection GetRootAsIPathLineFacingCurrentDirection(ByteBuffer _bb)
		{
			return IPathLineFacingCurrentDirection.GetRootAsIPathLineFacingCurrentDirection(_bb, default(IPathLineFacingCurrentDirection));
		}

		// Token: 0x06033D8B RID: 212363 RVA: 0x006FE0A4 File Offset: 0x006FC2A4
		public static IPathLineFacingCurrentDirection GetRootAsIPathLineFacingCurrentDirection(ByteBuffer _bb, IPathLineFacingCurrentDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D8C RID: 212364 RVA: 0x006FE0C1 File Offset: 0x006FC2C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D8D RID: 212365 RVA: 0x006FE0D0 File Offset: 0x006FC2D0
		public IPathLineFacingCurrentDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9BD RID: 55741
		// (get) Token: 0x06033D8E RID: 212366 RVA: 0x006FE0E0 File Offset: 0x006FC2E0
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

		// Token: 0x1700D9BE RID: 55742
		// (get) Token: 0x06033D8F RID: 212367 RVA: 0x006FE11C File Offset: 0x006FC31C
		public float YawOffset
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

		// Token: 0x1700D9BF RID: 55743
		// (get) Token: 0x06033D90 RID: 212368 RVA: 0x006FE15C File Offset: 0x006FC35C
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

		// Token: 0x06033D91 RID: 212369 RVA: 0x006FE198 File Offset: 0x006FC398
		public static Offset<IPathLineFacingCurrentDirection> CreateIPathLineFacingCurrentDirection(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current, float YawOffset = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPathLineFacingCurrentDirection.AddYawOffset(builder, YawOffset);
			IPathLineFacingCurrentDirection.AddNullMask(builder, NullMask);
			IPathLineFacingCurrentDirection.AddType(builder, Type);
			return IPathLineFacingCurrentDirection.EndIPathLineFacingCurrentDirection(builder);
		}

		// Token: 0x06033D92 RID: 212370 RVA: 0x006FE1BC File Offset: 0x006FC3BC
		public static void StartIPathLineFacingCurrentDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033D93 RID: 212371 RVA: 0x006FE1C5 File Offset: 0x006FC3C5
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D94 RID: 212372 RVA: 0x006FE1D0 File Offset: 0x006FC3D0
		public static void AddYawOffset(FlatBufferBuilder builder, float yawOffset)
		{
			builder.AddFloat(1, yawOffset, 0.0);
		}

		// Token: 0x06033D95 RID: 212373 RVA: 0x006FE1E3 File Offset: 0x006FC3E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033D96 RID: 212374 RVA: 0x006FE1EE File Offset: 0x006FC3EE
		public static Offset<IPathLineFacingCurrentDirection> EndIPathLineFacingCurrentDirection(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingCurrentDirection>(builder.EndTable());
		}

		// Token: 0x06033D97 RID: 212375 RVA: 0x006FE1FC File Offset: 0x006FC3FC
		public IPathLineFacingCurrentDirectionT UnPack()
		{
			IPathLineFacingCurrentDirectionT pathLineFacingCurrentDirectionT = new IPathLineFacingCurrentDirectionT();
			this.UnPackTo(pathLineFacingCurrentDirectionT);
			return pathLineFacingCurrentDirectionT;
		}

		// Token: 0x06033D98 RID: 212376 RVA: 0x006FE217 File Offset: 0x006FC417
		public void UnPackTo(IPathLineFacingCurrentDirectionT _o)
		{
			_o.Type = this.Type;
			_o.YawOffset = this.YawOffset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033D99 RID: 212377 RVA: 0x006FE240 File Offset: 0x006FC440
		public static Offset<IPathLineFacingCurrentDirection> Pack(FlatBufferBuilder builder, IPathLineFacingCurrentDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingCurrentDirection>);
			}
			return IPathLineFacingCurrentDirection.CreateIPathLineFacingCurrentDirection(builder, _o.Type, _o.YawOffset, _o.NullMask);
		}

		// Token: 0x040124FF RID: 75007
		private Table __p;
	}
}
