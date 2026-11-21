using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C14 RID: 27668
	public struct IDestroyVisionDisplay : IFlatbufferObject
	{
		// Token: 0x1700CAD2 RID: 51922
		// (get) Token: 0x0602F9E5 RID: 195045 RVA: 0x0067D1D1 File Offset: 0x0067B3D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F9E6 RID: 195046 RVA: 0x0067D1DE File Offset: 0x0067B3DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F9E7 RID: 195047 RVA: 0x0067D1E8 File Offset: 0x0067B3E8
		public static IDestroyVisionDisplay GetRootAsIDestroyVisionDisplay(ByteBuffer _bb)
		{
			return IDestroyVisionDisplay.GetRootAsIDestroyVisionDisplay(_bb, default(IDestroyVisionDisplay));
		}

		// Token: 0x0602F9E8 RID: 195048 RVA: 0x0067D204 File Offset: 0x0067B404
		public static IDestroyVisionDisplay GetRootAsIDestroyVisionDisplay(ByteBuffer _bb, IDestroyVisionDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F9E9 RID: 195049 RVA: 0x0067D221 File Offset: 0x0067B421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F9EA RID: 195050 RVA: 0x0067D230 File Offset: 0x0067B430
		public IDestroyVisionDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAD3 RID: 51923
		// (get) Token: 0x0602F9EB RID: 195051 RVA: 0x0067D240 File Offset: 0x0067B440
		public EDynamicEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityType.VisionDisplay;
				}
				return (EDynamicEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F9EC RID: 195052 RVA: 0x0067D27C File Offset: 0x0067B47C
		public static Offset<IDestroyVisionDisplay> CreateIDestroyVisionDisplay(FlatBufferBuilder builder, EDynamicEntityType Type = EDynamicEntityType.VisionDisplay)
		{
			builder.StartTable(1);
			IDestroyVisionDisplay.AddType(builder, Type);
			return IDestroyVisionDisplay.EndIDestroyVisionDisplay(builder);
		}

		// Token: 0x0602F9ED RID: 195053 RVA: 0x0067D292 File Offset: 0x0067B492
		public static void StartIDestroyVisionDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F9EE RID: 195054 RVA: 0x0067D29B File Offset: 0x0067B49B
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F9EF RID: 195055 RVA: 0x0067D2A6 File Offset: 0x0067B4A6
		public static Offset<IDestroyVisionDisplay> EndIDestroyVisionDisplay(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyVisionDisplay>(builder.EndTable());
		}

		// Token: 0x0602F9F0 RID: 195056 RVA: 0x0067D2B4 File Offset: 0x0067B4B4
		public IDestroyVisionDisplayT UnPack()
		{
			IDestroyVisionDisplayT destroyVisionDisplayT = new IDestroyVisionDisplayT();
			this.UnPackTo(destroyVisionDisplayT);
			return destroyVisionDisplayT;
		}

		// Token: 0x0602F9F1 RID: 195057 RVA: 0x0067D2CF File Offset: 0x0067B4CF
		public void UnPackTo(IDestroyVisionDisplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F9F2 RID: 195058 RVA: 0x0067D2E0 File Offset: 0x0067B4E0
		public static Offset<IDestroyVisionDisplay> Pack(FlatBufferBuilder builder, IDestroyVisionDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyVisionDisplay>);
			}
			return IDestroyVisionDisplay.CreateIDestroyVisionDisplay(builder, _o.Type);
		}

		// Token: 0x04011A1A RID: 72218
		private Table __p;
	}
}
