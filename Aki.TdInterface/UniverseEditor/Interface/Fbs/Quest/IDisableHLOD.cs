using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD3 RID: 15827
	public struct IDisableHLOD : IFlatbufferObject
	{
		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x06016197 RID: 90519 RVA: 0x00331D4B File Offset: 0x0032FF4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016198 RID: 90520 RVA: 0x00331D58 File Offset: 0x0032FF58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016199 RID: 90521 RVA: 0x00331D60 File Offset: 0x0032FF60
		public static IDisableHLOD GetRootAsIDisableHLOD(ByteBuffer _bb)
		{
			return IDisableHLOD.GetRootAsIDisableHLOD(_bb, default(IDisableHLOD));
		}

		// Token: 0x0601619A RID: 90522 RVA: 0x00331D7C File Offset: 0x0032FF7C
		public static IDisableHLOD GetRootAsIDisableHLOD(ByteBuffer _bb, IDisableHLOD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x00331D99 File Offset: 0x0032FF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601619C RID: 90524 RVA: 0x00331DA8 File Offset: 0x0032FFA8
		public IDisableHLOD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x0601619D RID: 90525 RVA: 0x00331DB8 File Offset: 0x0032FFB8
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

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x0601619E RID: 90526 RVA: 0x00331DF4 File Offset: 0x0032FFF4
		public bool IsDisable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601619F RID: 90527 RVA: 0x00331E33 File Offset: 0x00330033
		public static Offset<IDisableHLOD> CreateIDisableHLOD(FlatBufferBuilder builder, EOperation Type = EOperation.DisableHLOD, bool IsDisable = false)
		{
			builder.StartTable(2);
			IDisableHLOD.AddIsDisable(builder, IsDisable);
			IDisableHLOD.AddType(builder, Type);
			return IDisableHLOD.EndIDisableHLOD(builder);
		}

		// Token: 0x060161A0 RID: 90528 RVA: 0x00331E50 File Offset: 0x00330050
		public static void StartIDisableHLOD(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060161A1 RID: 90529 RVA: 0x00331E59 File Offset: 0x00330059
		public static void AddType(FlatBufferBuilder builder, EOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060161A2 RID: 90530 RVA: 0x00331E64 File Offset: 0x00330064
		public static void AddIsDisable(FlatBufferBuilder builder, bool isDisable)
		{
			builder.AddBool(1, isDisable, false);
		}

		// Token: 0x060161A3 RID: 90531 RVA: 0x00331E6F File Offset: 0x0033006F
		public static Offset<IDisableHLOD> EndIDisableHLOD(FlatBufferBuilder builder)
		{
			return new Offset<IDisableHLOD>(builder.EndTable());
		}

		// Token: 0x060161A4 RID: 90532 RVA: 0x00331E7C File Offset: 0x0033007C
		public IDisableHLODT UnPack()
		{
			IDisableHLODT disableHLODT = new IDisableHLODT();
			this.UnPackTo(disableHLODT);
			return disableHLODT;
		}

		// Token: 0x060161A5 RID: 90533 RVA: 0x00331E97 File Offset: 0x00330097
		public void UnPackTo(IDisableHLODT _o)
		{
			_o.Type = this.Type;
			_o.IsDisable = this.IsDisable;
		}

		// Token: 0x060161A6 RID: 90534 RVA: 0x00331EB4 File Offset: 0x003300B4
		public static Offset<IDisableHLOD> Pack(FlatBufferBuilder builder, IDisableHLODT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableHLOD>);
			}
			return IDisableHLOD.CreateIDisableHLOD(builder, _o.Type, _o.IsDisable);
		}

		// Token: 0x0400B71B RID: 46875
		private Table __p;
	}
}
