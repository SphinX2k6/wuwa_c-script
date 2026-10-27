using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005849 RID: 22601
	public struct IRenderQuantumFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700A8E2 RID: 43234
		// (get) Token: 0x06026080 RID: 155776 RVA: 0x0053E3EA File Offset: 0x0053C5EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026081 RID: 155777 RVA: 0x0053E3F7 File Offset: 0x0053C5F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026082 RID: 155778 RVA: 0x0053E400 File Offset: 0x0053C600
		public static IRenderQuantumFollowShooter GetRootAsIRenderQuantumFollowShooter(ByteBuffer _bb)
		{
			return IRenderQuantumFollowShooter.GetRootAsIRenderQuantumFollowShooter(_bb, default(IRenderQuantumFollowShooter));
		}

		// Token: 0x06026083 RID: 155779 RVA: 0x0053E41C File Offset: 0x0053C61C
		public static IRenderQuantumFollowShooter GetRootAsIRenderQuantumFollowShooter(ByteBuffer _bb, IRenderQuantumFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026084 RID: 155780 RVA: 0x0053E439 File Offset: 0x0053C639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026085 RID: 155781 RVA: 0x0053E448 File Offset: 0x0053C648
		public IRenderQuantumFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8E3 RID: 43235
		// (get) Token: 0x06026086 RID: 155782 RVA: 0x0053E458 File Offset: 0x0053C658
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8E4 RID: 43236
		// (get) Token: 0x06026087 RID: 155783 RVA: 0x0053E494 File Offset: 0x0053C694
		public TTargetEntity CenterTargetType
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

		// Token: 0x06026088 RID: 155784 RVA: 0x0053E4D0 File Offset: 0x0053C6D0
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026089 RID: 155785 RVA: 0x0053E514 File Offset: 0x0053C714
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x0053E530 File Offset: 0x0053C730
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602608B RID: 155787 RVA: 0x0053E54C File Offset: 0x0053C74C
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602608C RID: 155788 RVA: 0x0053E568 File Offset: 0x0053C768
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602608D RID: 155789 RVA: 0x0053E584 File Offset: 0x0053C784
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700A8E5 RID: 43237
		// (get) Token: 0x0602608E RID: 155790 RVA: 0x0053E5A0 File Offset: 0x0053C7A0
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A8E6 RID: 43238
		// (get) Token: 0x0602608F RID: 155791 RVA: 0x0053E600 File Offset: 0x0053C800
		public IVectorInfo? Size
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A8E7 RID: 43239
		// (get) Token: 0x06026090 RID: 155792 RVA: 0x0053E660 File Offset: 0x0053C860
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026091 RID: 155793 RVA: 0x0053E6BE File Offset: 0x0053C8BE
		public static Offset<IRenderQuantumFollowShooter> CreateIRenderQuantumFollowShooter(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(6);
			IRenderQuantumFollowShooter.AddRotator(builder, RotatorOffset);
			IRenderQuantumFollowShooter.AddSize(builder, SizeOffset);
			IRenderQuantumFollowShooter.AddCenter(builder, CenterOffset);
			IRenderQuantumFollowShooter.AddCenterTarget(builder, CenterTargetOffset);
			IRenderQuantumFollowShooter.AddCenterTargetType(builder, CenterTarget_type);
			IRenderQuantumFollowShooter.AddType(builder, Type);
			return IRenderQuantumFollowShooter.EndIRenderQuantumFollowShooter(builder);
		}

		// Token: 0x06026092 RID: 155794 RVA: 0x0053E6FA File Offset: 0x0053C8FA
		public static void StartIRenderQuantumFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026093 RID: 155795 RVA: 0x0053E703 File Offset: 0x0053C903
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026094 RID: 155796 RVA: 0x0053E70E File Offset: 0x0053C90E
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(1, (byte)centerTargetType, 0);
		}

		// Token: 0x06026095 RID: 155797 RVA: 0x0053E719 File Offset: 0x0053C919
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(2, centerTargetOffset, 0);
		}

		// Token: 0x06026096 RID: 155798 RVA: 0x0053E724 File Offset: 0x0053C924
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(3, centerOffset.Value, 0);
		}

		// Token: 0x06026097 RID: 155799 RVA: 0x0053E734 File Offset: 0x0053C934
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x06026098 RID: 155800 RVA: 0x0053E744 File Offset: 0x0053C944
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(5, rotatorOffset.Value, 0);
		}

		// Token: 0x06026099 RID: 155801 RVA: 0x0053E754 File Offset: 0x0053C954
		public static Offset<IRenderQuantumFollowShooter> EndIRenderQuantumFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IRenderQuantumFollowShooter>(builder.EndTable());
		}

		// Token: 0x0602609A RID: 155802 RVA: 0x0053E764 File Offset: 0x0053C964
		public IRenderQuantumFollowShooterT UnPack()
		{
			IRenderQuantumFollowShooterT renderQuantumFollowShooterT = new IRenderQuantumFollowShooterT();
			this.UnPackTo(renderQuantumFollowShooterT);
			return renderQuantumFollowShooterT;
		}

		// Token: 0x0602609B RID: 155803 RVA: 0x0053E780 File Offset: 0x0053C980
		public void UnPackTo(IRenderQuantumFollowShooterT _o)
		{
			_o.Type = this.Type;
			_o.CenterTarget = new TTargetEntityUnion();
			_o.CenterTarget.Type = this.CenterTargetType;
			switch (this.CenterTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IPlayerEntity>() != null) ? this.CenterTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ISelfEntity>() != null) ? this.CenterTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITargetEntity>() != null) ? this.CenterTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITriggeredEntity>() != null) ? this.CenterTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IVehicleEntity>() != null) ? this.CenterTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x0602609C RID: 155804 RVA: 0x0053E990 File Offset: 0x0053CB90
		public static Offset<IRenderQuantumFollowShooter> Pack(FlatBufferBuilder builder, IRenderQuantumFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderQuantumFollowShooter>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IRenderQuantumFollowShooter.CreateIRenderQuantumFollowShooter(builder, _o.Type, centerTarget_type, centerTargetOffset, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400ED6B RID: 60779
		private Table __p;
	}
}
