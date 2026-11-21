using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BF RID: 17855
	public struct ITakePhoto2CameraFovCondition : IFlatbufferObject
	{
		// Token: 0x17007CC1 RID: 31937
		// (get) Token: 0x0601A0C7 RID: 106695 RVA: 0x003B643C File Offset: 0x003B463C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0C8 RID: 106696 RVA: 0x003B6449 File Offset: 0x003B4649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0C9 RID: 106697 RVA: 0x003B6450 File Offset: 0x003B4650
		public static ITakePhoto2CameraFovCondition GetRootAsITakePhoto2CameraFovCondition(ByteBuffer _bb)
		{
			return ITakePhoto2CameraFovCondition.GetRootAsITakePhoto2CameraFovCondition(_bb, default(ITakePhoto2CameraFovCondition));
		}

		// Token: 0x0601A0CA RID: 106698 RVA: 0x003B646C File Offset: 0x003B466C
		public static ITakePhoto2CameraFovCondition GetRootAsITakePhoto2CameraFovCondition(ByteBuffer _bb, ITakePhoto2CameraFovCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0CB RID: 106699 RVA: 0x003B6489 File Offset: 0x003B4689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0CC RID: 106700 RVA: 0x003B6498 File Offset: 0x003B4698
		public ITakePhoto2CameraFovCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CC2 RID: 31938
		// (get) Token: 0x0601A0CD RID: 106701 RVA: 0x003B64A8 File Offset: 0x003B46A8
		public int MinFov
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CC3 RID: 31939
		// (get) Token: 0x0601A0CE RID: 106702 RVA: 0x003B64E4 File Offset: 0x003B46E4
		public int MaxFov
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A0CF RID: 106703 RVA: 0x003B6520 File Offset: 0x003B4720
		public static Offset<ITakePhoto2CameraFovCondition> CreateITakePhoto2CameraFovCondition(FlatBufferBuilder builder, int MinFov = 0, int MaxFov = 0)
		{
			builder.StartTable(2);
			ITakePhoto2CameraFovCondition.AddMaxFov(builder, MaxFov);
			ITakePhoto2CameraFovCondition.AddMinFov(builder, MinFov);
			return ITakePhoto2CameraFovCondition.EndITakePhoto2CameraFovCondition(builder);
		}

		// Token: 0x0601A0D0 RID: 106704 RVA: 0x003B653D File Offset: 0x003B473D
		public static void StartITakePhoto2CameraFovCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A0D1 RID: 106705 RVA: 0x003B6546 File Offset: 0x003B4746
		public static void AddMinFov(FlatBufferBuilder builder, int minFov)
		{
			builder.AddInt(0, minFov, 0);
		}

		// Token: 0x0601A0D2 RID: 106706 RVA: 0x003B6551 File Offset: 0x003B4751
		public static void AddMaxFov(FlatBufferBuilder builder, int maxFov)
		{
			builder.AddInt(1, maxFov, 0);
		}

		// Token: 0x0601A0D3 RID: 106707 RVA: 0x003B655C File Offset: 0x003B475C
		public static Offset<ITakePhoto2CameraFovCondition> EndITakePhoto2CameraFovCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2CameraFovCondition>(builder.EndTable());
		}

		// Token: 0x0601A0D4 RID: 106708 RVA: 0x003B656C File Offset: 0x003B476C
		public ITakePhoto2CameraFovConditionT UnPack()
		{
			ITakePhoto2CameraFovConditionT takePhoto2CameraFovConditionT = new ITakePhoto2CameraFovConditionT();
			this.UnPackTo(takePhoto2CameraFovConditionT);
			return takePhoto2CameraFovConditionT;
		}

		// Token: 0x0601A0D5 RID: 106709 RVA: 0x003B6587 File Offset: 0x003B4787
		public void UnPackTo(ITakePhoto2CameraFovConditionT _o)
		{
			_o.MinFov = this.MinFov;
			_o.MaxFov = this.MaxFov;
		}

		// Token: 0x0601A0D6 RID: 106710 RVA: 0x003B65A4 File Offset: 0x003B47A4
		public static Offset<ITakePhoto2CameraFovCondition> Pack(FlatBufferBuilder builder, ITakePhoto2CameraFovConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2CameraFovCondition>);
			}
			return ITakePhoto2CameraFovCondition.CreateITakePhoto2CameraFovCondition(builder, _o.MinFov, _o.MaxFov);
		}

		// Token: 0x0400C786 RID: 51078
		private Table __p;
	}
}
