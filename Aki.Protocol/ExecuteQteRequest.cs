using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D0 RID: 1232
	[NetMessage(EMessageId.ExecuteQteRequest)]
	public sealed class ExecuteQteRequest : IMessage<ExecuteQteRequest>, IMessage, IEquatable<ExecuteQteRequest>, IDeepCloneable<ExecuteQteRequest>, IBufferMessage
	{
		// Token: 0x0600754B RID: 30027 RVA: 0x0011F61B File Offset: 0x0011D81B
		[NullableContext(1)]
		public static ExecuteQteRequest Create()
		{
			return new ExecuteQteRequest();
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x0600754C RID: 30028 RVA: 0x0011F622 File Offset: 0x0011D822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x0600754D RID: 30029 RVA: 0x0011F625 File Offset: 0x0011D825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteRequest.Descriptor;
			}
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0011F62C File Offset: 0x0011D82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest()
		{
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0011F634 File Offset: 0x0011D834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest(ExecuteQteRequest other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0011F671 File Offset: 0x0011D871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteRequest Clone()
		{
			return new ExecuteQteRequest(this);
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06007551 RID: 30033 RVA: 0x0011F679 File Offset: 0x0011D879
		// (set) Token: 0x06007552 RID: 30034 RVA: 0x0011F681 File Offset: 0x0011D881
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

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x0011F68A File Offset: 0x0011D88A
		// (set) Token: 0x06007554 RID: 30036 RVA: 0x0011F692 File Offset: 0x0011D892
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

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06007555 RID: 30037 RVA: 0x0011F69B File Offset: 0x0011D89B
		// (set) Token: 0x06007556 RID: 30038 RVA: 0x0011F6A3 File Offset: 0x0011D8A3
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

		// Token: 0x06007557 RID: 30039 RVA: 0x0011F6AC File Offset: 0x0011D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteRequest);
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x0011F6BC File Offset: 0x0011D8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteRequest other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x0011F718 File Offset: 0x0011D918
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

		// Token: 0x0600755A RID: 30042 RVA: 0x0011F789 File Offset: 0x0011D989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x0011F796 File Offset: 0x0011D996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x0011F7A0 File Offset: 0x0011D9A0
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
				output.WriteRawTag(88);
				output.WriteInt32(this.QteId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.UpEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x0011F814 File Offset: 0x0011DA14
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

		// Token: 0x0600755E RID: 30046 RVA: 0x0011F884 File Offset: 0x0011DA84
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

		// Token: 0x0600755F RID: 30047 RVA: 0x0011F8E8 File Offset: 0x0011DAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x0011F8F4 File Offset: 0x0011DAF4
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
					if (num != 88U)
					{
						if (num != 104U)
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

		// Token: 0x04003DFF RID: 15871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E00 RID: 15872
		public const int DownEntityIdFieldNumber = 1;

		// Token: 0x04003E01 RID: 15873
		private long downEntityId_;

		// Token: 0x04003E02 RID: 15874
		public const int UpEntityIdFieldNumber = 13;

		// Token: 0x04003E03 RID: 15875
		private long upEntityId_;

		// Token: 0x04003E04 RID: 15876
		public const int QteIdFieldNumber = 11;

		// Token: 0x04003E05 RID: 15877
		private int qteId_;
	}
}
