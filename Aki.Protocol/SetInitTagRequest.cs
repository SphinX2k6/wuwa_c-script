using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120F RID: 4623
	[NetMessage(EMessageId.SetInitTagRequest)]
	public sealed class SetInitTagRequest : IMessage<SetInitTagRequest>, IMessage, IEquatable<SetInitTagRequest>, IDeepCloneable<SetInitTagRequest>, IBufferMessage
	{
		// Token: 0x06018B21 RID: 101153 RVA: 0x00399CDD File Offset: 0x00397EDD
		[NullableContext(1)]
		public static SetInitTagRequest Create()
		{
			return new SetInitTagRequest();
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x06018B22 RID: 101154 RVA: 0x00399CE4 File Offset: 0x00397EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x06018B23 RID: 101155 RVA: 0x00399CE7 File Offset: 0x00397EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetInitTagRequest.Descriptor;
			}
		}

		// Token: 0x06018B24 RID: 101156 RVA: 0x00399CEE File Offset: 0x00397EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest()
		{
		}

		// Token: 0x06018B25 RID: 101157 RVA: 0x00399CF6 File Offset: 0x00397EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest(SetInitTagRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B26 RID: 101158 RVA: 0x00399D1B File Offset: 0x00397F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest Clone()
		{
			return new SetInitTagRequest(this);
		}

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x06018B27 RID: 101159 RVA: 0x00399D23 File Offset: 0x00397F23
		// (set) Token: 0x06018B28 RID: 101160 RVA: 0x00399D2B File Offset: 0x00397F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06018B29 RID: 101161 RVA: 0x00399D34 File Offset: 0x00397F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetInitTagRequest);
		}

		// Token: 0x06018B2A RID: 101162 RVA: 0x00399D42 File Offset: 0x00397F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetInitTagRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B2B RID: 101163 RVA: 0x00399D70 File Offset: 0x00397F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B2C RID: 101164 RVA: 0x00399DAF File Offset: 0x00397FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B2D RID: 101165 RVA: 0x00399DBC File Offset: 0x00397FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B2E RID: 101166 RVA: 0x00399DC5 File Offset: 0x00397FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B2F RID: 101167 RVA: 0x00399DF8 File Offset: 0x00397FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B30 RID: 101168 RVA: 0x00399E36 File Offset: 0x00398036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetInitTagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B31 RID: 101169 RVA: 0x00399E67 File Offset: 0x00398067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B32 RID: 101170 RVA: 0x00399E70 File Offset: 0x00398070
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040092A8 RID: 37544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A9 RID: 37545
		public const int EntityIdFieldNumber = 3;

		// Token: 0x040092AA RID: 37546
		private long entityId_;
	}
}
