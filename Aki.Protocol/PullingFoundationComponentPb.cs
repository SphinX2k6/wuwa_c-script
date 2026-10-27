using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF6 RID: 3574
	public sealed class PullingFoundationComponentPb : IMessage<PullingFoundationComponentPb>, IMessage, IEquatable<PullingFoundationComponentPb>, IDeepCloneable<PullingFoundationComponentPb>, IBufferMessage
	{
		// Token: 0x06013399 RID: 78745 RVA: 0x002CCCC9 File Offset: 0x002CAEC9
		[NullableContext(1)]
		public static PullingFoundationComponentPb Create()
		{
			return new PullingFoundationComponentPb();
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0601339A RID: 78746 RVA: 0x002CCCD0 File Offset: 0x002CAED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0601339B RID: 78747 RVA: 0x002CCCD3 File Offset: 0x002CAED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationComponentPb.Descriptor;
			}
		}

		// Token: 0x0601339C RID: 78748 RVA: 0x002CCCDA File Offset: 0x002CAEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb()
		{
		}

		// Token: 0x0601339D RID: 78749 RVA: 0x002CCCE2 File Offset: 0x002CAEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb(PullingFoundationComponentPb other) : this()
		{
			this.relationId_ = other.relationId_;
			this.matchIndex_ = other.matchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601339E RID: 78750 RVA: 0x002CCD13 File Offset: 0x002CAF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb Clone()
		{
			return new PullingFoundationComponentPb(this);
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0601339F RID: 78751 RVA: 0x002CCD1B File Offset: 0x002CAF1B
		// (set) Token: 0x060133A0 RID: 78752 RVA: 0x002CCD23 File Offset: 0x002CAF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RelationId
		{
			get
			{
				return this.relationId_;
			}
			set
			{
				this.relationId_ = value;
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x060133A1 RID: 78753 RVA: 0x002CCD2C File Offset: 0x002CAF2C
		// (set) Token: 0x060133A2 RID: 78754 RVA: 0x002CCD34 File Offset: 0x002CAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchIndex
		{
			get
			{
				return this.matchIndex_;
			}
			set
			{
				this.matchIndex_ = value;
			}
		}

		// Token: 0x060133A3 RID: 78755 RVA: 0x002CCD3D File Offset: 0x002CAF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationComponentPb);
		}

		// Token: 0x060133A4 RID: 78756 RVA: 0x002CCD4B File Offset: 0x002CAF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationComponentPb other)
		{
			return other != null && (other == this || (this.RelationId == other.RelationId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133A5 RID: 78757 RVA: 0x002CCD8C File Offset: 0x002CAF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RelationId != 0)
			{
				num ^= this.RelationId.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060133A6 RID: 78758 RVA: 0x002CCDE4 File Offset: 0x002CAFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133A7 RID: 78759 RVA: 0x002CCDF1 File Offset: 0x002CAFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133A8 RID: 78760 RVA: 0x002CCDFC File Offset: 0x002CAFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RelationId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RelationId);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133A9 RID: 78761 RVA: 0x002CCE54 File Offset: 0x002CB054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RelationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RelationId);
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060133AA RID: 78762 RVA: 0x002CCEAC File Offset: 0x002CB0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PullingFoundationComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RelationId != 0)
			{
				this.RelationId = other.RelationId;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060133AB RID: 78763 RVA: 0x002CCEFC File Offset: 0x002CB0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133AC RID: 78764 RVA: 0x002CCF08 File Offset: 0x002CB108
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MatchIndex = input.ReadInt32();
					}
				}
				else
				{
					this.RelationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007659 RID: 30297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400765A RID: 30298
		public const int RelationIdFieldNumber = 1;

		// Token: 0x0400765B RID: 30299
		private int relationId_;

		// Token: 0x0400765C RID: 30300
		public const int MatchIndexFieldNumber = 2;

		// Token: 0x0400765D RID: 30301
		private int matchIndex_;
	}
}
