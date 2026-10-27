using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005870 RID: 22640
	public struct IRoadNetworkNavigationType : IFlatbufferObject
	{
		// Token: 0x1700A95E RID: 43358
		// (get) Token: 0x06026268 RID: 156264 RVA: 0x00542BB5 File Offset: 0x00540DB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026269 RID: 156265 RVA: 0x00542BC2 File Offset: 0x00540DC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602626A RID: 156266 RVA: 0x00542BCC File Offset: 0x00540DCC
		public static IRoadNetworkNavigationType GetRootAsIRoadNetworkNavigationType(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationType.GetRootAsIRoadNetworkNavigationType(_bb, default(IRoadNetworkNavigationType));
		}

		// Token: 0x0602626B RID: 156267 RVA: 0x00542BE8 File Offset: 0x00540DE8
		public static IRoadNetworkNavigationType GetRootAsIRoadNetworkNavigationType(ByteBuffer _bb, IRoadNetworkNavigationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602626C RID: 156268 RVA: 0x00542C05 File Offset: 0x00540E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602626D RID: 156269 RVA: 0x00542C14 File Offset: 0x00540E14
		public IRoadNetworkNavigationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A95F RID: 43359
		// (get) Token: 0x0602626E RID: 156270 RVA: 0x00542C24 File Offset: 0x00540E24
		public ERoadNetworkNavigationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoadNetworkNavigationType.Traffic;
				}
				return (ERoadNetworkNavigationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602626F RID: 156271 RVA: 0x00542C60 File Offset: 0x00540E60
		public static Offset<IRoadNetworkNavigationType> CreateIRoadNetworkNavigationType(FlatBufferBuilder builder, ERoadNetworkNavigationType Type = ERoadNetworkNavigationType.Traffic)
		{
			builder.StartTable(1);
			IRoadNetworkNavigationType.AddType(builder, Type);
			return IRoadNetworkNavigationType.EndIRoadNetworkNavigationType(builder);
		}

		// Token: 0x06026270 RID: 156272 RVA: 0x00542C76 File Offset: 0x00540E76
		public static void StartIRoadNetworkNavigationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026271 RID: 156273 RVA: 0x00542C7F File Offset: 0x00540E7F
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026272 RID: 156274 RVA: 0x00542C8A File Offset: 0x00540E8A
		public static Offset<IRoadNetworkNavigationType> EndIRoadNetworkNavigationType(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationType>(builder.EndTable());
		}

		// Token: 0x06026273 RID: 156275 RVA: 0x00542C98 File Offset: 0x00540E98
		public IRoadNetworkNavigationTypeT UnPack()
		{
			IRoadNetworkNavigationTypeT roadNetworkNavigationTypeT = new IRoadNetworkNavigationTypeT();
			this.UnPackTo(roadNetworkNavigationTypeT);
			return roadNetworkNavigationTypeT;
		}

		// Token: 0x06026274 RID: 156276 RVA: 0x00542CB3 File Offset: 0x00540EB3
		public void UnPackTo(IRoadNetworkNavigationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026275 RID: 156277 RVA: 0x00542CC4 File Offset: 0x00540EC4
		public static Offset<IRoadNetworkNavigationType> Pack(FlatBufferBuilder builder, IRoadNetworkNavigationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoadNetworkNavigationType>);
			}
			return IRoadNetworkNavigationType.CreateIRoadNetworkNavigationType(builder, _o.Type);
		}

		// Token: 0x0400EDB7 RID: 60855
		private Table __p;
	}
}
