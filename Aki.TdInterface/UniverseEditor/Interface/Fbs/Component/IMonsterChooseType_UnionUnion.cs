using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556D RID: 21869
	public class IMonsterChooseType_UnionUnion
	{
		// Token: 0x1700A18E RID: 41358
		// (get) Token: 0x060242D1 RID: 148177 RVA: 0x004FF13D File Offset: 0x004FD33D
		// (set) Token: 0x060242D2 RID: 148178 RVA: 0x004FF145 File Offset: 0x004FD345
		public IMonsterChooseType_Union Type { get; set; }

		// Token: 0x1700A18F RID: 41359
		// (get) Token: 0x060242D3 RID: 148179 RVA: 0x004FF14E File Offset: 0x004FD34E
		// (set) Token: 0x060242D4 RID: 148180 RVA: 0x004FF156 File Offset: 0x004FD356
		public object Value { get; set; }

		// Token: 0x060242D5 RID: 148181 RVA: 0x004FF15F File Offset: 0x004FD35F
		public IMonsterChooseType_UnionUnion()
		{
			this.Type = IMonsterChooseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x004FF175 File Offset: 0x004FD375
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x004FF187 File Offset: 0x004FD387
		public IMonsterChooseTypeT AsIMonsterChooseType()
		{
			return this.As<IMonsterChooseTypeT>();
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x004FF18F File Offset: 0x004FD38F
		public static IMonsterChooseType_UnionUnion FromIMonsterChooseType(IMonsterChooseTypeT _imonsterchoosetype)
		{
			return new IMonsterChooseType_UnionUnion
			{
				Type = IMonsterChooseType_Union.IMonsterChooseType,
				Value = _imonsterchoosetype
			};
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x004FF1A4 File Offset: 0x004FD3A4
		public IRandomPoolChooseT AsIRandomPoolChoose()
		{
			return this.As<IRandomPoolChooseT>();
		}

		// Token: 0x060242DA RID: 148186 RVA: 0x004FF1AC File Offset: 0x004FD3AC
		public static IMonsterChooseType_UnionUnion FromIRandomPoolChoose(IRandomPoolChooseT _irandompoolchoose)
		{
			return new IMonsterChooseType_UnionUnion
			{
				Type = IMonsterChooseType_Union.IRandomPoolChoose,
				Value = _irandompoolchoose
			};
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x004FF1C4 File Offset: 0x004FD3C4
		public static int Pack(FlatBufferBuilder builder, IMonsterChooseType_UnionUnion _o)
		{
			IMonsterChooseType_Union type = _o.Type;
			if (type == IMonsterChooseType_Union.IMonsterChooseType)
			{
				return IMonsterChooseType.Pack(builder, _o.AsIMonsterChooseType()).Value;
			}
			if (type != IMonsterChooseType_Union.IRandomPoolChoose)
			{
				return 0;
			}
			return IRandomPoolChoose.Pack(builder, _o.AsIRandomPoolChoose()).Value;
		}
	}
}
