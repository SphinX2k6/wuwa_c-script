using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715A RID: 29018
	public struct ILongPressButtonActionMapping : IFlatbufferObject
	{
		// Token: 0x1700D459 RID: 54361
		// (get) Token: 0x06032690 RID: 206480 RVA: 0x006D0378 File Offset: 0x006CE578
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032691 RID: 206481 RVA: 0x006D0385 File Offset: 0x006CE585
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032692 RID: 206482 RVA: 0x006D038C File Offset: 0x006CE58C
		public static ILongPressButtonActionMapping GetRootAsILongPressButtonActionMapping(ByteBuffer _bb)
		{
			return ILongPressButtonActionMapping.GetRootAsILongPressButtonActionMapping(_bb, default(ILongPressButtonActionMapping));
		}

		// Token: 0x06032693 RID: 206483 RVA: 0x006D03A8 File Offset: 0x006CE5A8
		public static ILongPressButtonActionMapping GetRootAsILongPressButtonActionMapping(ByteBuffer _bb, ILongPressButtonActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032694 RID: 206484 RVA: 0x006D03C5 File Offset: 0x006CE5C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032695 RID: 206485 RVA: 0x006D03D4 File Offset: 0x006CE5D4
		public ILongPressButtonActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D45A RID: 54362
		// (get) Token: 0x06032696 RID: 206486 RVA: 0x006D03E4 File Offset: 0x006CE5E4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D45B RID: 54363
		// (get) Token: 0x06032697 RID: 206487 RVA: 0x006D0420 File Offset: 0x006CE620
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032698 RID: 206488 RVA: 0x006D0457 File Offset: 0x006CE657
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032699 RID: 206489 RVA: 0x006D0466 File Offset: 0x006CE666
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603269A RID: 206490 RVA: 0x006D0474 File Offset: 0x006CE674
		public static Offset<ILongPressButtonActionMapping> CreateILongPressButtonActionMapping(FlatBufferBuilder builder, int Id = 0, StringOffset ActionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILongPressButtonActionMapping.AddActionName(builder, ActionNameOffset);
			ILongPressButtonActionMapping.AddId(builder, Id);
			return ILongPressButtonActionMapping.EndILongPressButtonActionMapping(builder);
		}

		// Token: 0x0603269B RID: 206491 RVA: 0x006D0491 File Offset: 0x006CE691
		public static void StartILongPressButtonActionMapping(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603269C RID: 206492 RVA: 0x006D049A File Offset: 0x006CE69A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0603269D RID: 206493 RVA: 0x006D04A5 File Offset: 0x006CE6A5
		public static void AddActionName(FlatBufferBuilder builder, StringOffset actionNameOffset)
		{
			builder.AddOffset(1, actionNameOffset.Value, 0);
		}

		// Token: 0x0603269E RID: 206494 RVA: 0x006D04B5 File Offset: 0x006CE6B5
		public static Offset<ILongPressButtonActionMapping> EndILongPressButtonActionMapping(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressButtonActionMapping>(builder.EndTable());
		}

		// Token: 0x0603269F RID: 206495 RVA: 0x006D04C4 File Offset: 0x006CE6C4
		public ILongPressButtonActionMappingT UnPack()
		{
			ILongPressButtonActionMappingT longPressButtonActionMappingT = new ILongPressButtonActionMappingT();
			this.UnPackTo(longPressButtonActionMappingT);
			return longPressButtonActionMappingT;
		}

		// Token: 0x060326A0 RID: 206496 RVA: 0x006D04DF File Offset: 0x006CE6DF
		public void UnPackTo(ILongPressButtonActionMappingT _o)
		{
			_o.Id = this.Id;
			_o.ActionName = this.ActionName;
		}

		// Token: 0x060326A1 RID: 206497 RVA: 0x006D04FC File Offset: 0x006CE6FC
		public static Offset<ILongPressButtonActionMapping> Pack(FlatBufferBuilder builder, ILongPressButtonActionMappingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressButtonActionMapping>);
			}
			StringOffset actionNameOffset = (_o.ActionName == null) ? default(StringOffset) : builder.CreateString(_o.ActionName);
			return ILongPressButtonActionMapping.CreateILongPressButtonActionMapping(builder, _o.Id, actionNameOffset);
		}

		// Token: 0x0401213F RID: 74047
		private Table __p;
	}
}
