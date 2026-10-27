using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045E RID: 1118
	[NetMessage(EMessageId.EntityAccessCasketRequest)]
	public sealed class EntityAccessCasketRequest : IMessage<EntityAccessCasketRequest>, IMessage, IEquatable<EntityAccessCasketRequest>, IDeepCloneable<EntityAccessCasketRequest>, IBufferMessage
	{
		// Token: 0x06006AC4 RID: 27332 RVA: 0x0010186D File Offset: 0x000FFA6D
		[NullableContext(1)]
		public static EntityAccessCasketRequest Create()
		{
			return new EntityAccessCasketRequest();
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x00101874 File Offset: 0x000FFA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06006AC6 RID: 27334 RVA: 0x00101877 File Offset: 0x000FFA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessCasketRequest.Descriptor;
			}
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0010187E File Offset: 0x000FFA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest()
		{
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00101894 File Offset: 0x000FFA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest(EntityAccessCasketRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.accessEntityIncIds_ = other.accessEntityIncIds_.Clone();
			this.isEnter_ = other.isEnter_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x001018ED File Offset: 0x000FFAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketRequest Clone()
		{
			return new EntityAccessCasketRequest(this);
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x001018F5 File Offset: 0x000FFAF5
		// (set) Token: 0x06006ACB RID: 27339 RVA: 0x001018FD File Offset: 0x000FFAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x00101906 File Offset: 0x000FFB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIncIds
		{
			get
			{
				return this.accessEntityIncIds_;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x0010190E File Offset: 0x000FFB0E
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x00101916 File Offset: 0x000FFB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x0010191F File Offset: 0x000FFB1F
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x00101927 File Offset: 0x000FFB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00101930 File Offset: 0x000FFB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessCasketRequest);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00101940 File Offset: 0x000FFB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessCasketRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.accessEntityIncIds_.Equals(other.accessEntityIncIds_) && this.IsEnter == other.IsEnter && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x001019B0 File Offset: 0x000FFBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			num ^= this.accessEntityIncIds_.GetHashCode();
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x00101A2F File Offset: 0x000FFC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00101A3C File Offset: 0x000FFC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00101A48 File Offset: 0x000FFC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CasketEntityIncId);
			}
			this.accessEntityIncIds_.WriteTo(ref output, EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.IsEnter)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00101AD0 File Offset: 0x000FFCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			num += this.accessEntityIncIds_.CalculateSize(EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00101B48 File Offset: 0x000FFD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessCasketRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this.accessEntityIncIds_.Add(other.accessEntityIncIds_);
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00101BBD File Offset: 0x000FFDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00101BC8 File Offset: 0x000FFDC8
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.EntityIncId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.CasketEntityIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.accessEntityIncIds_.AddEntriesFrom(ref input, EntityAccessCasketRequest._repeated_accessEntityIncIds_codec);
						continue;
					}
					if (num == 120U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A5A RID: 14938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A5B RID: 14939
		public const int EntityIncIdFieldNumber = 2;

		// Token: 0x04003A5C RID: 14940
		private long entityIncId_;

		// Token: 0x04003A5D RID: 14941
		public const int AccessEntityIncIdsFieldNumber = 11;

		// Token: 0x04003A5E RID: 14942
		private static readonly FieldCodec<long> _repeated_accessEntityIncIds_codec = FieldCodec.ForInt64(90U);

		// Token: 0x04003A5F RID: 14943
		private readonly RepeatedField<long> accessEntityIncIds_ = new RepeatedField<long>();

		// Token: 0x04003A60 RID: 14944
		public const int IsEnterFieldNumber = 15;

		// Token: 0x04003A61 RID: 14945
		private bool isEnter_;

		// Token: 0x04003A62 RID: 14946
		public const int CasketEntityIncIdFieldNumber = 10;

		// Token: 0x04003A63 RID: 14947
		private long casketEntityIncId_;
	}
}
