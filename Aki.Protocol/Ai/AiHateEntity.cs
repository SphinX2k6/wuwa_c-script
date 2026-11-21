using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172A RID: 5930
	public sealed class AiHateEntity : IMessage<AiHateEntity>, IMessage, IEquatable<AiHateEntity>, IDeepCloneable<AiHateEntity>, IBufferMessage
	{
		// Token: 0x0601DC42 RID: 121922 RVA: 0x0045D901 File Offset: 0x0045BB01
		[NullableContext(1)]
		public static AiHateEntity Create()
		{
			return new AiHateEntity();
		}

		// Token: 0x17006557 RID: 25943
		// (get) Token: 0x0601DC43 RID: 121923 RVA: 0x0045D908 File Offset: 0x0045BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AiHateEntity> Parser
		{
			get
			{
				return AiHateEntity._parser;
			}
		}

		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x0601DC44 RID: 121924 RVA: 0x0045D90F File Offset: 0x0045BB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006559 RID: 25945
		// (get) Token: 0x0601DC45 RID: 121925 RVA: 0x0045D912 File Offset: 0x0045BB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateEntity.Descriptor;
			}
		}

		// Token: 0x0601DC46 RID: 121926 RVA: 0x0045D919 File Offset: 0x0045BB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity()
		{
		}

		// Token: 0x0601DC47 RID: 121927 RVA: 0x0045D921 File Offset: 0x0045BB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity(AiHateEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hatredValue_ = other.hatredValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC48 RID: 121928 RVA: 0x0045D952 File Offset: 0x0045BB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity Clone()
		{
			return new AiHateEntity(this);
		}

		// Token: 0x1700655A RID: 25946
		// (get) Token: 0x0601DC49 RID: 121929 RVA: 0x0045D95A File Offset: 0x0045BB5A
		// (set) Token: 0x0601DC4A RID: 121930 RVA: 0x0045D962 File Offset: 0x0045BB62
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

		// Token: 0x1700655B RID: 25947
		// (get) Token: 0x0601DC4B RID: 121931 RVA: 0x0045D96B File Offset: 0x0045BB6B
		// (set) Token: 0x0601DC4C RID: 121932 RVA: 0x0045D973 File Offset: 0x0045BB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HatredValue
		{
			get
			{
				return this.hatredValue_;
			}
			set
			{
				this.hatredValue_ = value;
			}
		}

		// Token: 0x0601DC4D RID: 121933 RVA: 0x0045D97C File Offset: 0x0045BB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateEntity);
		}

		// Token: 0x0601DC4E RID: 121934 RVA: 0x0045D98A File Offset: 0x0045BB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HatredValue == other.HatredValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC4F RID: 121935 RVA: 0x0045D9C8 File Offset: 0x0045BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HatredValue != 0)
			{
				num ^= this.HatredValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DC50 RID: 121936 RVA: 0x0045DA20 File Offset: 0x0045BC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC51 RID: 121937 RVA: 0x0045DA2D File Offset: 0x0045BC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC52 RID: 121938 RVA: 0x0045DA38 File Offset: 0x0045BC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.HatredValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HatredValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC53 RID: 121939 RVA: 0x0045DA90 File Offset: 0x0045BC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HatredValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HatredValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC54 RID: 121940 RVA: 0x0045DAE8 File Offset: 0x0045BCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HatredValue != 0)
			{
				this.HatredValue = other.HatredValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC55 RID: 121941 RVA: 0x0045DB38 File Offset: 0x0045BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC56 RID: 121942 RVA: 0x0045DB44 File Offset: 0x0045BD44
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HatredValue = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C969 RID: 51561
		private static readonly MessageParser<AiHateEntity> _parser = new MessageParser<AiHateEntity>(() => new AiHateEntity());

		// Token: 0x0400C96A RID: 51562
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C96B RID: 51563
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C96C RID: 51564
		private long entityId_;

		// Token: 0x0400C96D RID: 51565
		public const int HatredValueFieldNumber = 2;

		// Token: 0x0400C96E RID: 51566
		private int hatredValue_;
	}
}
