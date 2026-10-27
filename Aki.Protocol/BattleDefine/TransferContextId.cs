using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.BattleDefine
{
	// Token: 0x02001675 RID: 5749
	public sealed class TransferContextId : IMessage<TransferContextId>, IMessage, IEquatable<TransferContextId>, IDeepCloneable<TransferContextId>, IBufferMessage
	{
		// Token: 0x0601CAE5 RID: 117477 RVA: 0x00423E91 File Offset: 0x00422091
		[NullableContext(1)]
		public static TransferContextId Create()
		{
			return new TransferContextId();
		}

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x0601CAE6 RID: 117478 RVA: 0x00423E98 File Offset: 0x00422098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x0601CAE7 RID: 117479 RVA: 0x00423E9B File Offset: 0x0042209B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransferContextId.Descriptor;
			}
		}

		// Token: 0x0601CAE8 RID: 117480 RVA: 0x00423EA2 File Offset: 0x004220A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId()
		{
		}

		// Token: 0x0601CAE9 RID: 117481 RVA: 0x00423EAA File Offset: 0x004220AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId(TransferContextId other) : this()
		{
			this.bulletContextId_ = other.bulletContextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAEA RID: 117482 RVA: 0x00423ECF File Offset: 0x004220CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId Clone()
		{
			return new TransferContextId(this);
		}

		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x0601CAEB RID: 117483 RVA: 0x00423ED7 File Offset: 0x004220D7
		// (set) Token: 0x0601CAEC RID: 117484 RVA: 0x00423EDF File Offset: 0x004220DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletContextId
		{
			get
			{
				return this.bulletContextId_;
			}
			set
			{
				this.bulletContextId_ = value;
			}
		}

		// Token: 0x0601CAED RID: 117485 RVA: 0x00423EE8 File Offset: 0x004220E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransferContextId);
		}

		// Token: 0x0601CAEE RID: 117486 RVA: 0x00423EF6 File Offset: 0x004220F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransferContextId other)
		{
			return other != null && (other == this || (this.BulletContextId == other.BulletContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAEF RID: 117487 RVA: 0x00423F24 File Offset: 0x00422124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletContextId != 0L)
			{
				num ^= this.BulletContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAF0 RID: 117488 RVA: 0x00423F63 File Offset: 0x00422163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAF1 RID: 117489 RVA: 0x00423F70 File Offset: 0x00422170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAF2 RID: 117490 RVA: 0x00423F79 File Offset: 0x00422179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BulletContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CAF3 RID: 117491 RVA: 0x00423FAC File Offset: 0x004221AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CAF4 RID: 117492 RVA: 0x00423FEA File Offset: 0x004221EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransferContextId other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletContextId != 0L)
			{
				this.BulletContextId = other.BulletContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x0042401B File Offset: 0x0042221B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x00424024 File Offset: 0x00422224
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
					this.BulletContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C1CB RID: 49611
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1CC RID: 49612
		public const int BulletContextIdFieldNumber = 1;

		// Token: 0x0400C1CD RID: 49613
		private long bulletContextId_;
	}
}
