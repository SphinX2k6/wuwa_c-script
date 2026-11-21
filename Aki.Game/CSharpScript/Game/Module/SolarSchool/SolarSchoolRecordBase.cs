using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058DB RID: 22747
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SolarSchoolRecordBase
	{
		// Token: 0x0603809C RID: 229532 RVA: 0x00FAA3C3 File Offset: 0x00FA85C3
		protected SolarSchoolRecordBase()
		{
			SolarSchoolGamePlayModel.Instance.RegisterRecordData(this);
		}

		// Token: 0x0603809D RID: 229533 RVA: 0x00FAA3D6 File Offset: 0x00FA85D6
		public void Init(int activityId)
		{
			this.OnInit(activityId);
		}

		// Token: 0x0603809E RID: 229534 RVA: 0x00FAA3DF File Offset: 0x00FA85DF
		protected virtual void OnInit(int activityId)
		{
		}

		// Token: 0x0603809F RID: 229535
		public abstract void Serialize(SolarSchoolSaveGamePb gameData);

		// Token: 0x060380A0 RID: 229536
		public abstract void Deserialize(SolarSchoolSaveGamePb gameData);
	}
}
