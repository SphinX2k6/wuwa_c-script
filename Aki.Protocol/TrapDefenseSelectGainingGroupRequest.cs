using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001444 RID: 5188
	[NetMessage(EMessageId.TrapDefenseSelectGainingGroupRequest)]
	public sealed class TrapDefenseSelectGainingGroupRequest : IMessage<TrapDefenseSelectGainingGroupRequest>, IMessage, IEquatable<TrapDefenseSelectGainingGroupRequest>, IDeepCloneable<TrapDefenseSelectGainingGroupRequest>, IBufferMessage
	{
		// Token: 0x0601B7A8 RID: 112552 RVA: 0x003FA7D9 File Offset: 0x003F89D9
		[NullableContext(1)]
		public static TrapDefenseSelectGainingGroupRequest Create()
		{
			return new TrapDefenseSelectGainingGroupRequest();
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0601B7A9 RID: 112553 RVA: 0x003FA7E0 File Offset: 0x003F89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0601B7AA RID: 112554 RVA: 0x003FA7E3 File Offset: 0x003F89E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSelectGainingGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601B7AB RID: 112555 RVA: 0x003FA7EA File Offset: 0x003F89EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest()
		{
		}

		// Token: 0x0601B7AC RID: 112556 RVA: 0x003FA7F2 File Offset: 0x003F89F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest(TrapDefenseSelectGainingGroupRequest other) : this()
		{
			this.gainingGroupId_ = other.gainingGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7AD RID: 112557 RVA: 0x003FA817 File Offset: 0x003F8A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest Clone()
		{
			return new TrapDefenseSelectGainingGroupRequest(this);
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0601B7AE RID: 112558 RVA: 0x003FA81F File Offset: 0x003F8A1F
		// (set) Token: 0x0601B7AF RID: 112559 RVA: 0x003FA827 File Offset: 0x003F8A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainingGroupId
		{
			get
			{
				return this.gainingGroupId_;
			}
			set
			{
				this.gainingGroupId_ = value;
			}
		}

		// Token: 0x0601B7B0 RID: 112560 RVA: 0x003FA830 File Offset: 0x003F8A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSelectGainingGroupRequest);
		}

		// Token: 0x0601B7B1 RID: 112561 RVA: 0x003FA83E File Offset: 0x003F8A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSelectGainingGroupRequest other)
		{
			return other != null && (other == this || (this.GainingGroupId == other.GainingGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7B2 RID: 112562 RVA: 0x003FA86C File Offset: 0x003F8A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GainingGroupId != 0)
			{
				num ^= this.GainingGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7B3 RID: 112563 RVA: 0x003FA8AB File Offset: 0x003F8AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7B4 RID: 112564 RVA: 0x003FA8B8 File Offset: 0x003F8AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7B5 RID: 112565 RVA: 0x003FA8C1 File Offset: 0x003F8AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GainingGroupId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GainingGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7B6 RID: 112566 RVA: 0x003FA8F4 File Offset: 0x003F8AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GainingGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainingGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7B7 RID: 112567 RVA: 0x003FA932 File Offset: 0x003F8B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSelectGainingGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GainingGroupId != 0)
			{
				this.GainingGroupId = other.GainingGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7B8 RID: 112568 RVA: 0x003FA963 File Offset: 0x003F8B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7B9 RID: 112569 RVA: 0x003FA96C File Offset: 0x003F8B6C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GainingGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E8A RID: 40586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E8B RID: 40587
		public const int GainingGroupIdFieldNumber = 8;

		// Token: 0x04009E8C RID: 40588
		private int gainingGroupId_;
	}
}
