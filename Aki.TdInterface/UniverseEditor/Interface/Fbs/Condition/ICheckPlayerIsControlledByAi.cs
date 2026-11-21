using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC5 RID: 20421
	public struct ICheckPlayerIsControlledByAi : IFlatbufferObject
	{
		// Token: 0x17009211 RID: 37393
		// (get) Token: 0x0601FD69 RID: 130409 RVA: 0x0046C25A File Offset: 0x0046A45A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD6A RID: 130410 RVA: 0x0046C267 File Offset: 0x0046A467
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD6B RID: 130411 RVA: 0x0046C270 File Offset: 0x0046A470
		public static ICheckPlayerIsControlledByAi GetRootAsICheckPlayerIsControlledByAi(ByteBuffer _bb)
		{
			return ICheckPlayerIsControlledByAi.GetRootAsICheckPlayerIsControlledByAi(_bb, default(ICheckPlayerIsControlledByAi));
		}

		// Token: 0x0601FD6C RID: 130412 RVA: 0x0046C28C File Offset: 0x0046A48C
		public static ICheckPlayerIsControlledByAi GetRootAsICheckPlayerIsControlledByAi(ByteBuffer _bb, ICheckPlayerIsControlledByAi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD6D RID: 130413 RVA: 0x0046C2A9 File Offset: 0x0046A4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD6E RID: 130414 RVA: 0x0046C2B8 File Offset: 0x0046A4B8
		public ICheckPlayerIsControlledByAi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009212 RID: 37394
		// (get) Token: 0x0601FD6F RID: 130415 RVA: 0x0046C2C8 File Offset: 0x0046A4C8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009213 RID: 37395
		// (get) Token: 0x0601FD70 RID: 130416 RVA: 0x0046C304 File Offset: 0x0046A504
		public bool IsControlledByAi
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FD71 RID: 130417 RVA: 0x0046C343 File Offset: 0x0046A543
		public static Offset<ICheckPlayerIsControlledByAi> CreateICheckPlayerIsControlledByAi(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsControlledByAi = false)
		{
			builder.StartTable(2);
			ICheckPlayerIsControlledByAi.AddIsControlledByAi(builder, IsControlledByAi);
			ICheckPlayerIsControlledByAi.AddType(builder, Type);
			return ICheckPlayerIsControlledByAi.EndICheckPlayerIsControlledByAi(builder);
		}

		// Token: 0x0601FD72 RID: 130418 RVA: 0x0046C360 File Offset: 0x0046A560
		public static void StartICheckPlayerIsControlledByAi(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD73 RID: 130419 RVA: 0x0046C369 File Offset: 0x0046A569
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD74 RID: 130420 RVA: 0x0046C374 File Offset: 0x0046A574
		public static void AddIsControlledByAi(FlatBufferBuilder builder, bool isControlledByAi)
		{
			builder.AddBool(1, isControlledByAi, false);
		}

		// Token: 0x0601FD75 RID: 130421 RVA: 0x0046C37F File Offset: 0x0046A57F
		public static Offset<ICheckPlayerIsControlledByAi> EndICheckPlayerIsControlledByAi(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerIsControlledByAi>(builder.EndTable());
		}

		// Token: 0x0601FD76 RID: 130422 RVA: 0x0046C38C File Offset: 0x0046A58C
		public ICheckPlayerIsControlledByAiT UnPack()
		{
			ICheckPlayerIsControlledByAiT checkPlayerIsControlledByAiT = new ICheckPlayerIsControlledByAiT();
			this.UnPackTo(checkPlayerIsControlledByAiT);
			return checkPlayerIsControlledByAiT;
		}

		// Token: 0x0601FD77 RID: 130423 RVA: 0x0046C3A7 File Offset: 0x0046A5A7
		public void UnPackTo(ICheckPlayerIsControlledByAiT _o)
		{
			_o.Type = this.Type;
			_o.IsControlledByAi = this.IsControlledByAi;
		}

		// Token: 0x0601FD78 RID: 130424 RVA: 0x0046C3C4 File Offset: 0x0046A5C4
		public static Offset<ICheckPlayerIsControlledByAi> Pack(FlatBufferBuilder builder, ICheckPlayerIsControlledByAiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerIsControlledByAi>);
			}
			return ICheckPlayerIsControlledByAi.CreateICheckPlayerIsControlledByAi(builder, _o.Type, _o.IsControlledByAi);
		}

		// Token: 0x0400DE6C RID: 56940
		private Table __p;
	}
}
