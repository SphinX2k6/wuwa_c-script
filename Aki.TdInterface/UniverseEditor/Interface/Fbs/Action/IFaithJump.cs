using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1B RID: 28187
	public struct IFaithJump : IFlatbufferObject
	{
		// Token: 0x1700CE99 RID: 52889
		// (get) Token: 0x06030AB2 RID: 199346 RVA: 0x0069B354 File Offset: 0x00699554
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030AB3 RID: 199347 RVA: 0x0069B361 File Offset: 0x00699561
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030AB4 RID: 199348 RVA: 0x0069B368 File Offset: 0x00699568
		public static IFaithJump GetRootAsIFaithJump(ByteBuffer _bb)
		{
			return IFaithJump.GetRootAsIFaithJump(_bb, default(IFaithJump));
		}

		// Token: 0x06030AB5 RID: 199349 RVA: 0x0069B384 File Offset: 0x00699584
		public static IFaithJump GetRootAsIFaithJump(ByteBuffer _bb, IFaithJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AB6 RID: 199350 RVA: 0x0069B3A1 File Offset: 0x006995A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AB7 RID: 199351 RVA: 0x0069B3B0 File Offset: 0x006995B0
		public IFaithJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE9A RID: 52890
		// (get) Token: 0x06030AB8 RID: 199352 RVA: 0x0069B3C0 File Offset: 0x006995C0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030AB9 RID: 199353 RVA: 0x0069B3FC File Offset: 0x006995FC
		public static Offset<IFaithJump> CreateIFaithJump(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IFaithJump.AddType(builder, Type);
			return IFaithJump.EndIFaithJump(builder);
		}

		// Token: 0x06030ABA RID: 199354 RVA: 0x0069B412 File Offset: 0x00699612
		public static void StartIFaithJump(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030ABB RID: 199355 RVA: 0x0069B41B File Offset: 0x0069961B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030ABC RID: 199356 RVA: 0x0069B426 File Offset: 0x00699626
		public static Offset<IFaithJump> EndIFaithJump(FlatBufferBuilder builder)
		{
			return new Offset<IFaithJump>(builder.EndTable());
		}

		// Token: 0x06030ABD RID: 199357 RVA: 0x0069B434 File Offset: 0x00699634
		public IFaithJumpT UnPack()
		{
			IFaithJumpT faithJumpT = new IFaithJumpT();
			this.UnPackTo(faithJumpT);
			return faithJumpT;
		}

		// Token: 0x06030ABE RID: 199358 RVA: 0x0069B44F File Offset: 0x0069964F
		public void UnPackTo(IFaithJumpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030ABF RID: 199359 RVA: 0x0069B460 File Offset: 0x00699660
		public static Offset<IFaithJump> Pack(FlatBufferBuilder builder, IFaithJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaithJump>);
			}
			return IFaithJump.CreateIFaithJump(builder, _o.Type);
		}

		// Token: 0x04011CDC RID: 72924
		private Table __p;
	}
}
