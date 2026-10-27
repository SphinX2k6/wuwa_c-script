using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5B RID: 23131
	public struct ITempleGuid : IFlatbufferObject
	{
		// Token: 0x1700AE11 RID: 44561
		// (get) Token: 0x060275A8 RID: 161192 RVA: 0x0056A6A7 File Offset: 0x005688A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275A9 RID: 161193 RVA: 0x0056A6B4 File Offset: 0x005688B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275AA RID: 161194 RVA: 0x0056A6BC File Offset: 0x005688BC
		public static ITempleGuid GetRootAsITempleGuid(ByteBuffer _bb)
		{
			return ITempleGuid.GetRootAsITempleGuid(_bb, default(ITempleGuid));
		}

		// Token: 0x060275AB RID: 161195 RVA: 0x0056A6D8 File Offset: 0x005688D8
		public static ITempleGuid GetRootAsITempleGuid(ByteBuffer _bb, ITempleGuid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275AC RID: 161196 RVA: 0x0056A6F5 File Offset: 0x005688F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275AD RID: 161197 RVA: 0x0056A704 File Offset: 0x00568904
		public ITempleGuid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE12 RID: 44562
		// (get) Token: 0x060275AE RID: 161198 RVA: 0x0056A714 File Offset: 0x00568914
		public int TempleGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060275AF RID: 161199 RVA: 0x0056A750 File Offset: 0x00568950
		public static Offset<ITempleGuid> CreateITempleGuid(FlatBufferBuilder builder, int TempleGuid = 0)
		{
			builder.StartTable(1);
			ITempleGuid.AddTempleGuid(builder, TempleGuid);
			return ITempleGuid.EndITempleGuid(builder);
		}

		// Token: 0x060275B0 RID: 161200 RVA: 0x0056A766 File Offset: 0x00568966
		public static void StartITempleGuid(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060275B1 RID: 161201 RVA: 0x0056A76F File Offset: 0x0056896F
		public static void AddTempleGuid(FlatBufferBuilder builder, int templeGuid)
		{
			builder.AddInt(0, templeGuid, 0);
		}

		// Token: 0x060275B2 RID: 161202 RVA: 0x0056A77A File Offset: 0x0056897A
		public static Offset<ITempleGuid> EndITempleGuid(FlatBufferBuilder builder)
		{
			return new Offset<ITempleGuid>(builder.EndTable());
		}

		// Token: 0x060275B3 RID: 161203 RVA: 0x0056A788 File Offset: 0x00568988
		public ITempleGuidT UnPack()
		{
			ITempleGuidT templeGuidT = new ITempleGuidT();
			this.UnPackTo(templeGuidT);
			return templeGuidT;
		}

		// Token: 0x060275B4 RID: 161204 RVA: 0x0056A7A3 File Offset: 0x005689A3
		public void UnPackTo(ITempleGuidT _o)
		{
			_o.TempleGuid = this.TempleGuid;
		}

		// Token: 0x060275B5 RID: 161205 RVA: 0x0056A7B4 File Offset: 0x005689B4
		public static Offset<ITempleGuid> Pack(FlatBufferBuilder builder, ITempleGuidT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITempleGuid>);
			}
			return ITempleGuid.CreateITempleGuid(builder, _o.TempleGuid);
		}

		// Token: 0x0400F0EB RID: 61675
		private Table __p;
	}
}
