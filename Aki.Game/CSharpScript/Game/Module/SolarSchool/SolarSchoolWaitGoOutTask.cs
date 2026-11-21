using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058ED RID: 22765
	public class SolarSchoolWaitGoOutTask : SolarSchoolTaskBase
	{
		// Token: 0x06038227 RID: 229927 RVA: 0x00FB0710 File Offset: 0x00FAE910
		protected override void OnExecute()
		{
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 当天起始停驻：等待玩家在主界面点【外出】", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06038228 RID: 229928 RVA: 0x00FB073C File Offset: 0x00FAE93C
		public void OnPlayerEnter()
		{
			if (!base.IsExecuting)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 当天起始停驻点未在执行，忽略【外出】", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SolarSchoolGamePlayModel.Instance.OpenMapView(null);
			base.Complete(null);
		}
	}
}
