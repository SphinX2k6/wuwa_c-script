using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E5D RID: 20061
	public class IAddBuffMode_UnionUnion
	{
		// Token: 0x17008F90 RID: 36752
		// (get) Token: 0x0601F7E0 RID: 128992 RVA: 0x00462FB5 File Offset: 0x004611B5
		// (set) Token: 0x0601F7E1 RID: 128993 RVA: 0x00462FBD File Offset: 0x004611BD
		public IAddBuffMode_Union Type { get; set; }

		// Token: 0x17008F91 RID: 36753
		// (get) Token: 0x0601F7E2 RID: 128994 RVA: 0x00462FC6 File Offset: 0x004611C6
		// (set) Token: 0x0601F7E3 RID: 128995 RVA: 0x00462FCE File Offset: 0x004611CE
		public object Value { get; set; }

		// Token: 0x0601F7E4 RID: 128996 RVA: 0x00462FD7 File Offset: 0x004611D7
		public IAddBuffMode_UnionUnion()
		{
			this.Type = IAddBuffMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F7E5 RID: 128997 RVA: 0x00462FED File Offset: 0x004611ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F7E6 RID: 128998 RVA: 0x00462FFF File Offset: 0x004611FF
		public IAddBuffModeT AsIAddBuffMode()
		{
			return this.As<IAddBuffModeT>();
		}

		// Token: 0x0601F7E7 RID: 128999 RVA: 0x00463007 File Offset: 0x00461207
		public static IAddBuffMode_UnionUnion FromIAddBuffMode(IAddBuffModeT _iaddbuffmode)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IAddBuffMode,
				Value = _iaddbuffmode
			};
		}

		// Token: 0x0601F7E8 RID: 129000 RVA: 0x0046301C File Offset: 0x0046121C
		public IImmediateAddBuffT AsIImmediateAddBuff()
		{
			return this.As<IImmediateAddBuffT>();
		}

		// Token: 0x0601F7E9 RID: 129001 RVA: 0x00463024 File Offset: 0x00461224
		public static IAddBuffMode_UnionUnion FromIImmediateAddBuff(IImmediateAddBuffT _iimmediateaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IImmediateAddBuff,
				Value = _iimmediateaddbuff
			};
		}

		// Token: 0x0601F7EA RID: 129002 RVA: 0x00463039 File Offset: 0x00461239
		public IAdsorbAddBuffT AsIAdsorbAddBuff()
		{
			return this.As<IAdsorbAddBuffT>();
		}

		// Token: 0x0601F7EB RID: 129003 RVA: 0x00463041 File Offset: 0x00461241
		public static IAddBuffMode_UnionUnion FromIAdsorbAddBuff(IAdsorbAddBuffT _iadsorbaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IAdsorbAddBuff,
				Value = _iadsorbaddbuff
			};
		}

		// Token: 0x0601F7EC RID: 129004 RVA: 0x00463056 File Offset: 0x00461256
		public IFireBulletAddBuffT AsIFireBulletAddBuff()
		{
			return this.As<IFireBulletAddBuffT>();
		}

		// Token: 0x0601F7ED RID: 129005 RVA: 0x0046305E File Offset: 0x0046125E
		public static IAddBuffMode_UnionUnion FromIFireBulletAddBuff(IFireBulletAddBuffT _ifirebulletaddbuff)
		{
			return new IAddBuffMode_UnionUnion
			{
				Type = IAddBuffMode_Union.IFireBulletAddBuff,
				Value = _ifirebulletaddbuff
			};
		}

		// Token: 0x0601F7EE RID: 129006 RVA: 0x00463074 File Offset: 0x00461274
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
