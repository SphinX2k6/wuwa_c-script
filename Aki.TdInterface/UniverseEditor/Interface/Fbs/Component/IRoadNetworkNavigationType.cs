using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7D RID: 24189
	public struct IRoadNetworkNavigationType : IFlatbufferObject
	{
		// Token: 0x1700B28E RID: 45710
		// (get) Token: 0x060287CA RID: 165834 RVA: 0x00589701 File Offset: 0x00587901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060287CB RID: 165835 RVA: 0x0058970E File Offset: 0x0058790E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060287CC RID: 165836 RVA: 0x00589718 File Offset: 0x00587918
		public static IRoadNetworkNavigationType GetRootAsIRoadNetworkNavigationType(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationType.GetRootAsIRoadNetworkNavigationType(_bb, default(IRoadNetworkNavigationType));
		}

		// Token: 0x060287CD RID: 165837 RVA: 0x00589734 File Offset: 0x00587934
		public static IRoadNetworkNavigationType GetRootAsIRoadNetworkNavigationType(ByteBuffer _bb, IRoadNetworkNavigationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060287CE RID: 165838 RVA: 0x00589751 File Offset: 0x00587951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060287CF RID: 165839 RVA: 0x00589760 File Offset: 0x00587960
		public IRoadNetworkNavigationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B28F RID: 45711
		// (get) Token: 0x060287D0 RID: 165840 RVA: 0x00589770 File Offset: 0x00587970
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

		// Token: 0x060287D1 RID: 165841 RVA: 0x005897AC File Offset: 0x005879AC
		public static Offset<IRoadNetworkNavigationType> CreateIRoadNetworkNavigationType(FlatBufferBuilder builder, ERoadNetworkNavigationType Type = ERoadNetworkNavigationType.Traffic)
		{
			builder.StartTable(1);
			IRoadNetworkNavigationType.AddType(builder, Type);
			return IRoadNetworkNavigationType.EndIRoadNetworkNavigationType(builder);
		}

		// Token: 0x060287D2 RID: 165842 RVA: 0x005897C2 File Offset: 0x005879C2
		public static void StartIRoadNetworkNavigationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060287D3 RID: 165843 RVA: 0x005897CB File Offset: 0x005879CB
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060287D4 RID: 165844 RVA: 0x005897D6 File Offset: 0x005879D6
		public static Offset<IRoadNetworkNavigationType> EndIRoadNetworkNavigationType(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationType>(builder.EndTable());
		}

		// Token: 0x060287D5 RID: 165845 RVA: 0x005897E4 File Offset: 0x005879E4
		public IRoadNetworkNavigationTypeT UnPack()
		{
			IRoadNetworkNavigationTypeT roadNetworkNavigationTypeT = new IRoadNetworkNavigationTypeT();
			this.UnPackTo(roadNetworkNavigationTypeT);
			return roadNetworkNavigationTypeT;
		}

		// Token: 0x060287D6 RID: 165846 RVA: 0x005897FF File Offset: 0x005879FF
		public void UnPackTo(IRoadNetworkNavigationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060287D7 RID: 165847 RVA: 0x00589810 File Offset: 0x00587A10
		public static Offset<IRoadNetworkNavigationType> Pack(FlatBufferBuilder builder, IRoadNetworkNavigationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoadNetworkNavigationType>);
			}
			return IRoadNetworkNavigationType.CreateIRoadNetworkNavigationType(builder, _o.Type);
		}

		// Token: 0x0400FAAA RID: 64170
		private Table __p;
	}
}
