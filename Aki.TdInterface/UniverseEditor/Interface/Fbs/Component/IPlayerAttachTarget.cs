using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4F RID: 23887
	public struct IPlayerAttachTarget : IFlatbufferObject
	{
		// Token: 0x1700AFD8 RID: 45016
		// (get) Token: 0x06027C27 RID: 162855 RVA: 0x00570BC9 File Offset: 0x0056EDC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C28 RID: 162856 RVA: 0x00570BD6 File Offset: 0x0056EDD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C29 RID: 162857 RVA: 0x00570BE0 File Offset: 0x0056EDE0
		public static IPlayerAttachTarget GetRootAsIPlayerAttachTarget(ByteBuffer _bb)
		{
			return IPlayerAttachTarget.GetRootAsIPlayerAttachTarget(_bb, default(IPlayerAttachTarget));
		}

		// Token: 0x06027C2A RID: 162858 RVA: 0x00570BFC File Offset: 0x0056EDFC
		public static IPlayerAttachTarget GetRootAsIPlayerAttachTarget(ByteBuffer _bb, IPlayerAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C2B RID: 162859 RVA: 0x00570C19 File Offset: 0x0056EE19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C2C RID: 162860 RVA: 0x00570C28 File Offset: 0x0056EE28
		public IPlayerAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFD9 RID: 45017
		// (get) Token: 0x06027C2D RID: 162861 RVA: 0x00570C38 File Offset: 0x0056EE38
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C2E RID: 162862 RVA: 0x00570C74 File Offset: 0x0056EE74
		public static Offset<IPlayerAttachTarget> CreateIPlayerAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IPlayerAttachTarget.AddType(builder, Type);
			return IPlayerAttachTarget.EndIPlayerAttachTarget(builder);
		}

		// Token: 0x06027C2F RID: 162863 RVA: 0x00570C8A File Offset: 0x0056EE8A
		public static void StartIPlayerAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027C30 RID: 162864 RVA: 0x00570C93 File Offset: 0x0056EE93
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C31 RID: 162865 RVA: 0x00570C9E File Offset: 0x0056EE9E
		public static Offset<IPlayerAttachTarget> EndIPlayerAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttachTarget>(builder.EndTable());
		}

		// Token: 0x06027C32 RID: 162866 RVA: 0x00570CAC File Offset: 0x0056EEAC
		public IPlayerAttachTargetT UnPack()
		{
			IPlayerAttachTargetT playerAttachTargetT = new IPlayerAttachTargetT();
			this.UnPackTo(playerAttachTargetT);
			return playerAttachTargetT;
		}

		// Token: 0x06027C33 RID: 162867 RVA: 0x00570CC7 File Offset: 0x0056EEC7
		public void UnPackTo(IPlayerAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027C34 RID: 162868 RVA: 0x00570CD8 File Offset: 0x0056EED8
		public static Offset<IPlayerAttachTarget> Pack(FlatBufferBuilder builder, IPlayerAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAttachTarget>);
			}
			return IPlayerAttachTarget.CreateIPlayerAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400F8D0 RID: 63696
		private Table __p;
	}
}
