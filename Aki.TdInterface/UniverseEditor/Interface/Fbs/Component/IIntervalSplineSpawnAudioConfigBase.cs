using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005488 RID: 21640
	public struct IIntervalSplineSpawnAudioConfigBase : IFlatbufferObject
	{
		// Token: 0x17009F5B RID: 40795
		// (get) Token: 0x060239CD RID: 145869 RVA: 0x004ECA4F File Offset: 0x004EAC4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239CE RID: 145870 RVA: 0x004ECA5C File Offset: 0x004EAC5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239CF RID: 145871 RVA: 0x004ECA64 File Offset: 0x004EAC64
		public static IIntervalSplineSpawnAudioConfigBase GetRootAsIIntervalSplineSpawnAudioConfigBase(ByteBuffer _bb)
		{
			return IIntervalSplineSpawnAudioConfigBase.GetRootAsIIntervalSplineSpawnAudioConfigBase(_bb, default(IIntervalSplineSpawnAudioConfigBase));
		}

		// Token: 0x060239D0 RID: 145872 RVA: 0x004ECA80 File Offset: 0x004EAC80
		public static IIntervalSplineSpawnAudioConfigBase GetRootAsIIntervalSplineSpawnAudioConfigBase(ByteBuffer _bb, IIntervalSplineSpawnAudioConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239D1 RID: 145873 RVA: 0x004ECA9D File Offset: 0x004EAC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239D2 RID: 145874 RVA: 0x004ECAAC File Offset: 0x004EACAC
		public IIntervalSplineSpawnAudioConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F5C RID: 40796
		// (get) Token: 0x060239D3 RID: 145875 RVA: 0x004ECABC File Offset: 0x004EACBC
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

		// Token: 0x060239D4 RID: 145876 RVA: 0x004ECAF8 File Offset: 0x004EACF8
		public static Offset<IIntervalSplineSpawnAudioConfigBase> CreateIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType Type = EIntervalSplineSpawnAudioConfigType.AllActorAddAudio)
		{
			builder.StartTable(1);
			IIntervalSplineSpawnAudioConfigBase.AddType(builder, Type);
			return IIntervalSplineSpawnAudioConfigBase.EndIIntervalSplineSpawnAudioConfigBase(builder);
		}

		// Token: 0x060239D5 RID: 145877 RVA: 0x004ECB0E File Offset: 0x004EAD0E
		public static void StartIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060239D6 RID: 145878 RVA: 0x004ECB17 File Offset: 0x004EAD17
		public static void AddType(FlatBufferBuilder builder, EIntervalSplineSpawnAudioConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060239D7 RID: 145879 RVA: 0x004ECB22 File Offset: 0x004EAD22
		public static Offset<IIntervalSplineSpawnAudioConfigBase> EndIIntervalSplineSpawnAudioConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawnAudioConfigBase>(builder.EndTable());
		}

		// Token: 0x060239D8 RID: 145880 RVA: 0x004ECB30 File Offset: 0x004EAD30
		public IIntervalSplineSpawnAudioConfigBaseT UnPack()
		{
			IIntervalSplineSpawnAudioConfigBaseT intervalSplineSpawnAudioConfigBaseT = new IIntervalSplineSpawnAudioConfigBaseT();
			this.UnPackTo(intervalSplineSpawnAudioConfigBaseT);
			return intervalSplineSpawnAudioConfigBaseT;
		}

		// Token: 0x060239D9 RID: 145881 RVA: 0x004ECB4B File Offset: 0x004EAD4B
		public void UnPackTo(IIntervalSplineSpawnAudioConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060239DA RID: 145882 RVA: 0x004ECB5C File Offset: 0x004EAD5C
		public static Offset<IIntervalSplineSpawnAudioConfigBase> Pack(FlatBufferBuilder builder, IIntervalSplineSpawnAudioConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntervalSplineSpawnAudioConfigBase>);
			}
			return IIntervalSplineSpawnAudioConfigBase.CreateIIntervalSplineSpawnAudioConfigBase(builder, _o.Type);
		}

		// Token: 0x0400E717 RID: 59159
		private Table __p;
	}
}
