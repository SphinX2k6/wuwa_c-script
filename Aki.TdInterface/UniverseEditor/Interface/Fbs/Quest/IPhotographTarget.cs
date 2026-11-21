using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D0 RID: 17360
	public struct IPhotographTarget : IFlatbufferObject
	{
		// Token: 0x17007793 RID: 30611
		// (get) Token: 0x06018A5B RID: 100955 RVA: 0x00383E60 File Offset: 0x00382060
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x00383E6D File Offset: 0x0038206D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x00383E74 File Offset: 0x00382074
		public static IPhotographTarget GetRootAsIPhotographTarget(ByteBuffer _bb)
		{
			return IPhotographTarget.GetRootAsIPhotographTarget(_bb, default(IPhotographTarget));
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x00383E90 File Offset: 0x00382090
		public static IPhotographTarget GetRootAsIPhotographTarget(ByteBuffer _bb, IPhotographTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A5F RID: 100959 RVA: 0x00383EAD File Offset: 0x003820AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A60 RID: 100960 RVA: 0x00383EBC File Offset: 0x003820BC
		public IPhotographTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007794 RID: 30612
		// (get) Token: 0x06018A61 RID: 100961 RVA: 0x00383ECC File Offset: 0x003820CC
		public EPhotographTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographTargetType.Player;
				}
				return (EPhotographTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x00383F08 File Offset: 0x00382108
		public static Offset<IPhotographTarget> CreateIPhotographTarget(FlatBufferBuilder builder, EPhotographTargetType Type = EPhotographTargetType.Player)
		{
			builder.StartTable(1);
			IPhotographTarget.AddType(builder, Type);
			return IPhotographTarget.EndIPhotographTarget(builder);
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x00383F1E File Offset: 0x0038211E
		public static void StartIPhotographTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018A64 RID: 100964 RVA: 0x00383F27 File Offset: 0x00382127
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A65 RID: 100965 RVA: 0x00383F32 File Offset: 0x00382132
		public static Offset<IPhotographTarget> EndIPhotographTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTarget>(builder.EndTable());
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x00383F40 File Offset: 0x00382140
		public IPhotographTargetT UnPack()
		{
			IPhotographTargetT photographTargetT = new IPhotographTargetT();
			this.UnPackTo(photographTargetT);
			return photographTargetT;
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x00383F5B File Offset: 0x0038215B
		public void UnPackTo(IPhotographTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x00383F6C File Offset: 0x0038216C
		public static Offset<IPhotographTarget> Pack(FlatBufferBuilder builder, IPhotographTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTarget>);
			}
			return IPhotographTarget.CreateIPhotographTarget(builder, _o.Type);
		}

		// Token: 0x0400C3D2 RID: 50130
		private Table __p;
	}
}
