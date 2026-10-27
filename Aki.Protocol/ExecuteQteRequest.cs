using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E6 RID: 1254
	[NetMessage(EMessageId.ExecuteQteRequest)]
	public sealed class ExecuteQteRequest : IMessage<ExecuteQteRequest>, IMessage, IEquatable<ExecuteQteRequest>, IDeepCloneable<ExecuteQteRequest>, IBufferMessage
	{
		// Token: 0x060076C7 RID: 30407 RVA: 0x0012249E File Offset: 0x0012069E
		[NullableContext(1)]
		public static ExecuteQteRequest Create()
		{
			return new ExecuteQteRequest();
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x060076C8 RID: 30408 RVA: 0x001224A5 File Offset: 0x001206A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x001224A8 File Offset: 0x001206A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteRequest.Descriptor;
			}
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x001224AF File Offset: 0x001206AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest()
		{
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x001224B7 File Offset: 0x001206B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest(ExecuteQteRequest other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x001224F4 File Offset: 0x001206F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest Clone()
		{
			return new ExecuteQteRequest(this);
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x001224FC File Offset: 0x001206FC
		// (set) Token: 0x060076CE RID: 30414 RVA: 0x00122504 File Offset: 0x00120704
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

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x060076CF RID: 30415 RVA: 0x0012250D File Offset: 0x0012070D
		// (set) Token: 0x060076D0 RID: 30416 RVA: 0x00122515 File Offset: 0x00120715
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

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x060076D1 RID: 30417 RVA: 0x0012251E File Offset: 0x0012071E
		// (set) Token: 0x060076D2 RID: 30418 RVA: 0x00122526 File Offset: 0x00120726
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

		// Token: 0x060076D3 RID: 30419 RVA: 0x0012252F File Offset: 0x0012072F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteRequest);
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00122540 File Offset: 0x00120740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteRequest other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x0012259C File Offset: 0x0012079C
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

		// Token: 0x060076D6 RID: 30422 RVA: 0x0012260D File Offset: 0x0012080D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x0012261A File Offset: 0x0012081A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00122624 File Offset: 0x00120824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QteId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QteId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.UpEntityId);
			}
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.DownEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x0012269C File Offset: 0x0012089C
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

		// Token: 0x060076DA RID: 30426 RVA: 0x0012270C File Offset: 0x0012090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExecuteQteRequest other)
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

		// Token: 0x060076DB RID: 30427 RVA: 0x00122770 File Offset: 0x00120970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x0012277C File Offset: 0x0012097C
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
					if (num != 64U)
					{
						if (num != 120U)
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
						this.UpEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.QteId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E0E RID: 15886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E0F RID: 15887
		public const int DownEntityIdFieldNumber = 15;

		// Token: 0x04003E10 RID: 15888
		private long downEntityId_;

		// Token: 0x04003E11 RID: 15889
		public const int UpEntityIdFieldNumber = 8;

		// Token: 0x04003E12 RID: 15890
		private long upEntityId_;

		// Token: 0x04003E13 RID: 15891
		public const int QteIdFieldNumber = 6;

		// Token: 0x04003E14 RID: 15892
		private int qteId_;
	}
}
