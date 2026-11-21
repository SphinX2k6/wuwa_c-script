using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A99 RID: 23193
	public class ILookAtTargetBase_UnionUnion
	{
		// Token: 0x1700A904 RID: 43268
		// (get) Token: 0x06026041 RID: 155713 RVA: 0x00535DD1 File Offset: 0x00533FD1
		// (set) Token: 0x06026042 RID: 155714 RVA: 0x00535DD9 File Offset: 0x00533FD9
		public ILookAtTargetBase_Union Type { get; set; }

		// Token: 0x1700A905 RID: 43269
		// (get) Token: 0x06026043 RID: 155715 RVA: 0x00535DE2 File Offset: 0x00533FE2
		// (set) Token: 0x06026044 RID: 155716 RVA: 0x00535DEA File Offset: 0x00533FEA
		public object Value { get; set; }

		// Token: 0x06026045 RID: 155717 RVA: 0x00535DF3 File Offset: 0x00533FF3
		public ILookAtTargetBase_UnionUnion()
		{
			this.Type = ILookAtTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026046 RID: 155718 RVA: 0x00535E09 File Offset: 0x00534009
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026047 RID: 155719 RVA: 0x00535E1B File Offset: 0x0053401B
		public ILookAtTargetBaseT AsILookAtTargetBase()
		{
			return this.As<ILookAtTargetBaseT>();
		}

		// Token: 0x06026048 RID: 155720 RVA: 0x00535E23 File Offset: 0x00534023
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetBase(ILookAtTargetBaseT _ilookattargetbase)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetBase,
				Value = _ilookattargetbase
			};
		}

		// Token: 0x06026049 RID: 155721 RVA: 0x00535E38 File Offset: 0x00534038
		public ILookAtTargetEntityT AsILookAtTargetEntity()
		{
			return this.As<ILookAtTargetEntityT>();
		}

		// Token: 0x0602604A RID: 155722 RVA: 0x00535E40 File Offset: 0x00534040
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetEntity(ILookAtTargetEntityT _ilookattargetentity)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetEntity,
				Value = _ilookattargetentity
			};
		}

		// Token: 0x0602604B RID: 155723 RVA: 0x00535E55 File Offset: 0x00534055
		public ILookAtTargetPlayerT AsILookAtTargetPlayer()
		{
			return this.As<ILookAtTargetPlayerT>();
		}

		// Token: 0x0602604C RID: 155724 RVA: 0x00535E5D File Offset: 0x0053405D
		public static ILookAtTargetBase_UnionUnion FromILookAtTargetPlayer(ILookAtTargetPlayerT _ilookattargetplayer)
		{
			return new ILookAtTargetBase_UnionUnion
			{
				Type = ILookAtTargetBase_Union.ILookAtTargetPlayer,
				Value = _ilookattargetplayer
			};
		}

		// Token: 0x0602604D RID: 155725 RVA: 0x00535E74 File Offset: 0x00534074
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
