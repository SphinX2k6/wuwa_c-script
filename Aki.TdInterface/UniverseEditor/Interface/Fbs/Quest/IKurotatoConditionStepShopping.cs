using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE7 RID: 16103
	public struct IKurotatoConditionStepShopping : IFlatbufferObject
	{
		// Token: 0x17006FBB RID: 28603
		// (get) Token: 0x06016C75 RID: 93301 RVA: 0x003495B1 File Offset: 0x003477B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x003495BE File Offset: 0x003477BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C77 RID: 93303 RVA: 0x003495C8 File Offset: 0x003477C8
		public static IKurotatoConditionStepShopping GetRootAsIKurotatoConditionStepShopping(ByteBuffer _bb)
		{
			return IKurotatoConditionStepShopping.GetRootAsIKurotatoConditionStepShopping(_bb, default(IKurotatoConditionStepShopping));
		}

		// Token: 0x06016C78 RID: 93304 RVA: 0x003495E4 File Offset: 0x003477E4
		public static IKurotatoConditionStepShopping GetRootAsIKurotatoConditionStepShopping(ByteBuffer _bb, IKurotatoConditionStepShopping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C79 RID: 93305 RVA: 0x00349601 File Offset: 0x00347801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C7A RID: 93306 RVA: 0x00349610 File Offset: 0x00347810
		public IKurotatoConditionStepShopping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FBC RID: 28604
		// (get) Token: 0x06016C7B RID: 93307 RVA: 0x00349620 File Offset: 0x00347820
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016C7C RID: 93308 RVA: 0x0034965C File Offset: 0x0034785C
		public static Offset<IKurotatoConditionStepShopping> CreateIKurotatoConditionStepShopping(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepShopping.AddType(builder, Type);
			return IKurotatoConditionStepShopping.EndIKurotatoConditionStepShopping(builder);
		}

		// Token: 0x06016C7D RID: 93309 RVA: 0x00349672 File Offset: 0x00347872
		public static void StartIKurotatoConditionStepShopping(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C7E RID: 93310 RVA: 0x0034967B File Offset: 0x0034787B
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C7F RID: 93311 RVA: 0x00349686 File Offset: 0x00347886
		public static Offset<IKurotatoConditionStepShopping> EndIKurotatoConditionStepShopping(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepShopping>(builder.EndTable());
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x00349694 File Offset: 0x00347894
		public IKurotatoConditionStepShoppingT UnPack()
		{
			IKurotatoConditionStepShoppingT kurotatoConditionStepShoppingT = new IKurotatoConditionStepShoppingT();
			this.UnPackTo(kurotatoConditionStepShoppingT);
			return kurotatoConditionStepShoppingT;
		}

		// Token: 0x06016C81 RID: 93313 RVA: 0x003496AF File Offset: 0x003478AF
		public void UnPackTo(IKurotatoConditionStepShoppingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C82 RID: 93314 RVA: 0x003496C0 File Offset: 0x003478C0
		public static Offset<IKurotatoConditionStepShopping> Pack(FlatBufferBuilder builder, IKurotatoConditionStepShoppingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepShopping>);
			}
			return IKurotatoConditionStepShopping.CreateIKurotatoConditionStepShopping(builder, _o.Type);
		}

		// Token: 0x0400B8C7 RID: 47303
		private Table __p;
	}
}
