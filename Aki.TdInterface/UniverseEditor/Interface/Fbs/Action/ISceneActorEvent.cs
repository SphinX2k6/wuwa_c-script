using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1E RID: 28446
	public struct ISceneActorEvent : IFlatbufferObject
	{
		// Token: 0x1700D379 RID: 54137
		// (get) Token: 0x06032421 RID: 205857 RVA: 0x006CA032 File Offset: 0x006C8232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032422 RID: 205858 RVA: 0x006CA03F File Offset: 0x006C823F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032423 RID: 205859 RVA: 0x006CA048 File Offset: 0x006C8248
		public static ISceneActorEvent GetRootAsISceneActorEvent(ByteBuffer _bb)
		{
			return ISceneActorEvent.GetRootAsISceneActorEvent(_bb, default(ISceneActorEvent));
		}

		// Token: 0x06032424 RID: 205860 RVA: 0x006CA064 File Offset: 0x006C8264
		public static ISceneActorEvent GetRootAsISceneActorEvent(ByteBuffer _bb, ISceneActorEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032425 RID: 205861 RVA: 0x006CA081 File Offset: 0x006C8281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032426 RID: 205862 RVA: 0x006CA090 File Offset: 0x006C8290
		public ISceneActorEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D37A RID: 54138
		// (get) Token: 0x06032427 RID: 205863 RVA: 0x006CA0A0 File Offset: 0x006C82A0
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

		// Token: 0x06032428 RID: 205864 RVA: 0x006CA0DC File Offset: 0x006C82DC
		public static Offset<ISceneActorEvent> CreateISceneActorEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants)
		{
			builder.StartTable(1);
			ISceneActorEvent.AddType(builder, Type);
			return ISceneActorEvent.EndISceneActorEvent(builder);
		}

		// Token: 0x06032429 RID: 205865 RVA: 0x006CA0F2 File Offset: 0x006C82F2
		public static void StartISceneActorEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603242A RID: 205866 RVA: 0x006CA0FB File Offset: 0x006C82FB
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603242B RID: 205867 RVA: 0x006CA106 File Offset: 0x006C8306
		public static Offset<ISceneActorEvent> EndISceneActorEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorEvent>(builder.EndTable());
		}

		// Token: 0x0603242C RID: 205868 RVA: 0x006CA114 File Offset: 0x006C8314
		public ISceneActorEventT UnPack()
		{
			ISceneActorEventT sceneActorEventT = new ISceneActorEventT();
			this.UnPackTo(sceneActorEventT);
			return sceneActorEventT;
		}

		// Token: 0x0603242D RID: 205869 RVA: 0x006CA12F File Offset: 0x006C832F
		public void UnPackTo(ISceneActorEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603242E RID: 205870 RVA: 0x006CA140 File Offset: 0x006C8340
		public static Offset<ISceneActorEvent> Pack(FlatBufferBuilder builder, ISceneActorEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorEvent>);
			}
			return ISceneActorEvent.CreateISceneActorEvent(builder, _o.Type);
		}

		// Token: 0x04011909 RID: 71945
		private Table __p;
	}
}
