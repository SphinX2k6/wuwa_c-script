using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045DD RID: 17885
	public struct ITakePhoto2SuccessCameraBehaviorBase : IFlatbufferObject
	{
		// Token: 0x17007D15 RID: 32021
		// (get) Token: 0x0601A1FB RID: 107003 RVA: 0x003B8DA0 File Offset: 0x003B6FA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1FC RID: 107004 RVA: 0x003B8DAD File Offset: 0x003B6FAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1FD RID: 107005 RVA: 0x003B8DB4 File Offset: 0x003B6FB4
		public static ITakePhoto2SuccessCameraBehaviorBase GetRootAsITakePhoto2SuccessCameraBehaviorBase(ByteBuffer _bb)
		{
			return ITakePhoto2SuccessCameraBehaviorBase.GetRootAsITakePhoto2SuccessCameraBehaviorBase(_bb, default(ITakePhoto2SuccessCameraBehaviorBase));
		}

		// Token: 0x0601A1FE RID: 107006 RVA: 0x003B8DD0 File Offset: 0x003B6FD0
		public static ITakePhoto2SuccessCameraBehaviorBase GetRootAsITakePhoto2SuccessCameraBehaviorBase(ByteBuffer _bb, ITakePhoto2SuccessCameraBehaviorBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1FF RID: 107007 RVA: 0x003B8DED File Offset: 0x003B6FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A200 RID: 107008 RVA: 0x003B8DFC File Offset: 0x003B6FFC
		public ITakePhoto2SuccessCameraBehaviorBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D16 RID: 32022
		// (get) Token: 0x0601A201 RID: 107009 RVA: 0x003B8E0C File Offset: 0x003B700C
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

		// Token: 0x0601A202 RID: 107010 RVA: 0x003B8E48 File Offset: 0x003B7048
		public static Offset<ITakePhoto2SuccessCameraBehaviorBase> CreateITakePhoto2SuccessCameraBehaviorBase(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior Type = ETakePhoto2SuccessCameraBehavior.KeepOpen)
		{
			builder.StartTable(1);
			ITakePhoto2SuccessCameraBehaviorBase.AddType(builder, Type);
			return ITakePhoto2SuccessCameraBehaviorBase.EndITakePhoto2SuccessCameraBehaviorBase(builder);
		}

		// Token: 0x0601A203 RID: 107011 RVA: 0x003B8E5E File Offset: 0x003B705E
		public static void StartITakePhoto2SuccessCameraBehaviorBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A204 RID: 107012 RVA: 0x003B8E67 File Offset: 0x003B7067
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2SuccessCameraBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A205 RID: 107013 RVA: 0x003B8E72 File Offset: 0x003B7072
		public static Offset<ITakePhoto2SuccessCameraBehaviorBase> EndITakePhoto2SuccessCameraBehaviorBase(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2SuccessCameraBehaviorBase>(builder.EndTable());
		}

		// Token: 0x0601A206 RID: 107014 RVA: 0x003B8E80 File Offset: 0x003B7080
		public ITakePhoto2SuccessCameraBehaviorBaseT UnPack()
		{
			ITakePhoto2SuccessCameraBehaviorBaseT takePhoto2SuccessCameraBehaviorBaseT = new ITakePhoto2SuccessCameraBehaviorBaseT();
			this.UnPackTo(takePhoto2SuccessCameraBehaviorBaseT);
			return takePhoto2SuccessCameraBehaviorBaseT;
		}

		// Token: 0x0601A207 RID: 107015 RVA: 0x003B8E9B File Offset: 0x003B709B
		public void UnPackTo(ITakePhoto2SuccessCameraBehaviorBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A208 RID: 107016 RVA: 0x003B8EAC File Offset: 0x003B70AC
		public static Offset<ITakePhoto2SuccessCameraBehaviorBase> Pack(FlatBufferBuilder builder, ITakePhoto2SuccessCameraBehaviorBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2SuccessCameraBehaviorBase>);
			}
			return ITakePhoto2SuccessCameraBehaviorBase.CreateITakePhoto2SuccessCameraBehaviorBase(builder, _o.Type);
		}

		// Token: 0x0400C7B9 RID: 51129
		private Table __p;
	}
}
