using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EFC RID: 20220
	public struct ICheckGiantStableValue : IFlatbufferObject
	{
		// Token: 0x17009065 RID: 36965
		// (get) Token: 0x0601F67B RID: 128635 RVA: 0x0045FE1C File Offset: 0x0045E01C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F67C RID: 128636 RVA: 0x0045FE29 File Offset: 0x0045E029
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F67D RID: 128637 RVA: 0x0045FE30 File Offset: 0x0045E030
		public static ICheckGiantStableValue GetRootAsICheckGiantStableValue(ByteBuffer _bb)
		{
			return ICheckGiantStableValue.GetRootAsICheckGiantStableValue(_bb, default(ICheckGiantStableValue));
		}

		// Token: 0x0601F67E RID: 128638 RVA: 0x0045FE4C File Offset: 0x0045E04C
		public static ICheckGiantStableValue GetRootAsICheckGiantStableValue(ByteBuffer _bb, ICheckGiantStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F67F RID: 128639 RVA: 0x0045FE69 File Offset: 0x0045E069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F680 RID: 128640 RVA: 0x0045FE78 File Offset: 0x0045E078
		public ICheckGiantStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009066 RID: 36966
		// (get) Token: 0x0601F681 RID: 128641 RVA: 0x0045FE88 File Offset: 0x0045E088
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

		// Token: 0x17009067 RID: 36967
		// (get) Token: 0x0601F682 RID: 128642 RVA: 0x0045FEC4 File Offset: 0x0045E0C4
		public TGiantStableValue StableValueOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGiantStableValue.NONE;
				}
				return (TGiantStableValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F683 RID: 128643 RVA: 0x0045FF00 File Offset: 0x0045E100
		public TTable? StableValueOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F684 RID: 128644 RVA: 0x0045FF44 File Offset: 0x0045E144
		public IGiantStableValueRegion StableValueOptionAsIGiantStableValueRegion()
		{
			return this.StableValueOption<IGiantStableValueRegion>().Value;
		}

		// Token: 0x0601F685 RID: 128645 RVA: 0x0045FF60 File Offset: 0x0045E160
		public IGiantStableValueTotal StableValueOptionAsIGiantStableValueTotal()
		{
			return this.StableValueOption<IGiantStableValueTotal>().Value;
		}

		// Token: 0x0601F686 RID: 128646 RVA: 0x0045FF7B File Offset: 0x0045E17B
		public static Offset<ICheckGiantStableValue> CreateICheckGiantStableValue(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TGiantStableValue StableValueOption_type = TGiantStableValue.NONE, int StableValueOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckGiantStableValue.AddStableValueOption(builder, StableValueOptionOffset);
			ICheckGiantStableValue.AddStableValueOptionType(builder, StableValueOption_type);
			ICheckGiantStableValue.AddType(builder, Type);
			return ICheckGiantStableValue.EndICheckGiantStableValue(builder);
		}

		// Token: 0x0601F687 RID: 128647 RVA: 0x0045FF9F File Offset: 0x0045E19F
		public static void StartICheckGiantStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F688 RID: 128648 RVA: 0x0045FFA8 File Offset: 0x0045E1A8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F689 RID: 128649 RVA: 0x0045FFB3 File Offset: 0x0045E1B3
		public static void AddStableValueOptionType(FlatBufferBuilder builder, TGiantStableValue stableValueOptionType)
		{
			builder.AddByte(1, (byte)stableValueOptionType, 0);
		}

		// Token: 0x0601F68A RID: 128650 RVA: 0x0045FFBE File Offset: 0x0045E1BE
		public static void AddStableValueOption(FlatBufferBuilder builder, int stableValueOptionOffset)
		{
			builder.AddOffset(2, stableValueOptionOffset, 0);
		}

		// Token: 0x0601F68B RID: 128651 RVA: 0x0045FFC9 File Offset: 0x0045E1C9
		public static Offset<ICheckGiantStableValue> EndICheckGiantStableValue(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantStableValue>(builder.EndTable());
		}

		// Token: 0x0601F68C RID: 128652 RVA: 0x0045FFD8 File Offset: 0x0045E1D8
		public ICheckGiantStableValueT UnPack()
		{
			ICheckGiantStableValueT checkGiantStableValueT = new ICheckGiantStableValueT();
			this.UnPackTo(checkGiantStableValueT);
			return checkGiantStableValueT;
		}

		// Token: 0x0601F68D RID: 128653 RVA: 0x0045FFF4 File Offset: 0x0045E1F4
		public void UnPackTo(ICheckGiantStableValueT _o)
		{
			_o.Type = this.Type;
			_o.StableValueOption = new TGiantStableValueUnion();
			_o.StableValueOption.Type = this.StableValueOptionType;
			TGiantStableValue stableValueOptionType = this.StableValueOptionType;
			if (stableValueOptionType == TGiantStableValue.IGiantStableValueRegion)
			{
				_o.StableValueOption.Value = ((this.StableValueOption<IGiantStableValueRegion>() != null) ? this.StableValueOption<IGiantStableValueRegion>().Value.UnPack() : null);
				return;
			}
			if (stableValueOptionType != TGiantStableValue.IGiantStableValueTotal)
			{
				return;
			}
			_o.StableValueOption.Value = ((this.StableValueOption<IGiantStableValueTotal>() != null) ? this.StableValueOption<IGiantStableValueTotal>().Value.UnPack() : null);
		}

		// Token: 0x0601F68E RID: 128654 RVA: 0x004600A4 File Offset: 0x0045E2A4
		public static Offset<ICheckGiantStableValue> Pack(FlatBufferBuilder builder, ICheckGiantStableValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantStableValue>);
			}
			TGiantStableValue stableValueOption_type = (_o.StableValueOption == null) ? TGiantStableValue.NONE : _o.StableValueOption.Type;
			int stableValueOptionOffset = (_o.StableValueOption == null) ? 0 : TGiantStableValueUnion.Pack(builder, _o.StableValueOption);
			return ICheckGiantStableValue.CreateICheckGiantStableValue(builder, _o.Type, stableValueOption_type, stableValueOptionOffset);
		}

		// Token: 0x0400DD66 RID: 56678
		private Table __p;
	}
}
