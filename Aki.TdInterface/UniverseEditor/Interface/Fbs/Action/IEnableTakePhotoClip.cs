using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006696 RID: 26262
	public struct IEnableTakePhotoClip : IFlatbufferObject
	{
		// Token: 0x1700C32E RID: 49966
		// (get) Token: 0x0602DA57 RID: 186967 RVA: 0x0063F4CE File Offset: 0x0063D6CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA58 RID: 186968 RVA: 0x0063F4DB File Offset: 0x0063D6DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA59 RID: 186969 RVA: 0x0063F4E4 File Offset: 0x0063D6E4
		public static IEnableTakePhotoClip GetRootAsIEnableTakePhotoClip(ByteBuffer _bb)
		{
			return IEnableTakePhotoClip.GetRootAsIEnableTakePhotoClip(_bb, default(IEnableTakePhotoClip));
		}

		// Token: 0x0602DA5A RID: 186970 RVA: 0x0063F500 File Offset: 0x0063D700
		public static IEnableTakePhotoClip GetRootAsIEnableTakePhotoClip(ByteBuffer _bb, IEnableTakePhotoClip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA5B RID: 186971 RVA: 0x0063F51D File Offset: 0x0063D71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA5C RID: 186972 RVA: 0x0063F52C File Offset: 0x0063D72C
		public IEnableTakePhotoClip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C32F RID: 49967
		// (get) Token: 0x0602DA5D RID: 186973 RVA: 0x0063F53C File Offset: 0x0063D73C
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602DA5E RID: 186974 RVA: 0x0063F57B File Offset: 0x0063D77B
		public static Offset<IEnableTakePhotoClip> CreateIEnableTakePhotoClip(FlatBufferBuilder builder, bool Enable = false)
		{
			builder.StartTable(1);
			IEnableTakePhotoClip.AddEnable(builder, Enable);
			return IEnableTakePhotoClip.EndIEnableTakePhotoClip(builder);
		}

		// Token: 0x0602DA5F RID: 186975 RVA: 0x0063F591 File Offset: 0x0063D791
		public static void StartIEnableTakePhotoClip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DA60 RID: 186976 RVA: 0x0063F59A File Offset: 0x0063D79A
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0602DA61 RID: 186977 RVA: 0x0063F5A5 File Offset: 0x0063D7A5
		public static Offset<IEnableTakePhotoClip> EndIEnableTakePhotoClip(FlatBufferBuilder builder)
		{
			return new Offset<IEnableTakePhotoClip>(builder.EndTable());
		}

		// Token: 0x0602DA62 RID: 186978 RVA: 0x0063F5B4 File Offset: 0x0063D7B4
		public IEnableTakePhotoClipT UnPack()
		{
			IEnableTakePhotoClipT enableTakePhotoClipT = new IEnableTakePhotoClipT();
			this.UnPackTo(enableTakePhotoClipT);
			return enableTakePhotoClipT;
		}

		// Token: 0x0602DA63 RID: 186979 RVA: 0x0063F5CF File Offset: 0x0063D7CF
		public void UnPackTo(IEnableTakePhotoClipT _o)
		{
			_o.Enable = this.Enable;
		}

		// Token: 0x0602DA64 RID: 186980 RVA: 0x0063F5E0 File Offset: 0x0063D7E0
		public static Offset<IEnableTakePhotoClip> Pack(FlatBufferBuilder builder, IEnableTakePhotoClipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableTakePhotoClip>);
			}
			return IEnableTakePhotoClip.CreateIEnableTakePhotoClip(builder, _o.Enable);
		}

		// Token: 0x04010D52 RID: 68946
		private Table __p;
	}
}
