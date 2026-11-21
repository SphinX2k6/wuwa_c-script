using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E1 RID: 30433
	public struct ISceneUiSubtitlePosition : IFlatbufferObject
	{
		// Token: 0x1700DF39 RID: 57145
		// (get) Token: 0x0603564D RID: 218701 RVA: 0x0072951C File Offset: 0x0072771C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603564E RID: 218702 RVA: 0x00729529 File Offset: 0x00727729
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603564F RID: 218703 RVA: 0x00729530 File Offset: 0x00727730
		public static ISceneUiSubtitlePosition GetRootAsISceneUiSubtitlePosition(ByteBuffer _bb)
		{
			return ISceneUiSubtitlePosition.GetRootAsISceneUiSubtitlePosition(_bb, default(ISceneUiSubtitlePosition));
		}

		// Token: 0x06035650 RID: 218704 RVA: 0x0072954C File Offset: 0x0072774C
		public static ISceneUiSubtitlePosition GetRootAsISceneUiSubtitlePosition(ByteBuffer _bb, ISceneUiSubtitlePosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035651 RID: 218705 RVA: 0x00729569 File Offset: 0x00727769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035652 RID: 218706 RVA: 0x00729578 File Offset: 0x00727778
		public ISceneUiSubtitlePosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF3A RID: 57146
		// (get) Token: 0x06035653 RID: 218707 RVA: 0x00729588 File Offset: 0x00727788
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

		// Token: 0x1700DF3B RID: 57147
		// (get) Token: 0x06035654 RID: 218708 RVA: 0x007295C4 File Offset: 0x007277C4
		public IPosAndRot? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035655 RID: 218709 RVA: 0x00729621 File Offset: 0x00727821
		public static Offset<ISceneUiSubtitlePosition> CreateISceneUiSubtitlePosition(FlatBufferBuilder builder, ESceneUiSubtitlePositionType Type = ESceneUiSubtitlePositionType.Position, Offset<IPosAndRot> PosOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(2);
			ISceneUiSubtitlePosition.AddPos(builder, PosOffset);
			ISceneUiSubtitlePosition.AddType(builder, Type);
			return ISceneUiSubtitlePosition.EndISceneUiSubtitlePosition(builder);
		}

		// Token: 0x06035656 RID: 218710 RVA: 0x0072963E File Offset: 0x0072783E
		public static void StartISceneUiSubtitlePosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035657 RID: 218711 RVA: 0x00729647 File Offset: 0x00727847
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitlePositionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035658 RID: 218712 RVA: 0x00729652 File Offset: 0x00727852
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosAndRot> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06035659 RID: 218713 RVA: 0x00729662 File Offset: 0x00727862
		public static Offset<ISceneUiSubtitlePosition> EndISceneUiSubtitlePosition(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitlePosition>(builder.EndTable());
		}

		// Token: 0x0603565A RID: 218714 RVA: 0x00729670 File Offset: 0x00727870
		public ISceneUiSubtitlePositionT UnPack()
		{
			ISceneUiSubtitlePositionT sceneUiSubtitlePositionT = new ISceneUiSubtitlePositionT();
			this.UnPackTo(sceneUiSubtitlePositionT);
			return sceneUiSubtitlePositionT;
		}

		// Token: 0x0603565B RID: 218715 RVA: 0x0072968C File Offset: 0x0072788C
		public void UnPackTo(ISceneUiSubtitlePositionT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0603565C RID: 218716 RVA: 0x007296D4 File Offset: 0x007278D4
		public static Offset<ISceneUiSubtitlePosition> Pack(FlatBufferBuilder builder, ISceneUiSubtitlePositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitlePosition>);
			}
			Offset<IPosAndRot> posOffset = (_o.Pos == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.Pos);
			return ISceneUiSubtitlePosition.CreateISceneUiSubtitlePosition(builder, _o.Type, posOffset);
		}

		// Token: 0x040128E4 RID: 76004
		private Table __p;
	}
}
