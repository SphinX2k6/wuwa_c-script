using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768D RID: 30349
	public struct IRoverRogueActivate : IFlatbufferObject
	{
		// Token: 0x1700DEB5 RID: 57013
		// (get) Token: 0x060353D0 RID: 218064 RVA: 0x00724F0D File Offset: 0x0072310D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060353D1 RID: 218065 RVA: 0x00724F1A File Offset: 0x0072311A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060353D2 RID: 218066 RVA: 0x00724F24 File Offset: 0x00723124
		public static IRoverRogueActivate GetRootAsIRoverRogueActivate(ByteBuffer _bb)
		{
			return IRoverRogueActivate.GetRootAsIRoverRogueActivate(_bb, default(IRoverRogueActivate));
		}

		// Token: 0x060353D3 RID: 218067 RVA: 0x00724F40 File Offset: 0x00723140
		public static IRoverRogueActivate GetRootAsIRoverRogueActivate(ByteBuffer _bb, IRoverRogueActivate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060353D4 RID: 218068 RVA: 0x00724F5D File Offset: 0x0072315D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060353D5 RID: 218069 RVA: 0x00724F6C File Offset: 0x0072316C
		public IRoverRogueActivate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEB6 RID: 57014
		// (get) Token: 0x060353D6 RID: 218070 RVA: 0x00724F7C File Offset: 0x0072317C
		public ERoverRogueActivateType InteractType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoverRogueActivateType.Shop;
				}
				return (ERoverRogueActivateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353D7 RID: 218071 RVA: 0x00724FB8 File Offset: 0x007231B8
		public static Offset<IRoverRogueActivate> CreateIRoverRogueActivate(FlatBufferBuilder builder, ERoverRogueActivateType InteractType = ERoverRogueActivateType.Shop)
		{
			builder.StartTable(1);
			IRoverRogueActivate.AddInteractType(builder, InteractType);
			return IRoverRogueActivate.EndIRoverRogueActivate(builder);
		}

		// Token: 0x060353D8 RID: 218072 RVA: 0x00724FCE File Offset: 0x007231CE
		public static void StartIRoverRogueActivate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060353D9 RID: 218073 RVA: 0x00724FD7 File Offset: 0x007231D7
		public static void AddInteractType(FlatBufferBuilder builder, ERoverRogueActivateType interactType)
		{
			builder.AddByte(0, (byte)interactType, 0);
		}

		// Token: 0x060353DA RID: 218074 RVA: 0x00724FE2 File Offset: 0x007231E2
		public static Offset<IRoverRogueActivate> EndIRoverRogueActivate(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueActivate>(builder.EndTable());
		}

		// Token: 0x060353DB RID: 218075 RVA: 0x00724FF0 File Offset: 0x007231F0
		public IRoverRogueActivateT UnPack()
		{
			IRoverRogueActivateT roverRogueActivateT = new IRoverRogueActivateT();
			this.UnPackTo(roverRogueActivateT);
			return roverRogueActivateT;
		}

		// Token: 0x060353DC RID: 218076 RVA: 0x0072500B File Offset: 0x0072320B
		public void UnPackTo(IRoverRogueActivateT _o)
		{
			_o.InteractType = this.InteractType;
		}

		// Token: 0x060353DD RID: 218077 RVA: 0x0072501C File Offset: 0x0072321C
		public static Offset<IRoverRogueActivate> Pack(FlatBufferBuilder builder, IRoverRogueActivateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueActivate>);
			}
			return IRoverRogueActivate.CreateIRoverRogueActivate(builder, _o.InteractType);
		}

		// Token: 0x0401287D RID: 75901
		private Table __p;
	}
}
