using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103C RID: 4156
	public sealed class RogueWhiteCatCtx : IMessage<RogueWhiteCatCtx>, IMessage, IEquatable<RogueWhiteCatCtx>, IDeepCloneable<RogueWhiteCatCtx>, IBufferMessage
	{
		// Token: 0x060163CA RID: 91082 RVA: 0x0033BAAC File Offset: 0x00339CAC
		[NullableContext(1)]
		public static RogueWhiteCatCtx Create()
		{
			return new RogueWhiteCatCtx();
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x060163CB RID: 91083 RVA: 0x0033BAB3 File Offset: 0x00339CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x060163CC RID: 91084 RVA: 0x0033BAB6 File Offset: 0x00339CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatCtx.Descriptor;
			}
		}

		// Token: 0x060163CD RID: 91085 RVA: 0x0033BABD File Offset: 0x00339CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx()
		{
		}

		// Token: 0x060163CE RID: 91086 RVA: 0x0033BAC5 File Offset: 0x00339CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx(RogueWhiteCatCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.isFirst_ = other.isFirst_;
			this.idnex_ = other.idnex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163CF RID: 91087 RVA: 0x0033BB02 File Offset: 0x00339D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx Clone()
		{
			return new RogueWhiteCatCtx(this);
		}

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x060163D0 RID: 91088 RVA: 0x0033BB0A File Offset: 0x00339D0A
		// (set) Token: 0x060163D1 RID: 91089 RVA: 0x0033BB12 File Offset: 0x00339D12
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

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x060163D2 RID: 91090 RVA: 0x0033BB1B File Offset: 0x00339D1B
		// (set) Token: 0x060163D3 RID: 91091 RVA: 0x0033BB23 File Offset: 0x00339D23
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

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x060163D4 RID: 91092 RVA: 0x0033BB2C File Offset: 0x00339D2C
		// (set) Token: 0x060163D5 RID: 91093 RVA: 0x0033BB34 File Offset: 0x00339D34
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

		// Token: 0x060163D6 RID: 91094 RVA: 0x0033BB3D File Offset: 0x00339D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatCtx);
		}

		// Token: 0x060163D7 RID: 91095 RVA: 0x0033BB4C File Offset: 0x00339D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.IsFirst == other.IsFirst && this.Idnex == other.Idnex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163D8 RID: 91096 RVA: 0x0033BBA8 File Offset: 0x00339DA8
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

		// Token: 0x060163D9 RID: 91097 RVA: 0x0033BC19 File Offset: 0x00339E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163DA RID: 91098 RVA: 0x0033BC26 File Offset: 0x00339E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163DB RID: 91099 RVA: 0x0033BC30 File Offset: 0x00339E30
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

		// Token: 0x060163DC RID: 91100 RVA: 0x0033BCA4 File Offset: 0x00339EA4
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

		// Token: 0x060163DD RID: 91101 RVA: 0x0033BD08 File Offset: 0x00339F08
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

		// Token: 0x060163DE RID: 91102 RVA: 0x0033BD6C File Offset: 0x00339F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163DF RID: 91103 RVA: 0x0033BD78 File Offset: 0x00339F78
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

		// Token: 0x0400857F RID: 34175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008580 RID: 34176
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008581 RID: 34177
		private int activityId_;

		// Token: 0x04008582 RID: 34178
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04008583 RID: 34179
		private bool isFirst_;

		// Token: 0x04008584 RID: 34180
		public const int IdnexFieldNumber = 3;

		// Token: 0x04008585 RID: 34181
		private int idnex_;
	}
}
