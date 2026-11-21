using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E7 RID: 231
	[NetMessage(EMessageId.AnimalDropRequest)]
	public sealed class AnimalDropRequest : IMessage<AnimalDropRequest>, IMessage, IEquatable<AnimalDropRequest>, IDeepCloneable<AnimalDropRequest>, IBufferMessage
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x0005AD55 File Offset: 0x00058F55
		[NullableContext(1)]
		public static AnimalDropRequest Create()
		{
			return new AnimalDropRequest();
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0005AD5C File Offset: 0x00058F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x0005AD5F File Offset: 0x00058F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDropRequest.Descriptor;
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0005AD66 File Offset: 0x00058F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest()
		{
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0005AD6E File Offset: 0x00058F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest(AnimalDropRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0005AD93 File Offset: 0x00058F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest Clone()
		{
			return new AnimalDropRequest(this);
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x0005AD9B File Offset: 0x00058F9B
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0005ADA3 File Offset: 0x00058FA3
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

		// Token: 0x06002201 RID: 8705 RVA: 0x0005ADAC File Offset: 0x00058FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDropRequest);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0005ADBA File Offset: 0x00058FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDropRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0005ADE8 File Offset: 0x00058FE8
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

		// Token: 0x06002204 RID: 8708 RVA: 0x0005AE27 File Offset: 0x00059027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0005AE34 File Offset: 0x00059034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0005AE3D File Offset: 0x0005903D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0005AE70 File Offset: 0x00059070
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

		// Token: 0x06002208 RID: 8712 RVA: 0x0005AEAE File Offset: 0x000590AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDropRequest other)
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

		// Token: 0x06002209 RID: 8713 RVA: 0x0005AEDF File Offset: 0x000590DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0005AEE8 File Offset: 0x000590E8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040024AD RID: 9389
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024AE RID: 9390
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040024AF RID: 9391
		private long entityId_;
	}
}
