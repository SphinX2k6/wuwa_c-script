using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02003441 RID: 13377
	[StaticVariableRuleIgnore]
	public abstract class ConfigManagerBase : IConfigManagerBase
	{
		// Token: 0x06021F65 RID: 139109 RVA: 0x00972AF0 File Offset: 0x00970CF0
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

		// Token: 0x06021F66 RID: 139110 RVA: 0x00972B78 File Offset: 0x00970D78
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

		// Token: 0x06021F67 RID: 139111 RVA: 0x00972C00 File Offset: 0x00970E00
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

		// Token: 0x06021F68 RID: 139112 RVA: 0x00972C88 File Offset: 0x00970E88
		protected bool OnInit()
		{
			return true;
		}

		// Token: 0x06021F69 RID: 139113 RVA: 0x00972C8B File Offset: 0x00970E8B
		protected bool OnClear()
		{
			return true;
		}
	}
}
