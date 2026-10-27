using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031E RID: 798
	[NetMessage(EMessageId.DailyAdventurePtRewardRequest)]
	public sealed class DailyAdventurePtRewardRequest : IMessage<DailyAdventurePtRewardRequest>, IMessage, IEquatable<DailyAdventurePtRewardRequest>, IDeepCloneable<DailyAdventurePtRewardRequest>, IBufferMessage
	{
		// Token: 0x06005062 RID: 20578 RVA: 0x000C40F0 File Offset: 0x000C22F0
		[NullableContext(1)]
		public static DailyAdventurePtRewardRequest Create()
		{
			return new DailyAdventurePtRewardRequest();
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x000C40F7 File Offset: 0x000C22F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x000C40FA File Offset: 0x000C22FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventurePtRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x000C4101 File Offset: 0x000C2301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest()
		{
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x000C4109 File Offset: 0x000C2309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest(DailyAdventurePtRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x000C412E File Offset: 0x000C232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest Clone()
		{
			return new DailyAdventurePtRewardRequest(this);
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x000C4136 File Offset: 0x000C2336
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x000C413E File Offset: 0x000C233E
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

		// Token: 0x0600506A RID: 20586 RVA: 0x000C4147 File Offset: 0x000C2347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventurePtRewardRequest);
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x000C4155 File Offset: 0x000C2355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventurePtRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x000C4184 File Offset: 0x000C2384
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

		// Token: 0x0600506D RID: 20589 RVA: 0x000C41C3 File Offset: 0x000C23C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x000C41D0 File Offset: 0x000C23D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x000C41D9 File Offset: 0x000C23D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x000C420C File Offset: 0x000C240C
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

		// Token: 0x06005071 RID: 20593 RVA: 0x000C424A File Offset: 0x000C244A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventurePtRewardRequest other)
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

		// Token: 0x06005072 RID: 20594 RVA: 0x000C427B File Offset: 0x000C247B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x000C4284 File Offset: 0x000C2484
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003265 RID: 12901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003266 RID: 12902
		public const int IdFieldNumber = 6;

		// Token: 0x04003267 RID: 12903
		private int id_;
	}
}
