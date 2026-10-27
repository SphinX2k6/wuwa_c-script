using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C5E RID: 19550
	public struct IOnlinePlayerConditionTarget : IFlatbufferObject
	{
		// Token: 0x17008E05 RID: 36357
		// (get) Token: 0x0601EFF5 RID: 126965 RVA: 0x00455BA4 File Offset: 0x00453DA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFF6 RID: 126966 RVA: 0x00455BB1 File Offset: 0x00453DB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFF7 RID: 126967 RVA: 0x00455BB8 File Offset: 0x00453DB8
		public static IOnlinePlayerConditionTarget GetRootAsIOnlinePlayerConditionTarget(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTarget.GetRootAsIOnlinePlayerConditionTarget(_bb, default(IOnlinePlayerConditionTarget));
		}

		// Token: 0x0601EFF8 RID: 126968 RVA: 0x00455BD4 File Offset: 0x00453DD4
		public static IOnlinePlayerConditionTarget GetRootAsIOnlinePlayerConditionTarget(ByteBuffer _bb, IOnlinePlayerConditionTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFF9 RID: 126969 RVA: 0x00455BF1 File Offset: 0x00453DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFFA RID: 126970 RVA: 0x00455C00 File Offset: 0x00453E00
		public IOnlinePlayerConditionTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E06 RID: 36358
		// (get) Token: 0x0601EFFB RID: 126971 RVA: 0x00455C10 File Offset: 0x00453E10
		public EOnlinePlayerConditionTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOnlinePlayerConditionTarget.Host;
				}
				return (EOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EFFC RID: 126972 RVA: 0x00455C4C File Offset: 0x00453E4C
		public static Offset<IOnlinePlayerConditionTarget> CreateIOnlinePlayerConditionTarget(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host)
		{
			builder.StartTable(1);
			IOnlinePlayerConditionTarget.AddType(builder, Type);
			return IOnlinePlayerConditionTarget.EndIOnlinePlayerConditionTarget(builder);
		}

		// Token: 0x0601EFFD RID: 126973 RVA: 0x00455C62 File Offset: 0x00453E62
		public static void StartIOnlinePlayerConditionTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EFFE RID: 126974 RVA: 0x00455C6B File Offset: 0x00453E6B
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFFF RID: 126975 RVA: 0x00455C76 File Offset: 0x00453E76
		public static Offset<IOnlinePlayerConditionTarget> EndIOnlinePlayerConditionTarget(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTarget>(builder.EndTable());
		}

		// Token: 0x0601F000 RID: 126976 RVA: 0x00455C84 File Offset: 0x00453E84
		public IOnlinePlayerConditionTargetT UnPack()
		{
			IOnlinePlayerConditionTargetT onlinePlayerConditionTargetT = new IOnlinePlayerConditionTargetT();
			this.UnPackTo(onlinePlayerConditionTargetT);
			return onlinePlayerConditionTargetT;
		}

		// Token: 0x0601F001 RID: 126977 RVA: 0x00455C9F File Offset: 0x00453E9F
		public void UnPackTo(IOnlinePlayerConditionTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F002 RID: 126978 RVA: 0x00455CB0 File Offset: 0x00453EB0
		public static Offset<IOnlinePlayerConditionTarget> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTarget>);
			}
			return IOnlinePlayerConditionTarget.CreateIOnlinePlayerConditionTarget(builder, _o.Type);
		}

		// Token: 0x0400D60B RID: 54795
		private Table __p;
	}
}
