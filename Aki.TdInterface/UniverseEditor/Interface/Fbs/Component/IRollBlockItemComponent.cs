using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E95 RID: 24213
	public struct IRollBlockItemComponent : IFlatbufferObject
	{
		// Token: 0x1700B2AC RID: 45740
		// (get) Token: 0x0602885E RID: 165982 RVA: 0x0058A486 File Offset: 0x00588686
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602885F RID: 165983 RVA: 0x0058A493 File Offset: 0x00588693
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028860 RID: 165984 RVA: 0x0058A49C File Offset: 0x0058869C
		public static IRollBlockItemComponent GetRootAsIRollBlockItemComponent(ByteBuffer _bb)
		{
			return IRollBlockItemComponent.GetRootAsIRollBlockItemComponent(_bb, default(IRollBlockItemComponent));
		}

		// Token: 0x06028861 RID: 165985 RVA: 0x0058A4B8 File Offset: 0x005886B8
		public static IRollBlockItemComponent GetRootAsIRollBlockItemComponent(ByteBuffer _bb, IRollBlockItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028862 RID: 165986 RVA: 0x0058A4D5 File Offset: 0x005886D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028863 RID: 165987 RVA: 0x0058A4E4 File Offset: 0x005886E4
		public IRollBlockItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2AD RID: 45741
		// (get) Token: 0x06028864 RID: 165988 RVA: 0x0058A4F4 File Offset: 0x005886F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2AE RID: 45742
		// (get) Token: 0x06028865 RID: 165989 RVA: 0x0058A534 File Offset: 0x00588734
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028866 RID: 165990 RVA: 0x0058A570 File Offset: 0x00588770
		public static Offset<IRollBlockItemComponent> CreateIRollBlockItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockItemComponent.AddNullMask(builder, NullMask);
			IRollBlockItemComponent.AddDisabled(builder, Disabled);
			return IRollBlockItemComponent.EndIRollBlockItemComponent(builder);
		}

		// Token: 0x06028867 RID: 165991 RVA: 0x0058A58D File Offset: 0x0058878D
		public static void StartIRollBlockItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028868 RID: 165992 RVA: 0x0058A596 File Offset: 0x00588796
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028869 RID: 165993 RVA: 0x0058A5A1 File Offset: 0x005887A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602886A RID: 165994 RVA: 0x0058A5AC File Offset: 0x005887AC
		public static Offset<IRollBlockItemComponent> EndIRollBlockItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemComponent>(builder.EndTable());
		}

		// Token: 0x0602886B RID: 165995 RVA: 0x0058A5BC File Offset: 0x005887BC
		public IRollBlockItemComponentT UnPack()
		{
			IRollBlockItemComponentT rollBlockItemComponentT = new IRollBlockItemComponentT();
			this.UnPackTo(rollBlockItemComponentT);
			return rollBlockItemComponentT;
		}

		// Token: 0x0602886C RID: 165996 RVA: 0x0058A5D7 File Offset: 0x005887D7
		public void UnPackTo(IRollBlockItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602886D RID: 165997 RVA: 0x0058A5F4 File Offset: 0x005887F4
		public static Offset<IRollBlockItemComponent> Pack(FlatBufferBuilder builder, IRollBlockItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemComponent>);
			}
			return IRollBlockItemComponent.CreateIRollBlockItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400FAC6 RID: 64198
		private Table __p;
	}
}
