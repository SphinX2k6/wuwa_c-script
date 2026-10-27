using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FB RID: 21499
	public struct IInhalationConfig : IFlatbufferObject
	{
		// Token: 0x17009E35 RID: 40501
		// (get) Token: 0x060234E7 RID: 144615 RVA: 0x004E34A7 File Offset: 0x004E16A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234E8 RID: 144616 RVA: 0x004E34B4 File Offset: 0x004E16B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234E9 RID: 144617 RVA: 0x004E34BC File Offset: 0x004E16BC
		public static IInhalationConfig GetRootAsIInhalationConfig(ByteBuffer _bb)
		{
			return IInhalationConfig.GetRootAsIInhalationConfig(_bb, default(IInhalationConfig));
		}

		// Token: 0x060234EA RID: 144618 RVA: 0x004E34D8 File Offset: 0x004E16D8
		public static IInhalationConfig GetRootAsIInhalationConfig(ByteBuffer _bb, IInhalationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234EB RID: 144619 RVA: 0x004E34F5 File Offset: 0x004E16F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234EC RID: 144620 RVA: 0x004E3504 File Offset: 0x004E1704
		public IInhalationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E36 RID: 40502
		// (get) Token: 0x060234ED RID: 144621 RVA: 0x004E3514 File Offset: 0x004E1714
		public IInhalationMatching? InhalationMatching
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInhalationMatching?(default(IInhalationMatching).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E37 RID: 40503
		// (get) Token: 0x060234EE RID: 144622 RVA: 0x004E3574 File Offset: 0x004E1774
		public TInhalationPerformance InhalationPerformanceType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TInhalationPerformance.NONE;
				}
				return (TInhalationPerformance)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060234EF RID: 144623 RVA: 0x004E35B0 File Offset: 0x004E17B0
		public TTable? InhalationPerformance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060234F0 RID: 144624 RVA: 0x004E35F4 File Offset: 0x004E17F4
		public IRoleInhalation InhalationPerformanceAsIRoleInhalation()
		{
			return this.InhalationPerformance<IRoleInhalation>().Value;
		}

		// Token: 0x060234F1 RID: 144625 RVA: 0x004E3610 File Offset: 0x004E1810
		public ISceneItemInhalation InhalationPerformanceAsISceneItemInhalation()
		{
			return this.InhalationPerformance<ISceneItemInhalation>().Value;
		}

		// Token: 0x060234F2 RID: 144626 RVA: 0x004E362B File Offset: 0x004E182B
		public static Offset<IInhalationConfig> CreateIInhalationConfig(FlatBufferBuilder builder, Offset<IInhalationMatching> InhalationMatchingOffset = default(Offset<IInhalationMatching>), TInhalationPerformance InhalationPerformance_type = TInhalationPerformance.NONE, int InhalationPerformanceOffset = 0)
		{
			builder.StartTable(3);
			IInhalationConfig.AddInhalationPerformance(builder, InhalationPerformanceOffset);
			IInhalationConfig.AddInhalationMatching(builder, InhalationMatchingOffset);
			IInhalationConfig.AddInhalationPerformanceType(builder, InhalationPerformance_type);
			return IInhalationConfig.EndIInhalationConfig(builder);
		}

		// Token: 0x060234F3 RID: 144627 RVA: 0x004E364F File Offset: 0x004E184F
		public static void StartIInhalationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060234F4 RID: 144628 RVA: 0x004E3658 File Offset: 0x004E1858
		public static void AddInhalationMatching(FlatBufferBuilder builder, Offset<IInhalationMatching> inhalationMatchingOffset)
		{
			builder.AddOffset(0, inhalationMatchingOffset.Value, 0);
		}

		// Token: 0x060234F5 RID: 144629 RVA: 0x004E3668 File Offset: 0x004E1868
		public static void AddInhalationPerformanceType(FlatBufferBuilder builder, TInhalationPerformance inhalationPerformanceType)
		{
			builder.AddByte(1, (byte)inhalationPerformanceType, 0);
		}

		// Token: 0x060234F6 RID: 144630 RVA: 0x004E3673 File Offset: 0x004E1873
		public static void AddInhalationPerformance(FlatBufferBuilder builder, int inhalationPerformanceOffset)
		{
			builder.AddOffset(2, inhalationPerformanceOffset, 0);
		}

		// Token: 0x060234F7 RID: 144631 RVA: 0x004E367E File Offset: 0x004E187E
		public static Offset<IInhalationConfig> EndIInhalationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationConfig>(builder.EndTable());
		}

		// Token: 0x060234F8 RID: 144632 RVA: 0x004E368C File Offset: 0x004E188C
		public IInhalationConfigT UnPack()
		{
			IInhalationConfigT inhalationConfigT = new IInhalationConfigT();
			this.UnPackTo(inhalationConfigT);
			return inhalationConfigT;
		}

		// Token: 0x060234F9 RID: 144633 RVA: 0x004E36A8 File Offset: 0x004E18A8
		public void UnPackTo(IInhalationConfigT _o)
		{
			_o.InhalationMatching = ((this.InhalationMatching != null) ? this.InhalationMatching.Value.UnPack() : null);
			_o.InhalationPerformance = new TInhalationPerformanceUnion();
			_o.InhalationPerformance.Type = this.InhalationPerformanceType;
			TInhalationPerformance inhalationPerformanceType = this.InhalationPerformanceType;
			if (inhalationPerformanceType == TInhalationPerformance.IRoleInhalation)
			{
				_o.InhalationPerformance.Value = ((this.InhalationPerformance<IRoleInhalation>() != null) ? this.InhalationPerformance<IRoleInhalation>().Value.UnPack() : null);
				return;
			}
			if (inhalationPerformanceType != TInhalationPerformance.ISceneItemInhalation)
			{
				return;
			}
			_o.InhalationPerformance.Value = ((this.InhalationPerformance<ISceneItemInhalation>() != null) ? this.InhalationPerformance<ISceneItemInhalation>().Value.UnPack() : null);
		}

		// Token: 0x060234FA RID: 144634 RVA: 0x004E3780 File Offset: 0x004E1980
		public static Offset<IInhalationConfig> Pack(FlatBufferBuilder builder, IInhalationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationConfig>);
			}
			Offset<IInhalationMatching> inhalationMatchingOffset = (_o.InhalationMatching == null) ? default(Offset<IInhalationMatching>) : IInhalationMatching.Pack(builder, _o.InhalationMatching);
			TInhalationPerformance inhalationPerformance_type = (_o.InhalationPerformance == null) ? TInhalationPerformance.NONE : _o.InhalationPerformance.Type;
			int inhalationPerformanceOffset = (_o.InhalationPerformance == null) ? 0 : TInhalationPerformanceUnion.Pack(builder, _o.InhalationPerformance);
			return IInhalationConfig.CreateIInhalationConfig(builder, inhalationMatchingOffset, inhalationPerformance_type, inhalationPerformanceOffset);
		}

		// Token: 0x0400E63F RID: 58943
		private Table __p;
	}
}
