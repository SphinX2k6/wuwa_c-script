using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E83 RID: 16003
	public struct IFireBoxLampParams : IFlatbufferObject
	{
		// Token: 0x17006C1D RID: 27677
		// (get) Token: 0x06015968 RID: 88424 RVA: 0x0031C84C File Offset: 0x0031AA4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015969 RID: 88425 RVA: 0x0031C859 File Offset: 0x0031AA59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601596A RID: 88426 RVA: 0x0031C860 File Offset: 0x0031AA60
		public static IFireBoxLampParams GetRootAsIFireBoxLampParams(ByteBuffer _bb)
		{
			return IFireBoxLampParams.GetRootAsIFireBoxLampParams(_bb, default(IFireBoxLampParams));
		}

		// Token: 0x0601596B RID: 88427 RVA: 0x0031C87C File Offset: 0x0031AA7C
		public static IFireBoxLampParams GetRootAsIFireBoxLampParams(ByteBuffer _bb, IFireBoxLampParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601596C RID: 88428 RVA: 0x0031C899 File Offset: 0x0031AA99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601596D RID: 88429 RVA: 0x0031C8A8 File Offset: 0x0031AAA8
		public IFireBoxLampParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C1E RID: 27678
		// (get) Token: 0x0601596E RID: 88430 RVA: 0x0031C8B8 File Offset: 0x0031AAB8
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C1F RID: 27679
		// (get) Token: 0x0601596F RID: 88431 RVA: 0x0031C8F4 File Offset: 0x0031AAF4
		public float RangeRadius
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

		// Token: 0x06015970 RID: 88432 RVA: 0x0031C934 File Offset: 0x0031AB34
		public static Offset<IFireBoxLampParams> CreateIFireBoxLampParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, float RangeRadius = 0f)
		{
			builder.StartTable(2);
			IFireBoxLampParams.AddRangeRadius(builder, RangeRadius);
			IFireBoxLampParams.AddType(builder, Type);
			return IFireBoxLampParams.EndIFireBoxLampParams(builder);
		}

		// Token: 0x06015971 RID: 88433 RVA: 0x0031C951 File Offset: 0x0031AB51
		public static void StartIFireBoxLampParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015972 RID: 88434 RVA: 0x0031C95A File Offset: 0x0031AB5A
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015973 RID: 88435 RVA: 0x0031C965 File Offset: 0x0031AB65
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x06015974 RID: 88436 RVA: 0x0031C978 File Offset: 0x0031AB78
		public static Offset<IFireBoxLampParams> EndIFireBoxLampParams(FlatBufferBuilder builder)
		{
			return new Offset<IFireBoxLampParams>(builder.EndTable());
		}

		// Token: 0x06015975 RID: 88437 RVA: 0x0031C988 File Offset: 0x0031AB88
		public IFireBoxLampParamsT UnPack()
		{
			IFireBoxLampParamsT fireBoxLampParamsT = new IFireBoxLampParamsT();
			this.UnPackTo(fireBoxLampParamsT);
			return fireBoxLampParamsT;
		}

		// Token: 0x06015976 RID: 88438 RVA: 0x0031C9A3 File Offset: 0x0031ABA3
		public void UnPackTo(IFireBoxLampParamsT _o)
		{
			_o.Type = this.Type;
			_o.RangeRadius = this.RangeRadius;
		}

		// Token: 0x06015977 RID: 88439 RVA: 0x0031C9C0 File Offset: 0x0031ABC0
		public static Offset<IFireBoxLampParams> Pack(FlatBufferBuilder builder, IFireBoxLampParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBoxLampParams>);
			}
			return IFireBoxLampParams.CreateIFireBoxLampParams(builder, _o.Type, _o.RangeRadius);
		}

		// Token: 0x0400B857 RID: 47191
		private Table __p;
	}
}
