using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE0 RID: 3296
	[NetMessage(EMessageId.PhantomPolishRequest)]
	public sealed class PhantomPolishRequest : IMessage<PhantomPolishRequest>, IMessage, IEquatable<PhantomPolishRequest>, IDeepCloneable<PhantomPolishRequest>, IBufferMessage
	{
		// Token: 0x06011D94 RID: 73108 RVA: 0x0029CB8C File Offset: 0x0029AD8C
		[NullableContext(1)]
		public static PhantomPolishRequest Create()
		{
			return new PhantomPolishRequest();
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x06011D95 RID: 73109 RVA: 0x0029CB93 File Offset: 0x0029AD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x06011D96 RID: 73110 RVA: 0x0029CB96 File Offset: 0x0029AD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPolishRequest.Descriptor;
			}
		}

		// Token: 0x06011D97 RID: 73111 RVA: 0x0029CB9D File Offset: 0x0029AD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest()
		{
		}

		// Token: 0x06011D98 RID: 73112 RVA: 0x0029CBA5 File Offset: 0x0029ADA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest(PhantomPolishRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.phantomMainPropItemId_ = other.phantomMainPropItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D99 RID: 73113 RVA: 0x0029CBD6 File Offset: 0x0029ADD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishRequest Clone()
		{
			return new PhantomPolishRequest(this);
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x06011D9A RID: 73114 RVA: 0x0029CBDE File Offset: 0x0029ADDE
		// (set) Token: 0x06011D9B RID: 73115 RVA: 0x0029CBE6 File Offset: 0x0029ADE6
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

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x06011D9C RID: 73116 RVA: 0x0029CBEF File Offset: 0x0029ADEF
		// (set) Token: 0x06011D9D RID: 73117 RVA: 0x0029CBF7 File Offset: 0x0029ADF7
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

		// Token: 0x06011D9E RID: 73118 RVA: 0x0029CC00 File Offset: 0x0029AE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPolishRequest);
		}

		// Token: 0x06011D9F RID: 73119 RVA: 0x0029CC0E File Offset: 0x0029AE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPolishRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.PhantomMainPropItemId == other.PhantomMainPropItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DA0 RID: 73120 RVA: 0x0029CC4C File Offset: 0x0029AE4C
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

		// Token: 0x06011DA1 RID: 73121 RVA: 0x0029CCA4 File Offset: 0x0029AEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DA2 RID: 73122 RVA: 0x0029CCB1 File Offset: 0x0029AEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DA3 RID: 73123 RVA: 0x0029CCBC File Offset: 0x0029AEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomMainPropItemId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PhantomMainPropItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DA4 RID: 73124 RVA: 0x0029CD18 File Offset: 0x0029AF18
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

		// Token: 0x06011DA5 RID: 73125 RVA: 0x0029CD70 File Offset: 0x0029AF70
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

		// Token: 0x06011DA6 RID: 73126 RVA: 0x0029CDC0 File Offset: 0x0029AFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DA7 RID: 73127 RVA: 0x0029CDCC File Offset: 0x0029AFCC
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
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomMainPropItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400706A RID: 28778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400706B RID: 28779
		public const int IncrIdFieldNumber = 14;

		// Token: 0x0400706C RID: 28780
		private int incrId_;

		// Token: 0x0400706D RID: 28781
		public const int PhantomMainPropItemIdFieldNumber = 10;

		// Token: 0x0400706E RID: 28782
		private int phantomMainPropItemId_;
	}
}
