using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120B RID: 4619
	[NetMessage(EMessageId.SetFanStateRequest)]
	public sealed class SetFanStateRequest : IMessage<SetFanStateRequest>, IMessage, IEquatable<SetFanStateRequest>, IDeepCloneable<SetFanStateRequest>, IBufferMessage
	{
		// Token: 0x06018AD7 RID: 101079 RVA: 0x003994B8 File Offset: 0x003976B8
		[NullableContext(1)]
		public static SetFanStateRequest Create()
		{
			return new SetFanStateRequest();
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x06018AD8 RID: 101080 RVA: 0x003994BF File Offset: 0x003976BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x06018AD9 RID: 101081 RVA: 0x003994C2 File Offset: 0x003976C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanStateRequest.Descriptor;
			}
		}

		// Token: 0x06018ADA RID: 101082 RVA: 0x003994C9 File Offset: 0x003976C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest()
		{
		}

		// Token: 0x06018ADB RID: 101083 RVA: 0x003994D1 File Offset: 0x003976D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest(SetFanStateRequest other) : this()
		{
			this.fanEntityId_ = other.fanEntityId_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x00399502 File Offset: 0x00397702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest Clone()
		{
			return new SetFanStateRequest(this);
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x06018ADD RID: 101085 RVA: 0x0039950A File Offset: 0x0039770A
		// (set) Token: 0x06018ADE RID: 101086 RVA: 0x00399512 File Offset: 0x00397712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FanEntityId
		{
			get
			{
				return this.fanEntityId_;
			}
			set
			{
				this.fanEntityId_ = value;
			}
		}

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x06018ADF RID: 101087 RVA: 0x0039951B File Offset: 0x0039771B
		// (set) Token: 0x06018AE0 RID: 101088 RVA: 0x00399523 File Offset: 0x00397723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x06018AE1 RID: 101089 RVA: 0x0039952C File Offset: 0x0039772C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanStateRequest);
		}

		// Token: 0x06018AE2 RID: 101090 RVA: 0x0039953A File Offset: 0x0039773A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanStateRequest other)
		{
			return other != null && (other == this || (this.FanEntityId == other.FanEntityId && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AE3 RID: 101091 RVA: 0x00399578 File Offset: 0x00397778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FanEntityId != 0L)
			{
				num ^= this.FanEntityId.GetHashCode();
			}
			if (this.IsActive != 0)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AE4 RID: 101092 RVA: 0x003995D0 File Offset: 0x003977D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AE5 RID: 101093 RVA: 0x003995DD File Offset: 0x003977DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AE6 RID: 101094 RVA: 0x003995E8 File Offset: 0x003977E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FanEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.FanEntityId);
			}
			if (this.IsActive != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AE7 RID: 101095 RVA: 0x00399644 File Offset: 0x00397844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FanEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FanEntityId);
			}
			if (this.IsActive != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AE8 RID: 101096 RVA: 0x0039969C File Offset: 0x0039789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FanEntityId != 0L)
			{
				this.FanEntityId = other.FanEntityId;
			}
			if (other.IsActive != 0)
			{
				this.IsActive = other.IsActive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AE9 RID: 101097 RVA: 0x003996EC File Offset: 0x003978EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AEA RID: 101098 RVA: 0x003996F8 File Offset: 0x003978F8
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsActive = input.ReadInt32();
					}
				}
				else
				{
					this.FanEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400929A RID: 37530
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400929B RID: 37531
		public const int FanEntityIdFieldNumber = 4;

		// Token: 0x0400929C RID: 37532
		private long fanEntityId_;

		// Token: 0x0400929D RID: 37533
		public const int IsActiveFieldNumber = 12;

		// Token: 0x0400929E RID: 37534
		private int isActive_;
	}
}
