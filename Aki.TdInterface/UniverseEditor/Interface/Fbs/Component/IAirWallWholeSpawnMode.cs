using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B5 RID: 21429
	public struct IAirWallWholeSpawnMode : IFlatbufferObject
	{
		// Token: 0x17009794 RID: 38804
		// (get) Token: 0x0602172B RID: 137003 RVA: 0x0049D35C File Offset: 0x0049B55C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602172C RID: 137004 RVA: 0x0049D369 File Offset: 0x0049B569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602172D RID: 137005 RVA: 0x0049D370 File Offset: 0x0049B570
		public static IAirWallWholeSpawnMode GetRootAsIAirWallWholeSpawnMode(ByteBuffer _bb)
		{
			return IAirWallWholeSpawnMode.GetRootAsIAirWallWholeSpawnMode(_bb, default(IAirWallWholeSpawnMode));
		}

		// Token: 0x0602172E RID: 137006 RVA: 0x0049D38C File Offset: 0x0049B58C
		public static IAirWallWholeSpawnMode GetRootAsIAirWallWholeSpawnMode(ByteBuffer _bb, IAirWallWholeSpawnMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602172F RID: 137007 RVA: 0x0049D3A9 File Offset: 0x0049B5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021730 RID: 137008 RVA: 0x0049D3B8 File Offset: 0x0049B5B8
		public IAirWallWholeSpawnMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009795 RID: 38805
		// (get) Token: 0x06021731 RID: 137009 RVA: 0x0049D3C8 File Offset: 0x0049B5C8
		public EAirWallSpawnMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAirWallSpawnMode.Whole;
				}
				return (EAirWallSpawnMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009796 RID: 38806
		// (get) Token: 0x06021732 RID: 137010 RVA: 0x0049D404 File Offset: 0x0049B604
		public TAirWallSpawnStyle SpawnStyleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAirWallSpawnStyle.NONE;
				}
				return (TAirWallSpawnStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021733 RID: 137011 RVA: 0x0049D440 File Offset: 0x0049B640
		public TTable? SpawnStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021734 RID: 137012 RVA: 0x0049D484 File Offset: 0x0049B684
		public IAirWallAlongSplineStyle SpawnStyleAsIAirWallAlongSplineStyle()
		{
			return this.SpawnStyle<IAirWallAlongSplineStyle>().Value;
		}

		// Token: 0x06021735 RID: 137013 RVA: 0x0049D4A0 File Offset: 0x0049B6A0
		public IAirWallBothSidesStyle SpawnStyleAsIAirWallBothSidesStyle()
		{
			return this.SpawnStyle<IAirWallBothSidesStyle>().Value;
		}

		// Token: 0x17009797 RID: 38807
		// (get) Token: 0x06021736 RID: 137014 RVA: 0x0049D4BC File Offset: 0x0049B6BC
		public float Thickness
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

		// Token: 0x17009798 RID: 38808
		// (get) Token: 0x06021737 RID: 137015 RVA: 0x0049D500 File Offset: 0x0049B700
		public float Height
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009799 RID: 38809
		// (get) Token: 0x06021738 RID: 137016 RVA: 0x0049D544 File Offset: 0x0049B744
		public float Depth
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021739 RID: 137017 RVA: 0x0049D585 File Offset: 0x0049B785
		public static Offset<IAirWallWholeSpawnMode> CreateIAirWallWholeSpawnMode(FlatBufferBuilder builder, EAirWallSpawnMode Type = EAirWallSpawnMode.Whole, TAirWallSpawnStyle SpawnStyle_type = TAirWallSpawnStyle.NONE, int SpawnStyleOffset = 0, float Thickness = 0f, float Height = 0f, float Depth = 0f)
		{
			builder.StartTable(6);
			IAirWallWholeSpawnMode.AddDepth(builder, Depth);
			IAirWallWholeSpawnMode.AddHeight(builder, Height);
			IAirWallWholeSpawnMode.AddThickness(builder, Thickness);
			IAirWallWholeSpawnMode.AddSpawnStyle(builder, SpawnStyleOffset);
			IAirWallWholeSpawnMode.AddSpawnStyleType(builder, SpawnStyle_type);
			IAirWallWholeSpawnMode.AddType(builder, Type);
			return IAirWallWholeSpawnMode.EndIAirWallWholeSpawnMode(builder);
		}

		// Token: 0x0602173A RID: 137018 RVA: 0x0049D5C1 File Offset: 0x0049B7C1
		public static void StartIAirWallWholeSpawnMode(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602173B RID: 137019 RVA: 0x0049D5CA File Offset: 0x0049B7CA
		public static void AddType(FlatBufferBuilder builder, EAirWallSpawnMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602173C RID: 137020 RVA: 0x0049D5D5 File Offset: 0x0049B7D5
		public static void AddSpawnStyleType(FlatBufferBuilder builder, TAirWallSpawnStyle spawnStyleType)
		{
			builder.AddByte(1, (byte)spawnStyleType, 0);
		}

		// Token: 0x0602173D RID: 137021 RVA: 0x0049D5E0 File Offset: 0x0049B7E0
		public static void AddSpawnStyle(FlatBufferBuilder builder, int spawnStyleOffset)
		{
			builder.AddOffset(2, spawnStyleOffset, 0);
		}

		// Token: 0x0602173E RID: 137022 RVA: 0x0049D5EB File Offset: 0x0049B7EB
		public static void AddThickness(FlatBufferBuilder builder, float thickness)
		{
			builder.AddFloat(3, thickness, 0.0);
		}

		// Token: 0x0602173F RID: 137023 RVA: 0x0049D5FE File Offset: 0x0049B7FE
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(4, height, 0.0);
		}

		// Token: 0x06021740 RID: 137024 RVA: 0x0049D611 File Offset: 0x0049B811
		public static void AddDepth(FlatBufferBuilder builder, float depth)
		{
			builder.AddFloat(5, depth, 0.0);
		}

		// Token: 0x06021741 RID: 137025 RVA: 0x0049D624 File Offset: 0x0049B824
		public static Offset<IAirWallWholeSpawnMode> EndIAirWallWholeSpawnMode(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallWholeSpawnMode>(builder.EndTable());
		}

		// Token: 0x06021742 RID: 137026 RVA: 0x0049D634 File Offset: 0x0049B834
		public IAirWallWholeSpawnModeT UnPack()
		{
			IAirWallWholeSpawnModeT airWallWholeSpawnModeT = new IAirWallWholeSpawnModeT();
			this.UnPackTo(airWallWholeSpawnModeT);
			return airWallWholeSpawnModeT;
		}

		// Token: 0x06021743 RID: 137027 RVA: 0x0049D650 File Offset: 0x0049B850
		public void UnPackTo(IAirWallWholeSpawnModeT _o)
		{
			_o.Type = this.Type;
			_o.SpawnStyle = new TAirWallSpawnStyleUnion();
			_o.SpawnStyle.Type = this.SpawnStyleType;
			TAirWallSpawnStyle spawnStyleType = this.SpawnStyleType;
			if (spawnStyleType != TAirWallSpawnStyle.IAirWallAlongSplineStyle)
			{
				if (spawnStyleType == TAirWallSpawnStyle.IAirWallBothSidesStyle)
				{
					_o.SpawnStyle.Value = ((this.SpawnStyle<IAirWallBothSidesStyle>() != null) ? this.SpawnStyle<IAirWallBothSidesStyle>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SpawnStyle.Value = ((this.SpawnStyle<IAirWallAlongSplineStyle>() != null) ? this.SpawnStyle<IAirWallAlongSplineStyle>().Value.UnPack() : null);
			}
			_o.Thickness = this.Thickness;
			_o.Height = this.Height;
			_o.Depth = this.Depth;
		}

		// Token: 0x06021744 RID: 137028 RVA: 0x0049D728 File Offset: 0x0049B928
		public static Offset<IAirWallWholeSpawnMode> Pack(FlatBufferBuilder builder, IAirWallWholeSpawnModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallWholeSpawnMode>);
			}
			TAirWallSpawnStyle spawnStyle_type = (_o.SpawnStyle == null) ? TAirWallSpawnStyle.NONE : _o.SpawnStyle.Type;
			int spawnStyleOffset = (_o.SpawnStyle == null) ? 0 : TAirWallSpawnStyleUnion.Pack(builder, _o.SpawnStyle);
			return IAirWallWholeSpawnMode.CreateIAirWallWholeSpawnMode(builder, _o.Type, spawnStyle_type, spawnStyleOffset, _o.Thickness, _o.Height, _o.Depth);
		}

		// Token: 0x0400E7FA RID: 59386
		private Table __p;
	}
}
