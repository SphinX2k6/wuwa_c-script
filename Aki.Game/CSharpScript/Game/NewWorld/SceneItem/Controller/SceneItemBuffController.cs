using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x020062F1 RID: 25329
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemBuffController : ControllerBase
	{
		// Token: 0x0603D421 RID: 250913 RVA: 0x011B0BC8 File Offset: 0x011AEDC8
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

		// Token: 0x170073FA RID: 29690
		// (get) Token: 0x0603D422 RID: 250914 RVA: 0x011B0C1F File Offset: 0x011AEE1F
		public static SceneItemBuffController Instance
		{
			get
			{
				return SceneItemBuffController._Instance;
			}
		}

		// Token: 0x0603D423 RID: 250915 RVA: 0x011B0C26 File Offset: 0x011AEE26
		public static SceneItemBuffController GetOrCreateInstance()
		{
			if (SceneItemBuffController._Instance == null)
			{
				SceneItemBuffController.CreateInstance();
			}
			return SceneItemBuffController._Instance;
		}

		// Token: 0x0603D424 RID: 250916 RVA: 0x011B0C3A File Offset: 0x011AEE3A
		public static bool CreateInstance()
		{
			if (SceneItemBuffController._Instance != null)
			{
				return true;
			}
			SceneItemBuffController._Instance = new SceneItemBuffController();
			return true;
		}

		// Token: 0x0603D425 RID: 250917 RVA: 0x011B0C50 File Offset: 0x011AEE50
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D426 RID: 250918 RVA: 0x011B0C52 File Offset: 0x011AEE52
		public static void ResetStaticDefaultValue()
		{
			SceneItemBuffController._Instance = null;
		}

		// Token: 0x0603D427 RID: 250919 RVA: 0x011B0C5A File Offset: 0x011AEE5A
		static SceneItemBuffController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemBuffController.CreateStaticDefaultValue), new Action(SceneItemBuffController.ResetStaticDefaultValue));
		}

		// Token: 0x040207CB RID: 133067
		[Nullable(2)]
		private static SceneItemBuffController _Instance;
	}
}
