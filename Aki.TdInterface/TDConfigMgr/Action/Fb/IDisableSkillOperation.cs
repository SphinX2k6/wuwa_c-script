using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002945 RID: 10565
	public class IDisableSkillOperation : ISkillOperationType
	{
		// Token: 0x0600EA4B RID: 59979 RVA: 0x00224F65 File Offset: 0x00223165
		[NullableContext(1)]
		public static IDisableSkillOperation Create(IDisableSkillOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSkillOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x0600EA4C RID: 59980 RVA: 0x00224F84 File Offset: 0x00223184
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x0600EA4D RID: 59981 RVA: 0x00224F94 File Offset: 0x00223194
		public virtual EDisplayModeInSkillOp? DisplayMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EDisplayModeInSkillOp?((EDisplayModeInSkillOp)this.Instance.DisplayMode);
			}
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x0600EA4E RID: 59982 RVA: 0x00224FCC File Offset: 0x002231CC
		public virtual bool? DisableSkillWheel
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableSkillWheel);
			}
		}

		// Token: 0x0400812F RID: 33071
		private IDisableSkillOperation Instance;
	}
}
