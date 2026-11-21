using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CE RID: 1230
	[NetMessage(EMessageId.ExecuteQteNotify)]
	public sealed class ExecuteQteNotify : IMessage<ExecuteQteNotify>, IMessage, IEquatable<ExecuteQteNotify>, IDeepCloneable<ExecuteQteNotify>, IBufferMessage
	{
		// Token: 0x0600751F RID: 29983 RVA: 0x0011EF8F File Offset: 0x0011D18F
		[NullableContext(1)]
		public static ExecuteQteNotify Create()
		{
			return new ExecuteQteNotify();
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x0011EF96 File Offset: 0x0011D196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x0011EF99 File Offset: 0x0011D199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteNotify.Descriptor;
			}
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x0011EFA0 File Offset: 0x0011D1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify()
		{
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x0011EFA8 File Offset: 0x0011D1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify(ExecuteQteNotify other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x0011EFE5 File Offset: 0x0011D1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify Clone()
		{
			return new ExecuteQteNotify(this);
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x0011EFED File Offset: 0x0011D1ED
		// (set) Token: 0x06007526 RID: 29990 RVA: 0x0011EFF5 File Offset: 0x0011D1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DownEntityId
		{
			get
			{
				return this.downEntityId_;
			}
			set
			{
				this.downEntityId_ = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0011EFFE File Offset: 0x0011D1FE
		// (set) Token: 0x06007528 RID: 29992 RVA: 0x0011F006 File Offset: 0x0011D206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpEntityId
		{
			get
			{
				return this.upEntityId_;
			}
			set
			{
				this.upEntityId_ = value;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x0011F00F File Offset: 0x0011D20F
		// (set) Token: 0x0600752A RID: 29994 RVA: 0x0011F017 File Offset: 0x0011D217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QteId
		{
			get
			{
				return this.qteId_;
			}
			set
			{
				this.qteId_ = value;
			}
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x0011F020 File Offset: 0x0011D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteNotify);
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x0011F030 File Offset: 0x0011D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteNotify other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x0011F08C File Offset: 0x0011D28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DownEntityId != 0L)
			{
				num ^= this.DownEntityId.GetHashCode();
			}
			if (this.UpEntityId != 0L)
			{
				num ^= this.UpEntityId.GetHashCode();
			}
			if (this.QteId != 0)
			{
				num ^= this.QteId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x0011F0FD File Offset: 0x0011D2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x0011F10A File Offset: 0x0011D30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x0011F114 File Offset: 0x0011D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.UpEntityId);
			}
			if (this.QteId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.QteId);
			}
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.DownEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0011F188 File Offset: 0x0011D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DownEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DownEntityId);
			}
			if (this.UpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpEntityId);
			}
			if (this.QteId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0011F1F8 File Offset: 0x0011D3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExecuteQteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DownEntityId != 0L)
			{
				this.DownEntityId = other.DownEntityId;
			}
			if (other.UpEntityId != 0L)
			{
				this.UpEntityId = other.UpEntityId;
			}
			if (other.QteId != 0)
			{
				this.QteId = other.QteId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0011F25C File Offset: 0x0011D45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0011F268 File Offset: 0x0011D468
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
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DownEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.QteId = input.ReadInt32();
					}
				}
				else
				{
					this.UpEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003DF1 RID: 15857
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF2 RID: 15858
		public const int DownEntityIdFieldNumber = 12;

		// Token: 0x04003DF3 RID: 15859
		private long downEntityId_;

		// Token: 0x04003DF4 RID: 15860
		public const int UpEntityIdFieldNumber = 1;

		// Token: 0x04003DF5 RID: 15861
		private long upEntityId_;

		// Token: 0x04003DF6 RID: 15862
		public const int QteIdFieldNumber = 2;

		// Token: 0x04003DF7 RID: 15863
		private int qteId_;
	}
}
