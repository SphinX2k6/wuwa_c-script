using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777A RID: 30586
	public struct ISetAudioEnable : IFlatbufferObject
	{
		// Token: 0x1700E026 RID: 57382
		// (get) Token: 0x06035AF5 RID: 219893 RVA: 0x00731A7C File Offset: 0x0072FC7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AF6 RID: 219894 RVA: 0x00731A89 File Offset: 0x0072FC89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AF7 RID: 219895 RVA: 0x00731A90 File Offset: 0x0072FC90
		public static ISetAudioEnable GetRootAsISetAudioEnable(ByteBuffer _bb)
		{
			return ISetAudioEnable.GetRootAsISetAudioEnable(_bb, default(ISetAudioEnable));
		}

		// Token: 0x06035AF8 RID: 219896 RVA: 0x00731AAC File Offset: 0x0072FCAC
		public static ISetAudioEnable GetRootAsISetAudioEnable(ByteBuffer _bb, ISetAudioEnable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AF9 RID: 219897 RVA: 0x00731AC9 File Offset: 0x0072FCC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AFA RID: 219898 RVA: 0x00731AD8 File Offset: 0x0072FCD8
		public ISetAudioEnable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E027 RID: 57383
		// (get) Token: 0x06035AFB RID: 219899 RVA: 0x00731AE8 File Offset: 0x0072FCE8
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

		// Token: 0x1700E028 RID: 57384
		// (get) Token: 0x06035AFC RID: 219900 RVA: 0x00731B24 File Offset: 0x0072FD24
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

		// Token: 0x06035AFD RID: 219901 RVA: 0x00731B81 File Offset: 0x0072FD81
		public static Offset<ISetAudioEnable> CreateISetAudioEnable(FlatBufferBuilder builder, EAudioEnableType SetAudioEnableType = EAudioEnableType.Enable, Offset<IRoleSceneVoice> AudioTypeOffset = default(Offset<IRoleSceneVoice>))
		{
			builder.StartTable(2);
			ISetAudioEnable.AddAudioType(builder, AudioTypeOffset);
			ISetAudioEnable.AddSetAudioEnableType(builder, SetAudioEnableType);
			return ISetAudioEnable.EndISetAudioEnable(builder);
		}

		// Token: 0x06035AFE RID: 219902 RVA: 0x00731B9E File Offset: 0x0072FD9E
		public static void StartISetAudioEnable(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035AFF RID: 219903 RVA: 0x00731BA7 File Offset: 0x0072FDA7
		public static void AddSetAudioEnableType(FlatBufferBuilder builder, EAudioEnableType setAudioEnableType)
		{
			builder.AddByte(0, (byte)setAudioEnableType, 0);
		}

		// Token: 0x06035B00 RID: 219904 RVA: 0x00731BB2 File Offset: 0x0072FDB2
		public static void AddAudioType(FlatBufferBuilder builder, Offset<IRoleSceneVoice> audioTypeOffset)
		{
			builder.AddOffset(1, audioTypeOffset.Value, 0);
		}

		// Token: 0x06035B01 RID: 219905 RVA: 0x00731BC2 File Offset: 0x0072FDC2
		public static Offset<ISetAudioEnable> EndISetAudioEnable(FlatBufferBuilder builder)
		{
			return new Offset<ISetAudioEnable>(builder.EndTable());
		}

		// Token: 0x06035B02 RID: 219906 RVA: 0x00731BD0 File Offset: 0x0072FDD0
		public ISetAudioEnableT UnPack()
		{
			ISetAudioEnableT setAudioEnableT = new ISetAudioEnableT();
			this.UnPackTo(setAudioEnableT);
			return setAudioEnableT;
		}

		// Token: 0x06035B03 RID: 219907 RVA: 0x00731BEC File Offset: 0x0072FDEC
		public void UnPackTo(ISetAudioEnableT _o)
		{
			_o.SetAudioEnableType = this.SetAudioEnableType;
			_o.AudioType = ((this.AudioType != null) ? this.AudioType.Value.UnPack() : null);
		}

		// Token: 0x06035B04 RID: 219908 RVA: 0x00731C34 File Offset: 0x0072FE34
		public static Offset<ISetAudioEnable> Pack(FlatBufferBuilder builder, ISetAudioEnableT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAudioEnable>);
			}
			Offset<IRoleSceneVoice> audioTypeOffset = (_o.AudioType == null) ? default(Offset<IRoleSceneVoice>) : IRoleSceneVoice.Pack(builder, _o.AudioType);
			return ISetAudioEnable.CreateISetAudioEnable(builder, _o.SetAudioEnableType, audioTypeOffset);
		}

		// Token: 0x0401299D RID: 76189
		private Table __p;
	}
}
