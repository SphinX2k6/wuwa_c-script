using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED8 RID: 28376
	public struct IFollowShooterLeaveThrowInteractionPoint : IFlatbufferObject
	{
		// Token: 0x1700D01E RID: 53278
		// (get) Token: 0x06031185 RID: 201093 RVA: 0x006A81B2 File Offset: 0x006A63B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031186 RID: 201094 RVA: 0x006A81BF File Offset: 0x006A63BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031187 RID: 201095 RVA: 0x006A81C8 File Offset: 0x006A63C8
		public static IFollowShooterLeaveThrowInteractionPoint GetRootAsIFollowShooterLeaveThrowInteractionPoint(ByteBuffer _bb)
		{
			return IFollowShooterLeaveThrowInteractionPoint.GetRootAsIFollowShooterLeaveThrowInteractionPoint(_bb, default(IFollowShooterLeaveThrowInteractionPoint));
		}

		// Token: 0x06031188 RID: 201096 RVA: 0x006A81E4 File Offset: 0x006A63E4
		public static IFollowShooterLeaveThrowInteractionPoint GetRootAsIFollowShooterLeaveThrowInteractionPoint(ByteBuffer _bb, IFollowShooterLeaveThrowInteractionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031189 RID: 201097 RVA: 0x006A8201 File Offset: 0x006A6401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603118A RID: 201098 RVA: 0x006A8210 File Offset: 0x006A6410
		public IFollowShooterLeaveThrowInteractionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D01F RID: 53279
		// (get) Token: 0x0603118B RID: 201099 RVA: 0x006A8220 File Offset: 0x006A6420
		public EFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603118C RID: 201100 RVA: 0x006A825C File Offset: 0x006A645C
		public static Offset<IFollowShooterLeaveThrowInteractionPoint> CreateIFollowShooterLeaveThrowInteractionPoint(FlatBufferBuilder builder, EFollowShooterLeisureInteractType Type = EFollowShooterLeisureInteractType.ResetToPlayer)
		{
			builder.StartTable(1);
			IFollowShooterLeaveThrowInteractionPoint.AddType(builder, Type);
			return IFollowShooterLeaveThrowInteractionPoint.EndIFollowShooterLeaveThrowInteractionPoint(builder);
		}

		// Token: 0x0603118D RID: 201101 RVA: 0x006A8272 File Offset: 0x006A6472
		public static void StartIFollowShooterLeaveThrowInteractionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603118E RID: 201102 RVA: 0x006A827B File Offset: 0x006A647B
		public static void AddType(FlatBufferBuilder builder, EFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603118F RID: 201103 RVA: 0x006A8286 File Offset: 0x006A6486
		public static Offset<IFollowShooterLeaveThrowInteractionPoint> EndIFollowShooterLeaveThrowInteractionPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterLeaveThrowInteractionPoint>(builder.EndTable());
		}

		// Token: 0x06031190 RID: 201104 RVA: 0x006A8294 File Offset: 0x006A6494
		public IFollowShooterLeaveThrowInteractionPointT UnPack()
		{
			IFollowShooterLeaveThrowInteractionPointT followShooterLeaveThrowInteractionPointT = new IFollowShooterLeaveThrowInteractionPointT();
			this.UnPackTo(followShooterLeaveThrowInteractionPointT);
			return followShooterLeaveThrowInteractionPointT;
		}

		// Token: 0x06031191 RID: 201105 RVA: 0x006A82AF File Offset: 0x006A64AF
		public void UnPackTo(IFollowShooterLeaveThrowInteractionPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031192 RID: 201106 RVA: 0x006A82C0 File Offset: 0x006A64C0
		public static Offset<IFollowShooterLeaveThrowInteractionPoint> Pack(FlatBufferBuilder builder, IFollowShooterLeaveThrowInteractionPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterLeaveThrowInteractionPoint>);
			}
			return IFollowShooterLeaveThrowInteractionPoint.CreateIFollowShooterLeaveThrowInteractionPoint(builder, _o.Type);
		}

		// Token: 0x04011DD7 RID: 73175
		private Table __p;
	}
}
