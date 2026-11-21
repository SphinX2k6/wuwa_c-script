using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A17 RID: 27159
	public struct IClientEventPianoSwitchPhase : IFlatbufferObject
	{
		// Token: 0x1700C7AC RID: 51116
		// (get) Token: 0x0602E975 RID: 190837 RVA: 0x0065A8DC File Offset: 0x00658ADC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E976 RID: 190838 RVA: 0x0065A8E9 File Offset: 0x00658AE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E977 RID: 190839 RVA: 0x0065A8F0 File Offset: 0x00658AF0
		public static IClientEventPianoSwitchPhase GetRootAsIClientEventPianoSwitchPhase(ByteBuffer _bb)
		{
			return IClientEventPianoSwitchPhase.GetRootAsIClientEventPianoSwitchPhase(_bb, default(IClientEventPianoSwitchPhase));
		}

		// Token: 0x0602E978 RID: 190840 RVA: 0x0065A90C File Offset: 0x00658B0C
		public static IClientEventPianoSwitchPhase GetRootAsIClientEventPianoSwitchPhase(ByteBuffer _bb, IClientEventPianoSwitchPhase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E979 RID: 190841 RVA: 0x0065A929 File Offset: 0x00658B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E97A RID: 190842 RVA: 0x0065A938 File Offset: 0x00658B38
		public IClientEventPianoSwitchPhase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7AD RID: 51117
		// (get) Token: 0x0602E97B RID: 190843 RVA: 0x0065A948 File Offset: 0x00658B48
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

		// Token: 0x0602E97C RID: 190844 RVA: 0x0065A984 File Offset: 0x00658B84
		public static Offset<IClientEventPianoSwitchPhase> CreateIClientEventPianoSwitchPhase(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventPianoSwitchPhase.AddType(builder, Type);
			return IClientEventPianoSwitchPhase.EndIClientEventPianoSwitchPhase(builder);
		}

		// Token: 0x0602E97D RID: 190845 RVA: 0x0065A99A File Offset: 0x00658B9A
		public static void StartIClientEventPianoSwitchPhase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E97E RID: 190846 RVA: 0x0065A9A3 File Offset: 0x00658BA3
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E97F RID: 190847 RVA: 0x0065A9AE File Offset: 0x00658BAE
		public static Offset<IClientEventPianoSwitchPhase> EndIClientEventPianoSwitchPhase(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoSwitchPhase>(builder.EndTable());
		}

		// Token: 0x0602E980 RID: 190848 RVA: 0x0065A9BC File Offset: 0x00658BBC
		public IClientEventPianoSwitchPhaseT UnPack()
		{
			IClientEventPianoSwitchPhaseT clientEventPianoSwitchPhaseT = new IClientEventPianoSwitchPhaseT();
			this.UnPackTo(clientEventPianoSwitchPhaseT);
			return clientEventPianoSwitchPhaseT;
		}

		// Token: 0x0602E981 RID: 190849 RVA: 0x0065A9D7 File Offset: 0x00658BD7
		public void UnPackTo(IClientEventPianoSwitchPhaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E982 RID: 190850 RVA: 0x0065A9E8 File Offset: 0x00658BE8
		public static Offset<IClientEventPianoSwitchPhase> Pack(FlatBufferBuilder builder, IClientEventPianoSwitchPhaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoSwitchPhase>);
			}
			return IClientEventPianoSwitchPhase.CreateIClientEventPianoSwitchPhase(builder, _o.Type);
		}

		// Token: 0x0401178D RID: 71565
		private Table __p;
	}
}
