using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000189 RID: 393
	[NetMessage(EMessageId.BeControlledDestroyRequest)]
	public sealed class BeControlledDestroyRequest : IMessage<BeControlledDestroyRequest>, IMessage, IEquatable<BeControlledDestroyRequest>, IDeepCloneable<BeControlledDestroyRequest>, IBufferMessage
	{
		// Token: 0x06002F72 RID: 12146 RVA: 0x00079EBE File Offset: 0x000780BE
		[NullableContext(1)]
		public static BeControlledDestroyRequest Create()
		{
			return new BeControlledDestroyRequest();
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00079EC5 File Offset: 0x000780C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00079EC8 File Offset: 0x000780C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledDestroyRequest.Descriptor;
			}
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00079ECF File Offset: 0x000780CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest()
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00079ED7 File Offset: 0x000780D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest(BeControlledDestroyRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00079EFC File Offset: 0x000780FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest Clone()
		{
			return new BeControlledDestroyRequest(this);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x00079F04 File Offset: 0x00078104
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x00079F0C File Offset: 0x0007810C
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

		// Token: 0x06002F7A RID: 12154 RVA: 0x00079F15 File Offset: 0x00078115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledDestroyRequest);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00079F23 File Offset: 0x00078123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledDestroyRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00079F54 File Offset: 0x00078154
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

		// Token: 0x06002F7D RID: 12157 RVA: 0x00079F93 File Offset: 0x00078193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00079FA0 File Offset: 0x000781A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00079FA9 File Offset: 0x000781A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00079FDC File Offset: 0x000781DC
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

		// Token: 0x06002F81 RID: 12161 RVA: 0x0007A01A File Offset: 0x0007821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledDestroyRequest other)
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

		// Token: 0x06002F82 RID: 12162 RVA: 0x0007A04B File Offset: 0x0007824B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0007A054 File Offset: 0x00078254
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400290A RID: 10506
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400290B RID: 10507
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400290C RID: 10508
		private long entityId_;
	}
}
