using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200515A RID: 20826
	public struct IOnlinePlayerConditionTargetHost : IFlatbufferObject
	{
		// Token: 0x17009536 RID: 38198
		// (get) Token: 0x06020C29 RID: 134185 RVA: 0x00489869 File Offset: 0x00487A69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C2A RID: 134186 RVA: 0x00489876 File Offset: 0x00487A76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C2B RID: 134187 RVA: 0x00489880 File Offset: 0x00487A80
		public static IOnlinePlayerConditionTargetHost GetRootAsIOnlinePlayerConditionTargetHost(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTargetHost.GetRootAsIOnlinePlayerConditionTargetHost(_bb, default(IOnlinePlayerConditionTargetHost));
		}

		// Token: 0x06020C2C RID: 134188 RVA: 0x0048989C File Offset: 0x00487A9C
		public static IOnlinePlayerConditionTargetHost GetRootAsIOnlinePlayerConditionTargetHost(ByteBuffer _bb, IOnlinePlayerConditionTargetHost obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C2D RID: 134189 RVA: 0x004898B9 File Offset: 0x00487AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C2E RID: 134190 RVA: 0x004898C8 File Offset: 0x00487AC8
		public IOnlinePlayerConditionTargetHost __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009537 RID: 38199
		// (get) Token: 0x06020C2F RID: 134191 RVA: 0x004898D8 File Offset: 0x00487AD8
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

		// Token: 0x06020C30 RID: 134192 RVA: 0x00489914 File Offset: 0x00487B14
		public static Offset<IOnlinePlayerConditionTargetHost> CreateIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host)
		{
			builder.StartTable(1);
			IOnlinePlayerConditionTargetHost.AddType(builder, Type);
			return IOnlinePlayerConditionTargetHost.EndIOnlinePlayerConditionTargetHost(builder);
		}

		// Token: 0x06020C31 RID: 134193 RVA: 0x0048992A File Offset: 0x00487B2A
		public static void StartIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020C32 RID: 134194 RVA: 0x00489933 File Offset: 0x00487B33
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C33 RID: 134195 RVA: 0x0048993E File Offset: 0x00487B3E
		public static Offset<IOnlinePlayerConditionTargetHost> EndIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTargetHost>(builder.EndTable());
		}

		// Token: 0x06020C34 RID: 134196 RVA: 0x0048994C File Offset: 0x00487B4C
		public IOnlinePlayerConditionTargetHostT UnPack()
		{
			IOnlinePlayerConditionTargetHostT onlinePlayerConditionTargetHostT = new IOnlinePlayerConditionTargetHostT();
			this.UnPackTo(onlinePlayerConditionTargetHostT);
			return onlinePlayerConditionTargetHostT;
		}

		// Token: 0x06020C35 RID: 134197 RVA: 0x00489967 File Offset: 0x00487B67
		public void UnPackTo(IOnlinePlayerConditionTargetHostT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020C36 RID: 134198 RVA: 0x00489978 File Offset: 0x00487B78
		public static Offset<IOnlinePlayerConditionTargetHost> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetHostT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTargetHost>);
			}
			return IOnlinePlayerConditionTargetHost.CreateIOnlinePlayerConditionTargetHost(builder, _o.Type);
		}

		// Token: 0x0400E134 RID: 57652
		private Table __p;
	}
}
