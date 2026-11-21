using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C2 RID: 17858
	public struct ITakePhoto2CloseCameraAfterFinishActions : IFlatbufferObject
	{
		// Token: 0x17007CC6 RID: 31942
		// (get) Token: 0x0601A0DD RID: 106717 RVA: 0x003B663A File Offset: 0x003B483A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0DE RID: 106718 RVA: 0x003B6647 File Offset: 0x003B4847
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0DF RID: 106719 RVA: 0x003B6650 File Offset: 0x003B4850
		public static ITakePhoto2CloseCameraAfterFinishActions GetRootAsITakePhoto2CloseCameraAfterFinishActions(ByteBuffer _bb)
		{
			return ITakePhoto2CloseCameraAfterFinishActions.GetRootAsITakePhoto2CloseCameraAfterFinishActions(_bb, default(ITakePhoto2CloseCameraAfterFinishActions));
		}

		// Token: 0x0601A0E0 RID: 106720 RVA: 0x003B666C File Offset: 0x003B486C
		public static ITakePhoto2CloseCameraAfterFinishActions GetRootAsITakePhoto2CloseCameraAfterFinishActions(ByteBuffer _bb, ITakePhoto2CloseCameraAfterFinishActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0E1 RID: 106721 RVA: 0x003B6689 File Offset: 0x003B4889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0E2 RID: 106722 RVA: 0x003B6698 File Offset: 0x003B4898
		public ITakePhoto2CloseCameraAfterFinishActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CC7 RID: 31943
		// (get) Token: 0x0601A0E3 RID: 106723 RVA: 0x003B66A8 File Offset: 0x003B48A8
		public ETakePhoto2SuccessCameraBehavior Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2SuccessCameraBehavior.KeepOpen;
				}
				return (ETakePhoto2SuccessCameraBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A0E4 RID: 106724 RVA: 0x003B66E4 File Offset: 0x003B48E4
		public static Offset<ITakePhoto2CloseCameraAfterFinishActions> CreateITakePhoto2CloseCameraAfterFinishActions(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior Type = ETakePhoto2SuccessCameraBehavior.KeepOpen)
		{
			builder.StartTable(1);
			ITakePhoto2CloseCameraAfterFinishActions.AddType(builder, Type);
			return ITakePhoto2CloseCameraAfterFinishActions.EndITakePhoto2CloseCameraAfterFinishActions(builder);
		}

		// Token: 0x0601A0E5 RID: 106725 RVA: 0x003B66FA File Offset: 0x003B48FA
		public static void StartITakePhoto2CloseCameraAfterFinishActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A0E6 RID: 106726 RVA: 0x003B6703 File Offset: 0x003B4903
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A0E7 RID: 106727 RVA: 0x003B670E File Offset: 0x003B490E
		public static Offset<ITakePhoto2CloseCameraAfterFinishActions> EndITakePhoto2CloseCameraAfterFinishActions(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2CloseCameraAfterFinishActions>(builder.EndTable());
		}

		// Token: 0x0601A0E8 RID: 106728 RVA: 0x003B671C File Offset: 0x003B491C
		public ITakePhoto2CloseCameraAfterFinishActionsT UnPack()
		{
			ITakePhoto2CloseCameraAfterFinishActionsT takePhoto2CloseCameraAfterFinishActionsT = new ITakePhoto2CloseCameraAfterFinishActionsT();
			this.UnPackTo(takePhoto2CloseCameraAfterFinishActionsT);
			return takePhoto2CloseCameraAfterFinishActionsT;
		}

		// Token: 0x0601A0E9 RID: 106729 RVA: 0x003B6737 File Offset: 0x003B4937
		public void UnPackTo(ITakePhoto2CloseCameraAfterFinishActionsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A0EA RID: 106730 RVA: 0x003B6748 File Offset: 0x003B4948
		public static Offset<ITakePhoto2CloseCameraAfterFinishActions> Pack(FlatBufferBuilder builder, ITakePhoto2CloseCameraAfterFinishActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2CloseCameraAfterFinishActions>);
			}
			return ITakePhoto2CloseCameraAfterFinishActions.CreateITakePhoto2CloseCameraAfterFinishActions(builder, _o.Type);
		}

		// Token: 0x0400C789 RID: 51081
		private Table __p;
	}
}
