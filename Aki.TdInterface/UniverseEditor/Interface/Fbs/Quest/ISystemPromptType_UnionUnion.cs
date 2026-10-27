using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004176 RID: 16758
	public class ISystemPromptType_UnionUnion
	{
		// Token: 0x170076AB RID: 30379
		// (get) Token: 0x060189D9 RID: 100825 RVA: 0x0038BA05 File Offset: 0x00389C05
		// (set) Token: 0x060189DA RID: 100826 RVA: 0x0038BA0D File Offset: 0x00389C0D
		public ISystemPromptType_Union Type { get; set; }

		// Token: 0x170076AC RID: 30380
		// (get) Token: 0x060189DB RID: 100827 RVA: 0x0038BA16 File Offset: 0x00389C16
		// (set) Token: 0x060189DC RID: 100828 RVA: 0x0038BA1E File Offset: 0x00389C1E
		public object Value { get; set; }

		// Token: 0x060189DD RID: 100829 RVA: 0x0038BA27 File Offset: 0x00389C27
		public ISystemPromptType_UnionUnion()
		{
			this.Type = ISystemPromptType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060189DE RID: 100830 RVA: 0x0038BA3D File Offset: 0x00389C3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060189DF RID: 100831 RVA: 0x0038BA4F File Offset: 0x00389C4F
		public ISystemPromptTypeT AsISystemPromptType()
		{
			return this.As<ISystemPromptTypeT>();
		}

		// Token: 0x060189E0 RID: 100832 RVA: 0x0038BA57 File Offset: 0x00389C57
		public static ISystemPromptType_UnionUnion FromISystemPromptType(ISystemPromptTypeT _isystemprompttype)
		{
			return new ISystemPromptType_UnionUnion
			{
				Type = ISystemPromptType_Union.ISystemPromptType,
				Value = _isystemprompttype
			};
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x0038BA6C File Offset: 0x00389C6C
		public IAreaNameSystemPromptT AsIAreaNameSystemPrompt()
		{
			return this.As<IAreaNameSystemPromptT>();
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x0038BA74 File Offset: 0x00389C74
		public static ISystemPromptType_UnionUnion FromIAreaNameSystemPrompt(IAreaNameSystemPromptT _iareanamesystemprompt)
		{
			return new ISystemPromptType_UnionUnion
			{
				Type = ISystemPromptType_Union.IAreaNameSystemPrompt,
				Value = _iareanamesystemprompt
			};
		}

		// Token: 0x060189E3 RID: 100835 RVA: 0x0038BA8C File Offset: 0x00389C8C
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
