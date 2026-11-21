using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005637 RID: 22071
	public struct IDynamicAttachTarget : IFlatbufferObject
	{
		// Token: 0x17009E82 RID: 40578
		// (get) Token: 0x060233E9 RID: 144361 RVA: 0x004D9840 File Offset: 0x004D7A40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233EA RID: 144362 RVA: 0x004D984D File Offset: 0x004D7A4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233EB RID: 144363 RVA: 0x004D9854 File Offset: 0x004D7A54
		public static IDynamicAttachTarget GetRootAsIDynamicAttachTarget(ByteBuffer _bb)
		{
			return IDynamicAttachTarget.GetRootAsIDynamicAttachTarget(_bb, default(IDynamicAttachTarget));
		}

		// Token: 0x060233EC RID: 144364 RVA: 0x004D9870 File Offset: 0x004D7A70
		public static IDynamicAttachTarget GetRootAsIDynamicAttachTarget(ByteBuffer _bb, IDynamicAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233ED RID: 144365 RVA: 0x004D988D File Offset: 0x004D7A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060233EE RID: 144366 RVA: 0x004D989C File Offset: 0x004D7A9C
		public IDynamicAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E83 RID: 40579
		// (get) Token: 0x060233EF RID: 144367 RVA: 0x004D98AC File Offset: 0x004D7AAC
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060233F0 RID: 144368 RVA: 0x004D98E8 File Offset: 0x004D7AE8
		public static Offset<IDynamicAttachTarget> CreateIDynamicAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IDynamicAttachTarget.AddType(builder, Type);
			return IDynamicAttachTarget.EndIDynamicAttachTarget(builder);
		}

		// Token: 0x060233F1 RID: 144369 RVA: 0x004D98FE File Offset: 0x004D7AFE
		public static void StartIDynamicAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060233F2 RID: 144370 RVA: 0x004D9907 File Offset: 0x004D7B07
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060233F3 RID: 144371 RVA: 0x004D9912 File Offset: 0x004D7B12
		public static Offset<IDynamicAttachTarget> EndIDynamicAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicAttachTarget>(builder.EndTable());
		}

		// Token: 0x060233F4 RID: 144372 RVA: 0x004D9920 File Offset: 0x004D7B20
		public IDynamicAttachTargetT UnPack()
		{
			IDynamicAttachTargetT dynamicAttachTargetT = new IDynamicAttachTargetT();
			this.UnPackTo(dynamicAttachTargetT);
			return dynamicAttachTargetT;
		}

		// Token: 0x060233F5 RID: 144373 RVA: 0x004D993B File Offset: 0x004D7B3B
		public void UnPackTo(IDynamicAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060233F6 RID: 144374 RVA: 0x004D994C File Offset: 0x004D7B4C
		public static Offset<IDynamicAttachTarget> Pack(FlatBufferBuilder builder, IDynamicAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicAttachTarget>);
			}
			return IDynamicAttachTarget.CreateIDynamicAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400ED17 RID: 60695
		private Table __p;
	}
}
