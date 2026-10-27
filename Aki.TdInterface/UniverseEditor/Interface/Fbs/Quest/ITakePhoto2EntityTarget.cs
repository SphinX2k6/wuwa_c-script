using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417E RID: 16766
	public struct ITakePhoto2EntityTarget : IFlatbufferObject
	{
		// Token: 0x170076C8 RID: 30408
		// (get) Token: 0x06018A47 RID: 100935 RVA: 0x0038CB17 File Offset: 0x0038AD17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A48 RID: 100936 RVA: 0x0038CB24 File Offset: 0x0038AD24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A49 RID: 100937 RVA: 0x0038CB2C File Offset: 0x0038AD2C
		public static ITakePhoto2EntityTarget GetRootAsITakePhoto2EntityTarget(ByteBuffer _bb)
		{
			return ITakePhoto2EntityTarget.GetRootAsITakePhoto2EntityTarget(_bb, default(ITakePhoto2EntityTarget));
		}

		// Token: 0x06018A4A RID: 100938 RVA: 0x0038CB48 File Offset: 0x0038AD48
		public static ITakePhoto2EntityTarget GetRootAsITakePhoto2EntityTarget(ByteBuffer _bb, ITakePhoto2EntityTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A4B RID: 100939 RVA: 0x0038CB65 File Offset: 0x0038AD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A4C RID: 100940 RVA: 0x0038CB74 File Offset: 0x0038AD74
		public ITakePhoto2EntityTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076C9 RID: 30409
		// (get) Token: 0x06018A4D RID: 100941 RVA: 0x0038CB84 File Offset: 0x0038AD84
		public ETakePhoto2TargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return (ETakePhoto2TargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076CA RID: 30410
		// (get) Token: 0x06018A4E RID: 100942 RVA: 0x0038CBC0 File Offset: 0x0038ADC0
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076CB RID: 30411
		// (get) Token: 0x06018A4F RID: 100943 RVA: 0x0038CC00 File Offset: 0x0038AE00
		public ITakePhoto2TargetCameraDistanceCondition? TargetCameraDistanceCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetCameraDistanceCondition?(default(ITakePhoto2TargetCameraDistanceCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076CC RID: 30412
		// (get) Token: 0x06018A50 RID: 100944 RVA: 0x0038CC60 File Offset: 0x0038AE60
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076CD RID: 30413
		// (get) Token: 0x06018A51 RID: 100945 RVA: 0x0038CCA0 File Offset: 0x0038AEA0
		public ITakePhoto2TargetPosByRangeCondition? TargetPosCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPosByRangeCondition?(default(ITakePhoto2TargetPosByRangeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076CE RID: 30414
		// (get) Token: 0x06018A52 RID: 100946 RVA: 0x0038CD00 File Offset: 0x0038AF00
		public ITakePhoto2TargetPlayMontageCondition? TargetPlayMontageCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPlayMontageCondition?(default(ITakePhoto2TargetPlayMontageCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076CF RID: 30415
		// (get) Token: 0x06018A53 RID: 100947 RVA: 0x0038CD60 File Offset: 0x0038AF60
		public ITakePhoto2TargetAnsTagCondition? TargetAnsTagCondition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetAnsTagCondition?(default(ITakePhoto2TargetAnsTagCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076D0 RID: 30416
		// (get) Token: 0x06018A54 RID: 100948 RVA: 0x0038CDC0 File Offset: 0x0038AFC0
		public ITakePhoto2TargetPartCondition? TargetPartCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPartCondition?(default(ITakePhoto2TargetPartCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076D1 RID: 30417
		// (get) Token: 0x06018A55 RID: 100949 RVA: 0x0038CE20 File Offset: 0x0038B020
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x0038CE60 File Offset: 0x0038B060
		public static Offset<ITakePhoto2EntityTarget> CreateITakePhoto2EntityTarget(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), int EntityId = 0, Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), Offset<ITakePhoto2TargetPlayMontageCondition> TargetPlayMontageConditionOffset = default(Offset<ITakePhoto2TargetPlayMontageCondition>), Offset<ITakePhoto2TargetAnsTagCondition> TargetAnsTagConditionOffset = default(Offset<ITakePhoto2TargetAnsTagCondition>), Offset<ITakePhoto2TargetPartCondition> TargetPartConditionOffset = default(Offset<ITakePhoto2TargetPartCondition>), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITakePhoto2EntityTarget.AddTargetPartCondition(builder, TargetPartConditionOffset);
			ITakePhoto2EntityTarget.AddTargetAnsTagCondition(builder, TargetAnsTagConditionOffset);
			ITakePhoto2EntityTarget.AddTargetPlayMontageCondition(builder, TargetPlayMontageConditionOffset);
			ITakePhoto2EntityTarget.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2EntityTarget.AddEntityId(builder, EntityId);
			ITakePhoto2EntityTarget.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2EntityTarget.AddNullMask(builder, NullMask);
			ITakePhoto2EntityTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2EntityTarget.AddType(builder, Type);
			return ITakePhoto2EntityTarget.EndITakePhoto2EntityTarget(builder);
		}

		// Token: 0x06018A57 RID: 100951 RVA: 0x0038CEC0 File Offset: 0x0038B0C0
		public static void StartITakePhoto2EntityTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x0038CECA File Offset: 0x0038B0CA
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x0038CED5 File Offset: 0x0038B0D5
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x0038CEF0 File Offset: 0x0038B0F0
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x0038CEFB File Offset: 0x0038B0FB
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x0038CF0B File Offset: 0x0038B10B
		public static void AddTargetPlayMontageCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset)
		{
			builder.AddOffset(5, targetPlayMontageConditionOffset.Value, 0);
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x0038CF1B File Offset: 0x0038B11B
		public static void AddTargetAnsTagCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset)
		{
			builder.AddOffset(6, targetAnsTagConditionOffset.Value, 0);
		}

		// Token: 0x06018A5F RID: 100959 RVA: 0x0038CF2B File Offset: 0x0038B12B
		public static void AddTargetPartCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPartCondition> targetPartConditionOffset)
		{
			builder.AddOffset(7, targetPartConditionOffset.Value, 0);
		}

		// Token: 0x06018A60 RID: 100960 RVA: 0x0038CF3B File Offset: 0x0038B13B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x0038CF46 File Offset: 0x0038B146
		public static Offset<ITakePhoto2EntityTarget> EndITakePhoto2EntityTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2EntityTarget>(builder.EndTable());
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x0038CF54 File Offset: 0x0038B154
		public ITakePhoto2EntityTargetT UnPack()
		{
			ITakePhoto2EntityTargetT takePhoto2EntityTargetT = new ITakePhoto2EntityTargetT();
			this.UnPackTo(takePhoto2EntityTargetT);
			return takePhoto2EntityTargetT;
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x0038CF70 File Offset: 0x0038B170
		public void UnPackTo(ITakePhoto2EntityTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.TargetPlayMontageCondition = ((this.TargetPlayMontageCondition != null) ? this.TargetPlayMontageCondition.Value.UnPack() : null);
			_o.TargetAnsTagCondition = ((this.TargetAnsTagCondition != null) ? this.TargetAnsTagCondition.Value.UnPack() : null);
			_o.TargetPartCondition = ((this.TargetPartCondition != null) ? this.TargetPartCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018A64 RID: 100964 RVA: 0x0038D0A4 File Offset: 0x0038B2A4
		public static Offset<ITakePhoto2EntityTarget> Pack(FlatBufferBuilder builder, ITakePhoto2EntityTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2EntityTarget>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset = (_o.TargetPlayMontageCondition == null) ? default(Offset<ITakePhoto2TargetPlayMontageCondition>) : ITakePhoto2TargetPlayMontageCondition.Pack(builder, _o.TargetPlayMontageCondition);
			Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset = (_o.TargetAnsTagCondition == null) ? default(Offset<ITakePhoto2TargetAnsTagCondition>) : ITakePhoto2TargetAnsTagCondition.Pack(builder, _o.TargetAnsTagCondition);
			Offset<ITakePhoto2TargetPartCondition> targetPartConditionOffset = (_o.TargetPartCondition == null) ? default(Offset<ITakePhoto2TargetPartCondition>) : ITakePhoto2TargetPartCondition.Pack(builder, _o.TargetPartCondition);
			return ITakePhoto2EntityTarget.CreateITakePhoto2EntityTarget(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, _o.EntityId, targetPosConditionOffset, targetPlayMontageConditionOffset, targetAnsTagConditionOffset, targetPartConditionOffset, _o.NullMask);
		}

		// Token: 0x0400BDA3 RID: 48547
		private Table __p;
	}
}
