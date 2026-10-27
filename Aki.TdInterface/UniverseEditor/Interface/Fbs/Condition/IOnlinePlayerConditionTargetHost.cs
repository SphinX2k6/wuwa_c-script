using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C61 RID: 19553
	public struct IOnlinePlayerConditionTargetHost : IFlatbufferObject
	{
		// Token: 0x17008E08 RID: 36360
		// (get) Token: 0x0601F007 RID: 126983 RVA: 0x00455D19 File Offset: 0x00453F19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F008 RID: 126984 RVA: 0x00455D26 File Offset: 0x00453F26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F009 RID: 126985 RVA: 0x00455D30 File Offset: 0x00453F30
		public static IOnlinePlayerConditionTargetHost GetRootAsIOnlinePlayerConditionTargetHost(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTargetHost.GetRootAsIOnlinePlayerConditionTargetHost(_bb, default(IOnlinePlayerConditionTargetHost));
		}

		// Token: 0x0601F00A RID: 126986 RVA: 0x00455D4C File Offset: 0x00453F4C
		public static IOnlinePlayerConditionTargetHost GetRootAsIOnlinePlayerConditionTargetHost(ByteBuffer _bb, IOnlinePlayerConditionTargetHost obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F00B RID: 126987 RVA: 0x00455D69 File Offset: 0x00453F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F00C RID: 126988 RVA: 0x00455D78 File Offset: 0x00453F78
		public IOnlinePlayerConditionTargetHost __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E09 RID: 36361
		// (get) Token: 0x0601F00D RID: 126989 RVA: 0x00455D88 File Offset: 0x00453F88
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

		// Token: 0x0601F00E RID: 126990 RVA: 0x00455DC4 File Offset: 0x00453FC4
		public static Offset<IOnlinePlayerConditionTargetHost> CreateIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host)
		{
			builder.StartTable(1);
			IOnlinePlayerConditionTargetHost.AddType(builder, Type);
			return IOnlinePlayerConditionTargetHost.EndIOnlinePlayerConditionTargetHost(builder);
		}

		// Token: 0x0601F00F RID: 126991 RVA: 0x00455DDA File Offset: 0x00453FDA
		public static void StartIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F010 RID: 126992 RVA: 0x00455DE3 File Offset: 0x00453FE3
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F011 RID: 126993 RVA: 0x00455DEE File Offset: 0x00453FEE
		public static Offset<IOnlinePlayerConditionTargetHost> EndIOnlinePlayerConditionTargetHost(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTargetHost>(builder.EndTable());
		}

		// Token: 0x0601F012 RID: 126994 RVA: 0x00455DFC File Offset: 0x00453FFC
		public IOnlinePlayerConditionTargetHostT UnPack()
		{
			IOnlinePlayerConditionTargetHostT onlinePlayerConditionTargetHostT = new IOnlinePlayerConditionTargetHostT();
			this.UnPackTo(onlinePlayerConditionTargetHostT);
			return onlinePlayerConditionTargetHostT;
		}

		// Token: 0x0601F013 RID: 126995 RVA: 0x00455E17 File Offset: 0x00454017
		public void UnPackTo(IOnlinePlayerConditionTargetHostT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F014 RID: 126996 RVA: 0x00455E28 File Offset: 0x00454028
		public static Offset<IOnlinePlayerConditionTargetHost> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetHostT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTargetHost>);
			}
			return IOnlinePlayerConditionTargetHost.CreateIOnlinePlayerConditionTargetHost(builder, _o.Type);
		}

		// Token: 0x0400D60D RID: 54797
		private Table __p;
	}
}
