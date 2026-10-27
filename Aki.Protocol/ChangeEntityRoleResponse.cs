using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024B RID: 587
	[NetMessage(EMessageId.ChangeEntityRoleResponse)]
	public sealed class ChangeEntityRoleResponse : IMessage<ChangeEntityRoleResponse>, IMessage, IEquatable<ChangeEntityRoleResponse>, IDeepCloneable<ChangeEntityRoleResponse>, IBufferMessage
	{
		// Token: 0x06003EBB RID: 16059 RVA: 0x0009AAAF File Offset: 0x00098CAF
		[NullableContext(1)]
		public static ChangeEntityRoleResponse Create()
		{
			return new ChangeEntityRoleResponse();
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x0009AAB6 File Offset: 0x00098CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x0009AAB9 File Offset: 0x00098CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityRoleResponse.Descriptor;
			}
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x0009AAC0 File Offset: 0x00098CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse()
		{
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0009AAC8 File Offset: 0x00098CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse(ChangeEntityRoleResponse other) : this()
		{
			this.success_ = other.success_;
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0009AB05 File Offset: 0x00098D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse Clone()
		{
			return new ChangeEntityRoleResponse(this);
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x0009AB0D File Offset: 0x00098D0D
		// (set) Token: 0x06003EC2 RID: 16066 RVA: 0x0009AB15 File Offset: 0x00098D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06003EC3 RID: 16067 RVA: 0x0009AB1E File Offset: 0x00098D1E
		// (set) Token: 0x06003EC4 RID: 16068 RVA: 0x0009AB26 File Offset: 0x00098D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x0009AB2F File Offset: 0x00098D2F
		// (set) Token: 0x06003EC6 RID: 16070 RVA: 0x0009AB37 File Offset: 0x00098D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0009AB40 File Offset: 0x00098D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityRoleResponse);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0009AB50 File Offset: 0x00098D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityRoleResponse other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x0009ABAC File Offset: 0x00098DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0009AC1D File Offset: 0x00098E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x0009AC2A File Offset: 0x00098E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0009AC34 File Offset: 0x00098E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Success)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Success);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0009ACAC File Offset: 0x00098EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x0009AD10 File Offset: 0x00098F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0009AD74 File Offset: 0x00098F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0009AD80 File Offset: 0x00098F80
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
					if (num != 24U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Success = input.ReadBool();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002CF3 RID: 11507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF4 RID: 11508
		public const int SuccessFieldNumber = 10;

		// Token: 0x04002CF5 RID: 11509
		private bool success_;

		// Token: 0x04002CF6 RID: 11510
		public const int IdFieldNumber = 2;

		// Token: 0x04002CF7 RID: 11511
		private long id_;

		// Token: 0x04002CF8 RID: 11512
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04002CF9 RID: 11513
		private int playerId_;
	}
}
