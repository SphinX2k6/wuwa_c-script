using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000981 RID: 2433
	[NetMessage(EMessageId.MainPhantomRecommendRequest)]
	public sealed class MainPhantomRecommendRequest : IMessage<MainPhantomRecommendRequest>, IMessage, IEquatable<MainPhantomRecommendRequest>, IDeepCloneable<MainPhantomRecommendRequest>, IBufferMessage
	{
		// Token: 0x0600D5FC RID: 54780 RVA: 0x001F7A12 File Offset: 0x001F5C12
		[NullableContext(1)]
		public static MainPhantomRecommendRequest Create()
		{
			return new MainPhantomRecommendRequest();
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x001F7A19 File Offset: 0x001F5C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x001F7A1C File Offset: 0x001F5C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0600D5FF RID: 54783 RVA: 0x001F7A23 File Offset: 0x001F5C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest()
		{
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x001F7A2B File Offset: 0x001F5C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest(MainPhantomRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x001F7A50 File Offset: 0x001F5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendRequest Clone()
		{
			return new MainPhantomRecommendRequest(this);
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600D602 RID: 54786 RVA: 0x001F7A58 File Offset: 0x001F5C58
		// (set) Token: 0x0600D603 RID: 54787 RVA: 0x001F7A60 File Offset: 0x001F5C60
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

		// Token: 0x0600D604 RID: 54788 RVA: 0x001F7A69 File Offset: 0x001F5C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendRequest);
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x001F7A77 File Offset: 0x001F5C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D606 RID: 54790 RVA: 0x001F7AA8 File Offset: 0x001F5CA8
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

		// Token: 0x0600D607 RID: 54791 RVA: 0x001F7AE7 File Offset: 0x001F5CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x001F7AF4 File Offset: 0x001F5CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x001F7AFD File Offset: 0x001F5CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D60A RID: 54794 RVA: 0x001F7B30 File Offset: 0x001F5D30
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

		// Token: 0x0600D60B RID: 54795 RVA: 0x001F7B6E File Offset: 0x001F5D6E
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

		// Token: 0x0600D60C RID: 54796 RVA: 0x001F7B9F File Offset: 0x001F5D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x001F7BA8 File Offset: 0x001F5DA8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005981 RID: 22913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005982 RID: 22914
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04005983 RID: 22915
		private int roleId_;
	}
}
