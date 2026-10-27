using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FAC RID: 20396
	public struct IClientTriggerComponent : IFlatbufferObject
	{
		// Token: 0x170093B3 RID: 37811
		// (get) Token: 0x06020755 RID: 132949 RVA: 0x00484160 File Offset: 0x00482360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020756 RID: 132950 RVA: 0x0048416D File Offset: 0x0048236D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020757 RID: 132951 RVA: 0x00484174 File Offset: 0x00482374
		public static IClientTriggerComponent GetRootAsIClientTriggerComponent(ByteBuffer _bb)
		{
			return IClientTriggerComponent.GetRootAsIClientTriggerComponent(_bb, default(IClientTriggerComponent));
		}

		// Token: 0x06020758 RID: 132952 RVA: 0x00484190 File Offset: 0x00482390
		public static IClientTriggerComponent GetRootAsIClientTriggerComponent(ByteBuffer _bb, IClientTriggerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020759 RID: 132953 RVA: 0x004841AD File Offset: 0x004823AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602075A RID: 132954 RVA: 0x004841BC File Offset: 0x004823BC
		public IClientTriggerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093B4 RID: 37812
		// (get) Token: 0x0602075B RID: 132955 RVA: 0x004841CC File Offset: 0x004823CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093B5 RID: 37813
		// (get) Token: 0x0602075C RID: 132956 RVA: 0x0048420C File Offset: 0x0048240C
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

		// Token: 0x170093B6 RID: 37814
		// (get) Token: 0x0602075D RID: 132957 RVA: 0x0048426C File Offset: 0x0048246C
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

		// Token: 0x170093B7 RID: 37815
		// (get) Token: 0x0602075E RID: 132958 RVA: 0x004842CC File Offset: 0x004824CC
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

		// Token: 0x170093B8 RID: 37816
		// (get) Token: 0x0602075F RID: 132959 RVA: 0x0048432C File Offset: 0x0048252C
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

		// Token: 0x06020760 RID: 132960 RVA: 0x00484369 File Offset: 0x00482569
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

		// Token: 0x06020761 RID: 132961 RVA: 0x0048439D File Offset: 0x0048259D
		public static void StartIClientTriggerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020762 RID: 132962 RVA: 0x004843A6 File Offset: 0x004825A6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020763 RID: 132963 RVA: 0x004843B1 File Offset: 0x004825B1
		public static void AddTriggerMatch(FlatBufferBuilder builder, Offset<ITriggerMatchConfig> triggerMatchOffset)
		{
			builder.AddOffset(1, triggerMatchOffset.Value, 0);
		}

		// Token: 0x06020764 RID: 132964 RVA: 0x004843C1 File Offset: 0x004825C1
		public static void AddOnTriggerEnter(FlatBufferBuilder builder, Offset<ITriggeredConfig> onTriggerEnterOffset)
		{
			builder.AddOffset(2, onTriggerEnterOffset.Value, 0);
		}

		// Token: 0x06020765 RID: 132965 RVA: 0x004843D1 File Offset: 0x004825D1
		public static void AddOnTriggerExit(FlatBufferBuilder builder, Offset<ITriggeredConfig> onTriggerExitOffset)
		{
			builder.AddOffset(3, onTriggerExitOffset.Value, 0);
		}

		// Token: 0x06020766 RID: 132966 RVA: 0x004843E1 File Offset: 0x004825E1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020767 RID: 132967 RVA: 0x004843EC File Offset: 0x004825EC
		public static Offset<IClientTriggerComponent> EndIClientTriggerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IClientTriggerComponent>(builder.EndTable());
		}

		// Token: 0x06020768 RID: 132968 RVA: 0x004843FC File Offset: 0x004825FC
		public IClientTriggerComponentT UnPack()
		{
			IClientTriggerComponentT clientTriggerComponentT = new IClientTriggerComponentT();
			this.UnPackTo(clientTriggerComponentT);
			return clientTriggerComponentT;
		}

		// Token: 0x06020769 RID: 132969 RVA: 0x00484418 File Offset: 0x00482618
		public void UnPackTo(IClientTriggerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TriggerMatch = ((this.TriggerMatch != null) ? this.TriggerMatch.Value.UnPack() : null);
			_o.OnTriggerEnter = ((this.OnTriggerEnter != null) ? this.OnTriggerEnter.Value.UnPack() : null);
			_o.OnTriggerExit = ((this.OnTriggerExit != null) ? this.OnTriggerExit.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602076A RID: 132970 RVA: 0x004844CC File Offset: 0x004826CC
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

		// Token: 0x0400DE82 RID: 56962
		private Table __p;
	}
}
