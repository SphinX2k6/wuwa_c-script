using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E5 RID: 1253
	[NetMessage(EMessageId.ExecuteQtePush)]
	public sealed class ExecuteQtePush : IMessage<ExecuteQtePush>, IMessage, IEquatable<ExecuteQtePush>, IDeepCloneable<ExecuteQtePush>, IBufferMessage
	{
		// Token: 0x060076B1 RID: 30385 RVA: 0x0012215B File Offset: 0x0012035B
		[NullableContext(1)]
		public static ExecuteQtePush Create()
		{
			return new ExecuteQtePush();
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00122162 File Offset: 0x00120362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x060076B3 RID: 30387 RVA: 0x00122165 File Offset: 0x00120365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQtePush.Descriptor;
			}
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x0012216C File Offset: 0x0012036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush()
		{
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00122174 File Offset: 0x00120374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush(ExecuteQtePush other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x001221B1 File Offset: 0x001203B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush Clone()
		{
			return new ExecuteQtePush(this);
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x060076B7 RID: 30391 RVA: 0x001221B9 File Offset: 0x001203B9
		// (set) Token: 0x060076B8 RID: 30392 RVA: 0x001221C1 File Offset: 0x001203C1
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

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x060076B9 RID: 30393 RVA: 0x001221CA File Offset: 0x001203CA
		// (set) Token: 0x060076BA RID: 30394 RVA: 0x001221D2 File Offset: 0x001203D2
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

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x060076BB RID: 30395 RVA: 0x001221DB File Offset: 0x001203DB
		// (set) Token: 0x060076BC RID: 30396 RVA: 0x001221E3 File Offset: 0x001203E3
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

		// Token: 0x060076BD RID: 30397 RVA: 0x001221EC File Offset: 0x001203EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQtePush);
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x001221FC File Offset: 0x001203FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQtePush other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00122258 File Offset: 0x00120458
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

		// Token: 0x060076C0 RID: 30400 RVA: 0x001222C9 File Offset: 0x001204C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x001222D6 File Offset: 0x001204D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x001222E0 File Offset: 0x001204E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.DownEntityId);
			}
			if (this.QteId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.QteId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.UpEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00122354 File Offset: 0x00120554
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

		// Token: 0x060076C4 RID: 30404 RVA: 0x001223C4 File Offset: 0x001205C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExecuteQtePush other)
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

		// Token: 0x060076C5 RID: 30405 RVA: 0x00122428 File Offset: 0x00120628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00122434 File Offset: 0x00120634
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
					if (num != 32U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.DownEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E07 RID: 15879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E08 RID: 15880
		public const int DownEntityIdFieldNumber = 1;

		// Token: 0x04003E09 RID: 15881
		private long downEntityId_;

		// Token: 0x04003E0A RID: 15882
		public const int UpEntityIdFieldNumber = 15;

		// Token: 0x04003E0B RID: 15883
		private long upEntityId_;

		// Token: 0x04003E0C RID: 15884
		public const int QteIdFieldNumber = 4;

		// Token: 0x04003E0D RID: 15885
		private int qteId_;
	}
}
