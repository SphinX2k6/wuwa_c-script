using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137B RID: 4987
	[NetMessage(EMessageId.TimePointActivityRewardRequest)]
	public sealed class TimePointActivityRewardRequest : IMessage<TimePointActivityRewardRequest>, IMessage, IEquatable<TimePointActivityRewardRequest>, IDeepCloneable<TimePointActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601A7A1 RID: 108449 RVA: 0x003D7E31 File Offset: 0x003D6031
		[NullableContext(1)]
		public static TimePointActivityRewardRequest Create()
		{
			return new TimePointActivityRewardRequest();
		}

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x0601A7A2 RID: 108450 RVA: 0x003D7E38 File Offset: 0x003D6038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x0601A7A3 RID: 108451 RVA: 0x003D7E3B File Offset: 0x003D603B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601A7A4 RID: 108452 RVA: 0x003D7E42 File Offset: 0x003D6042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest()
		{
		}

		// Token: 0x0601A7A5 RID: 108453 RVA: 0x003D7E4A File Offset: 0x003D604A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest(TimePointActivityRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7A6 RID: 108454 RVA: 0x003D7E6F File Offset: 0x003D606F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest Clone()
		{
			return new TimePointActivityRewardRequest(this);
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x0601A7A7 RID: 108455 RVA: 0x003D7E77 File Offset: 0x003D6077
		// (set) Token: 0x0601A7A8 RID: 108456 RVA: 0x003D7E7F File Offset: 0x003D607F
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

		// Token: 0x0601A7A9 RID: 108457 RVA: 0x003D7E88 File Offset: 0x003D6088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityRewardRequest);
		}

		// Token: 0x0601A7AA RID: 108458 RVA: 0x003D7E96 File Offset: 0x003D6096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7AB RID: 108459 RVA: 0x003D7EC4 File Offset: 0x003D60C4
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

		// Token: 0x0601A7AC RID: 108460 RVA: 0x003D7F03 File Offset: 0x003D6103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7AD RID: 108461 RVA: 0x003D7F10 File Offset: 0x003D6110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7AE RID: 108462 RVA: 0x003D7F19 File Offset: 0x003D6119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7AF RID: 108463 RVA: 0x003D7F4C File Offset: 0x003D614C
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

		// Token: 0x0601A7B0 RID: 108464 RVA: 0x003D7F8A File Offset: 0x003D618A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityRewardRequest other)
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

		// Token: 0x0601A7B1 RID: 108465 RVA: 0x003D7FBB File Offset: 0x003D61BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7B2 RID: 108466 RVA: 0x003D7FC4 File Offset: 0x003D61C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A18 RID: 39448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A19 RID: 39449
		public const int IdFieldNumber = 7;

		// Token: 0x04009A1A RID: 39450
		private int id_;
	}
}
