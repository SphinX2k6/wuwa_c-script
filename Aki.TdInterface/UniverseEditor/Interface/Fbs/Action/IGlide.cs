using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F35 RID: 28469
	public struct IGlide : IFlatbufferObject
	{
		// Token: 0x1700D0AA RID: 53418
		// (get) Token: 0x06031446 RID: 201798 RVA: 0x006ACBEA File Offset: 0x006AADEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031447 RID: 201799 RVA: 0x006ACBF7 File Offset: 0x006AADF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031448 RID: 201800 RVA: 0x006ACC00 File Offset: 0x006AAE00
		public static IGlide GetRootAsIGlide(ByteBuffer _bb)
		{
			return IGlide.GetRootAsIGlide(_bb, default(IGlide));
		}

		// Token: 0x06031449 RID: 201801 RVA: 0x006ACC1C File Offset: 0x006AAE1C
		public static IGlide GetRootAsIGlide(ByteBuffer _bb, IGlide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603144A RID: 201802 RVA: 0x006ACC39 File Offset: 0x006AAE39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603144B RID: 201803 RVA: 0x006ACC48 File Offset: 0x006AAE48
		public IGlide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0AB RID: 53419
		// (get) Token: 0x0603144C RID: 201804 RVA: 0x006ACC58 File Offset: 0x006AAE58
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603144D RID: 201805 RVA: 0x006ACC94 File Offset: 0x006AAE94
		public static Offset<IGlide> CreateIGlide(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGlide.AddType(builder, Type);
			return IGlide.EndIGlide(builder);
		}

		// Token: 0x0603144E RID: 201806 RVA: 0x006ACCAA File Offset: 0x006AAEAA
		public static void StartIGlide(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603144F RID: 201807 RVA: 0x006ACCB3 File Offset: 0x006AAEB3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031450 RID: 201808 RVA: 0x006ACCBE File Offset: 0x006AAEBE
		public static Offset<IGlide> EndIGlide(FlatBufferBuilder builder)
		{
			return new Offset<IGlide>(builder.EndTable());
		}

		// Token: 0x06031451 RID: 201809 RVA: 0x006ACCCC File Offset: 0x006AAECC
		public IGlideT UnPack()
		{
			IGlideT glideT = new IGlideT();
			this.UnPackTo(glideT);
			return glideT;
		}

		// Token: 0x06031452 RID: 201810 RVA: 0x006ACCE7 File Offset: 0x006AAEE7
		public void UnPackTo(IGlideT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031453 RID: 201811 RVA: 0x006ACCF8 File Offset: 0x006AAEF8
		public static Offset<IGlide> Pack(FlatBufferBuilder builder, IGlideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlide>);
			}
			return IGlide.CreateIGlide(builder, _o.Type);
		}

		// Token: 0x04011E39 RID: 73273
		private Table __p;
	}
}
