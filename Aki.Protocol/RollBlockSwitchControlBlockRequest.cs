using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001120 RID: 4384
	[NetMessage(EMessageId.RollBlockSwitchControlBlockRequest)]
	public sealed class RollBlockSwitchControlBlockRequest : IMessage<RollBlockSwitchControlBlockRequest>, IMessage, IEquatable<RollBlockSwitchControlBlockRequest>, IDeepCloneable<RollBlockSwitchControlBlockRequest>, IBufferMessage
	{
		// Token: 0x060176CA RID: 95946 RVA: 0x00368505 File Offset: 0x00366705
		[NullableContext(1)]
		public static RollBlockSwitchControlBlockRequest Create()
		{
			return new RollBlockSwitchControlBlockRequest();
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x060176CB RID: 95947 RVA: 0x0036850C File Offset: 0x0036670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x060176CC RID: 95948 RVA: 0x0036850F File Offset: 0x0036670F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSwitchControlBlockRequest.Descriptor;
			}
		}

		// Token: 0x060176CD RID: 95949 RVA: 0x00368516 File Offset: 0x00366716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest()
		{
		}

		// Token: 0x060176CE RID: 95950 RVA: 0x0036851E File Offset: 0x0036671E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest(RollBlockSwitchControlBlockRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176CF RID: 95951 RVA: 0x00368543 File Offset: 0x00366743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest Clone()
		{
			return new RollBlockSwitchControlBlockRequest(this);
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x060176D0 RID: 95952 RVA: 0x0036854B File Offset: 0x0036674B
		// (set) Token: 0x060176D1 RID: 95953 RVA: 0x00368553 File Offset: 0x00366753
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

		// Token: 0x060176D2 RID: 95954 RVA: 0x0036855C File Offset: 0x0036675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSwitchControlBlockRequest);
		}

		// Token: 0x060176D3 RID: 95955 RVA: 0x0036856A File Offset: 0x0036676A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSwitchControlBlockRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176D4 RID: 95956 RVA: 0x00368598 File Offset: 0x00366798
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

		// Token: 0x060176D5 RID: 95957 RVA: 0x003685D7 File Offset: 0x003667D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176D6 RID: 95958 RVA: 0x003685E4 File Offset: 0x003667E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176D7 RID: 95959 RVA: 0x003685ED File Offset: 0x003667ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x00368620 File Offset: 0x00366820
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

		// Token: 0x060176D9 RID: 95961 RVA: 0x0036865E File Offset: 0x0036685E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSwitchControlBlockRequest other)
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

		// Token: 0x060176DA RID: 95962 RVA: 0x0036868F File Offset: 0x0036688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x00368698 File Offset: 0x00366898
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BD3 RID: 35795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD4 RID: 35796
		public const int IncIdFieldNumber = 14;

		// Token: 0x04008BD5 RID: 35797
		private int incId_;
	}
}
