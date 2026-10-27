using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295D RID: 10589
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifySelfSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00225F70 File Offset: 0x00224170
		public static IModifySelfSceneItemAttributeTag Create(IModifySelfSceneItemAttributeTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x00225F8F File Offset: 0x0022418F
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x0600EAC7 RID: 60103 RVA: 0x00225F9C File Offset: 0x0022419C
		public override bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x0600EAC8 RID: 60104 RVA: 0x00225FAC File Offset: 0x002241AC
		public override List<int> PerformanceTag
		{
			get
			{
				if (this._PerformanceTagInited)
				{
					return this._PerformanceTagCache;
				}
				this._PerformanceTagInited = true;
				int performanceTagLength = this.Instance.PerformanceTagLength;
				this._PerformanceTagCache = new List<int>(performanceTagLength);
				for (int i = 0; i < performanceTagLength; i++)
				{
					this._PerformanceTagCache.Add(this.Instance.PerformanceTag(i));
				}
				return this._PerformanceTagCache;
			}
		}

		// Token: 0x0400815F RID: 33119
		private IModifySelfSceneItemAttributeTag Instance;

		// Token: 0x04008160 RID: 33120
		private List<int> _PerformanceTagCache;

		// Token: 0x04008161 RID: 33121
		private bool _PerformanceTagInited;
	}
}
