using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02005D37 RID: 23863
	[NullableContext(1)]
	[Nullable(0)]
	public class SimpleGameplayHandlerMap<[Nullable(0)] THandler> where THandler : ISimpleGameplayHandlerBase
	{
		// Token: 0x0603A4A5 RID: 238757 RVA: 0x0107A0D4 File Offset: 0x010782D4
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

		// Token: 0x0603A4A6 RID: 238758 RVA: 0x0107A1A9 File Offset: 0x010783A9
		[NullableContext(2)]
		public THandler Get(ESimpleGameplayType type)
		{
			return this.Handlers.GetValueOrDefault(type);
		}

		// Token: 0x0603A4A7 RID: 238759 RVA: 0x0107A1B7 File Offset: 0x010783B7
		public void Unregister(ESimpleGameplayType type)
		{
			this.Handlers.Remove(type);
		}

		// Token: 0x0603A4A8 RID: 238760 RVA: 0x0107A1C6 File Offset: 0x010783C6
		public List<ESimpleGameplayType> GetAllRegisteredTypes()
		{
			return new List<ESimpleGameplayType>(this.Handlers.Keys);
		}

		// Token: 0x0401EC26 RID: 125990
		private readonly Dictionary<ESimpleGameplayType, THandler> Handlers = new Dictionary<ESimpleGameplayType, THandler>();
	}
}
