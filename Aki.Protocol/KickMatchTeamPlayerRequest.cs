using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086E RID: 2158
	[NetMessage(EMessageId.KickMatchTeamPlayerRequest)]
	public sealed class KickMatchTeamPlayerRequest : IMessage<KickMatchTeamPlayerRequest>, IMessage, IEquatable<KickMatchTeamPlayerRequest>, IDeepCloneable<KickMatchTeamPlayerRequest>, IBufferMessage
	{
		// Token: 0x0600C08A RID: 49290 RVA: 0x001C9E30 File Offset: 0x001C8030
		[NullableContext(1)]
		public static KickMatchTeamPlayerRequest Create()
		{
			return new KickMatchTeamPlayerRequest();
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600C08B RID: 49291 RVA: 0x001C9E37 File Offset: 0x001C8037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600C08C RID: 49292 RVA: 0x001C9E3A File Offset: 0x001C803A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickMatchTeamPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x001C9E41 File Offset: 0x001C8041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest()
		{
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x001C9E49 File Offset: 0x001C8049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest(KickMatchTeamPlayerRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x001C9E6E File Offset: 0x001C806E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerRequest Clone()
		{
			return new KickMatchTeamPlayerRequest(this);
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600C090 RID: 49296 RVA: 0x001C9E76 File Offset: 0x001C8076
		// (set) Token: 0x0600C091 RID: 49297 RVA: 0x001C9E7E File Offset: 0x001C807E
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

		// Token: 0x0600C092 RID: 49298 RVA: 0x001C9E87 File Offset: 0x001C8087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickMatchTeamPlayerRequest);
		}

		// Token: 0x0600C093 RID: 49299 RVA: 0x001C9E95 File Offset: 0x001C8095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickMatchTeamPlayerRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C094 RID: 49300 RVA: 0x001C9EC4 File Offset: 0x001C80C4
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

		// Token: 0x0600C095 RID: 49301 RVA: 0x001C9F03 File Offset: 0x001C8103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C096 RID: 49302 RVA: 0x001C9F10 File Offset: 0x001C8110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C097 RID: 49303 RVA: 0x001C9F19 File Offset: 0x001C8119
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

		// Token: 0x0600C098 RID: 49304 RVA: 0x001C9F4C File Offset: 0x001C814C
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

		// Token: 0x0600C099 RID: 49305 RVA: 0x001C9F8A File Offset: 0x001C818A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickMatchTeamPlayerRequest other)
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

		// Token: 0x0600C09A RID: 49306 RVA: 0x001C9FBB File Offset: 0x001C81BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C09B RID: 49307 RVA: 0x001C9FC4 File Offset: 0x001C81C4
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

		// Token: 0x04005401 RID: 21505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005402 RID: 21506
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04005403 RID: 21507
		private int playerId_;
	}
}
