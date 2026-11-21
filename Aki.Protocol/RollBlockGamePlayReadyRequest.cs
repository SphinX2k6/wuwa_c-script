using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001115 RID: 4373
	[NetMessage(EMessageId.RollBlockGamePlayReadyRequest)]
	public sealed class RollBlockGamePlayReadyRequest : IMessage<RollBlockGamePlayReadyRequest>, IMessage, IEquatable<RollBlockGamePlayReadyRequest>, IDeepCloneable<RollBlockGamePlayReadyRequest>, IBufferMessage
	{
		// Token: 0x060175FE RID: 95742 RVA: 0x00366D10 File Offset: 0x00364F10
		[NullableContext(1)]
		public static RollBlockGamePlayReadyRequest Create()
		{
			return new RollBlockGamePlayReadyRequest();
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x060175FF RID: 95743 RVA: 0x00366D17 File Offset: 0x00364F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x06017600 RID: 95744 RVA: 0x00366D1A File Offset: 0x00364F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayReadyRequest.Descriptor;
			}
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x00366D21 File Offset: 0x00364F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest()
		{
		}

		// Token: 0x06017602 RID: 95746 RVA: 0x00366D29 File Offset: 0x00364F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest(RollBlockGamePlayReadyRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017603 RID: 95747 RVA: 0x00366D4E File Offset: 0x00364F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest Clone()
		{
			return new RollBlockGamePlayReadyRequest(this);
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x06017604 RID: 95748 RVA: 0x00366D56 File Offset: 0x00364F56
		// (set) Token: 0x06017605 RID: 95749 RVA: 0x00366D5E File Offset: 0x00364F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06017606 RID: 95750 RVA: 0x00366D67 File Offset: 0x00364F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayReadyRequest);
		}

		// Token: 0x06017607 RID: 95751 RVA: 0x00366D75 File Offset: 0x00364F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayReadyRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017608 RID: 95752 RVA: 0x00366DA4 File Offset: 0x00364FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017609 RID: 95753 RVA: 0x00366DE3 File Offset: 0x00364FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601760A RID: 95754 RVA: 0x00366DF0 File Offset: 0x00364FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601760B RID: 95755 RVA: 0x00366DF9 File Offset: 0x00364FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601760C RID: 95756 RVA: 0x00366E2C File Offset: 0x0036502C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601760D RID: 95757 RVA: 0x00366E6A File Offset: 0x0036506A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayReadyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601760E RID: 95758 RVA: 0x00366E9B File Offset: 0x0036509B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x00366EA4 File Offset: 0x003650A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BAC RID: 35756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BAD RID: 35757
		public const int IncIdFieldNumber = 4;

		// Token: 0x04008BAE RID: 35758
		private int incId_;
	}
}
