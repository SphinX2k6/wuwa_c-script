using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046D6 RID: 18134
	public class UiNiagaraSettingModule : UiResourceLoadModule
	{
		// Token: 0x0602EC90 RID: 191632 RVA: 0x00AD52D8 File Offset: 0x00AD34D8
		[NullableContext(2)]
		public void SetNiagaraByPath([Nullable(1)] string path, UUINiagara uiNiagara, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (uiNiagara == null || !uiNiagara.IsValid())
			{
				return;
			}
			base.CancelResource(uiNiagara);
			int resourceId = ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(path, delegate([Nullable(2)] UNiagaraSystem niagara, string loadedPath)
			{
				this.DeleteResourceHandle(uiNiagara);
				if (!uiNiagara.IsValid())
				{
					return;
				}
				if (niagara == null || !niagara.IsValid())
				{
					Log.Instance.Error(ELogModule.UiImageSetting, ELogAuthor.YYZ, "设置NiagaraSystem失败，Niagara资源加载失败，资源路径：" + path, default(ReadOnlySpan<ValueTuple<string, object>>));
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					uiNiagara.SetNiagaraSystem(niagara);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 100, "js_undefined");
			base.SetResourceId(uiNiagara, resourceId);
		}

		// Token: 0x0602EC91 RID: 191633 RVA: 0x00AD5364 File Offset: 0x00AD3564
		[NullableContext(1)]
		public UniTask SetNiagaraByPathAsync(string path, UUINiagara uiNiagara)
		{
			UiNiagaraSettingModule.<SetNiagaraByPathAsync>d__1 <SetNiagaraByPathAsync>d__;
			<SetNiagaraByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetNiagaraByPathAsync>d__.<>4__this = this;
			<SetNiagaraByPathAsync>d__.path = path;
			<SetNiagaraByPathAsync>d__.uiNiagara = uiNiagara;
			<SetNiagaraByPathAsync>d__.<>1__state = -1;
			<SetNiagaraByPathAsync>d__.<>t__builder.Start<UiNiagaraSettingModule.<SetNiagaraByPathAsync>d__1>(ref <SetNiagaraByPathAsync>d__);
			return <SetNiagaraByPathAsync>d__.<>t__builder.Task;
		}
	}
}
