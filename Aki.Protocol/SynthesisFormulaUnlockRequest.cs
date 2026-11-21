using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001377 RID: 4983
	[NetMessage(EMessageId.SynthesisFormulaUnlockRequest)]
	public sealed class SynthesisFormulaUnlockRequest : IMessage<SynthesisFormulaUnlockRequest>, IMessage, IEquatable<SynthesisFormulaUnlockRequest>, IDeepCloneable<SynthesisFormulaUnlockRequest>, IBufferMessage
	{
		// Token: 0x0601A88C RID: 108684 RVA: 0x003DDB43 File Offset: 0x003DBD43
		[NullableContext(1)]
		public static SynthesisFormulaUnlockRequest Create()
		{
			return new SynthesisFormulaUnlockRequest();
		}

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x0601A88D RID: 108685 RVA: 0x003DDB4A File Offset: 0x003DBD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x0601A88E RID: 108686 RVA: 0x003DDB4D File Offset: 0x003DBD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisFormulaUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0601A88F RID: 108687 RVA: 0x003DDB54 File Offset: 0x003DBD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest()
		{
		}

		// Token: 0x0601A890 RID: 108688 RVA: 0x003DDB5C File Offset: 0x003DBD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest(SynthesisFormulaUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A891 RID: 108689 RVA: 0x003DDB81 File Offset: 0x003DBD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest Clone()
		{
			return new SynthesisFormulaUnlockRequest(this);
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x0601A892 RID: 108690 RVA: 0x003DDB89 File Offset: 0x003DBD89
		// (set) Token: 0x0601A893 RID: 108691 RVA: 0x003DDB91 File Offset: 0x003DBD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601A894 RID: 108692 RVA: 0x003DDB9A File Offset: 0x003DBD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisFormulaUnlockRequest);
		}

		// Token: 0x0601A895 RID: 108693 RVA: 0x003DDBA8 File Offset: 0x003DBDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisFormulaUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A896 RID: 108694 RVA: 0x003DDBD8 File Offset: 0x003DBDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A897 RID: 108695 RVA: 0x003DDC17 File Offset: 0x003DBE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A898 RID: 108696 RVA: 0x003DDC24 File Offset: 0x003DBE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A899 RID: 108697 RVA: 0x003DDC2D File Offset: 0x003DBE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A89A RID: 108698 RVA: 0x003DDC60 File Offset: 0x003DBE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A89B RID: 108699 RVA: 0x003DDC9E File Offset: 0x003DBE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisFormulaUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A89C RID: 108700 RVA: 0x003DDCCF File Offset: 0x003DBECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A89D RID: 108701 RVA: 0x003DDCD8 File Offset: 0x003DBED8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B8C RID: 39820
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B8D RID: 39821
		public const int IdFieldNumber = 4;

		// Token: 0x04009B8E RID: 39822
		private int id_;
	}
}
