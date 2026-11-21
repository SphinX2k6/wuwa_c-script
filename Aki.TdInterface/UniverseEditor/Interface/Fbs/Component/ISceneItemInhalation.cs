using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED1 RID: 24273
	public struct ISceneItemInhalation : IFlatbufferObject
	{
		// Token: 0x1700B356 RID: 45910
		// (get) Token: 0x06028AF2 RID: 166642 RVA: 0x0058FACF File Offset: 0x0058DCCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028AF3 RID: 166643 RVA: 0x0058FADC File Offset: 0x0058DCDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028AF4 RID: 166644 RVA: 0x0058FAE4 File Offset: 0x0058DCE4
		public static ISceneItemInhalation GetRootAsISceneItemInhalation(ByteBuffer _bb)
		{
			return ISceneItemInhalation.GetRootAsISceneItemInhalation(_bb, default(ISceneItemInhalation));
		}

		// Token: 0x06028AF5 RID: 166645 RVA: 0x0058FB00 File Offset: 0x0058DD00
		public static ISceneItemInhalation GetRootAsISceneItemInhalation(ByteBuffer _bb, ISceneItemInhalation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028AF6 RID: 166646 RVA: 0x0058FB1D File Offset: 0x0058DD1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028AF7 RID: 166647 RVA: 0x0058FB2C File Offset: 0x0058DD2C
		public ISceneItemInhalation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B357 RID: 45911
		// (get) Token: 0x06028AF8 RID: 166648 RVA: 0x0058FB3C File Offset: 0x0058DD3C
		public EInhalationPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhalationPerformanceType.Role;
				}
				return (EInhalationPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028AF9 RID: 166649 RVA: 0x0058FB78 File Offset: 0x0058DD78
		public static Offset<ISceneItemInhalation> CreateISceneItemInhalation(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			ISceneItemInhalation.AddType(builder, Type);
			return ISceneItemInhalation.EndISceneItemInhalation(builder);
		}

		// Token: 0x06028AFA RID: 166650 RVA: 0x0058FB8E File Offset: 0x0058DD8E
		public static void StartISceneItemInhalation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028AFB RID: 166651 RVA: 0x0058FB97 File Offset: 0x0058DD97
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028AFC RID: 166652 RVA: 0x0058FBA2 File Offset: 0x0058DDA2
		public static Offset<ISceneItemInhalation> EndISceneItemInhalation(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemInhalation>(builder.EndTable());
		}

		// Token: 0x06028AFD RID: 166653 RVA: 0x0058FBB0 File Offset: 0x0058DDB0
		public ISceneItemInhalationT UnPack()
		{
			ISceneItemInhalationT sceneItemInhalationT = new ISceneItemInhalationT();
			this.UnPackTo(sceneItemInhalationT);
			return sceneItemInhalationT;
		}

		// Token: 0x06028AFE RID: 166654 RVA: 0x0058FBCB File Offset: 0x0058DDCB
		public void UnPackTo(ISceneItemInhalationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028AFF RID: 166655 RVA: 0x0058FBDC File Offset: 0x0058DDDC
		public static Offset<ISceneItemInhalation> Pack(FlatBufferBuilder builder, ISceneItemInhalationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemInhalation>);
			}
			return ISceneItemInhalation.CreateISceneItemInhalation(builder, _o.Type);
		}

		// Token: 0x0400FB2E RID: 64302
		private Table __p;
	}
}
