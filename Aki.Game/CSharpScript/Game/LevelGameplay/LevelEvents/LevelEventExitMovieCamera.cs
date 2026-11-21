using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C9F RID: 23711
	public class LevelEventExitMovieCamera : LevelEventBase
	{
		// Token: 0x0603A24E RID: 238158 RVA: 0x010659C7 File Offset: 0x01063BC7
		public LevelEventExitMovieCamera(int id) : base(id)
		{
		}

		// Token: 0x0603A24F RID: 238159 RVA: 0x010659D0 File Offset: 0x01063BD0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!(inParams is ExitMovieCamera))
			{
				base.FinishExecute(false, false, true);
				return;
			}
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "[电影镜头]通过LevelEvent离开电影镜头", default(ReadOnlySpan<ValueTuple<string, object>>));
			CameraModel instance = CameraModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.MainModel.StopMovieCamera(delegate(bool success)
			{
				base.FinishExecute(success, false, true);
				global::Log instance2 = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[电影镜头]通过LevelEvent离开电影镜头结果";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", success);
				instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}, "关卡事件,停止电影镜头");
		}
	}
}
