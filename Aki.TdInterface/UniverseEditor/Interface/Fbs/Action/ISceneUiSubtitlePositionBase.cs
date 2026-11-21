using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E4 RID: 30436
	public struct ISceneUiSubtitlePositionBase : IFlatbufferObject
	{
		// Token: 0x1700DF3E RID: 57150
		// (get) Token: 0x06035663 RID: 218723 RVA: 0x007297A8 File Offset: 0x007279A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035664 RID: 218724 RVA: 0x007297B5 File Offset: 0x007279B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035665 RID: 218725 RVA: 0x007297BC File Offset: 0x007279BC
		public static ISceneUiSubtitlePositionBase GetRootAsISceneUiSubtitlePositionBase(ByteBuffer _bb)
		{
			return ISceneUiSubtitlePositionBase.GetRootAsISceneUiSubtitlePositionBase(_bb, default(ISceneUiSubtitlePositionBase));
		}

		// Token: 0x06035666 RID: 218726 RVA: 0x007297D8 File Offset: 0x007279D8
		public static ISceneUiSubtitlePositionBase GetRootAsISceneUiSubtitlePositionBase(ByteBuffer _bb, ISceneUiSubtitlePositionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035667 RID: 218727 RVA: 0x007297F5 File Offset: 0x007279F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035668 RID: 218728 RVA: 0x00729804 File Offset: 0x00727A04
		public ISceneUiSubtitlePositionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF3F RID: 57151
		// (get) Token: 0x06035669 RID: 218729 RVA: 0x00729814 File Offset: 0x00727A14
		public ESceneUiSubtitlePositionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitlePositionType.Position;
				}
				return (ESceneUiSubtitlePositionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603566A RID: 218730 RVA: 0x00729850 File Offset: 0x00727A50
		public static Offset<ISceneUiSubtitlePositionBase> CreateISceneUiSubtitlePositionBase(FlatBufferBuilder builder, ESceneUiSubtitlePositionType Type = ESceneUiSubtitlePositionType.Position)
		{
			builder.StartTable(1);
			ISceneUiSubtitlePositionBase.AddType(builder, Type);
			return ISceneUiSubtitlePositionBase.EndISceneUiSubtitlePositionBase(builder);
		}

		// Token: 0x0603566B RID: 218731 RVA: 0x00729866 File Offset: 0x00727A66
		public static void StartISceneUiSubtitlePositionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603566C RID: 218732 RVA: 0x0072986F File Offset: 0x00727A6F
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitlePositionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603566D RID: 218733 RVA: 0x0072987A File Offset: 0x00727A7A
		public static Offset<ISceneUiSubtitlePositionBase> EndISceneUiSubtitlePositionBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitlePositionBase>(builder.EndTable());
		}

		// Token: 0x0603566E RID: 218734 RVA: 0x00729888 File Offset: 0x00727A88
		public ISceneUiSubtitlePositionBaseT UnPack()
		{
			ISceneUiSubtitlePositionBaseT sceneUiSubtitlePositionBaseT = new ISceneUiSubtitlePositionBaseT();
			this.UnPackTo(sceneUiSubtitlePositionBaseT);
			return sceneUiSubtitlePositionBaseT;
		}

		// Token: 0x0603566F RID: 218735 RVA: 0x007298A3 File Offset: 0x00727AA3
		public void UnPackTo(ISceneUiSubtitlePositionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035670 RID: 218736 RVA: 0x007298B4 File Offset: 0x00727AB4
		public static Offset<ISceneUiSubtitlePositionBase> Pack(FlatBufferBuilder builder, ISceneUiSubtitlePositionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitlePositionBase>);
			}
			return ISceneUiSubtitlePositionBase.CreateISceneUiSubtitlePositionBase(builder, _o.Type);
		}

		// Token: 0x040128E7 RID: 76007
		private Table __p;
	}
}
