using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000932 RID: 2354
	[NetMessage(EMessageId.LobbyQueryPlayersRequest)]
	public sealed class LobbyQueryPlayersRequest : IMessage<LobbyQueryPlayersRequest>, IMessage, IEquatable<LobbyQueryPlayersRequest>, IDeepCloneable<LobbyQueryPlayersRequest>, IBufferMessage
	{
		// Token: 0x0600CFB8 RID: 53176 RVA: 0x001E9434 File Offset: 0x001E7634
		[NullableContext(1)]
		public static LobbyQueryPlayersRequest Create()
		{
			return new LobbyQueryPlayersRequest();
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600CFB9 RID: 53177 RVA: 0x001E943B File Offset: 0x001E763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600CFBA RID: 53178 RVA: 0x001E943E File Offset: 0x001E763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQueryPlayersRequest.Descriptor;
			}
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x001E9445 File Offset: 0x001E7645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest()
		{
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x001E944D File Offset: 0x001E764D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest(LobbyQueryPlayersRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFBD RID: 53181 RVA: 0x001E9472 File Offset: 0x001E7672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersRequest Clone()
		{
			return new LobbyQueryPlayersRequest(this);
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600CFBE RID: 53182 RVA: 0x001E947A File Offset: 0x001E767A
		// (set) Token: 0x0600CFBF RID: 53183 RVA: 0x001E9482 File Offset: 0x001E7682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x0600CFC0 RID: 53184 RVA: 0x001E948B File Offset: 0x001E768B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQueryPlayersRequest);
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x001E9499 File Offset: 0x001E7699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQueryPlayersRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x001E94C8 File Offset: 0x001E76C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x001E9507 File Offset: 0x001E7707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x001E9514 File Offset: 0x001E7714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFC5 RID: 53189 RVA: 0x001E951D File Offset: 0x001E771D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x001E9550 File Offset: 0x001E7750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x001E958E File Offset: 0x001E778E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyQueryPlayersRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFC8 RID: 53192 RVA: 0x001E95BF File Offset: 0x001E77BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFC9 RID: 53193 RVA: 0x001E95C8 File Offset: 0x001E77C8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040057E7 RID: 22503
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E8 RID: 22504
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x040057E9 RID: 22505
		private int playerId_;
	}
}
