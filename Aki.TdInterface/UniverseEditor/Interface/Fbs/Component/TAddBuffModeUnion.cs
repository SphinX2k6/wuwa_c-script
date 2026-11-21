using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F6 RID: 25078
	public class TAddBuffModeUnion
	{
		// Token: 0x1700BB07 RID: 47879
		// (get) Token: 0x0602AABB RID: 174779 RVA: 0x005D198E File Offset: 0x005CFB8E
		// (set) Token: 0x0602AABC RID: 174780 RVA: 0x005D1996 File Offset: 0x005CFB96
		public TAddBuffMode Type { get; set; }

		// Token: 0x1700BB08 RID: 47880
		// (get) Token: 0x0602AABD RID: 174781 RVA: 0x005D199F File Offset: 0x005CFB9F
		// (set) Token: 0x0602AABE RID: 174782 RVA: 0x005D19A7 File Offset: 0x005CFBA7
		public object Value { get; set; }

		// Token: 0x0602AABF RID: 174783 RVA: 0x005D19B0 File Offset: 0x005CFBB0
		public TAddBuffModeUnion()
		{
			this.Type = TAddBuffMode.NONE;
			this.Value = null;
		}

		// Token: 0x0602AAC0 RID: 174784 RVA: 0x005D19C6 File Offset: 0x005CFBC6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AAC1 RID: 174785 RVA: 0x005D19D8 File Offset: 0x005CFBD8
		public IAdsorbAddBuffT AsIAdsorbAddBuff()
		{
			return this.As<IAdsorbAddBuffT>();
		}

		// Token: 0x0602AAC2 RID: 174786 RVA: 0x005D19E0 File Offset: 0x005CFBE0
		public static TAddBuffModeUnion FromIAdsorbAddBuff(IAdsorbAddBuffT _iadsorbaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IAdsorbAddBuff,
				Value = _iadsorbaddbuff
			};
		}

		// Token: 0x0602AAC3 RID: 174787 RVA: 0x005D19F5 File Offset: 0x005CFBF5
		public IFireBulletAddBuffT AsIFireBulletAddBuff()
		{
			return this.As<IFireBulletAddBuffT>();
		}

		// Token: 0x0602AAC4 RID: 174788 RVA: 0x005D19FD File Offset: 0x005CFBFD
		public static TAddBuffModeUnion FromIFireBulletAddBuff(IFireBulletAddBuffT _ifirebulletaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IFireBulletAddBuff,
				Value = _ifirebulletaddbuff
			};
		}

		// Token: 0x0602AAC5 RID: 174789 RVA: 0x005D1A12 File Offset: 0x005CFC12
		public IImmediateAddBuffT AsIImmediateAddBuff()
		{
			return this.As<IImmediateAddBuffT>();
		}

		// Token: 0x0602AAC6 RID: 174790 RVA: 0x005D1A1A File Offset: 0x005CFC1A
		public static TAddBuffModeUnion FromIImmediateAddBuff(IImmediateAddBuffT _iimmediateaddbuff)
		{
			return new TAddBuffModeUnion
			{
				Type = TAddBuffMode.IImmediateAddBuff,
				Value = _iimmediateaddbuff
			};
		}

		// Token: 0x0602AAC7 RID: 174791 RVA: 0x005D1A30 File Offset: 0x005CFC30
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
