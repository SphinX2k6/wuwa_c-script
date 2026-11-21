using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0E RID: 23054
	public struct IIntervalSplineSpawnAudioConfigBase : IFlatbufferObject
	{
		// Token: 0x1700A795 RID: 42901
		// (get) Token: 0x06025A85 RID: 154245 RVA: 0x00529AC3 File Offset: 0x00527CC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A86 RID: 154246 RVA: 0x00529AD0 File Offset: 0x00527CD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A87 RID: 154247 RVA: 0x00529AD8 File Offset: 0x00527CD8
		public static IIntervalSplineSpawnAudioConfigBase GetRootAsIIntervalSplineSpawnAudioConfigBase(ByteBuffer _bb)
		{
			return IIntervalSplineSpawnAudioConfigBase.GetRootAsIIntervalSplineSpawnAudioConfigBase(_bb, default(IIntervalSplineSpawnAudioConfigBase));
		}

		// Token: 0x06025A88 RID: 154248 RVA: 0x00529AF4 File Offset: 0x00527CF4
		public static IIntervalSplineSpawnAudioConfigBase GetRootAsIIntervalSplineSpawnAudioConfigBase(ByteBuffer _bb, IIntervalSplineSpawnAudioConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A89 RID: 154249 RVA: 0x00529B11 File Offset: 0x00527D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A8A RID: 154250 RVA: 0x00529B20 File Offset: 0x00527D20
		public IIntervalSplineSpawnAudioConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A796 RID: 42902
		// (get) Token: 0x06025A8B RID: 154251 RVA: 0x00529B30 File Offset: 0x00527D30
		public EIntervalSplineSpawnAudioConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
				}
				return (EIntervalSplineSpawnAudioConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025A8C RID: 154252 RVA: 0x00529B6C File Offset: 0x00527D6C
		public static Offset<IIntervalSplineSpawnAudioConfigBase> CreateIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio)
		{
			builder.StartTable(1);
			IIntervalSplineSpawnAudioConfigBase.AddType(builder, Type);
			return IIntervalSplineSpawnAudioConfigBase.EndIIntervalSplineSpawnAudioConfigBase(builder);
		}

		// Token: 0x06025A8D RID: 154253 RVA: 0x00529B82 File Offset: 0x00527D82
		public static void StartIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025A8E RID: 154254 RVA: 0x00529B8B File Offset: 0x00527D8B
		public static void AddType(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025A8F RID: 154255 RVA: 0x00529B96 File Offset: 0x00527D96
		public static Offset<IIntervalSplineSpawnAudioConfigBase> EndIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawnAudioConfigBase>(builder.EndTable());
		}

		// Token: 0x06025A90 RID: 154256 RVA: 0x00529BA4 File Offset: 0x00527DA4
		public IIntervalSplineSpawnAudioConfigBaseT UnPack()
		{
			IIntervalSplineSpawnAudioConfigBaseT intervalSplineSpawnAudioConfigBaseT = new IIntervalSplineSpawnAudioConfigBaseT();
			this.UnPackTo(intervalSplineSpawnAudioConfigBaseT);
			return intervalSplineSpawnAudioConfigBaseT;
		}

		// Token: 0x06025A91 RID: 154257 RVA: 0x00529BBF File Offset: 0x00527DBF
		public void UnPackTo(IIntervalSplineSpawnAudioConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025A92 RID: 154258 RVA: 0x00529BD0 File Offset: 0x00527DD0
		public static Offset<IIntervalSplineSpawnAudioConfigBase> Pack(FlatBufferBuilder builder, IIntervalSplineSpawnAudioConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntervalSplineSpawnAudioConfigBase>);
			}
			return IIntervalSplineSpawnAudioConfigBase.CreateIIntervalSplineSpawnAudioConfigBase(builder, _o.Type);
		}

		// Token: 0x0400F348 RID: 62280
		private Table __p;
	}
}
