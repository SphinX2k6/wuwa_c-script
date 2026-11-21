using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A50 RID: 23120
	public struct ILevelAiCycleLooply : IFlatbufferObject
	{
		// Token: 0x1700A82F RID: 43055
		// (get) Token: 0x06025D14 RID: 154900 RVA: 0x0052F1E2 File Offset: 0x0052D3E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D15 RID: 154901 RVA: 0x0052F1EF File Offset: 0x0052D3EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D16 RID: 154902 RVA: 0x0052F1F8 File Offset: 0x0052D3F8
		public static ILevelAiCycleLooply GetRootAsILevelAiCycleLooply(ByteBuffer _bb)
		{
			return ILevelAiCycleLooply.GetRootAsILevelAiCycleLooply(_bb, default(ILevelAiCycleLooply));
		}

		// Token: 0x06025D17 RID: 154903 RVA: 0x0052F214 File Offset: 0x0052D414
		public static ILevelAiCycleLooply GetRootAsILevelAiCycleLooply(ByteBuffer _bb, ILevelAiCycleLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D18 RID: 154904 RVA: 0x0052F231 File Offset: 0x0052D431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D19 RID: 154905 RVA: 0x0052F240 File Offset: 0x0052D440
		public ILevelAiCycleLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A830 RID: 43056
		// (get) Token: 0x06025D1A RID: 154906 RVA: 0x0052F250 File Offset: 0x0052D450
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

		// Token: 0x1700A831 RID: 43057
		// (get) Token: 0x06025D1B RID: 154907 RVA: 0x0052F28C File Offset: 0x0052D48C
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025D1C RID: 154908 RVA: 0x0052F2CB File Offset: 0x0052D4CB
		public static Offset<ILevelAiCycleLooply> CreateILevelAiCycleLooply(FlatBufferBuilder builder, ELevelAiCycleMode Type = ELevelAiCycleMode.Loop, bool IsCircle = false)
		{
			builder.StartTable(2);
			ILevelAiCycleLooply.AddIsCircle(builder, IsCircle);
			ILevelAiCycleLooply.AddType(builder, Type);
			return ILevelAiCycleLooply.EndILevelAiCycleLooply(builder);
		}

		// Token: 0x06025D1D RID: 154909 RVA: 0x0052F2E8 File Offset: 0x0052D4E8
		public static void StartILevelAiCycleLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D1E RID: 154910 RVA: 0x0052F2F1 File Offset: 0x0052D4F1
		public static void AddType(FlatBufferBuilder builder, ELevelAiCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x0052F2FC File Offset: 0x0052D4FC
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(1, isCircle, false);
		}

		// Token: 0x06025D20 RID: 154912 RVA: 0x0052F307 File Offset: 0x0052D507
		public static Offset<ILevelAiCycleLooply> EndILevelAiCycleLooply(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiCycleLooply>(builder.EndTable());
		}

		// Token: 0x06025D21 RID: 154913 RVA: 0x0052F314 File Offset: 0x0052D514
		public ILevelAiCycleLooplyT UnPack()
		{
			ILevelAiCycleLooplyT levelAiCycleLooplyT = new ILevelAiCycleLooplyT();
			this.UnPackTo(levelAiCycleLooplyT);
			return levelAiCycleLooplyT;
		}

		// Token: 0x06025D22 RID: 154914 RVA: 0x0052F32F File Offset: 0x0052D52F
		public void UnPackTo(ILevelAiCycleLooplyT _o)
		{
			_o.Type = this.Type;
			_o.IsCircle = this.IsCircle;
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x0052F34C File Offset: 0x0052D54C
		public static Offset<ILevelAiCycleLooply> Pack(FlatBufferBuilder builder, ILevelAiCycleLooplyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiCycleLooply>);
			}
			return ILevelAiCycleLooply.CreateILevelAiCycleLooply(builder, _o.Type, _o.IsCircle);
		}

		// Token: 0x0400F3B9 RID: 62393
		private Table __p;
	}
}
