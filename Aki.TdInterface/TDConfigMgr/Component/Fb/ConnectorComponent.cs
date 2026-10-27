using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1E RID: 3358
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectorComponent : IComponentBase
	{
		// Token: 0x06004CA5 RID: 19621 RVA: 0x000BEE5B File Offset: 0x000BD05B
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

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x000BEE7C File Offset: 0x000BD07C
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x000BEEB4 File Offset: 0x000BD0B4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x000BEECA File Offset: 0x000BD0CA
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

		// Token: 0x04002BE1 RID: 11233
		private IConnectorComponent Instance;

		// Token: 0x04002BE2 RID: 11234
		private IConnectorLogicType _LogicTypeCache;

		// Token: 0x04002BE3 RID: 11235
		private bool _LogicTypeInited;
	}
}
