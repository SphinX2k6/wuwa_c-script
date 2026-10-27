using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D22 RID: 15650
	public struct IAttributeToTarget : IFlatbufferObject
	{
		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x06015991 RID: 88465 RVA: 0x0031E50F File Offset: 0x0031C70F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015992 RID: 88466 RVA: 0x0031E51C File Offset: 0x0031C71C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015993 RID: 88467 RVA: 0x0031E524 File Offset: 0x0031C724
		public static IAttributeToTarget GetRootAsIAttributeToTarget(ByteBuffer _bb)
		{
			return IAttributeToTarget.GetRootAsIAttributeToTarget(_bb, default(IAttributeToTarget));
		}

		// Token: 0x06015994 RID: 88468 RVA: 0x0031E540 File Offset: 0x0031C740
		public static IAttributeToTarget GetRootAsIAttributeToTarget(ByteBuffer _bb, IAttributeToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015995 RID: 88469 RVA: 0x0031E55D File Offset: 0x0031C75D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015996 RID: 88470 RVA: 0x0031E56C File Offset: 0x0031C76C
		public IAttributeToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x06015997 RID: 88471 RVA: 0x0031E57C File Offset: 0x0031C77C
		public EAttributeToTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttributeToTarget.Health;
				}
				return (EAttributeToTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015998 RID: 88472 RVA: 0x0031E5B8 File Offset: 0x0031C7B8
		public static Offset<IAttributeToTarget> CreateIAttributeToTarget(FlatBufferBuilder builder, EAttributeToTarget Type = EAttributeToTarget.Health)
		{
			builder.StartTable(1);
			IAttributeToTarget.AddType(builder, Type);
			return IAttributeToTarget.EndIAttributeToTarget(builder);
		}

		// Token: 0x06015999 RID: 88473 RVA: 0x0031E5CE File Offset: 0x0031C7CE
		public static void StartIAttributeToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601599A RID: 88474 RVA: 0x0031E5D7 File Offset: 0x0031C7D7
		public static void AddType(FlatBufferBuilder builder, EAttributeToTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601599B RID: 88475 RVA: 0x0031E5E2 File Offset: 0x0031C7E2
		public static Offset<IAttributeToTarget> EndIAttributeToTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAttributeToTarget>(builder.EndTable());
		}

		// Token: 0x0601599C RID: 88476 RVA: 0x0031E5F0 File Offset: 0x0031C7F0
		public IAttributeToTargetT UnPack()
		{
			IAttributeToTargetT attributeToTargetT = new IAttributeToTargetT();
			this.UnPackTo(attributeToTargetT);
			return attributeToTargetT;
		}

		// Token: 0x0601599D RID: 88477 RVA: 0x0031E60B File Offset: 0x0031C80B
		public void UnPackTo(IAttributeToTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601599E RID: 88478 RVA: 0x0031E61C File Offset: 0x0031C81C
		public static Offset<IAttributeToTarget> Pack(FlatBufferBuilder builder, IAttributeToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttributeToTarget>);
			}
			return IAttributeToTarget.CreateIAttributeToTarget(builder, _o.Type);
		}

		// Token: 0x0400B5D9 RID: 46553
		private Table __p;
	}
}
