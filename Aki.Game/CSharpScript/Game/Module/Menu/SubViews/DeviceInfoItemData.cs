using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x020043F8 RID: 17400
	[NullableContext(2)]
	[Nullable(0)]
	public class DeviceInfoItemData
	{
		// Token: 0x0602BF8D RID: 180109 RVA: 0x00C58A73 File Offset: 0x00C56C73
		[NullableContext(1)]
		public DeviceInfoItemData(int id, string name, string lowText, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<ValueTuple<string, bool>> getInfoFunction)
		{
			this.Id = new int?(id);
			this.Name = name;
			this.LowText = lowText;
			this.GetInfoFunction = getInfoFunction;
		}

		// Token: 0x04017AF0 RID: 97008
		public int? Id;

		// Token: 0x04017AF1 RID: 97009
		public string Name;

		// Token: 0x04017AF2 RID: 97010
		public string LowText;

		// Token: 0x04017AF3 RID: 97011
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		public Func<ValueTuple<string, bool>> GetInfoFunction;
	}
}
