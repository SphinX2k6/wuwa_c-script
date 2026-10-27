using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x0200723C RID: 29244
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemBuffController : ControllerBase
	{
		// Token: 0x06047ABF RID: 293567 RVA: 0x01257F18 File Offset: 0x01256118
		[NullableContext(2)]
		public void BuffOperate(int entityId, BuffOperateType type, Action<BuffOperateType, bool> resultCb = null)
		{
			long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
			EntityBuffProducerOperateRequest entityBuffProducerOperateRequest = EntityBuffProducerOperateRequest.Create();
			entityBuffProducerOperateRequest.OpEntityId = creatureDataId;
			entityBuffProducerOperateRequest.OpType = type;
			Net.Instance.Call(ERequestMessageId.EntityBuffProducerOperateRequest, entityBuffProducerOperateRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EntityBuffProducerOperateResponse entityBuffProducerOperateResponse = (EntityBuffProducerOperateResponse)msg;
				bool arg = false;
				if (entityBuffProducerOperateResponse.ErrorCode == ErrorCode.Success)
				{
					arg = true;
				}
				long opEntityId = entityBuffProducerOperateResponse.OpEntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(opEntityId);
				if (entity == null || !entity.IsInit)
				{
					return;
				}
				if (resultCb != null)
				{
					resultCb(entityBuffProducerOperateResponse.OpType, arg);
				}
			}, 0);
		}

		// Token: 0x17009E43 RID: 40515
		// (get) Token: 0x06047AC0 RID: 293568 RVA: 0x01257F6F File Offset: 0x0125616F
		public static SceneItemBuffController Instance
		{
			get
			{
				return SceneItemBuffController._Instance;
			}
		}

		// Token: 0x06047AC1 RID: 293569 RVA: 0x01257F76 File Offset: 0x01256176
		public static SceneItemBuffController GetOrCreateInstance()
		{
			if (SceneItemBuffController._Instance == null)
			{
				SceneItemBuffController.CreateInstance();
			}
			return SceneItemBuffController._Instance;
		}

		// Token: 0x06047AC2 RID: 293570 RVA: 0x01257F8A File Offset: 0x0125618A
		public static bool CreateInstance()
		{
			if (SceneItemBuffController._Instance != null)
			{
				return true;
			}
			SceneItemBuffController._Instance = new SceneItemBuffController();
			return true;
		}

		// Token: 0x06047AC3 RID: 293571 RVA: 0x01257FA0 File Offset: 0x012561A0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047AC4 RID: 293572 RVA: 0x01257FA2 File Offset: 0x012561A2
		public static void ResetStaticDefaultValue()
		{
			SceneItemBuffController._Instance = null;
		}

		// Token: 0x06047AC5 RID: 293573 RVA: 0x01257FAA File Offset: 0x012561AA
		static SceneItemBuffController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemBuffController.CreateStaticDefaultValue), new Action(SceneItemBuffController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B5C RID: 154460
		[Nullable(2)]
		private static SceneItemBuffController _Instance;
	}
}
