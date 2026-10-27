using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000941 RID: 2369
	[NetMessage(EMessageId.LobbyListRequest)]
	public sealed class LobbyListRequest : IMessage<LobbyListRequest>, IMessage, IEquatable<LobbyListRequest>, IDeepCloneable<LobbyListRequest>, IBufferMessage
	{
		// Token: 0x0600D0AE RID: 53422 RVA: 0x001EB289 File Offset: 0x001E9489
		[NullableContext(1)]
		public static LobbyListRequest Create()
		{
			return new LobbyListRequest();
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600D0AF RID: 53423 RVA: 0x001EB290 File Offset: 0x001E9490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600D0B0 RID: 53424 RVA: 0x001EB293 File Offset: 0x001E9493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyListRequest.Descriptor;
			}
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x001EB29A File Offset: 0x001E949A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest()
		{
		}

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x001EB2A2 File Offset: 0x001E94A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest(LobbyListRequest other) : this()
		{
			this.isFriend_ = other.isFriend_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x001EB2C7 File Offset: 0x001E94C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest Clone()
		{
			return new LobbyListRequest(this);
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x001EB2CF File Offset: 0x001E94CF
		// (set) Token: 0x0600D0B5 RID: 53429 RVA: 0x001EB2D7 File Offset: 0x001E94D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFriend
		{
			get
			{
				return this.isFriend_;
			}
			set
			{
				this.isFriend_ = value;
			}
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x001EB2E0 File Offset: 0x001E94E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyListRequest);
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x001EB2EE File Offset: 0x001E94EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyListRequest other)
		{
			return other != null && (other == this || (this.IsFriend == other.IsFriend && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x001EB31C File Offset: 0x001E951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFriend)
			{
				num ^= this.IsFriend.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x001EB35B File Offset: 0x001E955B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x001EB368 File Offset: 0x001E9568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x001EB371 File Offset: 0x001E9571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFriend)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFriend);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x001EB3A4 File Offset: 0x001E95A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFriend)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x001EB3D6 File Offset: 0x001E95D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFriend)
			{
				this.IsFriend = other.IsFriend;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x001EB407 File Offset: 0x001E9607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x001EB410 File Offset: 0x001E9610
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsFriend = input.ReadBool();
				}
			}
		}

		// Token: 0x040057D7 RID: 22487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057D8 RID: 22488
		public const int IsFriendFieldNumber = 7;

		// Token: 0x040057D9 RID: 22489
		private bool isFriend_;
	}
}
