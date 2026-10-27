using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001215 RID: 4629
	[NetMessage(EMessageId.SignActivityFreeDropRequest)]
	public sealed class SignActivityFreeDropRequest : IMessage<SignActivityFreeDropRequest>, IMessage, IEquatable<SignActivityFreeDropRequest>, IDeepCloneable<SignActivityFreeDropRequest>, IBufferMessage
	{
		// Token: 0x06018AB9 RID: 101049 RVA: 0x00396853 File Offset: 0x00394A53
		[NullableContext(1)]
		public static SignActivityFreeDropRequest Create()
		{
			return new SignActivityFreeDropRequest();
		}

		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x06018ABA RID: 101050 RVA: 0x0039685A File Offset: 0x00394A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x06018ABB RID: 101051 RVA: 0x0039685D File Offset: 0x00394A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityFreeDropRequest.Descriptor;
			}
		}

		// Token: 0x06018ABC RID: 101052 RVA: 0x00396864 File Offset: 0x00394A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest()
		{
		}

		// Token: 0x06018ABD RID: 101053 RVA: 0x0039686C File Offset: 0x00394A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest(SignActivityFreeDropRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018ABE RID: 101054 RVA: 0x00396891 File Offset: 0x00394A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest Clone()
		{
			return new SignActivityFreeDropRequest(this);
		}

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x06018ABF RID: 101055 RVA: 0x00396899 File Offset: 0x00394A99
		// (set) Token: 0x06018AC0 RID: 101056 RVA: 0x003968A1 File Offset: 0x00394AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06018AC1 RID: 101057 RVA: 0x003968AA File Offset: 0x00394AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityFreeDropRequest);
		}

		// Token: 0x06018AC2 RID: 101058 RVA: 0x003968B8 File Offset: 0x00394AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityFreeDropRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AC3 RID: 101059 RVA: 0x003968E8 File Offset: 0x00394AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AC4 RID: 101060 RVA: 0x00396927 File Offset: 0x00394B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AC5 RID: 101061 RVA: 0x00396934 File Offset: 0x00394B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AC6 RID: 101062 RVA: 0x0039693D File Offset: 0x00394B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AC7 RID: 101063 RVA: 0x00396970 File Offset: 0x00394B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AC8 RID: 101064 RVA: 0x003969AE File Offset: 0x00394BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityFreeDropRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AC9 RID: 101065 RVA: 0x003969DF File Offset: 0x00394BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018ACA RID: 101066 RVA: 0x003969E8 File Offset: 0x00394BE8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040091B5 RID: 37301
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091B6 RID: 37302
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x040091B7 RID: 37303
		private int activityId_;
	}
}
