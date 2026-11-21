using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5C RID: 27740
	public struct IDisableRideFlyingCarUiGameplay : IFlatbufferObject
	{
		// Token: 0x1700CB71 RID: 52081
		// (get) Token: 0x0602FC64 RID: 195684 RVA: 0x00681C51 File Offset: 0x0067FE51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC65 RID: 195685 RVA: 0x00681C5E File Offset: 0x0067FE5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC66 RID: 195686 RVA: 0x00681C68 File Offset: 0x0067FE68
		public static IDisableRideFlyingCarUiGameplay GetRootAsIDisableRideFlyingCarUiGameplay(ByteBuffer _bb)
		{
			return IDisableRideFlyingCarUiGameplay.GetRootAsIDisableRideFlyingCarUiGameplay(_bb, default(IDisableRideFlyingCarUiGameplay));
		}

		// Token: 0x0602FC67 RID: 195687 RVA: 0x00681C84 File Offset: 0x0067FE84
		public static IDisableRideFlyingCarUiGameplay GetRootAsIDisableRideFlyingCarUiGameplay(ByteBuffer _bb, IDisableRideFlyingCarUiGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC68 RID: 195688 RVA: 0x00681CA1 File Offset: 0x0067FEA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC69 RID: 195689 RVA: 0x00681CB0 File Offset: 0x0067FEB0
		public IDisableRideFlyingCarUiGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB72 RID: 52082
		// (get) Token: 0x0602FC6A RID: 195690 RVA: 0x00681CC0 File Offset: 0x0067FEC0
		public EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return (EToggleRideFlyingCarUiGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC6B RID: 195691 RVA: 0x00681CFC File Offset: 0x0067FEFC
		public static Offset<IDisableRideFlyingCarUiGameplay> CreateIDisableRideFlyingCarUiGameplay(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType Type = EToggleRideFlyingCarUiGameplayType.Enable)
		{
			builder.StartTable(1);
			IDisableRideFlyingCarUiGameplay.AddType(builder, Type);
			return IDisableRideFlyingCarUiGameplay.EndIDisableRideFlyingCarUiGameplay(builder);
		}

		// Token: 0x0602FC6C RID: 195692 RVA: 0x00681D12 File Offset: 0x0067FF12
		public static void StartIDisableRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FC6D RID: 195693 RVA: 0x00681D1B File Offset: 0x0067FF1B
		public static void AddType(FlatBufferBuilder builder, EToggleRideFlyingCarUiGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC6E RID: 195694 RVA: 0x00681D26 File Offset: 0x0067FF26
		public static Offset<IDisableRideFlyingCarUiGameplay> EndIDisableRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IDisableRideFlyingCarUiGameplay>(builder.EndTable());
		}

		// Token: 0x0602FC6F RID: 195695 RVA: 0x00681D34 File Offset: 0x0067FF34
		public IDisableRideFlyingCarUiGameplayT UnPack()
		{
			IDisableRideFlyingCarUiGameplayT disableRideFlyingCarUiGameplayT = new IDisableRideFlyingCarUiGameplayT();
			this.UnPackTo(disableRideFlyingCarUiGameplayT);
			return disableRideFlyingCarUiGameplayT;
		}

		// Token: 0x0602FC70 RID: 195696 RVA: 0x00681D4F File Offset: 0x0067FF4F
		public void UnPackTo(IDisableRideFlyingCarUiGameplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FC71 RID: 195697 RVA: 0x00681D60 File Offset: 0x0067FF60
		public static Offset<IDisableRideFlyingCarUiGameplay> Pack(FlatBufferBuilder builder, IDisableRideFlyingCarUiGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableRideFlyingCarUiGameplay>);
			}
			return IDisableRideFlyingCarUiGameplay.CreateIDisableRideFlyingCarUiGameplay(builder, _o.Type);
		}

		// Token: 0x04011A84 RID: 72324
		private Table __p;
	}
}
