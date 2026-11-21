using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2D RID: 27437
	public struct IConeRangeCheck : IFlatbufferObject
	{
		// Token: 0x1700C97C RID: 51580
		// (get) Token: 0x0602F352 RID: 193362 RVA: 0x00672634 File Offset: 0x00670834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F353 RID: 193363 RVA: 0x00672641 File Offset: 0x00670841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F354 RID: 193364 RVA: 0x00672648 File Offset: 0x00670848
		public static IConeRangeCheck GetRootAsIConeRangeCheck(ByteBuffer _bb)
		{
			return IConeRangeCheck.GetRootAsIConeRangeCheck(_bb, default(IConeRangeCheck));
		}

		// Token: 0x0602F355 RID: 193365 RVA: 0x00672664 File Offset: 0x00670864
		public static IConeRangeCheck GetRootAsIConeRangeCheck(ByteBuffer _bb, IConeRangeCheck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F356 RID: 193366 RVA: 0x00672681 File Offset: 0x00670881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F357 RID: 193367 RVA: 0x00672690 File Offset: 0x00670890
		public IConeRangeCheck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C97D RID: 51581
		// (get) Token: 0x0602F358 RID: 193368 RVA: 0x006726A0 File Offset: 0x006708A0
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

		// Token: 0x1700C97E RID: 51582
		// (get) Token: 0x0602F359 RID: 193369 RVA: 0x006726DC File Offset: 0x006708DC
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

		// Token: 0x1700C97F RID: 51583
		// (get) Token: 0x0602F35A RID: 193370 RVA: 0x0067273C File Offset: 0x0067093C
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

		// Token: 0x1700C980 RID: 51584
		// (get) Token: 0x0602F35B RID: 193371 RVA: 0x0067277C File Offset: 0x0067097C
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

		// Token: 0x0602F35C RID: 193372 RVA: 0x006727BD File Offset: 0x006709BD
		public static Offset<IConeRangeCheck> CreateIConeRangeCheck(FlatBufferBuilder builder, ERangeCheckType Type = ERangeCheckType.Cone, Offset<IVectorInfo> CenterOffsetOffset = default(Offset<IVectorInfo>), float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(4);
			IConeRangeCheck.AddHeight(builder, Height);
			IConeRangeCheck.AddRadius(builder, Radius);
			IConeRangeCheck.AddCenterOffset(builder, CenterOffsetOffset);
			IConeRangeCheck.AddType(builder, Type);
			return IConeRangeCheck.EndIConeRangeCheck(builder);
		}

		// Token: 0x0602F35D RID: 193373 RVA: 0x006727E9 File Offset: 0x006709E9
		public static void StartIConeRangeCheck(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F35E RID: 193374 RVA: 0x006727F2 File Offset: 0x006709F2
		public static void AddType(FlatBufferBuilder builder, ERangeCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F35F RID: 193375 RVA: 0x006727FD File Offset: 0x006709FD
		public static void AddCenterOffset(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffsetOffset)
		{
			builder.AddOffset(1, centerOffsetOffset.Value, 0);
		}

		// Token: 0x0602F360 RID: 193376 RVA: 0x0067280D File Offset: 0x00670A0D
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0602F361 RID: 193377 RVA: 0x00672820 File Offset: 0x00670A20
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x0602F362 RID: 193378 RVA: 0x00672833 File Offset: 0x00670A33
		public static Offset<IConeRangeCheck> EndIConeRangeCheck(FlatBufferBuilder builder)
		{
			return new Offset<IConeRangeCheck>(builder.EndTable());
		}

		// Token: 0x0602F363 RID: 193379 RVA: 0x00672840 File Offset: 0x00670A40
		public IConeRangeCheckT UnPack()
		{
			IConeRangeCheckT coneRangeCheckT = new IConeRangeCheckT();
			this.UnPackTo(coneRangeCheckT);
			return coneRangeCheckT;
		}

		// Token: 0x0602F364 RID: 193380 RVA: 0x0067285C File Offset: 0x00670A5C
		public void UnPackTo(IConeRangeCheckT _o)
		{
			_o.Type = this.Type;
			_o.CenterOffset = ((this.CenterOffset != null) ? this.CenterOffset.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0602F365 RID: 193381 RVA: 0x006728BC File Offset: 0x00670ABC
		public static Offset<IConeRangeCheck> Pack(FlatBufferBuilder builder, IConeRangeCheckT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeRangeCheck>);
			}
			Offset<IVectorInfo> centerOffsetOffset = (_o.CenterOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterOffset);
			return IConeRangeCheck.CreateIConeRangeCheck(builder, _o.Type, centerOffsetOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0401190B RID: 71947
		private Table __p;
	}
}
