using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA8 RID: 15016
	public struct IOtherVarRef : IFlatbufferObject
	{
		// Token: 0x170066F4 RID: 26356
		// (get) Token: 0x0601465E RID: 83550 RVA: 0x002F9731 File Offset: 0x002F7931
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601465F RID: 83551 RVA: 0x002F973E File Offset: 0x002F793E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014660 RID: 83552 RVA: 0x002F9748 File Offset: 0x002F7948
		public static IOtherVarRef GetRootAsIOtherVarRef(ByteBuffer _bb)
		{
			return IOtherVarRef.GetRootAsIOtherVarRef(_bb, default(IOtherVarRef));
		}

		// Token: 0x06014661 RID: 83553 RVA: 0x002F9764 File Offset: 0x002F7964
		public static IOtherVarRef GetRootAsIOtherVarRef(ByteBuffer _bb, IOtherVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014662 RID: 83554 RVA: 0x002F9781 File Offset: 0x002F7981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014663 RID: 83555 RVA: 0x002F9790 File Offset: 0x002F7990
		public IOtherVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066F5 RID: 26357
		// (get) Token: 0x06014664 RID: 83556 RVA: 0x002F97A0 File Offset: 0x002F79A0
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066F6 RID: 26358
		// (get) Token: 0x06014665 RID: 83557 RVA: 0x002F97DC File Offset: 0x002F79DC
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066F7 RID: 26359
		// (get) Token: 0x06014666 RID: 83558 RVA: 0x002F9818 File Offset: 0x002F7A18
		public ERefType RefType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERefType.Entity;
				}
				return (ERefType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x06014667 RID: 83559 RVA: 0x002F9854 File Offset: 0x002F7A54
		public int RefId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x06014668 RID: 83560 RVA: 0x002F9894 File Offset: 0x002F7A94
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014669 RID: 83561 RVA: 0x002F98CC File Offset: 0x002F7ACC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601466A RID: 83562 RVA: 0x002F98DC File Offset: 0x002F7ADC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601466B RID: 83563 RVA: 0x002F98EB File Offset: 0x002F7AEB
		public static Offset<IOtherVarRef> CreateIOtherVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, ERefType RefType = ERefType.Entity, int RefId = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IOtherVarRef.AddName(builder, NameOffset);
			IOtherVarRef.AddRefId(builder, RefId);
			IOtherVarRef.AddRefType(builder, RefType);
			IOtherVarRef.AddSource(builder, Source);
			IOtherVarRef.AddType(builder, Type);
			return IOtherVarRef.EndIOtherVarRef(builder);
		}

		// Token: 0x0601466C RID: 83564 RVA: 0x002F991F File Offset: 0x002F7B1F
		public static void StartIOtherVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601466D RID: 83565 RVA: 0x002F9928 File Offset: 0x002F7B28
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601466E RID: 83566 RVA: 0x002F9933 File Offset: 0x002F7B33
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x0601466F RID: 83567 RVA: 0x002F993E File Offset: 0x002F7B3E
		public static void AddRefType(FlatBufferBuilder builder, ERefType refType)
		{
			builder.AddByte(2, (byte)refType, 0);
		}

		// Token: 0x06014670 RID: 83568 RVA: 0x002F9949 File Offset: 0x002F7B49
		public static void AddRefId(FlatBufferBuilder builder, int refId)
		{
			builder.AddInt(3, refId, 0);
		}

		// Token: 0x06014671 RID: 83569 RVA: 0x002F9954 File Offset: 0x002F7B54
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06014672 RID: 83570 RVA: 0x002F9964 File Offset: 0x002F7B64
		public static Offset<IOtherVarRef> EndIOtherVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IOtherVarRef>(builder.EndTable());
		}

		// Token: 0x06014673 RID: 83571 RVA: 0x002F9974 File Offset: 0x002F7B74
		public IOtherVarRefT UnPack()
		{
			IOtherVarRefT otherVarRefT = new IOtherVarRefT();
			this.UnPackTo(otherVarRefT);
			return otherVarRefT;
		}

		// Token: 0x06014674 RID: 83572 RVA: 0x002F998F File Offset: 0x002F7B8F
		public void UnPackTo(IOtherVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.RefType = this.RefType;
			_o.RefId = this.RefId;
			_o.Name = this.Name;
		}

		// Token: 0x06014675 RID: 83573 RVA: 0x002F99D0 File Offset: 0x002F7BD0
		public static Offset<IOtherVarRef> Pack(FlatBufferBuilder builder, IOtherVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOtherVarRef>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IOtherVarRef.CreateIOtherVarRef(builder, _o.Type, _o.Source, _o.RefType, _o.RefId, nameOffset);
		}

		// Token: 0x0400AF33 RID: 44851
		private Table __p;
	}
}
