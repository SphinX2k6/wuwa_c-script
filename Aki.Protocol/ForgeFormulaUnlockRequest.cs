using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000609 RID: 1545
	[NetMessage(EMessageId.ForgeFormulaUnlockRequest)]
	public sealed class ForgeFormulaUnlockRequest : IMessage<ForgeFormulaUnlockRequest>, IMessage, IEquatable<ForgeFormulaUnlockRequest>, IDeepCloneable<ForgeFormulaUnlockRequest>, IBufferMessage
	{
		// Token: 0x06008F1D RID: 36637 RVA: 0x0015B12C File Offset: 0x0015932C
		[NullableContext(1)]
		public static ForgeFormulaUnlockRequest Create()
		{
			return new ForgeFormulaUnlockRequest();
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06008F1E RID: 36638 RVA: 0x0015B133 File Offset: 0x00159333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06008F1F RID: 36639 RVA: 0x0015B136 File Offset: 0x00159336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeFormulaUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x0015B13D File Offset: 0x0015933D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest()
		{
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x0015B145 File Offset: 0x00159345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest(ForgeFormulaUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x0015B16A File Offset: 0x0015936A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockRequest Clone()
		{
			return new ForgeFormulaUnlockRequest(this);
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x0015B172 File Offset: 0x00159372
		// (set) Token: 0x06008F24 RID: 36644 RVA: 0x0015B17A File Offset: 0x0015937A
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

		// Token: 0x06008F25 RID: 36645 RVA: 0x0015B183 File Offset: 0x00159383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeFormulaUnlockRequest);
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x0015B191 File Offset: 0x00159391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeFormulaUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0015B1C0 File Offset: 0x001593C0
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

		// Token: 0x06008F28 RID: 36648 RVA: 0x0015B1FF File Offset: 0x001593FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0015B20C File Offset: 0x0015940C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x0015B215 File Offset: 0x00159415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x0015B248 File Offset: 0x00159448
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

		// Token: 0x06008F2C RID: 36652 RVA: 0x0015B286 File Offset: 0x00159486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeFormulaUnlockRequest other)
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

		// Token: 0x06008F2D RID: 36653 RVA: 0x0015B2B7 File Offset: 0x001594B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0015B2C0 File Offset: 0x001594C0
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045E9 RID: 17897
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045EA RID: 17898
		public const int IdFieldNumber = 6;

		// Token: 0x040045EB RID: 17899
		private int id_;
	}
}
