using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C87 RID: 3207
	[NetMessage(EMessageId.PhantomBattleMasterInfoNotify)]
	public sealed class PhantomBattleMasterInfoNotify : IMessage<PhantomBattleMasterInfoNotify>, IMessage, IEquatable<PhantomBattleMasterInfoNotify>, IDeepCloneable<PhantomBattleMasterInfoNotify>, IBufferMessage
	{
		// Token: 0x06011686 RID: 71302 RVA: 0x0028D897 File Offset: 0x0028BA97
		[NullableContext(1)]
		public static PhantomBattleMasterInfoNotify Create()
		{
			return new PhantomBattleMasterInfoNotify();
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x06011687 RID: 71303 RVA: 0x0028D89E File Offset: 0x0028BA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x06011688 RID: 71304 RVA: 0x0028D8A1 File Offset: 0x0028BAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011689 RID: 71305 RVA: 0x0028D8A8 File Offset: 0x0028BAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify()
		{
		}

		// Token: 0x0601168A RID: 71306 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify(PhantomBattleMasterInfoNotify other) : this()
		{
			this.phantomBattleMasterInfo_ = ((other.phantomBattleMasterInfo_ != null) ? other.phantomBattleMasterInfo_.Clone() : null);
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601168B RID: 71307 RVA: 0x0028D8FC File Offset: 0x0028BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify Clone()
		{
			return new PhantomBattleMasterInfoNotify(this);
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0601168C RID: 71308 RVA: 0x0028D904 File Offset: 0x0028BB04
		// (set) Token: 0x0601168D RID: 71309 RVA: 0x0028D90C File Offset: 0x0028BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo PhantomBattleMasterInfo
		{
			get
			{
				return this.phantomBattleMasterInfo_;
			}
			set
			{
				this.phantomBattleMasterInfo_ = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0601168E RID: 71310 RVA: 0x0028D915 File Offset: 0x0028BB15
		// (set) Token: 0x0601168F RID: 71311 RVA: 0x0028D91D File Offset: 0x0028BB1D
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

		// Token: 0x06011690 RID: 71312 RVA: 0x0028D926 File Offset: 0x0028BB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterInfoNotify);
		}

		// Token: 0x06011691 RID: 71313 RVA: 0x0028D934 File Offset: 0x0028BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleMasterInfo, other.PhantomBattleMasterInfo) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011692 RID: 71314 RVA: 0x0028D984 File Offset: 0x0028BB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleMasterInfo_ != null)
			{
				num ^= this.PhantomBattleMasterInfo.GetHashCode();
			}
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

		// Token: 0x06011693 RID: 71315 RVA: 0x0028D9D9 File Offset: 0x0028BBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011694 RID: 71316 RVA: 0x0028D9E6 File Offset: 0x0028BBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011695 RID: 71317 RVA: 0x0028D9F0 File Offset: 0x0028BBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleMasterInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomBattleMasterInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011696 RID: 71318 RVA: 0x0028DA4C File Offset: 0x0028BC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleMasterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleMasterInfo);
			}
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

		// Token: 0x06011697 RID: 71319 RVA: 0x0028DAA4 File Offset: 0x0028BCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleMasterInfo_ != null)
			{
				if (this.phantomBattleMasterInfo_ == null)
				{
					this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
				}
				this.PhantomBattleMasterInfo.MergeFrom(other.PhantomBattleMasterInfo);
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011698 RID: 71320 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011699 RID: 71321 RVA: 0x0028DB18 File Offset: 0x0028BD18
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
				if (num != 66U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleMasterInfo_ == null)
					{
						this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
					}
					input.ReadMessage(this.PhantomBattleMasterInfo);
				}
			}
		}

		// Token: 0x04006E56 RID: 28246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E57 RID: 28247
		public const int PhantomBattleMasterInfoFieldNumber = 8;

		// Token: 0x04006E58 RID: 28248
		private PhantomBattleMasterInfo phantomBattleMasterInfo_;

		// Token: 0x04006E59 RID: 28249
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04006E5A RID: 28250
		private int activityId_;
	}
}
