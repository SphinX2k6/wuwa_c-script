using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B06 RID: 27398
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventClientModifyTargetTag : LevelEventBase
	{
		// Token: 0x0604405B RID: 278619 RVA: 0x010B6CB0 File Offset: 0x010B4EB0
		public LevelEventClientModifyTargetTag(int id) : base(id)
		{
		}

		// Token: 0x0604405C RID: 278620 RVA: 0x010B6CBC File Offset: 0x010B4EBC
		private bool ModifySceneItemTag(int? contextEntityId, ClientModifyTargetTag clientModifyTargetTagParams)
		{
			EntityHandle entityHandle = null;
			EClientModifyTargetType type = clientModifyTargetTagParams.Target.Type;
			if (type != EClientModifyTargetType.Self)
			{
				if (type == EClientModifyTargetType.Player)
				{
					entityHandle = SceneTeamModel.Instance.GetCurrentEntity;
				}
			}
			else if (contextEntityId != null)
			{
				entityHandle = CreatureModel.Instance.GetEntityById(contextEntityId.Value);
			}
			if (entityHandle != null && entityHandle.Valid)
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity != null && entity.Valid)
				{
					BaseTagComponent baseTagComponent = entityHandle.Entity.CheckGetComponent<BaseTagComponent>();
					if (baseTagComponent == null)
					{
						return false;
					}
					if (clientModifyTargetTagParams.IsAddTag)
					{
						using (List<string>.Enumerator enumerator = clientModifyTargetTagParams.PerformanceTag.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string tagName = enumerator.Current;
								int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
								LevelGamePlayController.Instance.ClientAddTagToTarget(entityHandle, tagIdByName);
								baseTagComponent.AddTag(new int?(tagIdByName));
							}
							return true;
						}
					}
					foreach (string tagName2 in clientModifyTargetTagParams.PerformanceTag)
					{
						int tagIdByName2 = GameplayTagUtils.GetTagIdByName(tagName2);
						if (LevelGamePlayController.Instance.ClientRemoveTagFromTarget(entityHandle.Id, tagIdByName2))
						{
							baseTagComponent.RemoveTag(new int?(tagIdByName2));
						}
						else if (baseTagComponent.HasTag(tagIdByName2))
						{
							global::Log instance = global::Log.Instance;
							ELogModule module = ELogModule.LevelEvent;
							ELogAuthor author = ELogAuthor.XDW;
							string message = "ClientModifyTargetTag 不能删除非本行为添加的Tag";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Params", clientModifyTargetTagParams);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604405D RID: 278621 RVA: 0x010B6E48 File Offset: 0x010B5048
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ClientModifyTargetTag clientModifyTargetTag = inParams as ClientModifyTargetTag;
			if (clientModifyTargetTag == null)
			{
				return;
			}
			EGeneralContextType? type = context.Type;
			if (type != null)
			{
				EGeneralContextType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault == EGeneralContextType.Entity)
				{
					this.ModifySceneItemTag((context as EntityContext).EntityId, clientModifyTargetTag);
					return;
				}
				if (valueOrDefault == EGeneralContextType.Trigger)
				{
					this.ModifySceneItemTag((context as TriggerContext).TriggerEntityId, clientModifyTargetTag);
					return;
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.XDW;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ClientModifyTargetTag 没有支持的类型 ");
			defaultInterpolatedStringHandler.AppendFormatted<EGeneralContextType?>(context.Type);
			string message = defaultInterpolatedStringHandler.ToStringAndClear();
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Params", inParams);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Context", context);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}
}
