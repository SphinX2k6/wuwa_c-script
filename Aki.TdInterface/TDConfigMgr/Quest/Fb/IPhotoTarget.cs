using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A9 RID: 5033
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotoTarget
	{
		// Token: 0x060072FC RID: 29436 RVA: 0x0011443A File Offset: 0x0011263A
		[NullableContext(1)]
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

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x00114459 File Offset: 0x00112659
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x00114466 File Offset: 0x00112666
		[Nullable(1)]
		public virtual string TidDescription
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.TidDescription;
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x060072FF RID: 29439 RVA: 0x00114474 File Offset: 0x00112674
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

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x06007300 RID: 29440 RVA: 0x001144AA File Offset: 0x001126AA
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

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06007301 RID: 29441 RVA: 0x001144DE File Offset: 0x001126DE
		public virtual string EdTidDescription
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400427D RID: 17021
		private IPhotoTarget Instance;

		// Token: 0x0400427E RID: 17022
		private SetVar _SetVarCache;

		// Token: 0x0400427F RID: 17023
		private bool _SetVarInited;
	}
}
