using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C95 RID: 27797
	public struct IEaseData : IFlatbufferObject
	{
		// Token: 0x1700CBE0 RID: 52192
		// (get) Token: 0x0602FE48 RID: 196168 RVA: 0x006853E4 File Offset: 0x006835E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE49 RID: 196169 RVA: 0x006853F1 File Offset: 0x006835F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE4A RID: 196170 RVA: 0x006853F8 File Offset: 0x006835F8
		public static IEaseData GetRootAsIEaseData(ByteBuffer _bb)
		{
			return IEaseData.GetRootAsIEaseData(_bb, default(IEaseData));
		}

		// Token: 0x0602FE4B RID: 196171 RVA: 0x00685414 File Offset: 0x00683614
		public static IEaseData GetRootAsIEaseData(ByteBuffer _bb, IEaseData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE4C RID: 196172 RVA: 0x00685431 File Offset: 0x00683631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE4D RID: 196173 RVA: 0x00685440 File Offset: 0x00683640
		public IEaseData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBE1 RID: 52193
		// (get) Token: 0x0602FE4E RID: 196174 RVA: 0x00685450 File Offset: 0x00683650
		public EEaseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseType.Linear;
				}
				return (EEaseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBE2 RID: 52194
		// (get) Token: 0x0602FE4F RID: 196175 RVA: 0x0068548C File Offset: 0x0068368C
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE50 RID: 196176 RVA: 0x006854CC File Offset: 0x006836CC
		public static Offset<IEaseData> CreateIEaseData(FlatBufferBuilder builder, EEaseType Type = EEaseType.Linear, float Duration = 0f)
		{
			builder.StartTable(2);
			IEaseData.AddDuration(builder, Duration);
			IEaseData.AddType(builder, Type);
			return IEaseData.EndIEaseData(builder);
		}

		// Token: 0x0602FE51 RID: 196177 RVA: 0x006854E9 File Offset: 0x006836E9
		public static void StartIEaseData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FE52 RID: 196178 RVA: 0x006854F2 File Offset: 0x006836F2
		public static void AddType(FlatBufferBuilder builder, EEaseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE53 RID: 196179 RVA: 0x006854FD File Offset: 0x006836FD
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602FE54 RID: 196180 RVA: 0x00685510 File Offset: 0x00683710
		public static Offset<IEaseData> EndIEaseData(FlatBufferBuilder builder)
		{
			return new Offset<IEaseData>(builder.EndTable());
		}

		// Token: 0x0602FE55 RID: 196181 RVA: 0x00685520 File Offset: 0x00683720
		public IEaseDataT UnPack()
		{
			IEaseDataT easeDataT = new IEaseDataT();
			this.UnPackTo(easeDataT);
			return easeDataT;
		}

		// Token: 0x0602FE56 RID: 196182 RVA: 0x0068553B File Offset: 0x0068373B
		public void UnPackTo(IEaseDataT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0602FE57 RID: 196183 RVA: 0x00685558 File Offset: 0x00683758
		public static Offset<IEaseData> Pack(FlatBufferBuilder builder, IEaseDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseData>);
			}
			return IEaseData.CreateIEaseData(builder, _o.Type, _o.Duration);
		}

		// Token: 0x04011ACF RID: 72399
		private Table __p;
	}
}
