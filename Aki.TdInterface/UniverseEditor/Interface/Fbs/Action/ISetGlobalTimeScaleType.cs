using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF8 RID: 28664
	public struct ISetGlobalTimeScaleType : IFlatbufferObject
	{
		// Token: 0x1700D4EF RID: 54511
		// (get) Token: 0x06032B3E RID: 207678 RVA: 0x006D76E8 File Offset: 0x006D58E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B3F RID: 207679 RVA: 0x006D76F5 File Offset: 0x006D58F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B40 RID: 207680 RVA: 0x006D76FC File Offset: 0x006D58FC
		public static ISetGlobalTimeScaleType GetRootAsISetGlobalTimeScaleType(ByteBuffer _bb)
		{
			return ISetGlobalTimeScaleType.GetRootAsISetGlobalTimeScaleType(_bb, default(ISetGlobalTimeScaleType));
		}

		// Token: 0x06032B41 RID: 207681 RVA: 0x006D7718 File Offset: 0x006D5918
		public static ISetGlobalTimeScaleType GetRootAsISetGlobalTimeScaleType(ByteBuffer _bb, ISetGlobalTimeScaleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B42 RID: 207682 RVA: 0x006D7735 File Offset: 0x006D5935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B43 RID: 207683 RVA: 0x006D7744 File Offset: 0x006D5944
		public ISetGlobalTimeScaleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4F0 RID: 54512
		// (get) Token: 0x06032B44 RID: 207684 RVA: 0x006D7754 File Offset: 0x006D5954
		public ESetTimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTimeScaleType.Open;
				}
				return (ESetTimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B45 RID: 207685 RVA: 0x006D7790 File Offset: 0x006D5990
		public static Offset<ISetGlobalTimeScaleType> CreateISetGlobalTimeScaleType(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open)
		{
			builder.StartTable(1);
			ISetGlobalTimeScaleType.AddType(builder, Type);
			return ISetGlobalTimeScaleType.EndISetGlobalTimeScaleType(builder);
		}

		// Token: 0x06032B46 RID: 207686 RVA: 0x006D77A6 File Offset: 0x006D59A6
		public static void StartISetGlobalTimeScaleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032B47 RID: 207687 RVA: 0x006D77AF File Offset: 0x006D59AF
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B48 RID: 207688 RVA: 0x006D77BA File Offset: 0x006D59BA
		public static Offset<ISetGlobalTimeScaleType> EndISetGlobalTimeScaleType(FlatBufferBuilder builder)
		{
			return new Offset<ISetGlobalTimeScaleType>(builder.EndTable());
		}

		// Token: 0x06032B49 RID: 207689 RVA: 0x006D77C8 File Offset: 0x006D59C8
		public ISetGlobalTimeScaleTypeT UnPack()
		{
			ISetGlobalTimeScaleTypeT setGlobalTimeScaleTypeT = new ISetGlobalTimeScaleTypeT();
			this.UnPackTo(setGlobalTimeScaleTypeT);
			return setGlobalTimeScaleTypeT;
		}

		// Token: 0x06032B4A RID: 207690 RVA: 0x006D77E3 File Offset: 0x006D59E3
		public void UnPackTo(ISetGlobalTimeScaleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032B4B RID: 207691 RVA: 0x006D77F4 File Offset: 0x006D59F4
		public static Offset<ISetGlobalTimeScaleType> Pack(FlatBufferBuilder builder, ISetGlobalTimeScaleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetGlobalTimeScaleType>);
			}
			return ISetGlobalTimeScaleType.CreateISetGlobalTimeScaleType(builder, _o.Type);
		}

		// Token: 0x04011A19 RID: 72217
		private Table __p;
	}
}
