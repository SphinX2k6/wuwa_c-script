using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC7 RID: 16327
	public struct IShowTimelineInput : IFlatbufferObject
	{
		// Token: 0x17006E8C RID: 28300
		// (get) Token: 0x060164C5 RID: 91333 RVA: 0x00331EFE File Offset: 0x003300FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164C6 RID: 91334 RVA: 0x00331F0B File Offset: 0x0033010B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164C7 RID: 91335 RVA: 0x00331F14 File Offset: 0x00330114
		public static IShowTimelineInput GetRootAsIShowTimelineInput(ByteBuffer _bb)
		{
			return IShowTimelineInput.GetRootAsIShowTimelineInput(_bb, default(IShowTimelineInput));
		}

		// Token: 0x060164C8 RID: 91336 RVA: 0x00331F30 File Offset: 0x00330130
		public static IShowTimelineInput GetRootAsIShowTimelineInput(ByteBuffer _bb, IShowTimelineInput obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164C9 RID: 91337 RVA: 0x00331F4D File Offset: 0x0033014D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164CA RID: 91338 RVA: 0x00331F5C File Offset: 0x0033015C
		public IShowTimelineInput __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E8D RID: 28301
		// (get) Token: 0x060164CB RID: 91339 RVA: 0x00331F6C File Offset: 0x0033016C
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

		// Token: 0x17006E8E RID: 28302
		// (get) Token: 0x060164CC RID: 91340 RVA: 0x00331FA8 File Offset: 0x003301A8
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

		// Token: 0x17006E8F RID: 28303
		// (get) Token: 0x060164CD RID: 91341 RVA: 0x00331FE4 File Offset: 0x003301E4
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

		// Token: 0x060164CE RID: 91342 RVA: 0x00332020 File Offset: 0x00330220
		public static Offset<IShowTimelineInput> CreateIShowTimelineInput(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, int InputAction = 0, EShowTimelineInputType InputType = EShowTimelineInputType.Press)
		{
			builder.StartTable(3);
			IShowTimelineInput.AddInputAction(builder, InputAction);
			IShowTimelineInput.AddInputType(builder, InputType);
			IShowTimelineInput.AddType(builder, Type);
			return IShowTimelineInput.EndIShowTimelineInput(builder);
		}

		// Token: 0x060164CF RID: 91343 RVA: 0x00332044 File Offset: 0x00330244
		public static void StartIShowTimelineInput(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060164D0 RID: 91344 RVA: 0x0033204D File Offset: 0x0033024D
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060164D1 RID: 91345 RVA: 0x00332058 File Offset: 0x00330258
		public static void AddInputAction(FlatBufferBuilder builder, int inputAction)
		{
			builder.AddInt(1, inputAction, 0);
		}

		// Token: 0x060164D2 RID: 91346 RVA: 0x00332063 File Offset: 0x00330263
		public static void AddInputType(FlatBufferBuilder builder, EShowTimelineInputType inputType)
		{
			builder.AddByte(2, (byte)inputType, 0);
		}

		// Token: 0x060164D3 RID: 91347 RVA: 0x0033206E File Offset: 0x0033026E
		public static Offset<IShowTimelineInput> EndIShowTimelineInput(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineInput>(builder.EndTable());
		}

		// Token: 0x060164D4 RID: 91348 RVA: 0x0033207C File Offset: 0x0033027C
		public IShowTimelineInputT UnPack()
		{
			IShowTimelineInputT showTimelineInputT = new IShowTimelineInputT();
			this.UnPackTo(showTimelineInputT);
			return showTimelineInputT;
		}

		// Token: 0x060164D5 RID: 91349 RVA: 0x00332097 File Offset: 0x00330297
		public void UnPackTo(IShowTimelineInputT _o)
		{
			_o.Type = this.Type;
			_o.InputAction = this.InputAction;
			_o.InputType = this.InputType;
		}

		// Token: 0x060164D6 RID: 91350 RVA: 0x003320C0 File Offset: 0x003302C0
		public static Offset<IShowTimelineInput> Pack(FlatBufferBuilder builder, IShowTimelineInputT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineInput>);
			}
			return IShowTimelineInput.CreateIShowTimelineInput(builder, _o.Type, _o.InputAction, _o.InputType);
		}

		// Token: 0x0400BAC6 RID: 47814
		private Table __p;
	}
}
