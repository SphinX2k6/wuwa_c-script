using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E8 RID: 26856
	public struct IHideGroupType : IFlatbufferObject
	{
		// Token: 0x1700C748 RID: 51016
		// (get) Token: 0x0602ED9D RID: 191901 RVA: 0x0066462C File Offset: 0x0066282C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED9E RID: 191902 RVA: 0x00664639 File Offset: 0x00662839
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED9F RID: 191903 RVA: 0x00664640 File Offset: 0x00662840
		public static IHideGroupType GetRootAsIHideGroupType(ByteBuffer _bb)
		{
			return IHideGroupType.GetRootAsIHideGroupType(_bb, default(IHideGroupType));
		}

		// Token: 0x0602EDA0 RID: 191904 RVA: 0x0066465C File Offset: 0x0066285C
		public static IHideGroupType GetRootAsIHideGroupType(ByteBuffer _bb, IHideGroupType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDA1 RID: 191905 RVA: 0x00664679 File Offset: 0x00662879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDA2 RID: 191906 RVA: 0x00664688 File Offset: 0x00662888
		public IHideGroupType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C749 RID: 51017
		// (get) Token: 0x0602EDA3 RID: 191907 RVA: 0x00664698 File Offset: 0x00662898
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EDA4 RID: 191908 RVA: 0x006646D4 File Offset: 0x006628D4
		public static Offset<IHideGroupType> CreateIHideGroupType(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideGroupType.AddType(builder, Type);
			return IHideGroupType.EndIHideGroupType(builder);
		}

		// Token: 0x0602EDA5 RID: 191909 RVA: 0x006646EA File Offset: 0x006628EA
		public static void StartIHideGroupType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EDA6 RID: 191910 RVA: 0x006646F3 File Offset: 0x006628F3
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDA7 RID: 191911 RVA: 0x006646FE File Offset: 0x006628FE
		public static Offset<IHideGroupType> EndIHideGroupType(FlatBufferBuilder builder)
		{
			return new Offset<IHideGroupType>(builder.EndTable());
		}

		// Token: 0x0602EDA8 RID: 191912 RVA: 0x0066470C File Offset: 0x0066290C
		public IHideGroupTypeT UnPack()
		{
			IHideGroupTypeT hideGroupTypeT = new IHideGroupTypeT();
			this.UnPackTo(hideGroupTypeT);
			return hideGroupTypeT;
		}

		// Token: 0x0602EDA9 RID: 191913 RVA: 0x00664727 File Offset: 0x00662927
		public void UnPackTo(IHideGroupTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EDAA RID: 191914 RVA: 0x00664738 File Offset: 0x00662938
		public static Offset<IHideGroupType> Pack(FlatBufferBuilder builder, IHideGroupTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideGroupType>);
			}
			return IHideGroupType.CreateIHideGroupType(builder, _o.Type);
		}

		// Token: 0x04011051 RID: 69713
		private Table __p;
	}
}
