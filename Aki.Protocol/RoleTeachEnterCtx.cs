using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C5 RID: 4293
	public sealed class RoleTeachEnterCtx : IMessage<RoleTeachEnterCtx>, IMessage, IEquatable<RoleTeachEnterCtx>, IDeepCloneable<RoleTeachEnterCtx>, IBufferMessage
	{
		// Token: 0x06016E8D RID: 93837 RVA: 0x0035383D File Offset: 0x00351A3D
		[NullableContext(1)]
		public static RoleTeachEnterCtx Create()
		{
			return new RoleTeachEnterCtx();
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x06016E8E RID: 93838 RVA: 0x00353844 File Offset: 0x00351A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x06016E8F RID: 93839 RVA: 0x00353847 File Offset: 0x00351A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTeachEnterCtx.Descriptor;
			}
		}

		// Token: 0x06016E90 RID: 93840 RVA: 0x0035384E File Offset: 0x00351A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx()
		{
		}

		// Token: 0x06016E91 RID: 93841 RVA: 0x00353856 File Offset: 0x00351A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx(RoleTeachEnterCtx other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E92 RID: 93842 RVA: 0x0035387B File Offset: 0x00351A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx Clone()
		{
			return new RoleTeachEnterCtx(this);
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x06016E93 RID: 93843 RVA: 0x00353883 File Offset: 0x00351A83
		// (set) Token: 0x06016E94 RID: 93844 RVA: 0x0035388B File Offset: 0x00351A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06016E95 RID: 93845 RVA: 0x00353894 File Offset: 0x00351A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTeachEnterCtx);
		}

		// Token: 0x06016E96 RID: 93846 RVA: 0x003538A2 File Offset: 0x00351AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTeachEnterCtx other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E97 RID: 93847 RVA: 0x003538D0 File Offset: 0x00351AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E98 RID: 93848 RVA: 0x0035390F File Offset: 0x00351B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E99 RID: 93849 RVA: 0x0035391C File Offset: 0x00351B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E9A RID: 93850 RVA: 0x00353925 File Offset: 0x00351B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E9B RID: 93851 RVA: 0x00353958 File Offset: 0x00351B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E9C RID: 93852 RVA: 0x00353996 File Offset: 0x00351B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTeachEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E9D RID: 93853 RVA: 0x003539C7 File Offset: 0x00351BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E9E RID: 93854 RVA: 0x003539D0 File Offset: 0x00351BD0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008888 RID: 34952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008889 RID: 34953
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400888A RID: 34954
		private int roleId_;
	}
}
