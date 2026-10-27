using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000080 RID: 128
	[NetMessage(EMessageId.ActiveDragonPoolResponse)]
	public sealed class ActiveDragonPoolResponse : IMessage<ActiveDragonPoolResponse>, IMessage, IEquatable<ActiveDragonPoolResponse>, IDeepCloneable<ActiveDragonPoolResponse>, IBufferMessage
	{
		// Token: 0x060018B9 RID: 6329 RVA: 0x000408D5 File Offset: 0x0003EAD5
		[NullableContext(1)]
		public static ActiveDragonPoolResponse Create()
		{
			return new ActiveDragonPoolResponse();
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x000408DC File Offset: 0x0003EADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000408DF File Offset: 0x0003EADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveDragonPoolResponse.Descriptor;
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000408E6 File Offset: 0x0003EAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse()
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000408EE File Offset: 0x0003EAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse(ActiveDragonPoolResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolId_ = other.dragonPoolId_;
			this.activeStatus_ = other.activeStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0004092B File Offset: 0x0003EB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolResponse Clone()
		{
			return new ActiveDragonPoolResponse(this);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00040933 File Offset: 0x0003EB33
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0004093B File Offset: 0x0003EB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00040944 File Offset: 0x0003EB44
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0004094C File Offset: 0x0003EB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00040955 File Offset: 0x0003EB55
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0004095D File Offset: 0x0003EB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveStatus
		{
			get
			{
				return this.activeStatus_;
			}
			set
			{
				this.activeStatus_ = value;
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00040966 File Offset: 0x0003EB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveDragonPoolResponse);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00040974 File Offset: 0x0003EB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveDragonPoolResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DragonPoolId == other.DragonPoolId && this.ActiveStatus == other.ActiveStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000409D0 File Offset: 0x0003EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.ActiveStatus != 0)
			{
				num ^= this.ActiveStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00040A47 File Offset: 0x0003EC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00040A54 File Offset: 0x0003EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00040A60 File Offset: 0x0003EC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActiveStatus != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActiveStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00040AD4 File Offset: 0x0003ECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.ActiveStatus != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00040B44 File Offset: 0x0003ED44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActiveDragonPoolResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.ActiveStatus != 0)
			{
				this.ActiveStatus = other.ActiveStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00040BA8 File Offset: 0x0003EDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00040BB4 File Offset: 0x0003EDB4
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
				if (num != 8U)
				{
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActiveStatus = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400218F RID: 8591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002190 RID: 8592
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002191 RID: 8593
		private ErrorCode errorCode_;

		// Token: 0x04002192 RID: 8594
		public const int DragonPoolIdFieldNumber = 1;

		// Token: 0x04002193 RID: 8595
		private int dragonPoolId_;

		// Token: 0x04002194 RID: 8596
		public const int ActiveStatusFieldNumber = 14;

		// Token: 0x04002195 RID: 8597
		private int activeStatus_;
	}
}
