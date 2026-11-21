using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FC RID: 30460
	public struct ISceneUiSubtitleTextFlow : IFlatbufferObject
	{
		// Token: 0x1700DF69 RID: 57193
		// (get) Token: 0x0603571B RID: 218907 RVA: 0x0072AD00 File Offset: 0x00728F00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603571C RID: 218908 RVA: 0x0072AD0D File Offset: 0x00728F0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603571D RID: 218909 RVA: 0x0072AD14 File Offset: 0x00728F14
		public static ISceneUiSubtitleTextFlow GetRootAsISceneUiSubtitleTextFlow(ByteBuffer _bb)
		{
			return ISceneUiSubtitleTextFlow.GetRootAsISceneUiSubtitleTextFlow(_bb, default(ISceneUiSubtitleTextFlow));
		}

		// Token: 0x0603571E RID: 218910 RVA: 0x0072AD30 File Offset: 0x00728F30
		public static ISceneUiSubtitleTextFlow GetRootAsISceneUiSubtitleTextFlow(ByteBuffer _bb, ISceneUiSubtitleTextFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603571F RID: 218911 RVA: 0x0072AD4D File Offset: 0x00728F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035720 RID: 218912 RVA: 0x0072AD5C File Offset: 0x00728F5C
		public ISceneUiSubtitleTextFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF6A RID: 57194
		// (get) Token: 0x06035721 RID: 218913 RVA: 0x0072AD6C File Offset: 0x00728F6C
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

		// Token: 0x1700DF6B RID: 57195
		// (get) Token: 0x06035722 RID: 218914 RVA: 0x0072ADA8 File Offset: 0x00728FA8
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035723 RID: 218915 RVA: 0x0072AE05 File Offset: 0x00729005
		public static Offset<ISceneUiSubtitleTextFlow> CreateISceneUiSubtitleTextFlow(FlatBufferBuilder builder, ESceneUiSubtitleTextType Type = ESceneUiSubtitleTextType.Flow, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			ISceneUiSubtitleTextFlow.AddFlow(builder, FlowOffset);
			ISceneUiSubtitleTextFlow.AddType(builder, Type);
			return ISceneUiSubtitleTextFlow.EndISceneUiSubtitleTextFlow(builder);
		}

		// Token: 0x06035724 RID: 218916 RVA: 0x0072AE22 File Offset: 0x00729022
		public static void StartISceneUiSubtitleTextFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035725 RID: 218917 RVA: 0x0072AE2B File Offset: 0x0072902B
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035726 RID: 218918 RVA: 0x0072AE36 File Offset: 0x00729036
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06035727 RID: 218919 RVA: 0x0072AE46 File Offset: 0x00729046
		public static Offset<ISceneUiSubtitleTextFlow> EndISceneUiSubtitleTextFlow(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleTextFlow>(builder.EndTable());
		}

		// Token: 0x06035728 RID: 218920 RVA: 0x0072AE54 File Offset: 0x00729054
		public ISceneUiSubtitleTextFlowT UnPack()
		{
			ISceneUiSubtitleTextFlowT sceneUiSubtitleTextFlowT = new ISceneUiSubtitleTextFlowT();
			this.UnPackTo(sceneUiSubtitleTextFlowT);
			return sceneUiSubtitleTextFlowT;
		}

		// Token: 0x06035729 RID: 218921 RVA: 0x0072AE70 File Offset: 0x00729070
		public void UnPackTo(ISceneUiSubtitleTextFlowT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0603572A RID: 218922 RVA: 0x0072AEB8 File Offset: 0x007290B8
		public static Offset<ISceneUiSubtitleTextFlow> Pack(FlatBufferBuilder builder, ISceneUiSubtitleTextFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleTextFlow>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return ISceneUiSubtitleTextFlow.CreateISceneUiSubtitleTextFlow(builder, _o.Type, flowOffset);
		}

		// Token: 0x04012911 RID: 76049
		private Table __p;
	}
}
