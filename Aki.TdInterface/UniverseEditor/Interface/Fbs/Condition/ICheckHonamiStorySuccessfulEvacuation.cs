using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A63 RID: 19043
	public struct ICheckHonamiStorySuccessfulEvacuation : IFlatbufferObject
	{
		// Token: 0x170089E1 RID: 35297
		// (get) Token: 0x0601DD48 RID: 122184 RVA: 0x00431138 File Offset: 0x0042F338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD49 RID: 122185 RVA: 0x00431145 File Offset: 0x0042F345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD4A RID: 122186 RVA: 0x0043114C File Offset: 0x0042F34C
		public static ICheckHonamiStorySuccessfulEvacuation GetRootAsICheckHonamiStorySuccessfulEvacuation(ByteBuffer _bb)
		{
			return ICheckHonamiStorySuccessfulEvacuation.GetRootAsICheckHonamiStorySuccessfulEvacuation(_bb, default(ICheckHonamiStorySuccessfulEvacuation));
		}

		// Token: 0x0601DD4B RID: 122187 RVA: 0x00431168 File Offset: 0x0042F368
		public static ICheckHonamiStorySuccessfulEvacuation GetRootAsICheckHonamiStorySuccessfulEvacuation(ByteBuffer _bb, ICheckHonamiStorySuccessfulEvacuation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD4C RID: 122188 RVA: 0x00431185 File Offset: 0x0042F385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD4D RID: 122189 RVA: 0x00431194 File Offset: 0x0042F394
		public ICheckHonamiStorySuccessfulEvacuation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089E2 RID: 35298
		// (get) Token: 0x0601DD4E RID: 122190 RVA: 0x004311A4 File Offset: 0x0042F3A4
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

		// Token: 0x170089E3 RID: 35299
		// (get) Token: 0x0601DD4F RID: 122191 RVA: 0x004311E0 File Offset: 0x0042F3E0
		public bool IsSuccessful
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DD50 RID: 122192 RVA: 0x0043121F File Offset: 0x0042F41F
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> CreateICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSuccessful = false)
		{
			builder.StartTable(2);
			ICheckHonamiStorySuccessfulEvacuation.AddIsSuccessful(builder, IsSuccessful);
			ICheckHonamiStorySuccessfulEvacuation.AddType(builder, Type);
			return ICheckHonamiStorySuccessfulEvacuation.EndICheckHonamiStorySuccessfulEvacuation(builder);
		}

		// Token: 0x0601DD51 RID: 122193 RVA: 0x0043123C File Offset: 0x0042F43C
		public static void StartICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DD52 RID: 122194 RVA: 0x00431245 File Offset: 0x0042F445
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD53 RID: 122195 RVA: 0x00431250 File Offset: 0x0042F450
		public static void AddIsSuccessful(FlatBufferBuilder builder, bool isSuccessful)
		{
			builder.AddBool(1, isSuccessful, false);
		}

		// Token: 0x0601DD54 RID: 122196 RVA: 0x0043125B File Offset: 0x0042F45B
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> EndICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStorySuccessfulEvacuation>(builder.EndTable());
		}

		// Token: 0x0601DD55 RID: 122197 RVA: 0x00431268 File Offset: 0x0042F468
		public ICheckHonamiStorySuccessfulEvacuationT UnPack()
		{
			ICheckHonamiStorySuccessfulEvacuationT checkHonamiStorySuccessfulEvacuationT = new ICheckHonamiStorySuccessfulEvacuationT();
			this.UnPackTo(checkHonamiStorySuccessfulEvacuationT);
			return checkHonamiStorySuccessfulEvacuationT;
		}

		// Token: 0x0601DD56 RID: 122198 RVA: 0x00431283 File Offset: 0x0042F483
		public void UnPackTo(ICheckHonamiStorySuccessfulEvacuationT _o)
		{
			_o.Type = this.Type;
			_o.IsSuccessful = this.IsSuccessful;
		}

		// Token: 0x0601DD57 RID: 122199 RVA: 0x004312A0 File Offset: 0x0042F4A0
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> Pack(FlatBufferBuilder builder, ICheckHonamiStorySuccessfulEvacuationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStorySuccessfulEvacuation>);
			}
			return ICheckHonamiStorySuccessfulEvacuation.CreateICheckHonamiStorySuccessfulEvacuation(builder, _o.Type, _o.IsSuccessful);
		}

		// Token: 0x0400D2C4 RID: 53956
		private Table __p;
	}
}
