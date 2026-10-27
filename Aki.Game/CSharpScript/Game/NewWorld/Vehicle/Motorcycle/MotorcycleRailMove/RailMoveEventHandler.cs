using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007041 RID: 28737
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveEventHandler
	{
		// Token: 0x06045F5B RID: 286555 RVA: 0x0116EBA0 File Offset: 0x0116CDA0
		public void UpdateFromUeData(SMotorRailMove_EventHandler data)
		{
			this.ModifyCues.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair in data.ModifyCues)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int key = num;
				bool value = flag;
				this.ModifyCues[key] = value;
			}
		}

		// Token: 0x06045F5C RID: 286556 RVA: 0x0116EC10 File Offset: 0x0116CE10
		public void DeepCopy(RailMoveEventHandler other)
		{
			this.ModifyCues.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair in other.ModifyCues)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int key = num;
				bool value = flag;
				this.ModifyCues[key] = value;
			}
		}

		// Token: 0x040249AE RID: 149934
		public Dictionary<int, bool> ModifyCues = new Dictionary<int, bool>();
	}
}
