using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007540 RID: 30016
	public struct IPromptStyleBase : IFlatbufferObject
	{
		// Token: 0x1700DCD4 RID: 56532
		// (get) Token: 0x06034A35 RID: 215605 RVA: 0x007150C4 File Offset: 0x007132C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A36 RID: 215606 RVA: 0x007150D1 File Offset: 0x007132D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A37 RID: 215607 RVA: 0x007150D8 File Offset: 0x007132D8
		public static IPromptStyleBase GetRootAsIPromptStyleBase(ByteBuffer _bb)
		{
			return IPromptStyleBase.GetRootAsIPromptStyleBase(_bb, default(IPromptStyleBase));
		}

		// Token: 0x06034A38 RID: 215608 RVA: 0x007150F4 File Offset: 0x007132F4
		public static IPromptStyleBase GetRootAsIPromptStyleBase(ByteBuffer _bb, IPromptStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A39 RID: 215609 RVA: 0x00715111 File Offset: 0x00713311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A3A RID: 215610 RVA: 0x00715120 File Offset: 0x00713320
		public IPromptStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCD5 RID: 56533
		// (get) Token: 0x06034A3B RID: 215611 RVA: 0x00715130 File Offset: 0x00713330
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A3C RID: 215612 RVA: 0x0071516C File Offset: 0x0071336C
		public static Offset<IPromptStyleBase> CreateIPromptStyleBase(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBase.AddType(builder, Type);
			return IPromptStyleBase.EndIPromptStyleBase(builder);
		}

		// Token: 0x06034A3D RID: 215613 RVA: 0x00715182 File Offset: 0x00713382
		public static void StartIPromptStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A3E RID: 215614 RVA: 0x0071518B File Offset: 0x0071338B
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A3F RID: 215615 RVA: 0x00715196 File Offset: 0x00713396
		public static Offset<IPromptStyleBase> EndIPromptStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBase>(builder.EndTable());
		}

		// Token: 0x06034A40 RID: 215616 RVA: 0x007151A4 File Offset: 0x007133A4
		public IPromptStyleBaseT UnPack()
		{
			IPromptStyleBaseT promptStyleBaseT = new IPromptStyleBaseT();
			this.UnPackTo(promptStyleBaseT);
			return promptStyleBaseT;
		}

		// Token: 0x06034A41 RID: 215617 RVA: 0x007151BF File Offset: 0x007133BF
		public void UnPackTo(IPromptStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A42 RID: 215618 RVA: 0x007151D0 File Offset: 0x007133D0
		public static Offset<IPromptStyleBase> Pack(FlatBufferBuilder builder, IPromptStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBase>);
			}
			return IPromptStyleBase.CreateIPromptStyleBase(builder, _o.Type);
		}

		// Token: 0x0401271F RID: 75551
		private Table __p;
	}
}
