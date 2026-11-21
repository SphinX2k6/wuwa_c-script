using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCE RID: 28622
	public struct IHonamiStoryCorruptedChestConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700D1A6 RID: 53670
		// (get) Token: 0x06031957 RID: 203095 RVA: 0x006B800E File Offset: 0x006B620E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031958 RID: 203096 RVA: 0x006B801B File Offset: 0x006B621B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031959 RID: 203097 RVA: 0x006B8024 File Offset: 0x006B6224
		public static IHonamiStoryCorruptedChestConfirmBox GetRootAsIHonamiStoryCorruptedChestConfirmBox(ByteBuffer _bb)
		{
			return IHonamiStoryCorruptedChestConfirmBox.GetRootAsIHonamiStoryCorruptedChestConfirmBox(_bb, default(IHonamiStoryCorruptedChestConfirmBox));
		}

		// Token: 0x0603195A RID: 203098 RVA: 0x006B8040 File Offset: 0x006B6240
		public static IHonamiStoryCorruptedChestConfirmBox GetRootAsIHonamiStoryCorruptedChestConfirmBox(ByteBuffer _bb, IHonamiStoryCorruptedChestConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603195B RID: 203099 RVA: 0x006B805D File Offset: 0x006B625D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603195C RID: 203100 RVA: 0x006B806C File Offset: 0x006B626C
		public IHonamiStoryCorruptedChestConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1A7 RID: 53671
		// (get) Token: 0x0603195D RID: 203101 RVA: 0x006B807C File Offset: 0x006B627C
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1A8 RID: 53672
		// (get) Token: 0x0603195E RID: 203102 RVA: 0x006B80B8 File Offset: 0x006B62B8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603195F RID: 203103 RVA: 0x006B80F4 File Offset: 0x006B62F4
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> CreateIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common, int Id = 0)
		{
			builder.StartTable(2);
			IHonamiStoryCorruptedChestConfirmBox.AddId(builder, Id);
			IHonamiStoryCorruptedChestConfirmBox.AddType(builder, Type);
			return IHonamiStoryCorruptedChestConfirmBox.EndIHonamiStoryCorruptedChestConfirmBox(builder);
		}

		// Token: 0x06031960 RID: 203104 RVA: 0x006B8111 File Offset: 0x006B6311
		public static void StartIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031961 RID: 203105 RVA: 0x006B811A File Offset: 0x006B631A
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031962 RID: 203106 RVA: 0x006B8125 File Offset: 0x006B6325
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031963 RID: 203107 RVA: 0x006B8130 File Offset: 0x006B6330
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> EndIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryCorruptedChestConfirmBox>(builder.EndTable());
		}

		// Token: 0x06031964 RID: 203108 RVA: 0x006B8140 File Offset: 0x006B6340
		public IHonamiStoryCorruptedChestConfirmBoxT UnPack()
		{
			IHonamiStoryCorruptedChestConfirmBoxT honamiStoryCorruptedChestConfirmBoxT = new IHonamiStoryCorruptedChestConfirmBoxT();
			this.UnPackTo(honamiStoryCorruptedChestConfirmBoxT);
			return honamiStoryCorruptedChestConfirmBoxT;
		}

		// Token: 0x06031965 RID: 203109 RVA: 0x006B815B File Offset: 0x006B635B
		public void UnPackTo(IHonamiStoryCorruptedChestConfirmBoxT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06031966 RID: 203110 RVA: 0x006B8178 File Offset: 0x006B6378
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> Pack(FlatBufferBuilder builder, IHonamiStoryCorruptedChestConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryCorruptedChestConfirmBox>);
			}
			return IHonamiStoryCorruptedChestConfirmBox.CreateIHonamiStoryCorruptedChestConfirmBox(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011F02 RID: 73474
		private Table __p;
	}
}
