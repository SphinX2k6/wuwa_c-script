using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E18 RID: 3608
	public class ConnectorComponent : IComponentBase
	{
		// Token: 0x060051BF RID: 20927 RVA: 0x000CA52F File Offset: 0x000C872F
		public static ConnectorComponent Create(IConnectorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConnectorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x000CA550 File Offset: 0x000C8750
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x000CA588 File Offset: 0x000C8788
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x000CA59E File Offset: 0x000C879E
		public virtual IConnectorLogicType LogicType
		{
			get
			{
				if (this._LogicTypeInited)
				{
					return this._LogicTypeCache;
				}
				this._LogicTypeInited = true;
				this._LogicTypeCache = ComponentReadHelper.ReadConnectorComponent_LogicType(this.Instance);
				return this._LogicTypeCache;
			}
		}

		// Token: 0x04002EA1 RID: 11937
		private IConnectorComponent Instance;

		// Token: 0x04002EA2 RID: 11938
		private IConnectorLogicType _LogicTypeCache;

		// Token: 0x04002EA3 RID: 11939
		private bool _LogicTypeInited;
	}
}
