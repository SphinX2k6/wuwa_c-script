using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005921 RID: 22817
	public struct IHitLogicChangeNextState : IFlatbufferObject
	{
		// Token: 0x1700A57B RID: 42363
		// (get) Token: 0x06025186 RID: 151942 RVA: 0x005174B5 File Offset: 0x005156B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025187 RID: 151943 RVA: 0x005174C2 File Offset: 0x005156C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025188 RID: 151944 RVA: 0x005174CC File Offset: 0x005156CC
		public static IHitLogicChangeNextState GetRootAsIHitLogicChangeNextState(ByteBuffer _bb)
		{
			return IHitLogicChangeNextState.GetRootAsIHitLogicChangeNextState(_bb, default(IHitLogicChangeNextState));
		}

		// Token: 0x06025189 RID: 151945 RVA: 0x005174E8 File Offset: 0x005156E8
		public static IHitLogicChangeNextState GetRootAsIHitLogicChangeNextState(ByteBuffer _bb, IHitLogicChangeNextState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602518A RID: 151946 RVA: 0x00517505 File Offset: 0x00515705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602518B RID: 151947 RVA: 0x00517514 File Offset: 0x00515714
		public IHitLogicChangeNextState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A57C RID: 42364
		// (get) Token: 0x0602518C RID: 151948 RVA: 0x00517524 File Offset: 0x00515724
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602518D RID: 151949 RVA: 0x00517560 File Offset: 0x00515760
		public static Offset<IHitLogicChangeNextState> CreateIHitLogicChangeNextState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeNextState.AddType(builder, Type);
			return IHitLogicChangeNextState.EndIHitLogicChangeNextState(builder);
		}

		// Token: 0x0602518E RID: 151950 RVA: 0x00517576 File Offset: 0x00515776
		public static void StartIHitLogicChangeNextState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602518F RID: 151951 RVA: 0x0051757F File Offset: 0x0051577F
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025190 RID: 151952 RVA: 0x0051758A File Offset: 0x0051578A
		public static Offset<IHitLogicChangeNextState> EndIHitLogicChangeNextState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeNextState>(builder.EndTable());
		}

		// Token: 0x06025191 RID: 151953 RVA: 0x00517598 File Offset: 0x00515798
		public IHitLogicChangeNextStateT UnPack()
		{
			IHitLogicChangeNextStateT hitLogicChangeNextStateT = new IHitLogicChangeNextStateT();
			this.UnPackTo(hitLogicChangeNextStateT);
			return hitLogicChangeNextStateT;
		}

		// Token: 0x06025192 RID: 151954 RVA: 0x005175B3 File Offset: 0x005157B3
		public void UnPackTo(IHitLogicChangeNextStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025193 RID: 151955 RVA: 0x005175C4 File Offset: 0x005157C4
		public static Offset<IHitLogicChangeNextState> Pack(FlatBufferBuilder builder, IHitLogicChangeNextStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeNextState>);
			}
			return IHitLogicChangeNextState.CreateIHitLogicChangeNextState(builder, _o.Type);
		}

		// Token: 0x0400F1B5 RID: 61877
		private Table __p;
	}
}
