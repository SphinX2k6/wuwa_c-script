using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001251 RID: 4689
	[NetMessage(EMessageId.SignActivityFreeDropRequest)]
	public sealed class SignActivityFreeDropRequest : IMessage<SignActivityFreeDropRequest>, IMessage, IEquatable<SignActivityFreeDropRequest>, IDeepCloneable<SignActivityFreeDropRequest>, IBufferMessage
	{
		// Token: 0x06019093 RID: 102547 RVA: 0x003A66FB File Offset: 0x003A48FB
		[NullableContext(1)]
		public static SignActivityFreeDropRequest Create()
		{
			return new SignActivityFreeDropRequest();
		}

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x06019094 RID: 102548 RVA: 0x003A6702 File Offset: 0x003A4902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x06019095 RID: 102549 RVA: 0x003A6705 File Offset: 0x003A4905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityFreeDropRequest.Descriptor;
			}
		}

		// Token: 0x06019096 RID: 102550 RVA: 0x003A670C File Offset: 0x003A490C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest()
		{
		}

		// Token: 0x06019097 RID: 102551 RVA: 0x003A6714 File Offset: 0x003A4914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest(SignActivityFreeDropRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019098 RID: 102552 RVA: 0x003A6739 File Offset: 0x003A4939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropRequest Clone()
		{
			return new SignActivityFreeDropRequest(this);
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x06019099 RID: 102553 RVA: 0x003A6741 File Offset: 0x003A4941
		// (set) Token: 0x0601909A RID: 102554 RVA: 0x003A6749 File Offset: 0x003A4949
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

		// Token: 0x0601909B RID: 102555 RVA: 0x003A6752 File Offset: 0x003A4952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityFreeDropRequest);
		}

		// Token: 0x0601909C RID: 102556 RVA: 0x003A6760 File Offset: 0x003A4960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityFreeDropRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601909D RID: 102557 RVA: 0x003A6790 File Offset: 0x003A4990
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

		// Token: 0x0601909E RID: 102558 RVA: 0x003A67CF File Offset: 0x003A49CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601909F RID: 102559 RVA: 0x003A67DC File Offset: 0x003A49DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190A0 RID: 102560 RVA: 0x003A67E5 File Offset: 0x003A49E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190A1 RID: 102561 RVA: 0x003A6818 File Offset: 0x003A4A18
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

		// Token: 0x060190A2 RID: 102562 RVA: 0x003A6856 File Offset: 0x003A4A56
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

		// Token: 0x060190A3 RID: 102563 RVA: 0x003A6887 File Offset: 0x003A4A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190A4 RID: 102564 RVA: 0x003A6890 File Offset: 0x003A4A90
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009466 RID: 37990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009467 RID: 37991
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04009468 RID: 37992
		private int activityId_;
	}
}
