using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006854 RID: 26708
	public class IBasePos2_UnionUnion
	{
		// Token: 0x1700C45C RID: 50268
		// (get) Token: 0x0602DA68 RID: 186984 RVA: 0x0063EA7D File Offset: 0x0063CC7D
		// (set) Token: 0x0602DA69 RID: 186985 RVA: 0x0063EA85 File Offset: 0x0063CC85
		public IBasePos2_Union Type { get; set; }

		// Token: 0x1700C45D RID: 50269
		// (get) Token: 0x0602DA6A RID: 186986 RVA: 0x0063EA8E File Offset: 0x0063CC8E
		// (set) Token: 0x0602DA6B RID: 186987 RVA: 0x0063EA96 File Offset: 0x0063CC96
		public object Value { get; set; }

		// Token: 0x0602DA6C RID: 186988 RVA: 0x0063EA9F File Offset: 0x0063CC9F
		public IBasePos2_UnionUnion()
		{
			this.Type = IBasePos2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DA6D RID: 186989 RVA: 0x0063EAB5 File Offset: 0x0063CCB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DA6E RID: 186990 RVA: 0x0063EAC7 File Offset: 0x0063CCC7
		public IBasePos2T AsIBasePos2()
		{
			return this.As<IBasePos2T>();
		}

		// Token: 0x0602DA6F RID: 186991 RVA: 0x0063EACF File Offset: 0x0063CCCF
		public static IBasePos2_UnionUnion FromIBasePos2(IBasePos2T _ibasepos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IBasePos2,
				Value = _ibasepos2
			};
		}

		// Token: 0x0602DA70 RID: 186992 RVA: 0x0063EAE4 File Offset: 0x0063CCE4
		public IPlayerPos2T AsIPlayerPos2()
		{
			return this.As<IPlayerPos2T>();
		}

		// Token: 0x0602DA71 RID: 186993 RVA: 0x0063EAEC File Offset: 0x0063CCEC
		public static IBasePos2_UnionUnion FromIPlayerPos2(IPlayerPos2T _iplayerpos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IPlayerPos2,
				Value = _iplayerpos2
			};
		}

		// Token: 0x0602DA72 RID: 186994 RVA: 0x0063EB01 File Offset: 0x0063CD01
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x0602DA73 RID: 186995 RVA: 0x0063EB09 File Offset: 0x0063CD09
		public static IBasePos2_UnionUnion FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x0602DA74 RID: 186996 RVA: 0x0063EB1E File Offset: 0x0063CD1E
		public IEntityPos2T AsIEntityPos2()
		{
			return this.As<IEntityPos2T>();
		}

		// Token: 0x0602DA75 RID: 186997 RVA: 0x0063EB26 File Offset: 0x0063CD26
		public static IBasePos2_UnionUnion FromIEntityPos2(IEntityPos2T _ientitypos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEntityPos2,
				Value = _ientitypos2
			};
		}

		// Token: 0x0602DA76 RID: 186998 RVA: 0x0063EB3B File Offset: 0x0063CD3B
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x0602DA77 RID: 186999 RVA: 0x0063EB43 File Offset: 0x0063CD43
		public static IBasePos2_UnionUnion FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x0602DA78 RID: 187000 RVA: 0x0063EB58 File Offset: 0x0063CD58
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x0602DA79 RID: 187001 RVA: 0x0063EB60 File Offset: 0x0063CD60
		public static IBasePos2_UnionUnion FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new IBasePos2_UnionUnion
			{
				Type = IBasePos2_Union.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x0602DA7A RID: 187002 RVA: 0x0063EB78 File Offset: 0x0063CD78
		public static int Pack(FlatBufferBuilder builder, IBasePos2_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBasePos2_Union.IBasePos2:
				return IBasePos2.Pack(builder, _o.AsIBasePos2()).Value;
			case IBasePos2_Union.IPlayerPos2:
				return IPlayerPos2.Pack(builder, _o.AsIPlayerPos2()).Value;
			case IBasePos2_Union.IEffectPlayerPos2:
				return IEffectPlayerPos2.Pack(builder, _o.AsIEffectPlayerPos2()).Value;
			case IBasePos2_Union.IEntityPos2:
				return IEntityPos2.Pack(builder, _o.AsIEntityPos2()).Value;
			case IBasePos2_Union.IEffectEntityPos2:
				return IEffectEntityPos2.Pack(builder, _o.AsIEffectEntityPos2()).Value;
			case IBasePos2_Union.IAbsolutePos2:
				return IAbsolutePos2.Pack(builder, _o.AsIAbsolutePos2()).Value;
			default:
				return 0;
			}
		}
	}
}
