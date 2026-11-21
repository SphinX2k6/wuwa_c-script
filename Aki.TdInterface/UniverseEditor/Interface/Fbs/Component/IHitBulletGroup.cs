using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F1 RID: 22769
	public struct IHitBulletGroup : IFlatbufferObject
	{
		// Token: 0x1700A525 RID: 42277
		// (get) Token: 0x06024FCE RID: 151502 RVA: 0x00513ADD File Offset: 0x00511CDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FCF RID: 151503 RVA: 0x00513AEA File Offset: 0x00511CEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FD0 RID: 151504 RVA: 0x00513AF4 File Offset: 0x00511CF4
		public static IHitBulletGroup GetRootAsIHitBulletGroup(ByteBuffer _bb)
		{
			return IHitBulletGroup.GetRootAsIHitBulletGroup(_bb, default(IHitBulletGroup));
		}

		// Token: 0x06024FD1 RID: 151505 RVA: 0x00513B10 File Offset: 0x00511D10
		public static IHitBulletGroup GetRootAsIHitBulletGroup(ByteBuffer _bb, IHitBulletGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FD2 RID: 151506 RVA: 0x00513B2D File Offset: 0x00511D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FD3 RID: 151507 RVA: 0x00513B3C File Offset: 0x00511D3C
		public IHitBulletGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A526 RID: 42278
		// (get) Token: 0x06024FD4 RID: 151508 RVA: 0x00513B4C File Offset: 0x00511D4C
		public bool MatchAny
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024FD5 RID: 151509 RVA: 0x00513B8C File Offset: 0x00511D8C
		public THitBulletType HitBulletsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return THitBulletType.NONE;
			}
			return (THitBulletType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A527 RID: 42279
		// (get) Token: 0x06024FD6 RID: 151510 RVA: 0x00513BCC File Offset: 0x00511DCC
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

		// Token: 0x06024FD7 RID: 151511 RVA: 0x00513BF7 File Offset: 0x00511DF7
		public Span<THitBulletType> GetHitBulletsTypeBytes()
		{
			return this.__p.__vector_as_span<THitBulletType>(6, 1);
		}

		// Token: 0x06024FD8 RID: 151512 RVA: 0x00513C08 File Offset: 0x00511E08
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

		// Token: 0x06024FD9 RID: 151513 RVA: 0x00513C74 File Offset: 0x00511E74
		public TTable? HitBullets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A528 RID: 42280
		// (get) Token: 0x06024FDA RID: 151514 RVA: 0x00513CBC File Offset: 0x00511EBC
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

		// Token: 0x06024FDB RID: 151515 RVA: 0x00513CE7 File Offset: 0x00511EE7
		public static Offset<IHitBulletGroup> CreateIHitBulletGroup(FlatBufferBuilder builder, bool MatchAny = false, VectorOffset HitBullets_typeOffset = default(VectorOffset), VectorOffset HitBulletsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IHitBulletGroup.AddHitBullets(builder, HitBulletsOffset);
			IHitBulletGroup.AddHitBulletsType(builder, HitBullets_typeOffset);
			IHitBulletGroup.AddMatchAny(builder, MatchAny);
			return IHitBulletGroup.EndIHitBulletGroup(builder);
		}

		// Token: 0x06024FDC RID: 151516 RVA: 0x00513D0B File Offset: 0x00511F0B
		public static void StartIHitBulletGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024FDD RID: 151517 RVA: 0x00513D14 File Offset: 0x00511F14
		public static void AddMatchAny(FlatBufferBuilder builder, bool matchAny)
		{
			builder.AddBool(0, matchAny, false);
		}

		// Token: 0x06024FDE RID: 151518 RVA: 0x00513D1F File Offset: 0x00511F1F
		public static void AddHitBulletsType(FlatBufferBuilder builder, VectorOffset hitBulletsTypeOffset)
		{
			builder.AddOffset(1, hitBulletsTypeOffset.Value, 0);
		}

		// Token: 0x06024FDF RID: 151519 RVA: 0x00513D30 File Offset: 0x00511F30
		public static VectorOffset CreateHitBulletsTypeVector(FlatBufferBuilder builder, THitBulletType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024FE0 RID: 151520 RVA: 0x00513D67 File Offset: 0x00511F67
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, THitBulletType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<THitBulletType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024FE1 RID: 151521 RVA: 0x00513D81 File Offset: 0x00511F81
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<THitBulletType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<THitBulletType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024FE2 RID: 151522 RVA: 0x00513D9F File Offset: 0x00511F9F
		public static VectorOffset CreateHitBulletsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<THitBulletType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024FE3 RID: 151523 RVA: 0x00513DB8 File Offset: 0x00511FB8
		public static void StartHitBulletsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06024FE4 RID: 151524 RVA: 0x00513DC3 File Offset: 0x00511FC3
		public static void AddHitBullets(FlatBufferBuilder builder, VectorOffset hitBulletsOffset)
		{
			builder.AddOffset(2, hitBulletsOffset.Value, 0);
		}

		// Token: 0x06024FE5 RID: 151525 RVA: 0x00513DD4 File Offset: 0x00511FD4
		public static VectorOffset CreateHitBulletsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024FE6 RID: 151526 RVA: 0x00513E0B File Offset: 0x0051200B
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024FE7 RID: 151527 RVA: 0x00513E25 File Offset: 0x00512025
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024FE8 RID: 151528 RVA: 0x00513E43 File Offset: 0x00512043
		public static VectorOffset CreateHitBulletsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024FE9 RID: 151529 RVA: 0x00513E5C File Offset: 0x0051205C
		public static void StartHitBulletsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024FEA RID: 151530 RVA: 0x00513E67 File Offset: 0x00512067
		public static Offset<IHitBulletGroup> EndIHitBulletGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletGroup>(builder.EndTable());
		}

		// Token: 0x06024FEB RID: 151531 RVA: 0x00513E74 File Offset: 0x00512074
		public IHitBulletGroupT UnPack()
		{
			IHitBulletGroupT hitBulletGroupT = new IHitBulletGroupT();
			this.UnPackTo(hitBulletGroupT);
			return hitBulletGroupT;
		}

		// Token: 0x06024FEC RID: 151532 RVA: 0x00513E90 File Offset: 0x00512090
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

		// Token: 0x06024FED RID: 151533 RVA: 0x00514060 File Offset: 0x00512260
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

		// Token: 0x0400F179 RID: 61817
		private Table __p;
	}
}
