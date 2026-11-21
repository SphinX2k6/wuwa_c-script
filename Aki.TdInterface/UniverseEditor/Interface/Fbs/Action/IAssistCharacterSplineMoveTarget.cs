using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006811 RID: 26641
	public struct IAssistCharacterSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700C3D0 RID: 50128
		// (get) Token: 0x0602D819 RID: 186393 RVA: 0x0063AA8E File Offset: 0x00638C8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D81A RID: 186394 RVA: 0x0063AA9B File Offset: 0x00638C9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D81B RID: 186395 RVA: 0x0063AAA4 File Offset: 0x00638CA4
		public static IAssistCharacterSplineMoveTarget GetRootAsIAssistCharacterSplineMoveTarget(ByteBuffer _bb)
		{
			return IAssistCharacterSplineMoveTarget.GetRootAsIAssistCharacterSplineMoveTarget(_bb, default(IAssistCharacterSplineMoveTarget));
		}

		// Token: 0x0602D81C RID: 186396 RVA: 0x0063AAC0 File Offset: 0x00638CC0
		public static IAssistCharacterSplineMoveTarget GetRootAsIAssistCharacterSplineMoveTarget(ByteBuffer _bb, IAssistCharacterSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D81D RID: 186397 RVA: 0x0063AADD File Offset: 0x00638CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D81E RID: 186398 RVA: 0x0063AAEC File Offset: 0x00638CEC
		public IAssistCharacterSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3D1 RID: 50129
		// (get) Token: 0x0602D81F RID: 186399 RVA: 0x0063AAFC File Offset: 0x00638CFC
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3D2 RID: 50130
		// (get) Token: 0x0602D820 RID: 186400 RVA: 0x0063AB38 File Offset: 0x00638D38
		public int TrailRoleId
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

		// Token: 0x0602D821 RID: 186401 RVA: 0x0063AB74 File Offset: 0x00638D74
		public static Offset<IAssistCharacterSplineMoveTarget> CreateIAssistCharacterSplineMoveTarget(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity, int TrailRoleId = 0)
		{
			builder.StartTable(2);
			IAssistCharacterSplineMoveTarget.AddTrailRoleId(builder, TrailRoleId);
			IAssistCharacterSplineMoveTarget.AddType(builder, Type);
			return IAssistCharacterSplineMoveTarget.EndIAssistCharacterSplineMoveTarget(builder);
		}

		// Token: 0x0602D822 RID: 186402 RVA: 0x0063AB91 File Offset: 0x00638D91
		public static void StartIAssistCharacterSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D823 RID: 186403 RVA: 0x0063AB9A File Offset: 0x00638D9A
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D824 RID: 186404 RVA: 0x0063ABA5 File Offset: 0x00638DA5
		public static void AddTrailRoleId(FlatBufferBuilder builder, int trailRoleId)
		{
			builder.AddInt(1, trailRoleId, 0);
		}

		// Token: 0x0602D825 RID: 186405 RVA: 0x0063ABB0 File Offset: 0x00638DB0
		public static Offset<IAssistCharacterSplineMoveTarget> EndIAssistCharacterSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x0602D826 RID: 186406 RVA: 0x0063ABC0 File Offset: 0x00638DC0
		public IAssistCharacterSplineMoveTargetT UnPack()
		{
			IAssistCharacterSplineMoveTargetT assistCharacterSplineMoveTargetT = new IAssistCharacterSplineMoveTargetT();
			this.UnPackTo(assistCharacterSplineMoveTargetT);
			return assistCharacterSplineMoveTargetT;
		}

		// Token: 0x0602D827 RID: 186407 RVA: 0x0063ABDB File Offset: 0x00638DDB
		public void UnPackTo(IAssistCharacterSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TrailRoleId = this.TrailRoleId;
		}

		// Token: 0x0602D828 RID: 186408 RVA: 0x0063ABF8 File Offset: 0x00638DF8
		public static Offset<IAssistCharacterSplineMoveTarget> Pack(FlatBufferBuilder builder, IAssistCharacterSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterSplineMoveTarget>);
			}
			return IAssistCharacterSplineMoveTarget.CreateIAssistCharacterSplineMoveTarget(builder, _o.Type, _o.TrailRoleId);
		}

		// Token: 0x040114C9 RID: 70857
		private Table __p;
	}
}
