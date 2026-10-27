using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005B RID: 91
	[NetMessage(EMessageId.AchievementFinishRequest)]
	public sealed class AchievementFinishRequest : IMessage<AchievementFinishRequest>, IMessage, IEquatable<AchievementFinishRequest>, IDeepCloneable<AchievementFinishRequest>, IBufferMessage
	{
		// Token: 0x060015B6 RID: 5558 RVA: 0x0003985A File Offset: 0x00037A5A
		[NullableContext(1)]
		public static AchievementFinishRequest Create()
		{
			return new AchievementFinishRequest();
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x00039861 File Offset: 0x00037A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00039864 File Offset: 0x00037A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementFinishRequest.Descriptor;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0003986B File Offset: 0x00037A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest()
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00039873 File Offset: 0x00037A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest(AchievementFinishRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00039898 File Offset: 0x00037A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishRequest Clone()
		{
			return new AchievementFinishRequest(this);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000398A0 File Offset: 0x00037AA0
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x000398A8 File Offset: 0x00037AA8
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

		// Token: 0x060015BE RID: 5566 RVA: 0x000398B1 File Offset: 0x00037AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementFinishRequest);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000398BF File Offset: 0x00037ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementFinishRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000398F0 File Offset: 0x00037AF0
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

		// Token: 0x060015C1 RID: 5569 RVA: 0x0003992F File Offset: 0x00037B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0003993C File Offset: 0x00037B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00039945 File Offset: 0x00037B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00039978 File Offset: 0x00037B78
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

		// Token: 0x060015C5 RID: 5573 RVA: 0x000399B6 File Offset: 0x00037BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementFinishRequest other)
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

		// Token: 0x060015C6 RID: 5574 RVA: 0x000399E7 File Offset: 0x00037BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000399F0 File Offset: 0x00037BF0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040020B5 RID: 8373
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020B6 RID: 8374
		public const int IdFieldNumber = 8;

		// Token: 0x040020B7 RID: 8375
		private int id_;
	}
}
