using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02003443 RID: 13379
	[StaticVariableRuleIgnore]
	public abstract class ControllerManagerBase : IControllerManagerBase
	{
		// Token: 0x06021F6D RID: 139117 RVA: 0x00972C98 File Offset: 0x00970E98
		public unsafe bool CreateInstance()
		{
			try
			{
				bool flag = ControllerRegister.CreateInstance();
				bool flag2 = ControllerRegister.RegisterTick();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "控制器创建单例流程完成";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("success", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("registerTickSuccess", flag2);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return flag && flag2;
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "控制器创建单例流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return false;
		}

		// Token: 0x06021F6E RID: 139118 RVA: 0x00972D70 File Offset: 0x00970F70
		public virtual bool Init()
		{
			try
			{
				bool flag = ControllerRegister.Init();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "控制器初始化流程完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return flag;
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "控制器初始化流程失败，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return false;
		}

		// Token: 0x06021F6F RID: 139119 RVA: 0x00972E0C File Offset: 0x0097100C
		public void Tick(float delta)
		{
			ControllerRegister.Tick(delta, this.IsInFight);
		}

		// Token: 0x06021F70 RID: 139120 RVA: 0x00972E1C File Offset: 0x0097101C
		public virtual bool Clear()
		{
			try
			{
				bool flag = ControllerRegister.Clear();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "控制器初始化流程完成";
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
				string message2 = "控制器清理执行异常，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!this.OnClear())
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LCC, "控制器系统清理失败，请往上查看具体出错模块日志解决问题", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			ControllerRegister.ClearTick();
			return true;
		}

		// Token: 0x06021F71 RID: 139121 RVA: 0x00972EE8 File Offset: 0x009710E8
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<string, CustomPromise<bool>>> Preload()
		{
			return ControllerRegister.Preload();
		}

		// Token: 0x06021F72 RID: 139122 RVA: 0x00972EF0 File Offset: 0x009710F0
		public void LeaveLevel()
		{
			try
			{
				bool flag = ControllerRegister.LeaveLevel();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "控制器退出关卡流程完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "控制器退出关卡执行异常，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (!this.OnLeaveLevel())
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LCC, "控制器退出关卡失败，请往上查看具体出错模块日志解决问题", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06021F73 RID: 139123 RVA: 0x00972FA8 File Offset: 0x009711A8
		public void ChangeMode()
		{
			try
			{
				bool flag = ControllerRegister.ChangeMode();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "控制器退出模式流程完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCore;
				ELogAuthor author2 = ELogAuthor.LRX;
				string message2 = "控制器退出模式执行异常，请往上查看具体出错模块日志解决问题";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ex:", ex.ToString());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (!this.OnChangeMode())
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.LFJW, "控制器退出模式失败，请往上查看具体出错模块日志解决问题", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06021F74 RID: 139124 RVA: 0x00973060 File Offset: 0x00971260
		protected bool OnClear()
		{
			return true;
		}

		// Token: 0x06021F75 RID: 139125 RVA: 0x00973063 File Offset: 0x00971263
		protected bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x06021F76 RID: 139126 RVA: 0x00973066 File Offset: 0x00971266
		protected bool OnChangeMode()
		{
			return true;
		}

		// Token: 0x04012BAE RID: 76718
		protected bool IsInFight;
	}
}
