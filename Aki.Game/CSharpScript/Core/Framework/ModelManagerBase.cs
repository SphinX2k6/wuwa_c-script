using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02004520 RID: 17696
	[StaticVariableRuleIgnore]
	public abstract class ModelManagerBase : IModelManagerBase
	{
		// Token: 0x0602D8A6 RID: 186534 RVA: 0x00A47264 File Offset: 0x00A45464
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

		// Token: 0x0602D8A7 RID: 186535 RVA: 0x00A47300 File Offset: 0x00A45500
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

		// Token: 0x0602D8A8 RID: 186536 RVA: 0x00A4739C File Offset: 0x00A4559C
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

		// Token: 0x0602D8A9 RID: 186537 RVA: 0x00A47438 File Offset: 0x00A45638
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

		// Token: 0x0602D8AA RID: 186538 RVA: 0x00A47500 File Offset: 0x00A45700
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

		// Token: 0x0602D8AB RID: 186539 RVA: 0x00A475C4 File Offset: 0x00A457C4
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x0602D8AC RID: 186540 RVA: 0x00A475C7 File Offset: 0x00A457C7
		protected virtual bool OnClear()
		{
			return true;
		}

		// Token: 0x0602D8AD RID: 186541 RVA: 0x00A475CA File Offset: 0x00A457CA
		protected virtual bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x0602D8AE RID: 186542 RVA: 0x00A475CD File Offset: 0x00A457CD
		protected virtual bool OnChangeMode()
		{
			return true;
		}
	}
}
