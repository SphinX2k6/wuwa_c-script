using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C08 RID: 3080
	[NetMessage(EMessageId.PhantomAttrRecommendRequest)]
	public sealed class PhantomAttrRecommendRequest : IMessage<PhantomAttrRecommendRequest>, IMessage, IEquatable<PhantomAttrRecommendRequest>, IDeepCloneable<PhantomAttrRecommendRequest>, IBufferMessage
	{
		// Token: 0x06010BE9 RID: 68585 RVA: 0x0027451E File Offset: 0x0027271E
		[NullableContext(1)]
		public static PhantomAttrRecommendRequest Create()
		{
			return new PhantomAttrRecommendRequest();
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x06010BEA RID: 68586 RVA: 0x00274525 File Offset: 0x00272725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x06010BEB RID: 68587 RVA: 0x00274528 File Offset: 0x00272728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06010BEC RID: 68588 RVA: 0x0027452F File Offset: 0x0027272F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest()
		{
		}

		// Token: 0x06010BED RID: 68589 RVA: 0x00274537 File Offset: 0x00272737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest(PhantomAttrRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BEE RID: 68590 RVA: 0x0027455C File Offset: 0x0027275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest Clone()
		{
			return new PhantomAttrRecommendRequest(this);
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x06010BEF RID: 68591 RVA: 0x00274564 File Offset: 0x00272764
		// (set) Token: 0x06010BF0 RID: 68592 RVA: 0x0027456C File Offset: 0x0027276C
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

		// Token: 0x06010BF1 RID: 68593 RVA: 0x00274575 File Offset: 0x00272775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendRequest);
		}

		// Token: 0x06010BF2 RID: 68594 RVA: 0x00274583 File Offset: 0x00272783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BF3 RID: 68595 RVA: 0x002745B4 File Offset: 0x002727B4
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

		// Token: 0x06010BF4 RID: 68596 RVA: 0x002745F3 File Offset: 0x002727F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BF5 RID: 68597 RVA: 0x00274600 File Offset: 0x00272800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BF6 RID: 68598 RVA: 0x00274609 File Offset: 0x00272809
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

		// Token: 0x06010BF7 RID: 68599 RVA: 0x0027463C File Offset: 0x0027283C
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

		// Token: 0x06010BF8 RID: 68600 RVA: 0x0027467A File Offset: 0x0027287A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAttrRecommendRequest other)
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

		// Token: 0x06010BF9 RID: 68601 RVA: 0x002746AB File Offset: 0x002728AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BFA RID: 68602 RVA: 0x002746B4 File Offset: 0x002728B4
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

		// Token: 0x04006ACE RID: 27342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ACF RID: 27343
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04006AD0 RID: 27344
		private int roleId_;
	}
}
