using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A18 RID: 18968
	public struct ICheckEntitySelfDirection : IFlatbufferObject
	{
		// Token: 0x17008952 RID: 35154
		// (get) Token: 0x0601DADB RID: 121563 RVA: 0x0042CF90 File Offset: 0x0042B190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DADC RID: 121564 RVA: 0x0042CF9D File Offset: 0x0042B19D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DADD RID: 121565 RVA: 0x0042CFA4 File Offset: 0x0042B1A4
		public static ICheckEntitySelfDirection GetRootAsICheckEntitySelfDirection(ByteBuffer _bb)
		{
			return ICheckEntitySelfDirection.GetRootAsICheckEntitySelfDirection(_bb, default(ICheckEntitySelfDirection));
		}

		// Token: 0x0601DADE RID: 121566 RVA: 0x0042CFC0 File Offset: 0x0042B1C0
		public static ICheckEntitySelfDirection GetRootAsICheckEntitySelfDirection(ByteBuffer _bb, ICheckEntitySelfDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DADF RID: 121567 RVA: 0x0042CFDD File Offset: 0x0042B1DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAE0 RID: 121568 RVA: 0x0042CFEC File Offset: 0x0042B1EC
		public ICheckEntitySelfDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008953 RID: 35155
		// (get) Token: 0x0601DAE1 RID: 121569 RVA: 0x0042CFFC File Offset: 0x0042B1FC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008954 RID: 35156
		// (get) Token: 0x0601DAE2 RID: 121570 RVA: 0x0042D038 File Offset: 0x0042B238
		public IVectorInfo? Direction
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

		// Token: 0x17008955 RID: 35157
		// (get) Token: 0x0601DAE3 RID: 121571 RVA: 0x0042D098 File Offset: 0x0042B298
		public float Tolerance
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

		// Token: 0x0601DAE4 RID: 121572 RVA: 0x0042D0D8 File Offset: 0x0042B2D8
		public static Offset<ICheckEntitySelfDirection> CreateICheckEntitySelfDirection(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), float Tolerance = 0f)
		{
			builder.StartTable(3);
			ICheckEntitySelfDirection.AddTolerance(builder, Tolerance);
			ICheckEntitySelfDirection.AddDirection(builder, DirectionOffset);
			ICheckEntitySelfDirection.AddType(builder, Type);
			return ICheckEntitySelfDirection.EndICheckEntitySelfDirection(builder);
		}

		// Token: 0x0601DAE5 RID: 121573 RVA: 0x0042D0FC File Offset: 0x0042B2FC
		public static void StartICheckEntitySelfDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DAE6 RID: 121574 RVA: 0x0042D105 File Offset: 0x0042B305
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DAE7 RID: 121575 RVA: 0x0042D110 File Offset: 0x0042B310
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0601DAE8 RID: 121576 RVA: 0x0042D120 File Offset: 0x0042B320
		public static void AddTolerance(FlatBufferBuilder builder, float tolerance)
		{
			builder.AddFloat(2, tolerance, 0.0);
		}

		// Token: 0x0601DAE9 RID: 121577 RVA: 0x0042D133 File Offset: 0x0042B333
		public static Offset<ICheckEntitySelfDirection> EndICheckEntitySelfDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntitySelfDirection>(builder.EndTable());
		}

		// Token: 0x0601DAEA RID: 121578 RVA: 0x0042D140 File Offset: 0x0042B340
		public ICheckEntitySelfDirectionT UnPack()
		{
			ICheckEntitySelfDirectionT checkEntitySelfDirectionT = new ICheckEntitySelfDirectionT();
			this.UnPackTo(checkEntitySelfDirectionT);
			return checkEntitySelfDirectionT;
		}

		// Token: 0x0601DAEB RID: 121579 RVA: 0x0042D15C File Offset: 0x0042B35C
		public void UnPackTo(ICheckEntitySelfDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Tolerance = this.Tolerance;
		}

		// Token: 0x0601DAEC RID: 121580 RVA: 0x0042D1B0 File Offset: 0x0042B3B0
		public static Offset<ICheckEntitySelfDirection> Pack(FlatBufferBuilder builder, ICheckEntitySelfDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntitySelfDirection>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckEntitySelfDirection.CreateICheckEntitySelfDirection(builder, _o.Type, directionOffset, _o.Tolerance);
		}

		// Token: 0x0400D265 RID: 53861
		private Table __p;
	}
}
