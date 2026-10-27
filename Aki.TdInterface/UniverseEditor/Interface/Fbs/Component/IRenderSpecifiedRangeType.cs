using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584F RID: 22607
	public struct IRenderSpecifiedRangeType : IFlatbufferObject
	{
		// Token: 0x1700A8F6 RID: 43254
		// (get) Token: 0x060260CD RID: 155853 RVA: 0x0053F192 File Offset: 0x0053D392
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060260CE RID: 155854 RVA: 0x0053F19F File Offset: 0x0053D39F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060260CF RID: 155855 RVA: 0x0053F1A8 File Offset: 0x0053D3A8
		public static IRenderSpecifiedRangeType GetRootAsIRenderSpecifiedRangeType(ByteBuffer _bb)
		{
			return IRenderSpecifiedRangeType.GetRootAsIRenderSpecifiedRangeType(_bb, default(IRenderSpecifiedRangeType));
		}

		// Token: 0x060260D0 RID: 155856 RVA: 0x0053F1C4 File Offset: 0x0053D3C4
		public static IRenderSpecifiedRangeType GetRootAsIRenderSpecifiedRangeType(ByteBuffer _bb, IRenderSpecifiedRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260D1 RID: 155857 RVA: 0x0053F1E1 File Offset: 0x0053D3E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260D2 RID: 155858 RVA: 0x0053F1F0 File Offset: 0x0053D3F0
		public IRenderSpecifiedRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8F7 RID: 43255
		// (get) Token: 0x060260D3 RID: 155859 RVA: 0x0053F200 File Offset: 0x0053D400
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060260D4 RID: 155860 RVA: 0x0053F23C File Offset: 0x0053D43C
		public static Offset<IRenderSpecifiedRangeType> CreateIRenderSpecifiedRangeType(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge)
		{
			builder.StartTable(1);
			IRenderSpecifiedRangeType.AddType(builder, Type);
			return IRenderSpecifiedRangeType.EndIRenderSpecifiedRangeType(builder);
		}

		// Token: 0x060260D5 RID: 155861 RVA: 0x0053F252 File Offset: 0x0053D452
		public static void StartIRenderSpecifiedRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060260D6 RID: 155862 RVA: 0x0053F25B File Offset: 0x0053D45B
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060260D7 RID: 155863 RVA: 0x0053F266 File Offset: 0x0053D466
		public static Offset<IRenderSpecifiedRangeType> EndIRenderSpecifiedRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IRenderSpecifiedRangeType>(builder.EndTable());
		}

		// Token: 0x060260D8 RID: 155864 RVA: 0x0053F274 File Offset: 0x0053D474
		public IRenderSpecifiedRangeTypeT UnPack()
		{
			IRenderSpecifiedRangeTypeT renderSpecifiedRangeTypeT = new IRenderSpecifiedRangeTypeT();
			this.UnPackTo(renderSpecifiedRangeTypeT);
			return renderSpecifiedRangeTypeT;
		}

		// Token: 0x060260D9 RID: 155865 RVA: 0x0053F28F File Offset: 0x0053D48F
		public void UnPackTo(IRenderSpecifiedRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060260DA RID: 155866 RVA: 0x0053F2A0 File Offset: 0x0053D4A0
		public static Offset<IRenderSpecifiedRangeType> Pack(FlatBufferBuilder builder, IRenderSpecifiedRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderSpecifiedRangeType>);
			}
			return IRenderSpecifiedRangeType.CreateIRenderSpecifiedRangeType(builder, _o.Type);
		}

		// Token: 0x0400ED76 RID: 60790
		private Table __p;
	}
}
