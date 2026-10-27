using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279E RID: 10142
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenCustomInitData : ISubScreenInitData
	{
		// Token: 0x0600E1B4 RID: 57780 RVA: 0x00215955 File Offset: 0x00213B55
		public static ISubScreenCustomInitData Create(ISubScreenCustomInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenCustomInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x00215974 File Offset: 0x00213B74
		public override ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x00215981 File Offset: 0x00213B81
		public override string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x0600E1B7 RID: 57783 RVA: 0x0021598E File Offset: 0x00213B8E
		public virtual ISubScreenConfig InitConfig
		{
			get
			{
				if (this._InitConfigInited)
				{
					return this._InitConfigCache;
				}
				this._InitConfigInited = true;
				this._InitConfigCache = ISubScreenConfig.Create(this.Instance.InitConfig);
				return this._InitConfigCache;
			}
		}

		// Token: 0x04007D26 RID: 32038
		private ISubScreenCustomInitData Instance;

		// Token: 0x04007D27 RID: 32039
		[Nullable(2)]
		private ISubScreenConfig _InitConfigCache;

		// Token: 0x04007D28 RID: 32040
		private bool _InitConfigInited;
	}
}
