using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006364 RID: 25444
	public struct ICheckFlowLookAtPlayer : IFlatbufferObject
	{
		// Token: 0x1700BDD6 RID: 48598
		// (get) Token: 0x0602C04D RID: 180301 RVA: 0x0060C7E6 File Offset: 0x0060A9E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C04E RID: 180302 RVA: 0x0060C7F3 File Offset: 0x0060A9F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C04F RID: 180303 RVA: 0x0060C7FC File Offset: 0x0060A9FC
		public static ICheckFlowLookAtPlayer GetRootAsICheckFlowLookAtPlayer(ByteBuffer _bb)
		{
			return ICheckFlowLookAtPlayer.GetRootAsICheckFlowLookAtPlayer(_bb, default(ICheckFlowLookAtPlayer));
		}

		// Token: 0x0602C050 RID: 180304 RVA: 0x0060C818 File Offset: 0x0060AA18
		public static ICheckFlowLookAtPlayer GetRootAsICheckFlowLookAtPlayer(ByteBuffer _bb, ICheckFlowLookAtPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C051 RID: 180305 RVA: 0x0060C835 File Offset: 0x0060AA35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C052 RID: 180306 RVA: 0x0060C844 File Offset: 0x0060AA44
		public ICheckFlowLookAtPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDD7 RID: 48599
		// (get) Token: 0x0602C053 RID: 180307 RVA: 0x0060C854 File Offset: 0x0060AA54
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C054 RID: 180308 RVA: 0x0060C890 File Offset: 0x0060AA90
		public static Offset<ICheckFlowLookAtPlayer> CreateICheckFlowLookAtPlayer(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ICheckFlowLookAtPlayer.AddType(builder, Type);
			return ICheckFlowLookAtPlayer.EndICheckFlowLookAtPlayer(builder);
		}

		// Token: 0x0602C055 RID: 180309 RVA: 0x0060C8A6 File Offset: 0x0060AAA6
		public static void StartICheckFlowLookAtPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C056 RID: 180310 RVA: 0x0060C8AF File Offset: 0x0060AAAF
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C057 RID: 180311 RVA: 0x0060C8BA File Offset: 0x0060AABA
		public static Offset<ICheckFlowLookAtPlayer> EndICheckFlowLookAtPlayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtPlayer>(builder.EndTable());
		}

		// Token: 0x0602C058 RID: 180312 RVA: 0x0060C8C8 File Offset: 0x0060AAC8
		public ICheckFlowLookAtPlayerT UnPack()
		{
			ICheckFlowLookAtPlayerT checkFlowLookAtPlayerT = new ICheckFlowLookAtPlayerT();
			this.UnPackTo(checkFlowLookAtPlayerT);
			return checkFlowLookAtPlayerT;
		}

		// Token: 0x0602C059 RID: 180313 RVA: 0x0060C8E3 File Offset: 0x0060AAE3
		public void UnPackTo(ICheckFlowLookAtPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C05A RID: 180314 RVA: 0x0060C8F4 File Offset: 0x0060AAF4
		public static Offset<ICheckFlowLookAtPlayer> Pack(FlatBufferBuilder builder, ICheckFlowLookAtPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtPlayer>);
			}
			return ICheckFlowLookAtPlayer.CreateICheckFlowLookAtPlayer(builder, _o.Type);
		}

		// Token: 0x04010932 RID: 67890
		private Table __p;
	}
}
