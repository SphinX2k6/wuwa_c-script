using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBA RID: 28602
	public struct ISetBattleTag : IFlatbufferObject
	{
		// Token: 0x1700D45D RID: 54365
		// (get) Token: 0x060328CE RID: 207054 RVA: 0x006D2615 File Offset: 0x006D0815
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328CF RID: 207055 RVA: 0x006D2622 File Offset: 0x006D0822
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328D0 RID: 207056 RVA: 0x006D262C File Offset: 0x006D082C
		public static ISetBattleTag GetRootAsISetBattleTag(ByteBuffer _bb)
		{
			return ISetBattleTag.GetRootAsISetBattleTag(_bb, default(ISetBattleTag));
		}

		// Token: 0x060328D1 RID: 207057 RVA: 0x006D2648 File Offset: 0x006D0848
		public static ISetBattleTag GetRootAsISetBattleTag(ByteBuffer _bb, ISetBattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328D2 RID: 207058 RVA: 0x006D2665 File Offset: 0x006D0865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328D3 RID: 207059 RVA: 0x006D2674 File Offset: 0x006D0874
		public ISetBattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D45E RID: 54366
		// (get) Token: 0x060328D4 RID: 207060 RVA: 0x006D2684 File Offset: 0x006D0884
		public ESetBattleStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return (ESetBattleStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060328D5 RID: 207061 RVA: 0x006D26C0 File Offset: 0x006D08C0
		public ISetEntityTag? SetTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetEntityTag?(default(ISetEntityTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D45F RID: 54367
		// (get) Token: 0x060328D6 RID: 207062 RVA: 0x006D2720 File Offset: 0x006D0920
		public int SetTagsLength
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

		// Token: 0x060328D7 RID: 207063 RVA: 0x006D274B File Offset: 0x006D094B
		public static Offset<ISetBattleTag> CreateISetBattleTag(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag, VectorOffset SetTagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetBattleTag.AddSetTags(builder, SetTagsOffset);
			ISetBattleTag.AddType(builder, Type);
			return ISetBattleTag.EndISetBattleTag(builder);
		}

		// Token: 0x060328D8 RID: 207064 RVA: 0x006D2768 File Offset: 0x006D0968
		public static void StartISetBattleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060328D9 RID: 207065 RVA: 0x006D2771 File Offset: 0x006D0971
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060328DA RID: 207066 RVA: 0x006D277C File Offset: 0x006D097C
		public static void AddSetTags(FlatBufferBuilder builder, VectorOffset setTagsOffset)
		{
			builder.AddOffset(1, setTagsOffset.Value, 0);
		}

		// Token: 0x060328DB RID: 207067 RVA: 0x006D278C File Offset: 0x006D098C
		public static VectorOffset CreateSetTagsVector(FlatBufferBuilder builder, Offset<ISetEntityTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060328DC RID: 207068 RVA: 0x006D27CC File Offset: 0x006D09CC
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, Offset<ISetEntityTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetEntityTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060328DD RID: 207069 RVA: 0x006D27E6 File Offset: 0x006D09E6
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetEntityTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetEntityTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060328DE RID: 207070 RVA: 0x006D2804 File Offset: 0x006D0A04
		public static VectorOffset CreateSetTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetEntityTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060328DF RID: 207071 RVA: 0x006D281D File Offset: 0x006D0A1D
		public static void StartSetTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060328E0 RID: 207072 RVA: 0x006D2828 File Offset: 0x006D0A28
		public static Offset<ISetBattleTag> EndISetBattleTag(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTag>(builder.EndTable());
		}

		// Token: 0x060328E1 RID: 207073 RVA: 0x006D2838 File Offset: 0x006D0A38
		public ISetBattleTagT UnPack()
		{
			ISetBattleTagT setBattleTagT = new ISetBattleTagT();
			this.UnPackTo(setBattleTagT);
			return setBattleTagT;
		}

		// Token: 0x060328E2 RID: 207074 RVA: 0x006D2854 File Offset: 0x006D0A54
		public void UnPackTo(ISetBattleTagT _o)
		{
			_o.Type = this.Type;
			_o.SetTags = new List<ISetEntityTagT>();
			for (int i = 0; i < this.SetTagsLength; i++)
			{
				_o.SetTags.Add((this.SetTags(i) != null) ? this.SetTags(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060328E3 RID: 207075 RVA: 0x006D28C0 File Offset: 0x006D0AC0
		public static Offset<ISetBattleTag> Pack(FlatBufferBuilder builder, ISetBattleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTag>);
			}
			VectorOffset setTagsOffset = default(VectorOffset);
			if (_o.SetTags != null)
			{
				Offset<ISetEntityTag>[] array = new Offset<ISetEntityTag>[_o.SetTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetEntityTag.Pack(builder, _o.SetTags[i]);
				}
				setTagsOffset = ISetBattleTag.CreateSetTagsVector(builder, array);
			}
			return ISetBattleTag.CreateISetBattleTag(builder, _o.Type, setTagsOffset);
		}

		// Token: 0x040119BF RID: 72127
		private Table __p;
	}
}
