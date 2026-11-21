using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C2 RID: 25026
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveEventHandler
	{
		// Token: 0x0603C141 RID: 246081 RVA: 0x01118910 File Offset: 0x01116B10
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

		// Token: 0x0603C142 RID: 246082 RVA: 0x01118988 File Offset: 0x01116B88
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

		// Token: 0x0401FC64 RID: 130148
		public Dictionary<int, bool> ModifyCues = new Dictionary<int, bool>();
	}
}
