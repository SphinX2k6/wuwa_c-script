using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463A RID: 17978
	public struct ITimeScaledPhotograph : IFlatbufferObject
	{
		// Token: 0x17007DCC RID: 32204
		// (get) Token: 0x0601A516 RID: 107798 RVA: 0x003BEF89 File Offset: 0x003BD189
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A517 RID: 107799 RVA: 0x003BEF96 File Offset: 0x003BD196
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A518 RID: 107800 RVA: 0x003BEFA0 File Offset: 0x003BD1A0
		public static ITimeScaledPhotograph GetRootAsITimeScaledPhotograph(ByteBuffer _bb)
		{
			return ITimeScaledPhotograph.GetRootAsITimeScaledPhotograph(_bb, default(ITimeScaledPhotograph));
		}

		// Token: 0x0601A519 RID: 107801 RVA: 0x003BEFBC File Offset: 0x003BD1BC
		public static ITimeScaledPhotograph GetRootAsITimeScaledPhotograph(ByteBuffer _bb, ITimeScaledPhotograph obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A51A RID: 107802 RVA: 0x003BEFD9 File Offset: 0x003BD1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A51B RID: 107803 RVA: 0x003BEFE8 File Offset: 0x003BD1E8
		public ITimeScaledPhotograph __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DCD RID: 32205
		// (get) Token: 0x0601A51C RID: 107804 RVA: 0x003BEFF8 File Offset: 0x003BD1F8
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

		// Token: 0x17007DCE RID: 32206
		// (get) Token: 0x0601A51D RID: 107805 RVA: 0x003BF034 File Offset: 0x003BD234
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

		// Token: 0x17007DCF RID: 32207
		// (get) Token: 0x0601A51E RID: 107806 RVA: 0x003BF094 File Offset: 0x003BD294
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

		// Token: 0x17007DD0 RID: 32208
		// (get) Token: 0x0601A51F RID: 107807 RVA: 0x003BF0D0 File Offset: 0x003BD2D0
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

		// Token: 0x17007DD1 RID: 32209
		// (get) Token: 0x0601A520 RID: 107808 RVA: 0x003BF130 File Offset: 0x003BD330
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

		// Token: 0x0601A521 RID: 107809 RVA: 0x003BF18E File Offset: 0x003BD38E
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

		// Token: 0x0601A522 RID: 107810 RVA: 0x003BF1C2 File Offset: 0x003BD3C2
		public static void StartITimeScaledPhotograph(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A523 RID: 107811 RVA: 0x003BF1CB File Offset: 0x003BD3CB
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A524 RID: 107812 RVA: 0x003BF1D6 File Offset: 0x003BD3D6
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A525 RID: 107813 RVA: 0x003BF1E6 File Offset: 0x003BD3E6
		public static void AddViewFinderTip(FlatBufferBuilder builder, ETimeScaledPhotographTip viewFinderTip)
		{
			builder.AddByte(2, (byte)viewFinderTip, 0);
		}

		// Token: 0x0601A526 RID: 107814 RVA: 0x003BF1F1 File Offset: 0x003BD3F1
		public static void AddPhotographCondition(FlatBufferBuilder builder, Offset<IPhotographCondition> photographConditionOffset)
		{
			builder.AddOffset(3, photographConditionOffset.Value, 0);
		}

		// Token: 0x0601A527 RID: 107815 RVA: 0x003BF201 File Offset: 0x003BD401
		public static void AddCameraCondition(FlatBufferBuilder builder, Offset<ICameraCondition> cameraConditionOffset)
		{
			builder.AddOffset(4, cameraConditionOffset.Value, 0);
		}

		// Token: 0x0601A528 RID: 107816 RVA: 0x003BF211 File Offset: 0x003BD411
		public static Offset<ITimeScaledPhotograph> EndITimeScaledPhotograph(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScaledPhotograph>(builder.EndTable());
		}

		// Token: 0x0601A529 RID: 107817 RVA: 0x003BF220 File Offset: 0x003BD420
		public ITimeScaledPhotographT UnPack()
		{
			ITimeScaledPhotographT timeScaledPhotographT = new ITimeScaledPhotographT();
			this.UnPackTo(timeScaledPhotographT);
			return timeScaledPhotographT;
		}

		// Token: 0x0601A52A RID: 107818 RVA: 0x003BF23C File Offset: 0x003BD43C
		public void UnPackTo(ITimeScaledPhotographT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ViewFinderTip = this.ViewFinderTip;
			_o.PhotographCondition = ((this.PhotographCondition != null) ? this.PhotographCondition.Value.UnPack() : null);
			_o.CameraCondition = ((this.CameraCondition != null) ? this.CameraCondition.Value.UnPack() : null);
		}

		// Token: 0x0601A52B RID: 107819 RVA: 0x003BF2F4 File Offset: 0x003BD4F4
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

		// Token: 0x0400C83D RID: 51261
		private Table __p;
	}
}
