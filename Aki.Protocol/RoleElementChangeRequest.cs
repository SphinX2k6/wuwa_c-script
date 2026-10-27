using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106A RID: 4202
	[NetMessage(EMessageId.RoleElementChangeRequest)]
	public sealed class RoleElementChangeRequest : IMessage<RoleElementChangeRequest>, IMessage, IEquatable<RoleElementChangeRequest>, IDeepCloneable<RoleElementChangeRequest>, IBufferMessage
	{
		// Token: 0x0601674C RID: 91980 RVA: 0x00343C7F File Offset: 0x00341E7F
		[NullableContext(1)]
		public static RoleElementChangeRequest Create()
		{
			return new RoleElementChangeRequest();
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x0601674D RID: 91981 RVA: 0x00343C86 File Offset: 0x00341E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0601674E RID: 91982 RVA: 0x00343C89 File Offset: 0x00341E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleElementChangeRequest.Descriptor;
			}
		}

		// Token: 0x0601674F RID: 91983 RVA: 0x00343C90 File Offset: 0x00341E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest()
		{
		}

		// Token: 0x06016750 RID: 91984 RVA: 0x00343C98 File Offset: 0x00341E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest(RoleElementChangeRequest other) : this()
		{
			this.elementType_ = other.elementType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016751 RID: 91985 RVA: 0x00343CBD File Offset: 0x00341EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest Clone()
		{
			return new RoleElementChangeRequest(this);
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x06016752 RID: 91986 RVA: 0x00343CC5 File Offset: 0x00341EC5
		// (set) Token: 0x06016753 RID: 91987 RVA: 0x00343CCD File Offset: 0x00341ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementType
		{
			get
			{
				return this.elementType_;
			}
			set
			{
				this.elementType_ = value;
			}
		}

		// Token: 0x06016754 RID: 91988 RVA: 0x00343CD6 File Offset: 0x00341ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleElementChangeRequest);
		}

		// Token: 0x06016755 RID: 91989 RVA: 0x00343CE4 File Offset: 0x00341EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleElementChangeRequest other)
		{
			return other != null && (other == this || (this.ElementType == other.ElementType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016756 RID: 91990 RVA: 0x00343D14 File Offset: 0x00341F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ElementType != 0)
			{
				num ^= this.ElementType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016757 RID: 91991 RVA: 0x00343D53 File Offset: 0x00341F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016758 RID: 91992 RVA: 0x00343D60 File Offset: 0x00341F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016759 RID: 91993 RVA: 0x00343D69 File Offset: 0x00341F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ElementType != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ElementType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601675A RID: 91994 RVA: 0x00343D9C File Offset: 0x00341F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ElementType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601675B RID: 91995 RVA: 0x00343DDA File Offset: 0x00341FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleElementChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ElementType != 0)
			{
				this.ElementType = other.ElementType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601675C RID: 91996 RVA: 0x00343E0B File Offset: 0x0034200B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601675D RID: 91997 RVA: 0x00343E14 File Offset: 0x00342014
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ElementType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008657 RID: 34391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008658 RID: 34392
		public const int ElementTypeFieldNumber = 13;

		// Token: 0x04008659 RID: 34393
		private int elementType_;
	}
}
