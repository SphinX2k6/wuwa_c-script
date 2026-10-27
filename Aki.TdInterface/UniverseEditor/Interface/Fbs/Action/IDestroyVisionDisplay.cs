using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AC RID: 26028
	public struct IDestroyVisionDisplay : IFlatbufferObject
	{
		// Token: 0x1700C143 RID: 49475
		// (get) Token: 0x0602D261 RID: 184929 RVA: 0x0063100D File Offset: 0x0062F20D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D262 RID: 184930 RVA: 0x0063101A File Offset: 0x0062F21A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D263 RID: 184931 RVA: 0x00631024 File Offset: 0x0062F224
		public static IDestroyVisionDisplay GetRootAsIDestroyVisionDisplay(ByteBuffer _bb)
		{
			return IDestroyVisionDisplay.GetRootAsIDestroyVisionDisplay(_bb, default(IDestroyVisionDisplay));
		}

		// Token: 0x0602D264 RID: 184932 RVA: 0x00631040 File Offset: 0x0062F240
		public static IDestroyVisionDisplay GetRootAsIDestroyVisionDisplay(ByteBuffer _bb, IDestroyVisionDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D265 RID: 184933 RVA: 0x0063105D File Offset: 0x0062F25D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D266 RID: 184934 RVA: 0x0063106C File Offset: 0x0062F26C
		public IDestroyVisionDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C144 RID: 49476
		// (get) Token: 0x0602D267 RID: 184935 RVA: 0x0063107C File Offset: 0x0062F27C
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

		// Token: 0x0602D268 RID: 184936 RVA: 0x006310B8 File Offset: 0x0062F2B8
		public static Offset<IDestroyVisionDisplay> CreateIDestroyVisionDisplay(FlatBufferBuilder builder, EDynamicEntityType Type = EDynamicEntityType.VisionDisplay)
		{
			builder.StartTable(1);
			IDestroyVisionDisplay.AddType(builder, Type);
			return IDestroyVisionDisplay.EndIDestroyVisionDisplay(builder);
		}

		// Token: 0x0602D269 RID: 184937 RVA: 0x006310CE File Offset: 0x0062F2CE
		public static void StartIDestroyVisionDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D26A RID: 184938 RVA: 0x006310D7 File Offset: 0x0062F2D7
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D26B RID: 184939 RVA: 0x006310E2 File Offset: 0x0062F2E2
		public static Offset<IDestroyVisionDisplay> EndIDestroyVisionDisplay(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyVisionDisplay>(builder.EndTable());
		}

		// Token: 0x0602D26C RID: 184940 RVA: 0x006310F0 File Offset: 0x0062F2F0
		public IDestroyVisionDisplayT UnPack()
		{
			IDestroyVisionDisplayT destroyVisionDisplayT = new IDestroyVisionDisplayT();
			this.UnPackTo(destroyVisionDisplayT);
			return destroyVisionDisplayT;
		}

		// Token: 0x0602D26D RID: 184941 RVA: 0x0063110B File Offset: 0x0062F30B
		public void UnPackTo(IDestroyVisionDisplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D26E RID: 184942 RVA: 0x0063111C File Offset: 0x0062F31C
		public static Offset<IDestroyVisionDisplay> Pack(FlatBufferBuilder builder, IDestroyVisionDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyVisionDisplay>);
			}
			return IDestroyVisionDisplay.CreateIDestroyVisionDisplay(builder, _o.Type);
		}

		// Token: 0x04010C08 RID: 68616
		private Table __p;
	}
}
