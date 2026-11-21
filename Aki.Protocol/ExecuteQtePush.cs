using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CF RID: 1231
	[NetMessage(EMessageId.ExecuteQtePush)]
	public sealed class ExecuteQtePush : IMessage<ExecuteQtePush>, IMessage, IEquatable<ExecuteQtePush>, IDeepCloneable<ExecuteQtePush>, IBufferMessage
	{
		// Token: 0x06007535 RID: 30005 RVA: 0x0011F2D2 File Offset: 0x0011D4D2
		[NullableContext(1)]
		public static ExecuteQtePush Create()
		{
			return new ExecuteQtePush();
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06007536 RID: 30006 RVA: 0x0011F2D9 File Offset: 0x0011D4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x0011F2DC File Offset: 0x0011D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQtePush.Descriptor;
			}
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0011F2E3 File Offset: 0x0011D4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush()
		{
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x0011F2EB File Offset: 0x0011D4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush(ExecuteQtePush other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x0011F328 File Offset: 0x0011D528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQtePush Clone()
		{
			return new ExecuteQtePush(this);
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x0011F330 File Offset: 0x0011D530
		// (set) Token: 0x0600753C RID: 30012 RVA: 0x0011F338 File Offset: 0x0011D538
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

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x0011F341 File Offset: 0x0011D541
		// (set) Token: 0x0600753E RID: 30014 RVA: 0x0011F349 File Offset: 0x0011D549
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

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x0600753F RID: 30015 RVA: 0x0011F352 File Offset: 0x0011D552
		// (set) Token: 0x06007540 RID: 30016 RVA: 0x0011F35A File Offset: 0x0011D55A
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

		// Token: 0x06007541 RID: 30017 RVA: 0x0011F363 File Offset: 0x0011D563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQtePush);
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x0011F374 File Offset: 0x0011D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQtePush other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x0011F3D0 File Offset: 0x0011D5D0
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

		// Token: 0x06007544 RID: 30020 RVA: 0x0011F441 File Offset: 0x0011D641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x0011F44E File Offset: 0x0011D64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x0011F458 File Offset: 0x0011D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.DownEntityId);
			}
			if (this.QteId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.QteId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.UpEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x0011F4D0 File Offset: 0x0011D6D0
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

		// Token: 0x06007548 RID: 30024 RVA: 0x0011F540 File Offset: 0x0011D740
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

		// Token: 0x06007549 RID: 30025 RVA: 0x0011F5A4 File Offset: 0x0011D7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x0011F5B0 File Offset: 0x0011D7B0
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
				if (num != 64U)
				{
					if (num != 104U)
					{
						if (num != 112U)
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

		// Token: 0x04003DF8 RID: 15864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF9 RID: 15865
		public const int DownEntityIdFieldNumber = 8;

		// Token: 0x04003DFA RID: 15866
		private long downEntityId_;

		// Token: 0x04003DFB RID: 15867
		public const int UpEntityIdFieldNumber = 14;

		// Token: 0x04003DFC RID: 15868
		private long upEntityId_;

		// Token: 0x04003DFD RID: 15869
		public const int QteIdFieldNumber = 13;

		// Token: 0x04003DFE RID: 15870
		private int qteId_;
	}
}
