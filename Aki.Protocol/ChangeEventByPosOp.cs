using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024E RID: 590
	public sealed class ChangeEventByPosOp : IMessage<ChangeEventByPosOp>, IMessage, IEquatable<ChangeEventByPosOp>, IDeepCloneable<ChangeEventByPosOp>, IBufferMessage
	{
		// Token: 0x06003EF7 RID: 16119 RVA: 0x0009B265 File Offset: 0x00099465
		[NullableContext(1)]
		public static ChangeEventByPosOp Create()
		{
			return new ChangeEventByPosOp();
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x0009B26C File Offset: 0x0009946C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x0009B26F File Offset: 0x0009946F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEventByPosOp.Descriptor;
			}
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0009B276 File Offset: 0x00099476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp()
		{
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0009B289 File Offset: 0x00099489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp(ChangeEventByPosOp other) : this()
		{
			this.changeEventDatas_ = other.changeEventDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0009B2B3 File Offset: 0x000994B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp Clone()
		{
			return new ChangeEventByPosOp(this);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x0009B2BB File Offset: 0x000994BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChangeEventData> ChangeEventDatas
		{
			get
			{
				return this.changeEventDatas_;
			}
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0009B2C3 File Offset: 0x000994C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEventByPosOp);
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0009B2D1 File Offset: 0x000994D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEventByPosOp other)
		{
			return other != null && (other == this || (this.changeEventDatas_.Equals(other.changeEventDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0009B304 File Offset: 0x00099504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.changeEventDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0009B338 File Offset: 0x00099538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x0009B345 File Offset: 0x00099545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x0009B34E File Offset: 0x0009954E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeEventDatas_.WriteTo(ref output, ChangeEventByPosOp._repeated_changeEventDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x0009B378 File Offset: 0x00099578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.changeEventDatas_.CalculateSize(ChangeEventByPosOp._repeated_changeEventDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x0009B3B1 File Offset: 0x000995B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEventByPosOp other)
		{
			if (other == null)
			{
				return;
			}
			this.changeEventDatas_.Add(other.changeEventDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0009B3DF File Offset: 0x000995DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0009B3E8 File Offset: 0x000995E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.changeEventDatas_.AddEntriesFrom(ref input, ChangeEventByPosOp._repeated_changeEventDatas_codec);
				}
			}
		}

		// Token: 0x04002D02 RID: 11522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D03 RID: 11523
		public const int ChangeEventDatasFieldNumber = 1;

		// Token: 0x04002D04 RID: 11524
		private static readonly FieldCodec<ChangeEventData> _repeated_changeEventDatas_codec = FieldCodec.ForMessage<ChangeEventData>(10U, ChangeEventData.Parser);

		// Token: 0x04002D05 RID: 11525
		private readonly RepeatedField<ChangeEventData> changeEventDatas_ = new RepeatedField<ChangeEventData>();
	}
}
