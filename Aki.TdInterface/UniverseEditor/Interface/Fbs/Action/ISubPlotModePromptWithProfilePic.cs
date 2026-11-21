using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D1 RID: 31185
	public struct ISubPlotModePromptWithProfilePic : IFlatbufferObject
	{
		// Token: 0x1700E4A0 RID: 58528
		// (get) Token: 0x06036F14 RID: 225044 RVA: 0x007589D6 File Offset: 0x00756BD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F15 RID: 225045 RVA: 0x007589E3 File Offset: 0x00756BE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F16 RID: 225046 RVA: 0x007589EC File Offset: 0x00756BEC
		public static ISubPlotModePromptWithProfilePic GetRootAsISubPlotModePromptWithProfilePic(ByteBuffer _bb)
		{
			return ISubPlotModePromptWithProfilePic.GetRootAsISubPlotModePromptWithProfilePic(_bb, default(ISubPlotModePromptWithProfilePic));
		}

		// Token: 0x06036F17 RID: 225047 RVA: 0x00758A08 File Offset: 0x00756C08
		public static ISubPlotModePromptWithProfilePic GetRootAsISubPlotModePromptWithProfilePic(ByteBuffer _bb, ISubPlotModePromptWithProfilePic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F18 RID: 225048 RVA: 0x00758A25 File Offset: 0x00756C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F19 RID: 225049 RVA: 0x00758A34 File Offset: 0x00756C34
		public ISubPlotModePromptWithProfilePic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4A1 RID: 58529
		// (get) Token: 0x06036F1A RID: 225050 RVA: 0x00758A44 File Offset: 0x00756C44
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

		// Token: 0x06036F1B RID: 225051 RVA: 0x00758A80 File Offset: 0x00756C80
		public static Offset<ISubPlotModePromptWithProfilePic> CreateISubPlotModePromptWithProfilePic(FlatBufferBuilder builder, ESubPlotModeType Type = ESubPlotModeType.PromptWithProfilePic)
		{
			builder.StartTable(1);
			ISubPlotModePromptWithProfilePic.AddType(builder, Type);
			return ISubPlotModePromptWithProfilePic.EndISubPlotModePromptWithProfilePic(builder);
		}

		// Token: 0x06036F1C RID: 225052 RVA: 0x00758A96 File Offset: 0x00756C96
		public static void StartISubPlotModePromptWithProfilePic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036F1D RID: 225053 RVA: 0x00758A9F File Offset: 0x00756C9F
		public static void AddType(FlatBufferBuilder builder, ESubPlotModeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F1E RID: 225054 RVA: 0x00758AAA File Offset: 0x00756CAA
		public static Offset<ISubPlotModePromptWithProfilePic> EndISubPlotModePromptWithProfilePic(FlatBufferBuilder builder)
		{
			return new Offset<ISubPlotModePromptWithProfilePic>(builder.EndTable());
		}

		// Token: 0x06036F1F RID: 225055 RVA: 0x00758AB8 File Offset: 0x00756CB8
		public ISubPlotModePromptWithProfilePicT UnPack()
		{
			ISubPlotModePromptWithProfilePicT subPlotModePromptWithProfilePicT = new ISubPlotModePromptWithProfilePicT();
			this.UnPackTo(subPlotModePromptWithProfilePicT);
			return subPlotModePromptWithProfilePicT;
		}

		// Token: 0x06036F20 RID: 225056 RVA: 0x00758AD3 File Offset: 0x00756CD3
		public void UnPackTo(ISubPlotModePromptWithProfilePicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036F21 RID: 225057 RVA: 0x00758AE4 File Offset: 0x00756CE4
		public static Offset<ISubPlotModePromptWithProfilePic> Pack(FlatBufferBuilder builder, ISubPlotModePromptWithProfilePicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubPlotModePromptWithProfilePic>);
			}
			return ISubPlotModePromptWithProfilePic.CreateISubPlotModePromptWithProfilePic(builder, _o.Type);
		}

		// Token: 0x04012CE3 RID: 77027
		private Table __p;
	}
}
