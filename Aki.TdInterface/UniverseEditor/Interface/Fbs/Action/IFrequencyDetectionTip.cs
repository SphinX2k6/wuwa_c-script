using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFF RID: 28415
	public struct IFrequencyDetectionTip : IFlatbufferObject
	{
		// Token: 0x1700D064 RID: 53348
		// (get) Token: 0x060312B9 RID: 201401 RVA: 0x006AA10A File Offset: 0x006A830A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312BA RID: 201402 RVA: 0x006AA117 File Offset: 0x006A8317
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312BB RID: 201403 RVA: 0x006AA120 File Offset: 0x006A8320
		public static IFrequencyDetectionTip GetRootAsIFrequencyDetectionTip(ByteBuffer _bb)
		{
			return IFrequencyDetectionTip.GetRootAsIFrequencyDetectionTip(_bb, default(IFrequencyDetectionTip));
		}

		// Token: 0x060312BC RID: 201404 RVA: 0x006AA13C File Offset: 0x006A833C
		public static IFrequencyDetectionTip GetRootAsIFrequencyDetectionTip(ByteBuffer _bb, IFrequencyDetectionTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312BD RID: 201405 RVA: 0x006AA159 File Offset: 0x006A8359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312BE RID: 201406 RVA: 0x006AA168 File Offset: 0x006A8368
		public IFrequencyDetectionTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D065 RID: 53349
		// (get) Token: 0x060312BF RID: 201407 RVA: 0x006AA178 File Offset: 0x006A8378
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D066 RID: 53350
		// (get) Token: 0x060312C0 RID: 201408 RVA: 0x006AA1B4 File Offset: 0x006A83B4
		public ICommonTalkMessage? Content
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICommonTalkMessage?(default(ICommonTalkMessage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060312C1 RID: 201409 RVA: 0x006AA211 File Offset: 0x006A8411
		public static Offset<IFrequencyDetectionTip> CreateIFrequencyDetectionTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, Offset<ICommonTalkMessage> ContentOffset = default(Offset<ICommonTalkMessage>))
		{
			builder.StartTable(2);
			IFrequencyDetectionTip.AddContent(builder, ContentOffset);
			IFrequencyDetectionTip.AddType(builder, Type);
			return IFrequencyDetectionTip.EndIFrequencyDetectionTip(builder);
		}

		// Token: 0x060312C2 RID: 201410 RVA: 0x006AA22E File Offset: 0x006A842E
		public static void StartIFrequencyDetectionTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060312C3 RID: 201411 RVA: 0x006AA237 File Offset: 0x006A8437
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312C4 RID: 201412 RVA: 0x006AA242 File Offset: 0x006A8442
		public static void AddContent(FlatBufferBuilder builder, Offset<ICommonTalkMessage> contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x060312C5 RID: 201413 RVA: 0x006AA252 File Offset: 0x006A8452
		public static Offset<IFrequencyDetectionTip> EndIFrequencyDetectionTip(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectionTip>(builder.EndTable());
		}

		// Token: 0x060312C6 RID: 201414 RVA: 0x006AA260 File Offset: 0x006A8460
		public IFrequencyDetectionTipT UnPack()
		{
			IFrequencyDetectionTipT frequencyDetectionTipT = new IFrequencyDetectionTipT();
			this.UnPackTo(frequencyDetectionTipT);
			return frequencyDetectionTipT;
		}

		// Token: 0x060312C7 RID: 201415 RVA: 0x006AA27C File Offset: 0x006A847C
		public void UnPackTo(IFrequencyDetectionTipT _o)
		{
			_o.Type = this.Type;
			_o.Content = ((this.Content != null) ? this.Content.Value.UnPack() : null);
		}

		// Token: 0x060312C8 RID: 201416 RVA: 0x006AA2C4 File Offset: 0x006A84C4
		public static Offset<IFrequencyDetectionTip> Pack(FlatBufferBuilder builder, IFrequencyDetectionTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectionTip>);
			}
			Offset<ICommonTalkMessage> contentOffset = (_o.Content == null) ? default(Offset<ICommonTalkMessage>) : ICommonTalkMessage.Pack(builder, _o.Content);
			return IFrequencyDetectionTip.CreateIFrequencyDetectionTip(builder, _o.Type, contentOffset);
		}

		// Token: 0x04011E06 RID: 73222
		private Table __p;
	}
}
