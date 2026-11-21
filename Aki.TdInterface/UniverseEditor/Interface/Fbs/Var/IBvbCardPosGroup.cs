using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E20 RID: 15904
	public struct IBvbCardPosGroup : IFlatbufferObject
	{
		// Token: 0x17006B69 RID: 27497
		// (get) Token: 0x0601563C RID: 87612 RVA: 0x00316E33 File Offset: 0x00315033
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601563D RID: 87613 RVA: 0x00316E40 File Offset: 0x00315040
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601563E RID: 87614 RVA: 0x00316E48 File Offset: 0x00315048
		public static IBvbCardPosGroup GetRootAsIBvbCardPosGroup(ByteBuffer _bb)
		{
			return IBvbCardPosGroup.GetRootAsIBvbCardPosGroup(_bb, default(IBvbCardPosGroup));
		}

		// Token: 0x0601563F RID: 87615 RVA: 0x00316E64 File Offset: 0x00315064
		public static IBvbCardPosGroup GetRootAsIBvbCardPosGroup(ByteBuffer _bb, IBvbCardPosGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015640 RID: 87616 RVA: 0x00316E81 File Offset: 0x00315081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015641 RID: 87617 RVA: 0x00316E90 File Offset: 0x00315090
		public IBvbCardPosGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B6A RID: 27498
		// (get) Token: 0x06015642 RID: 87618 RVA: 0x00316EA0 File Offset: 0x003150A0
		public bool Pos0
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B6B RID: 27499
		// (get) Token: 0x06015643 RID: 87619 RVA: 0x00316EE0 File Offset: 0x003150E0
		public bool Pos1
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B6C RID: 27500
		// (get) Token: 0x06015644 RID: 87620 RVA: 0x00316F20 File Offset: 0x00315120
		public bool Pos2
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B6D RID: 27501
		// (get) Token: 0x06015645 RID: 87621 RVA: 0x00316F60 File Offset: 0x00315160
		public bool Pos3
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B6E RID: 27502
		// (get) Token: 0x06015646 RID: 87622 RVA: 0x00316FA0 File Offset: 0x003151A0
		public bool Pos4
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B6F RID: 27503
		// (get) Token: 0x06015647 RID: 87623 RVA: 0x00316FE0 File Offset: 0x003151E0
		public bool Pos5
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B70 RID: 27504
		// (get) Token: 0x06015648 RID: 87624 RVA: 0x00317020 File Offset: 0x00315220
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

		// Token: 0x06015649 RID: 87625 RVA: 0x00317060 File Offset: 0x00315260
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

		// Token: 0x0601564A RID: 87626 RVA: 0x003170AF File Offset: 0x003152AF
		public static void StartIBvbCardPosGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601564B RID: 87627 RVA: 0x003170B8 File Offset: 0x003152B8
		public static void AddPos0(FlatBufferBuilder builder, bool pos0)
		{
			builder.AddBool(0, pos0, false);
		}

		// Token: 0x0601564C RID: 87628 RVA: 0x003170C3 File Offset: 0x003152C3
		public static void AddPos1(FlatBufferBuilder builder, bool pos1)
		{
			builder.AddBool(1, pos1, false);
		}

		// Token: 0x0601564D RID: 87629 RVA: 0x003170CE File Offset: 0x003152CE
		public static void AddPos2(FlatBufferBuilder builder, bool pos2)
		{
			builder.AddBool(2, pos2, false);
		}

		// Token: 0x0601564E RID: 87630 RVA: 0x003170D9 File Offset: 0x003152D9
		public static void AddPos3(FlatBufferBuilder builder, bool pos3)
		{
			builder.AddBool(3, pos3, false);
		}

		// Token: 0x0601564F RID: 87631 RVA: 0x003170E4 File Offset: 0x003152E4
		public static void AddPos4(FlatBufferBuilder builder, bool pos4)
		{
			builder.AddBool(4, pos4, false);
		}

		// Token: 0x06015650 RID: 87632 RVA: 0x003170EF File Offset: 0x003152EF
		public static void AddPos5(FlatBufferBuilder builder, bool pos5)
		{
			builder.AddBool(5, pos5, false);
		}

		// Token: 0x06015651 RID: 87633 RVA: 0x003170FA File Offset: 0x003152FA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06015652 RID: 87634 RVA: 0x00317105 File Offset: 0x00315305
		public static Offset<IBvbCardPosGroup> EndIBvbCardPosGroup(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardPosGroup>(builder.EndTable());
		}

		// Token: 0x06015653 RID: 87635 RVA: 0x00317114 File Offset: 0x00315314
		public IBvbCardPosGroupT UnPack()
		{
			IBvbCardPosGroupT bvbCardPosGroupT = new IBvbCardPosGroupT();
			this.UnPackTo(bvbCardPosGroupT);
			return bvbCardPosGroupT;
		}

		// Token: 0x06015654 RID: 87636 RVA: 0x00317130 File Offset: 0x00315330
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

		// Token: 0x06015655 RID: 87637 RVA: 0x00317194 File Offset: 0x00315394
		public static Offset<IBvbCardPosGroup> Pack(FlatBufferBuilder builder, IBvbCardPosGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardPosGroup>);
			}
			return IBvbCardPosGroup.CreateIBvbCardPosGroup(builder, _o.Pos0, _o.Pos1, _o.Pos2, _o.Pos3, _o.Pos4, _o.Pos5, _o.NullMask);
		}

		// Token: 0x0400B7E7 RID: 47079
		private Table __p;
	}
}
