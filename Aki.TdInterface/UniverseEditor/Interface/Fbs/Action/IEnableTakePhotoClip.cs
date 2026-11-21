using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D10 RID: 27920
	public struct IEnableTakePhotoClip : IFlatbufferObject
	{
		// Token: 0x1700CCDF RID: 52447
		// (get) Token: 0x06030274 RID: 197236 RVA: 0x0068C782 File Offset: 0x0068A982
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030275 RID: 197237 RVA: 0x0068C78F File Offset: 0x0068A98F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030276 RID: 197238 RVA: 0x0068C798 File Offset: 0x0068A998
		public static IEnableTakePhotoClip GetRootAsIEnableTakePhotoClip(ByteBuffer _bb)
		{
			return IEnableTakePhotoClip.GetRootAsIEnableTakePhotoClip(_bb, default(IEnableTakePhotoClip));
		}

		// Token: 0x06030277 RID: 197239 RVA: 0x0068C7B4 File Offset: 0x0068A9B4
		public static IEnableTakePhotoClip GetRootAsIEnableTakePhotoClip(ByteBuffer _bb, IEnableTakePhotoClip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030278 RID: 197240 RVA: 0x0068C7D1 File Offset: 0x0068A9D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030279 RID: 197241 RVA: 0x0068C7E0 File Offset: 0x0068A9E0
		public IEnableTakePhotoClip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCE0 RID: 52448
		// (get) Token: 0x0603027A RID: 197242 RVA: 0x0068C7F0 File Offset: 0x0068A9F0
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603027B RID: 197243 RVA: 0x0068C82F File Offset: 0x0068AA2F
		public static Offset<IEnableTakePhotoClip> CreateIEnableTakePhotoClip(FlatBufferBuilder builder, bool Enable = false)
		{
			builder.StartTable(1);
			IEnableTakePhotoClip.AddEnable(builder, Enable);
			return IEnableTakePhotoClip.EndIEnableTakePhotoClip(builder);
		}

		// Token: 0x0603027C RID: 197244 RVA: 0x0068C845 File Offset: 0x0068AA45
		public static void StartIEnableTakePhotoClip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603027D RID: 197245 RVA: 0x0068C84E File Offset: 0x0068AA4E
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0603027E RID: 197246 RVA: 0x0068C859 File Offset: 0x0068AA59
		public static Offset<IEnableTakePhotoClip> EndIEnableTakePhotoClip(FlatBufferBuilder builder)
		{
			return new Offset<IEnableTakePhotoClip>(builder.EndTable());
		}

		// Token: 0x0603027F RID: 197247 RVA: 0x0068C868 File Offset: 0x0068AA68
		public IEnableTakePhotoClipT UnPack()
		{
			IEnableTakePhotoClipT enableTakePhotoClipT = new IEnableTakePhotoClipT();
			this.UnPackTo(enableTakePhotoClipT);
			return enableTakePhotoClipT;
		}

		// Token: 0x06030280 RID: 197248 RVA: 0x0068C883 File Offset: 0x0068AA83
		public void UnPackTo(IEnableTakePhotoClipT _o)
		{
			_o.Enable = this.Enable;
		}

		// Token: 0x06030281 RID: 197249 RVA: 0x0068C894 File Offset: 0x0068AA94
		public static Offset<IEnableTakePhotoClip> Pack(FlatBufferBuilder builder, IEnableTakePhotoClipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableTakePhotoClip>);
			}
			return IEnableTakePhotoClip.CreateIEnableTakePhotoClip(builder, _o.Enable);
		}

		// Token: 0x04011B78 RID: 72568
		private Table __p;
	}
}
