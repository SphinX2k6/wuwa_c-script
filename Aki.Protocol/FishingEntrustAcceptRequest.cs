using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000550 RID: 1360
	[NetMessage(EMessageId.FishingEntrustAcceptRequest)]
	public sealed class FishingEntrustAcceptRequest : IMessage<FishingEntrustAcceptRequest>, IMessage, IEquatable<FishingEntrustAcceptRequest>, IDeepCloneable<FishingEntrustAcceptRequest>, IBufferMessage
	{
		// Token: 0x06007F17 RID: 32535 RVA: 0x001338D8 File Offset: 0x00131AD8
		[NullableContext(1)]
		public static FishingEntrustAcceptRequest Create()
		{
			return new FishingEntrustAcceptRequest();
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06007F18 RID: 32536 RVA: 0x001338DF File Offset: 0x00131ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06007F19 RID: 32537 RVA: 0x001338E2 File Offset: 0x00131AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustAcceptRequest.Descriptor;
			}
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x001338E9 File Offset: 0x00131AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest()
		{
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x001338F1 File Offset: 0x00131AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest(FishingEntrustAcceptRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.accept_ = other.accept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x00133922 File Offset: 0x00131B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest Clone()
		{
			return new FishingEntrustAcceptRequest(this);
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06007F1D RID: 32541 RVA: 0x0013392A File Offset: 0x00131B2A
		// (set) Token: 0x06007F1E RID: 32542 RVA: 0x00133932 File Offset: 0x00131B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x0013393B File Offset: 0x00131B3B
		// (set) Token: 0x06007F20 RID: 32544 RVA: 0x00133943 File Offset: 0x00131B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accept
		{
			get
			{
				return this.accept_;
			}
			set
			{
				this.accept_ = value;
			}
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x0013394C File Offset: 0x00131B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustAcceptRequest);
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x0013395A File Offset: 0x00131B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustAcceptRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.Accept == other.Accept && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x00133998 File Offset: 0x00131B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this.Accept)
			{
				num ^= this.Accept.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x001339F0 File Offset: 0x00131BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F25 RID: 32549 RVA: 0x001339FD File Offset: 0x00131BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x00133A08 File Offset: 0x00131C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntrustId);
			}
			if (this.Accept)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Accept);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x00133A60 File Offset: 0x00131C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this.Accept)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x00133AAC File Offset: 0x00131CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustAcceptRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			if (other.Accept)
			{
				this.Accept = other.Accept;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x00133AFC File Offset: 0x00131CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x00133B08 File Offset: 0x00131D08
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Accept = input.ReadBool();
					}
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400404D RID: 16461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400404E RID: 16462
		public const int EntrustIdFieldNumber = 1;

		// Token: 0x0400404F RID: 16463
		private int entrustId_;

		// Token: 0x04004050 RID: 16464
		public const int AcceptFieldNumber = 9;

		// Token: 0x04004051 RID: 16465
		private bool accept_;
	}
}
