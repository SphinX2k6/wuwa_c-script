using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005513 RID: 21779
	public class ILookAtTargetBase_UnionUnion
	{
		// Token: 0x1700A0CA RID: 41162
		// (get) Token: 0x06023F87 RID: 147335 RVA: 0x004F8CAD File Offset: 0x004F6EAD
		// (set) Token: 0x06023F88 RID: 147336 RVA: 0x004F8CB5 File Offset: 0x004F6EB5
		public ILookAtTargetBase_Union Type { get; set; }

		// Token: 0x1700A0CB RID: 41163
		// (get) Token: 0x06023F89 RID: 147337 RVA: 0x004F8CBE File Offset: 0x004F6EBE
		// (set) Token: 0x06023F8A RID: 147338 RVA: 0x004F8CC6 File Offset: 0x004F6EC6
		public object Value { get; set; }

		// Token: 0x06023F8B RID: 147339 RVA: 0x004F8CCF File Offset: 0x004F6ECF
		public ILookAtTargetBase_UnionUnion()
		{
			this.Type = ILookAtTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023F8C RID: 147340 RVA: 0x004F8CE5 File Offset: 0x004F6EE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023F8D RID: 147341 RVA: 0x004F8CF7 File Offset: 0x004F6EF7
		public ILookAtTargetBaseT AsILookAtTargetBase()
		{
			return this.As<ILookAtTargetBaseT>();
		}

		// Token: 0x06023F8E RID: 147342 RVA: 0x004F8CFF File Offset: 0x004F6EFF
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetBase(ILookAtTargetBaseT _ilookattargetbase)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetBase,
				Value = _ilookattargetbase
			};
		}

		// Token: 0x06023F8F RID: 147343 RVA: 0x004F8D14 File Offset: 0x004F6F14
		public ILookAtTargetEntityT AsILookAtTargetEntity()
		{
			return this.As<ILookAtTargetEntityT>();
		}

		// Token: 0x06023F90 RID: 147344 RVA: 0x004F8D1C File Offset: 0x004F6F1C
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetEntity(ILookAtTargetEntityT _ilookattargetentity)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetEntity,
				Value = _ilookattargetentity
			};
		}

		// Token: 0x06023F91 RID: 147345 RVA: 0x004F8D31 File Offset: 0x004F6F31
		public ILookAtTargetPlayerT AsILookAtTargetPlayer()
		{
			return this.As<ILookAtTargetPlayerT>();
		}

		// Token: 0x06023F92 RID: 147346 RVA: 0x004F8D39 File Offset: 0x004F6F39
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetPlayer(ILookAtTargetPlayerT _ilookattargetplayer)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetPlayer,
				Value = _ilookattargetplayer
			};
		}

		// Token: 0x06023F93 RID: 147347 RVA: 0x004F8D50 File Offset: 0x004F6F50
		public static int Pack(FlatBufferBuilder builder, ILookAtTargetBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILookAtTargetBase_Union.ILookAtTargetBase:
				return ILookAtTargetBase.Pack(builder, _o.AsILookAtTargetBase()).Value;
			case ILookAtTargetBase_Union.ILookAtTargetEntity:
				return ILookAtTargetEntity.Pack(builder, _o.AsILookAtTargetEntity()).Value;
			case ILookAtTargetBase_Union.ILookAtTargetPlayer:
				return ILookAtTargetPlayer.Pack(builder, _o.AsILookAtTargetPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
