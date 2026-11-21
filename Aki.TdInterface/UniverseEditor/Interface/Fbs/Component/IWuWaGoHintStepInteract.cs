using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061CE RID: 25038
	public struct IWuWaGoHintStepInteract : IFlatbufferObject
	{
		// Token: 0x1700BAB0 RID: 47792
		// (get) Token: 0x0602A91B RID: 174363 RVA: 0x005CE0E8 File Offset: 0x005CC2E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A91C RID: 174364 RVA: 0x005CE0F5 File Offset: 0x005CC2F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A91D RID: 174365 RVA: 0x005CE0FC File Offset: 0x005CC2FC
		public static IWuWaGoHintStepInteract GetRootAsIWuWaGoHintStepInteract(ByteBuffer _bb)
		{
			return IWuWaGoHintStepInteract.GetRootAsIWuWaGoHintStepInteract(_bb, default(IWuWaGoHintStepInteract));
		}

		// Token: 0x0602A91E RID: 174366 RVA: 0x005CE118 File Offset: 0x005CC318
		public static IWuWaGoHintStepInteract GetRootAsIWuWaGoHintStepInteract(ByteBuffer _bb, IWuWaGoHintStepInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A91F RID: 174367 RVA: 0x005CE135 File Offset: 0x005CC335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A920 RID: 174368 RVA: 0x005CE144 File Offset: 0x005CC344
		public IWuWaGoHintStepInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAB1 RID: 47793
		// (get) Token: 0x0602A921 RID: 174369 RVA: 0x005CE154 File Offset: 0x005CC354
		public EWuWaGoHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoHintStepType.Move;
				}
				return (EWuWaGoHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A922 RID: 174370 RVA: 0x005CE190 File Offset: 0x005CC390
		public static Offset<IWuWaGoHintStepInteract> CreateIWuWaGoHintStepInteract(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move)
		{
			builder.StartTable(1);
			IWuWaGoHintStepInteract.AddType(builder, Type);
			return IWuWaGoHintStepInteract.EndIWuWaGoHintStepInteract(builder);
		}

		// Token: 0x0602A923 RID: 174371 RVA: 0x005CE1A6 File Offset: 0x005CC3A6
		public static void StartIWuWaGoHintStepInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A924 RID: 174372 RVA: 0x005CE1AF File Offset: 0x005CC3AF
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A925 RID: 174373 RVA: 0x005CE1BA File Offset: 0x005CC3BA
		public static Offset<IWuWaGoHintStepInteract> EndIWuWaGoHintStepInteract(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepInteract>(builder.EndTable());
		}

		// Token: 0x0602A926 RID: 174374 RVA: 0x005CE1C8 File Offset: 0x005CC3C8
		public IWuWaGoHintStepInteractT UnPack()
		{
			IWuWaGoHintStepInteractT wuWaGoHintStepInteractT = new IWuWaGoHintStepInteractT();
			this.UnPackTo(wuWaGoHintStepInteractT);
			return wuWaGoHintStepInteractT;
		}

		// Token: 0x0602A927 RID: 174375 RVA: 0x005CE1E3 File Offset: 0x005CC3E3
		public void UnPackTo(IWuWaGoHintStepInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A928 RID: 174376 RVA: 0x005CE1F4 File Offset: 0x005CC3F4
		public static Offset<IWuWaGoHintStepInteract> Pack(FlatBufferBuilder builder, IWuWaGoHintStepInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepInteract>);
			}
			return IWuWaGoHintStepInteract.CreateIWuWaGoHintStepInteract(builder, _o.Type);
		}

		// Token: 0x04010037 RID: 65591
		private Table __p;
	}
}
