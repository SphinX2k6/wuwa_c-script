using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C32 RID: 31794
	public struct ITransitionPopupArtTextTypeBase : IFlatbufferObject
	{
		// Token: 0x1700EE10 RID: 60944
		// (get) Token: 0x060394EB RID: 234731 RVA: 0x007BD418 File Offset: 0x007BB618
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060394EC RID: 234732 RVA: 0x007BD425 File Offset: 0x007BB625
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060394ED RID: 234733 RVA: 0x007BD42C File Offset: 0x007BB62C
		public static ITransitionPopupArtTextTypeBase GetRootAsITransitionPopupArtTextTypeBase(ByteBuffer _bb)
		{
			return ITransitionPopupArtTextTypeBase.GetRootAsITransitionPopupArtTextTypeBase(_bb, default(ITransitionPopupArtTextTypeBase));
		}

		// Token: 0x060394EE RID: 234734 RVA: 0x007BD448 File Offset: 0x007BB648
		public static ITransitionPopupArtTextTypeBase GetRootAsITransitionPopupArtTextTypeBase(ByteBuffer _bb, ITransitionPopupArtTextTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060394EF RID: 234735 RVA: 0x007BD465 File Offset: 0x007BB665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060394F0 RID: 234736 RVA: 0x007BD474 File Offset: 0x007BB674
		public ITransitionPopupArtTextTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE11 RID: 60945
		// (get) Token: 0x060394F1 RID: 234737 RVA: 0x007BD484 File Offset: 0x007BB684
		public ETransitionPopupArtTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupArtTextType.YuanCheng;
				}
				return (ETransitionPopupArtTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060394F2 RID: 234738 RVA: 0x007BD4C0 File Offset: 0x007BB6C0
		public static Offset<ITransitionPopupArtTextTypeBase> CreateITransitionPopupArtTextTypeBase(FlatBufferBuilder builder, ETransitionPopupArtTextType Type = ETransitionPopupArtTextType.YuanCheng)
		{
			builder.StartTable(1);
			ITransitionPopupArtTextTypeBase.AddType(builder, Type);
			return ITransitionPopupArtTextTypeBase.EndITransitionPopupArtTextTypeBase(builder);
		}

		// Token: 0x060394F3 RID: 234739 RVA: 0x007BD4D6 File Offset: 0x007BB6D6
		public static void StartITransitionPopupArtTextTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060394F4 RID: 234740 RVA: 0x007BD4DF File Offset: 0x007BB6DF
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupArtTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060394F5 RID: 234741 RVA: 0x007BD4EA File Offset: 0x007BB6EA
		public static Offset<ITransitionPopupArtTextTypeBase> EndITransitionPopupArtTextTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupArtTextTypeBase>(builder.EndTable());
		}

		// Token: 0x060394F6 RID: 234742 RVA: 0x007BD4F8 File Offset: 0x007BB6F8
		public ITransitionPopupArtTextTypeBaseT UnPack()
		{
			ITransitionPopupArtTextTypeBaseT transitionPopupArtTextTypeBaseT = new ITransitionPopupArtTextTypeBaseT();
			this.UnPackTo(transitionPopupArtTextTypeBaseT);
			return transitionPopupArtTextTypeBaseT;
		}

		// Token: 0x060394F7 RID: 234743 RVA: 0x007BD513 File Offset: 0x007BB713
		public void UnPackTo(ITransitionPopupArtTextTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060394F8 RID: 234744 RVA: 0x007BD524 File Offset: 0x007BB724
		public static Offset<ITransitionPopupArtTextTypeBase> Pack(FlatBufferBuilder builder, ITransitionPopupArtTextTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupArtTextTypeBase>);
			}
			return ITransitionPopupArtTextTypeBase.CreateITransitionPopupArtTextTypeBase(builder, _o.Type);
		}

		// Token: 0x040132E5 RID: 78565
		private Table __p;
	}
}
