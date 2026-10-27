using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291F RID: 10527
	[NullableContext(1)]
	[Nullable(0)]
	public class IGamepadShakeInTalk
	{
		// Token: 0x0600E9A2 RID: 59810 RVA: 0x00223E11 File Offset: 0x00222011
		public static IGamepadShakeInTalk Create(IGamepadShakeInTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeInTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x00223E30 File Offset: 0x00222030
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x00223E3D File Offset: 0x0022203D
		public virtual IGamepadShakeOptions Options
		{
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				this._OptionsCache = IGamepadShakeOptions.Create(this.Instance.Options);
				return this._OptionsCache;
			}
		}

		// Token: 0x040080EB RID: 33003
		private IGamepadShakeInTalk Instance;

		// Token: 0x040080EC RID: 33004
		[Nullable(2)]
		private IGamepadShakeOptions _OptionsCache;

		// Token: 0x040080ED RID: 33005
		private bool _OptionsInited;
	}
}
