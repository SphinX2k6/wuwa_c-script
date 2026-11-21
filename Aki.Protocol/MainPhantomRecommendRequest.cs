using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000970 RID: 2416
	[NetMessage(EMessageId.MainPhantomRecommendRequest)]
	public sealed class MainPhantomRecommendRequest : IMessage<MainPhantomRecommendRequest>, IMessage, IEquatable<MainPhantomRecommendRequest>, IDeepCloneable<MainPhantomRecommendRequest>, IBufferMessage
	{
		// Token: 0x0600D4E2 RID: 54498 RVA: 0x001F582A File Offset: 0x001F3A2A
		[NullableContext(1)]
		public static MainPhantomRecommendRequest Create()
		{
			return new MainPhantomRecommendRequest();
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x001F5831 File Offset: 0x001F3A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600D4E4 RID: 54500 RVA: 0x001F5834 File Offset: 0x001F3A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x001F583B File Offset: 0x001F3A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest()
		{
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x001F5843 File Offset: 0x001F3A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest(MainPhantomRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x001F5868 File Offset: 0x001F3A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest Clone()
		{
			return new MainPhantomRecommendRequest(this);
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600D4E8 RID: 54504 RVA: 0x001F5870 File Offset: 0x001F3A70
		// (set) Token: 0x0600D4E9 RID: 54505 RVA: 0x001F5878 File Offset: 0x001F3A78
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

		// Token: 0x0600D4EA RID: 54506 RVA: 0x001F5881 File Offset: 0x001F3A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendRequest);
		}

		// Token: 0x0600D4EB RID: 54507 RVA: 0x001F588F File Offset: 0x001F3A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4EC RID: 54508 RVA: 0x001F58C0 File Offset: 0x001F3AC0
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

		// Token: 0x0600D4ED RID: 54509 RVA: 0x001F58FF File Offset: 0x001F3AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4EE RID: 54510 RVA: 0x001F590C File Offset: 0x001F3B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x001F5915 File Offset: 0x001F3B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4F0 RID: 54512 RVA: 0x001F5948 File Offset: 0x001F3B48
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

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x001F5986 File Offset: 0x001F3B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MainPhantomRecommendRequest other)
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

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x001F59B7 File Offset: 0x001F3BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x001F59C0 File Offset: 0x001F3BC0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400598A RID: 22922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400598B RID: 22923
		public const int RoleIdFieldNumber = 9;

		// Token: 0x0400598C RID: 22924
		private int roleId_;
	}
}
