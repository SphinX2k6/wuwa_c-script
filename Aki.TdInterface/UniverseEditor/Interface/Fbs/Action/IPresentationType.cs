using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAA RID: 28074
	public struct IPresentationType : IFlatbufferObject
	{
		// Token: 0x1700D15F RID: 53599
		// (get) Token: 0x06031979 RID: 203129 RVA: 0x006B872E File Offset: 0x006B692E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603197A RID: 203130 RVA: 0x006B873B File Offset: 0x006B693B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603197B RID: 203131 RVA: 0x006B8744 File Offset: 0x006B6944
		public static IPresentationType GetRootAsIPresentationType(ByteBuffer _bb)
		{
			return IPresentationType.GetRootAsIPresentationType(_bb, default(IPresentationType));
		}

		// Token: 0x0603197C RID: 203132 RVA: 0x006B8760 File Offset: 0x006B6960
		public static IPresentationType GetRootAsIPresentationType(ByteBuffer _bb, IPresentationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603197D RID: 203133 RVA: 0x006B877D File Offset: 0x006B697D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603197E RID: 203134 RVA: 0x006B878C File Offset: 0x006B698C
		public IPresentationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D160 RID: 53600
		// (get) Token: 0x0603197F RID: 203135 RVA: 0x006B879C File Offset: 0x006B699C
		public EResetPresentationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPresentationType.Failure;
				}
				return (EResetPresentationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031980 RID: 203136 RVA: 0x006B87D8 File Offset: 0x006B69D8
		public static Offset<IPresentationType> CreateIPresentationType(FlatBufferBuilder builder, EResetPresentationType Type = EResetPresentationType.Failure)
		{
			builder.StartTable(1);
			IPresentationType.AddType(builder, Type);
			return IPresentationType.EndIPresentationType(builder);
		}

		// Token: 0x06031981 RID: 203137 RVA: 0x006B87EE File Offset: 0x006B69EE
		public static void StartIPresentationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031982 RID: 203138 RVA: 0x006B87F7 File Offset: 0x006B69F7
		public static void AddType(FlatBufferBuilder builder, EResetPresentationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031983 RID: 203139 RVA: 0x006B8802 File Offset: 0x006B6A02
		public static Offset<IPresentationType> EndIPresentationType(FlatBufferBuilder builder)
		{
			return new Offset<IPresentationType>(builder.EndTable());
		}

		// Token: 0x06031984 RID: 203140 RVA: 0x006B8810 File Offset: 0x006B6A10
		public IPresentationTypeT UnPack()
		{
			IPresentationTypeT presentationTypeT = new IPresentationTypeT();
			this.UnPackTo(presentationTypeT);
			return presentationTypeT;
		}

		// Token: 0x06031985 RID: 203141 RVA: 0x006B882B File Offset: 0x006B6A2B
		public void UnPackTo(IPresentationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031986 RID: 203142 RVA: 0x006B883C File Offset: 0x006B6A3C
		public static Offset<IPresentationType> Pack(FlatBufferBuilder builder, IPresentationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPresentationType>);
			}
			return IPresentationType.CreateIPresentationType(builder, _o.Type);
		}

		// Token: 0x0401177F RID: 71551
		private Table __p;
	}
}
