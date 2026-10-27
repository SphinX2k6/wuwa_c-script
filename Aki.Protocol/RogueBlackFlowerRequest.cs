using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F81 RID: 3969
	[NetMessage(EMessageId.RogueBlackFlowerRequest)]
	public sealed class RogueBlackFlowerRequest : IMessage<RogueBlackFlowerRequest>, IMessage, IEquatable<RogueBlackFlowerRequest>, IDeepCloneable<RogueBlackFlowerRequest>, IBufferMessage
	{
		// Token: 0x06015376 RID: 86902 RVA: 0x00313665 File Offset: 0x00311865
		[NullableContext(1)]
		public static RogueBlackFlowerRequest Create()
		{
			return new RogueBlackFlowerRequest();
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x06015377 RID: 86903 RVA: 0x0031366C File Offset: 0x0031186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x06015378 RID: 86904 RVA: 0x0031366F File Offset: 0x0031186F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerRequest.Descriptor;
			}
		}

		// Token: 0x06015379 RID: 86905 RVA: 0x00313676 File Offset: 0x00311876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest()
		{
		}

		// Token: 0x0601537A RID: 86906 RVA: 0x0031367E File Offset: 0x0031187E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest(RogueBlackFlowerRequest other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.ret_ = other.ret_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601537B RID: 86907 RVA: 0x003136AF File Offset: 0x003118AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest Clone()
		{
			return new RogueBlackFlowerRequest(this);
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x0601537C RID: 86908 RVA: 0x003136B7 File Offset: 0x003118B7
		// (set) Token: 0x0601537D RID: 86909 RVA: 0x003136BF File Offset: 0x003118BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x0601537E RID: 86910 RVA: 0x003136C8 File Offset: 0x003118C8
		// (set) Token: 0x0601537F RID: 86911 RVA: 0x003136D0 File Offset: 0x003118D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ret
		{
			get
			{
				return this.ret_;
			}
			set
			{
				this.ret_ = value;
			}
		}

		// Token: 0x06015380 RID: 86912 RVA: 0x003136D9 File Offset: 0x003118D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerRequest);
		}

		// Token: 0x06015381 RID: 86913 RVA: 0x003136E7 File Offset: 0x003118E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerRequest other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.Ret == other.Ret && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015382 RID: 86914 RVA: 0x00313728 File Offset: 0x00311928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.Ret)
			{
				num ^= this.Ret.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015383 RID: 86915 RVA: 0x00313780 File Offset: 0x00311980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015384 RID: 86916 RVA: 0x0031378D File Offset: 0x0031198D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015385 RID: 86917 RVA: 0x00313798 File Offset: 0x00311998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.Ret)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Ret);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015386 RID: 86918 RVA: 0x003137F4 File Offset: 0x003119F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.Ret)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015387 RID: 86919 RVA: 0x00313840 File Offset: 0x00311A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBlackFlowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.Ret)
			{
				this.Ret = other.Ret;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015388 RID: 86920 RVA: 0x00313890 File Offset: 0x00311A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015389 RID: 86921 RVA: 0x0031389C File Offset: 0x00311A9C
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Ret = input.ReadBool();
					}
				}
				else
				{
					this.EntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F8C RID: 32652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F8D RID: 32653
		public const int EntityConfigIdFieldNumber = 3;

		// Token: 0x04007F8E RID: 32654
		private int entityConfigId_;

		// Token: 0x04007F8F RID: 32655
		public const int RetFieldNumber = 4;

		// Token: 0x04007F90 RID: 32656
		private bool ret_;
	}
}
