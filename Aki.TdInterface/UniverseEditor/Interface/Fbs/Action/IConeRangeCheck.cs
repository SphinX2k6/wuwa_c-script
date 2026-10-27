using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C2 RID: 25794
	public struct IConeRangeCheck : IFlatbufferObject
	{
		// Token: 0x1700BFEF RID: 49135
		// (get) Token: 0x0602CBCE RID: 183246 RVA: 0x0062650C File Offset: 0x0062470C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBCF RID: 183247 RVA: 0x00626519 File Offset: 0x00624719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBD0 RID: 183248 RVA: 0x00626520 File Offset: 0x00624720
		public static IConeRangeCheck GetRootAsIConeRangeCheck(ByteBuffer _bb)
		{
			return IConeRangeCheck.GetRootAsIConeRangeCheck(_bb, default(IConeRangeCheck));
		}

		// Token: 0x0602CBD1 RID: 183249 RVA: 0x0062653C File Offset: 0x0062473C
		public static IConeRangeCheck GetRootAsIConeRangeCheck(ByteBuffer _bb, IConeRangeCheck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBD2 RID: 183250 RVA: 0x00626559 File Offset: 0x00624759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBD3 RID: 183251 RVA: 0x00626568 File Offset: 0x00624768
		public IConeRangeCheck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFF0 RID: 49136
		// (get) Token: 0x0602CBD4 RID: 183252 RVA: 0x00626578 File Offset: 0x00624778
		public ERangeCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeCheckType.Cone;
				}
				return (ERangeCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFF1 RID: 49137
		// (get) Token: 0x0602CBD5 RID: 183253 RVA: 0x006265B4 File Offset: 0x006247B4
		public IVectorInfo? CenterOffset
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

		// Token: 0x1700BFF2 RID: 49138
		// (get) Token: 0x0602CBD6 RID: 183254 RVA: 0x00626614 File Offset: 0x00624814
		public float Radius
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

		// Token: 0x1700BFF3 RID: 49139
		// (get) Token: 0x0602CBD7 RID: 183255 RVA: 0x00626654 File Offset: 0x00624854
		public float Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CBD8 RID: 183256 RVA: 0x00626695 File Offset: 0x00624895
		public static Offset<IConeRangeCheck> CreateIConeRangeCheck(FlatBufferBuilder builder, ERangeCheckType Type = ERangeCheckType.Cone, Offset<IVectorInfo> CenterOffsetOffset = default(Offset<IVectorInfo>), float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(4);
			IConeRangeCheck.AddHeight(builder, Height);
			IConeRangeCheck.AddRadius(builder, Radius);
			IConeRangeCheck.AddCenterOffset(builder, CenterOffsetOffset);
			IConeRangeCheck.AddType(builder, Type);
			return IConeRangeCheck.EndIConeRangeCheck(builder);
		}

		// Token: 0x0602CBD9 RID: 183257 RVA: 0x006266C1 File Offset: 0x006248C1
		public static void StartIConeRangeCheck(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CBDA RID: 183258 RVA: 0x006266CA File Offset: 0x006248CA
		public static void AddType(FlatBufferBuilder builder, ERangeCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CBDB RID: 183259 RVA: 0x006266D5 File Offset: 0x006248D5
		public static void AddCenterOffset(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffsetOffset)
		{
			builder.AddOffset(1, centerOffsetOffset.Value, 0);
		}

		// Token: 0x0602CBDC RID: 183260 RVA: 0x006266E5 File Offset: 0x006248E5
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0602CBDD RID: 183261 RVA: 0x006266F8 File Offset: 0x006248F8
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x0602CBDE RID: 183262 RVA: 0x0062670B File Offset: 0x0062490B
		public static Offset<IConeRangeCheck> EndIConeRangeCheck(FlatBufferBuilder builder)
		{
			return new Offset<IConeRangeCheck>(builder.EndTable());
		}

		// Token: 0x0602CBDF RID: 183263 RVA: 0x00626718 File Offset: 0x00624918
		public IConeRangeCheckT UnPack()
		{
			IConeRangeCheckT coneRangeCheckT = new IConeRangeCheckT();
			this.UnPackTo(coneRangeCheckT);
			return coneRangeCheckT;
		}

		// Token: 0x0602CBE0 RID: 183264 RVA: 0x00626734 File Offset: 0x00624934
		public void UnPackTo(IConeRangeCheckT _o)
		{
			_o.Type = this.Type;
			_o.CenterOffset = ((this.CenterOffset != null) ? this.CenterOffset.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0602CBE1 RID: 183265 RVA: 0x00626794 File Offset: 0x00624994
		public static Offset<IConeRangeCheck> Pack(FlatBufferBuilder builder, IConeRangeCheckT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeRangeCheck>);
			}
			Offset<IVectorInfo> centerOffsetOffset = (_o.CenterOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterOffset);
			return IConeRangeCheck.CreateIConeRangeCheck(builder, _o.Type, centerOffsetOffset, _o.Radius, _o.Height);
		}

		// Token: 0x04010AF5 RID: 68341
		private Table __p;
	}
}
