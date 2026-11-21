using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD8 RID: 3544
	[NetMessage(EMessageId.ProgressBarFinishRequest)]
	public sealed class ProgressBarFinishRequest : IMessage<ProgressBarFinishRequest>, IMessage, IEquatable<ProgressBarFinishRequest>, IDeepCloneable<ProgressBarFinishRequest>, IBufferMessage
	{
		// Token: 0x0601318C RID: 78220 RVA: 0x002C8CCE File Offset: 0x002C6ECE
		[NullableContext(1)]
		public static ProgressBarFinishRequest Create()
		{
			return new ProgressBarFinishRequest();
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0601318D RID: 78221 RVA: 0x002C8CD5 File Offset: 0x002C6ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0601318E RID: 78222 RVA: 0x002C8CD8 File Offset: 0x002C6ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressBarFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601318F RID: 78223 RVA: 0x002C8CDF File Offset: 0x002C6EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest()
		{
		}

		// Token: 0x06013190 RID: 78224 RVA: 0x002C8CE7 File Offset: 0x002C6EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest(ProgressBarFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013191 RID: 78225 RVA: 0x002C8D0C File Offset: 0x002C6F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest Clone()
		{
			return new ProgressBarFinishRequest(this);
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x06013192 RID: 78226 RVA: 0x002C8D14 File Offset: 0x002C6F14
		// (set) Token: 0x06013193 RID: 78227 RVA: 0x002C8D1C File Offset: 0x002C6F1C
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

		// Token: 0x06013194 RID: 78228 RVA: 0x002C8D25 File Offset: 0x002C6F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressBarFinishRequest);
		}

		// Token: 0x06013195 RID: 78229 RVA: 0x002C8D33 File Offset: 0x002C6F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProgressBarFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013196 RID: 78230 RVA: 0x002C8D64 File Offset: 0x002C6F64
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

		// Token: 0x06013197 RID: 78231 RVA: 0x002C8DA3 File Offset: 0x002C6FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013198 RID: 78232 RVA: 0x002C8DB0 File Offset: 0x002C6FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013199 RID: 78233 RVA: 0x002C8DB9 File Offset: 0x002C6FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601319A RID: 78234 RVA: 0x002C8DEC File Offset: 0x002C6FEC
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

		// Token: 0x0601319B RID: 78235 RVA: 0x002C8E2A File Offset: 0x002C702A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProgressBarFinishRequest other)
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

		// Token: 0x0601319C RID: 78236 RVA: 0x002C8E5B File Offset: 0x002C705B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601319D RID: 78237 RVA: 0x002C8E64 File Offset: 0x002C7064
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400762A RID: 30250
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400762B RID: 30251
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400762C RID: 30252
		private long entityId_;
	}
}
