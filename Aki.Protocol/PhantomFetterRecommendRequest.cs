using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC2 RID: 3266
	[NetMessage(EMessageId.PhantomFetterRecommendRequest)]
	public sealed class PhantomFetterRecommendRequest : IMessage<PhantomFetterRecommendRequest>, IMessage, IEquatable<PhantomFetterRecommendRequest>, IDeepCloneable<PhantomFetterRecommendRequest>, IBufferMessage
	{
		// Token: 0x06011B3F RID: 72511 RVA: 0x00297B2A File Offset: 0x00295D2A
		[NullableContext(1)]
		public static PhantomFetterRecommendRequest Create()
		{
			return new PhantomFetterRecommendRequest();
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x06011B40 RID: 72512 RVA: 0x00297B31 File Offset: 0x00295D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x06011B41 RID: 72513 RVA: 0x00297B34 File Offset: 0x00295D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06011B42 RID: 72514 RVA: 0x00297B3B File Offset: 0x00295D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest()
		{
		}

		// Token: 0x06011B43 RID: 72515 RVA: 0x00297B43 File Offset: 0x00295D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest(PhantomFetterRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B44 RID: 72516 RVA: 0x00297B68 File Offset: 0x00295D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest Clone()
		{
			return new PhantomFetterRecommendRequest(this);
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x06011B45 RID: 72517 RVA: 0x00297B70 File Offset: 0x00295D70
		// (set) Token: 0x06011B46 RID: 72518 RVA: 0x00297B78 File Offset: 0x00295D78
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

		// Token: 0x06011B47 RID: 72519 RVA: 0x00297B81 File Offset: 0x00295D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendRequest);
		}

		// Token: 0x06011B48 RID: 72520 RVA: 0x00297B8F File Offset: 0x00295D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B49 RID: 72521 RVA: 0x00297BC0 File Offset: 0x00295DC0
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

		// Token: 0x06011B4A RID: 72522 RVA: 0x00297BFF File Offset: 0x00295DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B4B RID: 72523 RVA: 0x00297C0C File Offset: 0x00295E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B4C RID: 72524 RVA: 0x00297C15 File Offset: 0x00295E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B4D RID: 72525 RVA: 0x00297C48 File Offset: 0x00295E48
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

		// Token: 0x06011B4E RID: 72526 RVA: 0x00297C86 File Offset: 0x00295E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterRecommendRequest other)
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

		// Token: 0x06011B4F RID: 72527 RVA: 0x00297CB7 File Offset: 0x00295EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B50 RID: 72528 RVA: 0x00297CC0 File Offset: 0x00295EC0
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
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006FB7 RID: 28599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FB8 RID: 28600
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04006FB9 RID: 28601
		private int roleId_;
	}
}
