using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CA RID: 21706
	public struct ILevelAiCycleLooply : IFlatbufferObject
	{
		// Token: 0x17009FF5 RID: 40949
		// (get) Token: 0x06023C5C RID: 146524 RVA: 0x004F216E File Offset: 0x004F036E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C5D RID: 146525 RVA: 0x004F217B File Offset: 0x004F037B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C5E RID: 146526 RVA: 0x004F2184 File Offset: 0x004F0384
		public static ILevelAiCycleLooply GetRootAsILevelAiCycleLooply(ByteBuffer _bb)
		{
			return ILevelAiCycleLooply.GetRootAsILevelAiCycleLooply(_bb, default(ILevelAiCycleLooply));
		}

		// Token: 0x06023C5F RID: 146527 RVA: 0x004F21A0 File Offset: 0x004F03A0
		public static ILevelAiCycleLooply GetRootAsILevelAiCycleLooply(ByteBuffer _bb, ILevelAiCycleLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C60 RID: 146528 RVA: 0x004F21BD File Offset: 0x004F03BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C61 RID: 146529 RVA: 0x004F21CC File Offset: 0x004F03CC
		public ILevelAiCycleLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FF6 RID: 40950
		// (get) Token: 0x06023C62 RID: 146530 RVA: 0x004F21DC File Offset: 0x004F03DC
		public ELevelAiCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAiCycleMode.Loop;
				}
				return (ELevelAiCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009FF7 RID: 40951
		// (get) Token: 0x06023C63 RID: 146531 RVA: 0x004F2218 File Offset: 0x004F0418
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023C64 RID: 146532 RVA: 0x004F2257 File Offset: 0x004F0457
		public static Offset<ILevelAiCycleLooply> CreateILevelAiCycleLooply(FlatBufferBuilder builder, ELevelAiCycleMode Type = ELevelAiCycleMode.Loop, bool IsCircle = false)
		{
			builder.StartTable(2);
			ILevelAiCycleLooply.AddIsCircle(builder, IsCircle);
			ILevelAiCycleLooply.AddType(builder, Type);
			return ILevelAiCycleLooply.EndILevelAiCycleLooply(builder);
		}

		// Token: 0x06023C65 RID: 146533 RVA: 0x004F2274 File Offset: 0x004F0474
		public static void StartILevelAiCycleLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023C66 RID: 146534 RVA: 0x004F227D File Offset: 0x004F047D
		public static void AddType(FlatBufferBuilder builder, ELevelAiCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C67 RID: 146535 RVA: 0x004F2288 File Offset: 0x004F0488
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(1, isCircle, false);
		}

		// Token: 0x06023C68 RID: 146536 RVA: 0x004F2293 File Offset: 0x004F0493
		public static Offset<ILevelAiCycleLooply> EndILevelAiCycleLooply(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiCycleLooply>(builder.EndTable());
		}

		// Token: 0x06023C69 RID: 146537 RVA: 0x004F22A0 File Offset: 0x004F04A0
		public ILevelAiCycleLooplyT UnPack()
		{
			ILevelAiCycleLooplyT levelAiCycleLooplyT = new ILevelAiCycleLooplyT();
			this.UnPackTo(levelAiCycleLooplyT);
			return levelAiCycleLooplyT;
		}

		// Token: 0x06023C6A RID: 146538 RVA: 0x004F22BB File Offset: 0x004F04BB
		public void UnPackTo(ILevelAiCycleLooplyT _o)
		{
			_o.Type = this.Type;
			_o.IsCircle = this.IsCircle;
		}

		// Token: 0x06023C6B RID: 146539 RVA: 0x004F22D8 File Offset: 0x004F04D8
		public static Offset<ILevelAiCycleLooply> Pack(FlatBufferBuilder builder, ILevelAiCycleLooplyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiCycleLooply>);
			}
			return ILevelAiCycleLooply.CreateILevelAiCycleLooply(builder, _o.Type, _o.IsCircle);
		}

		// Token: 0x0400E788 RID: 59272
		private Table __p;
	}
}
