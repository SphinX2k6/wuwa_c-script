using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005787 RID: 22407
	public struct IProceduralMaterialComponent : IFlatbufferObject
	{
		// Token: 0x1700A722 RID: 42786
		// (get) Token: 0x06025907 RID: 153863 RVA: 0x0052E813 File Offset: 0x0052CA13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025908 RID: 153864 RVA: 0x0052E820 File Offset: 0x0052CA20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025909 RID: 153865 RVA: 0x0052E828 File Offset: 0x0052CA28
		public static IProceduralMaterialComponent GetRootAsIProceduralMaterialComponent(ByteBuffer _bb)
		{
			return IProceduralMaterialComponent.GetRootAsIProceduralMaterialComponent(_bb, default(IProceduralMaterialComponent));
		}

		// Token: 0x0602590A RID: 153866 RVA: 0x0052E844 File Offset: 0x0052CA44
		public static IProceduralMaterialComponent GetRootAsIProceduralMaterialComponent(ByteBuffer _bb, IProceduralMaterialComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602590B RID: 153867 RVA: 0x0052E861 File Offset: 0x0052CA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602590C RID: 153868 RVA: 0x0052E870 File Offset: 0x0052CA70
		public IProceduralMaterialComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A723 RID: 42787
		// (get) Token: 0x0602590D RID: 153869 RVA: 0x0052E880 File Offset: 0x0052CA80
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602590E RID: 153870 RVA: 0x0052E8C0 File Offset: 0x0052CAC0
		public ICustomPrimitiveDataConfig? ProceduralMaterialConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPrimitiveDataConfig?(default(ICustomPrimitiveDataConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A724 RID: 42788
		// (get) Token: 0x0602590F RID: 153871 RVA: 0x0052E920 File Offset: 0x0052CB20
		public int ProceduralMaterialConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A725 RID: 42789
		// (get) Token: 0x06025910 RID: 153872 RVA: 0x0052E94C File Offset: 0x0052CB4C
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

		// Token: 0x06025911 RID: 153873 RVA: 0x0052E988 File Offset: 0x0052CB88
		public static Offset<IProceduralMaterialComponent> CreateIProceduralMaterialComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ProceduralMaterialConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IProceduralMaterialComponent.AddProceduralMaterialConfigs(builder, ProceduralMaterialConfigsOffset);
			IProceduralMaterialComponent.AddNullMask(builder, NullMask);
			IProceduralMaterialComponent.AddDisabled(builder, Disabled);
			return IProceduralMaterialComponent.EndIProceduralMaterialComponent(builder);
		}

		// Token: 0x06025912 RID: 153874 RVA: 0x0052E9AC File Offset: 0x0052CBAC
		public static void StartIProceduralMaterialComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025913 RID: 153875 RVA: 0x0052E9B5 File Offset: 0x0052CBB5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025914 RID: 153876 RVA: 0x0052E9C0 File Offset: 0x0052CBC0
		public static void AddProceduralMaterialConfigs(FlatBufferBuilder builder, VectorOffset proceduralMaterialConfigsOffset)
		{
			builder.AddOffset(1, proceduralMaterialConfigsOffset.Value, 0);
		}

		// Token: 0x06025915 RID: 153877 RVA: 0x0052E9D0 File Offset: 0x0052CBD0
		public static VectorOffset CreateProceduralMaterialConfigsVector(FlatBufferBuilder builder, Offset<ICustomPrimitiveDataConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025916 RID: 153878 RVA: 0x0052EA10 File Offset: 0x0052CC10
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICustomPrimitiveDataConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025917 RID: 153879 RVA: 0x0052EA2A File Offset: 0x0052CC2A
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPrimitiveDataConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025918 RID: 153880 RVA: 0x0052EA48 File Offset: 0x0052CC48
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025919 RID: 153881 RVA: 0x0052EA61 File Offset: 0x0052CC61
		public static void StartProceduralMaterialConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602591A RID: 153882 RVA: 0x0052EA6C File Offset: 0x0052CC6C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602591B RID: 153883 RVA: 0x0052EA77 File Offset: 0x0052CC77
		public static Offset<IProceduralMaterialComponent> EndIProceduralMaterialComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralMaterialComponent>(builder.EndTable());
		}

		// Token: 0x0602591C RID: 153884 RVA: 0x0052EA84 File Offset: 0x0052CC84
		public IProceduralMaterialComponentT UnPack()
		{
			IProceduralMaterialComponentT proceduralMaterialComponentT = new IProceduralMaterialComponentT();
			this.UnPackTo(proceduralMaterialComponentT);
			return proceduralMaterialComponentT;
		}

		// Token: 0x0602591D RID: 153885 RVA: 0x0052EAA0 File Offset: 0x0052CCA0
		public void UnPackTo(IProceduralMaterialComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ProceduralMaterialConfigs = new List<ICustomPrimitiveDataConfigT>();
			for (int i = 0; i < this.ProceduralMaterialConfigsLength; i++)
			{
				_o.ProceduralMaterialConfigs.Add((this.ProceduralMaterialConfigs(i) != null) ? this.ProceduralMaterialConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602591E RID: 153886 RVA: 0x0052EB18 File Offset: 0x0052CD18
		public static Offset<IProceduralMaterialComponent> Pack(FlatBufferBuilder builder, IProceduralMaterialComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralMaterialComponent>);
			}
			VectorOffset proceduralMaterialConfigsOffset = default(VectorOffset);
			if (_o.ProceduralMaterialConfigs != null)
			{
				Offset<ICustomPrimitiveDataConfig>[] array = new Offset<ICustomPrimitiveDataConfig>[_o.ProceduralMaterialConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICustomPrimitiveDataConfig.Pack(builder, _o.ProceduralMaterialConfigs[i]);
				}
				proceduralMaterialConfigsOffset = IProceduralMaterialComponent.CreateProceduralMaterialConfigsVector(builder, array);
			}
			return IProceduralMaterialComponent.CreateIProceduralMaterialComponent(builder, _o.Disabled, proceduralMaterialConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400EC35 RID: 60469
		private Table __p;
	}
}
