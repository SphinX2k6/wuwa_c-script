using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB7 RID: 23735
	public class LevelEventModifyActorMaterial : LevelEventBase
	{
		// Token: 0x0603A2AD RID: 238253 RVA: 0x01068395 File Offset: 0x01066595
		public LevelEventModifyActorMaterial(int id) : base(id)
		{
		}

		// Token: 0x0603A2AE RID: 238254 RVA: 0x010683A0 File Offset: 0x010665A0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ModifyActorMaterial modifyActorMaterial = inParams as ModifyActorMaterial;
			if (modifyActorMaterial == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "此LevelEvent只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "状态控制entity不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityContext.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
			if (((component != null) ? component.Owner : null) == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZS, "状态控制actor不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SceneItemReferenceComponent component2 = entity.GetComponent<SceneItemReferenceComponent>();
			if (component2 != null)
			{
				component2.HandleActorMaterial(modifyActorMaterial);
			}
		}
	}
}
