using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000443 RID: 1091
	[NetMessage(EMessageId.EnterMatchTeamNotify)]
	public sealed class EnterMatchTeamNotify : IMessage<EnterMatchTeamNotify>, IMessage, IEquatable<EnterMatchTeamNotify>, IDeepCloneable<EnterMatchTeamNotify>, IBufferMessage
	{
		// Token: 0x060068F2 RID: 26866 RVA: 0x000FE189 File Offset: 0x000FC389
		[NullableContext(1)]
		public static EnterMatchTeamNotify Create()
		{
			return new EnterMatchTeamNotify();
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x000FE190 File Offset: 0x000FC390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060068F4 RID: 26868 RVA: 0x000FE193 File Offset: 0x000FC393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x000FE19A File Offset: 0x000FC39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify()
		{
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x000FE1A2 File Offset: 0x000FC3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify(EnterMatchTeamNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x000FE1D7 File Offset: 0x000FC3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchTeamNotify Clone()
		{
			return new EnterMatchTeamNotify(this);
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x060068F8 RID: 26872 RVA: 0x000FE1DF File Offset: 0x000FC3DF
		// (set) Token: 0x060068F9 RID: 26873 RVA: 0x000FE1E7 File Offset: 0x000FC3E7
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

		// Token: 0x060068FA RID: 26874 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchTeamNotify);
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x000FE1FE File Offset: 0x000FC3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x000FE234 File Offset: 0x000FC434
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

		// Token: 0x060068FD RID: 26877 RVA: 0x000FE270 File Offset: 0x000FC470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x000FE27D File Offset: 0x000FC47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x000FE286 File Offset: 0x000FC486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x000FE2B8 File Offset: 0x000FC4B8
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

		// Token: 0x06006901 RID: 26881 RVA: 0x000FE2F8 File Offset: 0x000FC4F8
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

		// Token: 0x06006902 RID: 26882 RVA: 0x000FE34C File Offset: 0x000FC54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x000FE358 File Offset: 0x000FC558
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
				if (num != 98U)
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

		// Token: 0x04003A40 RID: 14912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A41 RID: 14913
		public const int PlayerInfoFieldNumber = 12;

		// Token: 0x04003A42 RID: 14914
		private MatchPlayerInfo playerInfo_;
	}
}
