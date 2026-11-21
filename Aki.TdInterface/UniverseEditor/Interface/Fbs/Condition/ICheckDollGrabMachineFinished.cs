using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8D RID: 20109
	public struct ICheckDollGrabMachineFinished : IFlatbufferObject
	{
		// Token: 0x17008F6A RID: 36714
		// (get) Token: 0x0601F26F RID: 127599 RVA: 0x0045846E File Offset: 0x0045666E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F270 RID: 127600 RVA: 0x0045847B File Offset: 0x0045667B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F271 RID: 127601 RVA: 0x00458484 File Offset: 0x00456684
		public static ICheckDollGrabMachineFinished GetRootAsICheckDollGrabMachineFinished(ByteBuffer _bb)
		{
			return ICheckDollGrabMachineFinished.GetRootAsICheckDollGrabMachineFinished(_bb, default(ICheckDollGrabMachineFinished));
		}

		// Token: 0x0601F272 RID: 127602 RVA: 0x004584A0 File Offset: 0x004566A0
		public static ICheckDollGrabMachineFinished GetRootAsICheckDollGrabMachineFinished(ByteBuffer _bb, ICheckDollGrabMachineFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F273 RID: 127603 RVA: 0x004584BD File Offset: 0x004566BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F274 RID: 127604 RVA: 0x004584CC File Offset: 0x004566CC
		public ICheckDollGrabMachineFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F6B RID: 36715
		// (get) Token: 0x0601F275 RID: 127605 RVA: 0x004584DC File Offset: 0x004566DC
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

		// Token: 0x17008F6C RID: 36716
		// (get) Token: 0x0601F276 RID: 127606 RVA: 0x00458518 File Offset: 0x00456718
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F277 RID: 127607 RVA: 0x00458554 File Offset: 0x00456754
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F278 RID: 127608 RVA: 0x00458598 File Offset: 0x00456798
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601F279 RID: 127609 RVA: 0x004585B4 File Offset: 0x004567B4
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601F27A RID: 127610 RVA: 0x004585D0 File Offset: 0x004567D0
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601F27B RID: 127611 RVA: 0x004585EC File Offset: 0x004567EC
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0601F27C RID: 127612 RVA: 0x00458607 File Offset: 0x00456807
		public static Offset<ICheckDollGrabMachineFinished> CreateICheckDollGrabMachineFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICheckDollGrabMachineFinished.AddTarget(builder, TargetOffset);
			ICheckDollGrabMachineFinished.AddTargetType(builder, Target_type);
			ICheckDollGrabMachineFinished.AddType(builder, Type);
			return ICheckDollGrabMachineFinished.EndICheckDollGrabMachineFinished(builder);
		}

		// Token: 0x0601F27D RID: 127613 RVA: 0x0045862B File Offset: 0x0045682B
		public static void StartICheckDollGrabMachineFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F27E RID: 127614 RVA: 0x00458634 File Offset: 0x00456834
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F27F RID: 127615 RVA: 0x0045863F File Offset: 0x0045683F
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F280 RID: 127616 RVA: 0x0045864A File Offset: 0x0045684A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F281 RID: 127617 RVA: 0x00458655 File Offset: 0x00456855
		public static Offset<ICheckDollGrabMachineFinished> EndICheckDollGrabMachineFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabMachineFinished>(builder.EndTable());
		}

		// Token: 0x0601F282 RID: 127618 RVA: 0x00458664 File Offset: 0x00456864
		public ICheckDollGrabMachineFinishedT UnPack()
		{
			ICheckDollGrabMachineFinishedT checkDollGrabMachineFinishedT = new ICheckDollGrabMachineFinishedT();
			this.UnPackTo(checkDollGrabMachineFinishedT);
			return checkDollGrabMachineFinishedT;
		}

		// Token: 0x0601F283 RID: 127619 RVA: 0x00458680 File Offset: 0x00456880
		public void UnPackTo(ICheckDollGrabMachineFinishedT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601F284 RID: 127620 RVA: 0x004587B0 File Offset: 0x004569B0
		public static Offset<ICheckDollGrabMachineFinished> Pack(FlatBufferBuilder builder, ICheckDollGrabMachineFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabMachineFinished>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICheckDollGrabMachineFinished.CreateICheckDollGrabMachineFinished(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x0400DCCB RID: 56523
		private Table __p;
	}
}
