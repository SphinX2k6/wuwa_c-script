using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BF RID: 1727
	[NetMessage(EMessageId.GetAdventureRewardRequest)]
	public sealed class GetAdventureRewardRequest : IMessage<GetAdventureRewardRequest>, IMessage, IEquatable<GetAdventureRewardRequest>, IDeepCloneable<GetAdventureRewardRequest>, IBufferMessage
	{
		// Token: 0x06009E1F RID: 40479 RVA: 0x0017FF21 File Offset: 0x0017E121
		[NullableContext(1)]
		public static GetAdventureRewardRequest Create()
		{
			return new GetAdventureRewardRequest();
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06009E20 RID: 40480 RVA: 0x0017FF28 File Offset: 0x0017E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06009E21 RID: 40481 RVA: 0x0017FF2B File Offset: 0x0017E12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAdventureRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009E22 RID: 40482 RVA: 0x0017FF32 File Offset: 0x0017E132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest()
		{
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x0017FF3A File Offset: 0x0017E13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest(GetAdventureRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x0017FF5F File Offset: 0x0017E15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest Clone()
		{
			return new GetAdventureRewardRequest(this);
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x0017FF67 File Offset: 0x0017E167
		// (set) Token: 0x06009E26 RID: 40486 RVA: 0x0017FF6F File Offset: 0x0017E16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x0017FF78 File Offset: 0x0017E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAdventureRewardRequest);
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x0017FF86 File Offset: 0x0017E186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAdventureRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x0017FFB4 File Offset: 0x0017E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x0017FFF3 File Offset: 0x0017E1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x00180000 File Offset: 0x0017E200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x00180009 File Offset: 0x0017E209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x0018003C File Offset: 0x0017E23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x0018007A File Offset: 0x0017E27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAdventureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x001800AB File Offset: 0x0017E2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x001800B4 File Offset: 0x0017E2B4
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A21 RID: 18977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A22 RID: 18978
		public const int IdFieldNumber = 3;

		// Token: 0x04004A23 RID: 18979
		private int id_;
	}
}
