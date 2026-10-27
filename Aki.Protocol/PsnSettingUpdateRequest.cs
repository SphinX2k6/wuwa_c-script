using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEF RID: 3567
	[NetMessage(EMessageId.PsnSettingUpdateRequest)]
	public sealed class PsnSettingUpdateRequest : IMessage<PsnSettingUpdateRequest>, IMessage, IEquatable<PsnSettingUpdateRequest>, IDeepCloneable<PsnSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x060132F9 RID: 78585 RVA: 0x002CB3F5 File Offset: 0x002C95F5
		[NullableContext(1)]
		public static PsnSettingUpdateRequest Create()
		{
			return new PsnSettingUpdateRequest();
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x060132FA RID: 78586 RVA: 0x002CB3FC File Offset: 0x002C95FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x060132FB RID: 78587 RVA: 0x002CB3FF File Offset: 0x002C95FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x060132FC RID: 78588 RVA: 0x002CB406 File Offset: 0x002C9606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest()
		{
		}

		// Token: 0x060132FD RID: 78589 RVA: 0x002CB40E File Offset: 0x002C960E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest(PsnSettingUpdateRequest other) : this()
		{
			this.matchPsnUser_ = other.matchPsnUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132FE RID: 78590 RVA: 0x002CB433 File Offset: 0x002C9633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest Clone()
		{
			return new PsnSettingUpdateRequest(this);
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x060132FF RID: 78591 RVA: 0x002CB43B File Offset: 0x002C963B
		// (set) Token: 0x06013300 RID: 78592 RVA: 0x002CB443 File Offset: 0x002C9643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchPsnUser
		{
			get
			{
				return this.matchPsnUser_;
			}
			set
			{
				this.matchPsnUser_ = value;
			}
		}

		// Token: 0x06013301 RID: 78593 RVA: 0x002CB44C File Offset: 0x002C964C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingUpdateRequest);
		}

		// Token: 0x06013302 RID: 78594 RVA: 0x002CB45A File Offset: 0x002C965A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.MatchPsnUser == other.MatchPsnUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013303 RID: 78595 RVA: 0x002CB488 File Offset: 0x002C9688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MatchPsnUser)
			{
				num ^= this.MatchPsnUser.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013304 RID: 78596 RVA: 0x002CB4C7 File Offset: 0x002C96C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013305 RID: 78597 RVA: 0x002CB4D4 File Offset: 0x002C96D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013306 RID: 78598 RVA: 0x002CB4DD File Offset: 0x002C96DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchPsnUser)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.MatchPsnUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013307 RID: 78599 RVA: 0x002CB510 File Offset: 0x002C9710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MatchPsnUser)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013308 RID: 78600 RVA: 0x002CB542 File Offset: 0x002C9742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MatchPsnUser)
			{
				this.MatchPsnUser = other.MatchPsnUser;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013309 RID: 78601 RVA: 0x002CB573 File Offset: 0x002C9773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601330A RID: 78602 RVA: 0x002CB57C File Offset: 0x002C977C
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
					this.MatchPsnUser = input.ReadBool();
				}
			}
		}

		// Token: 0x0400761E RID: 30238
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400761F RID: 30239
		public const int MatchPsnUserFieldNumber = 4;

		// Token: 0x04007620 RID: 30240
		private bool matchPsnUser_;
	}
}
