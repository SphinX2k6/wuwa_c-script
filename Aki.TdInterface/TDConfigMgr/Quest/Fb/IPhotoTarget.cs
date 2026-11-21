using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014FA RID: 5370
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotoTarget
	{
		// Token: 0x060079A3 RID: 31139 RVA: 0x00122AF6 File Offset: 0x00120CF6
		[NullableContext(0)]
		public static IPhotoTarget Create(IPhotoTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotoTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x00122B15 File Offset: 0x00120D15
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x060079A5 RID: 31141 RVA: 0x00122B22 File Offset: 0x00120D22
		[Nullable(0)]
		public virtual string TidDescription
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.TidDescription;
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x00122B30 File Offset: 0x00120D30
		public virtual bool? IsOptionalTarget
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOptionalTarget);
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x060079A7 RID: 31143 RVA: 0x00122B66 File Offset: 0x00120D66
		public virtual SetVar SetVar
		{
			get
			{
				if (this._SetVarInited)
				{
					return this._SetVarCache;
				}
				this._SetVarInited = true;
				this._SetVarCache = SetVar.Create(this.Instance.SetVar);
				return this._SetVarCache;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x00122B9A File Offset: 0x00120D9A
		public virtual string EdTidDescription
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040045FE RID: 17918
		private IPhotoTarget Instance;

		// Token: 0x040045FF RID: 17919
		private SetVar _SetVarCache;

		// Token: 0x04004600 RID: 17920
		private bool _SetVarInited;
	}
}
