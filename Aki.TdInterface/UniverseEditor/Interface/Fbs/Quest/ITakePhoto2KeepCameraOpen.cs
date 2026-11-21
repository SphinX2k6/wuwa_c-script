using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CB RID: 17867
	public struct ITakePhoto2KeepCameraOpen : IFlatbufferObject
	{
		// Token: 0x17007CFA RID: 31994
		// (get) Token: 0x0601A17F RID: 106879 RVA: 0x003B8151 File Offset: 0x003B6351
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A180 RID: 106880 RVA: 0x003B815E File Offset: 0x003B635E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A181 RID: 106881 RVA: 0x003B8168 File Offset: 0x003B6368
		public static ITakePhoto2KeepCameraOpen GetRootAsITakePhoto2KeepCameraOpen(ByteBuffer _bb)
		{
			return ITakePhoto2KeepCameraOpen.GetRootAsITakePhoto2KeepCameraOpen(_bb, default(ITakePhoto2KeepCameraOpen));
		}

		// Token: 0x0601A182 RID: 106882 RVA: 0x003B8184 File Offset: 0x003B6384
		public static ITakePhoto2KeepCameraOpen GetRootAsITakePhoto2KeepCameraOpen(ByteBuffer _bb, ITakePhoto2KeepCameraOpen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A183 RID: 106883 RVA: 0x003B81A1 File Offset: 0x003B63A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A184 RID: 106884 RVA: 0x003B81B0 File Offset: 0x003B63B0
		public ITakePhoto2KeepCameraOpen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CFB RID: 31995
		// (get) Token: 0x0601A185 RID: 106885 RVA: 0x003B81C0 File Offset: 0x003B63C0
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

		// Token: 0x0601A186 RID: 106886 RVA: 0x003B81FC File Offset: 0x003B63FC
		public static Offset<ITakePhoto2KeepCameraOpen> CreateITakePhoto2KeepCameraOpen(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior Type = ETakePhoto2SuccessCameraBehavior.KeepOpen)
		{
			builder.StartTable(1);
			ITakePhoto2KeepCameraOpen.AddType(builder, Type);
			return ITakePhoto2KeepCameraOpen.EndITakePhoto2KeepCameraOpen(builder);
		}

		// Token: 0x0601A187 RID: 106887 RVA: 0x003B8212 File Offset: 0x003B6412
		public static void StartITakePhoto2KeepCameraOpen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A188 RID: 106888 RVA: 0x003B821B File Offset: 0x003B641B
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A189 RID: 106889 RVA: 0x003B8226 File Offset: 0x003B6426
		public static Offset<ITakePhoto2KeepCameraOpen> EndITakePhoto2KeepCameraOpen(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2KeepCameraOpen>(builder.EndTable());
		}

		// Token: 0x0601A18A RID: 106890 RVA: 0x003B8234 File Offset: 0x003B6434
		public ITakePhoto2KeepCameraOpenT UnPack()
		{
			ITakePhoto2KeepCameraOpenT takePhoto2KeepCameraOpenT = new ITakePhoto2KeepCameraOpenT();
			this.UnPackTo(takePhoto2KeepCameraOpenT);
			return takePhoto2KeepCameraOpenT;
		}

		// Token: 0x0601A18B RID: 106891 RVA: 0x003B824F File Offset: 0x003B644F
		public void UnPackTo(ITakePhoto2KeepCameraOpenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A18C RID: 106892 RVA: 0x003B8260 File Offset: 0x003B6460
		public static Offset<ITakePhoto2KeepCameraOpen> Pack(FlatBufferBuilder builder, ITakePhoto2KeepCameraOpenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2KeepCameraOpen>);
			}
			return ITakePhoto2KeepCameraOpen.CreateITakePhoto2KeepCameraOpen(builder, _o.Type);
		}

		// Token: 0x0400C7A4 RID: 51108
		private Table __p;
	}
}
