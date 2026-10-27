using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A87 RID: 19079
	public struct ICheckIsEntityTimeScaleEnabled : IFlatbufferObject
	{
		// Token: 0x17008A37 RID: 35383
		// (get) Token: 0x0601DEAC RID: 122540 RVA: 0x004339EE File Offset: 0x00431BEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DEAD RID: 122541 RVA: 0x004339FB File Offset: 0x00431BFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DEAE RID: 122542 RVA: 0x00433A04 File Offset: 0x00431C04
		public static ICheckIsEntityTimeScaleEnabled GetRootAsICheckIsEntityTimeScaleEnabled(ByteBuffer _bb)
		{
			return ICheckIsEntityTimeScaleEnabled.GetRootAsICheckIsEntityTimeScaleEnabled(_bb, default(ICheckIsEntityTimeScaleEnabled));
		}

		// Token: 0x0601DEAF RID: 122543 RVA: 0x00433A20 File Offset: 0x00431C20
		public static ICheckIsEntityTimeScaleEnabled GetRootAsICheckIsEntityTimeScaleEnabled(ByteBuffer _bb, ICheckIsEntityTimeScaleEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DEB0 RID: 122544 RVA: 0x00433A3D File Offset: 0x00431C3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DEB1 RID: 122545 RVA: 0x00433A4C File Offset: 0x00431C4C
		public ICheckIsEntityTimeScaleEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A38 RID: 35384
		// (get) Token: 0x0601DEB2 RID: 122546 RVA: 0x00433A5C File Offset: 0x00431C5C
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

		// Token: 0x17008A39 RID: 35385
		// (get) Token: 0x0601DEB3 RID: 122547 RVA: 0x00433A98 File Offset: 0x00431C98
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

		// Token: 0x0601DEB4 RID: 122548 RVA: 0x00433AD4 File Offset: 0x00431CD4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DEB5 RID: 122549 RVA: 0x00433B18 File Offset: 0x00431D18
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601DEB6 RID: 122550 RVA: 0x00433B34 File Offset: 0x00431D34
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601DEB7 RID: 122551 RVA: 0x00433B50 File Offset: 0x00431D50
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601DEB8 RID: 122552 RVA: 0x00433B6C File Offset: 0x00431D6C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008A3A RID: 35386
		// (get) Token: 0x0601DEB9 RID: 122553 RVA: 0x00433B88 File Offset: 0x00431D88
		public bool Enabled
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DEBA RID: 122554 RVA: 0x00433BC8 File Offset: 0x00431DC8
		public static Offset<ICheckIsEntityTimeScaleEnabled> CreateICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, bool Enabled = false)
		{
			builder.StartTable(4);
			ICheckIsEntityTimeScaleEnabled.AddTarget(builder, TargetOffset);
			ICheckIsEntityTimeScaleEnabled.AddEnabled(builder, Enabled);
			ICheckIsEntityTimeScaleEnabled.AddTargetType(builder, Target_type);
			ICheckIsEntityTimeScaleEnabled.AddType(builder, Type);
			return ICheckIsEntityTimeScaleEnabled.EndICheckIsEntityTimeScaleEnabled(builder);
		}

		// Token: 0x0601DEBB RID: 122555 RVA: 0x00433BF4 File Offset: 0x00431DF4
		public static void StartICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DEBC RID: 122556 RVA: 0x00433BFD File Offset: 0x00431DFD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DEBD RID: 122557 RVA: 0x00433C08 File Offset: 0x00431E08
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601DEBE RID: 122558 RVA: 0x00433C13 File Offset: 0x00431E13
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601DEBF RID: 122559 RVA: 0x00433C1E File Offset: 0x00431E1E
		public static void AddEnabled(FlatBufferBuilder builder, bool enabled)
		{
			builder.AddBool(3, enabled, false);
		}

		// Token: 0x0601DEC0 RID: 122560 RVA: 0x00433C29 File Offset: 0x00431E29
		public static Offset<ICheckIsEntityTimeScaleEnabled> EndICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsEntityTimeScaleEnabled>(builder.EndTable());
		}

		// Token: 0x0601DEC1 RID: 122561 RVA: 0x00433C38 File Offset: 0x00431E38
		public ICheckIsEntityTimeScaleEnabledT UnPack()
		{
			ICheckIsEntityTimeScaleEnabledT checkIsEntityTimeScaleEnabledT = new ICheckIsEntityTimeScaleEnabledT();
			this.UnPackTo(checkIsEntityTimeScaleEnabledT);
			return checkIsEntityTimeScaleEnabledT;
		}

		// Token: 0x0601DEC2 RID: 122562 RVA: 0x00433C54 File Offset: 0x00431E54
		public void UnPackTo(ICheckIsEntityTimeScaleEnabledT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.Enabled = this.Enabled;
		}

		// Token: 0x0601DEC3 RID: 122563 RVA: 0x00433D9C File Offset: 0x00431F9C
		public static Offset<ICheckIsEntityTimeScaleEnabled> Pack(FlatBufferBuilder builder, ICheckIsEntityTimeScaleEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsEntityTimeScaleEnabled>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICheckIsEntityTimeScaleEnabled.CreateICheckIsEntityTimeScaleEnabled(builder, _o.Type, target_type, targetOffset, _o.Enabled);
		}

		// Token: 0x0400D2F5 RID: 54005
		private Table __p;
	}
}
