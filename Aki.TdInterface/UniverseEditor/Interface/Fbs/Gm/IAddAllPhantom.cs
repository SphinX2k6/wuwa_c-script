using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A98 RID: 19096
	public struct IAddAllPhantom : IFlatbufferObject
	{
		// Token: 0x170085C5 RID: 34245
		// (get) Token: 0x0601CB38 RID: 117560 RVA: 0x0040C019 File Offset: 0x0040A219
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB39 RID: 117561 RVA: 0x0040C026 File Offset: 0x0040A226
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB3A RID: 117562 RVA: 0x0040C030 File Offset: 0x0040A230
		public static IAddAllPhantom GetRootAsIAddAllPhantom(ByteBuffer _bb)
		{
			return IAddAllPhantom.GetRootAsIAddAllPhantom(_bb, default(IAddAllPhantom));
		}

		// Token: 0x0601CB3B RID: 117563 RVA: 0x0040C04C File Offset: 0x0040A24C
		public static IAddAllPhantom GetRootAsIAddAllPhantom(ByteBuffer _bb, IAddAllPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB3C RID: 117564 RVA: 0x0040C069 File Offset: 0x0040A269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB3D RID: 117565 RVA: 0x0040C078 File Offset: 0x0040A278
		public IAddAllPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085C6 RID: 34246
		// (get) Token: 0x0601CB3E RID: 117566 RVA: 0x0040C088 File Offset: 0x0040A288
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CB3F RID: 117567 RVA: 0x0040C0C4 File Offset: 0x0040A2C4
		public static Offset<IAddAllPhantom> CreateIAddAllPhantom(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllPhantom.AddType(builder, Type);
			return IAddAllPhantom.EndIAddAllPhantom(builder);
		}

		// Token: 0x0601CB40 RID: 117568 RVA: 0x0040C0DA File Offset: 0x0040A2DA
		public static void StartIAddAllPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CB41 RID: 117569 RVA: 0x0040C0E3 File Offset: 0x0040A2E3
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB42 RID: 117570 RVA: 0x0040C0EE File Offset: 0x0040A2EE
		public static Offset<IAddAllPhantom> EndIAddAllPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllPhantom>(builder.EndTable());
		}

		// Token: 0x0601CB43 RID: 117571 RVA: 0x0040C0FC File Offset: 0x0040A2FC
		public IAddAllPhantomT UnPack()
		{
			IAddAllPhantomT addAllPhantomT = new IAddAllPhantomT();
			this.UnPackTo(addAllPhantomT);
			return addAllPhantomT;
		}

		// Token: 0x0601CB44 RID: 117572 RVA: 0x0040C117 File Offset: 0x0040A317
		public void UnPackTo(IAddAllPhantomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CB45 RID: 117573 RVA: 0x0040C128 File Offset: 0x0040A328
		public static Offset<IAddAllPhantom> Pack(FlatBufferBuilder builder, IAddAllPhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllPhantom>);
			}
			return IAddAllPhantom.CreateIAddAllPhantom(builder, _o.Type);
		}

		// Token: 0x0400D1D7 RID: 53719
		private Table __p;
	}
}
