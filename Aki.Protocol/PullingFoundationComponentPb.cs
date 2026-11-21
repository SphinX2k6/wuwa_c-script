using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE6 RID: 3558
	public sealed class PullingFoundationComponentPb : IMessage<PullingFoundationComponentPb>, IMessage, IEquatable<PullingFoundationComponentPb>, IDeepCloneable<PullingFoundationComponentPb>, IBufferMessage
	{
		// Token: 0x060132B4 RID: 78516 RVA: 0x002CB605 File Offset: 0x002C9805
		[NullableContext(1)]
		public static PullingFoundationComponentPb Create()
		{
			return new PullingFoundationComponentPb();
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x060132B5 RID: 78517 RVA: 0x002CB60C File Offset: 0x002C980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x060132B6 RID: 78518 RVA: 0x002CB60F File Offset: 0x002C980F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationComponentPb.Descriptor;
			}
		}

		// Token: 0x060132B7 RID: 78519 RVA: 0x002CB616 File Offset: 0x002C9816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb()
		{
		}

		// Token: 0x060132B8 RID: 78520 RVA: 0x002CB61E File Offset: 0x002C981E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb(PullingFoundationComponentPb other) : this()
		{
			this.relationId_ = other.relationId_;
			this.matchIndex_ = other.matchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132B9 RID: 78521 RVA: 0x002CB64F File Offset: 0x002C984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb Clone()
		{
			return new PullingFoundationComponentPb(this);
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x060132BA RID: 78522 RVA: 0x002CB657 File Offset: 0x002C9857
		// (set) Token: 0x060132BB RID: 78523 RVA: 0x002CB65F File Offset: 0x002C985F
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

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x060132BC RID: 78524 RVA: 0x002CB668 File Offset: 0x002C9868
		// (set) Token: 0x060132BD RID: 78525 RVA: 0x002CB670 File Offset: 0x002C9870
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

		// Token: 0x060132BE RID: 78526 RVA: 0x002CB679 File Offset: 0x002C9879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationComponentPb);
		}

		// Token: 0x060132BF RID: 78527 RVA: 0x002CB687 File Offset: 0x002C9887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationComponentPb other)
		{
			return other != null && (other == this || (this.RelationId == other.RelationId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132C0 RID: 78528 RVA: 0x002CB6C8 File Offset: 0x002C98C8
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

		// Token: 0x060132C1 RID: 78529 RVA: 0x002CB720 File Offset: 0x002C9920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132C2 RID: 78530 RVA: 0x002CB72D File Offset: 0x002C992D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132C3 RID: 78531 RVA: 0x002CB738 File Offset: 0x002C9938
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

		// Token: 0x060132C4 RID: 78532 RVA: 0x002CB790 File Offset: 0x002C9990
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

		// Token: 0x060132C5 RID: 78533 RVA: 0x002CB7E8 File Offset: 0x002C99E8
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

		// Token: 0x060132C6 RID: 78534 RVA: 0x002CB838 File Offset: 0x002C9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132C7 RID: 78535 RVA: 0x002CB844 File Offset: 0x002C9A44
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

		// Token: 0x04007683 RID: 30339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007684 RID: 30340
		public const int RelationIdFieldNumber = 1;

		// Token: 0x04007685 RID: 30341
		private int relationId_;

		// Token: 0x04007686 RID: 30342
		public const int MatchIndexFieldNumber = 2;

		// Token: 0x04007687 RID: 30343
		private int matchIndex_;
	}
}
