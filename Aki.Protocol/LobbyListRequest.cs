using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000930 RID: 2352
	[NetMessage(EMessageId.LobbyListRequest)]
	public sealed class LobbyListRequest : IMessage<LobbyListRequest>, IMessage, IEquatable<LobbyListRequest>, IDeepCloneable<LobbyListRequest>, IBufferMessage
	{
		// Token: 0x0600CF92 RID: 53138 RVA: 0x001E8FB5 File Offset: 0x001E71B5
		[NullableContext(1)]
		public static LobbyListRequest Create()
		{
			return new LobbyListRequest();
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600CF93 RID: 53139 RVA: 0x001E8FBC File Offset: 0x001E71BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x001E8FBF File Offset: 0x001E71BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyListRequest.Descriptor;
			}
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x001E8FC6 File Offset: 0x001E71C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest()
		{
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x001E8FCE File Offset: 0x001E71CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest(LobbyListRequest other) : this()
		{
			this.isFriend_ = other.isFriend_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x001E8FF3 File Offset: 0x001E71F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyListRequest Clone()
		{
			return new LobbyListRequest(this);
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x001E8FFB File Offset: 0x001E71FB
		// (set) Token: 0x0600CF99 RID: 53145 RVA: 0x001E9003 File Offset: 0x001E7203
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

		// Token: 0x0600CF9A RID: 53146 RVA: 0x001E900C File Offset: 0x001E720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyListRequest);
		}

		// Token: 0x0600CF9B RID: 53147 RVA: 0x001E901A File Offset: 0x001E721A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyListRequest other)
		{
			return other != null && (other == this || (this.IsFriend == other.IsFriend && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x001E9048 File Offset: 0x001E7248
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

		// Token: 0x0600CF9D RID: 53149 RVA: 0x001E9087 File Offset: 0x001E7287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF9E RID: 53150 RVA: 0x001E9094 File Offset: 0x001E7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x001E909D File Offset: 0x001E729D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFriend)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsFriend);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x001E90D0 File Offset: 0x001E72D0
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

		// Token: 0x0600CFA1 RID: 53153 RVA: 0x001E9102 File Offset: 0x001E7302
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

		// Token: 0x0600CFA2 RID: 53154 RVA: 0x001E9133 File Offset: 0x001E7333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x001E913C File Offset: 0x001E733C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsFriend = input.ReadBool();
				}
			}
		}

		// Token: 0x040057DE RID: 22494
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057DF RID: 22495
		public const int IsFriendFieldNumber = 2;

		// Token: 0x040057E0 RID: 22496
		private bool isFriend_;
	}
}
