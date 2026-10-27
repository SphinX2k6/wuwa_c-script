using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F06 RID: 28422
	public struct IRoverRogueActivate : IFlatbufferObject
	{
		// Token: 0x1700D359 RID: 54105
		// (get) Token: 0x06032378 RID: 205688 RVA: 0x006C8FA5 File Offset: 0x006C71A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032379 RID: 205689 RVA: 0x006C8FB2 File Offset: 0x006C71B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603237A RID: 205690 RVA: 0x006C8FBC File Offset: 0x006C71BC
		public static IRoverRogueActivate GetRootAsIRoverRogueActivate(ByteBuffer _bb)
		{
			return IRoverRogueActivate.GetRootAsIRoverRogueActivate(_bb, default(IRoverRogueActivate));
		}

		// Token: 0x0603237B RID: 205691 RVA: 0x006C8FD8 File Offset: 0x006C71D8
		public static IRoverRogueActivate GetRootAsIRoverRogueActivate(ByteBuffer _bb, IRoverRogueActivate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603237C RID: 205692 RVA: 0x006C8FF5 File Offset: 0x006C71F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603237D RID: 205693 RVA: 0x006C9004 File Offset: 0x006C7204
		public IRoverRogueActivate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D35A RID: 54106
		// (get) Token: 0x0603237E RID: 205694 RVA: 0x006C9014 File Offset: 0x006C7214
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

		// Token: 0x0603237F RID: 205695 RVA: 0x006C9050 File Offset: 0x006C7250
		public static Offset<IRoverRogueActivate> CreateIRoverRogueActivate(FlatBufferBuilder builder, ERoverRogueActivateType InteractType = ERoverRogueActivateType.Shop)
		{
			builder.StartTable(1);
			IRoverRogueActivate.AddInteractType(builder, InteractType);
			return IRoverRogueActivate.EndIRoverRogueActivate(builder);
		}

		// Token: 0x06032380 RID: 205696 RVA: 0x006C9066 File Offset: 0x006C7266
		public static void StartIRoverRogueActivate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032381 RID: 205697 RVA: 0x006C906F File Offset: 0x006C726F
		public static void AddInteractType(FlatBufferBuilder builder, ERoverRogueActivateType interactType)
		{
			builder.AddByte(0, (byte)interactType, 0);
		}

		// Token: 0x06032382 RID: 205698 RVA: 0x006C907A File Offset: 0x006C727A
		public static Offset<IRoverRogueActivate> EndIRoverRogueActivate(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueActivate>(builder.EndTable());
		}

		// Token: 0x06032383 RID: 205699 RVA: 0x006C9088 File Offset: 0x006C7288
		public IRoverRogueActivateT UnPack()
		{
			IRoverRogueActivateT roverRogueActivateT = new IRoverRogueActivateT();
			this.UnPackTo(roverRogueActivateT);
			return roverRogueActivateT;
		}

		// Token: 0x06032384 RID: 205700 RVA: 0x006C90A3 File Offset: 0x006C72A3
		public void UnPackTo(IRoverRogueActivateT _o)
		{
			_o.InteractType = this.InteractType;
		}

		// Token: 0x06032385 RID: 205701 RVA: 0x006C90B4 File Offset: 0x006C72B4
		public static Offset<IRoverRogueActivate> Pack(FlatBufferBuilder builder, IRoverRogueActivateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueActivate>);
			}
			return IRoverRogueActivate.CreateIRoverRogueActivate(builder, _o.InteractType);
		}

		// Token: 0x040118F5 RID: 71925
		private Table __p;
	}
}
