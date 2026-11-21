using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F29 RID: 20265
	public struct ICheckHonamiStorySuccessfulEvacuation : IFlatbufferObject
	{
		// Token: 0x170090BD RID: 37053
		// (get) Token: 0x0601F7EB RID: 129003 RVA: 0x004622C4 File Offset: 0x004604C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7EC RID: 129004 RVA: 0x004622D1 File Offset: 0x004604D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7ED RID: 129005 RVA: 0x004622D8 File Offset: 0x004604D8
		public static ICheckHonamiStorySuccessfulEvacuation GetRootAsICheckHonamiStorySuccessfulEvacuation(ByteBuffer _bb)
		{
			return ICheckHonamiStorySuccessfulEvacuation.GetRootAsICheckHonamiStorySuccessfulEvacuation(_bb, default(ICheckHonamiStorySuccessfulEvacuation));
		}

		// Token: 0x0601F7EE RID: 129006 RVA: 0x004622F4 File Offset: 0x004604F4
		public static ICheckHonamiStorySuccessfulEvacuation GetRootAsICheckHonamiStorySuccessfulEvacuation(ByteBuffer _bb, ICheckHonamiStorySuccessfulEvacuation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7EF RID: 129007 RVA: 0x00462311 File Offset: 0x00460511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7F0 RID: 129008 RVA: 0x00462320 File Offset: 0x00460520
		public ICheckHonamiStorySuccessfulEvacuation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090BE RID: 37054
		// (get) Token: 0x0601F7F1 RID: 129009 RVA: 0x00462330 File Offset: 0x00460530
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

		// Token: 0x170090BF RID: 37055
		// (get) Token: 0x0601F7F2 RID: 129010 RVA: 0x0046236C File Offset: 0x0046056C
		public bool IsSuccessful
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F7F3 RID: 129011 RVA: 0x004623AB File Offset: 0x004605AB
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> CreateICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSuccessful = false)
		{
			builder.StartTable(2);
			ICheckHonamiStorySuccessfulEvacuation.AddIsSuccessful(builder, IsSuccessful);
			ICheckHonamiStorySuccessfulEvacuation.AddType(builder, Type);
			return ICheckHonamiStorySuccessfulEvacuation.EndICheckHonamiStorySuccessfulEvacuation(builder);
		}

		// Token: 0x0601F7F4 RID: 129012 RVA: 0x004623C8 File Offset: 0x004605C8
		public static void StartICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F7F5 RID: 129013 RVA: 0x004623D1 File Offset: 0x004605D1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7F6 RID: 129014 RVA: 0x004623DC File Offset: 0x004605DC
		public static void AddIsSuccessful(FlatBufferBuilder builder, bool isSuccessful)
		{
			builder.AddBool(1, isSuccessful, false);
		}

		// Token: 0x0601F7F7 RID: 129015 RVA: 0x004623E7 File Offset: 0x004605E7
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> EndICheckHonamiStorySuccessfulEvacuation(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStorySuccessfulEvacuation>(builder.EndTable());
		}

		// Token: 0x0601F7F8 RID: 129016 RVA: 0x004623F4 File Offset: 0x004605F4
		public ICheckHonamiStorySuccessfulEvacuationT UnPack()
		{
			ICheckHonamiStorySuccessfulEvacuationT checkHonamiStorySuccessfulEvacuationT = new ICheckHonamiStorySuccessfulEvacuationT();
			this.UnPackTo(checkHonamiStorySuccessfulEvacuationT);
			return checkHonamiStorySuccessfulEvacuationT;
		}

		// Token: 0x0601F7F9 RID: 129017 RVA: 0x0046240F File Offset: 0x0046060F
		public void UnPackTo(ICheckHonamiStorySuccessfulEvacuationT _o)
		{
			_o.Type = this.Type;
			_o.IsSuccessful = this.IsSuccessful;
		}

		// Token: 0x0601F7FA RID: 129018 RVA: 0x0046242C File Offset: 0x0046062C
		public static Offset<ICheckHonamiStorySuccessfulEvacuation> Pack(FlatBufferBuilder builder, ICheckHonamiStorySuccessfulEvacuationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStorySuccessfulEvacuation>);
			}
			return ICheckHonamiStorySuccessfulEvacuation.CreateICheckHonamiStorySuccessfulEvacuation(builder, _o.Type, _o.IsSuccessful);
		}

		// Token: 0x0400DD9F RID: 56735
		private Table __p;
	}
}
