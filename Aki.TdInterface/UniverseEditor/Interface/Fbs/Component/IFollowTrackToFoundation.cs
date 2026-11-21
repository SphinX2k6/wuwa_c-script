using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581D RID: 22557
	public struct IFollowTrackToFoundation : IFlatbufferObject
	{
		// Token: 0x1700A344 RID: 41796
		// (get) Token: 0x060247FB RID: 149499 RVA: 0x00503C92 File Offset: 0x00501E92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247FC RID: 149500 RVA: 0x00503C9F File Offset: 0x00501E9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247FD RID: 149501 RVA: 0x00503CA8 File Offset: 0x00501EA8
		public static IFollowTrackToFoundation GetRootAsIFollowTrackToFoundation(ByteBuffer _bb)
		{
			return IFollowTrackToFoundation.GetRootAsIFollowTrackToFoundation(_bb, default(IFollowTrackToFoundation));
		}

		// Token: 0x060247FE RID: 149502 RVA: 0x00503CC4 File Offset: 0x00501EC4
		public static IFollowTrackToFoundation GetRootAsIFollowTrackToFoundation(ByteBuffer _bb, IFollowTrackToFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247FF RID: 149503 RVA: 0x00503CE1 File Offset: 0x00501EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024800 RID: 149504 RVA: 0x00503CF0 File Offset: 0x00501EF0
		public IFollowTrackToFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A345 RID: 41797
		// (get) Token: 0x06024801 RID: 149505 RVA: 0x00503D00 File Offset: 0x00501F00
		public EFollowTrackEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowTrackEndType.ToStart;
				}
				return (EFollowTrackEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A346 RID: 41798
		// (get) Token: 0x06024802 RID: 149506 RVA: 0x00503D3C File Offset: 0x00501F3C
		public int FoundationId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A347 RID: 41799
		// (get) Token: 0x06024803 RID: 149507 RVA: 0x00503D78 File Offset: 0x00501F78
		public IVectorInfo? FinalOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024804 RID: 149508 RVA: 0x00503DD5 File Offset: 0x00501FD5
		public static Offset<IFollowTrackToFoundation> CreateIFollowTrackToFoundation(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart, int FoundationId = 0, Offset<IVectorInfo> FinalOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFollowTrackToFoundation.AddFinalOffset(builder, FinalOffsetOffset);
			IFollowTrackToFoundation.AddFoundationId(builder, FoundationId);
			IFollowTrackToFoundation.AddType(builder, Type);
			return IFollowTrackToFoundation.EndIFollowTrackToFoundation(builder);
		}

		// Token: 0x06024805 RID: 149509 RVA: 0x00503DF9 File Offset: 0x00501FF9
		public static void StartIFollowTrackToFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024806 RID: 149510 RVA: 0x00503E02 File Offset: 0x00502002
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024807 RID: 149511 RVA: 0x00503E0D File Offset: 0x0050200D
		public static void AddFoundationId(FlatBufferBuilder builder, int foundationId)
		{
			builder.AddInt(1, foundationId, 0);
		}

		// Token: 0x06024808 RID: 149512 RVA: 0x00503E18 File Offset: 0x00502018
		public static void AddFinalOffset(FlatBufferBuilder builder, Offset<IVectorInfo> finalOffsetOffset)
		{
			builder.AddOffset(2, finalOffsetOffset.Value, 0);
		}

		// Token: 0x06024809 RID: 149513 RVA: 0x00503E28 File Offset: 0x00502028
		public static Offset<IFollowTrackToFoundation> EndIFollowTrackToFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToFoundation>(builder.EndTable());
		}

		// Token: 0x0602480A RID: 149514 RVA: 0x00503E38 File Offset: 0x00502038
		public IFollowTrackToFoundationT UnPack()
		{
			IFollowTrackToFoundationT followTrackToFoundationT = new IFollowTrackToFoundationT();
			this.UnPackTo(followTrackToFoundationT);
			return followTrackToFoundationT;
		}

		// Token: 0x0602480B RID: 149515 RVA: 0x00503E54 File Offset: 0x00502054
		public void UnPackTo(IFollowTrackToFoundationT _o)
		{
			_o.Type = this.Type;
			_o.FoundationId = this.FoundationId;
			_o.FinalOffset = ((this.FinalOffset != null) ? this.FinalOffset.Value.UnPack() : null);
		}

		// Token: 0x0602480C RID: 149516 RVA: 0x00503EA8 File Offset: 0x005020A8
		public static Offset<IFollowTrackToFoundation> Pack(FlatBufferBuilder builder, IFollowTrackToFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToFoundation>);
			}
			Offset<IVectorInfo> finalOffsetOffset = (_o.FinalOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.FinalOffset);
			return IFollowTrackToFoundation.CreateIFollowTrackToFoundation(builder, _o.Type, _o.FoundationId, finalOffsetOffset);
		}

		// Token: 0x0400F03F RID: 61503
		private Table __p;
	}
}
