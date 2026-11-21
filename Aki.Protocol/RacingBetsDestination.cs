using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E48 RID: 3656
	public sealed class RacingBetsDestination : IMessage<RacingBetsDestination>, IMessage, IEquatable<RacingBetsDestination>, IDeepCloneable<RacingBetsDestination>, IBufferMessage
	{
		// Token: 0x06013A7D RID: 80509 RVA: 0x002DBFE0 File Offset: 0x002DA1E0
		[NullableContext(1)]
		public static RacingBetsDestination Create()
		{
			return new RacingBetsDestination();
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x06013A7E RID: 80510 RVA: 0x002DBFE7 File Offset: 0x002DA1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x06013A7F RID: 80511 RVA: 0x002DBFEA File Offset: 0x002DA1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDestination.Descriptor;
			}
		}

		// Token: 0x06013A80 RID: 80512 RVA: 0x002DBFF1 File Offset: 0x002DA1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination()
		{
		}

		// Token: 0x06013A81 RID: 80513 RVA: 0x002DBFF9 File Offset: 0x002DA1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination(RacingBetsDestination other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A82 RID: 80514 RVA: 0x002DC01E File Offset: 0x002DA21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination Clone()
		{
			return new RacingBetsDestination(this);
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x06013A83 RID: 80515 RVA: 0x002DC026 File Offset: 0x002DA226
		// (set) Token: 0x06013A84 RID: 80516 RVA: 0x002DC02E File Offset: 0x002DA22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x06013A85 RID: 80517 RVA: 0x002DC037 File Offset: 0x002DA237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDestination);
		}

		// Token: 0x06013A86 RID: 80518 RVA: 0x002DC045 File Offset: 0x002DA245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDestination other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A87 RID: 80519 RVA: 0x002DC074 File Offset: 0x002DA274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A88 RID: 80520 RVA: 0x002DC0B3 File Offset: 0x002DA2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A89 RID: 80521 RVA: 0x002DC0C0 File Offset: 0x002DA2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A8A RID: 80522 RVA: 0x002DC0C9 File Offset: 0x002DA2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A8B RID: 80523 RVA: 0x002DC0FC File Offset: 0x002DA2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A8C RID: 80524 RVA: 0x002DC13A File Offset: 0x002DA33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDestination other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A8D RID: 80525 RVA: 0x002DC16B File Offset: 0x002DA36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A8E RID: 80526 RVA: 0x002DC174 File Offset: 0x002DA374
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
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078B7 RID: 30903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078B8 RID: 30904
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040078B9 RID: 30905
		private int dangoId_;
	}
}
