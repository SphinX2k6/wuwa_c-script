using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A88 RID: 27272
	public struct IMechStuntBurrow : IFlatbufferObject
	{
		// Token: 0x1700CA7E RID: 51838
		// (get) Token: 0x0602FCBA RID: 195770 RVA: 0x0068117D File Offset: 0x0067F37D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCBB RID: 195771 RVA: 0x0068118A File Offset: 0x0067F38A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCBC RID: 195772 RVA: 0x00681194 File Offset: 0x0067F394
		public static IMechStuntBurrow GetRootAsIMechStuntBurrow(ByteBuffer _bb)
		{
			return IMechStuntBurrow.GetRootAsIMechStuntBurrow(_bb, default(IMechStuntBurrow));
		}

		// Token: 0x0602FCBD RID: 195773 RVA: 0x006811B0 File Offset: 0x0067F3B0
		public static IMechStuntBurrow GetRootAsIMechStuntBurrow(ByteBuffer _bb, IMechStuntBurrow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCBE RID: 195774 RVA: 0x006811CD File Offset: 0x0067F3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCBF RID: 195775 RVA: 0x006811DC File Offset: 0x0067F3DC
		public IMechStuntBurrow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA7F RID: 51839
		// (get) Token: 0x0602FCC0 RID: 195776 RVA: 0x006811EC File Offset: 0x0067F3EC
		public EMechStuntType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechStuntType.Dive;
				}
				return (EMechStuntType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCC1 RID: 195777 RVA: 0x00681228 File Offset: 0x0067F428
		public static Offset<IMechStuntBurrow> CreateIMechStuntBurrow(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntBurrow.AddType(builder, Type);
			return IMechStuntBurrow.EndIMechStuntBurrow(builder);
		}

		// Token: 0x0602FCC2 RID: 195778 RVA: 0x0068123E File Offset: 0x0067F43E
		public static void StartIMechStuntBurrow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FCC3 RID: 195779 RVA: 0x00681247 File Offset: 0x0067F447
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCC4 RID: 195780 RVA: 0x00681252 File Offset: 0x0067F452
		public static Offset<IMechStuntBurrow> EndIMechStuntBurrow(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntBurrow>(builder.EndTable());
		}

		// Token: 0x0602FCC5 RID: 195781 RVA: 0x00681260 File Offset: 0x0067F460
		public IMechStuntBurrowT UnPack()
		{
			IMechStuntBurrowT mechStuntBurrowT = new IMechStuntBurrowT();
			this.UnPackTo(mechStuntBurrowT);
			return mechStuntBurrowT;
		}

		// Token: 0x0602FCC6 RID: 195782 RVA: 0x0068127B File Offset: 0x0067F47B
		public void UnPackTo(IMechStuntBurrowT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FCC7 RID: 195783 RVA: 0x0068128C File Offset: 0x0067F48C
		public static Offset<IMechStuntBurrow> Pack(FlatBufferBuilder builder, IMechStuntBurrowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntBurrow>);
			}
			return IMechStuntBurrow.CreateIMechStuntBurrow(builder, _o.Type);
		}

		// Token: 0x040112C4 RID: 70340
		private Table __p;
	}
}
