using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x0200451E RID: 17694
	[StaticVariableRuleIgnore]
	public abstract class ConfigManagerBase : IConfigManagerBase
	{
		// Token: 0x0602D895 RID: 186517 RVA: 0x00A46CE0 File Offset: 0x00A44EE0
		public bool CreateInstance()
		{
			try
			{
				bool flag = ConfigRegister.CreateInstance();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "配置创建单例流程完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success:", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "控制器创建单例流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x0602D896 RID: 186518 RVA: 0x00A46D68 File Offset: 0x00A44F68
		public bool Init()
		{
			try
			{
				bool flag = ConfigRegister.Init();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "配置初始化流程结束";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success:", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "配置初始化失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x0602D897 RID: 186519 RVA: 0x00A46DF0 File Offset: 0x00A44FF0
		public bool Clear()
		{
			try
			{
				bool flag = ConfigRegister.Clear();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "配置清理失败流程结束";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success:", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "配置清理失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return true;
		}

		// Token: 0x0602D898 RID: 186520 RVA: 0x00A46E78 File Offset: 0x00A45078
		protected bool OnInit()
		{
			return true;
		}

		// Token: 0x0602D899 RID: 186521 RVA: 0x00A46E7B File Offset: 0x00A4507B
		protected bool OnClear()
		{
			return true;
		}
	}
}
