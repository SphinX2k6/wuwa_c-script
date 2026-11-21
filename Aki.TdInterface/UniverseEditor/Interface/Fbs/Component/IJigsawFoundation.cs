using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2F RID: 23087
	public struct IJigsawFoundation : IFlatbufferObject
	{
		// Token: 0x1700A7CB RID: 42955
		// (get) Token: 0x06025B7C RID: 154492 RVA: 0x0052B630 File Offset: 0x00529830
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B7D RID: 154493 RVA: 0x0052B63D File Offset: 0x0052983D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B7E RID: 154494 RVA: 0x0052B644 File Offset: 0x00529844
		public static IJigsawFoundation GetRootAsIJigsawFoundation(ByteBuffer _bb)
		{
			return IJigsawFoundation.GetRootAsIJigsawFoundation(_bb, default(IJigsawFoundation));
		}

		// Token: 0x06025B7F RID: 154495 RVA: 0x0052B660 File Offset: 0x00529860
		public static IJigsawFoundation GetRootAsIJigsawFoundation(ByteBuffer _bb, IJigsawFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B80 RID: 154496 RVA: 0x0052B67D File Offset: 0x0052987D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B81 RID: 154497 RVA: 0x0052B68C File Offset: 0x0052988C
		public IJigsawFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7CC RID: 42956
		// (get) Token: 0x06025B82 RID: 154498 RVA: 0x0052B69C File Offset: 0x0052989C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7CD RID: 42957
		// (get) Token: 0x06025B83 RID: 154499 RVA: 0x0052B6DC File Offset: 0x005298DC
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A7CE RID: 42958
		// (get) Token: 0x06025B84 RID: 154500 RVA: 0x0052B718 File Offset: 0x00529918
		public IVectorInfo? PlaceOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025B85 RID: 154501 RVA: 0x0052B778 File Offset: 0x00529978
		public IJigsawPieceMatch? InitMatchList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPieceMatch?(default(IJigsawPieceMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7CF RID: 42959
		// (get) Token: 0x06025B86 RID: 154502 RVA: 0x0052B7DC File Offset: 0x005299DC
		public int InitMatchListLength
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

		// Token: 0x1700A7D0 RID: 42960
		// (get) Token: 0x06025B87 RID: 154503 RVA: 0x0052B808 File Offset: 0x00529A08
		public TJigsawCompleteCondition CompleteConditionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TJigsawCompleteCondition.NONE;
				}
				return (TJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B88 RID: 154504 RVA: 0x0052B848 File Offset: 0x00529A48
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025B89 RID: 154505 RVA: 0x0052B890 File Offset: 0x00529A90
		public IActivateAllCorrectPiece CompleteConditionAsIActivateAllCorrectPiece()
		{
			return this.CompleteCondition<IActivateAllCorrectPiece>().Value;
		}

		// Token: 0x06025B8A RID: 154506 RVA: 0x0052B8AC File Offset: 0x00529AAC
		public IActivateSpecifiedPiece CompleteConditionAsIActivateSpecifiedPiece()
		{
			return this.CompleteCondition<IActivateSpecifiedPiece>().Value;
		}

		// Token: 0x06025B8B RID: 154507 RVA: 0x0052B8C8 File Offset: 0x00529AC8
		public IActiveRenjuPiece CompleteConditionAsIActiveRenjuPiece()
		{
			return this.CompleteCondition<IActiveRenjuPiece>().Value;
		}

		// Token: 0x06025B8C RID: 154508 RVA: 0x0052B8E4 File Offset: 0x00529AE4
		public IPutInTheSpecifiedPiece CompleteConditionAsIPutInTheSpecifiedPiece()
		{
			return this.CompleteCondition<IPutInTheSpecifiedPiece>().Value;
		}

		// Token: 0x1700A7D1 RID: 42961
		// (get) Token: 0x06025B8D RID: 154509 RVA: 0x0052B900 File Offset: 0x00529B00
		public IJigsawCompletedConfig? CompletedConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IJigsawCompletedConfig?(default(IJigsawCompletedConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A7D2 RID: 42962
		// (get) Token: 0x06025B8E RID: 154510 RVA: 0x0052B960 File Offset: 0x00529B60
		public IJigsawConfig? JigsawConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IJigsawConfig?(default(IJigsawConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025B8F RID: 154511 RVA: 0x0052B9C0 File Offset: 0x00529BC0
		public IJigsawItemMatchedConfig? MatchedConfig(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig?(default(IJigsawItemMatchedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7D3 RID: 42963
		// (get) Token: 0x06025B90 RID: 154512 RVA: 0x0052BA24 File Offset: 0x00529C24
		public int MatchedConfigLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A7D4 RID: 42964
		// (get) Token: 0x06025B91 RID: 154513 RVA: 0x0052BA50 File Offset: 0x00529C50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B92 RID: 154514 RVA: 0x0052BA90 File Offset: 0x00529C90
		public static Offset<IJigsawFoundation> CreateIJigsawFoundation(FlatBufferBuilder builder, bool Disabled = false, int ModelId = 0, Offset<IVectorInfo> PlaceOffsetOffset = default(Offset<IVectorInfo>), VectorOffset InitMatchListOffset = default(VectorOffset), TJigsawCompleteCondition CompleteCondition_type = TJigsawCompleteCondition.NONE, int CompleteConditionOffset = 0, Offset<IJigsawCompletedConfig> CompletedConfigOffset = default(Offset<IJigsawCompletedConfig>), Offset<IJigsawConfig> JigsawConfigOffset = default(Offset<IJigsawConfig>), VectorOffset MatchedConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IJigsawFoundation.AddMatchedConfig(builder, MatchedConfigOffset);
			IJigsawFoundation.AddJigsawConfig(builder, JigsawConfigOffset);
			IJigsawFoundation.AddCompletedConfig(builder, CompletedConfigOffset);
			IJigsawFoundation.AddCompleteCondition(builder, CompleteConditionOffset);
			IJigsawFoundation.AddInitMatchList(builder, InitMatchListOffset);
			IJigsawFoundation.AddPlaceOffset(builder, PlaceOffsetOffset);
			IJigsawFoundation.AddModelId(builder, ModelId);
			IJigsawFoundation.AddNullMask(builder, NullMask);
			IJigsawFoundation.AddCompleteConditionType(builder, CompleteCondition_type);
			IJigsawFoundation.AddDisabled(builder, Disabled);
			return IJigsawFoundation.EndIJigsawFoundation(builder);
		}

		// Token: 0x06025B93 RID: 154515 RVA: 0x0052BAF8 File Offset: 0x00529CF8
		public static void StartIJigsawFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06025B94 RID: 154516 RVA: 0x0052BB02 File Offset: 0x00529D02
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025B95 RID: 154517 RVA: 0x0052BB0D File Offset: 0x00529D0D
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x06025B96 RID: 154518 RVA: 0x0052BB18 File Offset: 0x00529D18
		public static void AddPlaceOffset(FlatBufferBuilder builder, Offset<IVectorInfo> placeOffsetOffset)
		{
			builder.AddOffset(2, placeOffsetOffset.Value, 0);
		}

		// Token: 0x06025B97 RID: 154519 RVA: 0x0052BB28 File Offset: 0x00529D28
		public static void AddInitMatchList(FlatBufferBuilder builder, VectorOffset initMatchListOffset)
		{
			builder.AddOffset(3, initMatchListOffset.Value, 0);
		}

		// Token: 0x06025B98 RID: 154520 RVA: 0x0052BB38 File Offset: 0x00529D38
		public static VectorOffset CreateInitMatchListVector(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025B99 RID: 154521 RVA: 0x0052BB78 File Offset: 0x00529D78
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B9A RID: 154522 RVA: 0x0052BB92 File Offset: 0x00529D92
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPieceMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B9B RID: 154523 RVA: 0x0052BBB0 File Offset: 0x00529DB0
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPieceMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025B9C RID: 154524 RVA: 0x0052BBC9 File Offset: 0x00529DC9
		public static void StartInitMatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025B9D RID: 154525 RVA: 0x0052BBD4 File Offset: 0x00529DD4
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TJigsawCompleteCondition completeConditionType)
		{
			builder.AddByte(4, (byte)completeConditionType, 0);
		}

		// Token: 0x06025B9E RID: 154526 RVA: 0x0052BBDF File Offset: 0x00529DDF
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(5, completeConditionOffset, 0);
		}

		// Token: 0x06025B9F RID: 154527 RVA: 0x0052BBEA File Offset: 0x00529DEA
		public static void AddCompletedConfig(FlatBufferBuilder builder, Offset<IJigsawCompletedConfig> completedConfigOffset)
		{
			builder.AddOffset(6, completedConfigOffset.Value, 0);
		}

		// Token: 0x06025BA0 RID: 154528 RVA: 0x0052BBFA File Offset: 0x00529DFA
		public static void AddJigsawConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> jigsawConfigOffset)
		{
			builder.AddOffset(7, jigsawConfigOffset.Value, 0);
		}

		// Token: 0x06025BA1 RID: 154529 RVA: 0x0052BC0A File Offset: 0x00529E0A
		public static void AddMatchedConfig(FlatBufferBuilder builder, VectorOffset matchedConfigOffset)
		{
			builder.AddOffset(8, matchedConfigOffset.Value, 0);
		}

		// Token: 0x06025BA2 RID: 154530 RVA: 0x0052BC1C File Offset: 0x00529E1C
		public static VectorOffset CreateMatchedConfigVector(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025BA3 RID: 154531 RVA: 0x0052BC5C File Offset: 0x00529E5C
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BA4 RID: 154532 RVA: 0x0052BC76 File Offset: 0x00529E76
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawItemMatchedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BA5 RID: 154533 RVA: 0x0052BC94 File Offset: 0x00529E94
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025BA6 RID: 154534 RVA: 0x0052BCAD File Offset: 0x00529EAD
		public static void StartMatchedConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025BA7 RID: 154535 RVA: 0x0052BCB8 File Offset: 0x00529EB8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06025BA8 RID: 154536 RVA: 0x0052BCC4 File Offset: 0x00529EC4
		public static Offset<IJigsawFoundation> EndIJigsawFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawFoundation>(builder.EndTable());
		}

		// Token: 0x06025BA9 RID: 154537 RVA: 0x0052BCD4 File Offset: 0x00529ED4
		public IJigsawFoundationT UnPack()
		{
			IJigsawFoundationT jigsawFoundationT = new IJigsawFoundationT();
			this.UnPackTo(jigsawFoundationT);
			return jigsawFoundationT;
		}

		// Token: 0x06025BAA RID: 154538 RVA: 0x0052BCF0 File Offset: 0x00529EF0
		public void UnPackTo(IJigsawFoundationT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ModelId = this.ModelId;
			_o.PlaceOffset = ((this.PlaceOffset != null) ? this.PlaceOffset.Value.UnPack() : null);
			_o.InitMatchList = new List<IJigsawPieceMatchT>();
			for (int i = 0; i < this.InitMatchListLength; i++)
			{
				_o.InitMatchList.Add((this.InitMatchList(i) != null) ? this.InitMatchList(i).Value.UnPack() : null);
			}
			_o.CompleteCondition = new TJigsawCompleteConditionUnion();
			_o.CompleteCondition.Type = this.CompleteConditionType;
			switch (this.CompleteConditionType)
			{
			case TJigsawCompleteCondition.IActivateAllCorrectPiece:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IActivateAllCorrectPiece>() != null) ? this.CompleteCondition<IActivateAllCorrectPiece>().Value.UnPack() : null);
				break;
			case TJigsawCompleteCondition.IActivateSpecifiedPiece:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IActivateSpecifiedPiece>() != null) ? this.CompleteCondition<IActivateSpecifiedPiece>().Value.UnPack() : null);
				break;
			case TJigsawCompleteCondition.IActiveRenjuPiece:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IActiveRenjuPiece>() != null) ? this.CompleteCondition<IActiveRenjuPiece>().Value.UnPack() : null);
				break;
			case TJigsawCompleteCondition.IPutInTheSpecifiedPiece:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IPutInTheSpecifiedPiece>() != null) ? this.CompleteCondition<IPutInTheSpecifiedPiece>().Value.UnPack() : null);
				break;
			}
			_o.CompletedConfig = ((this.CompletedConfig != null) ? this.CompletedConfig.Value.UnPack() : null);
			_o.JigsawConfig = ((this.JigsawConfig != null) ? this.JigsawConfig.Value.UnPack() : null);
			_o.MatchedConfig = new List<IJigsawItemMatchedConfigT>();
			for (int j = 0; j < this.MatchedConfigLength; j++)
			{
				_o.MatchedConfig.Add((this.MatchedConfig(j) != null) ? this.MatchedConfig(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025BAB RID: 154539 RVA: 0x0052BF8C File Offset: 0x0052A18C
		public static Offset<IJigsawFoundation> Pack(FlatBufferBuilder builder, IJigsawFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawFoundation>);
			}
			Offset<IVectorInfo> placeOffsetOffset = (_o.PlaceOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.PlaceOffset);
			VectorOffset initMatchListOffset = default(VectorOffset);
			if (_o.InitMatchList != null)
			{
				Offset<IJigsawPieceMatch>[] array = new Offset<IJigsawPieceMatch>[_o.InitMatchList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IJigsawPieceMatch.Pack(builder, _o.InitMatchList[i]);
				}
				initMatchListOffset = IJigsawFoundation.CreateInitMatchListVector(builder, array);
			}
			TJigsawCompleteCondition completeCondition_type = (_o.CompleteCondition == null) ? TJigsawCompleteCondition.NONE : _o.CompleteCondition.Type;
			int completeConditionOffset = (_o.CompleteCondition == null) ? 0 : TJigsawCompleteConditionUnion.Pack(builder, _o.CompleteCondition);
			Offset<IJigsawCompletedConfig> completedConfigOffset = (_o.CompletedConfig == null) ? default(Offset<IJigsawCompletedConfig>) : IJigsawCompletedConfig.Pack(builder, _o.CompletedConfig);
			Offset<IJigsawConfig> jigsawConfigOffset = (_o.JigsawConfig == null) ? default(Offset<IJigsawConfig>) : IJigsawConfig.Pack(builder, _o.JigsawConfig);
			VectorOffset matchedConfigOffset = default(VectorOffset);
			if (_o.MatchedConfig != null)
			{
				Offset<IJigsawItemMatchedConfig>[] array2 = new Offset<IJigsawItemMatchedConfig>[_o.MatchedConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IJigsawItemMatchedConfig.Pack(builder, _o.MatchedConfig[j]);
				}
				matchedConfigOffset = IJigsawFoundation.CreateMatchedConfigVector(builder, array2);
			}
			return IJigsawFoundation.CreateIJigsawFoundation(builder, _o.Disabled, _o.ModelId, placeOffsetOffset, initMatchListOffset, completeCondition_type, completeConditionOffset, completedConfigOffset, jigsawConfigOffset, matchedConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F37C RID: 62332
		private Table __p;
	}
}
