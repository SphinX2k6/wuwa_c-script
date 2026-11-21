using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1A RID: 27162
	public struct IClientEventPianoUpdateSubtitle : IFlatbufferObject
	{
		// Token: 0x1700C7AF RID: 51119
		// (get) Token: 0x0602E987 RID: 190855 RVA: 0x0065AA51 File Offset: 0x00658C51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E988 RID: 190856 RVA: 0x0065AA5E File Offset: 0x00658C5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E989 RID: 190857 RVA: 0x0065AA68 File Offset: 0x00658C68
		public static IClientEventPianoUpdateSubtitle GetRootAsIClientEventPianoUpdateSubtitle(ByteBuffer _bb)
		{
			return IClientEventPianoUpdateSubtitle.GetRootAsIClientEventPianoUpdateSubtitle(_bb, default(IClientEventPianoUpdateSubtitle));
		}

		// Token: 0x0602E98A RID: 190858 RVA: 0x0065AA84 File Offset: 0x00658C84
		public static IClientEventPianoUpdateSubtitle GetRootAsIClientEventPianoUpdateSubtitle(ByteBuffer _bb, IClientEventPianoUpdateSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E98B RID: 190859 RVA: 0x0065AAA1 File Offset: 0x00658CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E98C RID: 190860 RVA: 0x0065AAB0 File Offset: 0x00658CB0
		public IClientEventPianoUpdateSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7B0 RID: 51120
		// (get) Token: 0x0602E98D RID: 190861 RVA: 0x0065AAC0 File Offset: 0x00658CC0
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

		// Token: 0x1700C7B1 RID: 51121
		// (get) Token: 0x0602E98E RID: 190862 RVA: 0x0065AAFC File Offset: 0x00658CFC
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

		// Token: 0x1700C7B2 RID: 51122
		// (get) Token: 0x0602E98F RID: 190863 RVA: 0x0065AB5C File Offset: 0x00658D5C
		public bool DisableMove
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602E990 RID: 190864 RVA: 0x0065AB9B File Offset: 0x00658D9B
		public static Offset<IClientEventPianoUpdateSubtitle> CreateIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), bool DisableMove = false)
		{
			builder.StartTable(3);
			IClientEventPianoUpdateSubtitle.AddFlow(builder, FlowOffset);
			IClientEventPianoUpdateSubtitle.AddDisableMove(builder, DisableMove);
			IClientEventPianoUpdateSubtitle.AddType(builder, Type);
			return IClientEventPianoUpdateSubtitle.EndIClientEventPianoUpdateSubtitle(builder);
		}

		// Token: 0x0602E991 RID: 190865 RVA: 0x0065ABBF File Offset: 0x00658DBF
		public static void StartIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E992 RID: 190866 RVA: 0x0065ABC8 File Offset: 0x00658DC8
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E993 RID: 190867 RVA: 0x0065ABD3 File Offset: 0x00658DD3
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0602E994 RID: 190868 RVA: 0x0065ABE3 File Offset: 0x00658DE3
		public static void AddDisableMove(FlatBufferBuilder builder, bool disableMove)
		{
			builder.AddBool(2, disableMove, false);
		}

		// Token: 0x0602E995 RID: 190869 RVA: 0x0065ABEE File Offset: 0x00658DEE
		public static Offset<IClientEventPianoUpdateSubtitle> EndIClientEventPianoUpdateSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoUpdateSubtitle>(builder.EndTable());
		}

		// Token: 0x0602E996 RID: 190870 RVA: 0x0065ABFC File Offset: 0x00658DFC
		public IClientEventPianoUpdateSubtitleT UnPack()
		{
			IClientEventPianoUpdateSubtitleT clientEventPianoUpdateSubtitleT = new IClientEventPianoUpdateSubtitleT();
			this.UnPackTo(clientEventPianoUpdateSubtitleT);
			return clientEventPianoUpdateSubtitleT;
		}

		// Token: 0x0602E997 RID: 190871 RVA: 0x0065AC18 File Offset: 0x00658E18
		public void UnPackTo(IClientEventPianoUpdateSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.DisableMove = this.DisableMove;
		}

		// Token: 0x0602E998 RID: 190872 RVA: 0x0065AC6C File Offset: 0x00658E6C
		public static Offset<IClientEventPianoUpdateSubtitle> Pack(FlatBufferBuilder builder, IClientEventPianoUpdateSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoUpdateSubtitle>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IClientEventPianoUpdateSubtitle.CreateIClientEventPianoUpdateSubtitle(builder, _o.Type, flowOffset, _o.DisableMove);
		}

		// Token: 0x0401178F RID: 71567
		private Table __p;
	}
}
