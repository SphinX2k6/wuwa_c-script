using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DE RID: 30430
	public class TGroupAiCommunicateOptionUnion
	{
		// Token: 0x1700E62D RID: 58925
		// (get) Token: 0x06037548 RID: 226632 RVA: 0x0077ED22 File Offset: 0x0077CF22
		// (set) Token: 0x06037549 RID: 226633 RVA: 0x0077ED2A File Offset: 0x0077CF2A
		public TGroupAiCommunicateOption Type { get; set; }

		// Token: 0x1700E62E RID: 58926
		// (get) Token: 0x0603754A RID: 226634 RVA: 0x0077ED33 File Offset: 0x0077CF33
		// (set) Token: 0x0603754B RID: 226635 RVA: 0x0077ED3B File Offset: 0x0077CF3B
		public object Value { get; set; }

		// Token: 0x0603754C RID: 226636 RVA: 0x0077ED44 File Offset: 0x0077CF44
		public TGroupAiCommunicateOptionUnion()
		{
			this.Type = TGroupAiCommunicateOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603754D RID: 226637 RVA: 0x0077ED5A File Offset: 0x0077CF5A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603754E RID: 226638 RVA: 0x0077ED6C File Offset: 0x0077CF6C
		public IGroupAiCommunicateAddTagT AsIGroupAiCommunicateAddTag()
		{
			return this.As<IGroupAiCommunicateAddTagT>();
		}

		// Token: 0x0603754F RID: 226639 RVA: 0x0077ED74 File Offset: 0x0077CF74
		public static TGroupAiCommunicateOptionUnion FromIGroupAiCommunicateAddTag(IGroupAiCommunicateAddTagT _igroupaicommunicateaddtag)
		{
			return new TGroupAiCommunicateOptionUnion
			{
				Type = TGroupAiCommunicateOption.IGroupAiCommunicateAddTag,
				Value = _igroupaicommunicateaddtag
			};
		}

		// Token: 0x06037550 RID: 226640 RVA: 0x0077ED89 File Offset: 0x0077CF89
		public IGroupAiCommunicateRemoveTagT AsIGroupAiCommunicateRemoveTag()
		{
			return this.As<IGroupAiCommunicateRemoveTagT>();
		}

		// Token: 0x06037551 RID: 226641 RVA: 0x0077ED91 File Offset: 0x0077CF91
		public static TGroupAiCommunicateOptionUnion FromIGroupAiCommunicateRemoveTag(IGroupAiCommunicateRemoveTagT _igroupaicommunicateremovetag)
		{
			return new TGroupAiCommunicateOptionUnion
			{
				Type = TGroupAiCommunicateOption.IGroupAiCommunicateRemoveTag,
				Value = _igroupaicommunicateremovetag
			};
		}

		// Token: 0x06037552 RID: 226642 RVA: 0x0077EDA8 File Offset: 0x0077CFA8
		public static int Pack(FlatBufferBuilder builder, TGroupAiCommunicateOptionUnion _o)
		{
			TGroupAiCommunicateOption type = _o.Type;
			if (type == TGroupAiCommunicateOption.IGroupAiCommunicateAddTag)
			{
				return IGroupAiCommunicateAddTag.Pack(builder, _o.AsIGroupAiCommunicateAddTag()).Value;
			}
			if (type != TGroupAiCommunicateOption.IGroupAiCommunicateRemoveTag)
			{
				return 0;
			}
			return IGroupAiCommunicateRemoveTag.Pack(builder, _o.AsIGroupAiCommunicateRemoveTag()).Value;
		}
	}
}
