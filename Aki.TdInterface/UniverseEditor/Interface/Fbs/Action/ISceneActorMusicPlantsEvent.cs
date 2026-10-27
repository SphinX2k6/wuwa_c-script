using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F27 RID: 28455
	public struct ISceneActorMusicPlantsEvent : IFlatbufferObject
	{
		// Token: 0x1700D381 RID: 54145
		// (get) Token: 0x06032455 RID: 205909 RVA: 0x006CA4AD File Offset: 0x006C86AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032456 RID: 205910 RVA: 0x006CA4BA File Offset: 0x006C86BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032457 RID: 205911 RVA: 0x006CA4C4 File Offset: 0x006C86C4
		public static ISceneActorMusicPlantsEvent GetRootAsISceneActorMusicPlantsEvent(ByteBuffer _bb)
		{
			return ISceneActorMusicPlantsEvent.GetRootAsISceneActorMusicPlantsEvent(_bb, default(ISceneActorMusicPlantsEvent));
		}

		// Token: 0x06032458 RID: 205912 RVA: 0x006CA4E0 File Offset: 0x006C86E0
		public static ISceneActorMusicPlantsEvent GetRootAsISceneActorMusicPlantsEvent(ByteBuffer _bb, ISceneActorMusicPlantsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032459 RID: 205913 RVA: 0x006CA4FD File Offset: 0x006C86FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603245A RID: 205914 RVA: 0x006CA50C File Offset: 0x006C870C
		public ISceneActorMusicPlantsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D382 RID: 54146
		// (get) Token: 0x0603245B RID: 205915 RVA: 0x006CA51C File Offset: 0x006C871C
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

		// Token: 0x0603245C RID: 205916 RVA: 0x006CA558 File Offset: 0x006C8758
		public static Offset<ISceneActorMusicPlantsEvent> CreateISceneActorMusicPlantsEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorMusicPlantsEvent.AddType(builder, Type);
			return ISceneActorMusicPlantsEvent.EndISceneActorMusicPlantsEvent(builder);
		}

		// Token: 0x0603245D RID: 205917 RVA: 0x006CA56E File Offset: 0x006C876E
		public static void StartISceneActorMusicPlantsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603245E RID: 205918 RVA: 0x006CA577 File Offset: 0x006C8777
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603245F RID: 205919 RVA: 0x006CA582 File Offset: 0x006C8782
		public static Offset<ISceneActorMusicPlantsEvent> EndISceneActorMusicPlantsEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorMusicPlantsEvent>(builder.EndTable());
		}

		// Token: 0x06032460 RID: 205920 RVA: 0x006CA590 File Offset: 0x006C8790
		public ISceneActorMusicPlantsEventT UnPack()
		{
			ISceneActorMusicPlantsEventT sceneActorMusicPlantsEventT = new ISceneActorMusicPlantsEventT();
			this.UnPackTo(sceneActorMusicPlantsEventT);
			return sceneActorMusicPlantsEventT;
		}

		// Token: 0x06032461 RID: 205921 RVA: 0x006CA5AB File Offset: 0x006C87AB
		public void UnPackTo(ISceneActorMusicPlantsEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032462 RID: 205922 RVA: 0x006CA5BC File Offset: 0x006C87BC
		public static Offset<ISceneActorMusicPlantsEvent> Pack(FlatBufferBuilder builder, ISceneActorMusicPlantsEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorMusicPlantsEvent>);
			}
			return ISceneActorMusicPlantsEvent.CreateISceneActorMusicPlantsEvent(builder, _o.Type);
		}

		// Token: 0x04011915 RID: 71957
		private Table __p;
	}
}
