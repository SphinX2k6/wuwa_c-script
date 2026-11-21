using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC5 RID: 3269
	[NetMessage(EMessageId.PhantomIdentifyRequest)]
	public sealed class PhantomIdentifyRequest : IMessage<PhantomIdentifyRequest>, IMessage, IEquatable<PhantomIdentifyRequest>, IDeepCloneable<PhantomIdentifyRequest>, IBufferMessage
	{
		// Token: 0x06011B7D RID: 72573 RVA: 0x002983AD File Offset: 0x002965AD
		[NullableContext(1)]
		public static PhantomIdentifyRequest Create()
		{
			return new PhantomIdentifyRequest();
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x06011B7E RID: 72574 RVA: 0x002983B4 File Offset: 0x002965B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x06011B7F RID: 72575 RVA: 0x002983B7 File Offset: 0x002965B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomIdentifyRequest.Descriptor;
			}
		}

		// Token: 0x06011B80 RID: 72576 RVA: 0x002983BE File Offset: 0x002965BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest()
		{
		}

		// Token: 0x06011B81 RID: 72577 RVA: 0x002983C6 File Offset: 0x002965C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest(PhantomIdentifyRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B82 RID: 72578 RVA: 0x002983F7 File Offset: 0x002965F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyRequest Clone()
		{
			return new PhantomIdentifyRequest(this);
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x06011B83 RID: 72579 RVA: 0x002983FF File Offset: 0x002965FF
		// (set) Token: 0x06011B84 RID: 72580 RVA: 0x00298407 File Offset: 0x00296607
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

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x06011B85 RID: 72581 RVA: 0x00298410 File Offset: 0x00296610
		// (set) Token: 0x06011B86 RID: 72582 RVA: 0x00298418 File Offset: 0x00296618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06011B87 RID: 72583 RVA: 0x00298421 File Offset: 0x00296621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomIdentifyRequest);
		}

		// Token: 0x06011B88 RID: 72584 RVA: 0x0029842F File Offset: 0x0029662F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomIdentifyRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B89 RID: 72585 RVA: 0x00298470 File Offset: 0x00296670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B8A RID: 72586 RVA: 0x002984C8 File Offset: 0x002966C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B8B RID: 72587 RVA: 0x002984D5 File Offset: 0x002966D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B8C RID: 72588 RVA: 0x002984E0 File Offset: 0x002966E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B8D RID: 72589 RVA: 0x0029853C File Offset: 0x0029673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B8E RID: 72590 RVA: 0x00298594 File Offset: 0x00296794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomIdentifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B8F RID: 72591 RVA: 0x002985E4 File Offset: 0x002967E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B90 RID: 72592 RVA: 0x002985F0 File Offset: 0x002967F0
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
				if (num != 24U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006FCA RID: 28618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FCB RID: 28619
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04006FCC RID: 28620
		private int incrId_;

		// Token: 0x04006FCD RID: 28621
		public const int CountFieldNumber = 10;

		// Token: 0x04006FCE RID: 28622
		private int count_;
	}
}
