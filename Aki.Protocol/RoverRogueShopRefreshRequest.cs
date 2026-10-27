using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001126 RID: 4390
	[NetMessage(EMessageId.RoverRogueShopRefreshRequest)]
	public sealed class RoverRogueShopRefreshRequest : IMessage<RoverRogueShopRefreshRequest>, IMessage, IEquatable<RoverRogueShopRefreshRequest>, IDeepCloneable<RoverRogueShopRefreshRequest>, IBufferMessage
	{
		// Token: 0x060176B8 RID: 95928 RVA: 0x00366EDC File Offset: 0x003650DC
		[NullableContext(1)]
		public static RoverRogueShopRefreshRequest Create()
		{
			return new RoverRogueShopRefreshRequest();
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x060176B9 RID: 95929 RVA: 0x00366EE3 File Offset: 0x003650E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x060176BA RID: 95930 RVA: 0x00366EE6 File Offset: 0x003650E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopRefreshRequest.Descriptor;
			}
		}

		// Token: 0x060176BB RID: 95931 RVA: 0x00366EED File Offset: 0x003650ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest()
		{
		}

		// Token: 0x060176BC RID: 95932 RVA: 0x00366EF5 File Offset: 0x003650F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest(RoverRogueShopRefreshRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176BD RID: 95933 RVA: 0x00366F1A File Offset: 0x0036511A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest Clone()
		{
			return new RoverRogueShopRefreshRequest(this);
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x060176BE RID: 95934 RVA: 0x00366F22 File Offset: 0x00365122
		// (set) Token: 0x060176BF RID: 95935 RVA: 0x00366F2A File Offset: 0x0036512A
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

		// Token: 0x060176C0 RID: 95936 RVA: 0x00366F33 File Offset: 0x00365133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopRefreshRequest);
		}

		// Token: 0x060176C1 RID: 95937 RVA: 0x00366F41 File Offset: 0x00365141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopRefreshRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176C2 RID: 95938 RVA: 0x00366F70 File Offset: 0x00365170
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

		// Token: 0x060176C3 RID: 95939 RVA: 0x00366FAF File Offset: 0x003651AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176C4 RID: 95940 RVA: 0x00366FBC File Offset: 0x003651BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176C5 RID: 95941 RVA: 0x00366FC5 File Offset: 0x003651C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176C6 RID: 95942 RVA: 0x00366FF8 File Offset: 0x003651F8
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

		// Token: 0x060176C7 RID: 95943 RVA: 0x00367036 File Offset: 0x00365236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopRefreshRequest other)
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

		// Token: 0x060176C8 RID: 95944 RVA: 0x00367067 File Offset: 0x00365267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x00367070 File Offset: 0x00365270
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B4D RID: 35661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B4E RID: 35662
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04008B4F RID: 35663
		private int activityId_;
	}
}
