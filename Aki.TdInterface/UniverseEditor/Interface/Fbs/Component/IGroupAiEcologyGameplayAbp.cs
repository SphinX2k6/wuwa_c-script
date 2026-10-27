using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005333 RID: 21299
	public struct IGroupAiEcologyGameplayAbp : IFlatbufferObject
	{
		// Token: 0x17009C7A RID: 40058
		// (get) Token: 0x06022D43 RID: 142659 RVA: 0x004D377A File Offset: 0x004D197A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D44 RID: 142660 RVA: 0x004D3787 File Offset: 0x004D1987
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06022D45 RID: 142661 RVA: 0x004D3796 File Offset: 0x004D1996
		public IGroupAiEcologyGameplayAbp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C7B RID: 40059
		// (get) Token: 0x06022D46 RID: 142662 RVA: 0x004D37A6 File Offset: 0x004D19A6
		public EGroupAiEcologyGameplayType GameplayType
		{
			get
			{
				return (EGroupAiEcologyGameplayType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x06022D47 RID: 142663 RVA: 0x004D37C3 File Offset: 0x004D19C3
		public static Offset<IGroupAiEcologyGameplayAbp> CreateIGroupAiEcologyGameplayAbp(FlatBufferBuilder builder, EGroupAiEcologyGameplayType GameplayType)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)GameplayType);
			return new Offset<IGroupAiEcologyGameplayAbp>(builder.Offset);
		}

		// Token: 0x06022D48 RID: 142664 RVA: 0x004D37E0 File Offset: 0x004D19E0
		public IGroupAiEcologyGameplayAbpT UnPack()
		{
			IGroupAiEcologyGameplayAbpT groupAiEcologyGameplayAbpT = new IGroupAiEcologyGameplayAbpT();
			this.UnPackTo(groupAiEcologyGameplayAbpT);
			return groupAiEcologyGameplayAbpT;
		}

		// Token: 0x06022D49 RID: 142665 RVA: 0x004D37FB File Offset: 0x004D19FB
		public void UnPackTo(IGroupAiEcologyGameplayAbpT _o)
		{
			_o.GameplayType = this.GameplayType;
		}

		// Token: 0x06022D4A RID: 142666 RVA: 0x004D380C File Offset: 0x004D1A0C
		public static Offset<IGroupAiEcologyGameplayAbp> Pack(FlatBufferBuilder builder, IGroupAiEcologyGameplayAbpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiEcologyGameplayAbp>);
			}
			return IGroupAiEcologyGameplayAbp.CreateIGroupAiEcologyGameplayAbp(builder, _o.GameplayType);
		}

		// Token: 0x0400E4FA RID: 58618
		private Struct __p;
	}
}
