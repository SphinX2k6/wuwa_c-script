using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B9 RID: 22713
	public struct IGroupAiEcologyGameplayAbp : IFlatbufferObject
	{
		// Token: 0x1700A4B2 RID: 42162
		// (get) Token: 0x06024DF7 RID: 151031 RVA: 0x0051064E File Offset: 0x0050E84E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024DF8 RID: 151032 RVA: 0x0051065B File Offset: 0x0050E85B
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06024DF9 RID: 151033 RVA: 0x0051066A File Offset: 0x0050E86A
		public IGroupAiEcologyGameplayAbp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4B3 RID: 42163
		// (get) Token: 0x06024DFA RID: 151034 RVA: 0x0051067A File Offset: 0x0050E87A
		public EGroupAiEcologyGameplayType GameplayType
		{
			get
			{
				return (EGroupAiEcologyGameplayType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x06024DFB RID: 151035 RVA: 0x00510697 File Offset: 0x0050E897
		public static Offset<IGroupAiEcologyGameplayAbp> CreateIGroupAiEcologyGameplayAbp(FlatBufferBuilder builder, EGroupAiEcologyGameplayType GameplayType)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)GameplayType);
			return new Offset<IGroupAiEcologyGameplayAbp>(builder.Offset);
		}

		// Token: 0x06024DFC RID: 151036 RVA: 0x005106B4 File Offset: 0x0050E8B4
		public IGroupAiEcologyGameplayAbpT UnPack()
		{
			IGroupAiEcologyGameplayAbpT groupAiEcologyGameplayAbpT = new IGroupAiEcologyGameplayAbpT();
			this.UnPackTo(groupAiEcologyGameplayAbpT);
			return groupAiEcologyGameplayAbpT;
		}

		// Token: 0x06024DFD RID: 151037 RVA: 0x005106CF File Offset: 0x0050E8CF
		public void UnPackTo(IGroupAiEcologyGameplayAbpT _o)
		{
			_o.GameplayType = this.GameplayType;
		}

		// Token: 0x06024DFE RID: 151038 RVA: 0x005106E0 File Offset: 0x0050E8E0
		public static Offset<IGroupAiEcologyGameplayAbp> Pack(FlatBufferBuilder builder, IGroupAiEcologyGameplayAbpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiEcologyGameplayAbp>);
			}
			return IGroupAiEcologyGameplayAbp.CreateIGroupAiEcologyGameplayAbp(builder, _o.GameplayType);
		}

		// Token: 0x0400F12A RID: 61738
		private Struct __p;
	}
}
