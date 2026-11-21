using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBE RID: 3518
	public struct FurniturePresetConfig : IFlatbufferObject
	{
		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x00263D4A File Offset: 0x00261F4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00263D57 File Offset: 0x00261F57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x00263D60 File Offset: 0x00261F60
		public static FurniturePresetConfig GetRootAsFurniturePresetConfig(ByteBuffer _bb)
		{
			return FurniturePresetConfig.GetRootAsFurniturePresetConfig(_bb, default(FurniturePresetConfig));
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x00263D7C File Offset: 0x00261F7C
		public static FurniturePresetConfig GetRootAsFurniturePresetConfig(ByteBuffer _bb, FurniturePresetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x00263D99 File Offset: 0x00261F99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x00263DA8 File Offset: 0x00261FA8
		public FurniturePresetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x00263DB8 File Offset: 0x00261FB8
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x00263DF4 File Offset: 0x00261FF4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00263E2B File Offset: 0x0026202B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00263E3A File Offset: 0x0026203A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06007DDA RID: 32218 RVA: 0x00263E54 File Offset: 0x00262054
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x00263E8B File Offset: 0x0026208B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00263E9A File Offset: 0x0026209A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x00263EB4 File Offset: 0x002620B4
		public DicIntIntArray? FurniturePlaceInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06007DDE RID: 32222 RVA: 0x00263F18 File Offset: 0x00262118
		public int FurniturePlaceInfoLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x00263F44 File Offset: 0x00262144
		[NullableContext(1)]
		public Dictionary<int, IntArray> FurniturePlaceInfo()
		{
			return this.FurniturePlaceInfoIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x00263F9A File Offset: 0x0026219A
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> FurniturePlaceInfoIter()
		{
			FurniturePresetConfig.<FurniturePlaceInfoIter>d__22 <FurniturePlaceInfoIter>d__ = new FurniturePresetConfig.<FurniturePlaceInfoIter>d__22(-2);
			<FurniturePlaceInfoIter>d__.<>3__<>4__this = this;
			return <FurniturePlaceInfoIter>d__;
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00263FB0 File Offset: 0x002621B0
		public IntArray? GetFurniturePlaceInfo(int key)
		{
			this.EnsureFurniturePlaceInfoCacheIfNeeded();
			IntArray value;
			if (!this.FurniturePlaceInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x00263FE4 File Offset: 0x002621E4
		private void EnsureFurniturePlaceInfoCacheIfNeeded()
		{
			if (this.FurniturePlaceInfoCache != null)
			{
				return;
			}
			this.FurniturePlaceInfoCache = this.FurniturePlaceInfoIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x0026404A File Offset: 0x0026224A
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetFurniturePlaceInfoFrozenDict()
		{
			this.EnsureFurniturePlaceInfoCacheIfNeeded();
			return this.FurniturePlaceInfoCache;
		}

		// Token: 0x0400532E RID: 21294
		private Table __p;

		// Token: 0x0400532F RID: 21295
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> FurniturePlaceInfoCache;
	}
}
