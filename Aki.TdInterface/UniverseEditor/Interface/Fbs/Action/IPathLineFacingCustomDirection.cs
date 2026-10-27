using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C66 RID: 27750
	public struct IPathLineFacingCustomDirection : IFlatbufferObject
	{
		// Token: 0x1700CEA8 RID: 52904
		// (get) Token: 0x06030E47 RID: 200263 RVA: 0x006A3E14 File Offset: 0x006A2014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E48 RID: 200264 RVA: 0x006A3E21 File Offset: 0x006A2021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E49 RID: 200265 RVA: 0x006A3E28 File Offset: 0x006A2028
		public static IPathLineFacingCustomDirection GetRootAsIPathLineFacingCustomDirection(ByteBuffer _bb)
		{
			return IPathLineFacingCustomDirection.GetRootAsIPathLineFacingCustomDirection(_bb, default(IPathLineFacingCustomDirection));
		}

		// Token: 0x06030E4A RID: 200266 RVA: 0x006A3E44 File Offset: 0x006A2044
		public static IPathLineFacingCustomDirection GetRootAsIPathLineFacingCustomDirection(ByteBuffer _bb, IPathLineFacingCustomDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E4B RID: 200267 RVA: 0x006A3E61 File Offset: 0x006A2061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E4C RID: 200268 RVA: 0x006A3E70 File Offset: 0x006A2070
		public IPathLineFacingCustomDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEA9 RID: 52905
		// (get) Token: 0x06030E4D RID: 200269 RVA: 0x006A3E80 File Offset: 0x006A2080
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

		// Token: 0x1700CEAA RID: 52906
		// (get) Token: 0x06030E4E RID: 200270 RVA: 0x006A3EBC File Offset: 0x006A20BC
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

		// Token: 0x06030E4F RID: 200271 RVA: 0x006A3EFC File Offset: 0x006A20FC
		public static Offset<IPathLineFacingCustomDirection> CreateIPathLineFacingCustomDirection(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current, float Yaw = 0f)
		{
			builder.StartTable(2);
			IPathLineFacingCustomDirection.AddYaw(builder, Yaw);
			IPathLineFacingCustomDirection.AddType(builder, Type);
			return IPathLineFacingCustomDirection.EndIPathLineFacingCustomDirection(builder);
		}

		// Token: 0x06030E50 RID: 200272 RVA: 0x006A3F19 File Offset: 0x006A2119
		public static void StartIPathLineFacingCustomDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E51 RID: 200273 RVA: 0x006A3F22 File Offset: 0x006A2122
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E52 RID: 200274 RVA: 0x006A3F2D File Offset: 0x006A212D
		public static void AddYaw(FlatBufferBuilder builder, float yaw)
		{
			builder.AddFloat(1, yaw, 0.0);
		}

		// Token: 0x06030E53 RID: 200275 RVA: 0x006A3F40 File Offset: 0x006A2140
		public static Offset<IPathLineFacingCustomDirection> EndIPathLineFacingCustomDirection(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingCustomDirection>(builder.EndTable());
		}

		// Token: 0x06030E54 RID: 200276 RVA: 0x006A3F50 File Offset: 0x006A2150
		public IPathLineFacingCustomDirectionT UnPack()
		{
			IPathLineFacingCustomDirectionT pathLineFacingCustomDirectionT = new IPathLineFacingCustomDirectionT();
			this.UnPackTo(pathLineFacingCustomDirectionT);
			return pathLineFacingCustomDirectionT;
		}

		// Token: 0x06030E55 RID: 200277 RVA: 0x006A3F6B File Offset: 0x006A216B
		public void UnPackTo(IPathLineFacingCustomDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Yaw = this.Yaw;
		}

		// Token: 0x06030E56 RID: 200278 RVA: 0x006A3F88 File Offset: 0x006A2188
		public static Offset<IPathLineFacingCustomDirection> Pack(FlatBufferBuilder builder, IPathLineFacingCustomDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingCustomDirection>);
			}
			return IPathLineFacingCustomDirection.CreateIPathLineFacingCustomDirection(builder, _o.Type, _o.Yaw);
		}

		// Token: 0x040115AB RID: 71083
		private Table __p;
	}
}
