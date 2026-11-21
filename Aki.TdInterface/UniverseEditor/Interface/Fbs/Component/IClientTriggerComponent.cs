using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005508 RID: 21768
	public struct IClientTriggerComponent : IFlatbufferObject
	{
		// Token: 0x17009B8B RID: 39819
		// (get) Token: 0x06022649 RID: 140873 RVA: 0x004BD644 File Offset: 0x004BB844
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602264A RID: 140874 RVA: 0x004BD651 File Offset: 0x004BB851
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602264B RID: 140875 RVA: 0x004BD658 File Offset: 0x004BB858
		public static IClientTriggerComponent GetRootAsIClientTriggerComponent(ByteBuffer _bb)
		{
			return IClientTriggerComponent.GetRootAsIClientTriggerComponent(_bb, default(IClientTriggerComponent));
		}

		// Token: 0x0602264C RID: 140876 RVA: 0x004BD674 File Offset: 0x004BB874
		public static IClientTriggerComponent GetRootAsIClientTriggerComponent(ByteBuffer _bb, IClientTriggerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602264D RID: 140877 RVA: 0x004BD691 File Offset: 0x004BB891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602264E RID: 140878 RVA: 0x004BD6A0 File Offset: 0x004BB8A0
		public IClientTriggerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B8C RID: 39820
		// (get) Token: 0x0602264F RID: 140879 RVA: 0x004BD6B0 File Offset: 0x004BB8B0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009B8D RID: 39821
		// (get) Token: 0x06022650 RID: 140880 RVA: 0x004BD6F0 File Offset: 0x004BB8F0
		public ITriggerMatchConfig? TriggerMatch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITriggerMatchConfig?(default(ITriggerMatchConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009B8E RID: 39822
		// (get) Token: 0x06022651 RID: 140881 RVA: 0x004BD750 File Offset: 0x004BB950
		public ITriggeredConfig? OnTriggerEnter
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITriggeredConfig?(default(ITriggeredConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009B8F RID: 39823
		// (get) Token: 0x06022652 RID: 140882 RVA: 0x004BD7B0 File Offset: 0x004BB9B0
		public ITriggeredConfig? OnTriggerExit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITriggeredConfig?(default(ITriggeredConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009B90 RID: 39824
		// (get) Token: 0x06022653 RID: 140883 RVA: 0x004BD810 File Offset: 0x004BBA10
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022654 RID: 140884 RVA: 0x004BD84D File Offset: 0x004BBA4D
		public static Offset<IClientTriggerComponent> CreateIClientTriggerComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ITriggerMatchConfig> TriggerMatchOffset = default(Offset<ITriggerMatchConfig>), Offset<ITriggeredConfig> OnTriggerEnterOffset = default(Offset<ITriggeredConfig>), Offset<ITriggeredConfig> OnTriggerExitOffset = default(Offset<ITriggeredConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IClientTriggerComponent.AddOnTriggerExit(builder, OnTriggerExitOffset);
			IClientTriggerComponent.AddOnTriggerEnter(builder, OnTriggerEnterOffset);
			IClientTriggerComponent.AddTriggerMatch(builder, TriggerMatchOffset);
			IClientTriggerComponent.AddNullMask(builder, NullMask);
			IClientTriggerComponent.AddDisabled(builder, Disabled);
			return IClientTriggerComponent.EndIClientTriggerComponent(builder);
		}

		// Token: 0x06022655 RID: 140885 RVA: 0x004BD881 File Offset: 0x004BBA81
		public static void StartIClientTriggerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022656 RID: 140886 RVA: 0x004BD88A File Offset: 0x004BBA8A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022657 RID: 140887 RVA: 0x004BD895 File Offset: 0x004BBA95
		public static void AddTriggerMatch(FlatBufferBuilder builder, Offset<ITriggerMatchConfig> triggerMatchOffset)
		{
			builder.AddOffset(1, triggerMatchOffset.Value, 0);
		}

		// Token: 0x06022658 RID: 140888 RVA: 0x004BD8A5 File Offset: 0x004BBAA5
		public static void AddOnTriggerEnter(FlatBufferBuilder builder, Offset<ITriggeredConfig> onTriggerEnterOffset)
		{
			builder.AddOffset(2, onTriggerEnterOffset.Value, 0);
		}

		// Token: 0x06022659 RID: 140889 RVA: 0x004BD8B5 File Offset: 0x004BBAB5
		public static void AddOnTriggerExit(FlatBufferBuilder builder, Offset<ITriggeredConfig> onTriggerExitOffset)
		{
			builder.AddOffset(3, onTriggerExitOffset.Value, 0);
		}

		// Token: 0x0602265A RID: 140890 RVA: 0x004BD8C5 File Offset: 0x004BBAC5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602265B RID: 140891 RVA: 0x004BD8D0 File Offset: 0x004BBAD0
		public static Offset<IClientTriggerComponent> EndIClientTriggerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IClientTriggerComponent>(builder.EndTable());
		}

		// Token: 0x0602265C RID: 140892 RVA: 0x004BD8E0 File Offset: 0x004BBAE0
		public IClientTriggerComponentT UnPack()
		{
			IClientTriggerComponentT clientTriggerComponentT = new IClientTriggerComponentT();
			this.UnPackTo(clientTriggerComponentT);
			return clientTriggerComponentT;
		}

		// Token: 0x0602265D RID: 140893 RVA: 0x004BD8FC File Offset: 0x004BBAFC
		public void UnPackTo(IClientTriggerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TriggerMatch = ((this.TriggerMatch != null) ? this.TriggerMatch.Value.UnPack() : null);
			_o.OnTriggerEnter = ((this.OnTriggerEnter != null) ? this.OnTriggerEnter.Value.UnPack() : null);
			_o.OnTriggerExit = ((this.OnTriggerExit != null) ? this.OnTriggerExit.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602265E RID: 140894 RVA: 0x004BD9B0 File Offset: 0x004BBBB0
		public static Offset<IClientTriggerComponent> Pack(FlatBufferBuilder builder, IClientTriggerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTriggerComponent>);
			}
			Offset<ITriggerMatchConfig> triggerMatchOffset = (_o.TriggerMatch == null) ? default(Offset<ITriggerMatchConfig>) : ITriggerMatchConfig.Pack(builder, _o.TriggerMatch);
			Offset<ITriggeredConfig> onTriggerEnterOffset = (_o.OnTriggerEnter == null) ? default(Offset<ITriggeredConfig>) : ITriggeredConfig.Pack(builder, _o.OnTriggerEnter);
			Offset<ITriggeredConfig> onTriggerExitOffset = (_o.OnTriggerExit == null) ? default(Offset<ITriggeredConfig>) : ITriggeredConfig.Pack(builder, _o.OnTriggerExit);
			return IClientTriggerComponent.CreateIClientTriggerComponent(builder, _o.Disabled, triggerMatchOffset, onTriggerEnterOffset, onTriggerExitOffset, _o.NullMask);
		}

		// Token: 0x0400EA70 RID: 60016
		private Table __p;
	}
}
