using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104C RID: 4172
	public sealed class RogueWhiteCatCtx : IMessage<RogueWhiteCatCtx>, IMessage, IEquatable<RogueWhiteCatCtx>, IDeepCloneable<RogueWhiteCatCtx>, IBufferMessage
	{
		// Token: 0x060164AF RID: 91311 RVA: 0x0033D178 File Offset: 0x0033B378
		[NullableContext(1)]
		public static RogueWhiteCatCtx Create()
		{
			return new RogueWhiteCatCtx();
		}

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x060164B0 RID: 91312 RVA: 0x0033D17F File Offset: 0x0033B37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x060164B1 RID: 91313 RVA: 0x0033D182 File Offset: 0x0033B382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatCtx.Descriptor;
			}
		}

		// Token: 0x060164B2 RID: 91314 RVA: 0x0033D189 File Offset: 0x0033B389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx()
		{
		}

		// Token: 0x060164B3 RID: 91315 RVA: 0x0033D191 File Offset: 0x0033B391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx(RogueWhiteCatCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.isFirst_ = other.isFirst_;
			this.idnex_ = other.idnex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164B4 RID: 91316 RVA: 0x0033D1CE File Offset: 0x0033B3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx Clone()
		{
			return new RogueWhiteCatCtx(this);
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x060164B5 RID: 91317 RVA: 0x0033D1D6 File Offset: 0x0033B3D6
		// (set) Token: 0x060164B6 RID: 91318 RVA: 0x0033D1DE File Offset: 0x0033B3DE
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

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x060164B7 RID: 91319 RVA: 0x0033D1E7 File Offset: 0x0033B3E7
		// (set) Token: 0x060164B8 RID: 91320 RVA: 0x0033D1EF File Offset: 0x0033B3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirst
		{
			get
			{
				return this.isFirst_;
			}
			set
			{
				this.isFirst_ = value;
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x060164B9 RID: 91321 RVA: 0x0033D1F8 File Offset: 0x0033B3F8
		// (set) Token: 0x060164BA RID: 91322 RVA: 0x0033D200 File Offset: 0x0033B400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Idnex
		{
			get
			{
				return this.idnex_;
			}
			set
			{
				this.idnex_ = value;
			}
		}

		// Token: 0x060164BB RID: 91323 RVA: 0x0033D209 File Offset: 0x0033B409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatCtx);
		}

		// Token: 0x060164BC RID: 91324 RVA: 0x0033D218 File Offset: 0x0033B418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.IsFirst == other.IsFirst && this.Idnex == other.Idnex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164BD RID: 91325 RVA: 0x0033D274 File Offset: 0x0033B474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.IsFirst)
			{
				num ^= this.IsFirst.GetHashCode();
			}
			if (this.Idnex != 0)
			{
				num ^= this.Idnex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060164BE RID: 91326 RVA: 0x0033D2E5 File Offset: 0x0033B4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164BF RID: 91327 RVA: 0x0033D2F2 File Offset: 0x0033B4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164C0 RID: 91328 RVA: 0x0033D2FC File Offset: 0x0033B4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.IsFirst)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsFirst);
			}
			if (this.Idnex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Idnex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164C1 RID: 91329 RVA: 0x0033D370 File Offset: 0x0033B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.IsFirst)
			{
				num += 2;
			}
			if (this.Idnex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Idnex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060164C2 RID: 91330 RVA: 0x0033D3D4 File Offset: 0x0033B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.IsFirst)
			{
				this.IsFirst = other.IsFirst;
			}
			if (other.Idnex != 0)
			{
				this.Idnex = other.Idnex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060164C3 RID: 91331 RVA: 0x0033D438 File Offset: 0x0033B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164C4 RID: 91332 RVA: 0x0033D444 File Offset: 0x0033B644
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Idnex = input.ReadInt32();
						}
					}
					else
					{
						this.IsFirst = input.ReadBool();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008555 RID: 34133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008556 RID: 34134
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008557 RID: 34135
		private int activityId_;

		// Token: 0x04008558 RID: 34136
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04008559 RID: 34137
		private bool isFirst_;

		// Token: 0x0400855A RID: 34138
		public const int IdnexFieldNumber = 3;

		// Token: 0x0400855B RID: 34139
		private int idnex_;
	}
}
