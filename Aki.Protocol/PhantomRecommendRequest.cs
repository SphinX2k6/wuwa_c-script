using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF6 RID: 3318
	[NetMessage(EMessageId.PhantomRecommendRequest)]
	public sealed class PhantomRecommendRequest : IMessage<PhantomRecommendRequest>, IMessage, IEquatable<PhantomRecommendRequest>, IDeepCloneable<PhantomRecommendRequest>, IBufferMessage
	{
		// Token: 0x06011F12 RID: 73490 RVA: 0x0029FBAF File Offset: 0x0029DDAF
		[NullableContext(1)]
		public static PhantomRecommendRequest Create()
		{
			return new PhantomRecommendRequest();
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x06011F13 RID: 73491 RVA: 0x0029FBB6 File Offset: 0x0029DDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x06011F14 RID: 73492 RVA: 0x0029FBB9 File Offset: 0x0029DDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06011F15 RID: 73493 RVA: 0x0029FBC0 File Offset: 0x0029DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest()
		{
		}

		// Token: 0x06011F16 RID: 73494 RVA: 0x0029FBC8 File Offset: 0x0029DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest(PhantomRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F17 RID: 73495 RVA: 0x0029FBED File Offset: 0x0029DDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendRequest Clone()
		{
			return new PhantomRecommendRequest(this);
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x06011F18 RID: 73496 RVA: 0x0029FBF5 File Offset: 0x0029DDF5
		// (set) Token: 0x06011F19 RID: 73497 RVA: 0x0029FBFD File Offset: 0x0029DDFD
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

		// Token: 0x06011F1A RID: 73498 RVA: 0x0029FC06 File Offset: 0x0029DE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendRequest);
		}

		// Token: 0x06011F1B RID: 73499 RVA: 0x0029FC14 File Offset: 0x0029DE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F1C RID: 73500 RVA: 0x0029FC44 File Offset: 0x0029DE44
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

		// Token: 0x06011F1D RID: 73501 RVA: 0x0029FC83 File Offset: 0x0029DE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F1E RID: 73502 RVA: 0x0029FC90 File Offset: 0x0029DE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F1F RID: 73503 RVA: 0x0029FC99 File Offset: 0x0029DE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F20 RID: 73504 RVA: 0x0029FCCC File Offset: 0x0029DECC
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

		// Token: 0x06011F21 RID: 73505 RVA: 0x0029FD0A File Offset: 0x0029DF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRecommendRequest other)
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

		// Token: 0x06011F22 RID: 73506 RVA: 0x0029FD3B File Offset: 0x0029DF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F23 RID: 73507 RVA: 0x0029FD44 File Offset: 0x0029DF44
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400707F RID: 28799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007080 RID: 28800
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04007081 RID: 28801
		private int roleId_;
	}
}
