using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDF RID: 3551
	[NetMessage(EMessageId.PsnSettingUpdateRequest)]
	public sealed class PsnSettingUpdateRequest : IMessage<PsnSettingUpdateRequest>, IMessage, IEquatable<PsnSettingUpdateRequest>, IDeepCloneable<PsnSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x06013214 RID: 78356 RVA: 0x002C9D31 File Offset: 0x002C7F31
		[NullableContext(1)]
		public static PsnSettingUpdateRequest Create()
		{
			return new PsnSettingUpdateRequest();
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x06013215 RID: 78357 RVA: 0x002C9D38 File Offset: 0x002C7F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x06013216 RID: 78358 RVA: 0x002C9D3B File Offset: 0x002C7F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06013217 RID: 78359 RVA: 0x002C9D42 File Offset: 0x002C7F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest()
		{
		}

		// Token: 0x06013218 RID: 78360 RVA: 0x002C9D4A File Offset: 0x002C7F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest(PsnSettingUpdateRequest other) : this()
		{
			this.matchPsnUser_ = other.matchPsnUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013219 RID: 78361 RVA: 0x002C9D6F File Offset: 0x002C7F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingUpdateRequest Clone()
		{
			return new PsnSettingUpdateRequest(this);
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0601321A RID: 78362 RVA: 0x002C9D77 File Offset: 0x002C7F77
		// (set) Token: 0x0601321B RID: 78363 RVA: 0x002C9D7F File Offset: 0x002C7F7F
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

		// Token: 0x0601321C RID: 78364 RVA: 0x002C9D88 File Offset: 0x002C7F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingUpdateRequest);
		}

		// Token: 0x0601321D RID: 78365 RVA: 0x002C9D96 File Offset: 0x002C7F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.MatchPsnUser == other.MatchPsnUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601321E RID: 78366 RVA: 0x002C9DC4 File Offset: 0x002C7FC4
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

		// Token: 0x0601321F RID: 78367 RVA: 0x002C9E03 File Offset: 0x002C8003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013220 RID: 78368 RVA: 0x002C9E10 File Offset: 0x002C8010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013221 RID: 78369 RVA: 0x002C9E19 File Offset: 0x002C8019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchPsnUser)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.MatchPsnUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013222 RID: 78370 RVA: 0x002C9E4C File Offset: 0x002C804C
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

		// Token: 0x06013223 RID: 78371 RVA: 0x002C9E7E File Offset: 0x002C807E
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

		// Token: 0x06013224 RID: 78372 RVA: 0x002C9EAF File Offset: 0x002C80AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013225 RID: 78373 RVA: 0x002C9EB8 File Offset: 0x002C80B8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchPsnUser = input.ReadBool();
				}
			}
		}

		// Token: 0x04007648 RID: 30280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007649 RID: 30281
		public const int MatchPsnUserFieldNumber = 12;

		// Token: 0x0400764A RID: 30282
		private bool matchPsnUser_;
	}
}
