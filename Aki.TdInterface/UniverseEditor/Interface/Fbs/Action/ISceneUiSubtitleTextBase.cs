using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F6 RID: 30454
	public struct ISceneUiSubtitleTextBase : IFlatbufferObject
	{
		// Token: 0x1700DF64 RID: 57188
		// (get) Token: 0x060356FB RID: 218875 RVA: 0x0072AA40 File Offset: 0x00728C40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060356FC RID: 218876 RVA: 0x0072AA4D File Offset: 0x00728C4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060356FD RID: 218877 RVA: 0x0072AA54 File Offset: 0x00728C54
		public static ISceneUiSubtitleTextBase GetRootAsISceneUiSubtitleTextBase(ByteBuffer _bb)
		{
			return ISceneUiSubtitleTextBase.GetRootAsISceneUiSubtitleTextBase(_bb, default(ISceneUiSubtitleTextBase));
		}

		// Token: 0x060356FE RID: 218878 RVA: 0x0072AA70 File Offset: 0x00728C70
		public static ISceneUiSubtitleTextBase GetRootAsISceneUiSubtitleTextBase(ByteBuffer _bb, ISceneUiSubtitleTextBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060356FF RID: 218879 RVA: 0x0072AA8D File Offset: 0x00728C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035700 RID: 218880 RVA: 0x0072AA9C File Offset: 0x00728C9C
		public ISceneUiSubtitleTextBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF65 RID: 57189
		// (get) Token: 0x06035701 RID: 218881 RVA: 0x0072AAAC File Offset: 0x00728CAC
		public ESceneUiSubtitleTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitleTextType.Flow;
				}
				return (ESceneUiSubtitleTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035702 RID: 218882 RVA: 0x0072AAE8 File Offset: 0x00728CE8
		public static Offset<ISceneUiSubtitleTextBase> CreateISceneUiSubtitleTextBase(FlatBufferBuilder builder, ESceneUiSubtitleTextType Type = ESceneUiSubtitleTextType.Flow)
		{
			builder.StartTable(1);
			ISceneUiSubtitleTextBase.AddType(builder, Type);
			return ISceneUiSubtitleTextBase.EndISceneUiSubtitleTextBase(builder);
		}

		// Token: 0x06035703 RID: 218883 RVA: 0x0072AAFE File Offset: 0x00728CFE
		public static void StartISceneUiSubtitleTextBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035704 RID: 218884 RVA: 0x0072AB07 File Offset: 0x00728D07
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035705 RID: 218885 RVA: 0x0072AB12 File Offset: 0x00728D12
		public static Offset<ISceneUiSubtitleTextBase> EndISceneUiSubtitleTextBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleTextBase>(builder.EndTable());
		}

		// Token: 0x06035706 RID: 218886 RVA: 0x0072AB20 File Offset: 0x00728D20
		public ISceneUiSubtitleTextBaseT UnPack()
		{
			ISceneUiSubtitleTextBaseT sceneUiSubtitleTextBaseT = new ISceneUiSubtitleTextBaseT();
			this.UnPackTo(sceneUiSubtitleTextBaseT);
			return sceneUiSubtitleTextBaseT;
		}

		// Token: 0x06035707 RID: 218887 RVA: 0x0072AB3B File Offset: 0x00728D3B
		public void UnPackTo(ISceneUiSubtitleTextBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035708 RID: 218888 RVA: 0x0072AB4C File Offset: 0x00728D4C
		public static Offset<ISceneUiSubtitleTextBase> Pack(FlatBufferBuilder builder, ISceneUiSubtitleTextBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleTextBase>);
			}
			return ISceneUiSubtitleTextBase.CreateISceneUiSubtitleTextBase(builder, _o.Type);
		}

		// Token: 0x04012908 RID: 76040
		private Table __p;
	}
}
