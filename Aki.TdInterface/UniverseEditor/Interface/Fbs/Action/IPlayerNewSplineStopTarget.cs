using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007483 RID: 29827
	public struct IPlayerNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700DB20 RID: 56096
		// (get) Token: 0x06034378 RID: 213880 RVA: 0x00708955 File Offset: 0x00706B55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034379 RID: 213881 RVA: 0x00708962 File Offset: 0x00706B62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603437A RID: 213882 RVA: 0x0070896C File Offset: 0x00706B6C
		public static IPlayerNewSplineStopTarget GetRootAsIPlayerNewSplineStopTarget(ByteBuffer _bb)
		{
			return IPlayerNewSplineStopTarget.GetRootAsIPlayerNewSplineStopTarget(_bb, default(IPlayerNewSplineStopTarget));
		}

		// Token: 0x0603437B RID: 213883 RVA: 0x00708988 File Offset: 0x00706B88
		public static IPlayerNewSplineStopTarget GetRootAsIPlayerNewSplineStopTarget(ByteBuffer _bb, IPlayerNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603437C RID: 213884 RVA: 0x007089A5 File Offset: 0x00706BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603437D RID: 213885 RVA: 0x007089B4 File Offset: 0x00706BB4
		public IPlayerNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB21 RID: 56097
		// (get) Token: 0x0603437E RID: 213886 RVA: 0x007089C4 File Offset: 0x00706BC4
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

		// Token: 0x0603437F RID: 213887 RVA: 0x00708A00 File Offset: 0x00706C00
		public static Offset<IPlayerNewSplineStopTarget> CreateIPlayerNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			IPlayerNewSplineStopTarget.AddType(builder, Type);
			return IPlayerNewSplineStopTarget.EndIPlayerNewSplineStopTarget(builder);
		}

		// Token: 0x06034380 RID: 213888 RVA: 0x00708A16 File Offset: 0x00706C16
		public static void StartIPlayerNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034381 RID: 213889 RVA: 0x00708A1F File Offset: 0x00706C1F
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034382 RID: 213890 RVA: 0x00708A2A File Offset: 0x00706C2A
		public static Offset<IPlayerNewSplineStopTarget> EndIPlayerNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x06034383 RID: 213891 RVA: 0x00708A38 File Offset: 0x00706C38
		public IPlayerNewSplineStopTargetT UnPack()
		{
			IPlayerNewSplineStopTargetT playerNewSplineStopTargetT = new IPlayerNewSplineStopTargetT();
			this.UnPackTo(playerNewSplineStopTargetT);
			return playerNewSplineStopTargetT;
		}

		// Token: 0x06034384 RID: 213892 RVA: 0x00708A53 File Offset: 0x00706C53
		public void UnPackTo(IPlayerNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034385 RID: 213893 RVA: 0x00708A64 File Offset: 0x00706C64
		public static Offset<IPlayerNewSplineStopTarget> Pack(FlatBufferBuilder builder, IPlayerNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerNewSplineStopTarget>);
			}
			return IPlayerNewSplineStopTarget.CreateIPlayerNewSplineStopTarget(builder, _o.Type);
		}

		// Token: 0x040125FF RID: 75263
		private Table __p;
	}
}
