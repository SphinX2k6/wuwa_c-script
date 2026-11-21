using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF8 RID: 24312
	public struct ISceneTextTypeBase : IFlatbufferObject
	{
		// Token: 0x1700B3C5 RID: 46021
		// (get) Token: 0x06028C94 RID: 167060 RVA: 0x0059318C File Offset: 0x0059138C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C95 RID: 167061 RVA: 0x00593199 File Offset: 0x00591399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C96 RID: 167062 RVA: 0x005931A0 File Offset: 0x005913A0
		public static ISceneTextTypeBase GetRootAsISceneTextTypeBase(ByteBuffer _bb)
		{
			return ISceneTextTypeBase.GetRootAsISceneTextTypeBase(_bb, default(ISceneTextTypeBase));
		}

		// Token: 0x06028C97 RID: 167063 RVA: 0x005931BC File Offset: 0x005913BC
		public static ISceneTextTypeBase GetRootAsISceneTextTypeBase(ByteBuffer _bb, ISceneTextTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C98 RID: 167064 RVA: 0x005931D9 File Offset: 0x005913D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C99 RID: 167065 RVA: 0x005931E8 File Offset: 0x005913E8
		public ISceneTextTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3C6 RID: 46022
		// (get) Token: 0x06028C9A RID: 167066 RVA: 0x005931F8 File Offset: 0x005913F8
		public ESceneTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return (ESceneTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028C9B RID: 167067 RVA: 0x00593234 File Offset: 0x00591434
		public static Offset<ISceneTextTypeBase> CreateISceneTextTypeBase(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice)
		{
			builder.StartTable(1);
			ISceneTextTypeBase.AddType(builder, Type);
			return ISceneTextTypeBase.EndISceneTextTypeBase(builder);
		}

		// Token: 0x06028C9C RID: 167068 RVA: 0x0059324A File Offset: 0x0059144A
		public static void StartISceneTextTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028C9D RID: 167069 RVA: 0x00593253 File Offset: 0x00591453
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C9E RID: 167070 RVA: 0x0059325E File Offset: 0x0059145E
		public static Offset<ISceneTextTypeBase> EndISceneTextTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextTypeBase>(builder.EndTable());
		}

		// Token: 0x06028C9F RID: 167071 RVA: 0x0059326C File Offset: 0x0059146C
		public ISceneTextTypeBaseT UnPack()
		{
			ISceneTextTypeBaseT sceneTextTypeBaseT = new ISceneTextTypeBaseT();
			this.UnPackTo(sceneTextTypeBaseT);
			return sceneTextTypeBaseT;
		}

		// Token: 0x06028CA0 RID: 167072 RVA: 0x00593287 File Offset: 0x00591487
		public void UnPackTo(ISceneTextTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028CA1 RID: 167073 RVA: 0x00593298 File Offset: 0x00591498
		public static Offset<ISceneTextTypeBase> Pack(FlatBufferBuilder builder, ISceneTextTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextTypeBase>);
			}
			return ISceneTextTypeBase.CreateISceneTextTypeBase(builder, _o.Type);
		}

		// Token: 0x0400FB71 RID: 64369
		private Table __p;
	}
}
