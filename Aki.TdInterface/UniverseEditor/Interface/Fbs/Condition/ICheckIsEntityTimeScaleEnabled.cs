using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F4D RID: 20301
	public struct ICheckIsEntityTimeScaleEnabled : IFlatbufferObject
	{
		// Token: 0x17009113 RID: 37139
		// (get) Token: 0x0601F94F RID: 129359 RVA: 0x00464B7A File Offset: 0x00462D7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F950 RID: 129360 RVA: 0x00464B87 File Offset: 0x00462D87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F951 RID: 129361 RVA: 0x00464B90 File Offset: 0x00462D90
		public static ICheckIsEntityTimeScaleEnabled GetRootAsICheckIsEntityTimeScaleEnabled(ByteBuffer _bb)
		{
			return ICheckIsEntityTimeScaleEnabled.GetRootAsICheckIsEntityTimeScaleEnabled(_bb, default(ICheckIsEntityTimeScaleEnabled));
		}

		// Token: 0x0601F952 RID: 129362 RVA: 0x00464BAC File Offset: 0x00462DAC
		public static ICheckIsEntityTimeScaleEnabled GetRootAsICheckIsEntityTimeScaleEnabled(ByteBuffer _bb, ICheckIsEntityTimeScaleEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F953 RID: 129363 RVA: 0x00464BC9 File Offset: 0x00462DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F954 RID: 129364 RVA: 0x00464BD8 File Offset: 0x00462DD8
		public ICheckIsEntityTimeScaleEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009114 RID: 37140
		// (get) Token: 0x0601F955 RID: 129365 RVA: 0x00464BE8 File Offset: 0x00462DE8
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

		// Token: 0x17009115 RID: 37141
		// (get) Token: 0x0601F956 RID: 129366 RVA: 0x00464C24 File Offset: 0x00462E24
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

		// Token: 0x0601F957 RID: 129367 RVA: 0x00464C60 File Offset: 0x00462E60
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F958 RID: 129368 RVA: 0x00464CA4 File Offset: 0x00462EA4
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601F959 RID: 129369 RVA: 0x00464CC0 File Offset: 0x00462EC0
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601F95A RID: 129370 RVA: 0x00464CDC File Offset: 0x00462EDC
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601F95B RID: 129371 RVA: 0x00464CF8 File Offset: 0x00462EF8
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17009116 RID: 37142
		// (get) Token: 0x0601F95C RID: 129372 RVA: 0x00464D14 File Offset: 0x00462F14
		public bool Enabled
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F95D RID: 129373 RVA: 0x00464D54 File Offset: 0x00462F54
		public static Offset<ICheckIsEntityTimeScaleEnabled> CreateICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, bool Enabled = false)
		{
			builder.StartTable(4);
			ICheckIsEntityTimeScaleEnabled.AddTarget(builder, TargetOffset);
			ICheckIsEntityTimeScaleEnabled.AddEnabled(builder, Enabled);
			ICheckIsEntityTimeScaleEnabled.AddTargetType(builder, Target_type);
			ICheckIsEntityTimeScaleEnabled.AddType(builder, Type);
			return ICheckIsEntityTimeScaleEnabled.EndICheckIsEntityTimeScaleEnabled(builder);
		}

		// Token: 0x0601F95E RID: 129374 RVA: 0x00464D80 File Offset: 0x00462F80
		public static void StartICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F95F RID: 129375 RVA: 0x00464D89 File Offset: 0x00462F89
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F960 RID: 129376 RVA: 0x00464D94 File Offset: 0x00462F94
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F961 RID: 129377 RVA: 0x00464D9F File Offset: 0x00462F9F
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F962 RID: 129378 RVA: 0x00464DAA File Offset: 0x00462FAA
		public static void AddEnabled(FlatBufferBuilder builder, bool enabled)
		{
			builder.AddBool(3, enabled, false);
		}

		// Token: 0x0601F963 RID: 129379 RVA: 0x00464DB5 File Offset: 0x00462FB5
		public static Offset<ICheckIsEntityTimeScaleEnabled> EndICheckIsEntityTimeScaleEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsEntityTimeScaleEnabled>(builder.EndTable());
		}

		// Token: 0x0601F964 RID: 129380 RVA: 0x00464DC4 File Offset: 0x00462FC4
		public ICheckIsEntityTimeScaleEnabledT UnPack()
		{
			ICheckIsEntityTimeScaleEnabledT checkIsEntityTimeScaleEnabledT = new ICheckIsEntityTimeScaleEnabledT();
			this.UnPackTo(checkIsEntityTimeScaleEnabledT);
			return checkIsEntityTimeScaleEnabledT;
		}

		// Token: 0x0601F965 RID: 129381 RVA: 0x00464DE0 File Offset: 0x00462FE0
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

		// Token: 0x0601F966 RID: 129382 RVA: 0x00464F28 File Offset: 0x00463128
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

		// Token: 0x0400DDD0 RID: 56784
		private Table __p;
	}
}
