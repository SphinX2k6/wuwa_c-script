using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E1 RID: 10721
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadMp4s : IPreloadCharacterType
	{
		// Token: 0x0600ECD2 RID: 60626 RVA: 0x00229112 File Offset: 0x00227312
		public static IPreloadMp4s Create(IPreloadMp4s? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadMp4s
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x00229131 File Offset: 0x00227331
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x0600ECD4 RID: 60628 RVA: 0x00229140 File Offset: 0x00227340
		public virtual List<string> Mp4s
		{
			get
			{
				if (this._Mp4sInited)
				{
					return this._Mp4sCache;
				}
				this._Mp4sInited = true;
				int mp4sLength = this.Instance.Mp4sLength;
				this._Mp4sCache = new List<string>(mp4sLength);
				for (int i = 0; i < mp4sLength; i++)
				{
					this._Mp4sCache.Add(this.Instance.Mp4s(i));
				}
				return this._Mp4sCache;
			}
		}

		// Token: 0x0400826B RID: 33387
		private IPreloadMp4s Instance;

		// Token: 0x0400826C RID: 33388
		private List<string> _Mp4sCache;

		// Token: 0x0400826D RID: 33389
		private bool _Mp4sInited;
	}
}
