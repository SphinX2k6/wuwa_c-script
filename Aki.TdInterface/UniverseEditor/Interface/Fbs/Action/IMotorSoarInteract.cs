using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B30 RID: 27440
	public struct IMotorSoarInteract : IFlatbufferObject
	{
		// Token: 0x1700CBE9 RID: 52201
		// (get) Token: 0x06030297 RID: 197271 RVA: 0x0068BCE8 File Offset: 0x00689EE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030298 RID: 197272 RVA: 0x0068BCF5 File Offset: 0x00689EF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030299 RID: 197273 RVA: 0x0068BCFC File Offset: 0x00689EFC
		public static IMotorSoarInteract GetRootAsIMotorSoarInteract(ByteBuffer _bb)
		{
			return IMotorSoarInteract.GetRootAsIMotorSoarInteract(_bb, default(IMotorSoarInteract));
		}

		// Token: 0x0603029A RID: 197274 RVA: 0x0068BD18 File Offset: 0x00689F18
		public static IMotorSoarInteract GetRootAsIMotorSoarInteract(ByteBuffer _bb, IMotorSoarInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603029B RID: 197275 RVA: 0x0068BD35 File Offset: 0x00689F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603029C RID: 197276 RVA: 0x0068BD44 File Offset: 0x00689F44
		public IMotorSoarInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBEA RID: 52202
		// (get) Token: 0x0603029D RID: 197277 RVA: 0x0068BD54 File Offset: 0x00689F54
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

		// Token: 0x0603029E RID: 197278 RVA: 0x0068BD90 File Offset: 0x00689F90
		public static Offset<IMotorSoarInteract> CreateIMotorSoarInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IMotorSoarInteract.AddType(builder, Type);
			return IMotorSoarInteract.EndIMotorSoarInteract(builder);
		}

		// Token: 0x0603029F RID: 197279 RVA: 0x0068BDA6 File Offset: 0x00689FA6
		public static void StartIMotorSoarInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060302A0 RID: 197280 RVA: 0x0068BDAF File Offset: 0x00689FAF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060302A1 RID: 197281 RVA: 0x0068BDBA File Offset: 0x00689FBA
		public static Offset<IMotorSoarInteract> EndIMotorSoarInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInteract>(builder.EndTable());
		}

		// Token: 0x060302A2 RID: 197282 RVA: 0x0068BDC8 File Offset: 0x00689FC8
		public IMotorSoarInteractT UnPack()
		{
			IMotorSoarInteractT motorSoarInteractT = new IMotorSoarInteractT();
			this.UnPackTo(motorSoarInteractT);
			return motorSoarInteractT;
		}

		// Token: 0x060302A3 RID: 197283 RVA: 0x0068BDE3 File Offset: 0x00689FE3
		public void UnPackTo(IMotorSoarInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060302A4 RID: 197284 RVA: 0x0068BDF4 File Offset: 0x00689FF4
		public static Offset<IMotorSoarInteract> Pack(FlatBufferBuilder builder, IMotorSoarInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInteract>);
			}
			return IMotorSoarInteract.CreateIMotorSoarInteract(builder, _o.Type);
		}

		// Token: 0x040113C9 RID: 70601
		private Table __p;
	}
}
