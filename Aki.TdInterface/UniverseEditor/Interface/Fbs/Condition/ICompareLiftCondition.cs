using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB0 RID: 19376
	public struct ICompareLiftCondition : IFlatbufferObject
	{
		// Token: 0x17008CA9 RID: 36009
		// (get) Token: 0x0601E8EE RID: 125166 RVA: 0x00446576 File Offset: 0x00444776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8EF RID: 125167 RVA: 0x00446583 File Offset: 0x00444783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8F0 RID: 125168 RVA: 0x0044658C File Offset: 0x0044478C
		public static ICompareLiftCondition GetRootAsICompareLiftCondition(ByteBuffer _bb)
		{
			return ICompareLiftCondition.GetRootAsICompareLiftCondition(_bb, default(ICompareLiftCondition));
		}

		// Token: 0x0601E8F1 RID: 125169 RVA: 0x004465A8 File Offset: 0x004447A8
		public static ICompareLiftCondition GetRootAsICompareLiftCondition(ByteBuffer _bb, ICompareLiftCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8F2 RID: 125170 RVA: 0x004465C5 File Offset: 0x004447C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8F3 RID: 125171 RVA: 0x004465D4 File Offset: 0x004447D4
		public ICompareLiftCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CAA RID: 36010
		// (get) Token: 0x0601E8F4 RID: 125172 RVA: 0x004465E4 File Offset: 0x004447E4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CAB RID: 36011
		// (get) Token: 0x0601E8F5 RID: 125173 RVA: 0x00446620 File Offset: 0x00444820
		public bool IsSelf
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAC RID: 36012
		// (get) Token: 0x0601E8F6 RID: 125174 RVA: 0x00446660 File Offset: 0x00444860
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CAD RID: 36013
		// (get) Token: 0x0601E8F7 RID: 125175 RVA: 0x0044669C File Offset: 0x0044489C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CAE RID: 36014
		// (get) Token: 0x0601E8F8 RID: 125176 RVA: 0x004466DC File Offset: 0x004448DC
		public int Location
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CAF RID: 36015
		// (get) Token: 0x0601E8F9 RID: 125177 RVA: 0x0044671C File Offset: 0x0044491C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E8FA RID: 125178 RVA: 0x00446759 File Offset: 0x00444959
		public static Offset<ICompareLiftCondition> CreateICompareLiftCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSelf = false, int EntityId = 0, ECompare Compare = ECompare.Eq, int Location = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICompareLiftCondition.AddLocation(builder, Location);
			ICompareLiftCondition.AddEntityId(builder, EntityId);
			ICompareLiftCondition.AddNullMask(builder, NullMask);
			ICompareLiftCondition.AddCompare(builder, Compare);
			ICompareLiftCondition.AddIsSelf(builder, IsSelf);
			ICompareLiftCondition.AddType(builder, Type);
			return ICompareLiftCondition.EndICompareLiftCondition(builder);
		}

		// Token: 0x0601E8FB RID: 125179 RVA: 0x00446795 File Offset: 0x00444995
		public static void StartICompareLiftCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601E8FC RID: 125180 RVA: 0x0044679E File Offset: 0x0044499E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E8FD RID: 125181 RVA: 0x004467A9 File Offset: 0x004449A9
		public static void AddIsSelf(FlatBufferBuilder builder, bool isSelf)
		{
			builder.AddBool(1, isSelf, false);
		}

		// Token: 0x0601E8FE RID: 125182 RVA: 0x004467B4 File Offset: 0x004449B4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601E8FF RID: 125183 RVA: 0x004467BF File Offset: 0x004449BF
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601E900 RID: 125184 RVA: 0x004467CA File Offset: 0x004449CA
		public static void AddLocation(FlatBufferBuilder builder, int location)
		{
			builder.AddInt(4, location, 0);
		}

		// Token: 0x0601E901 RID: 125185 RVA: 0x004467D5 File Offset: 0x004449D5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601E902 RID: 125186 RVA: 0x004467E0 File Offset: 0x004449E0
		public static Offset<ICompareLiftCondition> EndICompareLiftCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareLiftCondition>(builder.EndTable());
		}

		// Token: 0x0601E903 RID: 125187 RVA: 0x004467F0 File Offset: 0x004449F0
		public ICompareLiftConditionT UnPack()
		{
			ICompareLiftConditionT compareLiftConditionT = new ICompareLiftConditionT();
			this.UnPackTo(compareLiftConditionT);
			return compareLiftConditionT;
		}

		// Token: 0x0601E904 RID: 125188 RVA: 0x0044680C File Offset: 0x00444A0C
		public void UnPackTo(ICompareLiftConditionT _o)
		{
			_o.Type = this.Type;
			_o.IsSelf = this.IsSelf;
			_o.EntityId = this.EntityId;
			_o.Compare = this.Compare;
			_o.Location = this.Location;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E905 RID: 125189 RVA: 0x00446864 File Offset: 0x00444A64
		public static Offset<ICompareLiftCondition> Pack(FlatBufferBuilder builder, ICompareLiftConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareLiftCondition>);
			}
			return ICompareLiftCondition.CreateICompareLiftCondition(builder, _o.Type, _o.IsSelf, _o.EntityId, _o.Compare, _o.Location, _o.NullMask);
		}

		// Token: 0x0400D492 RID: 54418
		private Table __p;
	}
}
