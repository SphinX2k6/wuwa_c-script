using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DA RID: 25818
	public struct IControlTrackingSelf : IFlatbufferObject
	{
		// Token: 0x1700C01C RID: 49180
		// (get) Token: 0x0602CC94 RID: 183444 RVA: 0x0062791F File Offset: 0x00625B1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC95 RID: 183445 RVA: 0x0062792C File Offset: 0x00625B2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC96 RID: 183446 RVA: 0x00627934 File Offset: 0x00625B34
		public static IControlTrackingSelf GetRootAsIControlTrackingSelf(ByteBuffer _bb)
		{
			return IControlTrackingSelf.GetRootAsIControlTrackingSelf(_bb, default(IControlTrackingSelf));
		}

		// Token: 0x0602CC97 RID: 183447 RVA: 0x00627950 File Offset: 0x00625B50
		public static IControlTrackingSelf GetRootAsIControlTrackingSelf(ByteBuffer _bb, IControlTrackingSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC98 RID: 183448 RVA: 0x0062796D File Offset: 0x00625B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC99 RID: 183449 RVA: 0x0062797C File Offset: 0x00625B7C
		public IControlTrackingSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C01D RID: 49181
		// (get) Token: 0x0602CC9A RID: 183450 RVA: 0x0062798C File Offset: 0x00625B8C
		public EControlTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlTrackingType.Self;
				}
				return (EControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CC9B RID: 183451 RVA: 0x006279C8 File Offset: 0x00625BC8
		public static Offset<IControlTrackingSelf> CreateIControlTrackingSelf(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self)
		{
			builder.StartTable(1);
			IControlTrackingSelf.AddType(builder, Type);
			return IControlTrackingSelf.EndIControlTrackingSelf(builder);
		}

		// Token: 0x0602CC9C RID: 183452 RVA: 0x006279DE File Offset: 0x00625BDE
		public static void StartIControlTrackingSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CC9D RID: 183453 RVA: 0x006279E7 File Offset: 0x00625BE7
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC9E RID: 183454 RVA: 0x006279F2 File Offset: 0x00625BF2
		public static Offset<IControlTrackingSelf> EndIControlTrackingSelf(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingSelf>(builder.EndTable());
		}

		// Token: 0x0602CC9F RID: 183455 RVA: 0x00627A00 File Offset: 0x00625C00
		public IControlTrackingSelfT UnPack()
		{
			IControlTrackingSelfT controlTrackingSelfT = new IControlTrackingSelfT();
			this.UnPackTo(controlTrackingSelfT);
			return controlTrackingSelfT;
		}

		// Token: 0x0602CCA0 RID: 183456 RVA: 0x00627A1B File Offset: 0x00625C1B
		public void UnPackTo(IControlTrackingSelfT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CCA1 RID: 183457 RVA: 0x00627A2C File Offset: 0x00625C2C
		public static Offset<IControlTrackingSelf> Pack(FlatBufferBuilder builder, IControlTrackingSelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingSelf>);
			}
			return IControlTrackingSelf.CreateIControlTrackingSelf(builder, _o.Type);
		}

		// Token: 0x04010B15 RID: 68373
		private Table __p;
	}
}
