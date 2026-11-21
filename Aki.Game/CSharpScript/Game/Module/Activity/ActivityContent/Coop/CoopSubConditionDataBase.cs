using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005840 RID: 22592
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopSubConditionDataBase
	{
		// Token: 0x06037B67 RID: 228199 RVA: 0x00F93AD2 File Offset: 0x00F91CD2
		public CoopSubConditionDataBase(int id, ECoopSubConditionType taskType)
		{
			this.Id = id;
			this.TaskType = taskType;
		}

		// Token: 0x06037B68 RID: 228200 RVA: 0x00F93AF3 File Offset: 0x00F91CF3
		public virtual bool IsShowJumpBtn()
		{
			return false;
		}

		// Token: 0x06037B69 RID: 228201 RVA: 0x00F93AF6 File Offset: 0x00F91CF6
		public virtual bool IsTaskDone()
		{
			return false;
		}

		// Token: 0x06037B6A RID: 228202 RVA: 0x00F93AF9 File Offset: 0x00F91CF9
		public virtual void RefreshData(CoopTaskCompleteInfo data)
		{
		}

		// Token: 0x06037B6B RID: 228203 RVA: 0x00F93AFB File Offset: 0x00F91CFB
		public virtual void OnJumpClick()
		{
		}

		// Token: 0x06037B6C RID: 228204 RVA: 0x00F93B00 File Offset: 0x00F91D00
		public void JumpMapMark(int traceMapId, int traceMarkId)
		{
			MapMark? config = MapConfig.Instance.GetConfigMark(traceMarkId);
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, null, delegate(bool success, int viewId)
			{
				if (success)
				{
					MapModel.Instance.CreateTempMapMark(traceMarkId);
					WorldMapController.Instance.FocalMarkItem((EMarkType)config.Value.ObjectType, traceMarkId);
				}
			});
		}

		// Token: 0x0401D680 RID: 120448
		public int Id;

		// Token: 0x0401D681 RID: 120449
		public int Current;

		// Token: 0x0401D682 RID: 120450
		public int Target;

		// Token: 0x0401D683 RID: 120451
		public ECoopSubConditionType TaskType;

		// Token: 0x0401D684 RID: 120452
		public string Title = "";
	}
}
