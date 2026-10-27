using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEE RID: 3566
	[NetMessage(EMessageId.PsnSettingResponse)]
	public sealed class PsnSettingResponse : IMessage<PsnSettingResponse>, IMessage, IEquatable<PsnSettingResponse>, IDeepCloneable<PsnSettingResponse>, IBufferMessage
	{
		// Token: 0x060132E7 RID: 78567 RVA: 0x002CB226 File Offset: 0x002C9426
		[NullableContext(1)]
		public static PsnSettingResponse Create()
		{
			return new PsnSettingResponse();
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x060132E8 RID: 78568 RVA: 0x002CB22D File Offset: 0x002C942D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x060132E9 RID: 78569 RVA: 0x002CB230 File Offset: 0x002C9430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingResponse.Descriptor;
			}
		}

		// Token: 0x060132EA RID: 78570 RVA: 0x002CB237 File Offset: 0x002C9437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse()
		{
		}

		// Token: 0x060132EB RID: 78571 RVA: 0x002CB23F File Offset: 0x002C943F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse(PsnSettingResponse other) : this()
		{
			this.matchPsnUser_ = other.matchPsnUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132EC RID: 78572 RVA: 0x002CB264 File Offset: 0x002C9464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse Clone()
		{
			return new PsnSettingResponse(this);
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x060132ED RID: 78573 RVA: 0x002CB26C File Offset: 0x002C946C
		// (set) Token: 0x060132EE RID: 78574 RVA: 0x002CB274 File Offset: 0x002C9474
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

		// Token: 0x060132EF RID: 78575 RVA: 0x002CB27D File Offset: 0x002C947D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingResponse);
		}

		// Token: 0x060132F0 RID: 78576 RVA: 0x002CB28B File Offset: 0x002C948B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingResponse other)
		{
			return other != null && (other == this || (this.MatchPsnUser == other.MatchPsnUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132F1 RID: 78577 RVA: 0x002CB2BC File Offset: 0x002C94BC
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

		// Token: 0x060132F2 RID: 78578 RVA: 0x002CB2FB File Offset: 0x002C94FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132F3 RID: 78579 RVA: 0x002CB308 File Offset: 0x002C9508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132F4 RID: 78580 RVA: 0x002CB311 File Offset: 0x002C9511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchPsnUser)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.MatchPsnUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132F5 RID: 78581 RVA: 0x002CB344 File Offset: 0x002C9544
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

		// Token: 0x060132F6 RID: 78582 RVA: 0x002CB376 File Offset: 0x002C9576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingResponse other)
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

		// Token: 0x060132F7 RID: 78583 RVA: 0x002CB3A7 File Offset: 0x002C95A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132F8 RID: 78584 RVA: 0x002CB3B0 File Offset: 0x002C95B0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchPsnUser = input.ReadBool();
				}
			}
		}

		// Token: 0x0400761B RID: 30235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400761C RID: 30236
		public const int MatchPsnUserFieldNumber = 15;

		// Token: 0x0400761D RID: 30237
		private bool matchPsnUser_;
	}
}
