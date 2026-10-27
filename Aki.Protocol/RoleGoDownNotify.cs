using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001082 RID: 4226
	[NetMessage(EMessageId.RoleGoDownNotify)]
	public sealed class RoleGoDownNotify : IMessage<RoleGoDownNotify>, IMessage, IEquatable<RoleGoDownNotify>, IDeepCloneable<RoleGoDownNotify>, IBufferMessage
	{
		// Token: 0x06016930 RID: 92464 RVA: 0x00347D2D File Offset: 0x00345F2D
		[NullableContext(1)]
		public static RoleGoDownNotify Create()
		{
			return new RoleGoDownNotify();
		}

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x06016931 RID: 92465 RVA: 0x00347D34 File Offset: 0x00345F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x06016932 RID: 92466 RVA: 0x00347D37 File Offset: 0x00345F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGoDownNotify.Descriptor;
			}
		}

		// Token: 0x06016933 RID: 92467 RVA: 0x00347D3E File Offset: 0x00345F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify()
		{
		}

		// Token: 0x06016934 RID: 92468 RVA: 0x00347D46 File Offset: 0x00345F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify(RoleGoDownNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016935 RID: 92469 RVA: 0x00347D6B File Offset: 0x00345F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownNotify Clone()
		{
			return new RoleGoDownNotify(this);
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x06016936 RID: 92470 RVA: 0x00347D73 File Offset: 0x00345F73
		// (set) Token: 0x06016937 RID: 92471 RVA: 0x00347D7B File Offset: 0x00345F7B
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

		// Token: 0x06016938 RID: 92472 RVA: 0x00347D84 File Offset: 0x00345F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGoDownNotify);
		}

		// Token: 0x06016939 RID: 92473 RVA: 0x00347D92 File Offset: 0x00345F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGoDownNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601693A RID: 92474 RVA: 0x00347DC0 File Offset: 0x00345FC0
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

		// Token: 0x0601693B RID: 92475 RVA: 0x00347DFF File Offset: 0x00345FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601693C RID: 92476 RVA: 0x00347E0C File Offset: 0x0034600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601693D RID: 92477 RVA: 0x00347E15 File Offset: 0x00346015
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

		// Token: 0x0601693E RID: 92478 RVA: 0x00347E48 File Offset: 0x00346048
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

		// Token: 0x0601693F RID: 92479 RVA: 0x00347E86 File Offset: 0x00346086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGoDownNotify other)
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

		// Token: 0x06016940 RID: 92480 RVA: 0x00347EB7 File Offset: 0x003460B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016941 RID: 92481 RVA: 0x00347EC0 File Offset: 0x003460C0
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

		// Token: 0x040086DF RID: 34527
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086E0 RID: 34528
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040086E1 RID: 34529
		private long entityId_;
	}
}
