using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AB RID: 30379
	public struct ISceneActorMusicLightsEvent : IFlatbufferObject
	{
		// Token: 0x1700DEDA RID: 57050
		// (get) Token: 0x0603549B RID: 218267 RVA: 0x0072629E File Offset: 0x0072449E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603549C RID: 218268 RVA: 0x007262AB File Offset: 0x007244AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603549D RID: 218269 RVA: 0x007262B4 File Offset: 0x007244B4
		public static ISceneActorMusicLightsEvent GetRootAsISceneActorMusicLightsEvent(ByteBuffer _bb)
		{
			return ISceneActorMusicLightsEvent.GetRootAsISceneActorMusicLightsEvent(_bb, default(ISceneActorMusicLightsEvent));
		}

		// Token: 0x0603549E RID: 218270 RVA: 0x007262D0 File Offset: 0x007244D0
		public static ISceneActorMusicLightsEvent GetRootAsISceneActorMusicLightsEvent(ByteBuffer _bb, ISceneActorMusicLightsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603549F RID: 218271 RVA: 0x007262ED File Offset: 0x007244ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060354A0 RID: 218272 RVA: 0x007262FC File Offset: 0x007244FC
		public ISceneActorMusicLightsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEDB RID: 57051
		// (get) Token: 0x060354A1 RID: 218273 RVA: 0x0072630C File Offset: 0x0072450C
		public ESceneActorEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneActorEventType.PlayMusicPlants;
				}
				return (ESceneActorEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060354A2 RID: 218274 RVA: 0x00726348 File Offset: 0x00724548
		public static Offset<ISceneActorMusicLightsEvent> CreateISceneActorMusicLightsEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorMusicLightsEvent.AddType(builder, Type);
			return ISceneActorMusicLightsEvent.EndISceneActorMusicLightsEvent(builder);
		}

		// Token: 0x060354A3 RID: 218275 RVA: 0x0072635E File Offset: 0x0072455E
		public static void StartISceneActorMusicLightsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060354A4 RID: 218276 RVA: 0x00726367 File Offset: 0x00724567
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060354A5 RID: 218277 RVA: 0x00726372 File Offset: 0x00724572
		public static Offset<ISceneActorMusicLightsEvent> EndISceneActorMusicLightsEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorMusicLightsEvent>(builder.EndTable());
		}

		// Token: 0x060354A6 RID: 218278 RVA: 0x00726380 File Offset: 0x00724580
		public ISceneActorMusicLightsEventT UnPack()
		{
			ISceneActorMusicLightsEventT sceneActorMusicLightsEventT = new ISceneActorMusicLightsEventT();
			this.UnPackTo(sceneActorMusicLightsEventT);
			return sceneActorMusicLightsEventT;
		}

		// Token: 0x060354A7 RID: 218279 RVA: 0x0072639B File Offset: 0x0072459B
		public void UnPackTo(ISceneActorMusicLightsEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060354A8 RID: 218280 RVA: 0x007263AC File Offset: 0x007245AC
		public static Offset<ISceneActorMusicLightsEvent> Pack(FlatBufferBuilder builder, ISceneActorMusicLightsEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorMusicLightsEvent>);
			}
			return ISceneActorMusicLightsEvent.CreateISceneActorMusicLightsEvent(builder, _o.Type);
		}

		// Token: 0x0401289B RID: 75931
		private Table __p;
	}
}
