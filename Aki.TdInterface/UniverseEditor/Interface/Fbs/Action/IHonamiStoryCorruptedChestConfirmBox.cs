using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691B RID: 26907
	public struct IHonamiStoryCorruptedChestConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700C7A3 RID: 51107
		// (get) Token: 0x0602EF87 RID: 192391 RVA: 0x00667B26 File Offset: 0x00665D26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF88 RID: 192392 RVA: 0x00667B33 File Offset: 0x00665D33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF89 RID: 192393 RVA: 0x00667B3C File Offset: 0x00665D3C
		public static IHonamiStoryCorruptedChestConfirmBox GetRootAsIHonamiStoryCorruptedChestConfirmBox(ByteBuffer _bb)
		{
			return IHonamiStoryCorruptedChestConfirmBox.GetRootAsIHonamiStoryCorruptedChestConfirmBox(_bb, default(IHonamiStoryCorruptedChestConfirmBox));
		}

		// Token: 0x0602EF8A RID: 192394 RVA: 0x00667B58 File Offset: 0x00665D58
		public static IHonamiStoryCorruptedChestConfirmBox GetRootAsIHonamiStoryCorruptedChestConfirmBox(ByteBuffer _bb, IHonamiStoryCorruptedChestConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF8B RID: 192395 RVA: 0x00667B75 File Offset: 0x00665D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF8C RID: 192396 RVA: 0x00667B84 File Offset: 0x00665D84
		public IHonamiStoryCorruptedChestConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7A4 RID: 51108
		// (get) Token: 0x0602EF8D RID: 192397 RVA: 0x00667B94 File Offset: 0x00665D94
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

		// Token: 0x1700C7A5 RID: 51109
		// (get) Token: 0x0602EF8E RID: 192398 RVA: 0x00667BD0 File Offset: 0x00665DD0
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

		// Token: 0x0602EF8F RID: 192399 RVA: 0x00667C0C File Offset: 0x00665E0C
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> CreateIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common, int Id = 0)
		{
			builder.StartTable(2);
			IHonamiStoryCorruptedChestConfirmBox.AddId(builder, Id);
			IHonamiStoryCorruptedChestConfirmBox.AddType(builder, Type);
			return IHonamiStoryCorruptedChestConfirmBox.EndIHonamiStoryCorruptedChestConfirmBox(builder);
		}

		// Token: 0x0602EF90 RID: 192400 RVA: 0x00667C29 File Offset: 0x00665E29
		public static void StartIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EF91 RID: 192401 RVA: 0x00667C32 File Offset: 0x00665E32
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EF92 RID: 192402 RVA: 0x00667C3D File Offset: 0x00665E3D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602EF93 RID: 192403 RVA: 0x00667C48 File Offset: 0x00665E48
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> EndIHonamiStoryCorruptedChestConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryCorruptedChestConfirmBox>(builder.EndTable());
		}

		// Token: 0x0602EF94 RID: 192404 RVA: 0x00667C58 File Offset: 0x00665E58
		public IHonamiStoryCorruptedChestConfirmBoxT UnPack()
		{
			IHonamiStoryCorruptedChestConfirmBoxT honamiStoryCorruptedChestConfirmBoxT = new IHonamiStoryCorruptedChestConfirmBoxT();
			this.UnPackTo(honamiStoryCorruptedChestConfirmBoxT);
			return honamiStoryCorruptedChestConfirmBoxT;
		}

		// Token: 0x0602EF95 RID: 192405 RVA: 0x00667C73 File Offset: 0x00665E73
		public void UnPackTo(IHonamiStoryCorruptedChestConfirmBoxT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602EF96 RID: 192406 RVA: 0x00667C90 File Offset: 0x00665E90
		public static Offset<IHonamiStoryCorruptedChestConfirmBox> Pack(FlatBufferBuilder builder, IHonamiStoryCorruptedChestConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryCorruptedChestConfirmBox>);
			}
			return IHonamiStoryCorruptedChestConfirmBox.CreateIHonamiStoryCorruptedChestConfirmBox(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011096 RID: 69782
		private Table __p;
	}
}
