using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AE RID: 30382
	public struct ISceneActorMusicPlantsEvent : IFlatbufferObject
	{
		// Token: 0x1700DEDD RID: 57053
		// (get) Token: 0x060354AD RID: 218285 RVA: 0x00726415 File Offset: 0x00724615
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060354AE RID: 218286 RVA: 0x00726422 File Offset: 0x00724622
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060354AF RID: 218287 RVA: 0x0072642C File Offset: 0x0072462C
		public static ISceneActorMusicPlantsEvent GetRootAsISceneActorMusicPlantsEvent(ByteBuffer _bb)
		{
			return ISceneActorMusicPlantsEvent.GetRootAsISceneActorMusicPlantsEvent(_bb, default(ISceneActorMusicPlantsEvent));
		}

		// Token: 0x060354B0 RID: 218288 RVA: 0x00726448 File Offset: 0x00724648
		public static ISceneActorMusicPlantsEvent GetRootAsISceneActorMusicPlantsEvent(ByteBuffer _bb, ISceneActorMusicPlantsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060354B1 RID: 218289 RVA: 0x00726465 File Offset: 0x00724665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060354B2 RID: 218290 RVA: 0x00726474 File Offset: 0x00724674
		public ISceneActorMusicPlantsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEDE RID: 57054
		// (get) Token: 0x060354B3 RID: 218291 RVA: 0x00726484 File Offset: 0x00724684
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

		// Token: 0x060354B4 RID: 218292 RVA: 0x007264C0 File Offset: 0x007246C0
		public static Offset<ISceneActorMusicPlantsEvent> CreateISceneActorMusicPlantsEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorMusicPlantsEvent.AddType(builder, Type);
			return ISceneActorMusicPlantsEvent.EndISceneActorMusicPlantsEvent(builder);
		}

		// Token: 0x060354B5 RID: 218293 RVA: 0x007264D6 File Offset: 0x007246D6
		public static void StartISceneActorMusicPlantsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060354B6 RID: 218294 RVA: 0x007264DF File Offset: 0x007246DF
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060354B7 RID: 218295 RVA: 0x007264EA File Offset: 0x007246EA
		public static Offset<ISceneActorMusicPlantsEvent> EndISceneActorMusicPlantsEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorMusicPlantsEvent>(builder.EndTable());
		}

		// Token: 0x060354B8 RID: 218296 RVA: 0x007264F8 File Offset: 0x007246F8
		public ISceneActorMusicPlantsEventT UnPack()
		{
			ISceneActorMusicPlantsEventT sceneActorMusicPlantsEventT = new ISceneActorMusicPlantsEventT();
			this.UnPackTo(sceneActorMusicPlantsEventT);
			return sceneActorMusicPlantsEventT;
		}

		// Token: 0x060354B9 RID: 218297 RVA: 0x00726513 File Offset: 0x00724713
		public void UnPackTo(ISceneActorMusicPlantsEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060354BA RID: 218298 RVA: 0x00726524 File Offset: 0x00724724
		public static Offset<ISceneActorMusicPlantsEvent> Pack(FlatBufferBuilder builder, ISceneActorMusicPlantsEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorMusicPlantsEvent>);
			}
			return ISceneActorMusicPlantsEvent.CreateISceneActorMusicPlantsEvent(builder, _o.Type);
		}

		// Token: 0x0401289D RID: 75933
		private Table __p;
	}
}
