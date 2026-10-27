using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AF RID: 17583
	public struct IFindSunSpiritGridBase : IFlatbufferObject
	{
		// Token: 0x17007C1B RID: 31771
		// (get) Token: 0x0601A436 RID: 107574 RVA: 0x003C066B File Offset: 0x003BE86B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A437 RID: 107575 RVA: 0x003C0678 File Offset: 0x003BE878
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A438 RID: 107576 RVA: 0x003C0680 File Offset: 0x003BE880
		public static IFindSunSpiritGridBase GetRootAsIFindSunSpiritGridBase(ByteBuffer _bb)
		{
			return IFindSunSpiritGridBase.GetRootAsIFindSunSpiritGridBase(_bb, default(IFindSunSpiritGridBase));
		}

		// Token: 0x0601A439 RID: 107577 RVA: 0x003C069C File Offset: 0x003BE89C
		public static IFindSunSpiritGridBase GetRootAsIFindSunSpiritGridBase(ByteBuffer _bb, IFindSunSpiritGridBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A43A RID: 107578 RVA: 0x003C06B9 File Offset: 0x003BE8B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A43B RID: 107579 RVA: 0x003C06C8 File Offset: 0x003BE8C8
		public IFindSunSpiritGridBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C1C RID: 31772
		// (get) Token: 0x0601A43C RID: 107580 RVA: 0x003C06D8 File Offset: 0x003BE8D8
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

		// Token: 0x0601A43D RID: 107581 RVA: 0x003C0714 File Offset: 0x003BE914
		public static Offset<IFindSunSpiritGridBase> CreateIFindSunSpiritGridBase(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridBase.AddType(builder, Type);
			return IFindSunSpiritGridBase.EndIFindSunSpiritGridBase(builder);
		}

		// Token: 0x0601A43E RID: 107582 RVA: 0x003C072A File Offset: 0x003BE92A
		public static void StartIFindSunSpiritGridBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x003C0733 File Offset: 0x003BE933
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A440 RID: 107584 RVA: 0x003C073E File Offset: 0x003BE93E
		public static Offset<IFindSunSpiritGridBase> EndIFindSunSpiritGridBase(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridBase>(builder.EndTable());
		}

		// Token: 0x0601A441 RID: 107585 RVA: 0x003C074C File Offset: 0x003BE94C
		public IFindSunSpiritGridBaseT UnPack()
		{
			IFindSunSpiritGridBaseT findSunSpiritGridBaseT = new IFindSunSpiritGridBaseT();
			this.UnPackTo(findSunSpiritGridBaseT);
			return findSunSpiritGridBaseT;
		}

		// Token: 0x0601A442 RID: 107586 RVA: 0x003C0767 File Offset: 0x003BE967
		public void UnPackTo(IFindSunSpiritGridBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A443 RID: 107587 RVA: 0x003C0778 File Offset: 0x003BE978
		public static Offset<IFindSunSpiritGridBase> Pack(FlatBufferBuilder builder, IFindSunSpiritGridBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridBase>);
			}
			return IFindSunSpiritGridBase.CreateIFindSunSpiritGridBase(builder, _o.Type);
		}

		// Token: 0x0400C4BD RID: 50365
		private Table __p;
	}
}
