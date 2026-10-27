using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546A RID: 21610
	public struct IInteractScreenDetectShapeBase : IFlatbufferObject
	{
		// Token: 0x17009F17 RID: 40727
		// (get) Token: 0x060238CB RID: 145611 RVA: 0x004EAC4C File Offset: 0x004E8E4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238CC RID: 145612 RVA: 0x004EAC59 File Offset: 0x004E8E59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238CD RID: 145613 RVA: 0x004EAC60 File Offset: 0x004E8E60
		public static IInteractScreenDetectShapeBase GetRootAsIInteractScreenDetectShapeBase(ByteBuffer _bb)
		{
			return IInteractScreenDetectShapeBase.GetRootAsIInteractScreenDetectShapeBase(_bb, default(IInteractScreenDetectShapeBase));
		}

		// Token: 0x060238CE RID: 145614 RVA: 0x004EAC7C File Offset: 0x004E8E7C
		public static IInteractScreenDetectShapeBase GetRootAsIInteractScreenDetectShapeBase(ByteBuffer _bb, IInteractScreenDetectShapeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238CF RID: 145615 RVA: 0x004EAC99 File Offset: 0x004E8E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238D0 RID: 145616 RVA: 0x004EACA8 File Offset: 0x004E8EA8
		public IInteractScreenDetectShapeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F18 RID: 40728
		// (get) Token: 0x060238D1 RID: 145617 RVA: 0x004EACB8 File Offset: 0x004E8EB8
		public EInteractScreenDetectShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return (EInteractScreenDetectShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060238D2 RID: 145618 RVA: 0x004EACF4 File Offset: 0x004E8EF4
		public static Offset<IInteractScreenDetectShapeBase> CreateIInteractScreenDetectShapeBase(FlatBufferBuilder builder, EInteractScreenDetectShape Type = EInteractScreenDetectShape.Circle)
		{
			builder.StartTable(1);
			IInteractScreenDetectShapeBase.AddType(builder, Type);
			return IInteractScreenDetectShapeBase.EndIInteractScreenDetectShapeBase(builder);
		}

		// Token: 0x060238D3 RID: 145619 RVA: 0x004EAD0A File Offset: 0x004E8F0A
		public static void StartIInteractScreenDetectShapeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060238D4 RID: 145620 RVA: 0x004EAD13 File Offset: 0x004E8F13
		public static void AddType(FlatBufferBuilder builder, EInteractScreenDetectShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060238D5 RID: 145621 RVA: 0x004EAD1E File Offset: 0x004E8F1E
		public static Offset<IInteractScreenDetectShapeBase> EndIInteractScreenDetectShapeBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractScreenDetectShapeBase>(builder.EndTable());
		}

		// Token: 0x060238D6 RID: 145622 RVA: 0x004EAD2C File Offset: 0x004E8F2C
		public IInteractScreenDetectShapeBaseT UnPack()
		{
			IInteractScreenDetectShapeBaseT interactScreenDetectShapeBaseT = new IInteractScreenDetectShapeBaseT();
			this.UnPackTo(interactScreenDetectShapeBaseT);
			return interactScreenDetectShapeBaseT;
		}

		// Token: 0x060238D7 RID: 145623 RVA: 0x004EAD47 File Offset: 0x004E8F47
		public void UnPackTo(IInteractScreenDetectShapeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060238D8 RID: 145624 RVA: 0x004EAD58 File Offset: 0x004E8F58
		public static Offset<IInteractScreenDetectShapeBase> Pack(FlatBufferBuilder builder, IInteractScreenDetectShapeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractScreenDetectShapeBase>);
			}
			return IInteractScreenDetectShapeBase.CreateIInteractScreenDetectShapeBase(builder, _o.Type);
		}

		// Token: 0x0400E6E6 RID: 59110
		private Table __p;
	}
}
