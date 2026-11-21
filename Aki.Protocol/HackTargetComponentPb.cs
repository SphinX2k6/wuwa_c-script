using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071F RID: 1823
	public sealed class HackTargetComponentPb : IMessage<HackTargetComponentPb>, IMessage, IEquatable<HackTargetComponentPb>, IDeepCloneable<HackTargetComponentPb>, IBufferMessage
	{
		// Token: 0x0600A5D0 RID: 42448 RVA: 0x0018FCD4 File Offset: 0x0018DED4
		[NullableContext(1)]
		public static HackTargetComponentPb Create()
		{
			return new HackTargetComponentPb();
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x0018FCDB File Offset: 0x0018DEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x0018FCDE File Offset: 0x0018DEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HackTargetComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x0018FCE5 File Offset: 0x0018DEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb()
		{
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x0018FCED File Offset: 0x0018DEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb(HackTargetComponentPb other) : this()
		{
			this.hackTargetEntityId_ = other.hackTargetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x0018FD12 File Offset: 0x0018DF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb Clone()
		{
			return new HackTargetComponentPb(this);
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x0018FD1A File Offset: 0x0018DF1A
		// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x0018FD22 File Offset: 0x0018DF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HackTargetEntityId
		{
			get
			{
				return this.hackTargetEntityId_;
			}
			set
			{
				this.hackTargetEntityId_ = value;
			}
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x0018FD2B File Offset: 0x0018DF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HackTargetComponentPb);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x0018FD39 File Offset: 0x0018DF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HackTargetComponentPb other)
		{
			return other != null && (other == this || (this.HackTargetEntityId == other.HackTargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x0018FD68 File Offset: 0x0018DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HackTargetEntityId != 0L)
			{
				num ^= this.HackTargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x0018FDA7 File Offset: 0x0018DFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x0018FDB4 File Offset: 0x0018DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x0018FDBD File Offset: 0x0018DFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HackTargetEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.HackTargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x0018FDF0 File Offset: 0x0018DFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HackTargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HackTargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x0018FE2E File Offset: 0x0018E02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HackTargetComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HackTargetEntityId != 0L)
			{
				this.HackTargetEntityId = other.HackTargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x0018FE5F File Offset: 0x0018E05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x0018FE68 File Offset: 0x0018E068
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
					this.HackTargetEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004C72 RID: 19570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C73 RID: 19571
		public const int HackTargetEntityIdFieldNumber = 1;

		// Token: 0x04004C74 RID: 19572
		private long hackTargetEntityId_;
	}
}
