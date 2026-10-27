using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BBF RID: 15295
	public struct IShowTimelineInput : IFlatbufferObject
	{
		// Token: 0x170068E9 RID: 26857
		// (get) Token: 0x06014FED RID: 85997 RVA: 0x0030B6A2 File Offset: 0x003098A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014FEE RID: 85998 RVA: 0x0030B6AF File Offset: 0x003098AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014FEF RID: 85999 RVA: 0x0030B6B8 File Offset: 0x003098B8
		public static IShowTimelineInput GetRootAsIShowTimelineInput(ByteBuffer _bb)
		{
			return IShowTimelineInput.GetRootAsIShowTimelineInput(_bb, default(IShowTimelineInput));
		}

		// Token: 0x06014FF0 RID: 86000 RVA: 0x0030B6D4 File Offset: 0x003098D4
		public static IShowTimelineInput GetRootAsIShowTimelineInput(ByteBuffer _bb, IShowTimelineInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014FF1 RID: 86001 RVA: 0x0030B6F1 File Offset: 0x003098F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014FF2 RID: 86002 RVA: 0x0030B700 File Offset: 0x00309900
		public IShowTimelineInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068EA RID: 26858
		// (get) Token: 0x06014FF3 RID: 86003 RVA: 0x0030B710 File Offset: 0x00309910
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170068EB RID: 26859
		// (get) Token: 0x06014FF4 RID: 86004 RVA: 0x0030B74C File Offset: 0x0030994C
		public int InputAction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170068EC RID: 26860
		// (get) Token: 0x06014FF5 RID: 86005 RVA: 0x0030B788 File Offset: 0x00309988
		public EShowTimelineInputType InputType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EShowTimelineInputType.Press;
				}
				return (EShowTimelineInputType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014FF6 RID: 86006 RVA: 0x0030B7C4 File Offset: 0x003099C4
		public static Offset<IShowTimelineInput> CreateIShowTimelineInput(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, int InputAction = 0, EShowTimelineInputType InputType = EShowTimelineInputType.Press)
		{
			builder.StartTable(3);
			IShowTimelineInput.AddInputAction(builder, InputAction);
			IShowTimelineInput.AddInputType(builder, InputType);
			IShowTimelineInput.AddType(builder, Type);
			return IShowTimelineInput.EndIShowTimelineInput(builder);
		}

		// Token: 0x06014FF7 RID: 86007 RVA: 0x0030B7E8 File Offset: 0x003099E8
		public static void StartIShowTimelineInput(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014FF8 RID: 86008 RVA: 0x0030B7F1 File Offset: 0x003099F1
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014FF9 RID: 86009 RVA: 0x0030B7FC File Offset: 0x003099FC
		public static void AddInputAction(FlatBufferBuilder builder, int inputAction)
		{
			builder.AddInt(1, inputAction, 0);
		}

		// Token: 0x06014FFA RID: 86010 RVA: 0x0030B807 File Offset: 0x00309A07
		public static void AddInputType(FlatBufferBuilder builder, EShowTimelineInputType inputType)
		{
			builder.AddByte(2, (byte)inputType, 0);
		}

		// Token: 0x06014FFB RID: 86011 RVA: 0x0030B812 File Offset: 0x00309A12
		public static Offset<IShowTimelineInput> EndIShowTimelineInput(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineInput>(builder.EndTable());
		}

		// Token: 0x06014FFC RID: 86012 RVA: 0x0030B820 File Offset: 0x00309A20
		public IShowTimelineInputT UnPack()
		{
			IShowTimelineInputT showTimelineInputT = new IShowTimelineInputT();
			this.UnPackTo(showTimelineInputT);
			return showTimelineInputT;
		}

		// Token: 0x06014FFD RID: 86013 RVA: 0x0030B83B File Offset: 0x00309A3B
		public void UnPackTo(IShowTimelineInputT _o)
		{
			_o.Type = this.Type;
			_o.InputAction = this.InputAction;
			_o.InputType = this.InputType;
		}

		// Token: 0x06014FFE RID: 86014 RVA: 0x0030B864 File Offset: 0x00309A64
		public static Offset<IShowTimelineInput> Pack(FlatBufferBuilder builder, IShowTimelineInputT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineInput>);
			}
			return IShowTimelineInput.CreateIShowTimelineInput(builder, _o.Type, _o.InputAction, _o.InputType);
		}

		// Token: 0x0400B147 RID: 45383
		private Table __p;
	}
}
