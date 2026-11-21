using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7D RID: 20349
	public struct ICheckJigsawInfoCondition : IFlatbufferObject
	{
		// Token: 0x1700917F RID: 37247
		// (get) Token: 0x0601FAFD RID: 129789 RVA: 0x00467BA3 File Offset: 0x00465DA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FAFE RID: 129790 RVA: 0x00467BB0 File Offset: 0x00465DB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FAFF RID: 129791 RVA: 0x00467BB8 File Offset: 0x00465DB8
		public static ICheckJigsawInfoCondition GetRootAsICheckJigsawInfoCondition(ByteBuffer _bb)
		{
			return ICheckJigsawInfoCondition.GetRootAsICheckJigsawInfoCondition(_bb, default(ICheckJigsawInfoCondition));
		}

		// Token: 0x0601FB00 RID: 129792 RVA: 0x00467BD4 File Offset: 0x00465DD4
		public static ICheckJigsawInfoCondition GetRootAsICheckJigsawInfoCondition(ByteBuffer _bb, ICheckJigsawInfoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB01 RID: 129793 RVA: 0x00467BF1 File Offset: 0x00465DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB02 RID: 129794 RVA: 0x00467C00 File Offset: 0x00465E00
		public ICheckJigsawInfoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009180 RID: 37248
		// (get) Token: 0x0601FB03 RID: 129795 RVA: 0x00467C10 File Offset: 0x00465E10
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009181 RID: 37249
		// (get) Token: 0x0601FB04 RID: 129796 RVA: 0x00467C4C File Offset: 0x00465E4C
		public TCheckJigsawInfo JigsawConditionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckJigsawInfo.NONE;
				}
				return (TCheckJigsawInfo)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB05 RID: 129797 RVA: 0x00467C88 File Offset: 0x00465E88
		public TTable? JigsawCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FB06 RID: 129798 RVA: 0x00467CCC File Offset: 0x00465ECC
		public ICheckJigsawItemMove JigsawConditionAsICheckJigsawItemMove()
		{
			return this.JigsawCondition<ICheckJigsawItemMove>().Value;
		}

		// Token: 0x0601FB07 RID: 129799 RVA: 0x00467CE8 File Offset: 0x00465EE8
		public ICheckJigsawItemPlaceIndex JigsawConditionAsICheckJigsawItemPlaceIndex()
		{
			return this.JigsawCondition<ICheckJigsawItemPlaceIndex>().Value;
		}

		// Token: 0x0601FB08 RID: 129800 RVA: 0x00467D03 File Offset: 0x00465F03
		public static Offset<ICheckJigsawInfoCondition> CreateICheckJigsawInfoCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckJigsawInfo JigsawCondition_type = TCheckJigsawInfo.NONE, int JigsawConditionOffset = 0)
		{
			builder.StartTable(3);
			ICheckJigsawInfoCondition.AddJigsawCondition(builder, JigsawConditionOffset);
			ICheckJigsawInfoCondition.AddJigsawConditionType(builder, JigsawCondition_type);
			ICheckJigsawInfoCondition.AddType(builder, Type);
			return ICheckJigsawInfoCondition.EndICheckJigsawInfoCondition(builder);
		}

		// Token: 0x0601FB09 RID: 129801 RVA: 0x00467D27 File Offset: 0x00465F27
		public static void StartICheckJigsawInfoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FB0A RID: 129802 RVA: 0x00467D30 File Offset: 0x00465F30
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB0B RID: 129803 RVA: 0x00467D3B File Offset: 0x00465F3B
		public static void AddJigsawConditionType(FlatBufferBuilder builder, TCheckJigsawInfo jigsawConditionType)
		{
			builder.AddByte(1, (byte)jigsawConditionType, 0);
		}

		// Token: 0x0601FB0C RID: 129804 RVA: 0x00467D46 File Offset: 0x00465F46
		public static void AddJigsawCondition(FlatBufferBuilder builder, int jigsawConditionOffset)
		{
			builder.AddOffset(2, jigsawConditionOffset, 0);
		}

		// Token: 0x0601FB0D RID: 129805 RVA: 0x00467D51 File Offset: 0x00465F51
		public static Offset<ICheckJigsawInfoCondition> EndICheckJigsawInfoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawInfoCondition>(builder.EndTable());
		}

		// Token: 0x0601FB0E RID: 129806 RVA: 0x00467D60 File Offset: 0x00465F60
		public ICheckJigsawInfoConditionT UnPack()
		{
			ICheckJigsawInfoConditionT checkJigsawInfoConditionT = new ICheckJigsawInfoConditionT();
			this.UnPackTo(checkJigsawInfoConditionT);
			return checkJigsawInfoConditionT;
		}

		// Token: 0x0601FB0F RID: 129807 RVA: 0x00467D7C File Offset: 0x00465F7C
		public void UnPackTo(ICheckJigsawInfoConditionT _o)
		{
			_o.Type = this.Type;
			_o.JigsawCondition = new TCheckJigsawInfoUnion();
			_o.JigsawCondition.Type = this.JigsawConditionType;
			TCheckJigsawInfo jigsawConditionType = this.JigsawConditionType;
			if (jigsawConditionType == TCheckJigsawInfo.ICheckJigsawItemMove)
			{
				_o.JigsawCondition.Value = ((this.JigsawCondition<ICheckJigsawItemMove>() != null) ? this.JigsawCondition<ICheckJigsawItemMove>().Value.UnPack() : null);
				return;
			}
			if (jigsawConditionType != TCheckJigsawInfo.ICheckJigsawItemPlaceIndex)
			{
				return;
			}
			_o.JigsawCondition.Value = ((this.JigsawCondition<ICheckJigsawItemPlaceIndex>() != null) ? this.JigsawCondition<ICheckJigsawItemPlaceIndex>().Value.UnPack() : null);
		}

		// Token: 0x0601FB10 RID: 129808 RVA: 0x00467E2C File Offset: 0x0046602C
		public static Offset<ICheckJigsawInfoCondition> Pack(FlatBufferBuilder builder, ICheckJigsawInfoConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawInfoCondition>);
			}
			TCheckJigsawInfo jigsawCondition_type = (_o.JigsawCondition == null) ? TCheckJigsawInfo.NONE : _o.JigsawCondition.Type;
			int jigsawConditionOffset = (_o.JigsawCondition == null) ? 0 : TCheckJigsawInfoUnion.Pack(builder, _o.JigsawCondition);
			return ICheckJigsawInfoCondition.CreateICheckJigsawInfoCondition(builder, _o.Type, jigsawCondition_type, jigsawConditionOffset);
		}

		// Token: 0x0400DE0E RID: 56846
		private Table __p;
	}
}
