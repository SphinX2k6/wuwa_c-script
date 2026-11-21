using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001700 RID: 5888
	[NetMessage(EMessageId.CombatMessagePostInfoResponse)]
	public sealed class CombatMessagePostInfoResponse : IMessage<CombatMessagePostInfoResponse>, IMessage, IEquatable<CombatMessagePostInfoResponse>, IDeepCloneable<CombatMessagePostInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D6AE RID: 120494 RVA: 0x00441B55 File Offset: 0x0043FD55
		[NullableContext(1)]
		public static CombatMessagePostInfoResponse Create()
		{
			return new CombatMessagePostInfoResponse();
		}

		// Token: 0x1700637F RID: 25471
		// (get) Token: 0x0601D6AF RID: 120495 RVA: 0x00441B5C File Offset: 0x0043FD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006380 RID: 25472
		// (get) Token: 0x0601D6B0 RID: 120496 RVA: 0x00441B5F File Offset: 0x0043FD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePostInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D6B1 RID: 120497 RVA: 0x00441B66 File Offset: 0x0043FD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse()
		{
		}

		// Token: 0x0601D6B2 RID: 120498 RVA: 0x00441B79 File Offset: 0x0043FD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse(CombatMessagePostInfoResponse other) : this()
		{
			this.postInfo_ = other.postInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D6B3 RID: 120499 RVA: 0x00441B9E File Offset: 0x0043FD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse Clone()
		{
			return new CombatMessagePostInfoResponse(this);
		}

		// Token: 0x17006381 RID: 25473
		// (get) Token: 0x0601D6B4 RID: 120500 RVA: 0x00441BA6 File Offset: 0x0043FDA6
		// (set) Token: 0x0601D6B5 RID: 120501 RVA: 0x00441BAE File Offset: 0x0043FDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PostInfo
		{
			get
			{
				return this.postInfo_;
			}
			set
			{
				this.postInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601D6B6 RID: 120502 RVA: 0x00441BC1 File Offset: 0x0043FDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePostInfoResponse);
		}

		// Token: 0x0601D6B7 RID: 120503 RVA: 0x00441BCF File Offset: 0x0043FDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePostInfoResponse other)
		{
			return other != null && (other == this || (!(this.PostInfo != other.PostInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D6B8 RID: 120504 RVA: 0x00441C04 File Offset: 0x0043FE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PostInfo.Length != 0)
			{
				num ^= this.PostInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D6B9 RID: 120505 RVA: 0x00441C45 File Offset: 0x0043FE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D6BA RID: 120506 RVA: 0x00441C52 File Offset: 0x0043FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D6BB RID: 120507 RVA: 0x00441C5B File Offset: 0x0043FE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PostInfo.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.PostInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D6BC RID: 120508 RVA: 0x00441C94 File Offset: 0x0043FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PostInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PostInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D6BD RID: 120509 RVA: 0x00441CD7 File Offset: 0x0043FED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePostInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PostInfo.Length != 0)
			{
				this.PostInfo = other.PostInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D6BE RID: 120510 RVA: 0x00441D0D File Offset: 0x0043FF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D6BF RID: 120511 RVA: 0x00441D18 File Offset: 0x0043FF18
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PostInfo = input.ReadString();
				}
			}
		}

		// Token: 0x0400C73A RID: 51002
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C73B RID: 51003
		public const int PostInfoFieldNumber = 14;

		// Token: 0x0400C73C RID: 51004
		private string postInfo_ = "";
	}
}
