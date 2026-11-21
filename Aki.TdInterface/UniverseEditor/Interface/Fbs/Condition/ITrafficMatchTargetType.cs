using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051FC RID: 20988
	public struct ITrafficMatchTargetType : IFlatbufferObject
	{
		// Token: 0x1700963F RID: 38463
		// (get) Token: 0x060210E7 RID: 135399 RVA: 0x004916DB File Offset: 0x0048F8DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210E8 RID: 135400 RVA: 0x004916E8 File Offset: 0x0048F8E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210E9 RID: 135401 RVA: 0x004916F0 File Offset: 0x0048F8F0
		public static ITrafficMatchTargetType GetRootAsITrafficMatchTargetType(ByteBuffer _bb)
		{
			return ITrafficMatchTargetType.GetRootAsITrafficMatchTargetType(_bb, default(ITrafficMatchTargetType));
		}

		// Token: 0x060210EA RID: 135402 RVA: 0x0049170C File Offset: 0x0048F90C
		public static ITrafficMatchTargetType GetRootAsITrafficMatchTargetType(ByteBuffer _bb, ITrafficMatchTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210EB RID: 135403 RVA: 0x00491729 File Offset: 0x0048F929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210EC RID: 135404 RVA: 0x00491738 File Offset: 0x0048F938
		public ITrafficMatchTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009640 RID: 38464
		// (get) Token: 0x060210ED RID: 135405 RVA: 0x00491748 File Offset: 0x0048F948
		public ETrafficMatchTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrafficMatchTargetType.MatchByEntityLogic;
				}
				return (ETrafficMatchTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060210EE RID: 135406 RVA: 0x00491784 File Offset: 0x0048F984
		public static Offset<ITrafficMatchTargetType> CreateITrafficMatchTargetType(FlatBufferBuilder builder, ETrafficMatchTargetType Type = ETrafficMatchTargetType.MatchByEntityLogic)
		{
			builder.StartTable(1);
			ITrafficMatchTargetType.AddType(builder, Type);
			return ITrafficMatchTargetType.EndITrafficMatchTargetType(builder);
		}

		// Token: 0x060210EF RID: 135407 RVA: 0x0049179A File Offset: 0x0048F99A
		public static void StartITrafficMatchTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060210F0 RID: 135408 RVA: 0x004917A3 File Offset: 0x0048F9A3
		public static void AddType(FlatBufferBuilder builder, ETrafficMatchTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060210F1 RID: 135409 RVA: 0x004917AE File Offset: 0x0048F9AE
		public static Offset<ITrafficMatchTargetType> EndITrafficMatchTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTargetType>(builder.EndTable());
		}

		// Token: 0x060210F2 RID: 135410 RVA: 0x004917BC File Offset: 0x0048F9BC
		public ITrafficMatchTargetTypeT UnPack()
		{
			ITrafficMatchTargetTypeT trafficMatchTargetTypeT = new ITrafficMatchTargetTypeT();
			this.UnPackTo(trafficMatchTargetTypeT);
			return trafficMatchTargetTypeT;
		}

		// Token: 0x060210F3 RID: 135411 RVA: 0x004917D7 File Offset: 0x0048F9D7
		public void UnPackTo(ITrafficMatchTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060210F4 RID: 135412 RVA: 0x004917E8 File Offset: 0x0048F9E8
		public static Offset<ITrafficMatchTargetType> Pack(FlatBufferBuilder builder, ITrafficMatchTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTargetType>);
			}
			return ITrafficMatchTargetType.CreateITrafficMatchTargetType(builder, _o.Type);
		}

		// Token: 0x0400E209 RID: 57865
		private Table __p;
	}
}
