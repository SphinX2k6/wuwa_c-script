using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536E RID: 21358
	public class IAddBuffMode_UnionUnion
	{
		// Token: 0x170096C9 RID: 38601
		// (get) Token: 0x0602142B RID: 136235 RVA: 0x00496FCD File Offset: 0x004951CD
		// (set) Token: 0x0602142C RID: 136236 RVA: 0x00496FD5 File Offset: 0x004951D5
		public IAddBuffMode_Union Type { get; set; }

		// Token: 0x170096CA RID: 38602
		// (get) Token: 0x0602142D RID: 136237 RVA: 0x00496FDE File Offset: 0x004951DE
		// (set) Token: 0x0602142E RID: 136238 RVA: 0x00496FE6 File Offset: 0x004951E6
		public object Value { get; set; }

		// Token: 0x0602142F RID: 136239 RVA: 0x00496FEF File Offset: 0x004951EF
		public IAddBuffMode_UnionUnion()
		{
			this.Type = IAddBuffMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021430 RID: 136240 RVA: 0x00497005 File Offset: 0x00495205
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021431 RID: 136241 RVA: 0x00497017 File Offset: 0x00495217
		public IAddBuffModeT AsIAddBuffMode()
		{
			return this.As<IAddBuffModeT>();
		}

		// Token: 0x06021432 RID: 136242 RVA: 0x0049701F File Offset: 0x0049521F
		public static IAddBuffMode_UnionUnion FromIAddBuffMode(IAddBuffModeT _iaddbuffmode)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IAddBuffMode,
				Value = _iaddbuffmode
			};
		}

		// Token: 0x06021433 RID: 136243 RVA: 0x00497034 File Offset: 0x00495234
		public IImmediateAddBuffT AsIImmediateAddBuff()
		{
			return this.As<IImmediateAddBuffT>();
		}

		// Token: 0x06021434 RID: 136244 RVA: 0x0049703C File Offset: 0x0049523C
		public static IAddBuffMode_UnionUnion FromIImmediateAddBuff(IImmediateAddBuffT _iimmediateaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IImmediateAddBuff,
				Value = _iimmediateaddbuff
			};
		}

		// Token: 0x06021435 RID: 136245 RVA: 0x00497051 File Offset: 0x00495251
		public IAdsorbAddBuffT AsIAdsorbAddBuff()
		{
			return this.As<IAdsorbAddBuffT>();
		}

		// Token: 0x06021436 RID: 136246 RVA: 0x00497059 File Offset: 0x00495259
		public static IAddBuffMode_UnionUnion FromIAdsorbAddBuff(IAdsorbAddBuffT _iadsorbaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IAdsorbAddBuff,
				Value = _iadsorbaddbuff
			};
		}

		// Token: 0x06021437 RID: 136247 RVA: 0x0049706E File Offset: 0x0049526E
		public IFireBulletAddBuffT AsIFireBulletAddBuff()
		{
			return this.As<IFireBulletAddBuffT>();
		}

		// Token: 0x06021438 RID: 136248 RVA: 0x00497076 File Offset: 0x00495276
		public static IAddBuffMode_UnionUnion FromIFireBulletAddBuff(IFireBulletAddBuffT _ifirebulletaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IFireBulletAddBuff,
				Value = _ifirebulletaddbuff
			};
		}

		// Token: 0x06021439 RID: 136249 RVA: 0x0049708C File Offset: 0x0049528C
		public static int Pack(FlatBufferBuilder builder, IAddBuffMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAddBuffMode_Union.IAddBuffMode:
				return IAddBuffMode.Pack(builder, _o.AsIAddBuffMode()).Value;
			case IAddBuffMode_Union.IImmediateAddBuff:
				return IImmediateAddBuff.Pack(builder, _o.AsIImmediateAddBuff()).Value;
			case IAddBuffMode_Union.IAdsorbAddBuff:
				return IAdsorbAddBuff.Pack(builder, _o.AsIAdsorbAddBuff()).Value;
			case IAddBuffMode_Union.IFireBulletAddBuff:
				return IFireBulletAddBuff.Pack(builder, _o.AsIFireBulletAddBuff()).Value;
			default:
				return 0;
			}
		}
	}
}
