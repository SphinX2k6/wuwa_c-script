using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006069 RID: 24681
	public class IAccelerateSkiConfigT
	{
		// Token: 0x1700B5DF RID: 46559
		// (get) Token: 0x06029CAF RID: 171183 RVA: 0x005BC1D5 File Offset: 0x005BA3D5
		// (set) Token: 0x06029CB0 RID: 171184 RVA: 0x005BC1DD File Offset: 0x005BA3DD
		public ESkiConfig Type { get; set; }

		// Token: 0x1700B5E0 RID: 46560
		// (get) Token: 0x06029CB1 RID: 171185 RVA: 0x005BC1E6 File Offset: 0x005BA3E6
		// (set) Token: 0x06029CB2 RID: 171186 RVA: 0x005BC1EE File Offset: 0x005BA3EE
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700B5E1 RID: 46561
		// (get) Token: 0x06029CB3 RID: 171187 RVA: 0x005BC1F7 File Offset: 0x005BA3F7
		// (set) Token: 0x06029CB4 RID: 171188 RVA: 0x005BC1FF File Offset: 0x005BA3FF
		public int Duration { get; set; }

		// Token: 0x1700B5E2 RID: 46562
		// (get) Token: 0x06029CB5 RID: 171189 RVA: 0x005BC208 File Offset: 0x005BA408
		// (set) Token: 0x06029CB6 RID: 171190 RVA: 0x005BC210 File Offset: 0x005BA410
		public int LimitSpeed { get; set; }

		// Token: 0x1700B5E3 RID: 46563
		// (get) Token: 0x06029CB7 RID: 171191 RVA: 0x005BC219 File Offset: 0x005BA419
		// (set) Token: 0x06029CB8 RID: 171192 RVA: 0x005BC221 File Offset: 0x005BA421
		public int Acceleration { get; set; }

		// Token: 0x1700B5E4 RID: 46564
		// (get) Token: 0x06029CB9 RID: 171193 RVA: 0x005BC22A File Offset: 0x005BA42A
		// (set) Token: 0x06029CBA RID: 171194 RVA: 0x005BC232 File Offset: 0x005BA432
		public int InstantSpeed { get; set; }

		// Token: 0x1700B5E5 RID: 46565
		// (get) Token: 0x06029CBB RID: 171195 RVA: 0x005BC23B File Offset: 0x005BA43B
		// (set) Token: 0x06029CBC RID: 171196 RVA: 0x005BC243 File Offset: 0x005BA443
		public byte NullMask { get; set; }

		// Token: 0x06029CBD RID: 171197 RVA: 0x005BC24C File Offset: 0x005BA44C
		public IAccelerateSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
			this.Duration = 0;
			this.LimitSpeed = 0;
			this.Acceleration = 0;
			this.InstantSpeed = 0;
			this.NullMask = 0;
		}
	}
}
