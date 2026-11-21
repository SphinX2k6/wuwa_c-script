using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A98 RID: 23192
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityActionFactory : Singleton
	{
		// Token: 0x06039285 RID: 234117 RVA: 0x010018E8 File Offset: 0x00FFFAE8
		public void Register(EActivityActionType type, Func<ActivityActionBase> creator)
		{
			if (creator == null)
			{
				return;
			}
			if (this.Creators.ContainsKey(type))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityActionFactory 重复注册 ActionType，后者覆盖前者";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.Creators[type] = creator;
		}

		// Token: 0x06039286 RID: 234118 RVA: 0x01001943 File Offset: 0x00FFFB43
		public bool IsRegistered(EActivityActionType type)
		{
			return this.Creators.ContainsKey(type);
		}

		// Token: 0x06039287 RID: 234119 RVA: 0x01001954 File Offset: 0x00FFFB54
		[NullableContext(2)]
		public ActivityActionBase Create(EActivityActionType type, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> parameters = null)
		{
			Func<ActivityActionBase> func;
			if (!this.Creators.TryGetValue(type, out func))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityActionFactory 未注册的 ActionType";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			ActivityActionBase activityActionBase = func();
			if (activityActionBase == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Activity;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "ActivityActionFactory 创建委托返回 null";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", type);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			activityActionBase.ParseParams(parameters ?? ActivityActionFactory.EmptyParams);
			return activityActionBase;
		}

		// Token: 0x17006CD2 RID: 27858
		// (get) Token: 0x06039288 RID: 234120 RVA: 0x010019EE File Offset: 0x00FFFBEE
		public static ActivityActionFactory Instance
		{
			get
			{
				if (ActivityActionFactory._instance == null)
				{
					ActivityActionFactory._instance = new ActivityActionFactory();
					ActivityActionFactory._instance.OnInit();
				}
				return ActivityActionFactory._instance;
			}
		}

		// Token: 0x06039289 RID: 234121 RVA: 0x01001A11 File Offset: 0x00FFFC11
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603928A RID: 234122 RVA: 0x01001A13 File Offset: 0x00FFFC13
		public static void ResetStaticDefaultValue()
		{
			ActivityActionFactory instance = ActivityActionFactory._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ActivityActionFactory._instance = null;
		}

		// Token: 0x0603928B RID: 234123 RVA: 0x01001A2C File Offset: 0x00FFFC2C
		static ActivityActionFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityActionFactory.CreateStaticDefaultValue), new Action(ActivityActionFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0401E13F RID: 123199
		private readonly Dictionary<EActivityActionType, Func<ActivityActionBase>> Creators = new Dictionary<EActivityActionType, Func<ActivityActionBase>>();

		// Token: 0x0401E140 RID: 123200
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<string, string> EmptyParams = new Dictionary<string, string>();

		// Token: 0x0401E141 RID: 123201
		[Nullable(2)]
		private static ActivityActionFactory _instance;
	}
}
