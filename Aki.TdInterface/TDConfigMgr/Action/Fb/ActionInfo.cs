using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D1 RID: 9425
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionInfo
	{
		// Token: 0x0600D286 RID: 53894 RVA: 0x001F3C63 File Offset: 0x001F1E63
		public static ActionInfo Create(IActionInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActionInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600D287 RID: 53895 RVA: 0x001F3C82 File Offset: 0x001F1E82
		public virtual EAction Name
		{
			get
			{
				return (EAction)this.Instance.Name;
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600D288 RID: 53896 RVA: 0x001F3C90 File Offset: 0x001F1E90
		public virtual bool? Async
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Async);
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600D289 RID: 53897 RVA: 0x001F3CC6 File Offset: 0x001F1EC6
		public virtual ActionParams Params
		{
			get
			{
				if (this._ParamsInited)
				{
					return this._ParamsCache;
				}
				this._ParamsInited = true;
				this._ParamsCache = ActionReadHelper.ReadActionInfo_Params(this.Instance);
				return this._ParamsCache;
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600D28A RID: 53898 RVA: 0x001F3CF8 File Offset: 0x001F1EF8
		public virtual int? ActionId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ActionId);
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600D28B RID: 53899 RVA: 0x001F3D30 File Offset: 0x001F1F30
		public virtual bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600D28C RID: 53900 RVA: 0x001F3D66 File Offset: 0x001F1F66
		[Nullable(2)]
		public virtual string ActionGuid
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ActionGuid;
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600D28D RID: 53901 RVA: 0x001F3D74 File Offset: 0x001F1F74
		public virtual float? Timeout
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Timeout);
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600D28E RID: 53902 RVA: 0x001F3DAC File Offset: 0x001F1FAC
		public virtual bool? EdLocalDisabled
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600D28F RID: 53903 RVA: 0x001F3DC2 File Offset: 0x001F1FC2
		[Nullable(2)]
		public virtual string EdNote
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400737B RID: 29563
		private IActionInfo Instance;

		// Token: 0x0400737C RID: 29564
		private ActionParams _ParamsCache;

		// Token: 0x0400737D RID: 29565
		private bool _ParamsInited;
	}
}
