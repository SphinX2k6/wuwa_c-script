using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079CB RID: 31179
	public struct ISubPlotModeBase : IFlatbufferObject
	{
		// Token: 0x1700E49B RID: 58523
		// (get) Token: 0x06036EF6 RID: 225014 RVA: 0x00758764 File Offset: 0x00756964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036EF7 RID: 225015 RVA: 0x00758771 File Offset: 0x00756971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036EF8 RID: 225016 RVA: 0x00758778 File Offset: 0x00756978
		public static ISubPlotModeBase GetRootAsISubPlotModeBase(ByteBuffer _bb)
		{
			return ISubPlotModeBase.GetRootAsISubPlotModeBase(_bb, default(ISubPlotModeBase));
		}

		// Token: 0x06036EF9 RID: 225017 RVA: 0x00758794 File Offset: 0x00756994
		public static ISubPlotModeBase GetRootAsISubPlotModeBase(ByteBuffer _bb, ISubPlotModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EFA RID: 225018 RVA: 0x007587B1 File Offset: 0x007569B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EFB RID: 225019 RVA: 0x007587C0 File Offset: 0x007569C0
		public ISubPlotModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E49C RID: 58524
		// (get) Token: 0x06036EFC RID: 225020 RVA: 0x007587D0 File Offset: 0x007569D0
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

		// Token: 0x06036EFD RID: 225021 RVA: 0x0075880C File Offset: 0x00756A0C
		public static Offset<ISubPlotModeBase> CreateISubPlotModeBase(FlatBufferBuilder builder, ESubPlotModeType Type = ESubPlotModeType.PromptWithProfilePic)
		{
			builder.StartTable(1);
			ISubPlotModeBase.AddType(builder, Type);
			return ISubPlotModeBase.EndISubPlotModeBase(builder);
		}

		// Token: 0x06036EFE RID: 225022 RVA: 0x00758822 File Offset: 0x00756A22
		public static void StartISubPlotModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036EFF RID: 225023 RVA: 0x0075882B File Offset: 0x00756A2B
		public static void AddType(FlatBufferBuilder builder, ESubPlotModeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F00 RID: 225024 RVA: 0x00758836 File Offset: 0x00756A36
		public static Offset<ISubPlotModeBase> EndISubPlotModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISubPlotModeBase>(builder.EndTable());
		}

		// Token: 0x06036F01 RID: 225025 RVA: 0x00758844 File Offset: 0x00756A44
		public ISubPlotModeBaseT UnPack()
		{
			ISubPlotModeBaseT subPlotModeBaseT = new ISubPlotModeBaseT();
			this.UnPackTo(subPlotModeBaseT);
			return subPlotModeBaseT;
		}

		// Token: 0x06036F02 RID: 225026 RVA: 0x0075885F File Offset: 0x00756A5F
		public void UnPackTo(ISubPlotModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036F03 RID: 225027 RVA: 0x00758870 File Offset: 0x00756A70
		public static Offset<ISubPlotModeBase> Pack(FlatBufferBuilder builder, ISubPlotModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubPlotModeBase>);
			}
			return ISubPlotModeBase.CreateISubPlotModeBase(builder, _o.Type);
		}

		// Token: 0x04012CDB RID: 77019
		private Table __p;
	}
}
