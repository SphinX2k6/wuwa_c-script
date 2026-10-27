using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296B RID: 10603
	[NullableContext(1)]
	[Nullable(0)]
	public class IPieceBase
	{
		// Token: 0x0600EAFD RID: 60157 RVA: 0x00226457 File Offset: 0x00224657
		public static IPieceBase Create(IPieceBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x0600EAFE RID: 60158 RVA: 0x00226476 File Offset: 0x00224676
		public virtual IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				this._IndexCache = IPieceIndex.Create(this.Instance.Index);
				return this._IndexCache;
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x002264AA File Offset: 0x002246AA
		public virtual bool Active
		{
			get
			{
				return this.Instance.Active;
			}
		}

		// Token: 0x04008175 RID: 33141
		private IPieceBase Instance;

		// Token: 0x04008176 RID: 33142
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x04008177 RID: 33143
		private bool _IndexInited;
	}
}
