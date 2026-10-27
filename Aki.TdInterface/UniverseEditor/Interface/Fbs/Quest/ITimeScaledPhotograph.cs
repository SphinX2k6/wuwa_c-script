using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E1 RID: 16865
	public struct ITimeScaledPhotograph : IFlatbufferObject
	{
		// Token: 0x170077A0 RID: 30624
		// (get) Token: 0x06018DC0 RID: 101824 RVA: 0x00393B35 File Offset: 0x00391D35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018DC1 RID: 101825 RVA: 0x00393B42 File Offset: 0x00391D42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018DC2 RID: 101826 RVA: 0x00393B4C File Offset: 0x00391D4C
		public static ITimeScaledPhotograph GetRootAsITimeScaledPhotograph(ByteBuffer _bb)
		{
			return ITimeScaledPhotograph.GetRootAsITimeScaledPhotograph(_bb, default(ITimeScaledPhotograph));
		}

		// Token: 0x06018DC3 RID: 101827 RVA: 0x00393B68 File Offset: 0x00391D68
		public static ITimeScaledPhotograph GetRootAsITimeScaledPhotograph(ByteBuffer _bb, ITimeScaledPhotograph obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018DC4 RID: 101828 RVA: 0x00393B85 File Offset: 0x00391D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018DC5 RID: 101829 RVA: 0x00393B94 File Offset: 0x00391D94
		public ITimeScaledPhotograph __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077A1 RID: 30625
		// (get) Token: 0x06018DC6 RID: 101830 RVA: 0x00393BA4 File Offset: 0x00391DA4
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077A2 RID: 30626
		// (get) Token: 0x06018DC7 RID: 101831 RVA: 0x00393BE0 File Offset: 0x00391DE0
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077A3 RID: 30627
		// (get) Token: 0x06018DC8 RID: 101832 RVA: 0x00393C40 File Offset: 0x00391E40
		public ETimeScaledPhotographTip ViewFinderTip
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETimeScaledPhotographTip.NoTip;
				}
				return (ETimeScaledPhotographTip)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077A4 RID: 30628
		// (get) Token: 0x06018DC9 RID: 101833 RVA: 0x00393C7C File Offset: 0x00391E7C
		public IPhotographCondition? PhotographCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPhotographCondition?(default(IPhotographCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077A5 RID: 30629
		// (get) Token: 0x06018DCA RID: 101834 RVA: 0x00393CDC File Offset: 0x00391EDC
		public ICameraCondition? CameraCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ICameraCondition?(default(ICameraCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018DCB RID: 101835 RVA: 0x00393D3A File Offset: 0x00391F3A
		public static Offset<ITimeScaledPhotograph> CreateITimeScaledPhotograph(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), ETimeScaledPhotographTip ViewFinderTip = ETimeScaledPhotographTip.NoTip, Offset<IPhotographCondition> PhotographConditionOffset = default(Offset<IPhotographCondition>), Offset<ICameraCondition> CameraConditionOffset = default(Offset<ICameraCondition>))
		{
			builder.StartTable(5);
			ITimeScaledPhotograph.AddCameraCondition(builder, CameraConditionOffset);
			ITimeScaledPhotograph.AddPhotographCondition(builder, PhotographConditionOffset);
			ITimeScaledPhotograph.AddPreConditions(builder, PreConditionsOffset);
			ITimeScaledPhotograph.AddViewFinderTip(builder, ViewFinderTip);
			ITimeScaledPhotograph.AddType(builder, Type);
			return ITimeScaledPhotograph.EndITimeScaledPhotograph(builder);
		}

		// Token: 0x06018DCC RID: 101836 RVA: 0x00393D6E File Offset: 0x00391F6E
		public static void StartITimeScaledPhotograph(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018DCD RID: 101837 RVA: 0x00393D77 File Offset: 0x00391F77
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018DCE RID: 101838 RVA: 0x00393D82 File Offset: 0x00391F82
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018DCF RID: 101839 RVA: 0x00393D92 File Offset: 0x00391F92
		public static void AddViewFinderTip(FlatBufferBuilder builder, ETimeScaledPhotographTip viewFinderTip)
		{
			builder.AddByte(2, (byte)viewFinderTip, 0);
		}

		// Token: 0x06018DD0 RID: 101840 RVA: 0x00393D9D File Offset: 0x00391F9D
		public static void AddPhotographCondition(FlatBufferBuilder builder, Offset<IPhotographCondition> photographConditionOffset)
		{
			builder.AddOffset(3, photographConditionOffset.Value, 0);
		}

		// Token: 0x06018DD1 RID: 101841 RVA: 0x00393DAD File Offset: 0x00391FAD
		public static void AddCameraCondition(FlatBufferBuilder builder, Offset<ICameraCondition> cameraConditionOffset)
		{
			builder.AddOffset(4, cameraConditionOffset.Value, 0);
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x00393DBD File Offset: 0x00391FBD
		public static Offset<ITimeScaledPhotograph> EndITimeScaledPhotograph(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScaledPhotograph>(builder.EndTable());
		}

		// Token: 0x06018DD3 RID: 101843 RVA: 0x00393DCC File Offset: 0x00391FCC
		public ITimeScaledPhotographT UnPack()
		{
			ITimeScaledPhotographT timeScaledPhotographT = new ITimeScaledPhotographT();
			this.UnPackTo(timeScaledPhotographT);
			return timeScaledPhotographT;
		}

		// Token: 0x06018DD4 RID: 101844 RVA: 0x00393DE8 File Offset: 0x00391FE8
		public void UnPackTo(ITimeScaledPhotographT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ViewFinderTip = this.ViewFinderTip;
			_o.PhotographCondition = ((this.PhotographCondition != null) ? this.PhotographCondition.Value.UnPack() : null);
			_o.CameraCondition = ((this.CameraCondition != null) ? this.CameraCondition.Value.UnPack() : null);
		}

		// Token: 0x06018DD5 RID: 101845 RVA: 0x00393EA0 File Offset: 0x003920A0
		public static Offset<ITimeScaledPhotograph> Pack(FlatBufferBuilder builder, ITimeScaledPhotographT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScaledPhotograph>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IPhotographCondition> photographConditionOffset = (_o.PhotographCondition == null) ? default(Offset<IPhotographCondition>) : IPhotographCondition.Pack(builder, _o.PhotographCondition);
			Offset<ICameraCondition> cameraConditionOffset = (_o.CameraCondition == null) ? default(Offset<ICameraCondition>) : ICameraCondition.Pack(builder, _o.CameraCondition);
			return ITimeScaledPhotograph.CreateITimeScaledPhotograph(builder, _o.Type, preConditionsOffset, _o.ViewFinderTip, photographConditionOffset, cameraConditionOffset);
		}

		// Token: 0x0400BE33 RID: 48691
		private Table __p;
	}
}
