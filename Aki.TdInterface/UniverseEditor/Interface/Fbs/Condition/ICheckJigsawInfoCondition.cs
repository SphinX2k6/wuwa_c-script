using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AAE RID: 19118
	public struct ICheckJigsawInfoCondition : IFlatbufferObject
	{
		// Token: 0x17008A92 RID: 35474
		// (get) Token: 0x0601E014 RID: 122900 RVA: 0x00436383 File Offset: 0x00434583
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E015 RID: 122901 RVA: 0x00436390 File Offset: 0x00434590
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E016 RID: 122902 RVA: 0x00436398 File Offset: 0x00434598
		public static ICheckJigsawInfoCondition GetRootAsICheckJigsawInfoCondition(ByteBuffer _bb)
		{
			return ICheckJigsawInfoCondition.GetRootAsICheckJigsawInfoCondition(_bb, default(ICheckJigsawInfoCondition));
		}

		// Token: 0x0601E017 RID: 122903 RVA: 0x004363B4 File Offset: 0x004345B4
		public static ICheckJigsawInfoCondition GetRootAsICheckJigsawInfoCondition(ByteBuffer _bb, ICheckJigsawInfoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E018 RID: 122904 RVA: 0x004363D1 File Offset: 0x004345D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E019 RID: 122905 RVA: 0x004363E0 File Offset: 0x004345E0
		public ICheckJigsawInfoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A93 RID: 35475
		// (get) Token: 0x0601E01A RID: 122906 RVA: 0x004363F0 File Offset: 0x004345F0
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

		// Token: 0x17008A94 RID: 35476
		// (get) Token: 0x0601E01B RID: 122907 RVA: 0x0043642C File Offset: 0x0043462C
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

		// Token: 0x0601E01C RID: 122908 RVA: 0x00436468 File Offset: 0x00434668
		public TTable? JigsawCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E01D RID: 122909 RVA: 0x004364AC File Offset: 0x004346AC
		public ICheckJigsawItemMove JigsawConditionAsICheckJigsawItemMove()
		{
			return this.JigsawCondition<ICheckJigsawItemMove>().Value;
		}

		// Token: 0x0601E01E RID: 122910 RVA: 0x004364C8 File Offset: 0x004346C8
		public ICheckJigsawItemPlaceIndex JigsawConditionAsICheckJigsawItemPlaceIndex()
		{
			return this.JigsawCondition<ICheckJigsawItemPlaceIndex>().Value;
		}

		// Token: 0x0601E01F RID: 122911 RVA: 0x004364E3 File Offset: 0x004346E3
		public static Offset<ICheckJigsawInfoCondition> CreateICheckJigsawInfoCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckJigsawInfo JigsawCondition_type = TCheckJigsawInfo.NONE, int JigsawConditionOffset = 0)
		{
			builder.StartTable(3);
			ICheckJigsawInfoCondition.AddJigsawCondition(builder, JigsawConditionOffset);
			ICheckJigsawInfoCondition.AddJigsawConditionType(builder, JigsawCondition_type);
			ICheckJigsawInfoCondition.AddType(builder, Type);
			return ICheckJigsawInfoCondition.EndICheckJigsawInfoCondition(builder);
		}

		// Token: 0x0601E020 RID: 122912 RVA: 0x00436507 File Offset: 0x00434707
		public static void StartICheckJigsawInfoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E021 RID: 122913 RVA: 0x00436510 File Offset: 0x00434710
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E022 RID: 122914 RVA: 0x0043651B File Offset: 0x0043471B
		public static void AddJigsawConditionType(FlatBufferBuilder builder, TCheckJigsawInfo jigsawConditionType)
		{
			builder.AddByte(1, (byte)jigsawConditionType, 0);
		}

		// Token: 0x0601E023 RID: 122915 RVA: 0x00436526 File Offset: 0x00434726
		public static void AddJigsawCondition(FlatBufferBuilder builder, int jigsawConditionOffset)
		{
			builder.AddOffset(2, jigsawConditionOffset, 0);
		}

		// Token: 0x0601E024 RID: 122916 RVA: 0x00436531 File Offset: 0x00434731
		public static Offset<ICheckJigsawInfoCondition> EndICheckJigsawInfoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawInfoCondition>(builder.EndTable());
		}

		// Token: 0x0601E025 RID: 122917 RVA: 0x00436540 File Offset: 0x00434740
		public ICheckJigsawInfoConditionT UnPack()
		{
			ICheckJigsawInfoConditionT checkJigsawInfoConditionT = new ICheckJigsawInfoConditionT();
			this.UnPackTo(checkJigsawInfoConditionT);
			return checkJigsawInfoConditionT;
		}

		// Token: 0x0601E026 RID: 122918 RVA: 0x0043655C File Offset: 0x0043475C
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

		// Token: 0x0601E027 RID: 122919 RVA: 0x0043660C File Offset: 0x0043480C
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

		// Token: 0x0400D329 RID: 54057
		private Table __p;
	}
}
