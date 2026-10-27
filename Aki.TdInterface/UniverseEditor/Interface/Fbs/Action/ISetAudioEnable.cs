using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB1 RID: 28593
	public struct ISetAudioEnable : IFlatbufferObject
	{
		// Token: 0x1700D452 RID: 54354
		// (get) Token: 0x0603288F RID: 206991 RVA: 0x006D1E37 File Offset: 0x006D0037
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032890 RID: 206992 RVA: 0x006D1E44 File Offset: 0x006D0044
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032891 RID: 206993 RVA: 0x006D1E4C File Offset: 0x006D004C
		public static ISetAudioEnable GetRootAsISetAudioEnable(ByteBuffer _bb)
		{
			return ISetAudioEnable.GetRootAsISetAudioEnable(_bb, default(ISetAudioEnable));
		}

		// Token: 0x06032892 RID: 206994 RVA: 0x006D1E68 File Offset: 0x006D0068
		public static ISetAudioEnable GetRootAsISetAudioEnable(ByteBuffer _bb, ISetAudioEnable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032893 RID: 206995 RVA: 0x006D1E85 File Offset: 0x006D0085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032894 RID: 206996 RVA: 0x006D1E94 File Offset: 0x006D0094
		public ISetAudioEnable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D453 RID: 54355
		// (get) Token: 0x06032895 RID: 206997 RVA: 0x006D1EA4 File Offset: 0x006D00A4
		public EAudioEnableType SetAudioEnableType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioEnableType.Enable;
				}
				return (EAudioEnableType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D454 RID: 54356
		// (get) Token: 0x06032896 RID: 206998 RVA: 0x006D1EE0 File Offset: 0x006D00E0
		public IRoleSceneVoice? AudioType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRoleSceneVoice?(default(IRoleSceneVoice).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032897 RID: 206999 RVA: 0x006D1F3D File Offset: 0x006D013D
		public static Offset<ISetAudioEnable> CreateISetAudioEnable(FlatBufferBuilder builder, EAudioEnableType SetAudioEnableType = EAudioEnableType.Enable, Offset<IRoleSceneVoice> AudioTypeOffset = default(Offset<IRoleSceneVoice>))
		{
			builder.StartTable(2);
			ISetAudioEnable.AddAudioType(builder, AudioTypeOffset);
			ISetAudioEnable.AddSetAudioEnableType(builder, SetAudioEnableType);
			return ISetAudioEnable.EndISetAudioEnable(builder);
		}

		// Token: 0x06032898 RID: 207000 RVA: 0x006D1F5A File Offset: 0x006D015A
		public static void StartISetAudioEnable(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032899 RID: 207001 RVA: 0x006D1F63 File Offset: 0x006D0163
		public static void AddSetAudioEnableType(FlatBufferBuilder builder, EAudioEnableType setAudioEnableType)
		{
			builder.AddByte(0, (byte)setAudioEnableType, 0);
		}

		// Token: 0x0603289A RID: 207002 RVA: 0x006D1F6E File Offset: 0x006D016E
		public static void AddAudioType(FlatBufferBuilder builder, Offset<IRoleSceneVoice> audioTypeOffset)
		{
			builder.AddOffset(1, audioTypeOffset.Value, 0);
		}

		// Token: 0x0603289B RID: 207003 RVA: 0x006D1F7E File Offset: 0x006D017E
		public static Offset<ISetAudioEnable> EndISetAudioEnable(FlatBufferBuilder builder)
		{
			return new Offset<ISetAudioEnable>(builder.EndTable());
		}

		// Token: 0x0603289C RID: 207004 RVA: 0x006D1F8C File Offset: 0x006D018C
		public ISetAudioEnableT UnPack()
		{
			ISetAudioEnableT setAudioEnableT = new ISetAudioEnableT();
			this.UnPackTo(setAudioEnableT);
			return setAudioEnableT;
		}

		// Token: 0x0603289D RID: 207005 RVA: 0x006D1FA8 File Offset: 0x006D01A8
		public void UnPackTo(ISetAudioEnableT _o)
		{
			_o.SetAudioEnableType = this.SetAudioEnableType;
			_o.AudioType = ((this.AudioType != null) ? this.AudioType.Value.UnPack() : null);
		}

		// Token: 0x0603289E RID: 207006 RVA: 0x006D1FF0 File Offset: 0x006D01F0
		public static Offset<ISetAudioEnable> Pack(FlatBufferBuilder builder, ISetAudioEnableT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAudioEnable>);
			}
			Offset<IRoleSceneVoice> audioTypeOffset = (_o.AudioType == null) ? default(Offset<IRoleSceneVoice>) : IRoleSceneVoice.Pack(builder, _o.AudioType);
			return ISetAudioEnable.CreateISetAudioEnable(builder, _o.SetAudioEnableType, audioTypeOffset);
		}

		// Token: 0x040119B8 RID: 72120
		private Table __p;
	}
}
