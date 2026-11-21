using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A1 RID: 21921
	public struct ICreateBulletDestroyCondition : IFlatbufferObject
	{
		// Token: 0x17009CF7 RID: 40183
		// (get) Token: 0x06022DD9 RID: 142809 RVA: 0x004CD4E7 File Offset: 0x004CB6E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DDA RID: 142810 RVA: 0x004CD4F4 File Offset: 0x004CB6F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DDB RID: 142811 RVA: 0x004CD4FC File Offset: 0x004CB6FC
		public static ICreateBulletDestroyCondition GetRootAsICreateBulletDestroyCondition(ByteBuffer _bb)
		{
			return ICreateBulletDestroyCondition.GetRootAsICreateBulletDestroyCondition(_bb, default(ICreateBulletDestroyCondition));
		}

		// Token: 0x06022DDC RID: 142812 RVA: 0x004CD518 File Offset: 0x004CB718
		public static ICreateBulletDestroyCondition GetRootAsICreateBulletDestroyCondition(ByteBuffer _bb, ICreateBulletDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DDD RID: 142813 RVA: 0x004CD535 File Offset: 0x004CB735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DDE RID: 142814 RVA: 0x004CD544 File Offset: 0x004CB744
		public ICreateBulletDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CF8 RID: 40184
		// (get) Token: 0x06022DDF RID: 142815 RVA: 0x004CD554 File Offset: 0x004CB754
		public ETeleControlDestroyCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return (ETeleControlDestroyCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DE0 RID: 142816 RVA: 0x004CD590 File Offset: 0x004CB790
		public static Offset<ICreateBulletDestroyCondition> CreateICreateBulletDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ICreateBulletDestroyCondition.AddType(builder, Type);
			return ICreateBulletDestroyCondition.EndICreateBulletDestroyCondition(builder);
		}

		// Token: 0x06022DE1 RID: 142817 RVA: 0x004CD5A6 File Offset: 0x004CB7A6
		public static void StartICreateBulletDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022DE2 RID: 142818 RVA: 0x004CD5AF File Offset: 0x004CB7AF
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022DE3 RID: 142819 RVA: 0x004CD5BA File Offset: 0x004CB7BA
		public static Offset<ICreateBulletDestroyCondition> EndICreateBulletDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICreateBulletDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06022DE4 RID: 142820 RVA: 0x004CD5C8 File Offset: 0x004CB7C8
		public ICreateBulletDestroyConditionT UnPack()
		{
			ICreateBulletDestroyConditionT createBulletDestroyConditionT = new ICreateBulletDestroyConditionT();
			this.UnPackTo(createBulletDestroyConditionT);
			return createBulletDestroyConditionT;
		}

		// Token: 0x06022DE5 RID: 142821 RVA: 0x004CD5E3 File Offset: 0x004CB7E3
		public void UnPackTo(ICreateBulletDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022DE6 RID: 142822 RVA: 0x004CD5F4 File Offset: 0x004CB7F4
		public static Offset<ICreateBulletDestroyCondition> Pack(FlatBufferBuilder builder, ICreateBulletDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreateBulletDestroyCondition>);
			}
			return ICreateBulletDestroyCondition.CreateICreateBulletDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400EC2B RID: 60459
		private Table __p;
	}
}
