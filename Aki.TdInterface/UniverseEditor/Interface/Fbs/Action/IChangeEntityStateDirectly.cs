using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F0 RID: 25328
	public struct IChangeEntityStateDirectly : IFlatbufferObject
	{
		// Token: 0x1700BD06 RID: 48390
		// (get) Token: 0x0602BC83 RID: 179331 RVA: 0x00605BDA File Offset: 0x00603DDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC84 RID: 179332 RVA: 0x00605BE7 File Offset: 0x00603DE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC85 RID: 179333 RVA: 0x00605BF0 File Offset: 0x00603DF0
		public static IChangeEntityStateDirectly GetRootAsIChangeEntityStateDirectly(ByteBuffer _bb)
		{
			return IChangeEntityStateDirectly.GetRootAsIChangeEntityStateDirectly(_bb, default(IChangeEntityStateDirectly));
		}

		// Token: 0x0602BC86 RID: 179334 RVA: 0x00605C0C File Offset: 0x00603E0C
		public static IChangeEntityStateDirectly GetRootAsIChangeEntityStateDirectly(ByteBuffer _bb, IChangeEntityStateDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC87 RID: 179335 RVA: 0x00605C29 File Offset: 0x00603E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC88 RID: 179336 RVA: 0x00605C38 File Offset: 0x00603E38
		public IChangeEntityStateDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD07 RID: 48391
		// (get) Token: 0x0602BC89 RID: 179337 RVA: 0x00605C48 File Offset: 0x00603E48
		public EChangeEntityState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityState.Directly;
				}
				return (EChangeEntityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD08 RID: 48392
		// (get) Token: 0x0602BC8A RID: 179338 RVA: 0x00605C84 File Offset: 0x00603E84
		public int EntityId
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

		// Token: 0x1700BD09 RID: 48393
		// (get) Token: 0x0602BC8B RID: 179339 RVA: 0x00605CC0 File Offset: 0x00603EC0
		public string State
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BC8C RID: 179340 RVA: 0x00605CF7 File Offset: 0x00603EF7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602BC8D RID: 179341 RVA: 0x00605D06 File Offset: 0x00603F06
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BD0A RID: 48394
		// (get) Token: 0x0602BC8E RID: 179342 RVA: 0x00605D14 File Offset: 0x00603F14
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD0B RID: 48395
		// (get) Token: 0x0602BC8F RID: 179343 RVA: 0x00605D54 File Offset: 0x00603F54
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BC90 RID: 179344 RVA: 0x00605D91 File Offset: 0x00603F91
		public static Offset<IChangeEntityStateDirectly> CreateIChangeEntityStateDirectly(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0, StringOffset StateOffset = default(StringOffset), bool DelayChange = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IChangeEntityStateDirectly.AddState(builder, StateOffset);
			IChangeEntityStateDirectly.AddEntityId(builder, EntityId);
			IChangeEntityStateDirectly.AddNullMask(builder, NullMask);
			IChangeEntityStateDirectly.AddDelayChange(builder, DelayChange);
			IChangeEntityStateDirectly.AddType(builder, Type);
			return IChangeEntityStateDirectly.EndIChangeEntityStateDirectly(builder);
		}

		// Token: 0x0602BC91 RID: 179345 RVA: 0x00605DC5 File Offset: 0x00603FC5
		public static void StartIChangeEntityStateDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BC92 RID: 179346 RVA: 0x00605DCE File Offset: 0x00603FCE
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BC93 RID: 179347 RVA: 0x00605DD9 File Offset: 0x00603FD9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BC94 RID: 179348 RVA: 0x00605DE4 File Offset: 0x00603FE4
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0602BC95 RID: 179349 RVA: 0x00605DF4 File Offset: 0x00603FF4
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(3, delayChange, false);
		}

		// Token: 0x0602BC96 RID: 179350 RVA: 0x00605DFF File Offset: 0x00603FFF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602BC97 RID: 179351 RVA: 0x00605E0A File Offset: 0x0060400A
		public static Offset<IChangeEntityStateDirectly> EndIChangeEntityStateDirectly(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateDirectly>(builder.EndTable());
		}

		// Token: 0x0602BC98 RID: 179352 RVA: 0x00605E18 File Offset: 0x00604018
		public IChangeEntityStateDirectlyT UnPack()
		{
			IChangeEntityStateDirectlyT changeEntityStateDirectlyT = new IChangeEntityStateDirectlyT();
			this.UnPackTo(changeEntityStateDirectlyT);
			return changeEntityStateDirectlyT;
		}

		// Token: 0x0602BC99 RID: 179353 RVA: 0x00605E33 File Offset: 0x00604033
		public void UnPackTo(IChangeEntityStateDirectlyT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.State = this.State;
			_o.DelayChange = this.DelayChange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BC9A RID: 179354 RVA: 0x00605E74 File Offset: 0x00604074
		public static Offset<IChangeEntityStateDirectly> Pack(FlatBufferBuilder builder, IChangeEntityStateDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityStateDirectly>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeEntityStateDirectly.CreateIChangeEntityStateDirectly(builder, _o.Type, _o.EntityId, stateOffset, _o.DelayChange, _o.NullMask);
		}

		// Token: 0x040108A1 RID: 67745
		private Table __p;
	}
}
