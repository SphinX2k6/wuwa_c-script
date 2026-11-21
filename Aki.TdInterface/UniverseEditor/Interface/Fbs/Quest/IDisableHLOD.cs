using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420E RID: 16910
	public struct IDisableHLOD : IFlatbufferObject
	{
		// Token: 0x1700732D RID: 29485
		// (get) Token: 0x060177B6 RID: 96182 RVA: 0x0035A74F File Offset: 0x0035894F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060177B7 RID: 96183 RVA: 0x0035A75C File Offset: 0x0035895C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060177B8 RID: 96184 RVA: 0x0035A764 File Offset: 0x00358964
		public static IDisableHLOD GetRootAsIDisableHLOD(ByteBuffer _bb)
		{
			return IDisableHLOD.GetRootAsIDisableHLOD(_bb, default(IDisableHLOD));
		}

		// Token: 0x060177B9 RID: 96185 RVA: 0x0035A780 File Offset: 0x00358980
		public static IDisableHLOD GetRootAsIDisableHLOD(ByteBuffer _bb, IDisableHLOD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060177BA RID: 96186 RVA: 0x0035A79D File Offset: 0x0035899D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060177BB RID: 96187 RVA: 0x0035A7AC File Offset: 0x003589AC
		public IDisableHLOD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700732E RID: 29486
		// (get) Token: 0x060177BC RID: 96188 RVA: 0x0035A7BC File Offset: 0x003589BC
		public EOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOperation.DisableHLOD;
				}
				return (EOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700732F RID: 29487
		// (get) Token: 0x060177BD RID: 96189 RVA: 0x0035A7F8 File Offset: 0x003589F8
		public bool IsDisable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060177BE RID: 96190 RVA: 0x0035A837 File Offset: 0x00358A37
		public static Offset<IDisableHLOD> CreateIDisableHLOD(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD, bool IsDisable = false)
		{
			builder.StartTable(2);
			IDisableHLOD.AddIsDisable(builder, IsDisable);
			IDisableHLOD.AddType(builder, Type);
			return IDisableHLOD.EndIDisableHLOD(builder);
		}

		// Token: 0x060177BF RID: 96191 RVA: 0x0035A854 File Offset: 0x00358A54
		public static void StartIDisableHLOD(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060177C0 RID: 96192 RVA: 0x0035A85D File Offset: 0x00358A5D
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060177C1 RID: 96193 RVA: 0x0035A868 File Offset: 0x00358A68
		public static void AddIsDisable(FlatBufferBuilder builder, bool isDisable)
		{
			builder.AddBool(1, isDisable, false);
		}

		// Token: 0x060177C2 RID: 96194 RVA: 0x0035A873 File Offset: 0x00358A73
		public static Offset<IDisableHLOD> EndIDisableHLOD(FlatBufferBuilder builder)
		{
			return new Offset<IDisableHLOD>(builder.EndTable());
		}

		// Token: 0x060177C3 RID: 96195 RVA: 0x0035A880 File Offset: 0x00358A80
		public IDisableHLODT UnPack()
		{
			IDisableHLODT disableHLODT = new IDisableHLODT();
			this.UnPackTo(disableHLODT);
			return disableHLODT;
		}

		// Token: 0x060177C4 RID: 96196 RVA: 0x0035A89B File Offset: 0x00358A9B
		public void UnPackTo(IDisableHLODT _o)
		{
			_o.Type = this.Type;
			_o.IsDisable = this.IsDisable;
		}

		// Token: 0x060177C5 RID: 96197 RVA: 0x0035A8B8 File Offset: 0x00358AB8
		public static Offset<IDisableHLOD> Pack(FlatBufferBuilder builder, IDisableHLODT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableHLOD>);
			}
			return IDisableHLOD.CreateIDisableHLOD(builder, _o.Type, _o.IsDisable);
		}

		// Token: 0x0400C0EF RID: 49391
		private Table __p;
	}
}
