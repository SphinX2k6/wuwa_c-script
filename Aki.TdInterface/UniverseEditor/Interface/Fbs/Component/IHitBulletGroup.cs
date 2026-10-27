using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536B RID: 21355
	public struct IHitBulletGroup : IFlatbufferObject
	{
		// Token: 0x17009CED RID: 40173
		// (get) Token: 0x06022F1A RID: 143130 RVA: 0x004D6C09 File Offset: 0x004D4E09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F1B RID: 143131 RVA: 0x004D6C16 File Offset: 0x004D4E16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F1C RID: 143132 RVA: 0x004D6C20 File Offset: 0x004D4E20
		public static IHitBulletGroup GetRootAsIHitBulletGroup(ByteBuffer _bb)
		{
			return IHitBulletGroup.GetRootAsIHitBulletGroup(_bb, default(IHitBulletGroup));
		}

		// Token: 0x06022F1D RID: 143133 RVA: 0x004D6C3C File Offset: 0x004D4E3C
		public static IHitBulletGroup GetRootAsIHitBulletGroup(ByteBuffer _bb, IHitBulletGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F1E RID: 143134 RVA: 0x004D6C59 File Offset: 0x004D4E59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F1F RID: 143135 RVA: 0x004D6C68 File Offset: 0x004D4E68
		public IHitBulletGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CEE RID: 40174
		// (get) Token: 0x06022F20 RID: 143136 RVA: 0x004D6C78 File Offset: 0x004D4E78
		public bool MatchAny
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022F21 RID: 143137 RVA: 0x004D6CB8 File Offset: 0x004D4EB8
		public THitBulletType HitBulletsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return THitBulletType.NONE;
			}
			return (THitBulletType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009CEF RID: 40175
		// (get) Token: 0x06022F22 RID: 143138 RVA: 0x004D6CF8 File Offset: 0x004D4EF8
		public int HitBulletsTypeLength
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

		// Token: 0x06022F23 RID: 143139 RVA: 0x004D6D23 File Offset: 0x004D4F23
		public Span<THitBulletType> GetHitBulletsTypeBytes()
		{
			return this.__p.__vector_as_span<THitBulletType>(6, 1);
		}

		// Token: 0x06022F24 RID: 143140 RVA: 0x004D6D34 File Offset: 0x004D4F34
		public THitBulletType[] GetHitBulletsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			THitBulletType[] array = new THitBulletType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (THitBulletType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06022F25 RID: 143141 RVA: 0x004D6DA0 File Offset: 0x004D4FA0
		public TTable? HitBullets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009CF0 RID: 40176
		// (get) Token: 0x06022F26 RID: 143142 RVA: 0x004D6DE8 File Offset: 0x004D4FE8
		public int HitBulletsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022F27 RID: 143143 RVA: 0x004D6E13 File Offset: 0x004D5013
		public static Offset<IHitBulletGroup> CreateIHitBulletGroup(FlatBufferBuilder builder, bool MatchAny = false, VectorOffset HitBullets_typeOffset = default(VectorOffset), VectorOffset HitBulletsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IHitBulletGroup.AddHitBullets(builder, HitBulletsOffset);
			IHitBulletGroup.AddHitBulletsType(builder, HitBullets_typeOffset);
			IHitBulletGroup.AddMatchAny(builder, MatchAny);
			return IHitBulletGroup.EndIHitBulletGroup(builder);
		}

		// Token: 0x06022F28 RID: 143144 RVA: 0x004D6E37 File Offset: 0x004D5037
		public static void StartIHitBulletGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022F29 RID: 143145 RVA: 0x004D6E40 File Offset: 0x004D5040
		public static void AddMatchAny(FlatBufferBuilder builder, bool matchAny)
		{
			builder.AddBool(0, matchAny, false);
		}

		// Token: 0x06022F2A RID: 143146 RVA: 0x004D6E4B File Offset: 0x004D504B
		public static void AddHitBulletsType(FlatBufferBuilder builder, VectorOffset hitBulletsTypeOffset)
		{
			builder.AddOffset(1, hitBulletsTypeOffset.Value, 0);
		}

		// Token: 0x06022F2B RID: 143147 RVA: 0x004D6E5C File Offset: 0x004D505C
		public static VectorOffset CreateHitBulletsTypeVector(FlatBufferBuilder builder, THitBulletType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022F2C RID: 143148 RVA: 0x004D6E93 File Offset: 0x004D5093
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, THitBulletType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<THitBulletType>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x004D6EAD File Offset: 0x004D50AD
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<THitBulletType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<THitBulletType>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x004D6ECB File Offset: 0x004D50CB
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<THitBulletType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022F2F RID: 143151 RVA: 0x004D6EE4 File Offset: 0x004D50E4
		public static void StartHitBulletsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06022F30 RID: 143152 RVA: 0x004D6EEF File Offset: 0x004D50EF
		public static void AddHitBullets(FlatBufferBuilder builder, VectorOffset hitBulletsOffset)
		{
			builder.AddOffset(2, hitBulletsOffset.Value, 0);
		}

		// Token: 0x06022F31 RID: 143153 RVA: 0x004D6F00 File Offset: 0x004D5100
		public static VectorOffset CreateHitBulletsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022F32 RID: 143154 RVA: 0x004D6F37 File Offset: 0x004D5137
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F33 RID: 143155 RVA: 0x004D6F51 File Offset: 0x004D5151
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022F34 RID: 143156 RVA: 0x004D6F6F File Offset: 0x004D516F
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022F35 RID: 143157 RVA: 0x004D6F88 File Offset: 0x004D5188
		public static void StartHitBulletsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022F36 RID: 143158 RVA: 0x004D6F93 File Offset: 0x004D5193
		public static Offset<IHitBulletGroup> EndIHitBulletGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletGroup>(builder.EndTable());
		}

		// Token: 0x06022F37 RID: 143159 RVA: 0x004D6FA0 File Offset: 0x004D51A0
		public IHitBulletGroupT UnPack()
		{
			IHitBulletGroupT hitBulletGroupT = new IHitBulletGroupT();
			this.UnPackTo(hitBulletGroupT);
			return hitBulletGroupT;
		}

		// Token: 0x06022F38 RID: 143160 RVA: 0x004D6FBC File Offset: 0x004D51BC
		public void UnPackTo(IHitBulletGroupT _o)
		{
			_o.MatchAny = this.MatchAny;
			_o.HitBullets = new List<THitBulletTypeUnion>();
			for (int i = 0; i < this.HitBulletsLength; i++)
			{
				THitBulletTypeUnion thitBulletTypeUnion = new THitBulletTypeUnion();
				thitBulletTypeUnion.Type = this.HitBulletsType(i);
				switch (this.HitBulletsType(i))
				{
				case THitBulletType.IHitBulletTypeAllCharacterAttack:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypeAllCharacterAttack>(i) != null) ? this.HitBullets<IHitBulletTypeAllCharacterAttack>(i).Value.UnPack() : null);
					break;
				case THitBulletType.IHitBulletTypeCrystalAttack:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypeCrystalAttack>(i) != null) ? this.HitBullets<IHitBulletTypeCrystalAttack>(i).Value.UnPack() : null);
					break;
				case THitBulletType.IHitBulletTypeFixedBulletId:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypeFixedBulletId>(i) != null) ? this.HitBullets<IHitBulletTypeFixedBulletId>(i).Value.UnPack() : null);
					break;
				case THitBulletType.IHitBulletTypeOnlyDropAttack:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypeOnlyDropAttack>(i) != null) ? this.HitBullets<IHitBulletTypeOnlyDropAttack>(i).Value.UnPack() : null);
					break;
				case THitBulletType.IHitBulletTypePlayerAttack:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypePlayerAttack>(i) != null) ? this.HitBullets<IHitBulletTypePlayerAttack>(i).Value.UnPack() : null);
					break;
				case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
					thitBulletTypeUnion.Value = ((this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>(i) != null) ? this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>(i).Value.UnPack() : null);
					break;
				}
				_o.HitBullets.Add(thitBulletTypeUnion);
			}
		}

		// Token: 0x06022F39 RID: 143161 RVA: 0x004D718C File Offset: 0x004D538C
		public static Offset<IHitBulletGroup> Pack(FlatBufferBuilder builder, IHitBulletGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletGroup>);
			}
			VectorOffset hitBullets_typeOffset = default(VectorOffset);
			if (_o.HitBullets != null)
			{
				THitBulletType[] array = new THitBulletType[_o.HitBullets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.HitBullets[i].Type;
				}
				hitBullets_typeOffset = IHitBulletGroup.CreateHitBulletsTypeVector(builder, array);
			}
			VectorOffset hitBulletsOffset = default(VectorOffset);
			if (_o.HitBullets != null)
			{
				int[] array2 = new int[_o.HitBullets.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = THitBulletTypeUnion.Pack(builder, _o.HitBullets[j]);
				}
				hitBulletsOffset = IHitBulletGroup.CreateHitBulletsVector(builder, array2);
			}
			return IHitBulletGroup.CreateIHitBulletGroup(builder, _o.MatchAny, hitBullets_typeOffset, hitBulletsOffset);
		}

		// Token: 0x0400E549 RID: 58697
		private Table __p;
	}
}
