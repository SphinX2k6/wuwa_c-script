using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035EE RID: 13806
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiStorage : Singleton
	{
		// Token: 0x0602329F RID: 144031 RVA: 0x009FDE37 File Offset: 0x009FC037
		[return: Nullable(2)]
		public SceneUiInfo Get(string viewName)
		{
			return this.SceneUiInfoMap.GetValueOrDefault(viewName);
		}

		// Token: 0x060232A0 RID: 144032 RVA: 0x009FDE48 File Offset: 0x009FC048
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

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x060232A1 RID: 144033 RVA: 0x009FDEDB File Offset: 0x009FC0DB
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

		// Token: 0x060232A2 RID: 144034 RVA: 0x009FDEFE File Offset: 0x009FC0FE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060232A3 RID: 144035 RVA: 0x009FDF00 File Offset: 0x009FC100
		public static void ResetStaticDefaultValue()
		{
			SceneUiStorage instance = SceneUiStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneUiStorage._instance = null;
		}

		// Token: 0x060232A4 RID: 144036 RVA: 0x009FDF19 File Offset: 0x009FC119
		static SceneUiStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiStorage.CreateStaticDefaultValue), new Action(SceneUiStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04013D7C RID: 81276
		private readonly Dictionary<string, SceneUiInfo> SceneUiInfoMap = new Dictionary<string, SceneUiInfo>();

		// Token: 0x04013D7D RID: 81277
		[Nullable(2)]
		private static SceneUiStorage _instance;
	}
}
