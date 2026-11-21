using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B31 RID: 19249
	public struct IUnfreezeInstanceLimit : IFlatbufferObject
	{
		// Token: 0x17008705 RID: 34565
		// (get) Token: 0x0601D09E RID: 118942 RVA: 0x00414CDF File Offset: 0x00412EDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D09F RID: 118943 RVA: 0x00414CEC File Offset: 0x00412EEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0A0 RID: 118944 RVA: 0x00414CF4 File Offset: 0x00412EF4
		public static IUnfreezeInstanceLimit GetRootAsIUnfreezeInstanceLimit(ByteBuffer _bb)
		{
			return IUnfreezeInstanceLimit.GetRootAsIUnfreezeInstanceLimit(_bb, default(IUnfreezeInstanceLimit));
		}

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x00414D10 File Offset: 0x00412F10
		public static IUnfreezeInstanceLimit GetRootAsIUnfreezeInstanceLimit(ByteBuffer _bb, IUnfreezeInstanceLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0A2 RID: 118946 RVA: 0x00414D2D File Offset: 0x00412F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0A3 RID: 118947 RVA: 0x00414D3C File Offset: 0x00412F3C
		public IUnfreezeInstanceLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008706 RID: 34566
		// (get) Token: 0x0601D0A4 RID: 118948 RVA: 0x00414D4C File Offset: 0x00412F4C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D0A5 RID: 118949 RVA: 0x00414D88 File Offset: 0x00412F88
		public static Offset<IUnfreezeInstanceLimit> CreateIUnfreezeInstanceLimit(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IUnfreezeInstanceLimit.AddType(builder, Type);
			return IUnfreezeInstanceLimit.EndIUnfreezeInstanceLimit(builder);
		}

		// Token: 0x0601D0A6 RID: 118950 RVA: 0x00414D9E File Offset: 0x00412F9E
		public static void StartIUnfreezeInstanceLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x00414DA7 File Offset: 0x00412FA7
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x00414DB2 File Offset: 0x00412FB2
		public static Offset<IUnfreezeInstanceLimit> EndIUnfreezeInstanceLimit(FlatBufferBuilder builder)
		{
			return new Offset<IUnfreezeInstanceLimit>(builder.EndTable());
		}

		// Token: 0x0601D0A9 RID: 118953 RVA: 0x00414DC0 File Offset: 0x00412FC0
		public IUnfreezeInstanceLimitT UnPack()
		{
			IUnfreezeInstanceLimitT unfreezeInstanceLimitT = new IUnfreezeInstanceLimitT();
			this.UnPackTo(unfreezeInstanceLimitT);
			return unfreezeInstanceLimitT;
		}

		// Token: 0x0601D0AA RID: 118954 RVA: 0x00414DDB File Offset: 0x00412FDB
		public void UnPackTo(IUnfreezeInstanceLimitT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D0AB RID: 118955 RVA: 0x00414DEC File Offset: 0x00412FEC
		public static Offset<IUnfreezeInstanceLimit> Pack(FlatBufferBuilder builder, IUnfreezeInstanceLimitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnfreezeInstanceLimit>);
			}
			return IUnfreezeInstanceLimit.CreateIUnfreezeInstanceLimit(builder, _o.Type);
		}

		// Token: 0x0400D2CC RID: 53964
		private Table __p;
	}
}
