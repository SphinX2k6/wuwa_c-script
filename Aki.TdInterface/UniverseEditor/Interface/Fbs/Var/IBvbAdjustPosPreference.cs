using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A24 RID: 14884
	public struct IBvbAdjustPosPreference : IFlatbufferObject
	{
		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x06014211 RID: 82449 RVA: 0x002F1D4E File Offset: 0x002EFF4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014212 RID: 82450 RVA: 0x002F1D5B File Offset: 0x002EFF5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014213 RID: 82451 RVA: 0x002F1D64 File Offset: 0x002EFF64
		public static IBvbAdjustPosPreference GetRootAsIBvbAdjustPosPreference(ByteBuffer _bb)
		{
			return IBvbAdjustPosPreference.GetRootAsIBvbAdjustPosPreference(_bb, default(IBvbAdjustPosPreference));
		}

		// Token: 0x06014214 RID: 82452 RVA: 0x002F1D80 File Offset: 0x002EFF80
		public static IBvbAdjustPosPreference GetRootAsIBvbAdjustPosPreference(ByteBuffer _bb, IBvbAdjustPosPreference obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014215 RID: 82453 RVA: 0x002F1D9D File Offset: 0x002EFF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014216 RID: 82454 RVA: 0x002F1DAC File Offset: 0x002EFFAC
		public IBvbAdjustPosPreference __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x06014217 RID: 82455 RVA: 0x002F1DBC File Offset: 0x002EFFBC
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014218 RID: 82456 RVA: 0x002F1DF8 File Offset: 0x002EFFF8
		public static Offset<IBvbAdjustPosPreference> CreateIBvbAdjustPosPreference(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbAdjustPosPreference.AddType(builder, Type);
			return IBvbAdjustPosPreference.EndIBvbAdjustPosPreference(builder);
		}

		// Token: 0x06014219 RID: 82457 RVA: 0x002F1E0E File Offset: 0x002F000E
		public static void StartIBvbAdjustPosPreference(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601421A RID: 82458 RVA: 0x002F1E17 File Offset: 0x002F0017
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601421B RID: 82459 RVA: 0x002F1E22 File Offset: 0x002F0022
		public static Offset<IBvbAdjustPosPreference> EndIBvbAdjustPosPreference(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAdjustPosPreference>(builder.EndTable());
		}

		// Token: 0x0601421C RID: 82460 RVA: 0x002F1E30 File Offset: 0x002F0030
		public IBvbAdjustPosPreferenceT UnPack()
		{
			IBvbAdjustPosPreferenceT bvbAdjustPosPreferenceT = new IBvbAdjustPosPreferenceT();
			this.UnPackTo(bvbAdjustPosPreferenceT);
			return bvbAdjustPosPreferenceT;
		}

		// Token: 0x0601421D RID: 82461 RVA: 0x002F1E4B File Offset: 0x002F004B
		public void UnPackTo(IBvbAdjustPosPreferenceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601421E RID: 82462 RVA: 0x002F1E5C File Offset: 0x002F005C
		public static Offset<IBvbAdjustPosPreference> Pack(FlatBufferBuilder builder, IBvbAdjustPosPreferenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAdjustPosPreference>);
			}
			return IBvbAdjustPosPreference.CreateIBvbAdjustPosPreference(builder, _o.Type);
		}

		// Token: 0x0400AE9C RID: 44700
		private Table __p;
	}
}
