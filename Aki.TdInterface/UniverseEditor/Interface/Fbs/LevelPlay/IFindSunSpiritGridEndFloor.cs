using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004926 RID: 18726
	public struct IFindSunSpiritGridEndFloor : IFlatbufferObject
	{
		// Token: 0x1700826F RID: 33391
		// (get) Token: 0x0601BC7F RID: 113791 RVA: 0x003ED718 File Offset: 0x003EB918
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC80 RID: 113792 RVA: 0x003ED725 File Offset: 0x003EB925
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC81 RID: 113793 RVA: 0x003ED72C File Offset: 0x003EB92C
		public static IFindSunSpiritGridEndFloor GetRootAsIFindSunSpiritGridEndFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridEndFloor.GetRootAsIFindSunSpiritGridEndFloor(_bb, default(IFindSunSpiritGridEndFloor));
		}

		// Token: 0x0601BC82 RID: 113794 RVA: 0x003ED748 File Offset: 0x003EB948
		public static IFindSunSpiritGridEndFloor GetRootAsIFindSunSpiritGridEndFloor(ByteBuffer _bb, IFindSunSpiritGridEndFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC83 RID: 113795 RVA: 0x003ED765 File Offset: 0x003EB965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC84 RID: 113796 RVA: 0x003ED774 File Offset: 0x003EB974
		public IFindSunSpiritGridEndFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008270 RID: 33392
		// (get) Token: 0x0601BC85 RID: 113797 RVA: 0x003ED784 File Offset: 0x003EB984
		public EFindSunSpiritGridType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFindSunSpiritGridType.Empty;
				}
				return (EFindSunSpiritGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC86 RID: 113798 RVA: 0x003ED7C0 File Offset: 0x003EB9C0
		public static Offset<IFindSunSpiritGridEndFloor> CreateIFindSunSpiritGridEndFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridEndFloor.AddType(builder, Type);
			return IFindSunSpiritGridEndFloor.EndIFindSunSpiritGridEndFloor(builder);
		}

		// Token: 0x0601BC87 RID: 113799 RVA: 0x003ED7D6 File Offset: 0x003EB9D6
		public static void StartIFindSunSpiritGridEndFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BC88 RID: 113800 RVA: 0x003ED7DF File Offset: 0x003EB9DF
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BC89 RID: 113801 RVA: 0x003ED7EA File Offset: 0x003EB9EA
		public static Offset<IFindSunSpiritGridEndFloor> EndIFindSunSpiritGridEndFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridEndFloor>(builder.EndTable());
		}

		// Token: 0x0601BC8A RID: 113802 RVA: 0x003ED7F8 File Offset: 0x003EB9F8
		public IFindSunSpiritGridEndFloorT UnPack()
		{
			IFindSunSpiritGridEndFloorT findSunSpiritGridEndFloorT = new IFindSunSpiritGridEndFloorT();
			this.UnPackTo(findSunSpiritGridEndFloorT);
			return findSunSpiritGridEndFloorT;
		}

		// Token: 0x0601BC8B RID: 113803 RVA: 0x003ED813 File Offset: 0x003EBA13
		public void UnPackTo(IFindSunSpiritGridEndFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BC8C RID: 113804 RVA: 0x003ED824 File Offset: 0x003EBA24
		public static Offset<IFindSunSpiritGridEndFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridEndFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridEndFloor>);
			}
			return IFindSunSpiritGridEndFloor.CreateIFindSunSpiritGridEndFloor(builder, _o.Type);
		}

		// Token: 0x0400CF00 RID: 52992
		private Table __p;
	}
}
