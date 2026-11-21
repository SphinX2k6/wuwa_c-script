using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004083 RID: 16515
	public class ITurntableConnectorTipsActorT
	{
		// Token: 0x1700706F RID: 28783
		// (get) Token: 0x06016BD9 RID: 93145 RVA: 0x0033FA53 File Offset: 0x0033DC53
		// (set) Token: 0x06016BDA RID: 93146 RVA: 0x0033FA5B File Offset: 0x0033DC5B
		public ETipsActorType Type { get; set; }

		// Token: 0x17007070 RID: 28784
		// (get) Token: 0x06016BDB RID: 93147 RVA: 0x0033FA64 File Offset: 0x0033DC64
		// (set) Token: 0x06016BDC RID: 93148 RVA: 0x0033FA6C File Offset: 0x0033DC6C
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17007071 RID: 28785
		// (get) Token: 0x06016BDD RID: 93149 RVA: 0x0033FA75 File Offset: 0x0033DC75
		// (set) Token: 0x06016BDE RID: 93150 RVA: 0x0033FA7D File Offset: 0x0033DC7D
		public string MeshPath { get; set; }

		// Token: 0x17007072 RID: 28786
		// (get) Token: 0x06016BDF RID: 93151 RVA: 0x0033FA86 File Offset: 0x0033DC86
		// (set) Token: 0x06016BE0 RID: 93152 RVA: 0x0033FA8E File Offset: 0x0033DC8E
		public byte NullMask { get; set; }

		// Token: 0x06016BE1 RID: 93153 RVA: 0x0033FA97 File Offset: 0x0033DC97
		public ITurntableConnectorTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.MeshPath = null;
			this.NullMask = 0;
		}
	}
}
