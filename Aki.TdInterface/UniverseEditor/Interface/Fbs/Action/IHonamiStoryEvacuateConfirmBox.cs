using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD4 RID: 28628
	public struct IHonamiStoryEvacuateConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700D1B0 RID: 53680
		// (get) Token: 0x06031983 RID: 203139 RVA: 0x006B840E File Offset: 0x006B660E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031984 RID: 203140 RVA: 0x006B841B File Offset: 0x006B661B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031985 RID: 203141 RVA: 0x006B8424 File Offset: 0x006B6624
		public static IHonamiStoryEvacuateConfirmBox GetRootAsIHonamiStoryEvacuateConfirmBox(ByteBuffer _bb)
		{
			return IHonamiStoryEvacuateConfirmBox.GetRootAsIHonamiStoryEvacuateConfirmBox(_bb, default(IHonamiStoryEvacuateConfirmBox));
		}

		// Token: 0x06031986 RID: 203142 RVA: 0x006B8440 File Offset: 0x006B6640
		public static IHonamiStoryEvacuateConfirmBox GetRootAsIHonamiStoryEvacuateConfirmBox(ByteBuffer _bb, IHonamiStoryEvacuateConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031987 RID: 203143 RVA: 0x006B845D File Offset: 0x006B665D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031988 RID: 203144 RVA: 0x006B846C File Offset: 0x006B666C
		public IHonamiStoryEvacuateConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1B1 RID: 53681
		// (get) Token: 0x06031989 RID: 203145 RVA: 0x006B847C File Offset: 0x006B667C
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

		// Token: 0x0603198A RID: 203146 RVA: 0x006B84B8 File Offset: 0x006B66B8
		public static Offset<IHonamiStoryEvacuateConfirmBox> CreateIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common)
		{
			builder.StartTable(1);
			IHonamiStoryEvacuateConfirmBox.AddType(builder, Type);
			return IHonamiStoryEvacuateConfirmBox.EndIHonamiStoryEvacuateConfirmBox(builder);
		}

		// Token: 0x0603198B RID: 203147 RVA: 0x006B84CE File Offset: 0x006B66CE
		public static void StartIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603198C RID: 203148 RVA: 0x006B84D7 File Offset: 0x006B66D7
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603198D RID: 203149 RVA: 0x006B84E2 File Offset: 0x006B66E2
		public static Offset<IHonamiStoryEvacuateConfirmBox> EndIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryEvacuateConfirmBox>(builder.EndTable());
		}

		// Token: 0x0603198E RID: 203150 RVA: 0x006B84F0 File Offset: 0x006B66F0
		public IHonamiStoryEvacuateConfirmBoxT UnPack()
		{
			IHonamiStoryEvacuateConfirmBoxT honamiStoryEvacuateConfirmBoxT = new IHonamiStoryEvacuateConfirmBoxT();
			this.UnPackTo(honamiStoryEvacuateConfirmBoxT);
			return honamiStoryEvacuateConfirmBoxT;
		}

		// Token: 0x0603198F RID: 203151 RVA: 0x006B850B File Offset: 0x006B670B
		public void UnPackTo(IHonamiStoryEvacuateConfirmBoxT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031990 RID: 203152 RVA: 0x006B851C File Offset: 0x006B671C
		public static Offset<IHonamiStoryEvacuateConfirmBox> Pack(FlatBufferBuilder builder, IHonamiStoryEvacuateConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryEvacuateConfirmBox>);
			}
			return IHonamiStoryEvacuateConfirmBox.CreateIHonamiStoryEvacuateConfirmBox(builder, _o.Type);
		}

		// Token: 0x04011F08 RID: 73480
		private Table __p;
	}
}
