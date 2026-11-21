using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001587 RID: 5511
	[NetMessage(EMessageId.WellStreamingFinisRequest)]
	public sealed class WellStreamingFinisRequest : IMessage<WellStreamingFinisRequest>, IMessage, IEquatable<WellStreamingFinisRequest>, IDeepCloneable<WellStreamingFinisRequest>, IBufferMessage
	{
		// Token: 0x0601D2D0 RID: 119504 RVA: 0x0043980A File Offset: 0x00437A0A
		[NullableContext(1)]
		public static WellStreamingFinisRequest Create()
		{
			return new WellStreamingFinisRequest();
		}

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x0601D2D1 RID: 119505 RVA: 0x00439811 File Offset: 0x00437A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x0601D2D2 RID: 119506 RVA: 0x00439814 File Offset: 0x00437A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WellStreamingFinisRequest.Descriptor;
			}
		}

		// Token: 0x0601D2D3 RID: 119507 RVA: 0x0043981B File Offset: 0x00437A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest()
		{
		}

		// Token: 0x0601D2D4 RID: 119508 RVA: 0x00439823 File Offset: 0x00437A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest(WellStreamingFinisRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D2D5 RID: 119509 RVA: 0x00439848 File Offset: 0x00437A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest Clone()
		{
			return new WellStreamingFinisRequest(this);
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x0601D2D6 RID: 119510 RVA: 0x00439850 File Offset: 0x00437A50
		// (set) Token: 0x0601D2D7 RID: 119511 RVA: 0x00439858 File Offset: 0x00437A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x0601D2D8 RID: 119512 RVA: 0x00439861 File Offset: 0x00437A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WellStreamingFinisRequest);
		}

		// Token: 0x0601D2D9 RID: 119513 RVA: 0x0043986F File Offset: 0x00437A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WellStreamingFinisRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D2DA RID: 119514 RVA: 0x004398A0 File Offset: 0x00437AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D2DB RID: 119515 RVA: 0x004398DF File Offset: 0x00437ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D2DC RID: 119516 RVA: 0x004398EC File Offset: 0x00437AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D2DD RID: 119517 RVA: 0x004398F5 File Offset: 0x00437AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D2DE RID: 119518 RVA: 0x00439928 File Offset: 0x00437B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D2DF RID: 119519 RVA: 0x00439966 File Offset: 0x00437B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WellStreamingFinisRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D2E0 RID: 119520 RVA: 0x00439997 File Offset: 0x00437B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D2E1 RID: 119521 RVA: 0x004399A0 File Offset: 0x00437BA0
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
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A772 RID: 42866
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A773 RID: 42867
		public const int EntityIncIdFieldNumber = 14;

		// Token: 0x0400A774 RID: 42868
		private long entityIncId_;
	}
}
