using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001165 RID: 4453
	[NetMessage(EMessageId.RoverRogueTalentInfoRequest)]
	public sealed class RoverRogueTalentInfoRequest : IMessage<RoverRogueTalentInfoRequest>, IMessage, IEquatable<RoverRogueTalentInfoRequest>, IDeepCloneable<RoverRogueTalentInfoRequest>, IBufferMessage
	{
		// Token: 0x06017CC9 RID: 97481 RVA: 0x0037749F File Offset: 0x0037569F
		[NullableContext(1)]
		public static RoverRogueTalentInfoRequest Create()
		{
			return new RoverRogueTalentInfoRequest();
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x06017CCA RID: 97482 RVA: 0x003774A6 File Offset: 0x003756A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x06017CCB RID: 97483 RVA: 0x003774A9 File Offset: 0x003756A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentInfoRequest.Descriptor;
			}
		}

		// Token: 0x06017CCC RID: 97484 RVA: 0x003774B0 File Offset: 0x003756B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest()
		{
		}

		// Token: 0x06017CCD RID: 97485 RVA: 0x003774B8 File Offset: 0x003756B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest(RoverRogueTalentInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CCE RID: 97486 RVA: 0x003774DD File Offset: 0x003756DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest Clone()
		{
			return new RoverRogueTalentInfoRequest(this);
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x06017CCF RID: 97487 RVA: 0x003774E5 File Offset: 0x003756E5
		// (set) Token: 0x06017CD0 RID: 97488 RVA: 0x003774ED File Offset: 0x003756ED
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

		// Token: 0x06017CD1 RID: 97489 RVA: 0x003774F6 File Offset: 0x003756F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentInfoRequest);
		}

		// Token: 0x06017CD2 RID: 97490 RVA: 0x00377504 File Offset: 0x00375704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CD3 RID: 97491 RVA: 0x00377534 File Offset: 0x00375734
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

		// Token: 0x06017CD4 RID: 97492 RVA: 0x00377573 File Offset: 0x00375773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CD5 RID: 97493 RVA: 0x00377580 File Offset: 0x00375780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CD6 RID: 97494 RVA: 0x00377589 File Offset: 0x00375789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CD7 RID: 97495 RVA: 0x003775BC File Offset: 0x003757BC
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

		// Token: 0x06017CD8 RID: 97496 RVA: 0x003775FA File Offset: 0x003757FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentInfoRequest other)
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

		// Token: 0x06017CD9 RID: 97497 RVA: 0x0037762B File Offset: 0x0037582B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CDA RID: 97498 RVA: 0x00377634 File Offset: 0x00375834
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E0B RID: 36363
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E0C RID: 36364
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04008E0D RID: 36365
		private int activityId_;
	}
}
