using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED8 RID: 20184
	public struct ICheckEntitySelfDirection : IFlatbufferObject
	{
		// Token: 0x17009022 RID: 36898
		// (get) Token: 0x0601F54E RID: 128334 RVA: 0x0045DBFC File Offset: 0x0045BDFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F54F RID: 128335 RVA: 0x0045DC09 File Offset: 0x0045BE09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F550 RID: 128336 RVA: 0x0045DC10 File Offset: 0x0045BE10
		public static ICheckEntitySelfDirection GetRootAsICheckEntitySelfDirection(ByteBuffer _bb)
		{
			return ICheckEntitySelfDirection.GetRootAsICheckEntitySelfDirection(_bb, default(ICheckEntitySelfDirection));
		}

		// Token: 0x0601F551 RID: 128337 RVA: 0x0045DC2C File Offset: 0x0045BE2C
		public static ICheckEntitySelfDirection GetRootAsICheckEntitySelfDirection(ByteBuffer _bb, ICheckEntitySelfDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F552 RID: 128338 RVA: 0x0045DC49 File Offset: 0x0045BE49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F553 RID: 128339 RVA: 0x0045DC58 File Offset: 0x0045BE58
		public ICheckEntitySelfDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009023 RID: 36899
		// (get) Token: 0x0601F554 RID: 128340 RVA: 0x0045DC68 File Offset: 0x0045BE68
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

		// Token: 0x17009024 RID: 36900
		// (get) Token: 0x0601F555 RID: 128341 RVA: 0x0045DCA4 File Offset: 0x0045BEA4
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

		// Token: 0x17009025 RID: 36901
		// (get) Token: 0x0601F556 RID: 128342 RVA: 0x0045DD04 File Offset: 0x0045BF04
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

		// Token: 0x0601F557 RID: 128343 RVA: 0x0045DD44 File Offset: 0x0045BF44
		public static Offset<ICheckEntitySelfDirection> CreateICheckEntitySelfDirection(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), float Tolerance = 0f)
		{
			builder.StartTable(3);
			ICheckEntitySelfDirection.AddTolerance(builder, Tolerance);
			ICheckEntitySelfDirection.AddDirection(builder, DirectionOffset);
			ICheckEntitySelfDirection.AddType(builder, Type);
			return ICheckEntitySelfDirection.EndICheckEntitySelfDirection(builder);
		}

		// Token: 0x0601F558 RID: 128344 RVA: 0x0045DD68 File Offset: 0x0045BF68
		public static void StartICheckEntitySelfDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F559 RID: 128345 RVA: 0x0045DD71 File Offset: 0x0045BF71
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F55A RID: 128346 RVA: 0x0045DD7C File Offset: 0x0045BF7C
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0601F55B RID: 128347 RVA: 0x0045DD8C File Offset: 0x0045BF8C
		public static void AddTolerance(FlatBufferBuilder builder, float tolerance)
		{
			builder.AddFloat(2, tolerance, 0.0);
		}

		// Token: 0x0601F55C RID: 128348 RVA: 0x0045DD9F File Offset: 0x0045BF9F
		public static Offset<ICheckEntitySelfDirection> EndICheckEntitySelfDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntitySelfDirection>(builder.EndTable());
		}

		// Token: 0x0601F55D RID: 128349 RVA: 0x0045DDAC File Offset: 0x0045BFAC
		public ICheckEntitySelfDirectionT UnPack()
		{
			ICheckEntitySelfDirectionT checkEntitySelfDirectionT = new ICheckEntitySelfDirectionT();
			this.UnPackTo(checkEntitySelfDirectionT);
			return checkEntitySelfDirectionT;
		}

		// Token: 0x0601F55E RID: 128350 RVA: 0x0045DDC8 File Offset: 0x0045BFC8
		public void UnPackTo(ICheckEntitySelfDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Tolerance = this.Tolerance;
		}

		// Token: 0x0601F55F RID: 128351 RVA: 0x0045DE1C File Offset: 0x0045C01C
		public static Offset<ICheckEntitySelfDirection> Pack(FlatBufferBuilder builder, ICheckEntitySelfDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntitySelfDirection>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckEntitySelfDirection.CreateICheckEntitySelfDirection(builder, _o.Type, directionOffset, _o.Tolerance);
		}

		// Token: 0x0400DD39 RID: 56633
		private Table __p;
	}
}
