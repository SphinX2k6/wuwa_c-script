using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB4 RID: 24500
	public struct IStateElementalEnableConfig : IFlatbufferObject
	{
		// Token: 0x1700B573 RID: 46451
		// (get) Token: 0x0602937C RID: 168828 RVA: 0x005A0701 File Offset: 0x0059E901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602937D RID: 168829 RVA: 0x005A070E File Offset: 0x0059E90E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602937E RID: 168830 RVA: 0x005A0718 File Offset: 0x0059E918
		public static IStateElementalEnableConfig GetRootAsIStateElementalEnableConfig(ByteBuffer _bb)
		{
			return IStateElementalEnableConfig.GetRootAsIStateElementalEnableConfig(_bb, default(IStateElementalEnableConfig));
		}

		// Token: 0x0602937F RID: 168831 RVA: 0x005A0734 File Offset: 0x0059E934
		public static IStateElementalEnableConfig GetRootAsIStateElementalEnableConfig(ByteBuffer _bb, IStateElementalEnableConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029380 RID: 168832 RVA: 0x005A0751 File Offset: 0x0059E951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029381 RID: 168833 RVA: 0x005A0760 File Offset: 0x0059E960
		public IStateElementalEnableConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B574 RID: 46452
		// (get) Token: 0x06029382 RID: 168834 RVA: 0x005A0770 File Offset: 0x0059E970
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029383 RID: 168835 RVA: 0x005A07A7 File Offset: 0x0059E9A7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029384 RID: 168836 RVA: 0x005A07B6 File Offset: 0x0059E9B6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B575 RID: 46453
		// (get) Token: 0x06029385 RID: 168837 RVA: 0x005A07C4 File Offset: 0x0059E9C4
		public bool ElementalEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029386 RID: 168838 RVA: 0x005A0803 File Offset: 0x0059EA03
		public static Offset<IStateElementalEnableConfig> CreateIStateElementalEnableConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), bool ElementalEnable = false)
		{
			builder.StartTable(2);
			IStateElementalEnableConfig.AddState(builder, StateOffset);
			IStateElementalEnableConfig.AddElementalEnable(builder, ElementalEnable);
			return IStateElementalEnableConfig.EndIStateElementalEnableConfig(builder);
		}

		// Token: 0x06029387 RID: 168839 RVA: 0x005A0820 File Offset: 0x0059EA20
		public static void StartIStateElementalEnableConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029388 RID: 168840 RVA: 0x005A0829 File Offset: 0x0059EA29
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06029389 RID: 168841 RVA: 0x005A0839 File Offset: 0x0059EA39
		public static void AddElementalEnable(FlatBufferBuilder builder, bool elementalEnable)
		{
			builder.AddBool(1, elementalEnable, false);
		}

		// Token: 0x0602938A RID: 168842 RVA: 0x005A0844 File Offset: 0x0059EA44
		public static Offset<IStateElementalEnableConfig> EndIStateElementalEnableConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateElementalEnableConfig>(builder.EndTable());
		}

		// Token: 0x0602938B RID: 168843 RVA: 0x005A0854 File Offset: 0x0059EA54
		public IStateElementalEnableConfigT UnPack()
		{
			IStateElementalEnableConfigT stateElementalEnableConfigT = new IStateElementalEnableConfigT();
			this.UnPackTo(stateElementalEnableConfigT);
			return stateElementalEnableConfigT;
		}

		// Token: 0x0602938C RID: 168844 RVA: 0x005A086F File Offset: 0x0059EA6F
		public void UnPackTo(IStateElementalEnableConfigT _o)
		{
			_o.State = this.State;
			_o.ElementalEnable = this.ElementalEnable;
		}

		// Token: 0x0602938D RID: 168845 RVA: 0x005A088C File Offset: 0x0059EA8C
		public static Offset<IStateElementalEnableConfig> Pack(FlatBufferBuilder builder, IStateElementalEnableConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateElementalEnableConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateElementalEnableConfig.CreateIStateElementalEnableConfig(builder, stateOffset, _o.ElementalEnable);
		}

		// Token: 0x0400FCAA RID: 64682
		private Table __p;
	}
}
