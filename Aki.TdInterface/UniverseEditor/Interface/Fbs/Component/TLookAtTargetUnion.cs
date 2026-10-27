using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C58 RID: 23640
	public class TLookAtTargetUnion
	{
		// Token: 0x1700B218 RID: 45592
		// (get) Token: 0x06028851 RID: 165969 RVA: 0x00592BFA File Offset: 0x00590DFA
		// (set) Token: 0x06028852 RID: 165970 RVA: 0x00592C02 File Offset: 0x00590E02
		public TLookAtTarget Type { get; set; }

		// Token: 0x1700B219 RID: 45593
		// (get) Token: 0x06028853 RID: 165971 RVA: 0x00592C0B File Offset: 0x00590E0B
		// (set) Token: 0x06028854 RID: 165972 RVA: 0x00592C13 File Offset: 0x00590E13
		public object Value { get; set; }

		// Token: 0x06028855 RID: 165973 RVA: 0x00592C1C File Offset: 0x00590E1C
		public TLookAtTargetUnion()
		{
			this.Type = TLookAtTarget.NONE;
			this.Value = null;
		}

		// Token: 0x06028856 RID: 165974 RVA: 0x00592C32 File Offset: 0x00590E32
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028857 RID: 165975 RVA: 0x00592C44 File Offset: 0x00590E44
		public ILookAtTargetEntityT AsILookAtTargetEntity()
		{
			return this.As<ILookAtTargetEntityT>();
		}

		// Token: 0x06028858 RID: 165976 RVA: 0x00592C4C File Offset: 0x00590E4C
		public static TLookAtTargetUnion FromILookAtTargetEntity(ILookAtTargetEntityT _ilookattargetentity)
		{
			return new TLookAtTargetUnion
			{
				Type = TLookAtTarget.ILookAtTargetEntity,
				Value = _ilookattargetentity
			};
		}

		// Token: 0x06028859 RID: 165977 RVA: 0x00592C61 File Offset: 0x00590E61
		public ILookAtTargetPlayerT AsILookAtTargetPlayer()
		{
			return this.As<ILookAtTargetPlayerT>();
		}

		// Token: 0x0602885A RID: 165978 RVA: 0x00592C69 File Offset: 0x00590E69
		public static TLookAtTargetUnion FromILookAtTargetPlayer(ILookAtTargetPlayerT _ilookattargetplayer)
		{
			return new TLookAtTargetUnion
			{
				Type = TLookAtTarget.ILookAtTargetPlayer,
				Value = _ilookattargetplayer
			};
		}

		// Token: 0x0602885B RID: 165979 RVA: 0x00592C80 File Offset: 0x00590E80
		public static int Pack(FlatBufferBuilder builder, TLookAtTargetUnion _o)
		{
			TLookAtTarget type = _o.Type;
			if (type == TLookAtTarget.ILookAtTargetEntity)
			{
				return ILookAtTargetEntity.Pack(builder, _o.AsILookAtTargetEntity()).Value;
			}
			if (type != TLookAtTarget.ILookAtTargetPlayer)
			{
				return 0;
			}
			return ILookAtTargetPlayer.Pack(builder, _o.AsILookAtTargetPlayer()).Value;
		}
	}
}
