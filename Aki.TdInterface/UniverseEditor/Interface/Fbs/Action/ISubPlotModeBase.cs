using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F6 RID: 29174
	public struct ISubPlotModeBase : IFlatbufferObject
	{
		// Token: 0x1700D8A2 RID: 55458
		// (get) Token: 0x06033BF4 RID: 211956 RVA: 0x006F7404 File Offset: 0x006F5604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033BF5 RID: 211957 RVA: 0x006F7411 File Offset: 0x006F5611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033BF6 RID: 211958 RVA: 0x006F7418 File Offset: 0x006F5618
		public static ISubPlotModeBase GetRootAsISubPlotModeBase(ByteBuffer _bb)
		{
			return ISubPlotModeBase.GetRootAsISubPlotModeBase(_bb, default(ISubPlotModeBase));
		}

		// Token: 0x06033BF7 RID: 211959 RVA: 0x006F7434 File Offset: 0x006F5634
		public static ISubPlotModeBase GetRootAsISubPlotModeBase(ByteBuffer _bb, ISubPlotModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033BF8 RID: 211960 RVA: 0x006F7451 File Offset: 0x006F5651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033BF9 RID: 211961 RVA: 0x006F7460 File Offset: 0x006F5660
		public ISubPlotModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8A3 RID: 55459
		// (get) Token: 0x06033BFA RID: 211962 RVA: 0x006F7470 File Offset: 0x006F5670
		public ESubPlotModeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubPlotModeType.PromptWithProfilePic;
				}
				return (ESubPlotModeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033BFB RID: 211963 RVA: 0x006F74AC File Offset: 0x006F56AC
		public static Offset<ISubPlotModeBase> CreateISubPlotModeBase(FlatBufferBuilder builder, ESubPlotModeType Type = ESubPlotModeType.PromptWithProfilePic)
		{
			builder.StartTable(1);
			ISubPlotModeBase.AddType(builder, Type);
			return ISubPlotModeBase.EndISubPlotModeBase(builder);
		}

		// Token: 0x06033BFC RID: 211964 RVA: 0x006F74C2 File Offset: 0x006F56C2
		public static void StartISubPlotModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033BFD RID: 211965 RVA: 0x006F74CB File Offset: 0x006F56CB
		public static void AddType(FlatBufferBuilder builder, ESubPlotModeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033BFE RID: 211966 RVA: 0x006F74D6 File Offset: 0x006F56D6
		public static Offset<ISubPlotModeBase> EndISubPlotModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISubPlotModeBase>(builder.EndTable());
		}

		// Token: 0x06033BFF RID: 211967 RVA: 0x006F74E4 File Offset: 0x006F56E4
		public ISubPlotModeBaseT UnPack()
		{
			ISubPlotModeBaseT subPlotModeBaseT = new ISubPlotModeBaseT();
			this.UnPackTo(subPlotModeBaseT);
			return subPlotModeBaseT;
		}

		// Token: 0x06033C00 RID: 211968 RVA: 0x006F74FF File Offset: 0x006F56FF
		public void UnPackTo(ISubPlotModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033C01 RID: 211969 RVA: 0x006F7510 File Offset: 0x006F5710
		public static Offset<ISubPlotModeBase> Pack(FlatBufferBuilder builder, ISubPlotModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubPlotModeBase>);
			}
			return ISubPlotModeBase.CreateISubPlotModeBase(builder, _o.Type);
		}

		// Token: 0x04011CD9 RID: 72921
		private Table __p;
	}
}
