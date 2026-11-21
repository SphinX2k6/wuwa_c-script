using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02003445 RID: 13381
	[StaticVariableRuleIgnore]
	public abstract class ModelManagerBase : IModelManagerBase
	{
		// Token: 0x06021F78 RID: 139128 RVA: 0x00973074 File Offset: 0x00971274
		public bool CreateInstance()
		{
			try
			{
				bool flag = ModelRegister.CreateInstance();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "Model创建单例流程完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "Model创建单例流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x06021F79 RID: 139129 RVA: 0x00973110 File Offset: 0x00971310
		public bool Init()
		{
			try
			{
				bool flag = ModelRegister.Init();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "Model初始化完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "Model初始化流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x06021F7A RID: 139130 RVA: 0x009731AC File Offset: 0x009713AC
		public bool Clear()
		{
			try
			{
				bool flag = ModelRegister.Clear();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "Model清理完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "Model清理流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x06021F7B RID: 139131 RVA: 0x00973248 File Offset: 0x00971448
		public bool LeaveLevel()
		{
			try
			{
				bool flag = ModelRegister.LeaveLevel();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "模块系统退出关卡失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (!flag)
				{
					return false;
				}
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "模块系统退出关卡失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!this.OnLeaveLevel())
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LCC, "模块系统退出关卡失败，请往上查看具体出错模块日志解决问题", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x06021F7C RID: 139132 RVA: 0x00973310 File Offset: 0x00971510
		public bool ChangeMode()
		{
			try
			{
				bool flag = ModelRegister.ChangeMode();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "模块系统退出模式失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (!flag)
				{
					return false;
				}
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "模块系统退出模式失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!this.OnChangeMode())
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LFJW, "模块系统退出模式失败，请往上查看具体出错模块日志解决问题", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x06021F7D RID: 139133 RVA: 0x009733D4 File Offset: 0x009715D4
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x06021F7E RID: 139134 RVA: 0x009733D7 File Offset: 0x009715D7
		protected virtual bool OnClear()
		{
			return true;
		}

		// Token: 0x06021F7F RID: 139135 RVA: 0x009733DA File Offset: 0x009715DA
		protected virtual bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x06021F80 RID: 139136 RVA: 0x009733DD File Offset: 0x009715DD
		protected virtual bool OnChangeMode()
		{
			return true;
		}
	}
}
