using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005748 RID: 22344
	public struct IExploreSkillGraffitiPuzzle : IFlatbufferObject
	{
		// Token: 0x1700A15F RID: 41311
		// (get) Token: 0x06023F5E RID: 147294 RVA: 0x004F16EE File Offset: 0x004EF8EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F5F RID: 147295 RVA: 0x004F16FB File Offset: 0x004EF8FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F60 RID: 147296 RVA: 0x004F1704 File Offset: 0x004EF904
		public static IExploreSkillGraffitiPuzzle GetRootAsIExploreSkillGraffitiPuzzle(ByteBuffer _bb)
		{
			return IExploreSkillGraffitiPuzzle.GetRootAsIExploreSkillGraffitiPuzzle(_bb, default(IExploreSkillGraffitiPuzzle));
		}

		// Token: 0x06023F61 RID: 147297 RVA: 0x004F1720 File Offset: 0x004EF920
		public static IExploreSkillGraffitiPuzzle GetRootAsIExploreSkillGraffitiPuzzle(ByteBuffer _bb, IExploreSkillGraffitiPuzzle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F62 RID: 147298 RVA: 0x004F173D File Offset: 0x004EF93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F63 RID: 147299 RVA: 0x004F174C File Offset: 0x004EF94C
		public IExploreSkillGraffitiPuzzle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A160 RID: 41312
		// (get) Token: 0x06023F64 RID: 147300 RVA: 0x004F175C File Offset: 0x004EF95C
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F65 RID: 147301 RVA: 0x004F1798 File Offset: 0x004EF998
		public IGraffitiPointPair? PointPairs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGraffitiPointPair?(default(IGraffitiPointPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A161 RID: 41313
		// (get) Token: 0x06023F66 RID: 147302 RVA: 0x004F17F8 File Offset: 0x004EF9F8
		public int PointPairsLength
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

		// Token: 0x1700A162 RID: 41314
		// (get) Token: 0x06023F67 RID: 147303 RVA: 0x004F1824 File Offset: 0x004EFA24
		public float AlignDuration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F68 RID: 147304 RVA: 0x004F1864 File Offset: 0x004EFA64
		public int HighlightEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A163 RID: 41315
		// (get) Token: 0x06023F69 RID: 147305 RVA: 0x004F18A4 File Offset: 0x004EFAA4
		public int HighlightEntityIdsLength
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

		// Token: 0x06023F6A RID: 147306 RVA: 0x004F18D0 File Offset: 0x004EFAD0
		public Span<int> GetHighlightEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06023F6B RID: 147307 RVA: 0x004F18E0 File Offset: 0x004EFAE0
		public int[] GetHighlightEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700A164 RID: 41316
		// (get) Token: 0x06023F6C RID: 147308 RVA: 0x004F18F0 File Offset: 0x004EFAF0
		public int HighlightTag
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F6D RID: 147309 RVA: 0x004F1930 File Offset: 0x004EFB30
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A165 RID: 41317
		// (get) Token: 0x06023F6E RID: 147310 RVA: 0x004F1994 File Offset: 0x004EFB94
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023F6F RID: 147311 RVA: 0x004F19C0 File Offset: 0x004EFBC0
		public static Offset<IExploreSkillGraffitiPuzzle> CreateIExploreSkillGraffitiPuzzle(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, VectorOffset PointPairsOffset = default(VectorOffset), float AlignDuration = 0f, VectorOffset HighlightEntityIdsOffset = default(VectorOffset), int HighlightTag = 0, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			IExploreSkillGraffitiPuzzle.AddActions(builder, ActionsOffset);
			IExploreSkillGraffitiPuzzle.AddHighlightTag(builder, HighlightTag);
			IExploreSkillGraffitiPuzzle.AddHighlightEntityIds(builder, HighlightEntityIdsOffset);
			IExploreSkillGraffitiPuzzle.AddAlignDuration(builder, AlignDuration);
			IExploreSkillGraffitiPuzzle.AddPointPairs(builder, PointPairsOffset);
			IExploreSkillGraffitiPuzzle.AddType(builder, Type);
			return IExploreSkillGraffitiPuzzle.EndIExploreSkillGraffitiPuzzle(builder);
		}

		// Token: 0x06023F70 RID: 147312 RVA: 0x004F19FC File Offset: 0x004EFBFC
		public static void StartIExploreSkillGraffitiPuzzle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023F71 RID: 147313 RVA: 0x004F1A05 File Offset: 0x004EFC05
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023F72 RID: 147314 RVA: 0x004F1A10 File Offset: 0x004EFC10
		public static void AddPointPairs(FlatBufferBuilder builder, VectorOffset pointPairsOffset)
		{
			builder.AddOffset(1, pointPairsOffset.Value, 0);
		}

		// Token: 0x06023F73 RID: 147315 RVA: 0x004F1A20 File Offset: 0x004EFC20
		public static VectorOffset CreatePointPairsVector(FlatBufferBuilder builder, Offset<IGraffitiPointPair>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F74 RID: 147316 RVA: 0x004F1A60 File Offset: 0x004EFC60
		public static VectorOffset CreatePointPairsVectorBlock(FlatBufferBuilder builder, Offset<IGraffitiPointPair>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraffitiPointPair>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F75 RID: 147317 RVA: 0x004F1A7A File Offset: 0x004EFC7A
		public static VectorOffset CreatePointPairsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraffitiPointPair>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraffitiPointPair>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F76 RID: 147318 RVA: 0x004F1A98 File Offset: 0x004EFC98
		public static VectorOffset CreatePointPairsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraffitiPointPair>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F77 RID: 147319 RVA: 0x004F1AB1 File Offset: 0x004EFCB1
		public static void StartPointPairsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F78 RID: 147320 RVA: 0x004F1ABC File Offset: 0x004EFCBC
		public static void AddAlignDuration(FlatBufferBuilder builder, float alignDuration)
		{
			builder.AddFloat(2, alignDuration, 0.0);
		}

		// Token: 0x06023F79 RID: 147321 RVA: 0x004F1ACF File Offset: 0x004EFCCF
		public static void AddHighlightEntityIds(FlatBufferBuilder builder, VectorOffset highlightEntityIdsOffset)
		{
			builder.AddOffset(3, highlightEntityIdsOffset.Value, 0);
		}

		// Token: 0x06023F7A RID: 147322 RVA: 0x004F1AE0 File Offset: 0x004EFCE0
		public static VectorOffset CreateHighlightEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F7B RID: 147323 RVA: 0x004F1B17 File Offset: 0x004EFD17
		public static VectorOffset CreateHighlightEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F7C RID: 147324 RVA: 0x004F1B31 File Offset: 0x004EFD31
		public static VectorOffset CreateHighlightEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F7D RID: 147325 RVA: 0x004F1B4F File Offset: 0x004EFD4F
		public static VectorOffset CreateHighlightEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F7E RID: 147326 RVA: 0x004F1B68 File Offset: 0x004EFD68
		public static void StartHighlightEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F7F RID: 147327 RVA: 0x004F1B73 File Offset: 0x004EFD73
		public static void AddHighlightTag(FlatBufferBuilder builder, int highlightTag)
		{
			builder.AddInt(4, highlightTag, 0);
		}

		// Token: 0x06023F80 RID: 147328 RVA: 0x004F1B7E File Offset: 0x004EFD7E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x06023F81 RID: 147329 RVA: 0x004F1B90 File Offset: 0x004EFD90
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F82 RID: 147330 RVA: 0x004F1BD0 File Offset: 0x004EFDD0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F83 RID: 147331 RVA: 0x004F1BEA File Offset: 0x004EFDEA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F84 RID: 147332 RVA: 0x004F1C08 File Offset: 0x004EFE08
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F85 RID: 147333 RVA: 0x004F1C21 File Offset: 0x004EFE21
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F86 RID: 147334 RVA: 0x004F1C2C File Offset: 0x004EFE2C
		public static Offset<IExploreSkillGraffitiPuzzle> EndIExploreSkillGraffitiPuzzle(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillGraffitiPuzzle>(builder.EndTable());
		}

		// Token: 0x06023F87 RID: 147335 RVA: 0x004F1C3C File Offset: 0x004EFE3C
		public IExploreSkillGraffitiPuzzleT UnPack()
		{
			IExploreSkillGraffitiPuzzleT exploreSkillGraffitiPuzzleT = new IExploreSkillGraffitiPuzzleT();
			this.UnPackTo(exploreSkillGraffitiPuzzleT);
			return exploreSkillGraffitiPuzzleT;
		}

		// Token: 0x06023F88 RID: 147336 RVA: 0x004F1C58 File Offset: 0x004EFE58
		public void UnPackTo(IExploreSkillGraffitiPuzzleT _o)
		{
			_o.Type = this.Type;
			_o.PointPairs = new List<IGraffitiPointPairT>();
			for (int i = 0; i < this.PointPairsLength; i++)
			{
				_o.PointPairs.Add((this.PointPairs(i) != null) ? this.PointPairs(i).Value.UnPack() : null);
			}
			_o.AlignDuration = this.AlignDuration;
			_o.HighlightEntityIds = new List<int>();
			for (int j = 0; j < this.HighlightEntityIdsLength; j++)
			{
				_o.HighlightEntityIds.Add(this.HighlightEntityIds(j));
			}
			_o.HighlightTag = this.HighlightTag;
			_o.Actions = new List<IActionInfoT>();
			for (int k = 0; k < this.ActionsLength; k++)
			{
				_o.Actions.Add((this.Actions(k) != null) ? this.Actions(k).Value.UnPack() : null);
			}
		}

		// Token: 0x06023F89 RID: 147337 RVA: 0x004F1D64 File Offset: 0x004EFF64
		public static Offset<IExploreSkillGraffitiPuzzle> Pack(FlatBufferBuilder builder, IExploreSkillGraffitiPuzzleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillGraffitiPuzzle>);
			}
			VectorOffset pointPairsOffset = default(VectorOffset);
			if (_o.PointPairs != null)
			{
				Offset<IGraffitiPointPair>[] array = new Offset<IGraffitiPointPair>[_o.PointPairs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGraffitiPointPair.Pack(builder, _o.PointPairs[i]);
				}
				pointPairsOffset = IExploreSkillGraffitiPuzzle.CreatePointPairsVector(builder, array);
			}
			VectorOffset highlightEntityIdsOffset = default(VectorOffset);
			if (_o.HighlightEntityIds != null)
			{
				int[] data = _o.HighlightEntityIds.ToArray();
				highlightEntityIdsOffset = IExploreSkillGraffitiPuzzle.CreateHighlightEntityIdsVector(builder, data);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.Actions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.Actions[j]);
				}
				actionsOffset = IExploreSkillGraffitiPuzzle.CreateActionsVector(builder, array2);
			}
			return IExploreSkillGraffitiPuzzle.CreateIExploreSkillGraffitiPuzzle(builder, _o.Type, pointPairsOffset, _o.AlignDuration, highlightEntityIdsOffset, _o.HighlightTag, actionsOffset);
		}

		// Token: 0x0400EEEF RID: 61167
		private Table __p;
	}
}
