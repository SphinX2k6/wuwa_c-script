using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037C7 RID: 14279
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCgAction : VisualNovelAction
	{
		// Token: 0x060252EF RID: 152303 RVA: 0x00A7D479 File Offset: 0x00A7B679
		public VisualNovelCgAction(VisualNovelContext context, IVisualNovelCgBase config) : base(context)
		{
			this.Config = config;
		}

		// Token: 0x060252F0 RID: 152304 RVA: 0x00A7D48C File Offset: 0x00A7B68C
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelCgAction.<ExecuteCoreAsync>d__2 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelCgAction.<ExecuteCoreAsync>d__2>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252F1 RID: 152305 RVA: 0x00A7D4D0 File Offset: 0x00A7B6D0
		private void SetCharactersHidden(bool hidden)
		{
			base.Context.AreCharactersTemporarilyHidden = hidden;
			foreach (VisualNovelCharacter visualNovelCharacter in base.Context.Scene.GetCharacters())
			{
				visualNovelCharacter.SetTemporarilyHidden(hidden);
			}
		}

		// Token: 0x04014916 RID: 84246
		private readonly IVisualNovelCgBase Config;
	}
}
