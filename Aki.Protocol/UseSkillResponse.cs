using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001531 RID: 5425
	[NetMessage(EMessageId.UseSkillResponse)]
	public sealed class UseSkillResponse : IMessage<UseSkillResponse>, IMessage, IEquatable<UseSkillResponse>, IDeepCloneable<UseSkillResponse>, IBufferMessage
	{
		// Token: 0x0601CBD8 RID: 117720 RVA: 0x0042A6D1 File Offset: 0x004288D1
		[NullableContext(1)]
		public static UseSkillResponse Create()
		{
			return new UseSkillResponse();
		}

		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0601CBD9 RID: 117721 RVA: 0x0042A6D8 File Offset: 0x004288D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x0601CBDA RID: 117722 RVA: 0x0042A6DB File Offset: 0x004288DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601CBDB RID: 117723 RVA: 0x0042A6E2 File Offset: 0x004288E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse()
		{
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x0042A6EC File Offset: 0x004288EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse(UseSkillResponse other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x0042A744 File Offset: 0x00428944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillResponse Clone()
		{
			return new UseSkillResponse(this);
		}

		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x0601CBDE RID: 117726 RVA: 0x0042A74C File Offset: 0x0042894C
		// (set) Token: 0x0601CBDF RID: 117727 RVA: 0x0042A754 File Offset: 0x00428954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x0601CBE0 RID: 117728 RVA: 0x0042A75D File Offset: 0x0042895D
		// (set) Token: 0x0601CBE1 RID: 117729 RVA: 0x0042A765 File Offset: 0x00428965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x0601CBE2 RID: 117730 RVA: 0x0042A76E File Offset: 0x0042896E
		// (set) Token: 0x0601CBE3 RID: 117731 RVA: 0x0042A776 File Offset: 0x00428976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601CBE4 RID: 117732 RVA: 0x0042A77F File Offset: 0x0042897F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillResponse);
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x0042A790 File Offset: 0x00428990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBE6 RID: 117734 RVA: 0x0042A7F0 File Offset: 0x004289F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBE7 RID: 117735 RVA: 0x0042A864 File Offset: 0x00428A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBE8 RID: 117736 RVA: 0x0042A871 File Offset: 0x00428A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBE9 RID: 117737 RVA: 0x0042A87C File Offset: 0x00428A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBEA RID: 117738 RVA: 0x0042A8F4 File Offset: 0x00428AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CBEB RID: 117739 RVA: 0x0042A964 File Offset: 0x00428B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBEC RID: 117740 RVA: 0x0042A9E0 File Offset: 0x00428BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBED RID: 117741 RVA: 0x0042A9EC File Offset: 0x00428BEC
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
				if (num != 26U)
				{
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillSingleId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.useSkillInfo_ == null)
					{
						this.UseSkillInfo = new UseSkillInformation();
					}
					input.ReadMessage(this.UseSkillInfo);
				}
			}
		}

		// Token: 0x0400A589 RID: 42377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A58A RID: 42378
		public const int UseSkillInfoFieldNumber = 3;

		// Token: 0x0400A58B RID: 42379
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A58C RID: 42380
		public const int SkillSingleIdFieldNumber = 9;

		// Token: 0x0400A58D RID: 42381
		private int skillSingleId_;

		// Token: 0x0400A58E RID: 42382
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400A58F RID: 42383
		private ErrorCode errorCode_;
	}
}
