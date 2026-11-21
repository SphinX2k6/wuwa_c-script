using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007480 RID: 29824
	public struct IPlayerNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700DB1D RID: 56093
		// (get) Token: 0x06034366 RID: 213862 RVA: 0x007087DF File Offset: 0x007069DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034367 RID: 213863 RVA: 0x007087EC File Offset: 0x007069EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034368 RID: 213864 RVA: 0x007087F4 File Offset: 0x007069F4
		public static IPlayerNewSplineMoveTarget GetRootAsIPlayerNewSplineMoveTarget(ByteBuffer _bb)
		{
			return IPlayerNewSplineMoveTarget.GetRootAsIPlayerNewSplineMoveTarget(_bb, default(IPlayerNewSplineMoveTarget));
		}

		// Token: 0x06034369 RID: 213865 RVA: 0x00708810 File Offset: 0x00706A10
		public static IPlayerNewSplineMoveTarget GetRootAsIPlayerNewSplineMoveTarget(ByteBuffer _bb, IPlayerNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603436A RID: 213866 RVA: 0x0070882D File Offset: 0x00706A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603436B RID: 213867 RVA: 0x0070883C File Offset: 0x00706A3C
		public IPlayerNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB1E RID: 56094
		// (get) Token: 0x0603436C RID: 213868 RVA: 0x0070884C File Offset: 0x00706A4C
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603436D RID: 213869 RVA: 0x00708888 File Offset: 0x00706A88
		public static Offset<IPlayerNewSplineMoveTarget> CreateIPlayerNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			IPlayerNewSplineMoveTarget.AddType(builder, Type);
			return IPlayerNewSplineMoveTarget.EndIPlayerNewSplineMoveTarget(builder);
		}

		// Token: 0x0603436E RID: 213870 RVA: 0x0070889E File Offset: 0x00706A9E
		public static void StartIPlayerNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603436F RID: 213871 RVA: 0x007088A7 File Offset: 0x00706AA7
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034370 RID: 213872 RVA: 0x007088B2 File Offset: 0x00706AB2
		public static Offset<IPlayerNewSplineMoveTarget> EndIPlayerNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06034371 RID: 213873 RVA: 0x007088C0 File Offset: 0x00706AC0
		public IPlayerNewSplineMoveTargetT UnPack()
		{
			IPlayerNewSplineMoveTargetT playerNewSplineMoveTargetT = new IPlayerNewSplineMoveTargetT();
			this.UnPackTo(playerNewSplineMoveTargetT);
			return playerNewSplineMoveTargetT;
		}

		// Token: 0x06034372 RID: 213874 RVA: 0x007088DB File Offset: 0x00706ADB
		public void UnPackTo(IPlayerNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034373 RID: 213875 RVA: 0x007088EC File Offset: 0x00706AEC
		public static Offset<IPlayerNewSplineMoveTarget> Pack(FlatBufferBuilder builder, IPlayerNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerNewSplineMoveTarget>);
			}
			return IPlayerNewSplineMoveTarget.CreateIPlayerNewSplineMoveTarget(builder, _o.Type);
		}

		// Token: 0x040125FD RID: 75261
		private Table __p;
	}
}
