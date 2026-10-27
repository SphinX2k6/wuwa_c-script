using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006921 RID: 26913
	public struct IHonamiStoryEvacuateConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700C7AD RID: 51117
		// (get) Token: 0x0602EFB3 RID: 192435 RVA: 0x00667F26 File Offset: 0x00666126
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFB4 RID: 192436 RVA: 0x00667F33 File Offset: 0x00666133
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFB5 RID: 192437 RVA: 0x00667F3C File Offset: 0x0066613C
		public static IHonamiStoryEvacuateConfirmBox GetRootAsIHonamiStoryEvacuateConfirmBox(ByteBuffer _bb)
		{
			return IHonamiStoryEvacuateConfirmBox.GetRootAsIHonamiStoryEvacuateConfirmBox(_bb, default(IHonamiStoryEvacuateConfirmBox));
		}

		// Token: 0x0602EFB6 RID: 192438 RVA: 0x00667F58 File Offset: 0x00666158
		public static IHonamiStoryEvacuateConfirmBox GetRootAsIHonamiStoryEvacuateConfirmBox(ByteBuffer _bb, IHonamiStoryEvacuateConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFB7 RID: 192439 RVA: 0x00667F75 File Offset: 0x00666175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFB8 RID: 192440 RVA: 0x00667F84 File Offset: 0x00666184
		public IHonamiStoryEvacuateConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7AE RID: 51118
		// (get) Token: 0x0602EFB9 RID: 192441 RVA: 0x00667F94 File Offset: 0x00666194
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EFBA RID: 192442 RVA: 0x00667FD0 File Offset: 0x006661D0
		public static Offset<IHonamiStoryEvacuateConfirmBox> CreateIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common)
		{
			builder.StartTable(1);
			IHonamiStoryEvacuateConfirmBox.AddType(builder, Type);
			return IHonamiStoryEvacuateConfirmBox.EndIHonamiStoryEvacuateConfirmBox(builder);
		}

		// Token: 0x0602EFBB RID: 192443 RVA: 0x00667FE6 File Offset: 0x006661E6
		public static void StartIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EFBC RID: 192444 RVA: 0x00667FEF File Offset: 0x006661EF
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EFBD RID: 192445 RVA: 0x00667FFA File Offset: 0x006661FA
		public static Offset<IHonamiStoryEvacuateConfirmBox> EndIHonamiStoryEvacuateConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryEvacuateConfirmBox>(builder.EndTable());
		}

		// Token: 0x0602EFBE RID: 192446 RVA: 0x00668008 File Offset: 0x00666208
		public IHonamiStoryEvacuateConfirmBoxT UnPack()
		{
			IHonamiStoryEvacuateConfirmBoxT honamiStoryEvacuateConfirmBoxT = new IHonamiStoryEvacuateConfirmBoxT();
			this.UnPackTo(honamiStoryEvacuateConfirmBoxT);
			return honamiStoryEvacuateConfirmBoxT;
		}

		// Token: 0x0602EFBF RID: 192447 RVA: 0x00668023 File Offset: 0x00666223
		public void UnPackTo(IHonamiStoryEvacuateConfirmBoxT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EFC0 RID: 192448 RVA: 0x00668034 File Offset: 0x00666234
		public static Offset<IHonamiStoryEvacuateConfirmBox> Pack(FlatBufferBuilder builder, IHonamiStoryEvacuateConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryEvacuateConfirmBox>);
			}
			return IHonamiStoryEvacuateConfirmBox.CreateIHonamiStoryEvacuateConfirmBox(builder, _o.Type);
		}

		// Token: 0x0401109C RID: 69788
		private Table __p;
	}
}
