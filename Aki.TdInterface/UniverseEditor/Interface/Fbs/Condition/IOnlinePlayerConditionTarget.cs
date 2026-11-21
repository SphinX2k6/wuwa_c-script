using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005157 RID: 20823
	public struct IOnlinePlayerConditionTarget : IFlatbufferObject
	{
		// Token: 0x17009533 RID: 38195
		// (get) Token: 0x06020C17 RID: 134167 RVA: 0x004896F4 File Offset: 0x004878F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C18 RID: 134168 RVA: 0x00489701 File Offset: 0x00487901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C19 RID: 134169 RVA: 0x00489708 File Offset: 0x00487908
		public static IOnlinePlayerConditionTarget GetRootAsIOnlinePlayerConditionTarget(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTarget.GetRootAsIOnlinePlayerConditionTarget(_bb, default(IOnlinePlayerConditionTarget));
		}

		// Token: 0x06020C1A RID: 134170 RVA: 0x00489724 File Offset: 0x00487924
		public static IOnlinePlayerConditionTarget GetRootAsIOnlinePlayerConditionTarget(ByteBuffer _bb, IOnlinePlayerConditionTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C1B RID: 134171 RVA: 0x00489741 File Offset: 0x00487941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C1C RID: 134172 RVA: 0x00489750 File Offset: 0x00487950
		public IOnlinePlayerConditionTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009534 RID: 38196
		// (get) Token: 0x06020C1D RID: 134173 RVA: 0x00489760 File Offset: 0x00487960
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

		// Token: 0x06020C1E RID: 134174 RVA: 0x0048979C File Offset: 0x0048799C
		public static Offset<IOnlinePlayerConditionTarget> CreateIOnlinePlayerConditionTarget(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host)
		{
			builder.StartTable(1);
			IOnlinePlayerConditionTarget.AddType(builder, Type);
			return IOnlinePlayerConditionTarget.EndIOnlinePlayerConditionTarget(builder);
		}

		// Token: 0x06020C1F RID: 134175 RVA: 0x004897B2 File Offset: 0x004879B2
		public static void StartIOnlinePlayerConditionTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020C20 RID: 134176 RVA: 0x004897BB File Offset: 0x004879BB
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C21 RID: 134177 RVA: 0x004897C6 File Offset: 0x004879C6
		public static Offset<IOnlinePlayerConditionTarget> EndIOnlinePlayerConditionTarget(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTarget>(builder.EndTable());
		}

		// Token: 0x06020C22 RID: 134178 RVA: 0x004897D4 File Offset: 0x004879D4
		public IOnlinePlayerConditionTargetT UnPack()
		{
			IOnlinePlayerConditionTargetT onlinePlayerConditionTargetT = new IOnlinePlayerConditionTargetT();
			this.UnPackTo(onlinePlayerConditionTargetT);
			return onlinePlayerConditionTargetT;
		}

		// Token: 0x06020C23 RID: 134179 RVA: 0x004897EF File Offset: 0x004879EF
		public void UnPackTo(IOnlinePlayerConditionTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020C24 RID: 134180 RVA: 0x00489800 File Offset: 0x00487A00
		public static Offset<IOnlinePlayerConditionTarget> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTarget>);
			}
			return IOnlinePlayerConditionTarget.CreateIOnlinePlayerConditionTarget(builder, _o.Type);
		}

		// Token: 0x0400E132 RID: 57650
		private Table __p;
	}
}
