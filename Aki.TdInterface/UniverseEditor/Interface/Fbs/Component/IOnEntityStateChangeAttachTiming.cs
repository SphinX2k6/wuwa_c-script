using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3C RID: 23612
	public struct IOnEntityStateChangeAttachTiming : IFlatbufferObject
	{
		// Token: 0x1700AD71 RID: 44401
		// (get) Token: 0x0602723D RID: 160317 RVA: 0x0055CF73 File Offset: 0x0055B173
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602723E RID: 160318 RVA: 0x0055CF80 File Offset: 0x0055B180
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602723F RID: 160319 RVA: 0x0055CF88 File Offset: 0x0055B188
		public static IOnEntityStateChangeAttachTiming GetRootAsIOnEntityStateChangeAttachTiming(ByteBuffer _bb)
		{
			return IOnEntityStateChangeAttachTiming.GetRootAsIOnEntityStateChangeAttachTiming(_bb, default(IOnEntityStateChangeAttachTiming));
		}

		// Token: 0x06027240 RID: 160320 RVA: 0x0055CFA4 File Offset: 0x0055B1A4
		public static IOnEntityStateChangeAttachTiming GetRootAsIOnEntityStateChangeAttachTiming(ByteBuffer _bb, IOnEntityStateChangeAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027241 RID: 160321 RVA: 0x0055CFC1 File Offset: 0x0055B1C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x0055CFD0 File Offset: 0x0055B1D0
		public IOnEntityStateChangeAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD72 RID: 44402
		// (get) Token: 0x06027243 RID: 160323 RVA: 0x0055CFE0 File Offset: 0x0055B1E0
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027244 RID: 160324 RVA: 0x0055D01C File Offset: 0x0055B21C
		public IAttachTimingEntityStateConfig? StateConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IAttachTimingEntityStateConfig?(default(IAttachTimingEntityStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD73 RID: 44403
		// (get) Token: 0x06027245 RID: 160325 RVA: 0x0055D07C File Offset: 0x0055B27C
		public int StateConfigsLength
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

		// Token: 0x06027246 RID: 160326 RVA: 0x0055D0A7 File Offset: 0x0055B2A7
		public static Offset<IOnEntityStateChangeAttachTiming> CreateIOnEntityStateChangeAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default, VectorOffset StateConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IOnEntityStateChangeAttachTiming.AddStateConfigs(builder, StateConfigsOffset);
			IOnEntityStateChangeAttachTiming.AddType(builder, Type);
			return IOnEntityStateChangeAttachTiming.EndIOnEntityStateChangeAttachTiming(builder);
		}

		// Token: 0x06027247 RID: 160327 RVA: 0x0055D0C4 File Offset: 0x0055B2C4
		public static void StartIOnEntityStateChangeAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027248 RID: 160328 RVA: 0x0055D0CD File Offset: 0x0055B2CD
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027249 RID: 160329 RVA: 0x0055D0D8 File Offset: 0x0055B2D8
		public static void AddStateConfigs(FlatBufferBuilder builder, VectorOffset stateConfigsOffset)
		{
			builder.AddOffset(1, stateConfigsOffset.Value, 0);
		}

		// Token: 0x0602724A RID: 160330 RVA: 0x0055D0E8 File Offset: 0x0055B2E8
		public static VectorOffset CreateStateConfigsVector(FlatBufferBuilder builder, Offset<IAttachTimingEntityStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602724B RID: 160331 RVA: 0x0055D128 File Offset: 0x0055B328
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IAttachTimingEntityStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAttachTimingEntityStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602724C RID: 160332 RVA: 0x0055D142 File Offset: 0x0055B342
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAttachTimingEntityStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAttachTimingEntityStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602724D RID: 160333 RVA: 0x0055D160 File Offset: 0x0055B360
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAttachTimingEntityStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602724E RID: 160334 RVA: 0x0055D179 File Offset: 0x0055B379
		public static void StartStateConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602724F RID: 160335 RVA: 0x0055D184 File Offset: 0x0055B384
		public static Offset<IOnEntityStateChangeAttachTiming> EndIOnEntityStateChangeAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IOnEntityStateChangeAttachTiming>(builder.EndTable());
		}

		// Token: 0x06027250 RID: 160336 RVA: 0x0055D194 File Offset: 0x0055B394
		public IOnEntityStateChangeAttachTimingT UnPack()
		{
			IOnEntityStateChangeAttachTimingT onEntityStateChangeAttachTimingT = new IOnEntityStateChangeAttachTimingT();
			this.UnPackTo(onEntityStateChangeAttachTimingT);
			return onEntityStateChangeAttachTimingT;
		}

		// Token: 0x06027251 RID: 160337 RVA: 0x0055D1B0 File Offset: 0x0055B3B0
		public void UnPackTo(IOnEntityStateChangeAttachTimingT _o)
		{
			_o.Type = this.Type;
			_o.StateConfigs = new List<IAttachTimingEntityStateConfigT>();
			for (int i = 0; i < this.StateConfigsLength; i++)
			{
				_o.StateConfigs.Add((this.StateConfigs(i) != null) ? this.StateConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027252 RID: 160338 RVA: 0x0055D21C File Offset: 0x0055B41C
		public static Offset<IOnEntityStateChangeAttachTiming> Pack(FlatBufferBuilder builder, IOnEntityStateChangeAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnEntityStateChangeAttachTiming>);
			}
			VectorOffset stateConfigsOffset = default(VectorOffset);
			if (_o.StateConfigs != null)
			{
				Offset<IAttachTimingEntityStateConfig>[] array = new Offset<IAttachTimingEntityStateConfig>[_o.StateConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAttachTimingEntityStateConfig.Pack(builder, _o.StateConfigs[i]);
				}
				stateConfigsOffset = IOnEntityStateChangeAttachTiming.CreateStateConfigsVector(builder, array);
			}
			return IOnEntityStateChangeAttachTiming.CreateIOnEntityStateChangeAttachTiming(builder, _o.Type, stateConfigsOffset);
		}

		// Token: 0x0400F728 RID: 63272
		private Table __p;
	}
}
