using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002729 RID: 10025
	public class ISceneItemNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600DF8C RID: 57228 RVA: 0x00211FC4 File Offset: 0x002101C4
		[NullableContext(1)]
		public static ISceneItemNewSplineMoveTarget Create(ISceneItemNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x0600DF8D RID: 57229 RVA: 0x00211FE3 File Offset: 0x002101E3
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x00211FF0 File Offset: 0x002101F0
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x0600DF8F RID: 57231 RVA: 0x00212000 File Offset: 0x00210200
		public virtual bool? IsLookDir
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLookDir);
			}
		}

		// Token: 0x04007C11 RID: 31761
		private ISceneItemNewSplineMoveTarget Instance;
	}
}
