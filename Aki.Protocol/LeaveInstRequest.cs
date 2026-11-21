using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D9 RID: 2265
	[NetMessage(EMessageId.LeaveInstRequest)]
	public sealed class LeaveInstRequest : IMessage<LeaveInstRequest>, IMessage, IEquatable<LeaveInstRequest>, IDeepCloneable<LeaveInstRequest>, IBufferMessage
	{
		// Token: 0x0600C8BC RID: 51388 RVA: 0x001DAC50 File Offset: 0x001D8E50
		[NullableContext(1)]
		public static LeaveInstRequest Create()
		{
			return new LeaveInstRequest();
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600C8BD RID: 51389 RVA: 0x001DAC57 File Offset: 0x001D8E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600C8BE RID: 51390 RVA: 0x001DAC5A File Offset: 0x001D8E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstRequest.Descriptor;
			}
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x001DAC61 File Offset: 0x001D8E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest()
		{
		}

		// Token: 0x0600C8C0 RID: 51392 RVA: 0x001DAC69 File Offset: 0x001D8E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest(LeaveInstRequest other) : this()
		{
			this.posEntityId_ = other.posEntityId_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x001DAC9A File Offset: 0x001D8E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest Clone()
		{
			return new LeaveInstRequest(this);
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600C8C2 RID: 51394 RVA: 0x001DACA2 File Offset: 0x001D8EA2
		// (set) Token: 0x0600C8C3 RID: 51395 RVA: 0x001DACAA File Offset: 0x001D8EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosEntityId
		{
			get
			{
				return this.posEntityId_;
			}
			set
			{
				this.posEntityId_ = value;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600C8C4 RID: 51396 RVA: 0x001DACB3 File Offset: 0x001D8EB3
		// (set) Token: 0x0600C8C5 RID: 51397 RVA: 0x001DACBB File Offset: 0x001D8EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstWay Way
		{
			get
			{
				return this.way_;
			}
			set
			{
				this.way_ = value;
			}
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x001DACC4 File Offset: 0x001D8EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstRequest);
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x001DACD2 File Offset: 0x001D8ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstRequest other)
		{
			return other != null && (other == this || (this.PosEntityId == other.PosEntityId && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x001DAD10 File Offset: 0x001D8F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PosEntityId != 0)
			{
				num ^= this.PosEntityId.GetHashCode();
			}
			if (this.Way != LeaveInstWay.Default)
			{
				num ^= this.Way.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x001DAD6E File Offset: 0x001D8F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x001DAD7B File Offset: 0x001D8F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x001DAD84 File Offset: 0x001D8F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PosEntityId);
			}
			if (this.Way != LeaveInstWay.Default)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x001DADE0 File Offset: 0x001D8FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PosEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosEntityId);
			}
			if (this.Way != LeaveInstWay.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x001DAE38 File Offset: 0x001D9038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PosEntityId != 0)
			{
				this.PosEntityId = other.PosEntityId;
			}
			if (other.Way != LeaveInstWay.Default)
			{
				this.Way = other.Way;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x001DAE88 File Offset: 0x001D9088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x001DAE94 File Offset: 0x001D9094
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Way = (LeaveInstWay)input.ReadEnum();
					}
				}
				else
				{
					this.PosEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400560E RID: 22030
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400560F RID: 22031
		public const int PosEntityIdFieldNumber = 4;

		// Token: 0x04005610 RID: 22032
		private int posEntityId_;

		// Token: 0x04005611 RID: 22033
		public const int WayFieldNumber = 15;

		// Token: 0x04005612 RID: 22034
		private LeaveInstWay way_;
	}
}
