using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006413 RID: 25619
	public struct IGiantStableValueRegion : IFlatbufferObject
	{
		// Token: 0x1700BD3A RID: 48442
		// (get) Token: 0x0602B866 RID: 178278 RVA: 0x005ED74F File Offset: 0x005EB94F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B867 RID: 178279 RVA: 0x005ED75C File Offset: 0x005EB95C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B868 RID: 178280 RVA: 0x005ED764 File Offset: 0x005EB964
		public static IGiantStableValueRegion GetRootAsIGiantStableValueRegion(ByteBuffer _bb)
		{
			return IGiantStableValueRegion.GetRootAsIGiantStableValueRegion(_bb, default(IGiantStableValueRegion));
		}

		// Token: 0x0602B869 RID: 178281 RVA: 0x005ED780 File Offset: 0x005EB980
		public static IGiantStableValueRegion GetRootAsIGiantStableValueRegion(ByteBuffer _bb, IGiantStableValueRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B86A RID: 178282 RVA: 0x005ED79D File Offset: 0x005EB99D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B86B RID: 178283 RVA: 0x005ED7AC File Offset: 0x005EB9AC
		public IGiantStableValueRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD3B RID: 48443
		// (get) Token: 0x0602B86C RID: 178284 RVA: 0x005ED7BC File Offset: 0x005EB9BC
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD3C RID: 48444
		// (get) Token: 0x0602B86D RID: 178285 RVA: 0x005ED7F8 File Offset: 0x005EB9F8
		public EGiantEcoType EcoType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantEcoType.Fire;
				}
				return (EGiantEcoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD3D RID: 48445
		// (get) Token: 0x0602B86E RID: 178286 RVA: 0x005ED834 File Offset: 0x005EBA34
		public IGiantStableValueRange? Range
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValueRange?(default(IGiantStableValueRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B86F RID: 178287 RVA: 0x005ED891 File Offset: 0x005EBA91
		public static Offset<IGiantStableValueRegion> CreateIGiantStableValueRegion(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region, EGiantEcoType EcoType = EGiantEcoType.Fire, Offset<IGiantStableValueRange> RangeOffset = default(Offset<IGiantStableValueRange>))
		{
			builder.StartTable(3);
			IGiantStableValueRegion.AddRange(builder, RangeOffset);
			IGiantStableValueRegion.AddEcoType(builder, EcoType);
			IGiantStableValueRegion.AddType(builder, Type);
			return IGiantStableValueRegion.EndIGiantStableValueRegion(builder);
		}

		// Token: 0x0602B870 RID: 178288 RVA: 0x005ED8B5 File Offset: 0x005EBAB5
		public static void StartIGiantStableValueRegion(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B871 RID: 178289 RVA: 0x005ED8BE File Offset: 0x005EBABE
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B872 RID: 178290 RVA: 0x005ED8C9 File Offset: 0x005EBAC9
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x0602B873 RID: 178291 RVA: 0x005ED8D4 File Offset: 0x005EBAD4
		public static void AddRange(FlatBufferBuilder builder, Offset<IGiantStableValueRange> rangeOffset)
		{
			builder.AddOffset(2, rangeOffset.Value, 0);
		}

		// Token: 0x0602B874 RID: 178292 RVA: 0x005ED8E4 File Offset: 0x005EBAE4
		public static Offset<IGiantStableValueRegion> EndIGiantStableValueRegion(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueRegion>(builder.EndTable());
		}

		// Token: 0x0602B875 RID: 178293 RVA: 0x005ED8F4 File Offset: 0x005EBAF4
		public IGiantStableValueRegionT UnPack()
		{
			IGiantStableValueRegionT giantStableValueRegionT = new IGiantStableValueRegionT();
			this.UnPackTo(giantStableValueRegionT);
			return giantStableValueRegionT;
		}

		// Token: 0x0602B876 RID: 178294 RVA: 0x005ED910 File Offset: 0x005EBB10
		public void UnPackTo(IGiantStableValueRegionT _o)
		{
			_o.Type = this.Type;
			_o.EcoType = this.EcoType;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
		}

		// Token: 0x0602B877 RID: 178295 RVA: 0x005ED964 File Offset: 0x005EBB64
		public static Offset<IGiantStableValueRegion> Pack(FlatBufferBuilder builder, IGiantStableValueRegionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueRegion>);
			}
			Offset<IGiantStableValueRange> rangeOffset = (_o.Range == null) ? default(Offset<IGiantStableValueRange>) : IGiantStableValueRange.Pack(builder, _o.Range);
			return IGiantStableValueRegion.CreateIGiantStableValueRegion(builder, _o.Type, _o.EcoType, rangeOffset);
		}

		// Token: 0x04010517 RID: 66839
		private Table __p;
	}
}
