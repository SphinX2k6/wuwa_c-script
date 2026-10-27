using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB1 RID: 4017
	[NetMessage(EMessageId.RoguelikeRoleInstStartRequest)]
	public sealed class RoguelikeRoleInstStartRequest : IMessage<RoguelikeRoleInstStartRequest>, IMessage, IEquatable<RoguelikeRoleInstStartRequest>, IDeepCloneable<RoguelikeRoleInstStartRequest>, IBufferMessage
	{
		// Token: 0x060157B3 RID: 87987 RVA: 0x0031E5CF File Offset: 0x0031C7CF
		[NullableContext(1)]
		public static RoguelikeRoleInstStartRequest Create()
		{
			return new RoguelikeRoleInstStartRequest();
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x060157B4 RID: 87988 RVA: 0x0031E5D6 File Offset: 0x0031C7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x060157B5 RID: 87989 RVA: 0x0031E5D9 File Offset: 0x0031C7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleInstStartRequest.Descriptor;
			}
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x0031E5E0 File Offset: 0x0031C7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest()
		{
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x0031E5E8 File Offset: 0x0031C7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest(RoguelikeRoleInstStartRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x0031E619 File Offset: 0x0031C819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest Clone()
		{
			return new RoguelikeRoleInstStartRequest(this);
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x060157B9 RID: 87993 RVA: 0x0031E621 File Offset: 0x0031C821
		// (set) Token: 0x060157BA RID: 87994 RVA: 0x0031E629 File Offset: 0x0031C829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x060157BB RID: 87995 RVA: 0x0031E632 File Offset: 0x0031C832
		// (set) Token: 0x060157BC RID: 87996 RVA: 0x0031E63A File Offset: 0x0031C83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060157BD RID: 87997 RVA: 0x0031E643 File Offset: 0x0031C843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleInstStartRequest);
		}

		// Token: 0x060157BE RID: 87998 RVA: 0x0031E651 File Offset: 0x0031C851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleInstStartRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157BF RID: 87999 RVA: 0x0031E690 File Offset: 0x0031C890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157C0 RID: 88000 RVA: 0x0031E6E8 File Offset: 0x0031C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157C1 RID: 88001 RVA: 0x0031E6F5 File Offset: 0x0031C8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157C2 RID: 88002 RVA: 0x0031E700 File Offset: 0x0031C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157C3 RID: 88003 RVA: 0x0031E75C File Offset: 0x0031C95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060157C4 RID: 88004 RVA: 0x0031E7B4 File Offset: 0x0031C9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060157C5 RID: 88005 RVA: 0x0031E804 File Offset: 0x0031CA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x0031E810 File Offset: 0x0031CA10
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
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400812C RID: 33068
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400812D RID: 33069
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x0400812E RID: 33070
		private int activityId_;

		// Token: 0x0400812F RID: 33071
		public const int IndexFieldNumber = 12;

		// Token: 0x04008130 RID: 33072
		private int index_;
	}
}
