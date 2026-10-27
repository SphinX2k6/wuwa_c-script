using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045A RID: 1114
	[NetMessage(EMessageId.EnterMatchTeamNotify)]
	public sealed class EnterMatchTeamNotify : IMessage<EnterMatchTeamNotify>, IMessage, IEquatable<EnterMatchTeamNotify>, IDeepCloneable<EnterMatchTeamNotify>, IBufferMessage
	{
		// Token: 0x06006A80 RID: 27264 RVA: 0x001011F1 File Offset: 0x000FF3F1
		[NullableContext(1)]
		public static EnterMatchTeamNotify Create()
		{
			return new EnterMatchTeamNotify();
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x001011F8 File Offset: 0x000FF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x001011FB File Offset: 0x000FF3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x00101202 File Offset: 0x000FF402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify()
		{
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x0010120A File Offset: 0x000FF40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify(EnterMatchTeamNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x0010123F File Offset: 0x000FF43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify Clone()
		{
			return new EnterMatchTeamNotify(this);
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x00101247 File Offset: 0x000FF447
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x0010124F File Offset: 0x000FF44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00101258 File Offset: 0x000FF458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchTeamNotify);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00101266 File Offset: 0x000FF466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0010129C File Offset: 0x000FF49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x001012D8 File Offset: 0x000FF4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x001012E5 File Offset: 0x000FF4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x001012EE File Offset: 0x000FF4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x00101320 File Offset: 0x000FF520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00101360 File Offset: 0x000FF560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMatchTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new MatchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x001013B4 File Offset: 0x000FF5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x001013C0 File Offset: 0x000FF5C0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new MatchPlayerInfo();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x04003A52 RID: 14930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A53 RID: 14931
		public const int PlayerInfoFieldNumber = 6;

		// Token: 0x04003A54 RID: 14932
		private MatchPlayerInfo playerInfo_;
	}
}
