using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B64 RID: 2916
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundation2 : IComponentBase
	{
		// Token: 0x06004325 RID: 17189 RVA: 0x000AB32E File Offset: 0x000A952E
		public static ItemFoundation2 Create(IItemFoundation2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundation2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x000AB350 File Offset: 0x000A9550
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x000AB388 File Offset: 0x000A9588
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x000AB39E File Offset: 0x000A959E
		public virtual IItemFoundationType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ComponentReadHelper.ReadItemFoundation2_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040025EB RID: 9707
		private IItemFoundation2 Instance;

		// Token: 0x040025EC RID: 9708
		private IItemFoundationType _ConfigCache;

		// Token: 0x040025ED RID: 9709
		private bool _ConfigInited;
	}
}
