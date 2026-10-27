using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D1 RID: 4561
	[NetMessage(EMessageId.SetFanStateRequest)]
	public sealed class SetFanStateRequest : IMessage<SetFanStateRequest>, IMessage, IEquatable<SetFanStateRequest>, IDeepCloneable<SetFanStateRequest>, IBufferMessage
	{
		// Token: 0x06018536 RID: 99638 RVA: 0x0038A185 File Offset: 0x00388385
		[NullableContext(1)]
		public static SetFanStateRequest Create()
		{
			return new SetFanStateRequest();
		}

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x06018537 RID: 99639 RVA: 0x0038A18C File Offset: 0x0038838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x06018538 RID: 99640 RVA: 0x0038A18F File Offset: 0x0038838F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanStateRequest.Descriptor;
			}
		}

		// Token: 0x06018539 RID: 99641 RVA: 0x0038A196 File Offset: 0x00388396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest()
		{
		}

		// Token: 0x0601853A RID: 99642 RVA: 0x0038A19E File Offset: 0x0038839E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest(SetFanStateRequest other) : this()
		{
			this.fanEntityId_ = other.fanEntityId_;
			this.isActive_ = other.isActive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601853B RID: 99643 RVA: 0x0038A1CF File Offset: 0x003883CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateRequest Clone()
		{
			return new SetFanStateRequest(this);
		}

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x0601853C RID: 99644 RVA: 0x0038A1D7 File Offset: 0x003883D7
		// (set) Token: 0x0601853D RID: 99645 RVA: 0x0038A1DF File Offset: 0x003883DF
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

		// Token: 0x170051EF RID: 20975
		// (get) Token: 0x0601853E RID: 99646 RVA: 0x0038A1E8 File Offset: 0x003883E8
		// (set) Token: 0x0601853F RID: 99647 RVA: 0x0038A1F0 File Offset: 0x003883F0
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

		// Token: 0x06018540 RID: 99648 RVA: 0x0038A1F9 File Offset: 0x003883F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanStateRequest);
		}

		// Token: 0x06018541 RID: 99649 RVA: 0x0038A207 File Offset: 0x00388407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanStateRequest other)
		{
			return other != null && (other == this || (this.FanEntityId == other.FanEntityId && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018542 RID: 99650 RVA: 0x0038A248 File Offset: 0x00388448
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

		// Token: 0x06018543 RID: 99651 RVA: 0x0038A2A0 File Offset: 0x003884A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018544 RID: 99652 RVA: 0x0038A2AD File Offset: 0x003884AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018545 RID: 99653 RVA: 0x0038A2B8 File Offset: 0x003884B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FanEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.FanEntityId);
			}
			if (this.IsActive != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018546 RID: 99654 RVA: 0x0038A314 File Offset: 0x00388514
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

		// Token: 0x06018547 RID: 99655 RVA: 0x0038A36C File Offset: 0x0038856C
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

		// Token: 0x06018548 RID: 99656 RVA: 0x0038A3BC File Offset: 0x003885BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018549 RID: 99657 RVA: 0x0038A3C8 File Offset: 0x003885C8
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
					if (num != 104U)
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

		// Token: 0x04009007 RID: 36871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009008 RID: 36872
		public const int FanEntityIdFieldNumber = 11;

		// Token: 0x04009009 RID: 36873
		private long fanEntityId_;

		// Token: 0x0400900A RID: 36874
		public const int IsActiveFieldNumber = 13;

		// Token: 0x0400900B RID: 36875
		private int isActive_;
	}
}
