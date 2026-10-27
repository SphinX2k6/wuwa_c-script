using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A9 RID: 21673
	public struct IJigsawFoundation : IFlatbufferObject
	{
		// Token: 0x17009F91 RID: 40849
		// (get) Token: 0x06023AC4 RID: 146116 RVA: 0x004EE5BC File Offset: 0x004EC7BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023AC5 RID: 146117 RVA: 0x004EE5C9 File Offset: 0x004EC7C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023AC6 RID: 146118 RVA: 0x004EE5D0 File Offset: 0x004EC7D0
		public static IJigsawFoundation GetRootAsIJigsawFoundation(ByteBuffer _bb)
		{
			return IJigsawFoundation.GetRootAsIJigsawFoundation(_bb, default(IJigsawFoundation));
		}

		// Token: 0x06023AC7 RID: 146119 RVA: 0x004EE5EC File Offset: 0x004EC7EC
		public static IJigsawFoundation GetRootAsIJigsawFoundation(ByteBuffer _bb, IJigsawFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023AC8 RID: 146120 RVA: 0x004EE609 File Offset: 0x004EC809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023AC9 RID: 146121 RVA: 0x004EE618 File Offset: 0x004EC818
		public IJigsawFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F92 RID: 40850
		// (get) Token: 0x06023ACA RID: 146122 RVA: 0x004EE628 File Offset: 0x004EC828
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F93 RID: 40851
		// (get) Token: 0x06023ACB RID: 146123 RVA: 0x004EE668 File Offset: 0x004EC868
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

		// Token: 0x17009F94 RID: 40852
		// (get) Token: 0x06023ACC RID: 146124 RVA: 0x004EE6A4 File Offset: 0x004EC8A4
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

		// Token: 0x06023ACD RID: 146125 RVA: 0x004EE704 File Offset: 0x004EC904
		public IJigsawPieceMatch? InitMatchList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPieceMatch?(default(IJigsawPieceMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F95 RID: 40853
		// (get) Token: 0x06023ACE RID: 146126 RVA: 0x004EE768 File Offset: 0x004EC968
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

		// Token: 0x17009F96 RID: 40854
		// (get) Token: 0x06023ACF RID: 146127 RVA: 0x004EE794 File Offset: 0x004EC994
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

		// Token: 0x06023AD0 RID: 146128 RVA: 0x004EE7D4 File Offset: 0x004EC9D4
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023AD1 RID: 146129 RVA: 0x004EE81C File Offset: 0x004ECA1C
		public IActivateAllCorrectPiece CompleteConditionAsIActivateAllCorrectPiece()
		{
			return this.CompleteCondition<IActivateAllCorrectPiece>().Value;
		}

		// Token: 0x06023AD2 RID: 146130 RVA: 0x004EE838 File Offset: 0x004ECA38
		public IActivateSpecifiedPiece CompleteConditionAsIActivateSpecifiedPiece()
		{
			return this.CompleteCondition<IActivateSpecifiedPiece>().Value;
		}

		// Token: 0x06023AD3 RID: 146131 RVA: 0x004EE854 File Offset: 0x004ECA54
		public IActiveRenjuPiece CompleteConditionAsIActiveRenjuPiece()
		{
			return this.CompleteCondition<IActiveRenjuPiece>().Value;
		}

		// Token: 0x06023AD4 RID: 146132 RVA: 0x004EE870 File Offset: 0x004ECA70
		public IPutInTheSpecifiedPiece CompleteConditionAsIPutInTheSpecifiedPiece()
		{
			return this.CompleteCondition<IPutInTheSpecifiedPiece>().Value;
		}

		// Token: 0x17009F97 RID: 40855
		// (get) Token: 0x06023AD5 RID: 146133 RVA: 0x004EE88C File Offset: 0x004ECA8C
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

		// Token: 0x17009F98 RID: 40856
		// (get) Token: 0x06023AD6 RID: 146134 RVA: 0x004EE8EC File Offset: 0x004ECAEC
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

		// Token: 0x06023AD7 RID: 146135 RVA: 0x004EE94C File Offset: 0x004ECB4C
		public IJigsawItemMatchedConfig? MatchedConfig(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig?(default(IJigsawItemMatchedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F99 RID: 40857
		// (get) Token: 0x06023AD8 RID: 146136 RVA: 0x004EE9B0 File Offset: 0x004ECBB0
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

		// Token: 0x17009F9A RID: 40858
		// (get) Token: 0x06023AD9 RID: 146137 RVA: 0x004EE9DC File Offset: 0x004ECBDC
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

		// Token: 0x06023ADA RID: 146138 RVA: 0x004EEA1C File Offset: 0x004ECC1C
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

		// Token: 0x06023ADB RID: 146139 RVA: 0x004EEA84 File Offset: 0x004ECC84
		public static void StartIJigsawFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06023ADC RID: 146140 RVA: 0x004EEA8E File Offset: 0x004ECC8E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023ADD RID: 146141 RVA: 0x004EEA99 File Offset: 0x004ECC99
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x06023ADE RID: 146142 RVA: 0x004EEAA4 File Offset: 0x004ECCA4
		public static void AddPlaceOffset(FlatBufferBuilder builder, Offset<IVectorInfo> placeOffsetOffset)
		{
			builder.AddOffset(2, placeOffsetOffset.Value, 0);
		}

		// Token: 0x06023ADF RID: 146143 RVA: 0x004EEAB4 File Offset: 0x004ECCB4
		public static void AddInitMatchList(FlatBufferBuilder builder, VectorOffset initMatchListOffset)
		{
			builder.AddOffset(3, initMatchListOffset.Value, 0);
		}

		// Token: 0x06023AE0 RID: 146144 RVA: 0x004EEAC4 File Offset: 0x004ECCC4
		public static VectorOffset CreateInitMatchListVector(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023AE1 RID: 146145 RVA: 0x004EEB04 File Offset: 0x004ECD04
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AE2 RID: 146146 RVA: 0x004EEB1E File Offset: 0x004ECD1E
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPieceMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AE3 RID: 146147 RVA: 0x004EEB3C File Offset: 0x004ECD3C
		public static VectorOffset CreateInitMatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPieceMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023AE4 RID: 146148 RVA: 0x004EEB55 File Offset: 0x004ECD55
		public static void StartInitMatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023AE5 RID: 146149 RVA: 0x004EEB60 File Offset: 0x004ECD60
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TJigsawCompleteCondition completeConditionType)
		{
			builder.AddByte(4, (byte)completeConditionType, 0);
		}

		// Token: 0x06023AE6 RID: 146150 RVA: 0x004EEB6B File Offset: 0x004ECD6B
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(5, completeConditionOffset, 0);
		}

		// Token: 0x06023AE7 RID: 146151 RVA: 0x004EEB76 File Offset: 0x004ECD76
		public static void AddCompletedConfig(FlatBufferBuilder builder, Offset<IJigsawCompletedConfig> completedConfigOffset)
		{
			builder.AddOffset(6, completedConfigOffset.Value, 0);
		}

		// Token: 0x06023AE8 RID: 146152 RVA: 0x004EEB86 File Offset: 0x004ECD86
		public static void AddJigsawConfig(FlatBufferBuilder builder, Offset<IJigsawConfig> jigsawConfigOffset)
		{
			builder.AddOffset(7, jigsawConfigOffset.Value, 0);
		}

		// Token: 0x06023AE9 RID: 146153 RVA: 0x004EEB96 File Offset: 0x004ECD96
		public static void AddMatchedConfig(FlatBufferBuilder builder, VectorOffset matchedConfigOffset)
		{
			builder.AddOffset(8, matchedConfigOffset.Value, 0);
		}

		// Token: 0x06023AEA RID: 146154 RVA: 0x004EEBA8 File Offset: 0x004ECDA8
		public static VectorOffset CreateMatchedConfigVector(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023AEB RID: 146155 RVA: 0x004EEBE8 File Offset: 0x004ECDE8
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AEC RID: 146156 RVA: 0x004EEC02 File Offset: 0x004ECE02
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawItemMatchedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AED RID: 146157 RVA: 0x004EEC20 File Offset: 0x004ECE20
		public static VectorOffset CreateMatchedConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023AEE RID: 146158 RVA: 0x004EEC39 File Offset: 0x004ECE39
		public static void StartMatchedConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023AEF RID: 146159 RVA: 0x004EEC44 File Offset: 0x004ECE44
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06023AF0 RID: 146160 RVA: 0x004EEC50 File Offset: 0x004ECE50
		public static Offset<IJigsawFoundation> EndIJigsawFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawFoundation>(builder.EndTable());
		}

		// Token: 0x06023AF1 RID: 146161 RVA: 0x004EEC60 File Offset: 0x004ECE60
		public IJigsawFoundationT UnPack()
		{
			IJigsawFoundationT jigsawFoundationT = new IJigsawFoundationT();
			this.UnPackTo(jigsawFoundationT);
			return jigsawFoundationT;
		}

		// Token: 0x06023AF2 RID: 146162 RVA: 0x004EEC7C File Offset: 0x004ECE7C
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

		// Token: 0x06023AF3 RID: 146163 RVA: 0x004EEF18 File Offset: 0x004ED118
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

		// Token: 0x0400E74B RID: 59211
		private Table __p;
	}
}
