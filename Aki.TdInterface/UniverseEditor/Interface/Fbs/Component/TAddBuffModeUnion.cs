using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE0 RID: 23520
	public class TAddBuffModeUnion
	{
		// Token: 0x1700B1BF RID: 45503
		// (get) Token: 0x060284F7 RID: 165111 RVA: 0x00589EFE File Offset: 0x005880FE
		// (set) Token: 0x060284F8 RID: 165112 RVA: 0x00589F06 File Offset: 0x00588106
		public TAddBuffMode Type { get; set; }

		// Token: 0x1700B1C0 RID: 45504
		// (get) Token: 0x060284F9 RID: 165113 RVA: 0x00589F0F File Offset: 0x0058810F
		// (set) Token: 0x060284FA RID: 165114 RVA: 0x00589F17 File Offset: 0x00588117
		public object Value { get; set; }

		// Token: 0x060284FB RID: 165115 RVA: 0x00589F20 File Offset: 0x00588120
		public TAddBuffModeUnion()
		{
			this.Type = TAddBuffMode.NONE;
			this.Value = null;
		}

		// Token: 0x060284FC RID: 165116 RVA: 0x00589F36 File Offset: 0x00588136
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060284FD RID: 165117 RVA: 0x00589F48 File Offset: 0x00588148
		public IAdsorbAddBuffT AsIAdsorbAddBuff()
		{
			return this.As<IAdsorbAddBuffT>();
		}

		// Token: 0x060284FE RID: 165118 RVA: 0x00589F50 File Offset: 0x00588150
		public static TAddBuffModeUnion FromIAdsorbAddBuff(IAdsorbAddBuffT _iadsorbaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IAdsorbAddBuff,
				Value = _iadsorbaddbuff
			};
		}

		// Token: 0x060284FF RID: 165119 RVA: 0x00589F65 File Offset: 0x00588165
		public IFireBulletAddBuffT AsIFireBulletAddBuff()
		{
			return this.As<IFireBulletAddBuffT>();
		}

		// Token: 0x06028500 RID: 165120 RVA: 0x00589F6D File Offset: 0x0058816D
		public static TAddBuffModeUnion FromIFireBulletAddBuff(IFireBulletAddBuffT _ifirebulletaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IFireBulletAddBuff,
				Value = _ifirebulletaddbuff
			};
		}

		// Token: 0x06028501 RID: 165121 RVA: 0x00589F82 File Offset: 0x00588182
		public IImmediateAddBuffT AsIImmediateAddBuff()
		{
			return this.As<IImmediateAddBuffT>();
		}

		// Token: 0x06028502 RID: 165122 RVA: 0x00589F8A File Offset: 0x0058818A
		public static TAddBuffModeUnion FromIImmediateAddBuff(IImmediateAddBuffT _iimmediateaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IImmediateAddBuff,
				Value = _iimmediateaddbuff
			};
		}

		// Token: 0x06028503 RID: 165123 RVA: 0x00589FA0 File Offset: 0x005881A0
		public static int Pack(FlatBufferBuilder builder, TAddBuffModeUnion _o)
		{
			switch (_o.Type)
			{
			case TAddBuffMode.IAdsorbAddBuff:
				return IAdsorbAddBuff.Pack(builder, _o.AsIAdsorbAddBuff()).Value;
			case TAddBuffMode.IFireBulletAddBuff:
				return IFireBulletAddBuff.Pack(builder, _o.AsIFireBulletAddBuff()).Value;
			case TAddBuffMode.IImmediateAddBuff:
				return IImmediateAddBuff.Pack(builder, _o.AsIImmediateAddBuff()).Value;
			default:
				return 0;
			}
		}
	}
}
