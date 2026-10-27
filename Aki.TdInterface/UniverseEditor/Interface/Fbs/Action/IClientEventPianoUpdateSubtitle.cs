using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A9 RID: 25513
	public struct IClientEventPianoUpdateSubtitle : IFlatbufferObject
	{
		// Token: 0x1700BE2B RID: 48683
		// (get) Token: 0x0602C225 RID: 180773 RVA: 0x0060FA19 File Offset: 0x0060DC19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C226 RID: 180774 RVA: 0x0060FA26 File Offset: 0x0060DC26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C227 RID: 180775 RVA: 0x0060FA30 File Offset: 0x0060DC30
		public static IClientEventPianoUpdateSubtitle GetRootAsIClientEventPianoUpdateSubtitle(ByteBuffer _bb)
		{
			return IClientEventPianoUpdateSubtitle.GetRootAsIClientEventPianoUpdateSubtitle(_bb, default(IClientEventPianoUpdateSubtitle));
		}

		// Token: 0x0602C228 RID: 180776 RVA: 0x0060FA4C File Offset: 0x0060DC4C
		public static IClientEventPianoUpdateSubtitle GetRootAsIClientEventPianoUpdateSubtitle(ByteBuffer _bb, IClientEventPianoUpdateSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C229 RID: 180777 RVA: 0x0060FA69 File Offset: 0x0060DC69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C22A RID: 180778 RVA: 0x0060FA78 File Offset: 0x0060DC78
		public IClientEventPianoUpdateSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE2C RID: 48684
		// (get) Token: 0x0602C22B RID: 180779 RVA: 0x0060FA88 File Offset: 0x0060DC88
		public EClientEventPianoEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return (EClientEventPianoEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE2D RID: 48685
		// (get) Token: 0x0602C22C RID: 180780 RVA: 0x0060FAC4 File Offset: 0x0060DCC4
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

		// Token: 0x1700BE2E RID: 48686
		// (get) Token: 0x0602C22D RID: 180781 RVA: 0x0060FB24 File Offset: 0x0060DD24
		public bool DisableMove
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602C22E RID: 180782 RVA: 0x0060FB63 File Offset: 0x0060DD63
		public static Offset<IClientEventPianoUpdateSubtitle> CreateIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), bool DisableMove = false)
		{
			builder.StartTable(3);
			IClientEventPianoUpdateSubtitle.AddFlow(builder, FlowOffset);
			IClientEventPianoUpdateSubtitle.AddDisableMove(builder, DisableMove);
			IClientEventPianoUpdateSubtitle.AddType(builder, Type);
			return IClientEventPianoUpdateSubtitle.EndIClientEventPianoUpdateSubtitle(builder);
		}

		// Token: 0x0602C22F RID: 180783 RVA: 0x0060FB87 File Offset: 0x0060DD87
		public static void StartIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C230 RID: 180784 RVA: 0x0060FB90 File Offset: 0x0060DD90
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C231 RID: 180785 RVA: 0x0060FB9B File Offset: 0x0060DD9B
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0602C232 RID: 180786 RVA: 0x0060FBAB File Offset: 0x0060DDAB
		public static void AddDisableMove(FlatBufferBuilder builder, bool disableMove)
		{
			builder.AddBool(2, disableMove, false);
		}

		// Token: 0x0602C233 RID: 180787 RVA: 0x0060FBB6 File Offset: 0x0060DDB6
		public static Offset<IClientEventPianoUpdateSubtitle> EndIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoUpdateSubtitle>(builder.EndTable());
		}

		// Token: 0x0602C234 RID: 180788 RVA: 0x0060FBC4 File Offset: 0x0060DDC4
		public IClientEventPianoUpdateSubtitleT UnPack()
		{
			IClientEventPianoUpdateSubtitleT clientEventPianoUpdateSubtitleT = new IClientEventPianoUpdateSubtitleT();
			this.UnPackTo(clientEventPianoUpdateSubtitleT);
			return clientEventPianoUpdateSubtitleT;
		}

		// Token: 0x0602C235 RID: 180789 RVA: 0x0060FBE0 File Offset: 0x0060DDE0
		public void UnPackTo(IClientEventPianoUpdateSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.DisableMove = this.DisableMove;
		}

		// Token: 0x0602C236 RID: 180790 RVA: 0x0060FC34 File Offset: 0x0060DE34
		public static Offset<IClientEventPianoUpdateSubtitle> Pack(FlatBufferBuilder builder, IClientEventPianoUpdateSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoUpdateSubtitle>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IClientEventPianoUpdateSubtitle.CreateIClientEventPianoUpdateSubtitle(builder, _o.Type, flowOffset, _o.DisableMove);
		}

		// Token: 0x0401097C RID: 67964
		private Table __p;
	}
}
