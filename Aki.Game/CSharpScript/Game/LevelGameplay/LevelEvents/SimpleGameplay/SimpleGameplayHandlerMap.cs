using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02006BBE RID: 27582
	[NullableContext(1)]
	[Nullable(0)]
	public class SimpleGameplayHandlerMap<[Nullable(0)] THandler> where THandler : ISimpleGameplayHandlerBase
	{
		// Token: 0x0604434D RID: 279373 RVA: 0x010D0180 File Offset: 0x010CE380
		public unsafe void Register(THandler handler)
		{
			ESimpleGameplayType type = handler.Type;
			THandler thandler;
			if (this.Handlers.TryGetValue(type, out thandler) && thandler != handler)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.XDW;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[SimpleGameplayHandlerRegistry] 重复注册 Handler: ");
				defaultInterpolatedStringHandler.AppendFormatted<ESimpleGameplayType>(type);
				defaultInterpolatedStringHandler.AppendLiteral(", 后者覆盖前者");
				string message = defaultInterpolatedStringHandler.ToStringAndClear();
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("exist", thandler);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", handler);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.Handlers[type] = handler;
		}

		// Token: 0x0604434E RID: 279374 RVA: 0x010D0255 File Offset: 0x010CE455
		[NullableContext(2)]
		public THandler Get(ESimpleGameplayType type)
		{
			return this.Handlers.GetValueOrDefault(type);
		}

		// Token: 0x0604434F RID: 279375 RVA: 0x010D0263 File Offset: 0x010CE463
		public void Unregister(ESimpleGameplayType type)
		{
			this.Handlers.Remove(type);
		}

		// Token: 0x06044350 RID: 279376 RVA: 0x010D0272 File Offset: 0x010CE472
		public List<ESimpleGameplayType> GetAllRegisteredTypes()
		{
			return new List<ESimpleGameplayType>(this.Handlers.Keys);
		}

		// Token: 0x04023984 RID: 145796
		private readonly Dictionary<ESimpleGameplayType, THandler> Handlers = new Dictionary<ESimpleGameplayType, THandler>();
	}
}
