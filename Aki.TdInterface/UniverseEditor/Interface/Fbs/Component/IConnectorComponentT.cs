using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005560 RID: 21856
	public class IConnectorComponentT
	{
		// Token: 0x17009C4F RID: 40015
		// (get) Token: 0x06022B33 RID: 142131 RVA: 0x004C7B3D File Offset: 0x004C5D3D
		// (set) Token: 0x06022B34 RID: 142132 RVA: 0x004C7B45 File Offset: 0x004C5D45
		public bool Disabled { get; set; }

		// Token: 0x17009C50 RID: 40016
		// (get) Token: 0x06022B35 RID: 142133 RVA: 0x004C7B4E File Offset: 0x004C5D4E
		// (set) Token: 0x06022B36 RID: 142134 RVA: 0x004C7B56 File Offset: 0x004C5D56
		public TConnectorLogicUnion LogicType { get; set; }

		// Token: 0x17009C51 RID: 40017
		// (get) Token: 0x06022B37 RID: 142135 RVA: 0x004C7B5F File Offset: 0x004C5D5F
		// (set) Token: 0x06022B38 RID: 142136 RVA: 0x004C7B67 File Offset: 0x004C5D67
		public byte NullMask { get; set; }

		// Token: 0x06022B39 RID: 142137 RVA: 0x004C7B70 File Offset: 0x004C5D70
		public IConnectorComponentT()
		{
			this.Disabled = false;
			this.LogicType = null;
			this.NullMask = 0;
		}
	}
}
