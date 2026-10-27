using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005415 RID: 21525
	[NullableContext(2)]
	[Nullable(0)]
	public class DeviceInfoItemData
	{
		// Token: 0x06037044 RID: 225348 RVA: 0x00D0964B File Offset: 0x00D0784B
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

		// Token: 0x0401D057 RID: 118871
		public int? Id;

		// Token: 0x0401D058 RID: 118872
		public string Name;

		// Token: 0x0401D059 RID: 118873
		public string LowText;

		// Token: 0x0401D05A RID: 118874
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		public Func<ValueTuple<string, bool>> GetInfoFunction;
	}
}
