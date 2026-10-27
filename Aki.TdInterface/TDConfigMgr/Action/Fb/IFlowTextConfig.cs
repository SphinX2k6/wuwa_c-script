using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024EF RID: 9455
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTextConfig
	{
		// Token: 0x0600D31A RID: 54042 RVA: 0x001F4EDE File Offset: 0x001F30DE
		public static IFlowTextConfig Create(IFlowTextConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTextConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600D31B RID: 54043 RVA: 0x001F4EFD File Offset: 0x001F30FD
		public virtual string Text
		{
			get
			{
				return this.Instance.Text;
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600D31C RID: 54044 RVA: 0x001F4F0A File Offset: 0x001F310A
		[Nullable(2)]
		public virtual string PlotLineKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600D31D RID: 54045 RVA: 0x001F4F17 File Offset: 0x001F3117
		public virtual string StringKey
		{
			get
			{
				return this.Instance.StringKey;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600D31E RID: 54046 RVA: 0x001F4F24 File Offset: 0x001F3124
		public virtual int FlowListId
		{
			get
			{
				return this.Instance.FlowListId;
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600D31F RID: 54047 RVA: 0x001F4F34 File Offset: 0x001F3134
		public virtual bool? IsNoPlotText
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNoPlotText);
			}
		}

		// Token: 0x040073C3 RID: 29635
		private IFlowTextConfig Instance;
	}
}
