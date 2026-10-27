using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDD RID: 3549
	[NetMessage(EMessageId.PrivateChatDataResponse)]
	public sealed class PrivateChatDataResponse : IMessage<PrivateChatDataResponse>, IMessage, IEquatable<PrivateChatDataResponse>, IDeepCloneable<PrivateChatDataResponse>, IBufferMessage
	{
		// Token: 0x0601318D RID: 78221 RVA: 0x002C83AE File Offset: 0x002C65AE
		[NullableContext(1)]
		public static PrivateChatDataResponse Create()
		{
			return new PrivateChatDataResponse();
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0601318E RID: 78222 RVA: 0x002C83B5 File Offset: 0x002C65B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0601318F RID: 78223 RVA: 0x002C83B8 File Offset: 0x002C65B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatDataResponse.Descriptor;
			}
		}

		// Token: 0x06013190 RID: 78224 RVA: 0x002C83BF File Offset: 0x002C65BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse()
		{
		}

		// Token: 0x06013191 RID: 78225 RVA: 0x002C83C7 File Offset: 0x002C65C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse(PrivateChatDataResponse other) : this()
		{
			this.loadSucc_ = other.loadSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013192 RID: 78226 RVA: 0x002C83EC File Offset: 0x002C65EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataResponse Clone()
		{
			return new PrivateChatDataResponse(this);
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x06013193 RID: 78227 RVA: 0x002C83F4 File Offset: 0x002C65F4
		// (set) Token: 0x06013194 RID: 78228 RVA: 0x002C83FC File Offset: 0x002C65FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LoadSucc
		{
			get
			{
				return this.loadSucc_;
			}
			set
			{
				this.loadSucc_ = value;
			}
		}

		// Token: 0x06013195 RID: 78229 RVA: 0x002C8405 File Offset: 0x002C6605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatDataResponse);
		}

		// Token: 0x06013196 RID: 78230 RVA: 0x002C8413 File Offset: 0x002C6613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatDataResponse other)
		{
			return other != null && (other == this || (this.LoadSucc == other.LoadSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013197 RID: 78231 RVA: 0x002C8444 File Offset: 0x002C6644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadSucc)
			{
				num ^= this.LoadSucc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013198 RID: 78232 RVA: 0x002C8483 File Offset: 0x002C6683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013199 RID: 78233 RVA: 0x002C8490 File Offset: 0x002C6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601319A RID: 78234 RVA: 0x002C8499 File Offset: 0x002C6699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadSucc)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.LoadSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601319B RID: 78235 RVA: 0x002C84CC File Offset: 0x002C66CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadSucc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601319C RID: 78236 RVA: 0x002C84FE File Offset: 0x002C66FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadSucc)
			{
				this.LoadSucc = other.LoadSucc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601319D RID: 78237 RVA: 0x002C852F File Offset: 0x002C672F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601319E RID: 78238 RVA: 0x002C8538 File Offset: 0x002C6738
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x040075BD RID: 30141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075BE RID: 30142
		public const int LoadSuccFieldNumber = 12;

		// Token: 0x040075BF RID: 30143
		private bool loadSucc_;
	}
}
