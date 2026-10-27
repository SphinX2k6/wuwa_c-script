using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x0200451F RID: 17695
	[StaticVariableRuleIgnore]
	public abstract class ControllerManagerBase : IControllerManagerBase
	{
		// Token: 0x0602D89B RID: 186523 RVA: 0x00A46E88 File Offset: 0x00A45088
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

		// Token: 0x0602D89C RID: 186524 RVA: 0x00A46F60 File Offset: 0x00A45160
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

		// Token: 0x0602D89D RID: 186525 RVA: 0x00A46FFC File Offset: 0x00A451FC
		public void Tick(float delta)
		{
			ControllerRegister.Tick(delta, this.IsInFight);
		}

		// Token: 0x0602D89E RID: 186526 RVA: 0x00A4700C File Offset: 0x00A4520C
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

		// Token: 0x0602D89F RID: 186527 RVA: 0x00A470D8 File Offset: 0x00A452D8
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

		// Token: 0x0602D8A0 RID: 186528 RVA: 0x00A470E0 File Offset: 0x00A452E0
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

		// Token: 0x0602D8A1 RID: 186529 RVA: 0x00A47198 File Offset: 0x00A45398
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

		// Token: 0x0602D8A2 RID: 186530 RVA: 0x00A47250 File Offset: 0x00A45450
		protected bool OnClear()
		{
			return true;
		}

		// Token: 0x0602D8A3 RID: 186531 RVA: 0x00A47253 File Offset: 0x00A45453
		protected bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x0602D8A4 RID: 186532 RVA: 0x00A47256 File Offset: 0x00A45456
		protected bool OnChangeMode()
		{
			return true;
		}

		// Token: 0x04018585 RID: 99717
		protected bool IsInFight;
	}
}
