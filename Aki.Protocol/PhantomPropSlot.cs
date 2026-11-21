using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE3 RID: 3299
	public sealed class PhantomPropSlot : IMessage<PhantomPropSlot>, IMessage, IEquatable<PhantomPropSlot>, IDeepCloneable<PhantomPropSlot>, IBufferMessage
	{
		// Token: 0x06011DD6 RID: 73174 RVA: 0x0029D59B File Offset: 0x0029B79B
		[NullableContext(1)]
		public static PhantomPropSlot Create()
		{
			return new PhantomPropSlot();
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x06011DD7 RID: 73175 RVA: 0x0029D5A2 File Offset: 0x0029B7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x06011DD8 RID: 73176 RVA: 0x0029D5A5 File Offset: 0x0029B7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPropSlot.Descriptor;
			}
		}

		// Token: 0x06011DD9 RID: 73177 RVA: 0x0029D5AC File Offset: 0x0029B7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot()
		{
		}

		// Token: 0x06011DDA RID: 73178 RVA: 0x0029D5BF File Offset: 0x0029B7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot(PhantomPropSlot other) : this()
		{
			this.index_ = other.index_;
			this.phantomProp_ = other.phantomProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DDB RID: 73179 RVA: 0x0029D5F5 File Offset: 0x0029B7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot Clone()
		{
			return new PhantomPropSlot(this);
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x06011DDC RID: 73180 RVA: 0x0029D5FD File Offset: 0x0029B7FD
		// (set) Token: 0x06011DDD RID: 73181 RVA: 0x0029D605 File Offset: 0x0029B805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x06011DDE RID: 73182 RVA: 0x0029D60E File Offset: 0x0029B80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomProp
		{
			get
			{
				return this.phantomProp_;
			}
		}

		// Token: 0x06011DDF RID: 73183 RVA: 0x0029D616 File Offset: 0x0029B816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPropSlot);
		}

		// Token: 0x06011DE0 RID: 73184 RVA: 0x0029D624 File Offset: 0x0029B824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPropSlot other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.phantomProp_.Equals(other.phantomProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DE1 RID: 73185 RVA: 0x0029D674 File Offset: 0x0029B874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.phantomProp_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011DE2 RID: 73186 RVA: 0x0029D6C1 File Offset: 0x0029B8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DE3 RID: 73187 RVA: 0x0029D6CE File Offset: 0x0029B8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DE4 RID: 73188 RVA: 0x0029D6D8 File Offset: 0x0029B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			this.phantomProp_.WriteTo(ref output, PhantomPropSlot._repeated_phantomProp_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DE5 RID: 73189 RVA: 0x0029D728 File Offset: 0x0029B928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.phantomProp_.CalculateSize(PhantomPropSlot._repeated_phantomProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011DE6 RID: 73190 RVA: 0x0029D77C File Offset: 0x0029B97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPropSlot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.phantomProp_.Add(other.phantomProp_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011DE7 RID: 73191 RVA: 0x0029D7C9 File Offset: 0x0029B9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DE8 RID: 73192 RVA: 0x0029D7D4 File Offset: 0x0029B9D4
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomProp_.AddEntriesFrom(ref input, PhantomPropSlot._repeated_phantomProp_codec);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400707E RID: 28798
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400707F RID: 28799
		public const int IndexFieldNumber = 1;

		// Token: 0x04007080 RID: 28800
		private int index_;

		// Token: 0x04007081 RID: 28801
		public const int PhantomPropFieldNumber = 2;

		// Token: 0x04007082 RID: 28802
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(18U, PhantomPropInfo.Parser);

		// Token: 0x04007083 RID: 28803
		private readonly RepeatedField<PhantomPropInfo> phantomProp_ = new RepeatedField<PhantomPropInfo>();
	}
}
