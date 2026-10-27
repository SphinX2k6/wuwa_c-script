using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001218 RID: 4632
	[NetMessage(EMessageId.SignActivityRequest)]
	public sealed class SignActivityRequest : IMessage<SignActivityRequest>, IMessage, IEquatable<SignActivityRequest>, IDeepCloneable<SignActivityRequest>, IBufferMessage
	{
		// Token: 0x06018AF1 RID: 101105 RVA: 0x00396EA8 File Offset: 0x003950A8
		[NullableContext(1)]
		public static SignActivityRequest Create()
		{
			return new SignActivityRequest();
		}

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x06018AF2 RID: 101106 RVA: 0x00396EAF File Offset: 0x003950AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x06018AF3 RID: 101107 RVA: 0x00396EB2 File Offset: 0x003950B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityRequest.Descriptor;
			}
		}

		// Token: 0x06018AF4 RID: 101108 RVA: 0x00396EB9 File Offset: 0x003950B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest()
		{
		}

		// Token: 0x06018AF5 RID: 101109 RVA: 0x00396EC1 File Offset: 0x003950C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest(SignActivityRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AF6 RID: 101110 RVA: 0x00396EF2 File Offset: 0x003950F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityRequest Clone()
		{
			return new SignActivityRequest(this);
		}

		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x06018AF7 RID: 101111 RVA: 0x00396EFA File Offset: 0x003950FA
		// (set) Token: 0x06018AF8 RID: 101112 RVA: 0x00396F02 File Offset: 0x00395102
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

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x06018AF9 RID: 101113 RVA: 0x00396F0B File Offset: 0x0039510B
		// (set) Token: 0x06018AFA RID: 101114 RVA: 0x00396F13 File Offset: 0x00395113
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

		// Token: 0x06018AFB RID: 101115 RVA: 0x00396F1C File Offset: 0x0039511C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityRequest);
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x00396F2A File Offset: 0x0039512A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AFD RID: 101117 RVA: 0x00396F68 File Offset: 0x00395168
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

		// Token: 0x06018AFE RID: 101118 RVA: 0x00396FC0 File Offset: 0x003951C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AFF RID: 101119 RVA: 0x00396FCD File Offset: 0x003951CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B00 RID: 101120 RVA: 0x00396FD8 File Offset: 0x003951D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B01 RID: 101121 RVA: 0x00397034 File Offset: 0x00395234
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

		// Token: 0x06018B02 RID: 101122 RVA: 0x0039708C File Offset: 0x0039528C
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

		// Token: 0x06018B03 RID: 101123 RVA: 0x003970DC File Offset: 0x003952DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B04 RID: 101124 RVA: 0x003970E8 File Offset: 0x003952E8
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
				if (num != 16U)
				{
					if (num != 88U)
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

		// Token: 0x040091C0 RID: 37312
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091C1 RID: 37313
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040091C2 RID: 37314
		private int activityId_;

		// Token: 0x040091C3 RID: 37315
		public const int IndexFieldNumber = 11;

		// Token: 0x040091C4 RID: 37316
		private int index_;
	}
}
