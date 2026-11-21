using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C0 RID: 25024
	public struct IWuWaGoGear : IFlatbufferObject
	{
		// Token: 0x1700BA96 RID: 47766
		// (get) Token: 0x0602A8AD RID: 174253 RVA: 0x005CD458 File Offset: 0x005CB658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A8AE RID: 174254 RVA: 0x005CD465 File Offset: 0x005CB665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A8AF RID: 174255 RVA: 0x005CD46C File Offset: 0x005CB66C
		public static IWuWaGoGear GetRootAsIWuWaGoGear(ByteBuffer _bb)
		{
			return IWuWaGoGear.GetRootAsIWuWaGoGear(_bb, default(IWuWaGoGear));
		}

		// Token: 0x0602A8B0 RID: 174256 RVA: 0x005CD488 File Offset: 0x005CB688
		public static IWuWaGoGear GetRootAsIWuWaGoGear(ByteBuffer _bb, IWuWaGoGear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A8B1 RID: 174257 RVA: 0x005CD4A5 File Offset: 0x005CB6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A8B2 RID: 174258 RVA: 0x005CD4B4 File Offset: 0x005CB6B4
		public IWuWaGoGear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA97 RID: 47767
		// (get) Token: 0x0602A8B3 RID: 174259 RVA: 0x005CD4C4 File Offset: 0x005CB6C4
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A8B4 RID: 174260 RVA: 0x005CD500 File Offset: 0x005CB700
		public int GridEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BA98 RID: 47768
		// (get) Token: 0x0602A8B5 RID: 174261 RVA: 0x005CD540 File Offset: 0x005CB740
		public int GridEntityIdsLength
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

		// Token: 0x0602A8B6 RID: 174262 RVA: 0x005CD56B File Offset: 0x005CB76B
		public Span<int> GetGridEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602A8B7 RID: 174263 RVA: 0x005CD57A File Offset: 0x005CB77A
		public int[] GetGridEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602A8B8 RID: 174264 RVA: 0x005CD588 File Offset: 0x005CB788
		public static Offset<IWuWaGoGear> CreateIWuWaGoGear(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, VectorOffset GridEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoGear.AddGridEntityIds(builder, GridEntityIdsOffset);
			IWuWaGoGear.AddType(builder, Type);
			return IWuWaGoGear.EndIWuWaGoGear(builder);
		}

		// Token: 0x0602A8B9 RID: 174265 RVA: 0x005CD5A5 File Offset: 0x005CB7A5
		public static void StartIWuWaGoGear(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A8BA RID: 174266 RVA: 0x005CD5AE File Offset: 0x005CB7AE
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A8BB RID: 174267 RVA: 0x005CD5B9 File Offset: 0x005CB7B9
		public static void AddGridEntityIds(FlatBufferBuilder builder, VectorOffset gridEntityIdsOffset)
		{
			builder.AddOffset(1, gridEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602A8BC RID: 174268 RVA: 0x005CD5CC File Offset: 0x005CB7CC
		public static VectorOffset CreateGridEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A8BD RID: 174269 RVA: 0x005CD603 File Offset: 0x005CB803
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A8BE RID: 174270 RVA: 0x005CD61D File Offset: 0x005CB81D
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A8BF RID: 174271 RVA: 0x005CD63B File Offset: 0x005CB83B
		public static VectorOffset CreateGridEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A8C0 RID: 174272 RVA: 0x005CD654 File Offset: 0x005CB854
		public static void StartGridEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A8C1 RID: 174273 RVA: 0x005CD65F File Offset: 0x005CB85F
		public static Offset<IWuWaGoGear> EndIWuWaGoGear(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGear>(builder.EndTable());
		}

		// Token: 0x0602A8C2 RID: 174274 RVA: 0x005CD66C File Offset: 0x005CB86C
		public IWuWaGoGearT UnPack()
		{
			IWuWaGoGearT wuWaGoGearT = new IWuWaGoGearT();
			this.UnPackTo(wuWaGoGearT);
			return wuWaGoGearT;
		}

		// Token: 0x0602A8C3 RID: 174275 RVA: 0x005CD688 File Offset: 0x005CB888
		public void UnPackTo(IWuWaGoGearT _o)
		{
			_o.Type = this.Type;
			_o.GridEntityIds = new List<int>();
			for (int i = 0; i < this.GridEntityIdsLength; i++)
			{
				_o.GridEntityIds.Add(this.GridEntityIds(i));
			}
		}

		// Token: 0x0602A8C4 RID: 174276 RVA: 0x005CD6D0 File Offset: 0x005CB8D0
		public static Offset<IWuWaGoGear> Pack(FlatBufferBuilder builder, IWuWaGoGearT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGear>);
			}
			VectorOffset gridEntityIdsOffset = default(VectorOffset);
			if (_o.GridEntityIds != null)
			{
				int[] data = _o.GridEntityIds.ToArray();
				gridEntityIdsOffset = IWuWaGoGear.CreateGridEntityIdsVector(builder, data);
			}
			return IWuWaGoGear.CreateIWuWaGoGear(builder, _o.Type, gridEntityIdsOffset);
		}

		// Token: 0x04010022 RID: 65570
		private Table __p;
	}
}
