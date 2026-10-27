using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AF RID: 22703
	public struct ISceneItemAiPatrolType : IFlatbufferObject
	{
		// Token: 0x1700A9FF RID: 43519
		// (get) Token: 0x060264DE RID: 156894 RVA: 0x00547ABE File Offset: 0x00545CBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264DF RID: 156895 RVA: 0x00547ACB File Offset: 0x00545CCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264E0 RID: 156896 RVA: 0x00547AD4 File Offset: 0x00545CD4
		public static ISceneItemAiPatrolType GetRootAsISceneItemAiPatrolType(ByteBuffer _bb)
		{
			return ISceneItemAiPatrolType.GetRootAsISceneItemAiPatrolType(_bb, default(ISceneItemAiPatrolType));
		}

		// Token: 0x060264E1 RID: 156897 RVA: 0x00547AF0 File Offset: 0x00545CF0
		public static ISceneItemAiPatrolType GetRootAsISceneItemAiPatrolType(ByteBuffer _bb, ISceneItemAiPatrolType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264E2 RID: 156898 RVA: 0x00547B0D File Offset: 0x00545D0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264E3 RID: 156899 RVA: 0x00547B1C File Offset: 0x00545D1C
		public ISceneItemAiPatrolType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA00 RID: 43520
		// (get) Token: 0x060264E4 RID: 156900 RVA: 0x00547B2C File Offset: 0x00545D2C
		public ESceneItemAiPatrolType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemAiPatrolType.ByGameTime;
				}
				return (ESceneItemAiPatrolType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060264E5 RID: 156901 RVA: 0x00547B68 File Offset: 0x00545D68
		public static Offset<ISceneItemAiPatrolType> CreateISceneItemAiPatrolType(FlatBufferBuilder builder, ESceneItemAiPatrolType Type = ESceneItemAiPatrolType.ByGameTime)
		{
			builder.StartTable(1);
			ISceneItemAiPatrolType.AddType(builder, Type);
			return ISceneItemAiPatrolType.EndISceneItemAiPatrolType(builder);
		}

		// Token: 0x060264E6 RID: 156902 RVA: 0x00547B7E File Offset: 0x00545D7E
		public static void StartISceneItemAiPatrolType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060264E7 RID: 156903 RVA: 0x00547B87 File Offset: 0x00545D87
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiPatrolType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060264E8 RID: 156904 RVA: 0x00547B92 File Offset: 0x00545D92
		public static Offset<ISceneItemAiPatrolType> EndISceneItemAiPatrolType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiPatrolType>(builder.EndTable());
		}

		// Token: 0x060264E9 RID: 156905 RVA: 0x00547BA0 File Offset: 0x00545DA0
		public ISceneItemAiPatrolTypeT UnPack()
		{
			ISceneItemAiPatrolTypeT sceneItemAiPatrolTypeT = new ISceneItemAiPatrolTypeT();
			this.UnPackTo(sceneItemAiPatrolTypeT);
			return sceneItemAiPatrolTypeT;
		}

		// Token: 0x060264EA RID: 156906 RVA: 0x00547BBB File Offset: 0x00545DBB
		public void UnPackTo(ISceneItemAiPatrolTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060264EB RID: 156907 RVA: 0x00547BCC File Offset: 0x00545DCC
		public static Offset<ISceneItemAiPatrolType> Pack(FlatBufferBuilder builder, ISceneItemAiPatrolTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiPatrolType>);
			}
			return ISceneItemAiPatrolType.CreateISceneItemAiPatrolType(builder, _o.Type);
		}

		// Token: 0x0400EE1B RID: 60955
		private Table __p;
	}
}
