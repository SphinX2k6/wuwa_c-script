using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014F RID: 335
	[NetMessage(EMessageId.BabelTowerSelfPassRequest)]
	public sealed class BabelTowerSelfPassRequest : IMessage<BabelTowerSelfPassRequest>, IMessage, IEquatable<BabelTowerSelfPassRequest>, IDeepCloneable<BabelTowerSelfPassRequest>, IBufferMessage
	{
		// Token: 0x06002ABF RID: 10943 RVA: 0x0006FEEA File Offset: 0x0006E0EA
		[NullableContext(1)]
		public static BabelTowerSelfPassRequest Create()
		{
			return new BabelTowerSelfPassRequest();
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0006FEF1 File Offset: 0x0006E0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0006FEFB File Offset: 0x0006E0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest()
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x0006FF03 File Offset: 0x0006E103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest(BabelTowerSelfPassRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x0006FF28 File Offset: 0x0006E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassRequest Clone()
		{
			return new BabelTowerSelfPassRequest(this);
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0006FF30 File Offset: 0x0006E130
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0006FF38 File Offset: 0x0006E138
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

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0006FF41 File Offset: 0x0006E141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSelfPassRequest);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0006FF4F File Offset: 0x0006E14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSelfPassRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0006FF80 File Offset: 0x0006E180
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

		// Token: 0x06002ACA RID: 10954 RVA: 0x0006FFBF File Offset: 0x0006E1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0006FFCC File Offset: 0x0006E1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0006FFD5 File Offset: 0x0006E1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x00070008 File Offset: 0x0006E208
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

		// Token: 0x06002ACE RID: 10958 RVA: 0x00070046 File Offset: 0x0006E246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSelfPassRequest other)
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

		// Token: 0x06002ACF RID: 10959 RVA: 0x00070077 File Offset: 0x0006E277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00070080 File Offset: 0x0006E280
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002779 RID: 10105
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400277A RID: 10106
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400277B RID: 10107
		private int activityId_;
	}
}
