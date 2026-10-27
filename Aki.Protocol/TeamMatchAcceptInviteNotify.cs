using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001324 RID: 4900
	[NetMessage(EMessageId.TeamMatchAcceptInviteNotify)]
	public sealed class TeamMatchAcceptInviteNotify : IMessage<TeamMatchAcceptInviteNotify>, IMessage, IEquatable<TeamMatchAcceptInviteNotify>, IDeepCloneable<TeamMatchAcceptInviteNotify>, IBufferMessage
	{
		// Token: 0x0601A0A1 RID: 106657 RVA: 0x003C87DD File Offset: 0x003C69DD
		[NullableContext(1)]
		public static TeamMatchAcceptInviteNotify Create()
		{
			return new TeamMatchAcceptInviteNotify();
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x0601A0A2 RID: 106658 RVA: 0x003C87E4 File Offset: 0x003C69E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x0601A0A3 RID: 106659 RVA: 0x003C87E7 File Offset: 0x003C69E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteNotify.Descriptor;
			}
		}

		// Token: 0x0601A0A4 RID: 106660 RVA: 0x003C87EE File Offset: 0x003C69EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify()
		{
		}

		// Token: 0x0601A0A5 RID: 106661 RVA: 0x003C87F6 File Offset: 0x003C69F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify(TeamMatchAcceptInviteNotify other) : this()
		{
			this.acceptResult_ = other.acceptResult_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0A6 RID: 106662 RVA: 0x003C8827 File Offset: 0x003C6A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify Clone()
		{
			return new TeamMatchAcceptInviteNotify(this);
		}

		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x0601A0A7 RID: 106663 RVA: 0x003C882F File Offset: 0x003C6A2F
		// (set) Token: 0x0601A0A8 RID: 106664 RVA: 0x003C8837 File Offset: 0x003C6A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchAcceptInviteResult AcceptResult
		{
			get
			{
				return this.acceptResult_;
			}
			set
			{
				this.acceptResult_ = value;
			}
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x0601A0A9 RID: 106665 RVA: 0x003C8840 File Offset: 0x003C6A40
		// (set) Token: 0x0601A0AA RID: 106666 RVA: 0x003C8848 File Offset: 0x003C6A48
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

		// Token: 0x0601A0AB RID: 106667 RVA: 0x003C8851 File Offset: 0x003C6A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteNotify);
		}

		// Token: 0x0601A0AC RID: 106668 RVA: 0x003C885F File Offset: 0x003C6A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteNotify other)
		{
			return other != null && (other == this || (this.AcceptResult == other.AcceptResult && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0AD RID: 106669 RVA: 0x003C88A0 File Offset: 0x003C6AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num ^= this.AcceptResult.GetHashCode();
			}
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

		// Token: 0x0601A0AE RID: 106670 RVA: 0x003C88FE File Offset: 0x003C6AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0AF RID: 106671 RVA: 0x003C890B File Offset: 0x003C6B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0B0 RID: 106672 RVA: 0x003C8914 File Offset: 0x003C6B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.AcceptResult);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0B1 RID: 106673 RVA: 0x003C8970 File Offset: 0x003C6B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AcceptResult);
			}
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

		// Token: 0x0601A0B2 RID: 106674 RVA: 0x003C89C8 File Offset: 0x003C6BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchAcceptInviteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				this.AcceptResult = other.AcceptResult;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0B3 RID: 106675 RVA: 0x003C8A18 File Offset: 0x003C6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0B4 RID: 106676 RVA: 0x003C8A24 File Offset: 0x003C6C24
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
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.AcceptResult = (EMatchAcceptInviteResult)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400981C RID: 38940
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400981D RID: 38941
		public const int AcceptResultFieldNumber = 10;

		// Token: 0x0400981E RID: 38942
		private EMatchAcceptInviteResult acceptResult_;

		// Token: 0x0400981F RID: 38943
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04009820 RID: 38944
		private int playerId_;
	}
}
