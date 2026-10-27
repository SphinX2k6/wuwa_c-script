using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104F RID: 4175
	[NetMessage(EMessageId.RogueWhiteCatLimitedRewardRequest)]
	public sealed class RogueWhiteCatLimitedRewardRequest : IMessage<RogueWhiteCatLimitedRewardRequest>, IMessage, IEquatable<RogueWhiteCatLimitedRewardRequest>, IDeepCloneable<RogueWhiteCatLimitedRewardRequest>, IBufferMessage
	{
		// Token: 0x060164FA RID: 91386 RVA: 0x0033E183 File Offset: 0x0033C383
		[NullableContext(1)]
		public static RogueWhiteCatLimitedRewardRequest Create()
		{
			return new RogueWhiteCatLimitedRewardRequest();
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x060164FB RID: 91387 RVA: 0x0033E18A File Offset: 0x0033C38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x060164FC RID: 91388 RVA: 0x0033E18D File Offset: 0x0033C38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedRewardRequest.Descriptor;
			}
		}

		// Token: 0x060164FD RID: 91389 RVA: 0x0033E194 File Offset: 0x0033C394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest()
		{
		}

		// Token: 0x060164FE RID: 91390 RVA: 0x0033E19C File Offset: 0x0033C39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest(RogueWhiteCatLimitedRewardRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164FF RID: 91391 RVA: 0x0033E1C1 File Offset: 0x0033C3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest Clone()
		{
			return new RogueWhiteCatLimitedRewardRequest(this);
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x06016500 RID: 91392 RVA: 0x0033E1C9 File Offset: 0x0033C3C9
		// (set) Token: 0x06016501 RID: 91393 RVA: 0x0033E1D1 File Offset: 0x0033C3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06016502 RID: 91394 RVA: 0x0033E1DA File Offset: 0x0033C3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedRewardRequest);
		}

		// Token: 0x06016503 RID: 91395 RVA: 0x0033E1E8 File Offset: 0x0033C3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedRewardRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016504 RID: 91396 RVA: 0x0033E218 File Offset: 0x0033C418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016505 RID: 91397 RVA: 0x0033E257 File Offset: 0x0033C457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016506 RID: 91398 RVA: 0x0033E264 File Offset: 0x0033C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016507 RID: 91399 RVA: 0x0033E26D File Offset: 0x0033C46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016508 RID: 91400 RVA: 0x0033E2A0 File Offset: 0x0033C4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016509 RID: 91401 RVA: 0x0033E2DE File Offset: 0x0033C4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatLimitedRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601650A RID: 91402 RVA: 0x0033E30F File Offset: 0x0033C50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601650B RID: 91403 RVA: 0x0033E318 File Offset: 0x0033C518
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008582 RID: 34178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008583 RID: 34179
		public const int IndexFieldNumber = 6;

		// Token: 0x04008584 RID: 34180
		private int index_;
	}
}
