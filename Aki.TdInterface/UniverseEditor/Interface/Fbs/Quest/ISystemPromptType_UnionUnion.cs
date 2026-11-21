using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BA RID: 17850
	public class ISystemPromptType_UnionUnion
	{
		// Token: 0x17007CBA RID: 31930
		// (get) Token: 0x0601A0A1 RID: 106657 RVA: 0x003B5FC1 File Offset: 0x003B41C1
		// (set) Token: 0x0601A0A2 RID: 106658 RVA: 0x003B5FC9 File Offset: 0x003B41C9
		public ISystemPromptType_Union Type { get; set; }

		// Token: 0x17007CBB RID: 31931
		// (get) Token: 0x0601A0A3 RID: 106659 RVA: 0x003B5FD2 File Offset: 0x003B41D2
		// (set) Token: 0x0601A0A4 RID: 106660 RVA: 0x003B5FDA File Offset: 0x003B41DA
		public object Value { get; set; }

		// Token: 0x0601A0A5 RID: 106661 RVA: 0x003B5FE3 File Offset: 0x003B41E3
		public ISystemPromptType_UnionUnion()
		{
			this.Type = ISystemPromptType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A0A6 RID: 106662 RVA: 0x003B5FF9 File Offset: 0x003B41F9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A0A7 RID: 106663 RVA: 0x003B600B File Offset: 0x003B420B
		public ISystemPromptTypeT AsISystemPromptType()
		{
			return this.As<ISystemPromptTypeT>();
		}

		// Token: 0x0601A0A8 RID: 106664 RVA: 0x003B6013 File Offset: 0x003B4213
		public static ISystemPromptType_UnionUnion FromISystemPromptType(ISystemPromptTypeT _isystemprompttype)
		{
			return new ISystemPromptType_UnionUnion
			{
				Type = ISystemPromptType_Union.ISystemPromptType,
				Value = _isystemprompttype
			};
		}

		// Token: 0x0601A0A9 RID: 106665 RVA: 0x003B6028 File Offset: 0x003B4228
		public IAreaNameSystemPromptT AsIAreaNameSystemPrompt()
		{
			return this.As<IAreaNameSystemPromptT>();
		}

		// Token: 0x0601A0AA RID: 106666 RVA: 0x003B6030 File Offset: 0x003B4230
		public static ISystemPromptType_UnionUnion FromIAreaNameSystemPrompt(IAreaNameSystemPromptT _iareanamesystemprompt)
		{
			return new ISystemPromptType_UnionUnion
			{
				Type = ISystemPromptType_Union.IAreaNameSystemPrompt,
				Value = _iareanamesystemprompt
			};
		}

		// Token: 0x0601A0AB RID: 106667 RVA: 0x003B6048 File Offset: 0x003B4248
		public static int Pack(FlatBufferBuilder builder, ISystemPromptType_UnionUnion _o)
		{
			ISystemPromptType_Union type = _o.Type;
			if (type == ISystemPromptType_Union.ISystemPromptType)
			{
				return ISystemPromptType.Pack(builder, _o.AsISystemPromptType()).Value;
			}
			if (type != ISystemPromptType_Union.IAreaNameSystemPrompt)
			{
				return 0;
			}
			return IAreaNameSystemPrompt.Pack(builder, _o.AsIAreaNameSystemPrompt()).Value;
		}
	}
}
