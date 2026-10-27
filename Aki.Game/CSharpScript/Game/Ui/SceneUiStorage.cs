using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046BD RID: 18109
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiStorage : Singleton
	{
		// Token: 0x0602EB53 RID: 191315 RVA: 0x00ACF50F File Offset: 0x00ACD70F
		[return: Nullable(2)]
		public SceneUiInfo Get(string viewName)
		{
			return this.SceneUiInfoMap.GetValueOrDefault(viewName);
		}

		// Token: 0x0602EB54 RID: 191316 RVA: 0x00ACF520 File Offset: 0x00ACD720
		public void Register([TupleElementNames(new string[]
		{
			"ViewName",
			"CreateView",
			"ResourceId"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1,
			1
		})] ValueTuple<string, Func<SceneUiView>, string>[] sceneUiInfoList)
		{
			foreach (ValueTuple<string, Func<SceneUiView>, string> valueTuple in sceneUiInfoList)
			{
				string item = valueTuple.Item1;
				if (this.SceneUiInfoMap.ContainsKey(item))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Scene3dUi;
					ELogAuthor author = ELogAuthor.HYF;
					string message = "[SceneUiStorage]重复注册";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName", item);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					this.SceneUiInfoMap[item] = new SceneUiInfo
					{
						CreateView = valueTuple.Item2,
						ResourceId = valueTuple.Item3
					};
				}
			}
		}

		// Token: 0x17007667 RID: 30311
		// (get) Token: 0x0602EB55 RID: 191317 RVA: 0x00ACF5B3 File Offset: 0x00ACD7B3
		public static SceneUiStorage Instance
		{
			get
			{
				if (SceneUiStorage._instance == null)
				{
					SceneUiStorage._instance = new SceneUiStorage();
					SceneUiStorage._instance.OnInit();
				}
				return SceneUiStorage._instance;
			}
		}

		// Token: 0x0602EB56 RID: 191318 RVA: 0x00ACF5D6 File Offset: 0x00ACD7D6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB57 RID: 191319 RVA: 0x00ACF5D8 File Offset: 0x00ACD7D8
		public static void ResetStaticDefaultValue()
		{
			SceneUiStorage instance = SceneUiStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneUiStorage._instance = null;
		}

		// Token: 0x0602EB58 RID: 191320 RVA: 0x00ACF5F1 File Offset: 0x00ACD7F1
		static SceneUiStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiStorage.CreateStaticDefaultValue), new Action(SceneUiStorage.ResetStaticDefaultValue));
		}

		// Token: 0x040196D5 RID: 104149
		private readonly Dictionary<string, SceneUiInfo> SceneUiInfoMap = new Dictionary<string, SceneUiInfo>();

		// Token: 0x040196D6 RID: 104150
		[Nullable(2)]
		private static SceneUiStorage _instance;
	}
}
