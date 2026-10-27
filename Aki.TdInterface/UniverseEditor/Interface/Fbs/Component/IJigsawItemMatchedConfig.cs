using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AF RID: 21679
	public struct IJigsawItemMatchedConfig : IFlatbufferObject
	{
		// Token: 0x17009FAB RID: 40875
		// (get) Token: 0x06023B26 RID: 146214 RVA: 0x004EF6FC File Offset: 0x004ED8FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B27 RID: 146215 RVA: 0x004EF709 File Offset: 0x004ED909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B28 RID: 146216 RVA: 0x004EF710 File Offset: 0x004ED910
		public static IJigsawItemMatchedConfig GetRootAsIJigsawItemMatchedConfig(ByteBuffer _bb)
		{
			return IJigsawItemMatchedConfig.GetRootAsIJigsawItemMatchedConfig(_bb, default(IJigsawItemMatchedConfig));
		}

		// Token: 0x06023B29 RID: 146217 RVA: 0x004EF72C File Offset: 0x004ED92C
		public static IJigsawItemMatchedConfig GetRootAsIJigsawItemMatchedConfig(ByteBuffer _bb, IJigsawItemMatchedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B2A RID: 146218 RVA: 0x004EF749 File Offset: 0x004ED949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B2B RID: 146219 RVA: 0x004EF758 File Offset: 0x004ED958
		public IJigsawItemMatchedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FAC RID: 40876
		// (get) Token: 0x06023B2C RID: 146220 RVA: 0x004EF768 File Offset: 0x004ED968
		public IPieceIndex? TargetIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023B2D RID: 146221 RVA: 0x004EF7C8 File Offset: 0x004ED9C8
		public int JigsawItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009FAD RID: 40877
		// (get) Token: 0x06023B2E RID: 146222 RVA: 0x004EF808 File Offset: 0x004EDA08
		public int JigsawItemIdsLength
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

		// Token: 0x06023B2F RID: 146223 RVA: 0x004EF833 File Offset: 0x004EDA33
		public Span<int> GetJigsawItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06023B30 RID: 146224 RVA: 0x004EF842 File Offset: 0x004EDA42
		public int[] GetJigsawItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06023B31 RID: 146225 RVA: 0x004EF850 File Offset: 0x004EDA50
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FAE RID: 40878
		// (get) Token: 0x06023B32 RID: 146226 RVA: 0x004EF8B0 File Offset: 0x004EDAB0
		public int ActionsLength
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

		// Token: 0x06023B33 RID: 146227 RVA: 0x004EF8DC File Offset: 0x004EDADC
		public IConditionAction? ConditionActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FAF RID: 40879
		// (get) Token: 0x06023B34 RID: 146228 RVA: 0x004EF940 File Offset: 0x004EDB40
		public int ConditionActionsLength
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

		// Token: 0x06023B35 RID: 146229 RVA: 0x004EF96C File Offset: 0x004EDB6C
		public IActionInfo? UnmatchedActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FB0 RID: 40880
		// (get) Token: 0x06023B36 RID: 146230 RVA: 0x004EF9D0 File Offset: 0x004EDBD0
		public int UnmatchedActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009FB1 RID: 40881
		// (get) Token: 0x06023B37 RID: 146231 RVA: 0x004EF9FC File Offset: 0x004EDBFC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023B38 RID: 146232 RVA: 0x004EFA39 File Offset: 0x004EDC39
		public static Offset<IJigsawItemMatchedConfig> CreateIJigsawItemMatchedConfig(FlatBufferBuilder builder, Offset<IPieceIndex> TargetIndexOffset = default(Offset<IPieceIndex>), VectorOffset JigsawItemIdsOffset = default(VectorOffset), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset ConditionActionsOffset = default(VectorOffset), VectorOffset UnmatchedActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IJigsawItemMatchedConfig.AddUnmatchedActions(builder, UnmatchedActionsOffset);
			IJigsawItemMatchedConfig.AddConditionActions(builder, ConditionActionsOffset);
			IJigsawItemMatchedConfig.AddActions(builder, ActionsOffset);
			IJigsawItemMatchedConfig.AddJigsawItemIds(builder, JigsawItemIdsOffset);
			IJigsawItemMatchedConfig.AddTargetIndex(builder, TargetIndexOffset);
			IJigsawItemMatchedConfig.AddNullMask(builder, NullMask);
			return IJigsawItemMatchedConfig.EndIJigsawItemMatchedConfig(builder);
		}

		// Token: 0x06023B39 RID: 146233 RVA: 0x004EFA75 File Offset: 0x004EDC75
		public static void StartIJigsawItemMatchedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023B3A RID: 146234 RVA: 0x004EFA7E File Offset: 0x004EDC7E
		public static void AddTargetIndex(FlatBufferBuilder builder, Offset<IPieceIndex> targetIndexOffset)
		{
			builder.AddOffset(0, targetIndexOffset.Value, 0);
		}

		// Token: 0x06023B3B RID: 146235 RVA: 0x004EFA8E File Offset: 0x004EDC8E
		public static void AddJigsawItemIds(FlatBufferBuilder builder, VectorOffset jigsawItemIdsOffset)
		{
			builder.AddOffset(1, jigsawItemIdsOffset.Value, 0);
		}

		// Token: 0x06023B3C RID: 146236 RVA: 0x004EFAA0 File Offset: 0x004EDCA0
		public static VectorOffset CreateJigsawItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B3D RID: 146237 RVA: 0x004EFAD7 File Offset: 0x004EDCD7
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B3E RID: 146238 RVA: 0x004EFAF1 File Offset: 0x004EDCF1
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B3F RID: 146239 RVA: 0x004EFB0F File Offset: 0x004EDD0F
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B40 RID: 146240 RVA: 0x004EFB28 File Offset: 0x004EDD28
		public static void StartJigsawItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B41 RID: 146241 RVA: 0x004EFB33 File Offset: 0x004EDD33
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06023B42 RID: 146242 RVA: 0x004EFB44 File Offset: 0x004EDD44
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B43 RID: 146243 RVA: 0x004EFB84 File Offset: 0x004EDD84
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B44 RID: 146244 RVA: 0x004EFB9E File Offset: 0x004EDD9E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B45 RID: 146245 RVA: 0x004EFBBC File Offset: 0x004EDDBC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B46 RID: 146246 RVA: 0x004EFBD5 File Offset: 0x004EDDD5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B47 RID: 146247 RVA: 0x004EFBE0 File Offset: 0x004EDDE0
		public static void AddConditionActions(FlatBufferBuilder builder, VectorOffset conditionActionsOffset)
		{
			builder.AddOffset(3, conditionActionsOffset.Value, 0);
		}

		// Token: 0x06023B48 RID: 146248 RVA: 0x004EFBF0 File Offset: 0x004EDDF0
		public static VectorOffset CreateConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B49 RID: 146249 RVA: 0x004EFC30 File Offset: 0x004EDE30
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B4A RID: 146250 RVA: 0x004EFC4A File Offset: 0x004EDE4A
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B4B RID: 146251 RVA: 0x004EFC68 File Offset: 0x004EDE68
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B4C RID: 146252 RVA: 0x004EFC81 File Offset: 0x004EDE81
		public static void StartConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B4D RID: 146253 RVA: 0x004EFC8C File Offset: 0x004EDE8C
		public static void AddUnmatchedActions(FlatBufferBuilder builder, VectorOffset unmatchedActionsOffset)
		{
			builder.AddOffset(4, unmatchedActionsOffset.Value, 0);
		}

		// Token: 0x06023B4E RID: 146254 RVA: 0x004EFC9C File Offset: 0x004EDE9C
		public static VectorOffset CreateUnmatchedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B4F RID: 146255 RVA: 0x004EFCDC File Offset: 0x004EDEDC
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B50 RID: 146256 RVA: 0x004EFCF6 File Offset: 0x004EDEF6
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B51 RID: 146257 RVA: 0x004EFD14 File Offset: 0x004EDF14
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B52 RID: 146258 RVA: 0x004EFD2D File Offset: 0x004EDF2D
		public static void StartUnmatchedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B53 RID: 146259 RVA: 0x004EFD38 File Offset: 0x004EDF38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023B54 RID: 146260 RVA: 0x004EFD43 File Offset: 0x004EDF43
		public static Offset<IJigsawItemMatchedConfig> EndIJigsawItemMatchedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItemMatchedConfig>(builder.EndTable());
		}

		// Token: 0x06023B55 RID: 146261 RVA: 0x004EFD50 File Offset: 0x004EDF50
		public IJigsawItemMatchedConfigT UnPack()
		{
			IJigsawItemMatchedConfigT jigsawItemMatchedConfigT = new IJigsawItemMatchedConfigT();
			this.UnPackTo(jigsawItemMatchedConfigT);
			return jigsawItemMatchedConfigT;
		}

		// Token: 0x06023B56 RID: 146262 RVA: 0x004EFD6C File Offset: 0x004EDF6C
		public void UnPackTo(IJigsawItemMatchedConfigT _o)
		{
			_o.TargetIndex = ((this.TargetIndex != null) ? this.TargetIndex.Value.UnPack() : null);
			_o.JigsawItemIds = new List<int>();
			for (int i = 0; i < this.JigsawItemIdsLength; i++)
			{
				_o.JigsawItemIds.Add(this.JigsawItemIds(i));
			}
			_o.Actions = new List<IActionInfoT>();
			for (int j = 0; j < this.ActionsLength; j++)
			{
				_o.Actions.Add((this.Actions(j) != null) ? this.Actions(j).Value.UnPack() : null);
			}
			_o.ConditionActions = new List<IConditionActionT>();
			for (int k = 0; k < this.ConditionActionsLength; k++)
			{
				_o.ConditionActions.Add((this.ConditionActions(k) != null) ? this.ConditionActions(k).Value.UnPack() : null);
			}
			_o.UnmatchedActions = new List<IActionInfoT>();
			for (int l = 0; l < this.UnmatchedActionsLength; l++)
			{
				_o.UnmatchedActions.Add((this.UnmatchedActions(l) != null) ? this.UnmatchedActions(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023B57 RID: 146263 RVA: 0x004EFEF0 File Offset: 0x004EE0F0
		public static Offset<IJigsawItemMatchedConfig> Pack(FlatBufferBuilder builder, IJigsawItemMatchedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawItemMatchedConfig>);
			}
			Offset<IPieceIndex> targetIndexOffset = (_o.TargetIndex == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.TargetIndex);
			VectorOffset jigsawItemIdsOffset = default(VectorOffset);
			if (_o.JigsawItemIds != null)
			{
				int[] data = _o.JigsawItemIds.ToArray();
				jigsawItemIdsOffset = IJigsawItemMatchedConfig.CreateJigsawItemIdsVector(builder, data);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IJigsawItemMatchedConfig.CreateActionsVector(builder, array);
			}
			VectorOffset conditionActionsOffset = default(VectorOffset);
			if (_o.ConditionActions != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.ConditionActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.ConditionActions[j]);
				}
				conditionActionsOffset = IJigsawItemMatchedConfig.CreateConditionActionsVector(builder, array2);
			}
			VectorOffset unmatchedActionsOffset = default(VectorOffset);
			if (_o.UnmatchedActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.UnmatchedActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.UnmatchedActions[k]);
				}
				unmatchedActionsOffset = IJigsawItemMatchedConfig.CreateUnmatchedActionsVector(builder, array3);
			}
			return IJigsawItemMatchedConfig.CreateIJigsawItemMatchedConfig(builder, targetIndexOffset, jigsawItemIdsOffset, actionsOffset, conditionActionsOffset, unmatchedActionsOffset, _o.NullMask);
		}

		// Token: 0x0400E759 RID: 59225
		private Table __p;
	}
}
