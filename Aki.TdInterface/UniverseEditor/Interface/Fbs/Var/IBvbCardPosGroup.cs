using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A45 RID: 14917
	public struct IBvbCardPosGroup : IFlatbufferObject
	{
		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x06014320 RID: 82720 RVA: 0x002F3C47 File Offset: 0x002F1E47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014321 RID: 82721 RVA: 0x002F3C54 File Offset: 0x002F1E54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014322 RID: 82722 RVA: 0x002F3C5C File Offset: 0x002F1E5C
		public static IBvbCardPosGroup GetRootAsIBvbCardPosGroup(ByteBuffer _bb)
		{
			return IBvbCardPosGroup.GetRootAsIBvbCardPosGroup(_bb, default(IBvbCardPosGroup));
		}

		// Token: 0x06014323 RID: 82723 RVA: 0x002F3C78 File Offset: 0x002F1E78
		public static IBvbCardPosGroup GetRootAsIBvbCardPosGroup(ByteBuffer _bb, IBvbCardPosGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014324 RID: 82724 RVA: 0x002F3C95 File Offset: 0x002F1E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014325 RID: 82725 RVA: 0x002F3CA4 File Offset: 0x002F1EA4
		public IBvbCardPosGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x06014326 RID: 82726 RVA: 0x002F3CB4 File Offset: 0x002F1EB4
		public bool Pos0
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x06014327 RID: 82727 RVA: 0x002F3CF4 File Offset: 0x002F1EF4
		public bool Pos1
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x06014328 RID: 82728 RVA: 0x002F3D34 File Offset: 0x002F1F34
		public bool Pos2
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x06014329 RID: 82729 RVA: 0x002F3D74 File Offset: 0x002F1F74
		public bool Pos3
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0601432A RID: 82730 RVA: 0x002F3DB4 File Offset: 0x002F1FB4
		public bool Pos4
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0601432B RID: 82731 RVA: 0x002F3DF4 File Offset: 0x002F1FF4
		public bool Pos5
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x0601432C RID: 82732 RVA: 0x002F3E34 File Offset: 0x002F2034
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601432D RID: 82733 RVA: 0x002F3E74 File Offset: 0x002F2074
		public static Offset<IBvbCardPosGroup> CreateIBvbCardPosGroup(FlatBufferBuilder builder, bool Pos0 = false, bool Pos1 = false, bool Pos2 = false, bool Pos3 = false, bool Pos4 = false, bool Pos5 = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IBvbCardPosGroup.AddNullMask(builder, NullMask);
			IBvbCardPosGroup.AddPos5(builder, Pos5);
			IBvbCardPosGroup.AddPos4(builder, Pos4);
			IBvbCardPosGroup.AddPos3(builder, Pos3);
			IBvbCardPosGroup.AddPos2(builder, Pos2);
			IBvbCardPosGroup.AddPos1(builder, Pos1);
			IBvbCardPosGroup.AddPos0(builder, Pos0);
			return IBvbCardPosGroup.EndIBvbCardPosGroup(builder);
		}

		// Token: 0x0601432E RID: 82734 RVA: 0x002F3EC3 File Offset: 0x002F20C3
		public static void StartIBvbCardPosGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601432F RID: 82735 RVA: 0x002F3ECC File Offset: 0x002F20CC
		public static void AddPos0(FlatBufferBuilder builder, bool pos0)
		{
			builder.AddBool(0, pos0, false);
		}

		// Token: 0x06014330 RID: 82736 RVA: 0x002F3ED7 File Offset: 0x002F20D7
		public static void AddPos1(FlatBufferBuilder builder, bool pos1)
		{
			builder.AddBool(1, pos1, false);
		}

		// Token: 0x06014331 RID: 82737 RVA: 0x002F3EE2 File Offset: 0x002F20E2
		public static void AddPos2(FlatBufferBuilder builder, bool pos2)
		{
			builder.AddBool(2, pos2, false);
		}

		// Token: 0x06014332 RID: 82738 RVA: 0x002F3EED File Offset: 0x002F20ED
		public static void AddPos3(FlatBufferBuilder builder, bool pos3)
		{
			builder.AddBool(3, pos3, false);
		}

		// Token: 0x06014333 RID: 82739 RVA: 0x002F3EF8 File Offset: 0x002F20F8
		public static void AddPos4(FlatBufferBuilder builder, bool pos4)
		{
			builder.AddBool(4, pos4, false);
		}

		// Token: 0x06014334 RID: 82740 RVA: 0x002F3F03 File Offset: 0x002F2103
		public static void AddPos5(FlatBufferBuilder builder, bool pos5)
		{
			builder.AddBool(5, pos5, false);
		}

		// Token: 0x06014335 RID: 82741 RVA: 0x002F3F0E File Offset: 0x002F210E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06014336 RID: 82742 RVA: 0x002F3F19 File Offset: 0x002F2119
		public static Offset<IBvbCardPosGroup> EndIBvbCardPosGroup(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardPosGroup>(builder.EndTable());
		}

		// Token: 0x06014337 RID: 82743 RVA: 0x002F3F28 File Offset: 0x002F2128
		public IBvbCardPosGroupT UnPack()
		{
			IBvbCardPosGroupT bvbCardPosGroupT = new IBvbCardPosGroupT();
			this.UnPackTo(bvbCardPosGroupT);
			return bvbCardPosGroupT;
		}

		// Token: 0x06014338 RID: 82744 RVA: 0x002F3F44 File Offset: 0x002F2144
		public void UnPackTo(IBvbCardPosGroupT _o)
		{
			_o.Pos0 = this.Pos0;
			_o.Pos1 = this.Pos1;
			_o.Pos2 = this.Pos2;
			_o.Pos3 = this.Pos3;
			_o.Pos4 = this.Pos4;
			_o.Pos5 = this.Pos5;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014339 RID: 82745 RVA: 0x002F3FA8 File Offset: 0x002F21A8
		public static Offset<IBvbCardPosGroup> Pack(FlatBufferBuilder builder, IBvbCardPosGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardPosGroup>);
			}
			return IBvbCardPosGroup.CreateIBvbCardPosGroup(builder, _o.Pos0, _o.Pos1, _o.Pos2, _o.Pos3, _o.Pos4, _o.Pos5, _o.NullMask);
		}

		// Token: 0x0400AEC5 RID: 44741
		private Table __p;
	}
}
