using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EEF RID: 32495
	public class TGroupAiCommunicateOptionUnion
	{
		// Token: 0x1700F26D RID: 62061
		// (get) Token: 0x0603AA09 RID: 240137 RVA: 0x007E3132 File Offset: 0x007E1332
		// (set) Token: 0x0603AA0A RID: 240138 RVA: 0x007E313A File Offset: 0x007E133A
		public TGroupAiCommunicateOption Type { get; set; }

		// Token: 0x1700F26E RID: 62062
		// (get) Token: 0x0603AA0B RID: 240139 RVA: 0x007E3143 File Offset: 0x007E1343
		// (set) Token: 0x0603AA0C RID: 240140 RVA: 0x007E314B File Offset: 0x007E134B
		public object Value { get; set; }

		// Token: 0x0603AA0D RID: 240141 RVA: 0x007E3154 File Offset: 0x007E1354
		public TGroupAiCommunicateOptionUnion()
		{
			this.Type = TGroupAiCommunicateOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA0E RID: 240142 RVA: 0x007E316A File Offset: 0x007E136A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA0F RID: 240143 RVA: 0x007E317C File Offset: 0x007E137C
		public IGroupAiCommunicateAddTagT AsIGroupAiCommunicateAddTag()
		{
			return this.As<IGroupAiCommunicateAddTagT>();
		}

		// Token: 0x0603AA10 RID: 240144 RVA: 0x007E3184 File Offset: 0x007E1384
		public static TGroupAiCommunicateOptionUnion FromIGroupAiCommunicateAddTag(IGroupAiCommunicateAddTagT _igroupaicommunicateaddtag)
		{
			return new TGroupAiCommunicateOptionUnion
			{
				Type = TGroupAiCommunicateOption.IGroupAiCommunicateAddTag,
				Value = _igroupaicommunicateaddtag
			};
		}

		// Token: 0x0603AA11 RID: 240145 RVA: 0x007E3199 File Offset: 0x007E1399
		public IGroupAiCommunicateRemoveTagT AsIGroupAiCommunicateRemoveTag()
		{
			return this.As<IGroupAiCommunicateRemoveTagT>();
		}

		// Token: 0x0603AA12 RID: 240146 RVA: 0x007E31A1 File Offset: 0x007E13A1
		public static TGroupAiCommunicateOptionUnion FromIGroupAiCommunicateRemoveTag(IGroupAiCommunicateRemoveTagT _igroupaicommunicateremovetag)
		{
			return new TGroupAiCommunicateOptionUnion
			{
				Type = TGroupAiCommunicateOption.IGroupAiCommunicateRemoveTag,
				Value = _igroupaicommunicateremovetag
			};
		}

		// Token: 0x0603AA13 RID: 240147 RVA: 0x007E31B8 File Offset: 0x007E13B8
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
