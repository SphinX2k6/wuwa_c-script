using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001254 RID: 4692
	[NetMessage(EMessageId.SignActivityRequest)]
	public sealed class SignActivityRequest : IMessage<SignActivityRequest>, IMessage, IEquatable<SignActivityRequest>, IDeepCloneable<SignActivityRequest>, IBufferMessage
	{
		// Token: 0x060190CB RID: 102603 RVA: 0x003A6D4B File Offset: 0x003A4F4B
		[NullableContext(1)]
		public static SignActivityRequest Create()
		{
			return new SignActivityRequest();
		}

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x060190CC RID: 102604 RVA: 0x003A6D52 File Offset: 0x003A4F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x060190CD RID: 102605 RVA: 0x003A6D55 File Offset: 0x003A4F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityRequest.Descriptor;
			}
		}

		// Token: 0x060190CE RID: 102606 RVA: 0x003A6D5C File Offset: 0x003A4F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest()
		{
		}

		// Token: 0x060190CF RID: 102607 RVA: 0x003A6D64 File Offset: 0x003A4F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest(SignActivityRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190D0 RID: 102608 RVA: 0x003A6D95 File Offset: 0x003A4F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest Clone()
		{
			return new SignActivityRequest(this);
		}

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x060190D1 RID: 102609 RVA: 0x003A6D9D File Offset: 0x003A4F9D
		// (set) Token: 0x060190D2 RID: 102610 RVA: 0x003A6DA5 File Offset: 0x003A4FA5
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

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x060190D3 RID: 102611 RVA: 0x003A6DAE File Offset: 0x003A4FAE
		// (set) Token: 0x060190D4 RID: 102612 RVA: 0x003A6DB6 File Offset: 0x003A4FB6
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

		// Token: 0x060190D5 RID: 102613 RVA: 0x003A6DBF File Offset: 0x003A4FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityRequest);
		}

		// Token: 0x060190D6 RID: 102614 RVA: 0x003A6DCD File Offset: 0x003A4FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190D7 RID: 102615 RVA: 0x003A6E0C File Offset: 0x003A500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060190D8 RID: 102616 RVA: 0x003A6E64 File Offset: 0x003A5064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190D9 RID: 102617 RVA: 0x003A6E71 File Offset: 0x003A5071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190DA RID: 102618 RVA: 0x003A6E7C File Offset: 0x003A507C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190DB RID: 102619 RVA: 0x003A6ED8 File Offset: 0x003A50D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060190DC RID: 102620 RVA: 0x003A6F30 File Offset: 0x003A5130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060190DD RID: 102621 RVA: 0x003A6F80 File Offset: 0x003A5180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190DE RID: 102622 RVA: 0x003A6F8C File Offset: 0x003A518C
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009471 RID: 38001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009472 RID: 38002
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04009473 RID: 38003
		private int activityId_;

		// Token: 0x04009474 RID: 38004
		public const int IndexFieldNumber = 10;

		// Token: 0x04009475 RID: 38005
		private int index_;
	}
}
