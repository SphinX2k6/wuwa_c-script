using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005431 RID: 21553
	public struct IInteractAdditionalInfo : IFlatbufferObject
	{
		// Token: 0x17009E84 RID: 40580
		// (get) Token: 0x0602367F RID: 145023 RVA: 0x004E6058 File Offset: 0x004E4258
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023680 RID: 145024 RVA: 0x004E6065 File Offset: 0x004E4265
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023681 RID: 145025 RVA: 0x004E606C File Offset: 0x004E426C
		public static IInteractAdditionalInfo GetRootAsIInteractAdditionalInfo(ByteBuffer _bb)
		{
			return IInteractAdditionalInfo.GetRootAsIInteractAdditionalInfo(_bb, default(IInteractAdditionalInfo));
		}

		// Token: 0x06023682 RID: 145026 RVA: 0x004E6088 File Offset: 0x004E4288
		public static IInteractAdditionalInfo GetRootAsIInteractAdditionalInfo(ByteBuffer _bb, IInteractAdditionalInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023683 RID: 145027 RVA: 0x004E60A5 File Offset: 0x004E42A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023684 RID: 145028 RVA: 0x004E60B4 File Offset: 0x004E42B4
		public IInteractAdditionalInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E85 RID: 40581
		// (get) Token: 0x06023685 RID: 145029 RVA: 0x004E60C4 File Offset: 0x004E42C4
		public EInteractAdditionalInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractAdditionalInfoType.FishingPoint;
				}
				return (EInteractAdditionalInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023686 RID: 145030 RVA: 0x004E6100 File Offset: 0x004E4300
		public static Offset<IInteractAdditionalInfo> CreateIInteractAdditionalInfo(FlatBufferBuilder builder, EInteractAdditionalInfoType Type = EInteractAdditionalInfoType.FishingPoint)
		{
			builder.StartTable(1);
			IInteractAdditionalInfo.AddType(builder, Type);
			return IInteractAdditionalInfo.EndIInteractAdditionalInfo(builder);
		}

		// Token: 0x06023687 RID: 145031 RVA: 0x004E6116 File Offset: 0x004E4316
		public static void StartIInteractAdditionalInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023688 RID: 145032 RVA: 0x004E611F File Offset: 0x004E431F
		public static void AddType(FlatBufferBuilder builder, EInteractAdditionalInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023689 RID: 145033 RVA: 0x004E612A File Offset: 0x004E432A
		public static Offset<IInteractAdditionalInfo> EndIInteractAdditionalInfo(FlatBufferBuilder builder)
		{
			return new Offset<IInteractAdditionalInfo>(builder.EndTable());
		}

		// Token: 0x0602368A RID: 145034 RVA: 0x004E6138 File Offset: 0x004E4338
		public IInteractAdditionalInfoT UnPack()
		{
			IInteractAdditionalInfoT interactAdditionalInfoT = new IInteractAdditionalInfoT();
			this.UnPackTo(interactAdditionalInfoT);
			return interactAdditionalInfoT;
		}

		// Token: 0x0602368B RID: 145035 RVA: 0x004E6153 File Offset: 0x004E4353
		public void UnPackTo(IInteractAdditionalInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602368C RID: 145036 RVA: 0x004E6164 File Offset: 0x004E4364
		public static Offset<IInteractAdditionalInfo> Pack(FlatBufferBuilder builder, IInteractAdditionalInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractAdditionalInfo>);
			}
			return IInteractAdditionalInfo.CreateIInteractAdditionalInfo(builder, _o.Type);
		}

		// Token: 0x0400E684 RID: 59012
		private Table __p;
	}
}
