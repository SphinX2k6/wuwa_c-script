using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD3 RID: 23507
	public struct INpcPerformOnInteract : IFlatbufferObject
	{
		// Token: 0x1700AC02 RID: 44034
		// (get) Token: 0x06026CEA RID: 158954 RVA: 0x0055087C File Offset: 0x0054EA7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026CEB RID: 158955 RVA: 0x00550889 File Offset: 0x0054EA89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026CEC RID: 158956 RVA: 0x00550890 File Offset: 0x0054EA90
		public static INpcPerformOnInteract GetRootAsINpcPerformOnInteract(ByteBuffer _bb)
		{
			return INpcPerformOnInteract.GetRootAsINpcPerformOnInteract(_bb, default(INpcPerformOnInteract));
		}

		// Token: 0x06026CED RID: 158957 RVA: 0x005508AC File Offset: 0x0054EAAC
		public static INpcPerformOnInteract GetRootAsINpcPerformOnInteract(ByteBuffer _bb, INpcPerformOnInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026CEE RID: 158958 RVA: 0x005508C9 File Offset: 0x0054EAC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026CEF RID: 158959 RVA: 0x005508D8 File Offset: 0x0054EAD8
		public INpcPerformOnInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC03 RID: 44035
		// (get) Token: 0x06026CF0 RID: 158960 RVA: 0x005508E8 File Offset: 0x0054EAE8
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026CF1 RID: 158961 RVA: 0x0055091F File Offset: 0x0054EB1F
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026CF2 RID: 158962 RVA: 0x0055092E File Offset: 0x0054EB2E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC04 RID: 44036
		// (get) Token: 0x06026CF3 RID: 158963 RVA: 0x0055093C File Offset: 0x0054EB3C
		public bool NotInterruptMontageWhenFinishedInteract
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC05 RID: 44037
		// (get) Token: 0x06026CF4 RID: 158964 RVA: 0x0055097C File Offset: 0x0054EB7C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026CF5 RID: 158965 RVA: 0x005509B8 File Offset: 0x0054EBB8
		public static Offset<INpcPerformOnInteract> CreateINpcPerformOnInteract(FlatBufferBuilder builder, StringOffset MontageOffset = default(StringOffset), bool NotInterruptMontageWhenFinishedInteract = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcPerformOnInteract.AddMontage(builder, MontageOffset);
			INpcPerformOnInteract.AddNullMask(builder, NullMask);
			INpcPerformOnInteract.AddNotInterruptMontageWhenFinishedInteract(builder, NotInterruptMontageWhenFinishedInteract);
			return INpcPerformOnInteract.EndINpcPerformOnInteract(builder);
		}

		// Token: 0x06026CF6 RID: 158966 RVA: 0x005509DC File Offset: 0x0054EBDC
		public static void StartINpcPerformOnInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026CF7 RID: 158967 RVA: 0x005509E5 File Offset: 0x0054EBE5
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x06026CF8 RID: 158968 RVA: 0x005509F5 File Offset: 0x0054EBF5
		public static void AddNotInterruptMontageWhenFinishedInteract(FlatBufferBuilder builder, bool notInterruptMontageWhenFinishedInteract)
		{
			builder.AddBool(1, notInterruptMontageWhenFinishedInteract, false);
		}

		// Token: 0x06026CF9 RID: 158969 RVA: 0x00550A00 File Offset: 0x0054EC00
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026CFA RID: 158970 RVA: 0x00550A0B File Offset: 0x0054EC0B
		public static Offset<INpcPerformOnInteract> EndINpcPerformOnInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformOnInteract>(builder.EndTable());
		}

		// Token: 0x06026CFB RID: 158971 RVA: 0x00550A18 File Offset: 0x0054EC18
		public INpcPerformOnInteractT UnPack()
		{
			INpcPerformOnInteractT npcPerformOnInteractT = new INpcPerformOnInteractT();
			this.UnPackTo(npcPerformOnInteractT);
			return npcPerformOnInteractT;
		}

		// Token: 0x06026CFC RID: 158972 RVA: 0x00550A33 File Offset: 0x0054EC33
		public void UnPackTo(INpcPerformOnInteractT _o)
		{
			_o.Montage = this.Montage;
			_o.NotInterruptMontageWhenFinishedInteract = this.NotInterruptMontageWhenFinishedInteract;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026CFD RID: 158973 RVA: 0x00550A5C File Offset: 0x0054EC5C
		public static Offset<INpcPerformOnInteract> Pack(FlatBufferBuilder builder, INpcPerformOnInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformOnInteract>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcPerformOnInteract.CreateINpcPerformOnInteract(builder, montageOffset, _o.NotInterruptMontageWhenFinishedInteract, _o.NullMask);
		}

		// Token: 0x0400F63C RID: 63036
		private Table __p;
	}
}
