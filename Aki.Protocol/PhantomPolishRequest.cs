using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF0 RID: 3312
	[NetMessage(EMessageId.PhantomPolishRequest)]
	public sealed class PhantomPolishRequest : IMessage<PhantomPolishRequest>, IMessage, IEquatable<PhantomPolishRequest>, IDeepCloneable<PhantomPolishRequest>, IBufferMessage
	{
		// Token: 0x06011E90 RID: 73360 RVA: 0x0029E7A4 File Offset: 0x0029C9A4
		[NullableContext(1)]
		public static PhantomPolishRequest Create()
		{
			return new PhantomPolishRequest();
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x06011E91 RID: 73361 RVA: 0x0029E7AB File Offset: 0x0029C9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x06011E92 RID: 73362 RVA: 0x0029E7AE File Offset: 0x0029C9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPolishRequest.Descriptor;
			}
		}

		// Token: 0x06011E93 RID: 73363 RVA: 0x0029E7B5 File Offset: 0x0029C9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest()
		{
		}

		// Token: 0x06011E94 RID: 73364 RVA: 0x0029E7BD File Offset: 0x0029C9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest(PhantomPolishRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.phantomMainPropItemId_ = other.phantomMainPropItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E95 RID: 73365 RVA: 0x0029E7EE File Offset: 0x0029C9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest Clone()
		{
			return new PhantomPolishRequest(this);
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x06011E96 RID: 73366 RVA: 0x0029E7F6 File Offset: 0x0029C9F6
		// (set) Token: 0x06011E97 RID: 73367 RVA: 0x0029E7FE File Offset: 0x0029C9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x06011E98 RID: 73368 RVA: 0x0029E807 File Offset: 0x0029CA07
		// (set) Token: 0x06011E99 RID: 73369 RVA: 0x0029E80F File Offset: 0x0029CA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomMainPropItemId
		{
			get
			{
				return this.phantomMainPropItemId_;
			}
			set
			{
				this.phantomMainPropItemId_ = value;
			}
		}

		// Token: 0x06011E9A RID: 73370 RVA: 0x0029E818 File Offset: 0x0029CA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPolishRequest);
		}

		// Token: 0x06011E9B RID: 73371 RVA: 0x0029E826 File Offset: 0x0029CA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPolishRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.PhantomMainPropItemId == other.PhantomMainPropItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E9C RID: 73372 RVA: 0x0029E864 File Offset: 0x0029CA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.PhantomMainPropItemId != 0)
			{
				num ^= this.PhantomMainPropItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011E9D RID: 73373 RVA: 0x0029E8BC File Offset: 0x0029CABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E9E RID: 73374 RVA: 0x0029E8C9 File Offset: 0x0029CAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E9F RID: 73375 RVA: 0x0029E8D4 File Offset: 0x0029CAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncrId);
			}
			if (this.PhantomMainPropItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PhantomMainPropItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EA0 RID: 73376 RVA: 0x0029E930 File Offset: 0x0029CB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.PhantomMainPropItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomMainPropItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EA1 RID: 73377 RVA: 0x0029E988 File Offset: 0x0029CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPolishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.PhantomMainPropItemId != 0)
			{
				this.PhantomMainPropItemId = other.PhantomMainPropItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011EA2 RID: 73378 RVA: 0x0029E9D8 File Offset: 0x0029CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EA3 RID: 73379 RVA: 0x0029E9E4 File Offset: 0x0029CBE4
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PhantomMainPropItemId = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007052 RID: 28754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007053 RID: 28755
		public const int IncrIdFieldNumber = 9;

		// Token: 0x04007054 RID: 28756
		private int incrId_;

		// Token: 0x04007055 RID: 28757
		public const int PhantomMainPropItemIdFieldNumber = 12;

		// Token: 0x04007056 RID: 28758
		private int phantomMainPropItemId_;
	}
}
