using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x02004387 RID: 17287
	public struct IOfflineEntityComponentConfig : IFlatbufferObject
	{
		// Token: 0x17007A33 RID: 31283
		// (get) Token: 0x06019B73 RID: 105331 RVA: 0x003AEDC0 File Offset: 0x003ACFC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019B74 RID: 105332 RVA: 0x003AEDCD File Offset: 0x003ACFCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019B75 RID: 105333 RVA: 0x003AEDD4 File Offset: 0x003ACFD4
		public static IOfflineEntityComponentConfig GetRootAsIOfflineEntityComponentConfig(ByteBuffer _bb)
		{
			return IOfflineEntityComponentConfig.GetRootAsIOfflineEntityComponentConfig(_bb, default(IOfflineEntityComponentConfig));
		}

		// Token: 0x06019B76 RID: 105334 RVA: 0x003AEDF0 File Offset: 0x003ACFF0
		public static IOfflineEntityComponentConfig GetRootAsIOfflineEntityComponentConfig(ByteBuffer _bb, IOfflineEntityComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019B77 RID: 105335 RVA: 0x003AEE0D File Offset: 0x003AD00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019B78 RID: 105336 RVA: 0x003AEE1C File Offset: 0x003AD01C
		public IOfflineEntityComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019B79 RID: 105337 RVA: 0x003AEE2C File Offset: 0x003AD02C
		public EComponent Components(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return EComponent.AirWallSpawnerComponent;
			}
			return (EComponent)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A34 RID: 31284
		// (get) Token: 0x06019B7A RID: 105338 RVA: 0x003AEE6C File Offset: 0x003AD06C
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

		// Token: 0x06019B7B RID: 105339 RVA: 0x003AEE97 File Offset: 0x003AD097
		public Span<EComponent> GetComponentsBytes()
		{
			return this.__p.__vector_as_span<EComponent>(4, 1);
		}

		// Token: 0x06019B7C RID: 105340 RVA: 0x003AEEA8 File Offset: 0x003AD0A8
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

		// Token: 0x06019B7D RID: 105341 RVA: 0x003AEF11 File Offset: 0x003AD111
		public static Offset<IOfflineEntityComponentConfig> CreateIOfflineEntityComponentConfig(FlatBufferBuilder builder, VectorOffset ComponentsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IOfflineEntityComponentConfig.AddComponents(builder, ComponentsOffset);
			return IOfflineEntityComponentConfig.EndIOfflineEntityComponentConfig(builder);
		}

		// Token: 0x06019B7E RID: 105342 RVA: 0x003AEF27 File Offset: 0x003AD127
		public static void StartIOfflineEntityComponentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019B7F RID: 105343 RVA: 0x003AEF30 File Offset: 0x003AD130
		public static void AddComponents(FlatBufferBuilder builder, VectorOffset componentsOffset)
		{
			builder.AddOffset(0, componentsOffset.Value, 0);
		}

		// Token: 0x06019B80 RID: 105344 RVA: 0x003AEF40 File Offset: 0x003AD140
		public static VectorOffset CreateComponentsVector(FlatBufferBuilder builder, EComponent[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019B81 RID: 105345 RVA: 0x003AEF77 File Offset: 0x003AD177
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, EComponent[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EComponent>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B82 RID: 105346 RVA: 0x003AEF91 File Offset: 0x003AD191
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, ArraySegment<EComponent> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EComponent>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B83 RID: 105347 RVA: 0x003AEFAF File Offset: 0x003AD1AF
		public static VectorOffset CreateComponentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EComponent>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019B84 RID: 105348 RVA: 0x003AEFC8 File Offset: 0x003AD1C8
		public static void StartComponentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019B85 RID: 105349 RVA: 0x003AEFD3 File Offset: 0x003AD1D3
		public static Offset<IOfflineEntityComponentConfig> EndIOfflineEntityComponentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOfflineEntityComponentConfig>(builder.EndTable());
		}

		// Token: 0x06019B86 RID: 105350 RVA: 0x003AEFE0 File Offset: 0x003AD1E0
		public IOfflineEntityComponentConfigT UnPack()
		{
			IOfflineEntityComponentConfigT offlineEntityComponentConfigT = new IOfflineEntityComponentConfigT();
			this.UnPackTo(offlineEntityComponentConfigT);
			return offlineEntityComponentConfigT;
		}

		// Token: 0x06019B87 RID: 105351 RVA: 0x003AEFFC File Offset: 0x003AD1FC
		public void UnPackTo(IOfflineEntityComponentConfigT _o)
		{
			_o.Components = new List<EComponent>();
			for (int i = 0; i < this.ComponentsLength; i++)
			{
				_o.Components.Add(this.Components(i));
			}
		}

		// Token: 0x06019B88 RID: 105352 RVA: 0x003AF038 File Offset: 0x003AD238
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

		// Token: 0x0400C1B0 RID: 49584
		private Table __p;
	}
}
