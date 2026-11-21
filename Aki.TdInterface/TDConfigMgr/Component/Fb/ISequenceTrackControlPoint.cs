using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D03 RID: 3331
	public class ISequenceTrackControlPoint
	{
		// Token: 0x06004BE6 RID: 19430 RVA: 0x000BE3B6 File Offset: 0x000BC5B6
		public static ISequenceTrackControlPoint Create(ISequenceTrackControlPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceTrackControlPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x000BE3D5 File Offset: 0x000BC5D5
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04002AEE RID: 10990
		private ISequenceTrackControlPoint Instance;
	}
}
