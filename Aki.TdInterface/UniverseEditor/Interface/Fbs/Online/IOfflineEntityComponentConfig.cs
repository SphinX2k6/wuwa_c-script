using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x020047E9 RID: 18409
	public struct IOfflineEntityComponentConfig : IFlatbufferObject
	{
		// Token: 0x17008068 RID: 32872
		// (get) Token: 0x0601B301 RID: 111361 RVA: 0x003DA7E8 File Offset: 0x003D89E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B302 RID: 111362 RVA: 0x003DA7F5 File Offset: 0x003D89F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B303 RID: 111363 RVA: 0x003DA7FC File Offset: 0x003D89FC
		public static IOfflineEntityComponentConfig GetRootAsIOfflineEntityComponentConfig(ByteBuffer _bb)
		{
			return IOfflineEntityComponentConfig.GetRootAsIOfflineEntityComponentConfig(_bb, default(IOfflineEntityComponentConfig));
		}

		// Token: 0x0601B304 RID: 111364 RVA: 0x003DA818 File Offset: 0x003D8A18
		public static IOfflineEntityComponentConfig GetRootAsIOfflineEntityComponentConfig(ByteBuffer _bb, IOfflineEntityComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B305 RID: 111365 RVA: 0x003DA835 File Offset: 0x003D8A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B306 RID: 111366 RVA: 0x003DA844 File Offset: 0x003D8A44
		public IOfflineEntityComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B307 RID: 111367 RVA: 0x003DA854 File Offset: 0x003D8A54
		public EComponent Components(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EComponent.AirWallSpawnerComponent;
			}
			return (EComponent)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008069 RID: 32873
		// (get) Token: 0x0601B308 RID: 111368 RVA: 0x003DA894 File Offset: 0x003D8A94
		public int ComponentsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601B309 RID: 111369 RVA: 0x003DA8BF File Offset: 0x003D8ABF
		public Span<EComponent> GetComponentsBytes()
		{
			return this.__p.__vector_as_span<EComponent>(4, 1);
		}

		// Token: 0x0601B30A RID: 111370 RVA: 0x003DA8D0 File Offset: 0x003D8AD0
		public EComponent[] GetComponentsArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EComponent[] array = new EComponent[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EComponent)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601B30B RID: 111371 RVA: 0x003DA939 File Offset: 0x003D8B39
		public static Offset<IOfflineEntityComponentConfig> CreateIOfflineEntityComponentConfig(FlatBufferBuilder builder, VectorOffset ComponentsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IOfflineEntityComponentConfig.AddComponents(builder, ComponentsOffset);
			return IOfflineEntityComponentConfig.EndIOfflineEntityComponentConfig(builder);
		}

		// Token: 0x0601B30C RID: 111372 RVA: 0x003DA94F File Offset: 0x003D8B4F
		public static void StartIOfflineEntityComponentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B30D RID: 111373 RVA: 0x003DA958 File Offset: 0x003D8B58
		public static void AddComponents(FlatBufferBuilder builder, VectorOffset componentsOffset)
		{
			builder.AddOffset(0, componentsOffset.Value, 0);
		}

		// Token: 0x0601B30E RID: 111374 RVA: 0x003DA968 File Offset: 0x003D8B68
		public static VectorOffset CreateComponentsVector(FlatBufferBuilder builder, EComponent[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B30F RID: 111375 RVA: 0x003DA99F File Offset: 0x003D8B9F
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, EComponent[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EComponent>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B310 RID: 111376 RVA: 0x003DA9B9 File Offset: 0x003D8BB9
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, ArraySegment<EComponent> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EComponent>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B311 RID: 111377 RVA: 0x003DA9D7 File Offset: 0x003D8BD7
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EComponent>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B312 RID: 111378 RVA: 0x003DA9F0 File Offset: 0x003D8BF0
		public static void StartComponentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B313 RID: 111379 RVA: 0x003DA9FB File Offset: 0x003D8BFB
		public static Offset<IOfflineEntityComponentConfig> EndIOfflineEntityComponentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOfflineEntityComponentConfig>(builder.EndTable());
		}

		// Token: 0x0601B314 RID: 111380 RVA: 0x003DAA08 File Offset: 0x003D8C08
		public IOfflineEntityComponentConfigT UnPack()
		{
			IOfflineEntityComponentConfigT offlineEntityComponentConfigT = new IOfflineEntityComponentConfigT();
			this.UnPackTo(offlineEntityComponentConfigT);
			return offlineEntityComponentConfigT;
		}

		// Token: 0x0601B315 RID: 111381 RVA: 0x003DAA24 File Offset: 0x003D8C24
		public void UnPackTo(IOfflineEntityComponentConfigT _o)
		{
			_o.Components = new List<EComponent>();
			for (int i = 0; i < this.ComponentsLength; i++)
			{
				_o.Components.Add(this.Components(i));
			}
		}

		// Token: 0x0601B316 RID: 111382 RVA: 0x003DAA60 File Offset: 0x003D8C60
		public static Offset<IOfflineEntityComponentConfig> Pack(FlatBufferBuilder builder, IOfflineEntityComponentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOfflineEntityComponentConfig>);
			}
			VectorOffset componentsOffset = default(VectorOffset);
			if (_o.Components != null)
			{
				EComponent[] data = _o.Components.ToArray();
				componentsOffset = IOfflineEntityComponentConfig.CreateComponentsVector(builder, data);
			}
			return IOfflineEntityComponentConfig.CreateIOfflineEntityComponentConfig(builder, componentsOffset);
		}

		// Token: 0x0400CBCE RID: 52174
		private Table __p;
	}
}
