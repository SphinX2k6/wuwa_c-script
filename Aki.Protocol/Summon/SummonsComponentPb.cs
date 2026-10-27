using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x0200167B RID: 5755
	public sealed class SummonsComponentPb : IMessage<SummonsComponentPb>, IMessage, IEquatable<SummonsComponentPb>, IDeepCloneable<SummonsComponentPb>, IBufferMessage
	{
		// Token: 0x0601CB61 RID: 117601 RVA: 0x00424EE6 File Offset: 0x004230E6
		[NullableContext(1)]
		public static SummonsComponentPb Create()
		{
			return new SummonsComponentPb();
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x0601CB62 RID: 117602 RVA: 0x00424EED File Offset: 0x004230ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x0601CB63 RID: 117603 RVA: 0x00424EF0 File Offset: 0x004230F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonsComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CB64 RID: 117604 RVA: 0x00424EF7 File Offset: 0x004230F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb()
		{
		}

		// Token: 0x0601CB65 RID: 117605 RVA: 0x00424EFF File Offset: 0x004230FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb(SummonsComponentPb other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB66 RID: 117606 RVA: 0x00424F24 File Offset: 0x00423124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb Clone()
		{
			return new SummonsComponentPb(this);
		}

		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x0601CB67 RID: 117607 RVA: 0x00424F2C File Offset: 0x0042312C
		// (set) Token: 0x0601CB68 RID: 117608 RVA: 0x00424F34 File Offset: 0x00423134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x0601CB69 RID: 117609 RVA: 0x00424F3D File Offset: 0x0042313D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonsComponentPb);
		}

		// Token: 0x0601CB6A RID: 117610 RVA: 0x00424F4B File Offset: 0x0042314B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonsComponentPb other)
		{
			return other != null && (other == this || (this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB6B RID: 117611 RVA: 0x00424F7C File Offset: 0x0042317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB6C RID: 117612 RVA: 0x00424FBB File Offset: 0x004231BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB6D RID: 117613 RVA: 0x00424FC8 File Offset: 0x004231C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB6E RID: 117614 RVA: 0x00424FD1 File Offset: 0x004231D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB6F RID: 117615 RVA: 0x00425004 File Offset: 0x00423204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB70 RID: 117616 RVA: 0x00425042 File Offset: 0x00423242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonsComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB71 RID: 117617 RVA: 0x00425073 File Offset: 0x00423273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB72 RID: 117618 RVA: 0x0042507C File Offset: 0x0042327C
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
					this.Version = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C1EE RID: 49646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1EF RID: 49647
		public const int VersionFieldNumber = 1;

		// Token: 0x0400C1F0 RID: 49648
		private int version_;
	}
}
