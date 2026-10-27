using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB4 RID: 2996
	[NetMessage(EMessageId.OtherJoinSceneNotify)]
	public sealed class OtherJoinSceneNotify : IMessage<OtherJoinSceneNotify>, IMessage, IEquatable<OtherJoinSceneNotify>, IDeepCloneable<OtherJoinSceneNotify>, IBufferMessage
	{
		// Token: 0x060103DF RID: 66527 RVA: 0x0025EF50 File Offset: 0x0025D150
		[NullableContext(1)]
		public static OtherJoinSceneNotify Create()
		{
			return new OtherJoinSceneNotify();
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x060103E0 RID: 66528 RVA: 0x0025EF57 File Offset: 0x0025D157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x060103E1 RID: 66529 RVA: 0x0025EF5A File Offset: 0x0025D15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OtherJoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x060103E2 RID: 66530 RVA: 0x0025EF61 File Offset: 0x0025D161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify()
		{
		}

		// Token: 0x060103E3 RID: 66531 RVA: 0x0025EF69 File Offset: 0x0025D169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify(OtherJoinSceneNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103E4 RID: 66532 RVA: 0x0025EF9E File Offset: 0x0025D19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify Clone()
		{
			return new OtherJoinSceneNotify(this);
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x060103E5 RID: 66533 RVA: 0x0025EFA6 File Offset: 0x0025D1A6
		// (set) Token: 0x060103E6 RID: 66534 RVA: 0x0025EFAE File Offset: 0x0025D1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation PlayerInfo
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

		// Token: 0x060103E7 RID: 66535 RVA: 0x0025EFB7 File Offset: 0x0025D1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OtherJoinSceneNotify);
		}

		// Token: 0x060103E8 RID: 66536 RVA: 0x0025EFC5 File Offset: 0x0025D1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OtherJoinSceneNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103E9 RID: 66537 RVA: 0x0025EFF8 File Offset: 0x0025D1F8
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

		// Token: 0x060103EA RID: 66538 RVA: 0x0025F034 File Offset: 0x0025D234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103EB RID: 66539 RVA: 0x0025F041 File Offset: 0x0025D241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103EC RID: 66540 RVA: 0x0025F04A File Offset: 0x0025D24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103ED RID: 66541 RVA: 0x0025F07C File Offset: 0x0025D27C
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

		// Token: 0x060103EE RID: 66542 RVA: 0x0025F0BC File Offset: 0x0025D2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OtherJoinSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new ScenePlayerInformation();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103EF RID: 66543 RVA: 0x0025F110 File Offset: 0x0025D310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103F0 RID: 66544 RVA: 0x0025F11C File Offset: 0x0025D31C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new ScenePlayerInformation();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x04006761 RID: 26465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006762 RID: 26466
		public const int PlayerInfoFieldNumber = 7;

		// Token: 0x04006763 RID: 26467
		private ScenePlayerInformation playerInfo_;
	}
}
