using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B7 RID: 29111
	public struct IStartSlidePerformType : IFlatbufferObject
	{
		// Token: 0x1700D835 RID: 55349
		// (get) Token: 0x060339F0 RID: 211440 RVA: 0x006F39E9 File Offset: 0x006F1BE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339F1 RID: 211441 RVA: 0x006F39F6 File Offset: 0x006F1BF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339F2 RID: 211442 RVA: 0x006F3A00 File Offset: 0x006F1C00
		public static IStartSlidePerformType GetRootAsIStartSlidePerformType(ByteBuffer _bb)
		{
			return IStartSlidePerformType.GetRootAsIStartSlidePerformType(_bb, default(IStartSlidePerformType));
		}

		// Token: 0x060339F3 RID: 211443 RVA: 0x006F3A1C File Offset: 0x006F1C1C
		public static IStartSlidePerformType GetRootAsIStartSlidePerformType(ByteBuffer _bb, IStartSlidePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339F4 RID: 211444 RVA: 0x006F3A39 File Offset: 0x006F1C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339F5 RID: 211445 RVA: 0x006F3A48 File Offset: 0x006F1C48
		public IStartSlidePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D836 RID: 55350
		// (get) Token: 0x060339F6 RID: 211446 RVA: 0x006F3A58 File Offset: 0x006F1C58
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060339F7 RID: 211447 RVA: 0x006F3A94 File Offset: 0x006F1C94
		public static Offset<IStartSlidePerformType> CreateIStartSlidePerformType(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide)
		{
			builder.StartTable(1);
			IStartSlidePerformType.AddType(builder, Type);
			return IStartSlidePerformType.EndIStartSlidePerformType(builder);
		}

		// Token: 0x060339F8 RID: 211448 RVA: 0x006F3AAA File Offset: 0x006F1CAA
		public static void StartIStartSlidePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060339F9 RID: 211449 RVA: 0x006F3AB3 File Offset: 0x006F1CB3
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060339FA RID: 211450 RVA: 0x006F3ABE File Offset: 0x006F1CBE
		public static Offset<IStartSlidePerformType> EndIStartSlidePerformType(FlatBufferBuilder builder)
		{
			return new Offset<IStartSlidePerformType>(builder.EndTable());
		}

		// Token: 0x060339FB RID: 211451 RVA: 0x006F3ACC File Offset: 0x006F1CCC
		public IStartSlidePerformTypeT UnPack()
		{
			IStartSlidePerformTypeT startSlidePerformTypeT = new IStartSlidePerformTypeT();
			this.UnPackTo(startSlidePerformTypeT);
			return startSlidePerformTypeT;
		}

		// Token: 0x060339FC RID: 211452 RVA: 0x006F3AE7 File Offset: 0x006F1CE7
		public void UnPackTo(IStartSlidePerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060339FD RID: 211453 RVA: 0x006F3AF8 File Offset: 0x006F1CF8
		public static Offset<IStartSlidePerformType> Pack(FlatBufferBuilder builder, IStartSlidePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartSlidePerformType>);
			}
			return IStartSlidePerformType.CreateIStartSlidePerformType(builder, _o.Type);
		}

		// Token: 0x04011C83 RID: 72835
		private Table __p;
	}
}
