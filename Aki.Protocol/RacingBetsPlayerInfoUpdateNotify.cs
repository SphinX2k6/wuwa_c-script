using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E60 RID: 3680
	[NetMessage(EMessageId.RacingBetsPlayerInfoUpdateNotify)]
	public sealed class RacingBetsPlayerInfoUpdateNotify : IMessage<RacingBetsPlayerInfoUpdateNotify>, IMessage, IEquatable<RacingBetsPlayerInfoUpdateNotify>, IDeepCloneable<RacingBetsPlayerInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06013CD0 RID: 81104 RVA: 0x002E2F27 File Offset: 0x002E1127
		[NullableContext(1)]
		public static RacingBetsPlayerInfoUpdateNotify Create()
		{
			return new RacingBetsPlayerInfoUpdateNotify();
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x06013CD1 RID: 81105 RVA: 0x002E2F2E File Offset: 0x002E112E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x06013CD2 RID: 81106 RVA: 0x002E2F31 File Offset: 0x002E1131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013CD3 RID: 81107 RVA: 0x002E2F38 File Offset: 0x002E1138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify()
		{
		}

		// Token: 0x06013CD4 RID: 81108 RVA: 0x002E2F40 File Offset: 0x002E1140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify(RacingBetsPlayerInfoUpdateNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CD5 RID: 81109 RVA: 0x002E2F75 File Offset: 0x002E1175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify Clone()
		{
			return new RacingBetsPlayerInfoUpdateNotify(this);
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x06013CD6 RID: 81110 RVA: 0x002E2F7D File Offset: 0x002E117D
		// (set) Token: 0x06013CD7 RID: 81111 RVA: 0x002E2F85 File Offset: 0x002E1185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo PlayerInfo
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

		// Token: 0x06013CD8 RID: 81112 RVA: 0x002E2F8E File Offset: 0x002E118E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoUpdateNotify);
		}

		// Token: 0x06013CD9 RID: 81113 RVA: 0x002E2F9C File Offset: 0x002E119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CDA RID: 81114 RVA: 0x002E2FD0 File Offset: 0x002E11D0
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

		// Token: 0x06013CDB RID: 81115 RVA: 0x002E300C File Offset: 0x002E120C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CDC RID: 81116 RVA: 0x002E3019 File Offset: 0x002E1219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CDD RID: 81117 RVA: 0x002E3022 File Offset: 0x002E1222
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

		// Token: 0x06013CDE RID: 81118 RVA: 0x002E3054 File Offset: 0x002E1254
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

		// Token: 0x06013CDF RID: 81119 RVA: 0x002E3094 File Offset: 0x002E1294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPlayerInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new RacingBetPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CE0 RID: 81120 RVA: 0x002E30E8 File Offset: 0x002E12E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CE1 RID: 81121 RVA: 0x002E30F4 File Offset: 0x002E12F4
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
						this.PlayerInfo = new RacingBetPlayerInfo();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x040079A0 RID: 31136
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079A1 RID: 31137
		public const int PlayerInfoFieldNumber = 6;

		// Token: 0x040079A2 RID: 31138
		private RacingBetPlayerInfo playerInfo_;
	}
}
