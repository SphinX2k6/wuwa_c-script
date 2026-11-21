using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049B RID: 1179
	[NetMessage(EMessageId.EntityPosAbnormalResponse)]
	public sealed class EntityPosAbnormalResponse : IMessage<EntityPosAbnormalResponse>, IMessage, IEquatable<EntityPosAbnormalResponse>, IDeepCloneable<EntityPosAbnormalResponse>, IBufferMessage
	{
		// Token: 0x06007104 RID: 28932 RVA: 0x00116274 File Offset: 0x00114474
		[NullableContext(1)]
		public static EntityPosAbnormalResponse Create()
		{
			return new EntityPosAbnormalResponse();
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x0011627B File Offset: 0x0011447B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x0011627E File Offset: 0x0011447E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosAbnormalResponse.Descriptor;
			}
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00116285 File Offset: 0x00114485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse()
		{
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x0011628D File Offset: 0x0011448D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse(EntityPosAbnormalResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x001162B2 File Offset: 0x001144B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse Clone()
		{
			return new EntityPosAbnormalResponse(this);
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x001162BA File Offset: 0x001144BA
		// (set) Token: 0x0600710B RID: 28939 RVA: 0x001162C2 File Offset: 0x001144C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x001162CB File Offset: 0x001144CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosAbnormalResponse);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x001162D9 File Offset: 0x001144D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosAbnormalResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00116308 File Offset: 0x00114508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x0011634D File Offset: 0x0011454D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x0011635A File Offset: 0x0011455A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00116363 File Offset: 0x00114563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x00116398 File Offset: 0x00114598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x001163D6 File Offset: 0x001145D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPosAbnormalResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00116407 File Offset: 0x00114607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x00116410 File Offset: 0x00114610
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003CDA RID: 15578
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CDB RID: 15579
		public const int CodeFieldNumber = 8;

		// Token: 0x04003CDC RID: 15580
		private ErrorCode code_;
	}
}
