using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EB RID: 22763
	public struct ISceneTextTypeBase : IFlatbufferObject
	{
		// Token: 0x1700AA91 RID: 43665
		// (get) Token: 0x0602672A RID: 157482 RVA: 0x0054C51D File Offset: 0x0054A71D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602672B RID: 157483 RVA: 0x0054C52A File Offset: 0x0054A72A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602672C RID: 157484 RVA: 0x0054C534 File Offset: 0x0054A734
		public static ISceneTextTypeBase GetRootAsISceneTextTypeBase(ByteBuffer _bb)
		{
			return ISceneTextTypeBase.GetRootAsISceneTextTypeBase(_bb, default(ISceneTextTypeBase));
		}

		// Token: 0x0602672D RID: 157485 RVA: 0x0054C550 File Offset: 0x0054A750
		public static ISceneTextTypeBase GetRootAsISceneTextTypeBase(ByteBuffer _bb, ISceneTextTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602672E RID: 157486 RVA: 0x0054C56D File Offset: 0x0054A76D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602672F RID: 157487 RVA: 0x0054C57C File Offset: 0x0054A77C
		public ISceneTextTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA92 RID: 43666
		// (get) Token: 0x06026730 RID: 157488 RVA: 0x0054C58C File Offset: 0x0054A78C
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

		// Token: 0x06026731 RID: 157489 RVA: 0x0054C5C8 File Offset: 0x0054A7C8
		public static Offset<ISceneTextTypeBase> CreateISceneTextTypeBase(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice)
		{
			builder.StartTable(1);
			ISceneTextTypeBase.AddType(builder, Type);
			return ISceneTextTypeBase.EndISceneTextTypeBase(builder);
		}

		// Token: 0x06026732 RID: 157490 RVA: 0x0054C5DE File Offset: 0x0054A7DE
		public static void StartISceneTextTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026733 RID: 157491 RVA: 0x0054C5E7 File Offset: 0x0054A7E7
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026734 RID: 157492 RVA: 0x0054C5F2 File Offset: 0x0054A7F2
		public static Offset<ISceneTextTypeBase> EndISceneTextTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextTypeBase>(builder.EndTable());
		}

		// Token: 0x06026735 RID: 157493 RVA: 0x0054C600 File Offset: 0x0054A800
		public ISceneTextTypeBaseT UnPack()
		{
			ISceneTextTypeBaseT sceneTextTypeBaseT = new ISceneTextTypeBaseT();
			this.UnPackTo(sceneTextTypeBaseT);
			return sceneTextTypeBaseT;
		}

		// Token: 0x06026736 RID: 157494 RVA: 0x0054C61B File Offset: 0x0054A81B
		public void UnPackTo(ISceneTextTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026737 RID: 157495 RVA: 0x0054C62C File Offset: 0x0054A82C
		public static Offset<ISceneTextTypeBase> Pack(FlatBufferBuilder builder, ISceneTextTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextTypeBase>);
			}
			return ISceneTextTypeBase.CreateISceneTextTypeBase(builder, _o.Type);
		}

		// Token: 0x0400EE7C RID: 61052
		private Table __p;
	}
}
