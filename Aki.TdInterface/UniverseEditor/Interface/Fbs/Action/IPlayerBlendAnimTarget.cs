using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007468 RID: 29800
	public struct IPlayerBlendAnimTarget : IFlatbufferObject
	{
		// Token: 0x1700DAF5 RID: 56053
		// (get) Token: 0x060342AF RID: 213679 RVA: 0x0070741C File Offset: 0x0070561C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060342B0 RID: 213680 RVA: 0x00707429 File Offset: 0x00705629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060342B1 RID: 213681 RVA: 0x00707430 File Offset: 0x00705630
		public static IPlayerBlendAnimTarget GetRootAsIPlayerBlendAnimTarget(ByteBuffer _bb)
		{
			return IPlayerBlendAnimTarget.GetRootAsIPlayerBlendAnimTarget(_bb, default(IPlayerBlendAnimTarget));
		}

		// Token: 0x060342B2 RID: 213682 RVA: 0x0070744C File Offset: 0x0070564C
		public static IPlayerBlendAnimTarget GetRootAsIPlayerBlendAnimTarget(ByteBuffer _bb, IPlayerBlendAnimTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060342B3 RID: 213683 RVA: 0x00707469 File Offset: 0x00705669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060342B4 RID: 213684 RVA: 0x00707478 File Offset: 0x00705678
		public IPlayerBlendAnimTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAF6 RID: 56054
		// (get) Token: 0x060342B5 RID: 213685 RVA: 0x00707488 File Offset: 0x00705688
		public EBlendAnimTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimTarget.Player;
				}
				return (EBlendAnimTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060342B6 RID: 213686 RVA: 0x007074C4 File Offset: 0x007056C4
		public static Offset<IPlayerBlendAnimTarget> CreateIPlayerBlendAnimTarget(FlatBufferBuilder builder, EBlendAnimTarget Type = EBlendAnimTarget.Player)
		{
			builder.StartTable(1);
			IPlayerBlendAnimTarget.AddType(builder, Type);
			return IPlayerBlendAnimTarget.EndIPlayerBlendAnimTarget(builder);
		}

		// Token: 0x060342B7 RID: 213687 RVA: 0x007074DA File Offset: 0x007056DA
		public static void StartIPlayerBlendAnimTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060342B8 RID: 213688 RVA: 0x007074E3 File Offset: 0x007056E3
		public static void AddType(FlatBufferBuilder builder, EBlendAnimTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060342B9 RID: 213689 RVA: 0x007074EE File Offset: 0x007056EE
		public static Offset<IPlayerBlendAnimTarget> EndIPlayerBlendAnimTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerBlendAnimTarget>(builder.EndTable());
		}

		// Token: 0x060342BA RID: 213690 RVA: 0x007074FC File Offset: 0x007056FC
		public IPlayerBlendAnimTargetT UnPack()
		{
			IPlayerBlendAnimTargetT playerBlendAnimTargetT = new IPlayerBlendAnimTargetT();
			this.UnPackTo(playerBlendAnimTargetT);
			return playerBlendAnimTargetT;
		}

		// Token: 0x060342BB RID: 213691 RVA: 0x00707517 File Offset: 0x00705717
		public void UnPackTo(IPlayerBlendAnimTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060342BC RID: 213692 RVA: 0x00707528 File Offset: 0x00705728
		public static Offset<IPlayerBlendAnimTarget> Pack(FlatBufferBuilder builder, IPlayerBlendAnimTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerBlendAnimTarget>);
			}
			return IPlayerBlendAnimTarget.CreateIPlayerBlendAnimTarget(builder, _o.Type);
		}

		// Token: 0x040125E5 RID: 75237
		private Table __p;
	}
}
