using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005042 RID: 20546
	public struct ICreateBulletDestroyCondition : IFlatbufferObject
	{
		// Token: 0x17009516 RID: 38166
		// (get) Token: 0x06020EB9 RID: 134841 RVA: 0x00493A97 File Offset: 0x00491C97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020EBA RID: 134842 RVA: 0x00493AA4 File Offset: 0x00491CA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020EBB RID: 134843 RVA: 0x00493AAC File Offset: 0x00491CAC
		public static ICreateBulletDestroyCondition GetRootAsICreateBulletDestroyCondition(ByteBuffer _bb)
		{
			return ICreateBulletDestroyCondition.GetRootAsICreateBulletDestroyCondition(_bb, default(ICreateBulletDestroyCondition));
		}

		// Token: 0x06020EBC RID: 134844 RVA: 0x00493AC8 File Offset: 0x00491CC8
		public static ICreateBulletDestroyCondition GetRootAsICreateBulletDestroyCondition(ByteBuffer _bb, ICreateBulletDestroyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020EBD RID: 134845 RVA: 0x00493AE5 File Offset: 0x00491CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020EBE RID: 134846 RVA: 0x00493AF4 File Offset: 0x00491CF4
		public ICreateBulletDestroyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009517 RID: 38167
		// (get) Token: 0x06020EBF RID: 134847 RVA: 0x00493B04 File Offset: 0x00491D04
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

		// Token: 0x06020EC0 RID: 134848 RVA: 0x00493B40 File Offset: 0x00491D40
		public static Offset<ICreateBulletDestroyCondition> CreateICreateBulletDestroyCondition(FlatBufferBuilder builder, ETeleControlDestroyCondition Type = ETeleControlDestroyCondition.LetGo)
		{
			builder.StartTable(1);
			ICreateBulletDestroyCondition.AddType(builder, Type);
			return ICreateBulletDestroyCondition.EndICreateBulletDestroyCondition(builder);
		}

		// Token: 0x06020EC1 RID: 134849 RVA: 0x00493B56 File Offset: 0x00491D56
		public static void StartICreateBulletDestroyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020EC2 RID: 134850 RVA: 0x00493B5F File Offset: 0x00491D5F
		public static void AddType(FlatBufferBuilder builder, ETeleControlDestroyCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020EC3 RID: 134851 RVA: 0x00493B6A File Offset: 0x00491D6A
		public static Offset<ICreateBulletDestroyCondition> EndICreateBulletDestroyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICreateBulletDestroyCondition>(builder.EndTable());
		}

		// Token: 0x06020EC4 RID: 134852 RVA: 0x00493B78 File Offset: 0x00491D78
		public ICreateBulletDestroyConditionT UnPack()
		{
			ICreateBulletDestroyConditionT createBulletDestroyConditionT = new ICreateBulletDestroyConditionT();
			this.UnPackTo(createBulletDestroyConditionT);
			return createBulletDestroyConditionT;
		}

		// Token: 0x06020EC5 RID: 134853 RVA: 0x00493B93 File Offset: 0x00491D93
		public void UnPackTo(ICreateBulletDestroyConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020EC6 RID: 134854 RVA: 0x00493BA4 File Offset: 0x00491DA4
		public static Offset<ICreateBulletDestroyCondition> Pack(FlatBufferBuilder builder, ICreateBulletDestroyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreateBulletDestroyCondition>);
			}
			return ICreateBulletDestroyCondition.CreateICreateBulletDestroyCondition(builder, _o.Type);
		}

		// Token: 0x0400E035 RID: 57397
		private Table __p;
	}
}
