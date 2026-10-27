using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000230 RID: 560
	[NetMessage(EMessageId.CancelMatchNotify)]
	public sealed class CancelMatchNotify : IMessage<CancelMatchNotify>, IMessage, IEquatable<CancelMatchNotify>, IDeepCloneable<CancelMatchNotify>, IBufferMessage
	{
		// Token: 0x06003CB7 RID: 15543 RVA: 0x00096CBF File Offset: 0x00094EBF
		[NullableContext(1)]
		public static CancelMatchNotify Create()
		{
			return new CancelMatchNotify();
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x00096CC6 File Offset: 0x00094EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x00096CC9 File Offset: 0x00094EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchNotify.Descriptor;
			}
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00096CD0 File Offset: 0x00094ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify()
		{
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00096CD8 File Offset: 0x00094ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify(CancelMatchNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00096CFD File Offset: 0x00094EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify Clone()
		{
			return new CancelMatchNotify(this);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x00096D05 File Offset: 0x00094F05
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00096D0D File Offset: 0x00094F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00096D16 File Offset: 0x00094F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchNotify);
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00096D24 File Offset: 0x00094F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00096D54 File Offset: 0x00094F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00096D93 File Offset: 0x00094F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00096DA0 File Offset: 0x00094FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00096DA9 File Offset: 0x00094FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00096DDC File Offset: 0x00094FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00096E1A File Offset: 0x0009501A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00096E4B File Offset: 0x0009504B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00096E54 File Offset: 0x00095054
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C83 RID: 11395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C84 RID: 11396
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04002C85 RID: 11397
		private int playerId_;
	}
}
