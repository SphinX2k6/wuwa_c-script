using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068F0 RID: 26864
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopSubConditionDataBase
	{
		// Token: 0x0604300F RID: 274447 RVA: 0x010524AA File Offset: 0x010506AA
		public CoopSubConditionDataBase(int id, ECoopSubConditionType taskType)
		{
			this.Id = id;
			this.TaskType = taskType;
		}

		// Token: 0x06043010 RID: 274448 RVA: 0x010524CB File Offset: 0x010506CB
		public virtual bool IsShowJumpBtn()
		{
			return false;
		}

		// Token: 0x06043011 RID: 274449 RVA: 0x010524CE File Offset: 0x010506CE
		public virtual bool IsTaskDone()
		{
			return false;
		}

		// Token: 0x06043012 RID: 274450 RVA: 0x010524D1 File Offset: 0x010506D1
		public virtual void RefreshData(CoopTaskCompleteInfo data)
		{
		}

		// Token: 0x06043013 RID: 274451 RVA: 0x010524D3 File Offset: 0x010506D3
		public virtual void OnJumpClick()
		{
		}

		// Token: 0x06043014 RID: 274452 RVA: 0x010524D8 File Offset: 0x010506D8
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

		// Token: 0x04022E24 RID: 142884
		public int Id;

		// Token: 0x04022E25 RID: 142885
		public int Current;

		// Token: 0x04022E26 RID: 142886
		public int Target;

		// Token: 0x04022E27 RID: 142887
		public ECoopSubConditionType TaskType;

		// Token: 0x04022E28 RID: 142888
		public string Title = "";
	}
}
