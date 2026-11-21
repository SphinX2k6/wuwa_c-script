using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCE RID: 11470
	public class IPreloadMp4s : IPreloadCharacterType
	{
		// Token: 0x0600FB69 RID: 64361 RVA: 0x00246A96 File Offset: 0x00244C96
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

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x0600FB6A RID: 64362 RVA: 0x00246AB5 File Offset: 0x00244CB5
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x0600FB6B RID: 64363 RVA: 0x00246AC4 File Offset: 0x00244CC4
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

		// Token: 0x0400895C RID: 35164
		private IPreloadMp4s Instance;

		// Token: 0x0400895D RID: 35165
		private List<string> _Mp4sCache;

		// Token: 0x0400895E RID: 35166
		private bool _Mp4sInited;
	}
}
