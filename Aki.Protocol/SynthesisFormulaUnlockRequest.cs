using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130A RID: 4874
	[NetMessage(EMessageId.SynthesisFormulaUnlockRequest)]
	public sealed class SynthesisFormulaUnlockRequest : IMessage<SynthesisFormulaUnlockRequest>, IMessage, IEquatable<SynthesisFormulaUnlockRequest>, IDeepCloneable<SynthesisFormulaUnlockRequest>, IBufferMessage
	{
		// Token: 0x06019E7C RID: 106108 RVA: 0x003C388B File Offset: 0x003C1A8B
		[NullableContext(1)]
		public static SynthesisFormulaUnlockRequest Create()
		{
			return new SynthesisFormulaUnlockRequest();
		}

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x06019E7D RID: 106109 RVA: 0x003C3892 File Offset: 0x003C1A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x06019E7E RID: 106110 RVA: 0x003C3895 File Offset: 0x003C1A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisFormulaUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06019E7F RID: 106111 RVA: 0x003C389C File Offset: 0x003C1A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest()
		{
		}

		// Token: 0x06019E80 RID: 106112 RVA: 0x003C38A4 File Offset: 0x003C1AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest(SynthesisFormulaUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E81 RID: 106113 RVA: 0x003C38C9 File Offset: 0x003C1AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockRequest Clone()
		{
			return new SynthesisFormulaUnlockRequest(this);
		}

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x06019E82 RID: 106114 RVA: 0x003C38D1 File Offset: 0x003C1AD1
		// (set) Token: 0x06019E83 RID: 106115 RVA: 0x003C38D9 File Offset: 0x003C1AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06019E84 RID: 106116 RVA: 0x003C38E2 File Offset: 0x003C1AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisFormulaUnlockRequest);
		}

		// Token: 0x06019E85 RID: 106117 RVA: 0x003C38F0 File Offset: 0x003C1AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisFormulaUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E86 RID: 106118 RVA: 0x003C3920 File Offset: 0x003C1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E87 RID: 106119 RVA: 0x003C395F File Offset: 0x003C1B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E88 RID: 106120 RVA: 0x003C396C File Offset: 0x003C1B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E89 RID: 106121 RVA: 0x003C3975 File Offset: 0x003C1B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E8A RID: 106122 RVA: 0x003C39A8 File Offset: 0x003C1BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E8B RID: 106123 RVA: 0x003C39E6 File Offset: 0x003C1BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisFormulaUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E8C RID: 106124 RVA: 0x003C3A17 File Offset: 0x003C1C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E8D RID: 106125 RVA: 0x003C3A20 File Offset: 0x003C1C20
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400976A RID: 38762
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400976B RID: 38763
		public const int IdFieldNumber = 1;

		// Token: 0x0400976C RID: 38764
		private int id_;
	}
}
