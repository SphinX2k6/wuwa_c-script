using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.BattleDefine
{
	// Token: 0x020016F1 RID: 5873
	public sealed class TransferContextId : IMessage<TransferContextId>, IMessage, IEquatable<TransferContextId>, IDeepCloneable<TransferContextId>, IBufferMessage
	{
		// Token: 0x0601D5B0 RID: 120240 RVA: 0x0043FAB1 File Offset: 0x0043DCB1
		[NullableContext(1)]
		public static TransferContextId Create()
		{
			return new TransferContextId();
		}

		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x0601D5B1 RID: 120241 RVA: 0x0043FAB8 File Offset: 0x0043DCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x0601D5B2 RID: 120242 RVA: 0x0043FABB File Offset: 0x0043DCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransferContextId.Descriptor;
			}
		}

		// Token: 0x0601D5B3 RID: 120243 RVA: 0x0043FAC2 File Offset: 0x0043DCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId()
		{
		}

		// Token: 0x0601D5B4 RID: 120244 RVA: 0x0043FACA File Offset: 0x0043DCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId(TransferContextId other) : this()
		{
			this.bulletContextId_ = other.bulletContextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5B5 RID: 120245 RVA: 0x0043FAEF File Offset: 0x0043DCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId Clone()
		{
			return new TransferContextId(this);
		}

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x0601D5B6 RID: 120246 RVA: 0x0043FAF7 File Offset: 0x0043DCF7
		// (set) Token: 0x0601D5B7 RID: 120247 RVA: 0x0043FAFF File Offset: 0x0043DCFF
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

		// Token: 0x0601D5B8 RID: 120248 RVA: 0x0043FB08 File Offset: 0x0043DD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransferContextId);
		}

		// Token: 0x0601D5B9 RID: 120249 RVA: 0x0043FB16 File Offset: 0x0043DD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransferContextId other)
		{
			return other != null && (other == this || (this.BulletContextId == other.BulletContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5BA RID: 120250 RVA: 0x0043FB44 File Offset: 0x0043DD44
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

		// Token: 0x0601D5BB RID: 120251 RVA: 0x0043FB83 File Offset: 0x0043DD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x0043FB90 File Offset: 0x0043DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x0043FB99 File Offset: 0x0043DD99
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

		// Token: 0x0601D5BE RID: 120254 RVA: 0x0043FBCC File Offset: 0x0043DDCC
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

		// Token: 0x0601D5BF RID: 120255 RVA: 0x0043FC0A File Offset: 0x0043DE0A
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

		// Token: 0x0601D5C0 RID: 120256 RVA: 0x0043FC3B File Offset: 0x0043DE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5C1 RID: 120257 RVA: 0x0043FC44 File Offset: 0x0043DE44
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

		// Token: 0x0400C6F4 RID: 50932
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C6F5 RID: 50933
		public const int BulletContextIdFieldNumber = 1;

		// Token: 0x0400C6F6 RID: 50934
		private long bulletContextId_;
	}
}
