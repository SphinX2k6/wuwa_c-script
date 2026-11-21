using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E74 RID: 15988
	public struct IEnergyFishParams : IFlatbufferObject
	{
		// Token: 0x17006BFD RID: 27645
		// (get) Token: 0x060158E2 RID: 88290 RVA: 0x0031B873 File Offset: 0x00319A73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x0031B880 File Offset: 0x00319A80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158E4 RID: 88292 RVA: 0x0031B888 File Offset: 0x00319A88
		public static IEnergyFishParams GetRootAsIEnergyFishParams(ByteBuffer _bb)
		{
			return IEnergyFishParams.GetRootAsIEnergyFishParams(_bb, default(IEnergyFishParams));
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x0031B8A4 File Offset: 0x00319AA4
		public static IEnergyFishParams GetRootAsIEnergyFishParams(ByteBuffer _bb, IEnergyFishParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x0031B8C1 File Offset: 0x00319AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x0031B8D0 File Offset: 0x00319AD0
		public IEnergyFishParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BFE RID: 27646
		// (get) Token: 0x060158E8 RID: 88296 RVA: 0x0031B8E0 File Offset: 0x00319AE0
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

		// Token: 0x060158E9 RID: 88297 RVA: 0x0031B91C File Offset: 0x00319B1C
		public IEnergyFishStateConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEnergyFishStateConfig?(default(IEnergyFishStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006BFF RID: 27647
		// (get) Token: 0x060158EA RID: 88298 RVA: 0x0031B97C File Offset: 0x00319B7C
		public int ConfigsLength
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

		// Token: 0x060158EB RID: 88299 RVA: 0x0031B9A7 File Offset: 0x00319BA7
		public static Offset<IEnergyFishParams> CreateIEnergyFishParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEnergyFishParams.AddConfigs(builder, ConfigsOffset);
			IEnergyFishParams.AddType(builder, Type);
			return IEnergyFishParams.EndIEnergyFishParams(builder);
		}

		// Token: 0x060158EC RID: 88300 RVA: 0x0031B9C4 File Offset: 0x00319BC4
		public static void StartIEnergyFishParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060158ED RID: 88301 RVA: 0x0031B9CD File Offset: 0x00319BCD
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158EE RID: 88302 RVA: 0x0031B9D8 File Offset: 0x00319BD8
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x060158EF RID: 88303 RVA: 0x0031B9E8 File Offset: 0x00319BE8
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IEnergyFishStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060158F0 RID: 88304 RVA: 0x0031BA28 File Offset: 0x00319C28
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IEnergyFishStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEnergyFishStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060158F1 RID: 88305 RVA: 0x0031BA42 File Offset: 0x00319C42
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEnergyFishStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEnergyFishStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060158F2 RID: 88306 RVA: 0x0031BA60 File Offset: 0x00319C60
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEnergyFishStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x0031BA79 File Offset: 0x00319C79
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060158F4 RID: 88308 RVA: 0x0031BA84 File Offset: 0x00319C84
		public static Offset<IEnergyFishParams> EndIEnergyFishParams(FlatBufferBuilder builder)
		{
			return new Offset<IEnergyFishParams>(builder.EndTable());
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x0031BA94 File Offset: 0x00319C94
		public IEnergyFishParamsT UnPack()
		{
			IEnergyFishParamsT energyFishParamsT = new IEnergyFishParamsT();
			this.UnPackTo(energyFishParamsT);
			return energyFishParamsT;
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x0031BAB0 File Offset: 0x00319CB0
		public void UnPackTo(IEnergyFishParamsT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<IEnergyFishStateConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060158F7 RID: 88311 RVA: 0x0031BB1C File Offset: 0x00319D1C
		public static Offset<IEnergyFishParams> Pack(FlatBufferBuilder builder, IEnergyFishParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnergyFishParams>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IEnergyFishStateConfig>[] array = new Offset<IEnergyFishStateConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEnergyFishStateConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IEnergyFishParams.CreateConfigsVector(builder, array);
			}
			return IEnergyFishParams.CreateIEnergyFishParams(builder, _o.Type, configsOffset);
		}

		// Token: 0x0400B83F RID: 47167
		private Table __p;
	}
}
