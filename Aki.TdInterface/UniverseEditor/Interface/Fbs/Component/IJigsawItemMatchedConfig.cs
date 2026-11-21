using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A35 RID: 23093
	public struct IJigsawItemMatchedConfig : IFlatbufferObject
	{
		// Token: 0x1700A7E5 RID: 42981
		// (get) Token: 0x06025BDE RID: 154590 RVA: 0x0052C770 File Offset: 0x0052A970
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025BDF RID: 154591 RVA: 0x0052C77D File Offset: 0x0052A97D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025BE0 RID: 154592 RVA: 0x0052C784 File Offset: 0x0052A984
		public static IJigsawItemMatchedConfig GetRootAsIJigsawItemMatchedConfig(ByteBuffer _bb)
		{
			return IJigsawItemMatchedConfig.GetRootAsIJigsawItemMatchedConfig(_bb, default(IJigsawItemMatchedConfig));
		}

		// Token: 0x06025BE1 RID: 154593 RVA: 0x0052C7A0 File Offset: 0x0052A9A0
		public static IJigsawItemMatchedConfig GetRootAsIJigsawItemMatchedConfig(ByteBuffer _bb, IJigsawItemMatchedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025BE2 RID: 154594 RVA: 0x0052C7BD File Offset: 0x0052A9BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025BE3 RID: 154595 RVA: 0x0052C7CC File Offset: 0x0052A9CC
		public IJigsawItemMatchedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7E6 RID: 42982
		// (get) Token: 0x06025BE4 RID: 154596 RVA: 0x0052C7DC File Offset: 0x0052A9DC
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

		// Token: 0x06025BE5 RID: 154597 RVA: 0x0052C83C File Offset: 0x0052AA3C
		public int JigsawItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A7E7 RID: 42983
		// (get) Token: 0x06025BE6 RID: 154598 RVA: 0x0052C87C File Offset: 0x0052AA7C
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

		// Token: 0x06025BE7 RID: 154599 RVA: 0x0052C8A7 File Offset: 0x0052AAA7
		public Span<int> GetJigsawItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025BE8 RID: 154600 RVA: 0x0052C8B6 File Offset: 0x0052AAB6
		public int[] GetJigsawItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06025BE9 RID: 154601 RVA: 0x0052C8C4 File Offset: 0x0052AAC4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7E8 RID: 42984
		// (get) Token: 0x06025BEA RID: 154602 RVA: 0x0052C924 File Offset: 0x0052AB24
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

		// Token: 0x06025BEB RID: 154603 RVA: 0x0052C950 File Offset: 0x0052AB50
		public IConditionAction? ConditionActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7E9 RID: 42985
		// (get) Token: 0x06025BEC RID: 154604 RVA: 0x0052C9B4 File Offset: 0x0052ABB4
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

		// Token: 0x06025BED RID: 154605 RVA: 0x0052C9E0 File Offset: 0x0052ABE0
		public IActionInfo? UnmatchedActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7EA RID: 42986
		// (get) Token: 0x06025BEE RID: 154606 RVA: 0x0052CA44 File Offset: 0x0052AC44
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

		// Token: 0x1700A7EB RID: 42987
		// (get) Token: 0x06025BEF RID: 154607 RVA: 0x0052CA70 File Offset: 0x0052AC70
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

		// Token: 0x06025BF0 RID: 154608 RVA: 0x0052CAAD File Offset: 0x0052ACAD
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

		// Token: 0x06025BF1 RID: 154609 RVA: 0x0052CAE9 File Offset: 0x0052ACE9
		public static void StartIJigsawItemMatchedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025BF2 RID: 154610 RVA: 0x0052CAF2 File Offset: 0x0052ACF2
		public static void AddTargetIndex(FlatBufferBuilder builder, Offset<IPieceIndex> targetIndexOffset)
		{
			builder.AddOffset(0, targetIndexOffset.Value, 0);
		}

		// Token: 0x06025BF3 RID: 154611 RVA: 0x0052CB02 File Offset: 0x0052AD02
		public static void AddJigsawItemIds(FlatBufferBuilder builder, VectorOffset jigsawItemIdsOffset)
		{
			builder.AddOffset(1, jigsawItemIdsOffset.Value, 0);
		}

		// Token: 0x06025BF4 RID: 154612 RVA: 0x0052CB14 File Offset: 0x0052AD14
		public static VectorOffset CreateJigsawItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025BF5 RID: 154613 RVA: 0x0052CB4B File Offset: 0x0052AD4B
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BF6 RID: 154614 RVA: 0x0052CB65 File Offset: 0x0052AD65
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BF7 RID: 154615 RVA: 0x0052CB83 File Offset: 0x0052AD83
		public static VectorOffset CreateJigsawItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025BF8 RID: 154616 RVA: 0x0052CB9C File Offset: 0x0052AD9C
		public static void StartJigsawItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025BF9 RID: 154617 RVA: 0x0052CBA7 File Offset: 0x0052ADA7
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06025BFA RID: 154618 RVA: 0x0052CBB8 File Offset: 0x0052ADB8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025BFB RID: 154619 RVA: 0x0052CBF8 File Offset: 0x0052ADF8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BFC RID: 154620 RVA: 0x0052CC12 File Offset: 0x0052AE12
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BFD RID: 154621 RVA: 0x0052CC30 File Offset: 0x0052AE30
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025BFE RID: 154622 RVA: 0x0052CC49 File Offset: 0x0052AE49
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025BFF RID: 154623 RVA: 0x0052CC54 File Offset: 0x0052AE54
		public static void AddConditionActions(FlatBufferBuilder builder, VectorOffset conditionActionsOffset)
		{
			builder.AddOffset(3, conditionActionsOffset.Value, 0);
		}

		// Token: 0x06025C00 RID: 154624 RVA: 0x0052CC64 File Offset: 0x0052AE64
		public static VectorOffset CreateConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C01 RID: 154625 RVA: 0x0052CCA4 File Offset: 0x0052AEA4
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C02 RID: 154626 RVA: 0x0052CCBE File Offset: 0x0052AEBE
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C03 RID: 154627 RVA: 0x0052CCDC File Offset: 0x0052AEDC
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C04 RID: 154628 RVA: 0x0052CCF5 File Offset: 0x0052AEF5
		public static void StartConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C05 RID: 154629 RVA: 0x0052CD00 File Offset: 0x0052AF00
		public static void AddUnmatchedActions(FlatBufferBuilder builder, VectorOffset unmatchedActionsOffset)
		{
			builder.AddOffset(4, unmatchedActionsOffset.Value, 0);
		}

		// Token: 0x06025C06 RID: 154630 RVA: 0x0052CD10 File Offset: 0x0052AF10
		public static VectorOffset CreateUnmatchedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C07 RID: 154631 RVA: 0x0052CD50 File Offset: 0x0052AF50
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C08 RID: 154632 RVA: 0x0052CD6A File Offset: 0x0052AF6A
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C09 RID: 154633 RVA: 0x0052CD88 File Offset: 0x0052AF88
		public static VectorOffset CreateUnmatchedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C0A RID: 154634 RVA: 0x0052CDA1 File Offset: 0x0052AFA1
		public static void StartUnmatchedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C0B RID: 154635 RVA: 0x0052CDAC File Offset: 0x0052AFAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025C0C RID: 154636 RVA: 0x0052CDB7 File Offset: 0x0052AFB7
		public static Offset<IJigsawItemMatchedConfig> EndIJigsawItemMatchedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItemMatchedConfig>(builder.EndTable());
		}

		// Token: 0x06025C0D RID: 154637 RVA: 0x0052CDC4 File Offset: 0x0052AFC4
		public IJigsawItemMatchedConfigT UnPack()
		{
			IJigsawItemMatchedConfigT jigsawItemMatchedConfigT = new IJigsawItemMatchedConfigT();
			this.UnPackTo(jigsawItemMatchedConfigT);
			return jigsawItemMatchedConfigT;
		}

		// Token: 0x06025C0E RID: 154638 RVA: 0x0052CDE0 File Offset: 0x0052AFE0
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

		// Token: 0x06025C0F RID: 154639 RVA: 0x0052CF64 File Offset: 0x0052B164
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

		// Token: 0x0400F38A RID: 62346
		private Table __p;
	}
}
