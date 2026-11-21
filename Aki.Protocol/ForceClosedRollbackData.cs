using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000608 RID: 1544
	public sealed class ForceClosedRollbackData : IMessage<ForceClosedRollbackData>, IMessage, IEquatable<ForceClosedRollbackData>, IDeepCloneable<ForceClosedRollbackData>, IBufferMessage
	{
		// Token: 0x06008F0B RID: 36619 RVA: 0x0015AF53 File Offset: 0x00159153
		[NullableContext(1)]
		public static ForceClosedRollbackData Create()
		{
			return new ForceClosedRollbackData();
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0015AF5A File Offset: 0x0015915A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06008F0D RID: 36621 RVA: 0x0015AF5D File Offset: 0x0015915D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForceClosedRollbackData.Descriptor;
			}
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x0015AF64 File Offset: 0x00159164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceClosedRollbackData()
		{
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0015AF6C File Offset: 0x0015916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceClosedRollbackData(ForceClosedRollbackData other) : this()
		{
			this.forceClosedNodeId_ = other.forceClosedNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0015AF91 File Offset: 0x00159191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceClosedRollbackData Clone()
		{
			return new ForceClosedRollbackData(this);
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x0015AF99 File Offset: 0x00159199
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x0015AFA1 File Offset: 0x001591A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ForceClosedNodeId
		{
			get
			{
				return this.forceClosedNodeId_;
			}
			set
			{
				this.forceClosedNodeId_ = value;
			}
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0015AFAA File Offset: 0x001591AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForceClosedRollbackData);
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0015AFB8 File Offset: 0x001591B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForceClosedRollbackData other)
		{
			return other != null && (other == this || (this.ForceClosedNodeId == other.ForceClosedNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0015AFE8 File Offset: 0x001591E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ForceClosedNodeId != 0)
			{
				num ^= this.ForceClosedNodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0015B027 File Offset: 0x00159227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0015B034 File Offset: 0x00159234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0015B03D File Offset: 0x0015923D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ForceClosedNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ForceClosedNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0015B070 File Offset: 0x00159270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ForceClosedNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceClosedNodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0015B0AE File Offset: 0x001592AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForceClosedRollbackData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ForceClosedNodeId != 0)
			{
				this.ForceClosedNodeId = other.ForceClosedNodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0015B0DF File Offset: 0x001592DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x0015B0E8 File Offset: 0x001592E8
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
					this.ForceClosedNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045E6 RID: 17894
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045E7 RID: 17895
		public const int ForceClosedNodeIdFieldNumber = 1;

		// Token: 0x040045E8 RID: 17896
		private int forceClosedNodeId_;
	}
}
