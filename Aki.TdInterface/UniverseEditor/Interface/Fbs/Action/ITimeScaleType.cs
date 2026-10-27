using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E5 RID: 29669
	public struct ITimeScaleType : IFlatbufferObject
	{
		// Token: 0x1700E15E RID: 57694
		// (get) Token: 0x06035E57 RID: 220759 RVA: 0x00755D28 File Offset: 0x00753F28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E58 RID: 220760 RVA: 0x00755D35 File Offset: 0x00753F35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E59 RID: 220761 RVA: 0x00755D3C File Offset: 0x00753F3C
		public static ITimeScaleType GetRootAsITimeScaleType(ByteBuffer _bb)
		{
			return ITimeScaleType.GetRootAsITimeScaleType(_bb, default(ITimeScaleType));
		}

		// Token: 0x06035E5A RID: 220762 RVA: 0x00755D58 File Offset: 0x00753F58
		public static ITimeScaleType GetRootAsITimeScaleType(ByteBuffer _bb, ITimeScaleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E5B RID: 220763 RVA: 0x00755D75 File Offset: 0x00753F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E5C RID: 220764 RVA: 0x00755D84 File Offset: 0x00753F84
		public ITimeScaleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E15F RID: 57695
		// (get) Token: 0x06035E5D RID: 220765 RVA: 0x00755D94 File Offset: 0x00753F94
		public ETimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScaleType.Global;
				}
				return (ETimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035E5E RID: 220766 RVA: 0x00755DD0 File Offset: 0x00753FD0
		public static Offset<ITimeScaleType> CreateITimeScaleType(FlatBufferBuilder builder, ETimeScaleType Type = ETimeScaleType.Global)
		{
			builder.StartTable(1);
			ITimeScaleType.AddType(builder, Type);
			return ITimeScaleType.EndITimeScaleType(builder);
		}

		// Token: 0x06035E5F RID: 220767 RVA: 0x00755DE6 File Offset: 0x00753FE6
		public static void StartITimeScaleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E60 RID: 220768 RVA: 0x00755DEF File Offset: 0x00753FEF
		public static void AddType(FlatBufferBuilder builder, ETimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E61 RID: 220769 RVA: 0x00755DFA File Offset: 0x00753FFA
		public static Offset<ITimeScaleType> EndITimeScaleType(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScaleType>(builder.EndTable());
		}

		// Token: 0x06035E62 RID: 220770 RVA: 0x00755E08 File Offset: 0x00754008
		public ITimeScaleTypeT UnPack()
		{
			ITimeScaleTypeT timeScaleTypeT = new ITimeScaleTypeT();
			this.UnPackTo(timeScaleTypeT);
			return timeScaleTypeT;
		}

		// Token: 0x06035E63 RID: 220771 RVA: 0x00755E23 File Offset: 0x00754023
		public void UnPackTo(ITimeScaleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035E64 RID: 220772 RVA: 0x00755E34 File Offset: 0x00754034
		public static Offset<ITimeScaleType> Pack(FlatBufferBuilder builder, ITimeScaleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScaleType>);
			}
			return ITimeScaleType.CreateITimeScaleType(builder, _o.Type);
		}

		// Token: 0x0401223D RID: 74301
		private Table __p;
	}
}
