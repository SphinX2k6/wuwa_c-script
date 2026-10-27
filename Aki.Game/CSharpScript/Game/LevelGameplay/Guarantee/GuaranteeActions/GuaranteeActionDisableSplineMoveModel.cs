using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E10 RID: 28176
	public class GuaranteeActionDisableSplineMoveModel : GuaranteeActionBase
	{
		// Token: 0x06044B65 RID: 281445 RVA: 0x010F5970 File Offset: 0x010F3B70
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params)
		{
			EnableSplineMoveModel enableSplineMoveModel = @params as EnableSplineMoveModel;
			if (enableSplineMoveModel == null)
			{
				return;
			}
			ISplineMoveConfig config = enableSplineMoveModel.Config;
			Entity entity = null;
			ETargetEntityType type = config.Target.Type;
			if (type != ETargetEntityType.Triggered)
			{
				if (type != ETargetEntityType.Player)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "EnableSplineMoveModel不接受此对象类型";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", config.Target.Type);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter == null || !baseCharacter.IsValid())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.YSQ;
					string message2 = "EnableSplineMoveModel.BaseCharacter InValid";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", config.Target.Type);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				entity = Global.BaseCharacter.GetEntityNoBlueprint();
			}
			BaseSplineMoveComponent baseSplineMoveComponent = (entity != null) ? entity.GetComponent<BaseSplineMoveComponent>() : null;
			if (baseSplineMoveComponent == null || !baseSplineMoveComponent.Valid)
			{
				return;
			}
			baseSplineMoveComponent.EndSplineMove(config.SplineEntityId);
		}
	}
}
